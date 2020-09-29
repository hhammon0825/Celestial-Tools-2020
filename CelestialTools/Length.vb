Option Strict Off
Option Explicit On
Friend Class FormLength
    Inherits System.Windows.Forms.Form
    Dim LengthDegLSpherefeet, LengthDegLSpherenm, LengthDegLSpheremeters, LengthDegLSpheresm As Single
    Dim LengthDegLoSpherefeet, LengthDegLoSpherenm, LengthDegLoSpheremeters, LengthDegLoSpheresm As Single
    Dim LengthDegLWGS84feet, LengthDegLWGS84nm, LengthDegLWGS84meters, LengthDegLWGS84sm As Single
    Dim LengthDegLoWGS84feet, LengthDegLoWGS84nm, LengthDegLoWGS84meters, LengthDegLoWGS84sm As Single

    Dim LatIn, LatInRad, Pi As Double
    Dim fnumeral As String
    Private FormLengthLoaded As Boolean = False
    Private FileTextLine As String = vbNullString

    Private Sub FormLength_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtLDeg.Clear()
        txtLDeg.Text = "0"
        'txtLMin.Clear()
        txtLMin.Text = "0"
        FormLengthLoaded = True
        WriteLengthCSV()
        Dim FName As String = "./Graphics/Length1Degree" & ".csv"
        Dim tablename As String = "export"
        Dim DataSet As DataSet = New DataSet()
        DataSet.Tables.Add(tablename)
        DataSet.Tables(tablename).Columns.Add("Latitude")
        DataSet.Tables(tablename).Columns.Add("Lat Feet")
        DataSet.Tables(tablename).Columns.Add("Lat Meter")
        DataSet.Tables(tablename).Columns.Add("Lat StatMile")
        DataSet.Tables(tablename).Columns.Add("Lat NautMile")
        DataSet.Tables(tablename).Columns.Add("Lo  Feet")
        DataSet.Tables(tablename).Columns.Add("Lo  Meter")
        DataSet.Tables(tablename).Columns.Add("Lo  StatMile")
        DataSet.Tables(tablename).Columns.Add("Lo  NautMile")
        Dim SR As System.IO.StreamReader = New System.IO.StreamReader(FName)
        Dim allData As String = SR.ReadToEnd()
        Dim rows As String() = allData.Split(vbCrLf) '("\r".ToCharArray())

        For Each r As String In rows
            Dim items As String() = r.Split(",")
            If items(0) <> vbLf Then
                DataSet.Tables(tablename).Rows.Add(items)
            End If

        Next
        DataGridView1.DataSource = DataSet.Tables(0).DefaultView

        Exit Sub
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Calculate()
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Calculate()

        'Pi = 4 * System.Math.Atan(1.0#)
        Pi = System.Math.PI
        txtLength.Clear()

        If txtLDeg.Text = "" Then
            txtLDeg.Text = "0"
        End If

        If txtLMin.Text = "" Then
            txtLMin.Text = "0"
        End If

        LatIn = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60)
        LatInRad = LatIn * (Pi / 180)

        ' 1 degree of latitude spherical is constant at all latitudes so the next 4 statements remain the same no matter what latitude was entered
        LengthDegLSpherenm = 60
        LengthDegLSpheremeters = LengthDegLSpherenm * 1852
        LengthDegLSpherefeet = LengthDegLSpheremeters * 3.2808399
        LengthDegLSpheresm = LengthDegLSpherefeet / 5280
        ' now the 1 degree of lat or long from here are calculated using latitude angle entered converted to radians
        LengthDegLoSpherenm = 60 * System.Math.Cos(LatInRad)
        LengthDegLoSpheremeters = LengthDegLoSpherenm * 1852
        LengthDegLoSpherefeet = LengthDegLoSpheremeters * 3.2808399
        LengthDegLoSpheresm = LengthDegLoSpherefeet / 5280

        LengthDegLWGS84meters = 111132.92 - 559.82 * System.Math.Cos(2 * LatInRad) + 1.175 * System.Math.Cos(4 * LatInRad) - 0.0023 * System.Math.Cos(6 * LatInRad)
        LengthDegLWGS84feet = LengthDegLWGS84meters * 3.2808399
        LengthDegLWGS84sm = LengthDegLWGS84feet / 5280
        LengthDegLWGS84nm = LengthDegLWGS84meters / 1852

        LengthDegLoWGS84meters = 111412.84 * System.Math.Cos(LatInRad) - 93.5 * System.Math.Cos(3 * LatInRad) + 0.118 * System.Math.Cos(5 * LatInRad)
        LengthDegLoWGS84feet = LengthDegLoWGS84meters * 3.2808399
        LengthDegLoWGS84sm = LengthDegLoWGS84feet / 5280
        LengthDegLoWGS84nm = LengthDegLoWGS84meters / 1852

        txtLength.AppendText(vbNewLine & vbTab & "At Latitude: " & Strings.Format(Convert.ToInt32(txtLDeg.Text), "#0") _
                             & Chr(176) & Space(1) & Strings.Format(Convert.ToDouble(txtLMin.Text), "#0.0") & "'" & vbNewLine & vbNewLine)
        txtLength.AppendText(vbTab & "Length of 1" & Chr(176) & " of LATITUDE:" & vbNewLine)
        txtLength.AppendText(vbTab & vbTab & vbTab & "Sphere" & vbTab & "WGS84 Spheroid" & vbNewLine)
        txtLength.AppendText(vbTab & "Feet" & vbTab & vbTab & Strings.Format(LengthDegLSpherefeet, "#,0") & vbTab & Strings.Format(LengthDegLWGS84feet, "#,0") & vbNewLine)
        txtLength.AppendText(vbTab & "Meters" & vbTab & vbTab & Strings.Format(LengthDegLSpheremeters, "#,0") & vbTab & Strings.Format(LengthDegLWGS84meters, "#,0") & vbNewLine)
        txtLength.AppendText(vbTab & "Statute Miles" & vbTab & Strings.Format(LengthDegLSpheresm, "#0.000") & vbTab & Strings.Format(LengthDegLWGS84sm, "#0.000") & vbNewLine)
        txtLength.AppendText(vbTab & "Nautical Miles" & vbTab & Strings.Format(LengthDegLSpherenm, "#0.000") & vbTab & Strings.Format(LengthDegLWGS84nm, "#0.000") & vbNewLine & vbNewLine)
        txtLength.AppendText(vbTab & "Length of 1" & Chr(176) & " of LONGITUDE:" & vbNewLine)
        txtLength.AppendText(vbTab & vbTab & vbTab & "Sphere" & vbTab & "WGS84 Spheroid" & vbNewLine)
        txtLength.AppendText(vbTab & "Feet" & vbTab & vbTab & Strings.Format(LengthDegLoSpherefeet, "#,0") & vbTab & Strings.Format(LengthDegLoWGS84feet, "#,0") & vbNewLine)
        txtLength.AppendText(vbTab & "Meters" & vbTab & vbTab & Strings.Format(LengthDegLoSpheremeters, "#,0") & vbTab & Strings.Format(LengthDegLoWGS84meters, "#,0") & vbNewLine)
        txtLength.AppendText(vbTab & "Statute Miles" & vbTab & Strings.Format(LengthDegLoSpheresm, "#0.000") & vbTab & Strings.Format(LengthDegLoWGS84sm, "#0.000") & vbNewLine)
        txtLength.AppendText(vbTab & "Nautical Miles" & vbTab & Strings.Format(LengthDegLoSpherenm, "#0.000") & vbTab & Strings.Format(LengthDegLoWGS84nm, "#0.000") & vbNewLine)

    End Sub

    Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
        If FormLengthLoaded = False Then Exit Sub
        If Val(txtLDeg.Text) <> 90 Then
            txtLMin.Enabled = True
        End If
        If Val(txtLDeg.Text) = 90 Then
            txtLMin.Text = "0.0"
            txtLMin.Enabled = False
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If

        txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLDeg.Text) > 90 Then
            txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtLDeg.SelectAll()
            ErrorMsgBox("Out of Range - Latitude Degree value must be 0 thru 90")
            Exit Sub
        End If
        If (Val(txtLDeg.Text) = 90 And Val(txtLMin.Text) <> 0) Then
            txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtLDeg.SelectAll()
            ErrorMsgBox("Out of Range - Latitude Minutes value must be 0 if Degrees is 90")
            Exit Sub
        End If
        If Val(txtLDeg.Text) < 90 Then
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtLDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLDeg.KeyPress
        If FormLengthLoaded = False Then Exit Sub
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                ErrorMsgBox("Invalid Latitude Degree")
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLDeg.Validating
        If FormLengthLoaded = False Then Exit Sub
        'Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtLDeg.Text) > 90 Then
        '    KeepFocus = True
        'End If
        'eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.Enter
        If FormLengthLoaded = False Then Exit Sub
        'txtLDeg.SelectAll()

    End Sub

    Private Sub txtLMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLMin.TextChanged
        If FormLengthLoaded = False Then Exit Sub
        'txtLMin.ForeColor = &H80000008
        txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLMin.Text) > 59.9 Then
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtLMin.SelectAll()
            ErrorMsgBox("Out of Range - - Latitude Minutes value must be 0 thru 59.9")
            Exit Sub
        End If
    End Sub

    Private Sub txtLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLMin.KeyPress
        If FormLengthLoaded = False Then Exit Sub
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
                ErrorMsgBox("Invalid Latitude Minute")
                Exit Sub
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLMin.Validating
        If FormLengthLoaded = False Then Exit Sub
        'Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtLMin.Text) > 59.9 Then
        '    KeepFocus = True
        'End If
        'eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLMin.Enter
        If FormLengthLoaded = False Then Exit Sub
        'txtLMin.SelectAll()

    End Sub

    Private Sub FormLength_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
    Private Function CalculateForFile(ByVal LatParmIn As Double) As String
        'Pi = 4 * System.Math.Atan(1.0#)

        Pi = System.Math.PI
        txtLength.Clear()

        'LatIn = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60)
        LatInRad = LatParmIn * (Pi / 180)

        ' 1 degree of latitude spherical is constant at all latitudes so the next 4 statements remain the same no matter what latitude was entered
        LengthDegLSpherenm = 60
        LengthDegLSpheremeters = LengthDegLSpherenm * 1852
        LengthDegLSpherefeet = LengthDegLSpheremeters * 3.2808399
        LengthDegLSpheresm = LengthDegLSpherefeet / 5280
        ' now the 1 degree of lat or long from here are calculated using latitude angle entered converted to radians
        LengthDegLoSpherenm = 60 * System.Math.Cos(LatInRad)
        LengthDegLoSpheremeters = LengthDegLoSpherenm * 1852
        LengthDegLoSpherefeet = LengthDegLoSpheremeters * 3.2808399
        LengthDegLoSpheresm = LengthDegLoSpherefeet / 5280

        LengthDegLWGS84meters = 111132.92 - 559.82 * System.Math.Cos(2 * LatInRad) + 1.175 * System.Math.Cos(4 * LatInRad) - 0.0023 * System.Math.Cos(6 * LatInRad)
        LengthDegLWGS84feet = LengthDegLWGS84meters * 3.2808399
        LengthDegLWGS84sm = LengthDegLWGS84feet / 5280
        LengthDegLWGS84nm = LengthDegLWGS84meters / 1852

        LengthDegLoWGS84meters = 111412.84 * System.Math.Cos(LatInRad) - 93.5 * System.Math.Cos(3 * LatInRad) + 0.118 * System.Math.Cos(5 * LatInRad)
        LengthDegLoWGS84feet = LengthDegLoWGS84meters * 3.2808399
        LengthDegLoWGS84sm = LengthDegLoWGS84feet / 5280
        LengthDegLoWGS84nm = LengthDegLoWGS84meters / 1852
        FileTextLine = LatParmIn.ToString("#0") & "," &
                             LengthDegLSpherefeet.ToString("#0") & "," &
                            LengthDegLSpheremeters.ToString("#0") & "," &
                            LengthDegLSpheresm.ToString("#0.000") & "," &
                            LengthDegLSpherenm.ToString("#0.000") & "," &
                            LengthDegLoSpherefeet.ToString("#0") & "," &
                            LengthDegLoSpheremeters.ToString("#0") & "," &
                            LengthDegLoSpheresm.ToString("#0.000") & "," &
                            LengthDegLoSpherenm.ToString("#0.000")
        'LengthDegLWGS84feet.ToString("#.0") & "," &
        'LengthDegLWGS84meters.ToString("#.0") & "," &
        'LengthDegLWGS84sm.ToString("#0.000") & "," &
        'LengthDegLWGS84nm.ToString("#0.000") & "," &
        'LengthDegLoWGS84feet.ToString("#0") & "," &
        'LengthDegLoWGS84meters.ToString("#0") & "," &
        'LengthDegLoWGS84sm.ToString("#0.000") & "," &
        'LengthDegLoWGS84nm.ToString("#0.000")
        Return FileTextLine
        Exit Function
    End Function
    Private Sub WriteLengthCSV()
        Dim limit As Integer = 0
        Dim FName As String = "./Graphics/Length1Degree" & ".csv"
        Dim objWriter As New System.IO.StreamWriter(FName, False)
        'objWriter.WriteLine("Latitude, LatDegSphFeet, LatDegSphMeter, LatDegSphSM, LatDegSphNM, LongDegSphFeet, LongDegSphMeter, LongDegSphSM, LongDegSphNM") ' LatDegWGS84Feet, LatDegWGS84Meter, LatDegWGS84SM, LatDegWGS84NM, LongDegWGS84Feet, LongDegWGS84Meter, LongDegWGS84SM, LongDegWGS84NM") ' write header line with column names in it
        Do While limit <= 89

            objWriter.WriteLine(CalculateForFile(Convert.ToDouble(limit)))
            limit += 5
        Loop
        limit = 89
        objWriter.WriteLine(CalculateForFile(Convert.ToDouble(limit)))
        objWriter.Close()
        objWriter.Dispose()
        Exit Sub
    End Sub
End Class