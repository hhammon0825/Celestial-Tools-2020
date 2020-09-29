Imports System.Data.SqlTypes

Public Class ZTInfo
    Public InvokedbyDeckLog As Boolean = False
    Private LocACollection As ObjectModel.ReadOnlyCollection(Of TimeZoneInfo)
    Private LongTZInfo As TimeZoneInfo()
    ReadOnly ZeroVal As String = "0"

    ReadOnly tablename As String = "Table1"
    Private DataSet1 As DataSet
    ReadOnly HdrStr As String() = {"Display Name", "UTC Hours", "UTC Minutes", "Supports DST", "DST Name"}
    ReadOnly NullStr As String() = {vbNullString, vbNullString, vbNullString, vbNullString, vbNullString}

    Private Sub ZTInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocACollection = TimeZoneInfo.GetSystemTimeZones
        ReDim LongTZInfo(0)
        For Each TZT As TimeZoneInfo In LocACollection 'TimeZoneInfo.GetSystemTimeZones
            Dim unused = cboLocAZD.Items.Add(TZT)
            Dim unused1 = cboLocBZD.Items.Add(TZT)
        Next
        If InvokedbyDeckLog = False Then
            ClearFields()
        Else
            FillZTGrid()
            ' if ZT Info is invoked by DeckLog then the cboLoA abd cboLoB were set by DeckLog and should not be reset here - the add/subtract default of + is fine
            'cboLoA.SelectedIndex = 0
            'cboLoB.SelectedIndex = 0
            cboAddSub.SelectedIndex = 0
        End If

        Exit Sub
    End Sub
    Private Sub ClearFields()
        txtLoDegA.Text = ZeroVal
        txtLoMinA.Text = ZeroVal
        txtLoDegB.Text = ZeroVal
        txtLoMinB.Text = ZeroVal
        cboLoA.SelectedIndex = 0
        cboLoB.SelectedIndex = 0
        cboAddSub.SelectedIndex = 0
        DTLocA.Value = DateTime.Now
        DTResult.Value = DateTime.Now
        DTLocAUTC.Value = DateTime.Now
        txtLocAZTInfo.Clear()
        txtLocBZTInfo.Clear()
        DT1Days.Value = 0
        DT1Hours.Value = 0
        DT1Minutes.Value = 0
        FillZTGrid()
        Exit Sub
    End Sub
    Private Function CnvtLongtoTZInfo(ByVal LongIn As Double) As TimeZoneInfo()
        Dim LongDegIn As Integer = Int(LongIn)
        Dim LongMinIN As Double = LongIn - LongDegIn
        Dim ZDLongIn As Integer = System.Math.Round(LongIn / 15, 0, MidpointRounding.AwayFromZero)
        ReDim LongTZInfo(0)

        For Each TZT As TimeZoneInfo In LocACollection 'TimeZoneInfo.GetSystemTimeZones
            If TZT.BaseUtcOffset.Hours = ZDLongIn Then
                Dim UL As Integer = LongTZInfo.GetUpperBound(0)
                ReDim Preserve LongTZInfo(UL + 1)
                LongTZInfo(UL + 1) = TZT
            End If
        Next
        Return (LongTZInfo)
    End Function

    Private Sub FillZTGrid()
        DataSet1 = New DataSet()
        Dim unused = DataSet1.Tables.Add(tablename)
        DataSet1.DataSetName = tablename
        DGTZ.DataSource = DataSet1
        For i As Integer = 0 To UBound(HdrStr)
            Dim unused1 = DataSet1.Tables(tablename).Columns.Add(HdrStr(i))
            DataSet1.Tables(tablename).Columns(i).AllowDBNull = False
            DataSet1.Tables(tablename).Columns(i).DefaultValue = ""
        Next
        Dim unused2 = DataSet1.Tables(tablename).Rows.Add(NullStr)
        'DataSet1.Tables(tablename).Rows.RemoveAt(0)
        DGTZ.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGTZ.Columns.Count - 1
            DGTZ.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGTZ.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGTZ.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DGTZ.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        DGTZ.RowHeadersDefaultCellStyle.BackColor = Color.Yellow

        DataSet1.Tables(tablename).Clear()

        For Each TZ As TimeZoneInfo In LocACollection
            DataSet1.Tables(tablename).Rows.Add(TZ.DisplayName, TZ.BaseUtcOffset.Hours.ToString("00"), TZ.BaseUtcOffset.Minutes.ToString("00"),
                                                TZ.SupportsDaylightSavingTime.ToString, TZ.DaylightName)
        Next

        DGTZ.Refresh()
        Exit Sub

    End Sub
    Private Sub CbLocAZD_MouseEnter(sender As Object, e As EventArgs) Handles cboLocAZD.MouseEnter
        Dim TZList As TimeZoneInfo()
        Dim LoA As Double = Convert.ToDouble(txtLoDegA.Text) + Convert.ToDouble(txtLoMinA.Text) / 60
        If cboLoA.Text = "W" Then
            LoA = -LoA
        End If
        TZList = CnvtLongtoTZInfo(LoA)
        cboLocAZD.Items.Clear()

        For Each TZ As TimeZoneInfo In TZList
            If IsNothing(TZ) Then
                ' ignore first nothing entry in array
            Else
                Dim unused = cboLocAZD.Items.Add(TZ.DisplayName)
            End If

        Next
        cboLocAZD.SelectedIndex = 0
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub CbLocBZone_MouseEnter(sender As Object, e As EventArgs) Handles cboLocBZD.MouseEnter
        Dim TZList As TimeZoneInfo()
        Dim LoB As Double = Convert.ToDouble(txtLoDegB.Text) + Convert.ToDouble(txtLoMinB.Text) / 60
        If cboLoB.Text = "W" Then
            LoB = -LoB
        End If
        TZList = CnvtLongtoTZInfo(LoB)
        cboLocBZD.Items.Clear()

        For Each TZ As TimeZoneInfo In TZList
            If IsNothing(TZ) Then
                ' ignore first nothing entry in array
            Else
                Dim unused = cboLocBZD.Items.Add(TZ.DisplayName)
            End If
        Next
        cboLocBZD.SelectedIndex = 0
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If InvokedbyDeckLog = True Then
            InvokedbyDeckLog = False
            DeckLogUpdate.DestDTUpdatedbyZTInfo = True

        End If

        Me.Close()
        Exit Sub
    End Sub

    Private Sub BtnReloadZT_Click(sender As Object, e As EventArgs) Handles btnReloadZT.Click

        LocACollection = TimeZoneInfo.GetSystemTimeZones
        FillZTGrid()
        Exit Sub
    End Sub
    Private Function FindZTID(ByVal StrIn) As String
        For Each TZ As TimeZoneInfo In LocACollection
            If TZ.DisplayName = StrIn Then
                Return TZ.Id
            End If
        Next
        Return "-1"
    End Function

    Private Sub CboLocAZD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocAZD.SelectedIndexChanged
        txtLocAZTInfo.Clear()
        Dim TZA As TimeZoneInfo = System.TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocAZD.Text))
        txtLocAZTInfo.AppendText("UTC Offset Hr: " & TZA.BaseUtcOffset.Hours.ToString("00") & " Min: " & TZA.BaseUtcOffset.Minutes.ToString("00") & vbCrLf &
                                    "Standard Name: " & TZA.StandardName.ToString & vbCrLf &
                                 "DST Support: " & TZA.SupportsDaylightSavingTime.ToString & vbCrLf &
                                 "UTC Offset: " & TZA.GetUtcOffset(DTLocA.Value).ToString)

        Dim DTTemp As DateTime = New DateTime(DTLocA.Value.Ticks, DateTimeKind.Unspecified)
        DTLocAUTC.Value = System.TimeZoneInfo.ConvertTimeToUtc(DTTemp, TZA)
        If cboLocBZD.Text <> "" Then
            PerformEditClick()
        End If
    End Sub

    Private Sub CboLocBZD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocBZD.SelectedIndexChanged
        txtLocBZTInfo.Clear()
        Dim TZB As TimeZoneInfo = System.TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocBZD.Text))
        txtLocBZTInfo.AppendText("UTC Offset Hr: " & TZB.BaseUtcOffset.Hours.ToString("00") & " Min: " & TZB.BaseUtcOffset.Minutes.ToString("00") & vbCrLf &
                                 "Standard Name: " & TZB.StandardName.ToString & vbCrLf &
                                 "DST Support: " & TZB.SupportsDaylightSavingTime.ToString & vbCrLf &
                                 "UTC Offset: " & TZB.GetUtcOffset(DTResult.Value).ToString)
        PerformEditClick()
        Exit Sub
    End Sub
    Private Function DestDT(ByVal TZAIn As TimeZoneInfo, ByVal DTAIn As DateTime, ByVal TSIn As TimeSpan, ByVal TZBIn As TimeZoneInfo)
        If cboAddSub.Text = "+" Then
            Dim DTTSAdd As DateTime = New DateTime(DTAIn.AddMinutes(TSIn.TotalMinutes).Ticks, DateTimeKind.Unspecified)
            Return System.TimeZoneInfo.ConvertTime(DTTSAdd, TZAIn, TZBIn)
        Else
            Dim DTTSSubt As DateTime = New DateTime(DTAIn.AddMinutes(-1 * TSIn.TotalMinutes).Ticks, DateTimeKind.Unspecified)
            Return System.TimeZoneInfo.ConvertTime(DTTSSubt, TZAIn, TZBIn)
        End If
        Dim DTTSAdd1 As DateTime = New DateTime(DTAIn.AddMinutes(TSIn.TotalMinutes).Ticks, DateTimeKind.Unspecified)
        Return System.TimeZoneInfo.ConvertTime(DTTSAdd1, TZAIn, TZBIn)

    End Function

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        PerformEditClick()
        Exit Sub
    End Sub
    Private Sub PerformEditClick()
        If EditFields() = True Then
            Dim TS As TimeSpan = New TimeSpan(Convert.ToInt32(DT1Days.Value), Convert.ToInt32(DT1Hours.Value), Convert.ToInt32(DT1Minutes.Value), 0)
            Dim TZA As TimeZoneInfo = System.TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocAZD.Text))
            Dim TZB As TimeZoneInfo = System.TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocBZD.Text))
            DTResult.Value = DestDT(TZA, DTLocA.Value, TS, TZB)
            If InvokedbyDeckLog = True Then
                DeckLogUpdate.DestDTUpdatedbyZTInfo = True
                DeckLogUpdate.DestDTfromZTInfo = DTResult.Value
            End If
        End If
        Exit Sub
    End Sub
    Private Function EditFields() As Boolean
        If txtLoDegA.Text = vbNullString Or txtLoDegA.Text = "" Then
            ErrorMsgBox("Longitude Degrees must be entered")
            Return False
        End If
        If IsNumeric(txtLoDegA.Text) = False Then
            ErrorMsgBox("Longitude Degrees must be numeric between 0 and 89")
            Return False
        End If
        Try
            Dim LoDegI As Integer = Convert.ToInt32(txtLoDegA.Text)
            If LoDegI < 0 Or LoDegI > 180 Then
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180")
            Return False
        End Try

        If txtLoMinA.Text = vbNullString Or txtLoMinA.Text = "" Then
            ErrorMsgBox("Longitude Minutes must be entered")
            Return False
        End If
        If IsNumeric(txtLoMinA.Text) = False Then
            ErrorMsgBox("Longitude Minutes be numeric between 0 and 59.9")
            Return False
        End If
        Try
            Dim LoMinI As Double = Convert.ToDouble(txtLoMinA.Text)
            Dim LoEW As String = cboLoA.Text
            If LoMinI < 0 Or LoMinI > 59.9 Then
                ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9")
            Return False
        End Try

        If txtLoDegB.Text = vbNullString Or txtLoDegB.Text = "" Then
            ErrorMsgBox("Longitude Degrees must be entered")
            Return False
        End If
        If IsNumeric(txtLoDegB.Text) = False Then
            ErrorMsgBox("Longitude Degrees must be numeric between 0 and 89")
            Return False
        End If
        Try
            Dim LoDegI As Integer = Convert.ToInt32(txtLoDegB.Text)
            If LoDegI < 0 Or LoDegI > 180 Then
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180")
            Return False
        End Try

        If txtLoMinB.Text = vbNullString Or txtLoMinB.Text = "" Then
            ErrorMsgBox("Longitude Minutes must be entered")
            Return False
        End If
        If IsNumeric(txtLoMinB.Text) = False Then
            ErrorMsgBox("Longitude Minutes be numeric between 0 and 59.9")
            Return False
        End If
        Try
            Dim LoMinI As Double = Convert.ToDouble(txtLoMinB.Text)
            Dim LoEW As String = cboLoA.Text
            If LoMinI < 0 Or LoMinI > 59.9 Then
                ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9")
            Return False
        End Try

        If cboLocAZD.Text = "" Then
            ErrorMsgBox("Time Zone selection is missing - Select a Time Zone and Proceed")
            Return False
        End If

        If cboLocBZD.Text = "" Then
            ErrorMsgBox("Time Zone selection is missing - Select a Time Zone and Proceed")
            Return False
        End If

        Return True
    End Function
    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        Dim unused = System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub BtnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        ClearFields()
        ReDim LongTZInfo(0)
        cboLocAZD.Items.Clear()
        cboLocBZD.Items.Clear()
        For Each TZT As TimeZoneInfo In LocACollection 'TimeZoneInfo.GetSystemTimeZones
            Dim unused = cboLocAZD.Items.Add(TZT)
            Dim unused1 = cboLocBZD.Items.Add(TZT)
        Next
        Exit Sub
    End Sub
End Class