Imports System.ComponentModel.DataAnnotations
Imports System.Deployment.Application
Imports System.Windows
Imports System.Windows.Controls.Primitives

Public Class DeckLogUpdate
    Private FName As String = "./DeckLog/"
    Private ReadError As Boolean = False
    Private FileLoading As Boolean = False
    Private InitialLoad As Boolean = False
    Private SelectedRow As Boolean = False
    'Private FileRead As Boolean = False
    Private SortingDG As Boolean = False
    Private IsUpdated As Boolean = False
    Private SLOpenFName As String = ""
    Private ReadOnly tablename As String = "Table1"
    Private DataSet1 As DataSet
    Private DestEstArrival As DateTime
    Private DRAdvanceMode As Boolean = False
    'Private DRAdvanceDGSave As Integer = 0
    Private DTChanged As Boolean = False
    Public DestDTUpdatedbyZTInfo As Boolean = False
    Public DestDTfromZTInfo As DateTime
    Private AutoGCRMode As Boolean = False
    Private ReadOnly GCRThreshhold As Integer = 500 'Per documentation at 500 nm in distance it makes sense to plot a Great Circle Route instead of a Rhumb Line
    Private DTFormatString As String = "yyyy/MM/dd HH:mm:ss"
    Private MaxDate As Date = New Date(2999, 12, 31, 23, 59, 59)
    Private DefaultDT As DateTime = New Date(100)
    Private ReadOnly HdrStr As String() = {"Vessel", "Navigator", "From", "To", "Log Type",
        "Log DateTime", "Course Psc", "Var", "Dev", "Course True",
        "Speed", "Position L/Lo", "Weather Notes", "Log Entry Notes", "ElapsedTime",
        "Distance", "Calc Dest", "Calc True", "Calc Speed", "Set",
        "Drift", "Eval Basis", "ZD", "KnotLog", "Wind", "WindDir", "Seas", "Use4Eval"}
    Private ReadOnly NullStr As String() = {vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString}

    Private Structure GCRRec
        Public LatStr As String
        Public LongStr As String
        Public CTrue As String
        Public GCRDist As String
    End Structure
    Private GCRArray As GCRRec()
    Private UpdtRow As Integer = Nothing
    Private Structure DLUpdate
        Public Vessel As String
        Public Navigator As String
        Public LocFrom As String
        Public LocTo As String
        Public DateZoneTime As String
        Public Compass As String
        Public CompassI As Integer
        Public Var As String
        Public VarEW As String
        Public VarI As Double
        Public Dev As String
        Public DevEW As String
        Public DevI As Double
        Public CTrue As String
        Public CTrueI As Integer
        Public Speed As String
        Public SpeedI As Double
        Public PositionLatLong As String
        Public LDegI As Integer
        Public LMinI As Double
        Public LNS As String
        Public LatDouble As Double
        Public LoDegI As Integer
        Public LoMinI As Double
        Public LoEW As String
        Public LongDouble As Double
        Public LogType As String
        Public Weather As String
        Public Remarks As String
        Public Distance As Double
        Public Elapsed As TimeSpan
        Public CMG As Integer
        Public SMG As Double
        Public SetDir As Integer
        Public Drift As Double
        Public DBRowNum As Integer
        Public DestLatLongStr As String
        Public DestLDegI As Integer
        Public DestLMinI As Double
        Public DestLNS As String
        Public DestLatDouble As Double
        Public DestLoDegI As Integer
        Public DestLoMinI As Double
        Public DestLoEW As String
        Public DestLongDouble As Double
        Public DestTrueI As Integer
        Public DestDistance As Double
        Public DestSpeed As Double
        Public DestEstArrival As String
        Public DestEstElapsed As String
        Public ZD As String
        Public DestZD As String
        Public KnotLog As String
        Public Wind As String
        Public WindDir As String
        Public Seas As String
        Public UseForEval As String
    End Structure
    Private UpdtRtn As DLUpdate
    Public DevformLoaded As Boolean = False
    Private AdvMin As Integer = 0
    Private AdvNm As Double = 0.0
    Private DTAdvDTSave As DateTime
    Private AddNewMode As Boolean = False
    ' the next 4 log types require Date/Time, L/Lo, and TVMDC entries
    Private ReadOnly g_LogTypeDR As String = "DR Track"
    Private ReadOnly g_LogTypeOldDR As String = "DR"
    Private ReadOnly g_LogTypePlan As String = "Plan/Route"
    Private ReadOnly g_LogTypeOldPlan As String = "Plan"
    Private ReadOnly g_LogTypeDRAdv As String = "DRAdvance"
    Private ReadOnly g_LogTypeGPS As String = "GPS Track"
    Private ReadOnly g_LogTypeOldGPS As String = "GPS"
    ' the next 2 log types require Date/Time, L/Lo but NO TVMDC - they are fixed points in time not moving point. GPS Track is a moving 
    Private ReadOnly g_LogTypeFix As String = "Fix"
    Private ReadOnly g_LogTypeWayPoint As String = "Waypoint"

    ' The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
    ' Cell 0 = Vessel name  
    ' Cell 1 = Navigator name  
    ' Cell 2 = From location name   
    ' Cell 3 = To location name 
    ' Cell 4 = L/Lo loc type 
    ' Cell 5 = Zone Date & time String MM/dd/yyyy HH:mm:ss 
    ' Cell 6 = Compass course string 
    ' Cell 7 = Variation string 
    ' Cell 8 = Deviation string
    ' Cell 9 = Computed True Course string  
    ' Cell 10 = DR Speed string  
    ' Cell 11 = Latitude / Longitude string 
    ' Cell 12 = Weather string   
    ' Cell 13 = Remarks string
    ' Cell 14 = Elapsed Time from Lat/Long to Dest Lat/Long
    ' Cell 15 = Distance in nm from Lat/Long to Dest Lat/Long
    ' Cell 16 = Calculated Destination Lat/Long
    ' Cell 17 = Calculated True Course to destination
    ' Cell 18 = Calculated Speed to make destination
    ' Cell 19 = Calculated Set between two GPS/Fix locations
    ' Cell 20 = Calculated Drift between two GPS/Fix locations
    ' Cell 21 = Eval Based On string (filled in in EvaluatedDG subroutine)
    Private ReadOnly VesselCell As Integer = 0
    Private ReadOnly NavigatorCell As Integer = 1
    Private ReadOnly FromCell As Integer = 2
    Private ReadOnly ToCell As Integer = 3
    Private ReadOnly LogTypeCell As Integer = 4
    Private ReadOnly DTCell As Integer = 5
    Private ReadOnly CompassCell As Integer = 6
    Private ReadOnly VarCell As Integer = 7
    Private ReadOnly DevCell As Integer = 8
    Private ReadOnly TrueCell As Integer = 9
    Private ReadOnly DRSpeedCell As Integer = 10
    Private ReadOnly DestLogTypeCell As Integer = 11
    Private ReadOnly WeatherCell As Integer = 12
    Private ReadOnly NotesCell As Integer = 13
    Private ReadOnly ElapsedCell As Integer = 14
    Private ReadOnly DistCell As Integer = 15
    Private ReadOnly CalcDestLogTypeCell As Integer = 16
    Private ReadOnly CalcDestTrueCell As Integer = 17
    Private ReadOnly CalcDestSpeedCell As Integer = 18
    Private ReadOnly CalcSetCell As Integer = 19
    Private ReadOnly CalcDriftCell As Integer = 20
    Private ReadOnly EvalCell As Integer = 21
    Private ReadOnly ZDCell As Integer = 22
    Private ReadOnly KnotLogCell As Integer = 23
    Private ReadOnly WindCell As Integer = 24
    Private ReadOnly WindDirCell As Integer = 25
    Private ReadOnly SeasCell As Integer = 26
    Private ReadOnly UseForEvalCell As Integer = 27
    Private CurrDir As String
    Private CompassInput As Boolean = False
    Private TrueInput As Boolean = False
    Private Sub FormDeckLogUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DefFName As String = "DeckLog" & Now.ToString("yyyyMMddHHmmss") & ".csv"
        CurrDir = FileIO.FileSystem.CurrentDirectory() & "\DeckLog"
        InitialLoad = True
        FName &= CurrDir & "/" & DefFName

        CompassInput = False
        TrueInput = False

        DataSet1 = New DataSet()
        DataSet1.Tables.Add(tablename)
        DataSet1.DataSetName = tablename
        DataGridView1.DataSource = DataSet1
        For i As Integer = 0 To UBound(HdrStr)
            DataSet1.Tables(tablename).Columns.Add(HdrStr(i))
            DataSet1.Tables(tablename).Columns(i).AllowDBNull = False
            DataSet1.Tables(tablename).Columns(i).DefaultValue = ""
        Next
        DataSet1.Tables(tablename).Rows.Add(NullStr)
        DataGridView1.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns(12).MinimumWidth = 250
        DataGridView1.Columns(13).MinimumWidth = 250

        txtVar.Clear()
        txtDev.Clear()

        SortDataGridonDate()
        DataGridView1.Refresh()

        ResetAllScreenFields()
        btnDeleteSight.Visible = False
        btnUpdateExisting.Visible = False
        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0
        cboAdvType.SelectedIndex = 0
        AddNewMode = False
        DRAdvanceMode = False
        If My.Computer.Network.IsAvailable Then
            linkLblNOAAVar.Visible = True
            linkLblNOAAVar.Enabled = True
        Else
            linkLblNOAAVar.Visible = False
            linkLblNOAAVar.Enabled = False
        End If
        cboDisplayRows.SelectedIndex = 0

        chkHideFirst4Col.Checked = True
        AutoGCRMode = False
        InitialLoad = False
        If System.Windows.Forms.Application.OpenForms().OfType(Of FormSailings).Any Then
            If FormSailings.GCRAvailable = True Then
                chkImportGCR.Visible = True
                chkImportGCR.Checked = True
            Else
                chkImportGCR.Visible = False
                chkImportGCR.Checked = False
            End If
        Else
            chkImportGCR.Visible = False
            chkImportGCR.Checked = False
        End If
        Me.Show()
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        SaveDataGrid()
        IsUpdated = False
        DataSet1.Dispose()
        CleanUp()
        Me.Close()
    End Sub
    Public Sub QuickExit()
        Dim openFileDialog1 As New OpenFileDialog()
        If IsUpdated = True Then
            Dim MsgBack As MsgBoxResult = MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
            If MsgBack = MsgBoxResult.Yes Then
                SaveDataGrid()
            End If
            IsUpdated = False
        End If
        openFileDialog1.Dispose()
        DataSet1.Dispose()
        Exit Sub
    End Sub
    Private Sub SaveDataGrid()

        'Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
        Dim saveFileDialog1 As New SaveFileDialog With {
            .InitialDirectory = CurrDir,
            .Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
            .Title = "Save Deck Log File",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFileDialog1.FileName = vbNullString Then
                saveFileDialog1.Dispose()
                Exit Sub
            End If
            FName = saveFileDialog1.FileName
        End If

        Dim textstr As New System.Text.StringBuilder()
        Dim FileHdrStr As String = vbNullString
        For i As Integer = 0 To UBound(HdrStr)
            If i > 0 Then
                textstr.Append(",")
            End If
            textstr.Append(HdrStr(i))
        Next
        textstr.AppendLine()
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNothing(DataGridView1.Rows(x).Cells(VesselCell).Value) = False Then
                For v As Integer = 0 To DataGridView1.Columns.Count - 1
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then
                        textstr.Append(",")
                    End If
                    Dim tempstr As String = DataGridView1.Rows(x).Cells(v).Value.ToString()
                    tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
                    textstr.Append(tempstr)
                Next
            End If
            'adding new line to text
            textstr.AppendLine()
        Next
        IO.File.WriteAllText(FName, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"))
        SLOpenFName = FName
        lblOpenFN.Visible = True
        txtOpenFN.Visible = True
        txtOpenFN.Text = SLOpenFName
        saveFileDialog1.Dispose()
        Exit Sub
    End Sub

    Private Sub btnExitNoSave_Click(sender As Object, e As EventArgs) Handles btnExitNoSave.Click
        If IsUpdated = True Then
            Dim MsgBack As MsgBoxResult = MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
            If MsgBack = MsgBoxResult.Yes Then
                SaveDataGrid()
            End If
            IsUpdated = False
        End If

        CleanUp()
        Me.Close()
        Exit Sub
    End Sub

    Private Sub btnOpenCSV_Click(sender As Object, e As EventArgs) Handles btnOpenCSV.Click
        Dim myStream As System.IO.StreamReader = Nothing
        Dim openFileDialog2 As New OpenFileDialog()
        'Dim CurrDir As String = FileIO.FileSystem.CurrentDirectory()

        If IsUpdated = True Then
            Dim MsgBack As MsgBoxResult = MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
            If MsgBack = MsgBoxResult.Yes Then
                SaveDataGrid()
            End If
            IsUpdated = False
        End If

        FileLoading = True
        DataSet1.Tables(tablename).Clear()

        'Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
        openFileDialog2.Reset()
        openFileDialog2.InitialDirectory = CurrDir
        openFileDialog2.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv"
        openFileDialog2.Title = "Open Deck Log File"
        openFileDialog2.FilterIndex = 2
        openFileDialog2.RestoreDirectory = True
        openFileDialog2.AutoUpgradeEnabled = True

        If openFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If openFileDialog2.FileName = vbNullString Then
                openFileDialog2.Dispose()
                Exit Sub
            End If
            ReadError = False

            Dim ReadNum As Integer = 0
            Try
                myStream = New System.IO.StreamReader(openFileDialog2.FileName, System.Text.Encoding.Default)
                If (myStream IsNot Nothing) Then
                    FName = openFileDialog2.FileName
                    SLOpenFName = openFileDialog2.FileName
                    lblOpenFN.Visible = True
                    txtOpenFN.Visible = True
                    txtOpenFN.Text = SLOpenFName
                    Dim allData As String = myStream.ReadToEnd()
                    Dim rows As String() = allData.Split(vbCrLf) '("\r".ToCharArray())
                    Dim incr1 As Integer = 0
                    For Each r As String In rows
                        r = r.Trim(vbLf).Trim
                        If ReadNum = 0 Then
                            r = r.Trim(vbLf).Trim
                            Dim items As String() = r.Split(",")
                            'For ctr As Integer = 0 To UBound(items)
                            'Set1.Tables(tablename).Columns.Add(items(ctr))
                            'Next
                        Else
                            r = r.Trim(vbLf).Trim
                            Dim items1 As String() = r.Split(",")
                            If items1(0) <> vbNullString And items1(0) <> Nothing Then
                                DataSet1.Tables(tablename).Rows.Add(items1)
                            End If

                        End If
                        ReadNum += 1
                        incr1 += 1
                    Next
                    myStream.Close()

                    DisplayCommonButtons()
                End If
                openFileDialog2.Dispose()

                myStream.Dispose()
                DataGridView1.DataSource = DataSet1.Tables(0).DefaultView
                DataGridView1.ClearSelection()
                DataGridView1.CurrentCell = Nothing
                DisplayHideFirst4Col()
                SortDataGridonDate()
                evaluateDG()
                DisplayDGRows()
                DataGridView1.Refresh()
                FileLoading = False
                Me.Refresh()
            Catch Ex As Exception
                ErrorMsgBox("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        Else

            HideCommonButtons()
        End If
        openFileDialog2.Dispose()
    End Sub
    Private Shared Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        SaveDataGrid()
        IsUpdated = False
        Exit Sub
    End Sub

    Private Sub btnInfoForm_Click(sender As Object, e As EventArgs) Handles btnInfoForm.Click
        DeckLogHelp.Show()
        Exit Sub
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If FileLoading = True Then
            Exit Sub
        End If
        If InitialLoad = True Then
            Exit Sub
        End If
        If SortingDG = True Then
            Exit Sub
        End If
        If DRAdvanceMode = True Then
            Exit Sub
        End If
        If AddNewMode = True Then
            Exit Sub
        End If
        UpdtRow = Nothing
        Dim n As Integer = Nothing
        ' if a selection has occured but there are now rows in the datagridview then exit sub
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(DataGridView1.CurrentRow.Index) Then 'Or DataGridView1.CurrentRow.Index = vbNull Then
            Exit Sub
        End If
        ' if the selected row somehow has a blank or nullstring in the LogTypeCell then exit sub
        If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(LogTypeCell).Value = vbNullString Or DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(LogTypeCell).Value = "" Then
            Exit Sub
        End If
        SelectedRow = True
        n = DataGridView1.CurrentRow.Index
        UpdtRow = DataGridView1.CurrentRow.Index

        ' The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
        ' Cell 0 = Vessel name  
        ' Cell 1 = Navigator name  
        ' Cell 2 = From location name   
        ' Cell 3 = To location name 
        ' Cell 4 = L/Lo loc type 
        ' Cell 5 = Zone Date & time String MM/dd/yyyy HH:mm:ss 
        ' Cell 6 = Compass course string 
        ' Cell 7 = Variation string 
        ' Cell 8 = Deviation string
        ' Cell 9 = Computed True Course string  
        ' Cell 10 = DR Speed string  
        ' Cell 11 = Latitude / Longitude string 
        ' Cell 12 = Weather string   
        ' Cell 13 = Remarks string
        ' Cell 14 = Elapsed Time from Lat/Long to Dest Lat/Long
        ' Cell 15 = Distance in nm from Lat/Long to Dest Lat/Long
        ' Cell 16 = Calculated Destination Lat/Long
        ' Cell 17 = Calculated True Course to destination
        ' Cell 18 = Calculated Speed to make destination
        ' Cell 19 = Calculated Set between two GPS/Fix locations
        ' Cell 20 = Calculated Drift between two GPS/Fix locations
        ' Cell 21 = Eval Based On string (filled in in EvaluatedDG subroutine)
        ' Cell 22 = ZD 
        ' Cell 23 = Knot Log
        ' Cell 24 =  Wind info
        ' Cell 25 =  Wind Direction
        ' Cell 26 =  Seas Height info
        ' Cell 27 =  UseForEval Y/N 

        If DataGridView1.Rows(n).Cells(VesselCell).Value <> vbNullString Then
            UpdtRtn.Vessel = DataGridView1.Rows(n).Cells(VesselCell).Value
            txtVessel.Text = DataGridView1.Rows(n).Cells(VesselCell).Value
        Else
            UpdtRtn.Vessel = vbNullString
            txtVessel.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(NavigatorCell).Value <> vbNullString Then
            UpdtRtn.Navigator = DataGridView1.Rows(n).Cells(NavigatorCell).Value
            txtNavigator.Text = DataGridView1.Rows(n).Cells(NavigatorCell).Value
        Else
            UpdtRtn.Navigator = vbNullString
            txtNavigator.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(FromCell).Value <> vbNullString Then
            UpdtRtn.LocFrom = DataGridView1.Rows(n).Cells(FromCell).Value
            txtFrom.Text = DataGridView1.Rows(n).Cells(FromCell).Value
        End If

        If DataGridView1.Rows(n).Cells(ToCell).Value <> vbNullString Then
            UpdtRtn.LocTo = DataGridView1.Rows(n).Cells(ToCell).Value
            txtTo.Text = DataGridView1.Rows(n).Cells(ToCell).Value
        Else
            UpdtRtn.LocTo = vbNullString
            txtTo.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(LogTypeCell).Value <> vbNullString Then
            UpdtRtn.LogType = DataGridView1.Rows(n).Cells(LogTypeCell).Value
            cboLocType.Text = DataGridView1.Rows(n).Cells(LogTypeCell).Value
        Else
            UpdtRtn.LogType = vbNullString
            cboLocType.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(DTCell).Value <> vbNullString Then
            UpdtRtn.DateZoneTime = DataGridView1.Rows(n).Cells(DTCell).Value
            DTDateZoneTime.Value = Convert.ToDateTime(DataGridView1.Rows(n).Cells(DTCell).Value)
        Else
            UpdtRtn.DateZoneTime = Now.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
            DTDateZoneTime.Value = Now
        End If

        If DataGridView1.Rows(n).Cells(CompassCell).Value <> vbNullString Then
            Dim tlen As Integer = DataGridView1.Rows(n).Cells(CompassCell).Value.ToString.Length
            UpdtRtn.Compass = DataGridView1.Rows(n).Cells(CompassCell).Value.ToString.Substring(0, tlen - 1)
            txtCompass.Text = DataGridView1.Rows(n).Cells(CompassCell).Value.ToString.Substring(0, tlen - 1)
        Else
            UpdtRtn.Compass = vbNullString
            txtCompass.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(VarCell).Value <> vbNullString Then
            UpdtRtn.Var = DataGridView1.Rows(n).Cells(VarCell).Value
            UpdtRtn.VarEW = UpdtRtn.Var.Last
            UpdtRtn.Var = UpdtRtn.Var.Substring(0, UpdtRtn.Var.Length - 1)
            txtVar.Text = UpdtRtn.Var
            cboVar.Text = UpdtRtn.VarEW
        Else
            UpdtRtn.Var = ""
            txtVar.Clear()
        End If

        If DataGridView1.Rows(n).Cells(DevCell).Value <> vbNullString Then
            UpdtRtn.Dev = DataGridView1.Rows(n).Cells(DevCell).Value
            UpdtRtn.DevEW = UpdtRtn.Dev.Last
            UpdtRtn.Dev = UpdtRtn.Dev.Substring(0, UpdtRtn.Dev.Length - 1)
            txtDev.Text = UpdtRtn.Dev
            cboDev.Text = UpdtRtn.DevEW
        Else
            UpdtRtn.Dev = ""
            txtDev.Clear()
            cboDev.Text = g_LongW
        End If
        'End If


        If DataGridView1.Rows(n).Cells(TrueCell).Value <> vbNullString Then
            Dim tlen As Integer = DataGridView1.Rows(n).Cells(TrueCell).Value.ToString.Length
            UpdtRtn.CTrue = DataGridView1.Rows(n).Cells(TrueCell).Value.ToString.Substring(0, tlen - 1)
            txtCTrue.Text = DataGridView1.Rows(n).Cells(TrueCell).Value.ToString.Substring(0, tlen - 1)
        Else
            UpdtRtn.CTrue = vbNullString
            txtCTrue.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(DRSpeedCell).Value <> vbNullString Then
            Dim tlen As Integer = DataGridView1.Rows(n).Cells(DRSpeedCell).Value.ToString.Length
            UpdtRtn.Speed = DataGridView1.Rows(n).Cells(DRSpeedCell).Value.ToString.Substring(0, tlen - 2)
            txtSpeed.Text = DataGridView1.Rows(n).Cells(DRSpeedCell).Value.ToString.Substring(0, tlen - 2)
        Else
            UpdtRtn.Speed = vbNullString
            txtSpeed.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(DestLogTypeCell).Value <> vbNullString Then
            UpdtRtn.PositionLatLong = DataGridView1.Rows(n).Cells(DestLogTypeCell).Value
            Dim LLo As String = DataGridView1.Rows(n).Cells(DestLogTypeCell).Value
            Dim LPos As Integer = LLo.IndexOf("=", StringComparison.OrdinalIgnoreCase)
            Dim LDegPos As Integer = LLo.IndexOf(Chr(176))
            Dim LMinPos As Integer = LLo.IndexOf("'", StringComparison.OrdinalIgnoreCase)
            Dim LoPos As Integer = LLo.IndexOf("=", LPos + 1, StringComparison.OrdinalIgnoreCase)
            Dim LoDegPos As Integer = LLo.IndexOf(Chr(176), LDegPos + 1)
            Dim LoMinPos As Integer = LLo.IndexOf("'", LMinPos + 1, StringComparison.OrdinalIgnoreCase)
            txtLDeg.Text = LLo.Substring(LPos + 1, (LDegPos - 1) - (LPos + 1) + 1)
            txtLMin.Text = LLo.Substring(LDegPos + 1, (LMinPos - 1) - (LDegPos + 1) + 1)
            cboL.Text = LLo.Substring(LMinPos + 1, 1)
            txtLoDeg.Text = LLo.Substring(LoPos + 1, (LoDegPos - 1) - (LoPos + 1) + 1)
            txtLoMin.Text = LLo.Substring(LoDegPos + 1, (LoMinPos - 1) - (LoDegPos + 1) + 1)
            cboLo.Text = LLo.Substring(LoMinPos + 1, 1)
        Else
            UpdtRtn.PositionLatLong = vbNullString
            txtLDeg.Clear()
            txtLMin.Clear()
            cboL.SelectedIndex = 0
            txtLoDeg.Clear()
            txtLoMin.Clear()
            cboLo.SelectedIndex = 0
        End If

        If DataGridView1.Rows(n).Cells(ZDCell).Value <> vbNullString Then
            UpdtRtn.ZD = DataGridView1.Rows(n).Cells(ZDCell).Value
            txtZD.Text = DataGridView1.Rows(n).Cells(ZDCell).Value
        Else
            Dim TempZD As Integer = Math.Abs(Math.Round((Convert.ToDouble(txtLoDeg.Text) + (Convert.ToDouble(txtLoMin.Text) / 60) / 15), 0))
            If cboLo.Text = g_LongW Then
                UpdtRtn.ZD = "-" & TempZD.ToString("#0")
                txtZD.Text = "-" & TempZD.ToString("#0")
            Else
                UpdtRtn.ZD = "+" & TempZD.ToString("#0")
                txtZD.Text = "+" & TempZD.ToString("#0")
            End If

        End If

        If DataGridView1.Rows(n).Cells(KnotLogCell).Value <> vbNullString Then
            UpdtRtn.KnotLog = DataGridView1.Rows(n).Cells(KnotLogCell).Value
            txtKnotLog.Text = DataGridView1.Rows(n).Cells(KnotLogCell).Value
        Else
            UpdtRtn.KnotLog = vbNullString
            txtKnotLog.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(WeatherCell).Value <> vbNullString Then
            UpdtRtn.Weather = DataGridView1.Rows(n).Cells(WeatherCell).Value
            txtWeather.Text = DataGridView1.Rows(n).Cells(WeatherCell).Value
        Else
            UpdtRtn.Weather = vbNullString
            txtWeather.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(WindCell).Value <> vbNullString Then
            UpdtRtn.Wind = DataGridView1.Rows(n).Cells(WindCell).Value
            txtWind.Text = DataGridView1.Rows(n).Cells(WindCell).Value
        Else
            UpdtRtn.Wind = vbNullString
            txtWind.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(WindDirCell).Value <> vbNullString Then
            UpdtRtn.WindDir = DataGridView1.Rows(n).Cells(WindDirCell).Value
            cboWindDir.Text = DataGridView1.Rows(n).Cells(WindDirCell).Value
        Else
            UpdtRtn.WindDir = vbNullString
            cboWindDir.Text = vbNullString
        End If

        If DataGridView1.Rows(n).Cells(UseForEvalCell).Value = "Y" Then
            chkUseForEval.Checked = True
            UpdtRtn.UseForEval = "Y"
        Else
            chkUseForEval.Checked = False
            UpdtRtn.UseForEval = "N"
        End If

        If DataGridView1.Rows(n).Cells(NotesCell).Value <> vbNullString Then
            UpdtRtn.Remarks = DataGridView1.Rows(n).Cells(NotesCell).Value
            txtRemarks.Text = DataGridView1.Rows(n).Cells(NotesCell).Value
        Else
            UpdtRtn.Remarks = vbNullString
            txtRemarks.Text = vbNullString
        End If
        If UpdtRtn.LogType <> g_LogTypeDRAdv Then
            lblAdvHrMin.Visible = False
            cboAdvHrs.Visible = False
            cboAdvMin.Visible = False
            cboAdvType.Visible = False
            lblAdvNm.Visible = False
            cboAdvNm.Visible = False
            grpAdvInfo.Visible = False
        End If
        If UpdtRtn.LogType = g_LogTypePlan Then
            txtDestElapsed.Text = DataGridView1.Rows(n).Cells(ElapsedCell).Value
            UpdtRtn.DestEstElapsed = DataGridView1.Rows(n).Cells(ElapsedCell).Value

            If DataGridView1.Rows(n).Cells(DistCell).Value <> "" Then
                txtDestDist.Text = DataGridView1.Rows(n).Cells(DistCell).Value
                UpdtRtn.DestDistance = Convert.ToDouble(DataGridView1.Rows(n).Cells(DistCell).Value.ToString.Substring(0, txtDestDist.Text.ToString.Length - 2))
            End If
            If DataGridView1.Rows(n).Cells(CalcDestLogTypeCell).Value <> "" Then
                UpdtRtn.DestLatLongStr = DataGridView1.Rows(n).Cells(CalcDestLogTypeCell).Value
                Dim DestLLo As String = DataGridView1.Rows(n).Cells(CalcDestLogTypeCell).Value
                Dim LPos As Integer = DestLLo.IndexOf("=", StringComparison.OrdinalIgnoreCase)
                Dim LDegPos As Integer = DestLLo.IndexOf(Chr(176))
                Dim LMinPos As Integer = DestLLo.IndexOf("'", StringComparison.OrdinalIgnoreCase)
                Dim LoPos As Integer = DestLLo.IndexOf("=", LPos + 1, StringComparison.OrdinalIgnoreCase)
                Dim LoDegPos As Integer = DestLLo.IndexOf(Chr(176), LDegPos + 1)
                Dim LoMinPos As Integer = DestLLo.IndexOf("'", LMinPos + 1, StringComparison.OrdinalIgnoreCase)
                txtDestLDeg.Text = DestLLo.Substring(LPos + 1, (LDegPos - 1) - (LPos + 1) + 1)
                txtDestLMin.Text = DestLLo.Substring(LDegPos + 1, (LMinPos - 1) - (LDegPos + 1) + 1)
                cboDestL.Text = DestLLo.Substring(LMinPos + 1, 1)
                txtDestLoDeg.Text = DestLLo.Substring(LoPos + 1, (LoDegPos - 1) - (LoPos + 1) + 1)
                txtDestLoMin.Text = DestLLo.Substring(LoDegPos + 1, (LoMinPos - 1) - (LoDegPos + 1) + 1)
                cboDestLo.Text = DestLLo.Substring(LoMinPos + 1, 1)
                txtDestTrue.Text = DataGridView1.Rows(n).Cells(CalcDestTrueCell).Value
                UpdtRtn.DestTrueI = Convert.ToInt32(DataGridView1.Rows(n).Cells(CalcDestTrueCell).Value.ToString.Substring(0, txtDestTrue.Text.ToString.Length - 1))
                Dim Pos1 As Integer = txtRemarks.Text.IndexOf(":", StringComparison.OrdinalIgnoreCase)
                Dim Len1 As Integer = txtRemarks.Text.Length - (Pos1 + 1)
                txtEstArrival.Text = txtRemarks.Text.Substring(Pos1 + 1, Len1)
            End If

        End If
        cboLocType.Items.Clear()
        cboLocType.Enabled = False

        Select Case UpdtRtn.LogType
            Case g_LogTypeDR, g_LogTypeOldDR
                cboLocType.Items.Add(g_LogTypeDR)
                cboLocType.Items.Add(g_LogTypeDRAdv)
                cboLocType.Items.Add(g_LogTypeGPS)
                cboLocType.Items.Add(g_LogTypeFix)
                cboLocType.Items.Add(g_LogTypeWayPoint)
                cboLocType.Items.Add(g_LogTypePlan)
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
            Case g_LogTypeFix, g_LogTypeWayPoint
                cboLocType.Items.Add(g_LogTypeDR)
                cboLocType.Items.Add(g_LogTypeGPS)
                cboLocType.Items.Add(g_LogTypeFix)
                cboLocType.Items.Add(g_LogTypeWayPoint)
                cboLocType.Items.Add(g_LogTypePlan)

                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
            Case g_LogTypeGPS, g_LogTypeOldGPS
                cboLocType.Items.Add(g_LogTypeDR)
                cboLocType.Items.Add(g_LogTypeGPS)
                cboLocType.Items.Add(g_LogTypeFix)
                cboLocType.Items.Add(g_LogTypeWayPoint)
                cboLocType.Items.Add(g_LogTypePlan)
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
            Case g_LogTypePlan
                cboLocType.Items.Add(g_LogTypeDR)
                cboLocType.Items.Add(g_LogTypeGPS)
                cboLocType.Items.Add(g_LogTypeFix)
                cboLocType.Items.Add(g_LogTypeWayPoint)
                cboLocType.Items.Add(g_LogTypePlan)
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
            Case Else
                ErrorMsgBox("The Log Entry you have selected has an invalid Log Type. Select a new log type for this entry and update it. This error occurs because of changing log types and old file formats")
                cboLocType.Items.Add(g_LogTypeDR)
                cboLocType.Items.Add(g_LogTypeGPS)
                cboLocType.Items.Add(g_LogTypeFix)
                cboLocType.Items.Add(g_LogTypeWayPoint)
                cboLocType.Items.Add(g_LogTypePlan)
                btnUpdateExisting.Visible = False
                btnDeleteSight.Visible = False
        End Select
        cboLocType.Enabled = True

        Me.Refresh()
        SelectedRow = False
        Exit Sub
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ProcessAddNew()
        SortingDG = True
        RemoveEmptyRowsinDG()
        SortingDG = False
        Exit Sub
    End Sub
    Private ReadOnly G_UseDestData As String = "Use Dest Data"
    Private Sub ProcessAddNew()
        AddNewMode = True
        If cboLocType.Text = g_LogTypeDR Then
            If ZTInfo.InvokedbyDeckLog = True Then
                If DestDTUpdatedbyZTInfo = True Then
                    DTDateZoneTime.Value = DestDTfromZTInfo
                    DestDTUpdatedbyZTInfo = False
                    ZTInfo.InvokedbyDeckLog = False
                Else
                    ZTInfo.InvokedbyDeckLog = False
                    DestDTUpdatedbyZTInfo = False
                End If
            Else
                ZTInfo.InvokedbyDeckLog = False
                DestDTUpdatedbyZTInfo = False
            End If
        End If

        If cboLocType.Text = g_LogTypeDRAdv Then
            DRAdvanceMode = True

            FindInstallAdvancedDR()
            cboLocType.Text = g_LogTypeDR
            If EditUpdtFields() = False Then
                DRAdvanceMode = False
                Me.Refresh()
                AddNewMode = False
                Exit Sub
            End If
            lblAdvHrMin.Visible = False
            cboAdvHrs.Visible = False
            cboAdvMin.Visible = False
            lblAdvNm.Visible = False
            cboAdvNm.Visible = False
            grpAdvInfo.Visible = False
            cboAdvHrs.Value = 0
            cboAdvMin.Value = 0
            DRAdvanceMode = False
            SortDataGridonDate()
            evaluateDG()
            DisplayDGRows()
            DataGridView1.CurrentCell.Selected = True
            DataGridView1.Refresh()
            ResetSomeScreenFields()
            DisplayCommonButtons()
            Me.Refresh()
            IsUpdated = True
            DTChanged = False
            AddNewMode = False
            Exit Sub
        End If
        If EditUpdtFields() = False Then
            Me.Refresh()
            AddNewMode = False
            Exit Sub
        End If
        If cboLocType.Text = g_LogTypePlan Then
            If EditPlanFields() = False Then
                Me.Refresh()
                AddNewMode = False
                Exit Sub
            End If
        End If
        Dim LLo As String = "L=" & txtLDeg.Text.ToString & Chr(176) & txtLMin.Text.ToString & "'" & cboL.Text.ToString &
            " Lo=" & txtLoDeg.Text.ToString & Chr(176) & txtLoMin.Text.ToString & "'" & cboLo.Text.ToString
        Dim TempEval4Use As String = "N"
        If chkUseForEval.Checked = True Then
            TempEval4Use = "Y"
        End If
        If cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan Then
            Dim DestLLo As String = "L=" & txtDestLDeg.Text.ToString & Chr(176) & txtDestLMin.Text.ToString & "'" & cboDestL.Text.ToString &
                                " Lo=" & txtDestLoDeg.Text.ToString & Chr(176) & txtDestLoMin.Text.ToString & "'" & cboDestLo.Text.ToString
            DataSet1.Tables(tablename).Rows.Add(txtVessel.Text.ToString, txtNavigator.Text.ToString, txtFrom.Text.ToString, txtTo.Text.ToString,
                               cboLocType.Text.ToString, DTDateZoneTime.Value.ToString(DTFormatString), txtCompass.Text.ToString & Chr(176),
                               txtVar.Text.ToString & cboVar.Text, txtDev.Text.ToString & cboDev.Text,
                               txtCTrue.Text.ToString & Chr(176), txtSpeed.Text.ToString & "kn", LLo, txtWeather.Text.ToString, txtRemarks.Text.ToString,
                               txtDestElapsed.Text, txtDestDist.Text, DestLLo, txtDestTrue.Text, "", "", "", "Plan Entry", txtZD.Text, txtKnotLog.Text,
                               txtWind.Text, cboWindDir.Text.ToString, txtSeas.Text.ToString, TempEval4Use)
        ElseIf cboLocType.Text = g_LogTypeFix Or cboLocType.Text = g_LogTypeWayPoint Then
            DataSet1.Tables(tablename).Rows.Add(txtVessel.Text.ToString, txtNavigator.Text.ToString, txtFrom.Text.ToString, txtTo.Text.ToString,
                               cboLocType.Text.ToString, DTDateZoneTime.Value.ToString(DTFormatString), "", "", "", "", "", LLo, txtWeather.Text.ToString, txtRemarks.Text.ToString,
                                "", "", "", "", "", "", "", "", txtZD.Text, txtKnotLog.Text, txtWind.Text, cboWindDir.Text.ToString, txtSeas.Text.ToString, TempEval4Use)
        Else
            DataSet1.Tables(tablename).Rows.Add(txtVessel.Text.ToString, txtNavigator.Text.ToString, txtFrom.Text.ToString, txtTo.Text.ToString,
                               cboLocType.Text.ToString, DTDateZoneTime.Value.ToString(DTFormatString), txtCompass.Text.ToString & Chr(176),
                               txtVar.Text.ToString & cboVar.Text, txtDev.Text.ToString & cboDev.Text,
                               txtCTrue.Text.ToString & Chr(176), txtSpeed.Text.ToString & "kn", LLo, txtWeather.Text.ToString, txtRemarks.Text.ToString,
                                "", "", "", "", "", "", "", "", txtZD.Text, txtKnotLog.Text, txtWind.Text, cboWindDir.Text.ToString, txtSeas.Text.ToString, TempEval4Use)
        End If

        ' transfer destination info to input fields for next Plan log entry

        If cboLocType.Text = g_LogTypePlan Then
            If AutoGCRMode = False Then
                'Dim result As DialogResult = MessageBox.Show("Use Destination data to build next Plan Log entry - Yes/No", G_UseDestData, MessageBoxButtons.YesNo)
                'If result = DialogResult.Yes Then
                DTDateZoneTime.Value = DestEstArrival
                txtLDeg.Text = txtDestLDeg.Text
                txtLMin.Text = txtDestLMin.Text
                cboL.SelectedIndex = cboDestL.SelectedIndex
                txtLoDeg.Text = txtDestLoDeg.Text
                txtLoMin.Text = txtDestLoMin.Text
                cboLo.SelectedIndex = cboDestLo.SelectedIndex
                txtSpeed.Text = UpdtRtn.SpeedI.ToString("#0.0")
                txtCTrue.Text = UpdtRtn.CTrueI.ToString("##0")   'txtDestTrue.Text.ToString.Substring(0, txtDestTrue.Text.ToString.Length - 1)
                txtDev.Text = Math.Abs(UpdtRtn.DevI).ToString("#0")
                If UpdtRtn.DevEW = g_LongW Then
                    cboDev.SelectedIndex = 0
                Else
                    cboDev.SelectedIndex = 1
                End If
                'Dim DtrueI As Integer = Convert.ToInt32(txtDestTrue.Text.ToString.Replace(Chr(176), "").Trim)
                'Dim DDevI As Integer = Convert.ToInt32(txtDev.Text.ToString.Replace(Chr(176), "").Trim)
                txtCompass.Text = (UpdtRtn.CTrueI + UpdtRtn.DevI + UpdtRtn.VarI).ToString("##0")
                txtZD.Text = txtDestZD.Text
                txtDestLDeg.Clear()
                txtDestLMin.Clear()
                txtDestLoDeg.Clear()
                txtDestLoMin.Clear()
                txtDestTrue.Clear()
                txtDestDist.Clear()
                txtDestElapsed.Clear()
                txtDestZD.Clear()

                txtEstArrival.Clear()
                txtWeather.Clear()
                txtRemarks.Clear()
                lblAdvHrMin.Visible = True
                cboAdvHrs.Visible = True
                cboAdvMin.Visible = True
                lblAdvNm.Visible = True
                cboAdvNm.Visible = True
                grpAdvInfo.Visible = True
                cboAdvType.Visible = True

            Else
                DTDateZoneTime.Value = DestEstArrival
                txtLDeg.Text = txtDestLDeg.Text
                txtLMin.Text = txtDestLMin.Text
                cboL.SelectedIndex = cboDestL.SelectedIndex
                txtLoDeg.Text = txtDestLoDeg.Text
                txtLoMin.Text = txtDestLoMin.Text
                cboLo.SelectedIndex = cboDestLo.SelectedIndex
                txtSpeed.Text = UpdtRtn.SpeedI.ToString("#0.0")
                txtCTrue.Text = UpdtRtn.CTrueI.ToString("##0")   'txtDestTrue.Text.ToString.Substring(0, txtDestTrue.Text.ToString.Length - 1)
                txtDev.Text = Math.Abs(UpdtRtn.DevI).ToString("#0")
                If UpdtRtn.DevEW = g_LongW Then
                    cboDev.SelectedIndex = 0
                Else
                    cboDev.SelectedIndex = 1
                End If

                'Dim DtrueI As Integer = Convert.ToInt32(txtDestTrue.Text.ToString.Replace(Chr(176), "").Trim)
                'Dim DDevI As Integer = Convert.ToInt32(txtDev.Text.ToString.Replace(Chr(176), "").Trim)
                'txtCompass.Text = (DtrueI + DDevI + UpdtRtn.VarI).ToString("##0")

                txtCompass.Text = (UpdtRtn.CTrueI + UpdtRtn.DevI + UpdtRtn.VarI).ToString("##0")
                txtZD.Text = txtDestZD.Text
                txtDestLDeg.Clear()
                txtDestLMin.Clear()
                txtDestLoDeg.Clear()
                txtDestLoMin.Clear()
                txtDestTrue.Clear()
                txtDestDist.Clear()
                txtDestElapsed.Clear()
                txtDestZD.Clear()

                txtEstArrival.Clear()
                txtWeather.Clear()
                txtRemarks.Clear()
                lblAdvHrMin.Visible = True
                cboAdvHrs.Visible = True
                cboAdvMin.Visible = True
                lblAdvNm.Visible = True
                cboAdvNm.Visible = True
                grpAdvInfo.Visible = True
                cboAdvType.Visible = True
            End If
        End If

        If cboLocType.Text <> g_LogTypePlan And DRAdvanceMode = False And AutoGCRMode = False Then
            ResetSomeScreenFields()
            DisplayCommonButtons()
        End If

        If AutoGCRMode = False Then
            SortDataGridonDate()
            evaluateDG()
            DisplayDGRows()
            'DataGridView1.ClearSelection()
            DataGridView1.CurrentCell.Selected = True
            DataGridView1.Refresh()
            DisplayCommonButtons()
        End If

        'DataGridView1.ClearSelection()
        DataGridView1.CurrentCell.Selected = True
        DataGridView1.Refresh()
        Me.Refresh()
        IsUpdated = True
        DTChanged = False
        AddNewMode = False
        Exit Sub
    End Sub

    Private Sub btnUpdateExisting_Click(sender As Object, e As EventArgs) Handles btnUpdateExisting.Click
        ProcessUpdateExisting()
        Exit Sub
    End Sub
    Private ReadOnly g_DrAdvError1 As String = "Can Not Update DRAdvance Entry"
    Private Sub ProcessUpdateExisting()
        AddNewMode = False
        If cboLocType.Text = g_LogTypeDRAdv Then
            Dim result As MessageBoxResult = MessageBox.Show("Error - Can Not Update a DRAdvance type log entry - Change to DR type entry = Yes or No to exit", g_DrAdvError1, MessageBoxButtons.YesNo)
            If result = MessageBoxResult.Yes Then
                cboLocType.Text = g_LogTypeDR

                lblAdvHrMin.Visible = False
                cboAdvHrs.Visible = False
                cboAdvMin.Visible = False
                lblAdvNm.Visible = False
                cboAdvNm.Visible = False
                grpAdvInfo.Visible = False
                cboAdvType.Visible = False

                AdvMin = (Convert.ToInt32(cboAdvHrs.Value.ToString) * 60) + Convert.ToInt32(cboAdvMin.Value.ToString)
                DTDateZoneTime.Value = DTDateZoneTime.Value.AddMinutes(AdvMin)
            Else
                Exit Sub
            End If
        End If

        If EditUpdtFields() = False Then
            Me.Refresh()
            Exit Sub
        End If
        If cboLocType.Text = g_LogTypePlan Then
            If EditPlanFields() = False Then
                Me.Refresh()
                Exit Sub
            End If
        End If
        Dim PlanDTChg As Boolean = False
        Dim DRGPSSightDTChg As Boolean = False
        Dim NewDT As Date
        Dim OriginalDT As Date
        Dim TDiff As TimeSpan
        If Convert.ToDateTime(DataGridView1.Rows(UpdtRow).Cells(DTCell).Value) <> DTDateZoneTime.Value Then
            If cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan Then
                ' if this is a planned route entry and the date/time has changed, ask if user wants to autocalc subsequent entries to new date / time and execute updat
                If UpdtRow < DataGridView1.Rows.Count Then
                    Dim MsgBack As MsgBoxResult = MsgBox("Plan Entry Date/Time has been updated - Do You Want to AutoUpdate the Date/Time for subsequent Plan entries - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
                    If MsgBack = MsgBoxResult.Yes Then
                        NewDT = DTDateZoneTime.Value
                        OriginalDT = Convert.ToDateTime(DataGridView1.Rows(UpdtRow).Cells(DTCell).Value)
                        TDiff = NewDT - OriginalDT
                        PlanDTChg = True
                    Else
                        PlanDTChg = False
                    End If
                End If
            Else
                If cboLocType.Text = g_LogTypeDR Or cboLocType.Text = g_LogTypeOldDR Or cboLocType.Text = g_LogTypeOldGPS Or cboLocType.Text = g_LogTypeGPS Then
                    If UpdtRow < DataGridView1.Rows.Count Then
                        Dim MsgBack As MsgBoxResult = MsgBox("DR/GPS Entry Date/Time has been updated - Do You Want to AutoUpdate the Date/Time for subsequent DR/GPS entries - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
                        If MsgBack = MsgBoxResult.Yes Then
                            NewDT = DTDateZoneTime.Value
                            OriginalDT = Convert.ToDateTime(DataGridView1.Rows(UpdtRow).Cells(DTCell).Value)
                            TDiff = NewDT - OriginalDT
                            DRGPSSightDTChg = True
                        Else
                            DRGPSSightDTChg = False
                        End If
                    End If
                End If

            End If
        End If
        Dim LLo As String = ""
        LLo = "L=" & UpdtRtn.LDegI.ToString("00") & Chr(176) & UpdtRtn.LMinI.ToString("00.0") &
            "'" & cboL.Text.ToString & " Lo=" & UpdtRtn.LoDegI.ToString("00") & Chr(176) & UpdtRtn.LoMinI.ToString("00.0") & "'" & cboLo.Text.ToString

        DataGridView1.Rows(UpdtRow).Cells(VesselCell).Value = txtVessel.Text
        DataGridView1.Rows(UpdtRow).Cells(NavigatorCell).Value = txtNavigator.Text
        DataGridView1.Rows(UpdtRow).Cells(FromCell).Value = txtFrom.Text
        DataGridView1.Rows(UpdtRow).Cells(ToCell).Value = txtTo.Text
        DataGridView1.Rows(UpdtRow).Cells(LogTypeCell).Value = cboLocType.Text
        DataGridView1.Rows(UpdtRow).Cells(DTCell).Value = DTDateZoneTime.Value.ToString(DTFormatString)

        If cboLocType.Text = g_LogTypeWayPoint Or cboLocType.Text = g_LogTypeFix Then
            DataGridView1.Rows(UpdtRow).Cells(CompassCell).Value = ""
            DataGridView1.Rows(UpdtRow).Cells(VarCell).Value = ""
            DataGridView1.Rows(UpdtRow).Cells(DevCell).Value = ""
            DataGridView1.Rows(UpdtRow).Cells(TrueCell).Value = ""
            DataGridView1.Rows(UpdtRow).Cells(DRSpeedCell).Value = ""
        Else
            DataGridView1.Rows(UpdtRow).Cells(CompassCell).Value = txtCompass.Text & Chr(176)
            DataGridView1.Rows(UpdtRow).Cells(VarCell).Value = txtVar.Text & cboVar.Text
            DataGridView1.Rows(UpdtRow).Cells(DevCell).Value = txtDev.Text & cboDev.Text
            DataGridView1.Rows(UpdtRow).Cells(TrueCell).Value = txtCTrue.Text & Chr(176)
            DataGridView1.Rows(UpdtRow).Cells(DRSpeedCell).Value = txtSpeed.Text & "kn"
        End If

        DataGridView1.Rows(UpdtRow).Cells(DestLogTypeCell).Value = LLo
        DataGridView1.Rows(UpdtRow).Cells(WeatherCell).Value = txtWeather.Text
        DataGridView1.Rows(UpdtRow).Cells(NotesCell).Value = txtRemarks.Text
        DataGridView1.Rows(UpdtRow).Cells(KnotLogCell).Value = txtKnotLog.Text
        DataGridView1.Rows(UpdtRow).Cells(WindCell).Value = txtWind.Text
        DataGridView1.Rows(UpdtRow).Cells(WindDirCell).Value = cboWindDir.Text.ToString
        DataGridView1.Rows(UpdtRow).Cells(SeasCell).Value = txtSeas.Text
        If chkUseForEval.Checked = True Then
            DataGridView1.Rows(UpdtRow).Cells(UseForEvalCell).Value = "Y"
        Else
            DataGridView1.Rows(UpdtRow).Cells(UseForEvalCell).Value = "N"
        End If


        If cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan Then
            Dim DestLLo As String = "L=" & txtDestLDeg.Text.ToString & Chr(176) & txtDestLMin.Text.ToString & "'" & cboDestL.Text.ToString &
            " Lo=" & txtDestLoDeg.Text.ToString & Chr(176) & txtDestLoMin.Text.ToString & "'" & cboDestLo.Text.ToString
            DataGridView1.Rows(UpdtRow).Cells(ElapsedCell).Value = txtDestElapsed.Text
            DataGridView1.Rows(UpdtRow).Cells(DistCell).Value = txtDestDist.Text
            DataGridView1.Rows(UpdtRow).Cells(CalcDestLogTypeCell).Value = DestLLo
            DataGridView1.Rows(UpdtRow).Cells(CalcDestTrueCell).Value = txtDestTrue.Text
        End If

        If PlanDTChg = True Then
            For i As Integer = UpdtRow + 1 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypePlan And i <> UpdtRow Then
                    Dim DTTemp As Date = Convert.ToDateTime(DataGridView1.Rows(i).Cells(DTCell).Value)
                    If DTTemp > OriginalDT Then
                        DTTemp = DTTemp.AddSeconds(TDiff.TotalSeconds)
                        DataGridView1.Rows(i).Cells(DTCell).Value = DTTemp.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                    End If
                End If
            Next
        End If
        If DRGPSSightDTChg = True Then
            For i As Integer = UpdtRow + 1 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(LogTypeCell).Value <> g_LogTypePlan And i <> UpdtRow Then
                    Dim DTTemp As Date = Convert.ToDateTime(DataGridView1.Rows(i).Cells(DTCell).Value)
                    If DTTemp > OriginalDT Then
                        DTTemp = DTTemp.AddSeconds(TDiff.TotalSeconds)
                        DataGridView1.Rows(i).Cells(DTCell).Value = DTTemp.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                    End If
                End If
            Next
        End If
        SortDataGridonDate()
        evaluateDG()
        DisplayDGRows()
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = Nothing
        ResetSomeScreenFields()
        DisplayCommonButtons()
        DataGridView1.Refresh()
        Me.Refresh()
        IsUpdated = True
        DTChanged = False
        Exit Sub
    End Sub

    Private Sub btnDeleteSight_Click(sender As Object, e As EventArgs) Handles btnDeleteSight.Click
        ' turn addnewmode on so that any side effects of selecting / deleting a row is suppressed
        AddNewMode = True
        ' first remove selected row from DataSet and suppress side effects of updating row
        Dim currencyManager1 As CurrencyManager
        currencyManager1 = CType(Me.BindingContext(DataSet1), CurrencyManager)
        currencyManager1.SuspendBinding()
        DataSet1.Tables(tablename).Rows.RemoveAt(UpdtRow)
        ' now remove the selected row from the datagridview
        Dim DltRow As DataGridViewRow = DataGridView1.Rows(UpdtRow)
        DataGridView1.Rows.Remove(DltRow)
        currencyManager1.ResumeBinding()
        AddNewMode = False

        SortDataGridonDate()
        evaluateDG()
        DisplayDGRows()
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = Nothing

        ResetSomeScreenFields()
        DisplayCommonButtons()
        DataGridView1.Refresh()
        Me.Refresh()
        IsUpdated = True
        DTChanged = False
        Exit Sub
    End Sub
    Private Function EditUpdtFields() As Boolean
        TrueInput = False
        CompassInput = False
        ' all entry types require vessel, navigator, from and to text boxes with something in them
        If txtVessel.Text = vbNullString Or txtVessel.Text = "" Then
            ErrorMsgBox("Vessel Name must be entered")
            Return False
        End If
        If txtNavigator.Text = vbNullString Or txtNavigator.Text = "" Then
            ErrorMsgBox("Navigator Name must be entered")
            Return False
        End If
        If txtFrom.Text = vbNullString Or txtFrom.Text = "" Then
            ErrorMsgBox("From Location must be entered")
            Return False
        End If
        If txtTo.Text = vbNullString Or txtTo.Text = "" Then
            ErrorMsgBox("Destination Location must be entered")
            Return False
        End If

        ' all entries require location lat / long data be input so edit those fields
        If txtLDeg.Text = vbNullString Or txtLDeg.Text = "" Then
            ErrorMsgBox("Latitude Degrees must be entered")
            Return False
        End If
        If IsNumeric(txtLDeg.Text) = False Then
            ErrorMsgBox("Latitude Degrees must be numeric between 0 and 89")
            Return False
        End If
        Try
            UpdtRtn.LDegI = Convert.ToInt32(txtLDeg.Text)
            If UpdtRtn.LDegI < 0 Or UpdtRtn.LDegI > 89 Then
                ErrorMsgBox("Latitude Degrees must be numeric between 0 and 89")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Latitude Degrees must be numeric between 0 and 89")
            Return False
        End Try

        If txtLMin.Text = vbNullString Or txtLMin.Text = "" Then
            ErrorMsgBox("Latitude Minutes must be entered")
            Return False
        End If
        If IsNumeric(txtLMin.Text) = False Then
            ErrorMsgBox("Latitude Minutes be numeric between 0 and 59.9")
            Return False
        End If
        Try
            UpdtRtn.LMinI = Convert.ToDouble(txtLMin.Text)
            UpdtRtn.LNS = cboL.Text
            If cboL.Text = g_LatN Then
                UpdtRtn.LatDouble = Convert.ToDouble(UpdtRtn.LDegI) + UpdtRtn.LMinI / 60
            Else
                UpdtRtn.LatDouble = -1 * (Convert.ToDouble(UpdtRtn.LDegI) + UpdtRtn.LMinI / 60)
            End If
            If UpdtRtn.LMinI < 0 Or UpdtRtn.LMinI > 59.9 Then
                ErrorMsgBox("Latitude Minutes must be numeric between 0 and 59.9")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Latitude Minutes must be numeric between 0 and 59.9")
            Return False
        End Try

        If txtLoDeg.Text = vbNullString Or txtLoDeg.Text = "" Then
            ErrorMsgBox("Longitude Degrees must be entered")
            Return False
        End If
        If IsNumeric(txtLoDeg.Text) = False Then
            ErrorMsgBox("Longitude Degrees must be numeric between 0 and 89")
            Return False
        End If
        Try
            UpdtRtn.LoDegI = Convert.ToInt32(txtLoDeg.Text)
            If UpdtRtn.LoDegI < 0 Or UpdtRtn.LoDegI > 180 Then
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180")
            Return False
        End Try

        If txtLoMin.Text = vbNullString Or txtLoMin.Text = "" Then
            ErrorMsgBox("Longitude Minutes must be entered")
            Return False
        End If
        If IsNumeric(txtLoMin.Text) = False Then
            ErrorMsgBox("Longitude Minutes be numeric between 0 and 59.9")
            Return False
        End If
        Try
            UpdtRtn.LoMinI = Convert.ToDouble(txtLoMin.Text)
            UpdtRtn.LoEW = cboLo.Text
            If cboLo.Text = g_LongW Then
                UpdtRtn.LongDouble = -1 * (Convert.ToDouble(UpdtRtn.LoDegI) + UpdtRtn.LoMinI / 60)
            Else
                UpdtRtn.LongDouble = (Convert.ToDouble(UpdtRtn.LoDegI) + UpdtRtn.LoMinI / 60)
            End If
            If UpdtRtn.LoMinI < 0 Or UpdtRtn.LoMinI > 59.9 Then
                ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9")
            Return False
        End Try

        If cboLocType.Text = g_LogTypeFix And (txtRemarks.Text = vbNullString Or txtRemarks.Text = "") Then
            ErrorMsgBox("An Entry Type of Fix requires Remarks describing Fix data be entered")
            Return False
        End If
        ' due to csv file format for decklog file, all commas, line feeds, and CR/line feeds must be removed
        txtRemarks.Text = txtRemarks.Text.ToString.Replace(vbCr, "").Replace(vbCrLf, "").Replace(",", "")
        txtWeather.Text = txtWeather.Text.ToString.Replace(vbCr, "").Replace(vbCrLf, "").Replace(",", "")
        UpdtRtn.Wind = txtWind.Text.ToString
        UpdtRtn.WindDir = cboWindDir.Text.ToString
        UpdtRtn.Seas = txtSeas.Text.ToString

        If chkUseForEval.Checked = True Then
            UpdtRtn.UseForEval = "Y"
        Else
            UpdtRtn.UseForEval = "N"
        End If

        Dim TempZD As Integer = Math.Round((Convert.ToDouble(UpdtRtn.LoDegI) + UpdtRtn.LoMinI / 60) / 15, 0)
        If cboLo.Text = g_LongE Then
            TempZD = -1 * TempZD
        End If
        txtZD.Text = TempZD.ToString
        UpdtRtn.ZD = TempZD.ToString

        ' Now if this is a Fix or Waypoint type of entry then edits are done because those types only require/allow date/time and location inputs
        If cboLocType.Text = g_LogTypeFix Or cboLocType.Text = g_LogTypeWayPoint Then
            Return True
        End If

        ' A DR Track entry must have a compass course entered that is non-blank - a zero course is valid
        CompassInput = False
        If cboLocType.Text = g_LogTypeDR Or cboLocType.Text = g_LogTypeOldDR Then
            If txtCompass.Text = "" Or txtCompass.Text = vbNullString Then
                ErrorMsgBox("For DR Track Entry Compass Course must be entered - input one and try again")
                Return False
            Else
                CompassInput = True
            End If
        Else
            If txtCompass.Text = "" Or txtCompass.Text = vbNullString Then
                'Nothing()
            Else
                CompassInput = True
            End If
        End If

        ' GPS track log entries and Plan log entries must have True Course entries made - a zero true course is valid
        TrueInput = False
        If cboLocType.Text = g_LogTypeGPS Or cboLocType.Text = g_LogTypeOldGPS Or cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan Then
            If txtCTrue.Text = "" And txtCTrue.Text = vbNullString Then
                ErrorMsgBox("For GPS Track or Plan Entry a True Course must be entered - input one and try again")
                Return False
            Else
                TrueInput = True
            End If
        Else
            If txtCTrue.Text = "" And txtCTrue.Text = vbNullString Then
                ' nothing
            Else
                TrueInput = True
            End If
        End If

        If CompassInput = False And TrueInput = False And txtCTrue.Text = "" And txtCompass.Text = "" Then
            ' neither was input - issue an error message
            ErrorMsgBox("Either Compass or True Course must be entered - input one and try again")
            Return False
        End If

        ' if log type is GPS, DR, or Fix = Not a Plan type
        If cboLocType.Text = g_LogTypeDR Or cboLocType.Text = g_LogTypeOldDR Then
            If txtKnotLog.Text = "" Or txtKnotLog.Text = vbNullString Then
                ' ignore - nothing to do
            Else
                If IsNumeric(txtKnotLog.Text) = False Then
                    ErrorMsgBox("KnotLog value must be numeric text string")
                    Return False
                End If
            End If
        End If

        If CompassInput = True Then
            If txtCompass.Text = vbNullString Or txtCompass.Text = "" Then
                If cboLocType.Text = g_LogTypeFix Then
                    txtCompass.Text = "0"
                    UpdtRtn.CompassI = 0
                    'Else
                    '    ErrorMsgBox("Compass Course must be entered")
                    '    Return False

                End If
            End If
            If IsNumeric(txtCompass.Text) = False Then
                ErrorMsgBox("Compass Course must be numeric between 0 and 360")
                Return False
            End If
            Try
                UpdtRtn.CompassI = Convert.ToInt32(txtCompass.Text)
                If UpdtRtn.CompassI < 0 Or UpdtRtn.CompassI > 359 Then
                    ErrorMsgBox("Compass Course must be numeric between 0 and 360")
                    Return False
                End If
            Catch ex As Exception
                ErrorMsgBox("Compass Course must be numeric between 0 and 360")
                Return False
            End Try
        End If
        If TrueInput = True Then
            If IsNumeric(txtCTrue.Text) = False Then
                ErrorMsgBox("True Course must be numeric between 0 and 360")
                Return False
            End If
            Try
                UpdtRtn.CTrueI = Convert.ToInt32(txtCTrue.Text)
                UpdtRtn.CTrue = txtCTrue.Text.ToString
                If UpdtRtn.CTrueI < 0 Or UpdtRtn.CTrueI > 359 Then
                    ErrorMsgBox("True Course must be numeric between 0 and 360")
                    Return False
                End If
            Catch ex As Exception
                ErrorMsgBox("True Course must be numeric between 0 and 360")
                Return False
            End Try
        End If

        If txtVar.Text = vbNullString Or txtVar.Text = "" Then
            ErrorMsgBox("Variation must be entered")
            Return False
        ElseIf IsNumeric(txtVar.Text) = False Then
            ErrorMsgBox("Variation must be numeric between 0 and 20")
            Return False
        Else
            Try
                UpdtRtn.VarI = Convert.ToDouble(txtVar.Text)
                'If cboVar.Text = g_LongE Then
                '    UpdtRtn.VarI = -1 * UpdtRtn.VarI
                'End If
                UpdtRtn.Var = txtVar.Text.ToString
                UpdtRtn.VarEW = cboVar.Text
                If UpdtRtn.VarI < -20 Or UpdtRtn.VarI > 20 Then
                    ErrorMsgBox("Var Course must be numeric between -20 (E) and +20 (W)")
                    Return False
                End If
            Catch ex As Exception
                ErrorMsgBox("Var Course must be numeric between 0 and 20")
                Return False
            End Try
        End If

        If chkDev.Checked = True And AutoGCRMode = False Then
            ' if GPS or Plan log type then true route and var were input; use True and Var to compute Magnetic and intepolate Mag to get Dev and then compute Compass
            If cboLocType.Text = g_LogTypeGPS Or cboLocType.Text = g_LogTypeOldGPS Or
                cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan Then
                Dim tempvar As Integer = Convert.ToInt32(txtVar.Text.ToString)
                If cboVar.Text = g_LongE Then
                    tempvar = -1 * tempvar
                End If
                Dim TempMag As Integer = UpdtRtn.CTrueI + tempvar
                Dim rtnrec1 As DevForm.DeviationRec = DevForm.DevInterpolateMagnetic(TempMag)
                UpdtRtn.Dev = System.Math.Abs(rtnrec1.TblDev).ToString("#0")
                UpdtRtn.DevEW = rtnrec1.TblDevEW
                txtDev.Text = System.Math.Abs(rtnrec1.TblDev).ToString("#0")
                If rtnrec1.TblDevEW = g_LongW Then
                    cboDev.SelectedIndex = 0
                Else
                    cboDev.SelectedIndex = 1
                End If
                UpdtRtn.Compass = (TempMag + rtnrec1.TblDev).ToString("000")
                UpdtRtn.CompassI = TempMag + rtnrec1.TblDev
                txtCompass.Text = UpdtRtn.Compass

                ' if compass route was input then interpolate compass heading to get Dev and calculate True using Dev and Var
            ElseIf UpdtRtn.LogType = g_LogTypeDR Or UpdtRtn.LogType = g_LogTypeDRAdv Or UpdtRtn.LogType = g_LogTypeOldDR Then
                Dim rtnrec As DevForm.DeviationRec = DevForm.DevInterpolateCompass(Convert.ToInt32(txtCompass.Text.ToString))
                UpdtRtn.Dev = System.Math.Abs(rtnrec.TblDev).ToString("#0")
                UpdtRtn.DevEW = rtnrec.TblDevEW
                txtDev.Text = System.Math.Abs(rtnrec.TblDev).ToString("#0")
                If rtnrec.TblDevEW = g_LongW Then
                    cboDev.SelectedIndex = 0
                Else
                    cboDev.SelectedIndex = 1
                End If

                Dim tempvar As Integer = Convert.ToInt32(txtVar.Text.ToString)
                If cboVar.Text = g_LongW Then
                    tempvar = -1 * tempvar
                End If

                UpdtRtn.CTrue = (UpdtRtn.CompassI + rtnrec.TblDev + tempvar).ToString("000")
                UpdtRtn.CTrueI = UpdtRtn.CompassI + rtnrec.TblDev + tempvar
                txtCTrue.Text = UpdtRtn.CTrue
            End If
        End If

        ' now edit Dev field - if Dev check box is checked then the previous code has taken care of Dev field - only do this code if Dev check box is unchecked
        If chkDev.Checked = False Then
            If txtDev.Text = vbNullString Or txtDev.Text = "" Then
                ''txtDev.Text = 0
                'UpdtRtn.DevI = 0
                ErrorMsgBox("Deviation must be entered")
                Return False
            ElseIf IsNumeric(txtDev.Text) = False Then
                ErrorMsgBox("Deviation must be numeric between 0 and 20")
                Return False
            Else
                Try
                    UpdtRtn.DevI = Convert.ToDouble(txtDev.Text)
                    UpdtRtn.Dev = txtDev.Text.ToString
                    UpdtRtn.DevEW = cboDev.Text.ToString

                    If UpdtRtn.DevI < 0 Or UpdtRtn.DevI > 20 Then
                        ErrorMsgBox("Dev Course must be numeric between 0 and 20")
                        Return False
                    End If
                Catch ex As Exception
                    ErrorMsgBox("Dev Course must be numeric between 0 and 20")
                    Return False
                End Try
            End If
        End If



        If cboLocType.Text <> g_LogTypePlan And chkDev.Checked = False Then ' must be  DR track or GPS track log type and Dev check box is not checked
            If cboLocType.Text = g_LogTypeDR Or cboLocType.Text = g_LogTypeOldDR Or UpdtRtn.LogType = g_LogTypeDRAdv Then

                If cboVar.Text = g_LongW Then
                    UpdtRtn.VarI = -UpdtRtn.VarI
                End If
                If cboDev.Text = g_LongW Then
                    UpdtRtn.DevI = -UpdtRtn.DevI
                End If
                UpdtRtn.CTrueI = UpdtRtn.CompassI + UpdtRtn.VarI + UpdtRtn.DevI
                txtCTrue.Text = UpdtRtn.CTrueI.ToString("000")
                UpdtRtn.CTrue = UpdtRtn.CTrueI.ToString("000")

            End If
            If cboLocType.Text = g_LogTypeGPS Or cboLocType.Text = g_LogTypeOldGPS Or
                cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan Then
                If cboVar.Text = g_LongE Then
                    UpdtRtn.VarI = -UpdtRtn.VarI
                End If
                If cboDev.Text = g_LongE Then
                    UpdtRtn.DevI = -UpdtRtn.DevI
                End If
                UpdtRtn.CompassI = Convert.ToInt32(txtCTrue.Text.ToString) + UpdtRtn.VarI + UpdtRtn.DevI
                txtCompass.Text = UpdtRtn.CompassI.ToString("000")
                UpdtRtn.Compass = UpdtRtn.CompassI.ToString("000")
            End If
        End If

        If (cboLocType.Text = g_LogTypePlan Or cboLocType.Text = g_LogTypeOldPlan) And chkDev.Checked = False Then
            If cboVar.Text = g_LongE Then
                UpdtRtn.VarI = -UpdtRtn.VarI
            End If
            If cboDev.Text = g_LongE Then
                UpdtRtn.DevI = -UpdtRtn.DevI
            End If
            UpdtRtn.CompassI = Convert.ToInt32(txtCTrue.Text.ToString) + UpdtRtn.VarI + UpdtRtn.DevI
            txtCompass.Text = UpdtRtn.CompassI.ToString("000")
            UpdtRtn.Compass = UpdtRtn.CompassI.ToString("000")
            ' as insurance move deviation  to text field
            txtDev.Text = UpdtRtn.Dev
            If UpdtRtn.DevEW = g_LongW Then
                cboDev.SelectedIndex = 0
            Else
                cboDev.SelectedIndex = 1
            End If
        End If

        If cboLocType.Text = g_LogTypeFix Or cboLocType.Text = g_LogTypeWayPoint Then
            ' nothing to do
            txtSpeed.Text = ""
            UpdtRtn.SpeedI = 0
        Else
            If txtSpeed.Text = vbNullString Or txtSpeed.Text = "" Then
                ErrorMsgBox("Speed must be entered")
                Return False
            End If
            If IsNumeric(txtSpeed.Text) = False Then
                ErrorMsgBox("Speed must be numeric between 0 and 99")
                Return False
            End If
            Try
                UpdtRtn.SpeedI = Convert.ToDouble(txtSpeed.Text)
                If UpdtRtn.SpeedI < 0 Or UpdtRtn.SpeedI > 99 Then
                    ErrorMsgBox("Speed must be numeric between 0 and 99")
                    Return False
                End If
            Catch ex As Exception
                ErrorMsgBox("Speed must be numeric between 0 and 99")
                Return False
            End Try
        End If

        Return True
        Exit Function
    End Function
    Private Function EditPlanFields() As Boolean

        'If AddNewMode = True And AutoGCRMode = False Then
        '    If cboAdvType.SelectedIndex = 0 Then
        '        If cboAdvHrs.Value <> 0 Or cboAdvMin.Value <> 0 Then
        '            FindInstallAdvancedPlan()
        '            ' turn off Hr/Min fields for advancing time
        '            cboAdvType.Visible = False
        '            lblAdvNm.Visible = False
        '            cboAdvNm.Visible = False
        '            lblAdvHrMin.Visible = False
        '            cboAdvHrs.Visible = False
        '            cboAdvMin.Visible = False
        '            grpAdvInfo.Visible = False
        '            cboAdvNm.Value = 0
        '            cboAdvHrs.Value = 0
        '            cboAdvMin.Value = 0
        '        End If
        '    End If
        '    If cboAdvType.SelectedIndex = 1 Then
        '        If cboAdvNm.Value <> 0.0 Then
        '            FindInstallAdvancedPlan()
        '            ' turn off Hr/Min fields for advancing time
        '            cboAdvType.Visible = False
        '            lblAdvNm.Visible = False
        '            cboAdvNm.Visible = False
        '            lblAdvHrMin.Visible = False
        '            cboAdvHrs.Visible = False
        '            cboAdvMin.Visible = False
        '            grpAdvInfo.Visible = False
        '            cboAdvNm.Value = 0
        '            cboAdvHrs.Value = 0
        '            cboAdvMin.Value = 0
        '        End If
        '    End If

        'End If

        If txtDestLDeg.Text = vbNullString Or txtDestLDeg.Text = "" Then
            ErrorMsgBox("For Plan Entry, Destination Latitude Degrees must be entered")
            Return False
        End If
        If IsNumeric(txtDestLDeg.Text) = False Then
            ErrorMsgBox("For Plan Entry, Destination Latitude Degrees must be numeric between 0 and 89")
            Return False
        End If
        Try
            UpdtRtn.DestLDegI = Convert.ToInt32(txtDestLDeg.Text)

            If UpdtRtn.DestLDegI < 0 Or UpdtRtn.DestLDegI > 89 Then
                ErrorMsgBox("For Plan Entry, Destination Latitude Degrees must be numeric between 0 and 89")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("For Plan Entry, DestinationLatitude Degrees must be numeric between 0 and 89")
            Return False
        End Try

        If txtDestLMin.Text = vbNullString Or txtDestLMin.Text = "" Then
            ErrorMsgBox("For Plan Entry, Latitude Minutes must be entered")
            Return False
        End If
        If IsNumeric(txtDestLMin.Text) = False Then
            ErrorMsgBox("For Plan Entry, Latitude Minutes be numeric between 0 and 59.9")
            Return False
        End If
        Try
            UpdtRtn.DestLMinI = Convert.ToDouble(txtDestLMin.Text)
            UpdtRtn.DestLNS = cboDestL.Text
            If UpdtRtn.DestLNS = g_LatN Then
                UpdtRtn.DestLatDouble = (UpdtRtn.DestLDegI) + UpdtRtn.DestLMinI / 60
            Else
                UpdtRtn.DestLatDouble = -1 * ((UpdtRtn.DestLDegI) + UpdtRtn.DestLMinI / 60)
            End If
            If UpdtRtn.DestLMinI < 0 Or UpdtRtn.DestLMinI > 59.9 Then
                ErrorMsgBox("For Plan Entry, Latitude Minutes must be numeric between 0 and 59.9")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("For Plan Entry, Latitude Minutes must be numeric between 0 and 59.9")
            Return False
        End Try

        If txtDestLoDeg.Text = vbNullString Or txtDestLDeg.Text = "" Then
            ErrorMsgBox("For Plan Entry, Longitude Degrees must be entered")
            Return False
        End If
        If IsNumeric(txtDestLoDeg.Text) = False Then
            ErrorMsgBox("For Plan Entry, Longitude Degrees must be numeric between 0 and 89")
            Return False
        End If
        Try
            UpdtRtn.DestLoDegI = Convert.ToInt32(txtDestLoDeg.Text)
            If UpdtRtn.DestLoDegI < 0 Or UpdtRtn.DestLoDegI > 180 Then
                ErrorMsgBox("For Plan Entry, Longitude Degrees must be numeric between 0 and 180")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("For Plan Entry, Longitude Degrees must be numeric between 0 and 180")
            Return False
        End Try

        If txtDestLoMin.Text = vbNullString Or txtDestLoMin.Text = "" Then
            ErrorMsgBox("For Plan Entry, Longitude Minutes must be entered")
            Return False
        End If
        If IsNumeric(txtDestLoMin.Text) = False Then
            ErrorMsgBox("For Plan Entry, Longitude Minutes be numeric between 0 and 59.9")
            Return False
        End If
        Try

            UpdtRtn.DestLoMinI = Convert.ToDouble(txtDestLoMin.Text)
            UpdtRtn.DestLoEW = cboDestLo.Text
            If UpdtRtn.DestLoEW = g_LongW Then
                UpdtRtn.DestLongDouble = -1 * ((UpdtRtn.DestLoDegI) + UpdtRtn.DestLoMinI / 60.0)
            Else
                UpdtRtn.DestLongDouble = ((UpdtRtn.DestLoDegI) + UpdtRtn.DestLoMinI / 60.0)
            End If
            ' If the destination Longitude is 0 degrees 0 minutes then the minutes must reset to 1 minute for other math to work elsewhere
            If UpdtRtn.DestLoDegI = 0 And UpdtRtn.DestLoMinI = 0 Then
                UpdtRtn.DestLoMinI = 1
            End If
            If UpdtRtn.DestLoMinI < 0 Or UpdtRtn.DestLoMinI > 59.9 Then
                ErrorMsgBox("For Plan Entry, Longitude Minutes must be numeric between 0 and 59.9")
                Return False
            End If
        Catch ex As Exception
            ErrorMsgBox("For Plan Entry, Longitude Minutes must be numeric between 0 and 59.9")
            Return False
        End Try

        ' the evaluation of these plan entry fields are done here because the evaluateDB routine works on pairs of entries together. A plan entry has all its data in one entry
        ' now create a GeoCoordinate object for each set of Lat & Long for subsequent function calls
        Dim Loc1 As System.Device.Location.GeoCoordinate = New Device.Location.GeoCoordinate(UpdtRtn.LatDouble, UpdtRtn.LongDouble)
        Dim Loc2 As System.Device.Location.GeoCoordinate = New Device.Location.GeoCoordinate(UpdtRtn.DestLatDouble, UpdtRtn.DestLongDouble)
        ' Get the distance from origin Lat/Long to destination Lat/Long and format results into text display field
        Dim DestDist As Double = GetDistance(UpdtRtn.LatDouble, UpdtRtn.LongDouble, UpdtRtn.DestLatDouble, UpdtRtn.DestLongDouble)
        txtDestDist.Text = DestDist.ToString("##0.0") & "nm"
        ' Get the true heading from origin Lat/Long to destination Lat/Long and format display text field
        Dim TempHeading As Integer = Int(GetHeading(UpdtRtn.LatDouble, UpdtRtn.LongDouble, UpdtRtn.DestLatDouble, UpdtRtn.DestLongDouble))
        txtDestTrue.Text = TempHeading.ToString("##0") & Chr(176)
        ' no matter what was entered the true bearing to steer is the calculated one - so it is installed along with the compass bearing recalculated.
        txtCTrue.Text = TempHeading.ToString("##0")    'txtDestTrue.Text.Trim(Chr(176))
        UpdtRtn.CTrue = TempHeading.ToString("##0") 'txtDestTrue.Text.Trim(Chr(176))
        UpdtRtn.CTrueI = TempHeading 'Convert.ToInt32(txtDestTrue.Text.Trim(Chr(176)))
        UpdtRtn.CompassI = UpdtRtn.CTrueI + UpdtRtn.VarI + UpdtRtn.DevI
        txtCompass.Text = UpdtRtn.CompassI.ToString("000")
        ' Using the calculated distance to destination, get the elapsed time to destination using declared speed and starting date/time
        Dim DestElapsed As TimeSpan = Calc60DSTElapsed(DTDateZoneTime.Value, Convert.ToDouble(txtSpeed.Text), DestDist)
        If DestElapsed.Days = 0 Then
            txtDestElapsed.Text = DestElapsed.ToString("hh\:mm\:ss")
        Else
            txtDestElapsed.Text = DestElapsed.ToString("d\d\y\ hh\:mm\:ss")
        End If
        DestEstArrival = DTDateZoneTime.Value.AddMinutes(DestElapsed.TotalMinutes)

        ' Is the Celestial Tools Sailings form open
        If System.Windows.Forms.Application.OpenForms().OfType(Of FormSailings).Any Then
            ' check if the Sailings form has a Great Circle Route ready generated and we must be in AddNew mode and not in generating a GCR in this module
            If FormSailings.GCRAvailable = True And chkImportGCR.Checked = True And AddNewMode = True And AutoGCRMode = False Then
                Dim MsgBack As MsgBoxResult = MsgBox("Great Circle Route Plan availble to load from Sailings form. Load? - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
                If MsgBack = MsgBoxResult.Yes Then
                    ReDim GCRArray(UBound(FormSailings.GCRArray))

                    For i As Integer = 0 To UBound(FormSailings.GCRArray)
                        GCRArray(i).LongStr = FormSailings.GCRArray(i).LongStr
                        GCRArray(i).LatStr = FormSailings.GCRArray(i).LatStr
                        GCRArray(i).CTrue = FormSailings.GCRArray(i).CTrue
                        GCRArray(i).GCRDist = FormSailings.GCRArray(i).GCRDist
                    Next

                    ' Process the captured GCR array into new Plan entries 
                    ProcessGCRArray()
                    ' Clean out the capture GCR array in case this is done back to back 
                    ReDim GCRArray(0)
                    ReDim FormSailings.GCRArray(0)
                    FormSailings.GCRAvailable = False
                    chkImportGCR.Checked = False
                    chkImportGCR.Visible = False
                    Return True
                End If
            End If
        End If

        ' Is the Distance of this Plan Entry > 500 nm and are we doing the Add of New Entry and is this a manual entry not an auto generated entry - see ProcessGCRArray() below
        If DestDist > GCRThreshhold And AddNewMode = True And AutoGCRMode = False Then
            If chkPlanGCR.Checked = True Then
                Dim MsgBack As MsgBoxResult = MsgBox("Use Sailings GCR Form to create Great Circle Route = Yes or Use Rhumb Line of two Plan Entries = No", MsgBoxStyle.YesNo, "Use Sailings Greate Circle Route Form?")
                If MsgBack = MsgBoxResult.Yes Then
                    ' Pop up the Sailings form, fill in the start Lat/Long for this entry and the destination lat/long - click calculate button and then click the GCR cmdPoints button
                    FormSailings.Show()
                    FormSailings.txtL1Deg.Text = txtLDeg.Text
                    FormSailings.txtL1Min.Text = txtLMin.Text
                    FormSailings.cboL1.Text = cboL.Text
                    FormSailings.txtLo1Deg.Text = txtLoDeg.Text
                    FormSailings.txtLo1Min.Text = txtLoMin.Text
                    FormSailings.cboLo1.Text = cboLo.Text

                    FormSailings.txtL2Deg.Text = txtDestLDeg.Text
                    FormSailings.txtL2Min.Text = txtDestLMin.Text
                    FormSailings.cboL2.Text = cboDestL.Text
                    FormSailings.txtLo2Deg.Text = txtDestLoDeg.Text
                    FormSailings.txtLo2Min.Text = txtDestLoMin.Text
                    FormSailings.cboLo2.Text = cboDestLo.Text

                    FormSailings.optGreatCircle.Checked = True
                    FormSailings.cmdCalculate.PerformClick()
                    FormSailings.cmdPoints.PerformClick()

                    ' now the frmPointsOnGCR form will display - on it will be a datagridview DGGCR with each Long / Lat / True course / Distance in nm - capture them in local array
                    ReDim GCRArray(frmPointsOnGCR.DGGCR.Rows.Count - 2)

                    For i As Integer = 0 To frmPointsOnGCR.DGGCR.Rows.Count - 2
                        GCRArray(i).LongStr = frmPointsOnGCR.DGGCR.Rows(i).Cells(0).Value
                        GCRArray(i).LatStr = frmPointsOnGCR.DGGCR.Rows(i).Cells(1).Value
                        GCRArray(i).CTrue = frmPointsOnGCR.DGGCR.Rows(i).Cells(2).Value
                        GCRArray(i).GCRDist = frmPointsOnGCR.DGGCR.Rows(i).Cells(3).Value
                    Next

                    ' now close the GCR form and then close the Sailings form
                    frmPointsOnGCR.ExitBtn.PerformClick()
                    FormSailings.ExitBtn.PerformClick()

                    ' Process the captured GCR array into new Plan entries 
                    ProcessGCRArray()
                    ' Clean out the capture GCR array in case this is done back to back 
                    ReDim GCRArray(0)

                    Return True
                End If
            End If
        End If
        Dim ZDLoc1 As Integer = Math.Round(Loc1.Longitude / 15, 0, MidpointRounding.AwayFromZero)
        Dim ZDLoc2 As Integer = Math.Round(Loc2.Longitude / 15, 0, MidpointRounding.AwayFromZero)
        If cboDestLo.Text = g_LongE Then
            txtDestZD.Text = "+" & Math.Abs(ZDLoc2).ToString
        Else
            txtDestZD.Text = "-" & Math.Abs(ZDLoc2).ToString
        End If

        If ZDLoc1 <> ZDLoc2 Then ' Origin to Destination ZD are the not the same then we have passed into next time zone - use ZTInfo to plan arrival time
            If AutoGCRMode = False Then
                Dim MsgBack As MsgBoxResult = MsgBox("Destination Longitude passes into new Time Zone. Do you want to use ZTInfo form to plan arrival time? Yes = Use ZTInfo OR No = Use Default Info", MsgBoxStyle.YesNo, "Calculate Destination ZD Info?")
                If MsgBack = MsgBoxResult.Yes Then
                    ZTInfo.InvokedbyDeckLog = True
                    DestDTUpdatedbyZTInfo = False
                    ZTInfo.txtLoDegA.Text = txtLoDeg.Text
                    ZTInfo.txtLoMinA.Text = txtLoMin.Text
                    ZTInfo.cboLoA.Text = cboLo.Text
                    ZTInfo.DTLocA.Value = DTDateZoneTime.Value
                    ZTInfo.txtLoDegB.Text = txtDestLoDeg.Text
                    ZTInfo.txtLoMinB.Text = txtDestLoMin.Text
                    ZTInfo.cboLoB.Text = g_LongE
                    If Loc2.Longitude < 0 Then
                        ZTInfo.cboLoB.Text = g_LongW
                    End If

                    ZTInfo.DT1Days.Value = 0
                    ZTInfo.DT1Hours.Value = Convert.ToInt32(cboAdvHrs.Value.ToString)
                    ZTInfo.DT1Minutes.Value = Convert.ToInt32(cboAdvMin.Value.ToString)
                    DestDTUpdatedbyZTInfo = False
                    ZTInfo.Show()
                    ZTInfo.cboLocAZD.SelectedIndex = 0
                    ZTInfo.cboLocBZD.SelectedIndex = 0
                    While DestDTUpdatedbyZTInfo = False
                        System.Threading.Thread.Sleep(500) ' sleep for 500 milliseconds or 1/2 second
                        System.Windows.Forms.Application.DoEvents()
                    End While
                    ZTInfo.SendToBack()
                    If ZTInfo.InvokedbyDeckLog = True Then
                        If DestDTUpdatedbyZTInfo = True Then
                            DestEstArrival = DestDTfromZTInfo
                            DestDTUpdatedbyZTInfo = False
                            ZTInfo.InvokedbyDeckLog = False
                        Else
                            SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)
                            ZTInfo.InvokedbyDeckLog = False
                            DestDTUpdatedbyZTInfo = False
                        End If
                    Else
                        SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)
                        ZTInfo.InvokedbyDeckLog = False
                        DestDTUpdatedbyZTInfo = False
                    End If
                Else
                    SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)
                    ZTInfo.InvokedbyDeckLog = False
                    DestDTUpdatedbyZTInfo = False
                End If
                txtRemarks.Text = "Estimated Arrival Time for Plan Log Entry:" & DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                txtEstArrival.Text = DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
            Else
                ZTInfo.InvokedbyDeckLog = True
                DestDTUpdatedbyZTInfo = False

                ZTInfo.txtLoDegA.Text = txtLoDeg.Text
                ZTInfo.txtLoMinA.Text = txtLoMin.Text
                ZTInfo.cboLoA.Text = cboLo.Text
                ZTInfo.DTLocA.Value = DTDateZoneTime.Value
                ZTInfo.txtLoDegB.Text = txtDestLoDeg.Text
                ZTInfo.txtLoMinB.Text = txtDestLoMin.Text
                ZTInfo.cboLoB.Text = g_LongE
                If Loc2.Longitude < 0 Then
                    ZTInfo.cboLoB.Text = g_LongW
                End If
                ZTInfo.DT1Days.Value = 0
                ZTInfo.DT1Hours.Value = Convert.ToInt32(cboAdvHrs.Value.ToString)
                ZTInfo.DT1Minutes.Value = Convert.ToInt32(cboAdvMin.Value.ToString)
                DestDTUpdatedbyZTInfo = False
                ZTInfo.Show()
                ZTInfo.cboLocAZD.SelectedIndex = 0
                ZTInfo.cboLocBZD.SelectedIndex = 0
                While DestDTUpdatedbyZTInfo = False
                    System.Threading.Thread.Sleep(500) ' sleep for 500 milliseconds or 1/2 second
                    System.Windows.Forms.Application.DoEvents()
                End While
                ZTInfo.SendToBack()
                If ZTInfo.InvokedbyDeckLog = True Then
                    If DestDTUpdatedbyZTInfo = True Then
                        DestEstArrival = DestDTfromZTInfo
                        DestDTUpdatedbyZTInfo = False
                        ZTInfo.InvokedbyDeckLog = False
                    Else
                        SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)
                        ZTInfo.InvokedbyDeckLog = False
                        DestDTUpdatedbyZTInfo = False
                    End If
                Else
                    SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)
                    ZTInfo.InvokedbyDeckLog = False
                    DestDTUpdatedbyZTInfo = False
                End If
                ZTInfo.ExitBtn.PerformClick()
                SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)

                txtRemarks.Text = "Entry #" & RcdCount.ToString("##0") & " on generated Great Circle Route. Estimated Arrival Time for Plan Log Entry:" & DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                txtEstArrival.Text = DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                ' now do autotransfer of plan dest info calc'd for auto GCR entry to entry fields
                DTDateZoneTime.Value = DestEstArrival
            End If
        Else
            If AutoGCRMode = True Then
                DestEstArrival = DTDateZoneTime.Value.AddMinutes(DestElapsed.TotalMinutes)
                txtRemarks.Text = "Entry #" & RcdCount.ToString("##0") & " on generated Great Circle Route. Estimated Arrival Time for Plan Log Entry:" & DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                txtEstArrival.Text = DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                ' now do autotransfer of plan dest info calc'd for auto GCR entry to entry fields
                DTDateZoneTime.Value = DestEstArrival
            Else
                SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes)
                ZTInfo.InvokedbyDeckLog = False
                DestDTUpdatedbyZTInfo = False
                txtRemarks.Text = "Estimated Arrival Time for Plan Log Entry:" & DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
                txtEstArrival.Text = DestEstArrival.ToString(DTFormatString) '("MM/dd/yyyy HH:mm:ss")
            End If
        End If

        Return True
    End Function

    Private Sub SetDestinationZoneTime(ByVal ZDLoc1 As Integer, ByVal ZDLoc2 As Integer, ByVal TotMin As Double)
        Dim IncrHr As Integer = ZDLoc2 - ZDLoc1
        If Math.Sign(ZDLoc1) <> Math.Sign(ZDLoc2) Then ' we have crossed the IDL
            If ZDLoc1 < 0 And ZDLoc2 > 0 Then ' moving from West (ZD negative) to East (ZD positive)
                IncrHr = -1 * ZDLoc1 - ZDLoc2
            End If
            If ZDLoc1 > 0 And ZDLoc2 < 0 Then ' moving from East (ZD positive) to West (ZD negative)
                IncrHr = -1 * ZDLoc1 + ZDLoc2
            End If
        End If
        ' Set the destination time to the origin DTDate plus elapsed total minutes - then add or subtract time zone difference of 1 hour
        DestEstArrival = DTDateZoneTime.Value.AddMinutes(TotMin)
        DestEstArrival = DestEstArrival.AddHours(IncrHr)
        Exit Sub
    End Sub

    Private Function ReturnDestinationZoneTime(ByVal ZDLoc1 As Integer, ByVal ZDLoc2 As Integer, ByVal TotMin As Double, ByVal TimeIn As DateTime) As DateTime
        Dim IncrHr As Integer = 0
        Dim RtnDatetime As DateTime = TimeIn
        If Math.Sign(ZDLoc1) <> Math.Sign(ZDLoc2) Then ' we have crossed the IDL
            If ZDLoc1 < 0 And ZDLoc2 > 0 Then ' moving from West (ZD negative) to East (ZD positive)
                IncrHr = -1 * ZDLoc1 - ZDLoc2
            End If
            If ZDLoc1 > 0 And ZDLoc2 < 0 Then ' moving from East (ZD positive) to West (ZD negative)
                IncrHr = -1 * ZDLoc1 + ZDLoc2
            End If
        Else
            IncrHr = ZDLoc2 - ZDLoc1
        End If
        ' Set the destination time to the origin DTDate plus elapsed total minutes - then add or subtract time zone difference of 1 hour
        RtnDatetime = DTDateZoneTime.Value.AddMinutes(TotMin)
        RtnDatetime = RtnDatetime.AddHours(IncrHr)
        Return RtnDatetime
        Exit Function
    End Function
    Public Sub ResetSomeScreenFields()
        'txtVessel.Clear()
        'txtNavigator.Clear()
        'txtFrom.Clear()
        'txtTo.Clear()
        'DTDateZoneTime.Value = Now
        'txtCompass.Clear()
        'txtVar.Clear()
        'txtDev.Clear()
        'txtCTrue.Clear()
        'txtSpeed.Clear()
        'txtLDeg.Clear()
        'txtLMin.Clear()
        'txtLoDeg.Clear()
        'txtLoMin.Clear()
        txtWeather.Clear()
        txtRemarks.Clear()

        'txtWind.Clear()
        'cboWindDir.Text = ""
        'txtSeas.Clear()

        'cboLocType.Text = ""
        'cboL.SelectedIndex = 0
        'cboLo.SelectedIndex = 0
        'cboVar.SelectedIndex = 0
        'cboDev.SelectedIndex = 0
        'chkDev.Checked = False
        ' clear and make invisible the advance fields and the plan dest fields
        txtDestLDeg.Clear()
        txtDestLMin.Clear()
        txtDestLoDeg.Clear()
        txtDestLoMin.Clear()
        txtDestTrue.Clear()
        txtDestDist.Clear()
        txtDestElapsed.Clear()
        txtEstArrival.Clear()

        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        cboAdvType.Visible = False
        grpAdvInfo.Visible = False
        grpbxPlan.Visible = False

        DTChanged = False
        DRAdvanceMode = False
        'UpdtRow = Nothing
        AddNewMode = False
        HideCommonButtons()
        Exit Sub
    End Sub
    Private Sub ResetScreenFieldsforPlan()
        ' make visible plan dest fields and enable 
        grpbxPlan.Visible = True
        grpbxPlan.BackColor = PlanBackColor
        grpbxPlan.ForeColor = PlanForeColor

        chkPlanGCR.Visible = True
        txtSpeed.Enabled = True
        txtSpeed.BackColor = Color.Yellow
        txtDev.Enabled = True
        txtDev.BackColor = Color.Yellow
        cboDev.Enabled = True
        chkDev.Visible = True

        txtCompass.Enabled = False
        txtCompass.BackColor = Color.Aqua
        txtCTrue.Enabled = True
        txtCTrue.BackColor = Color.Yellow
        'txtCTrue.Text = ""
        txtDev.Enabled = True
        txtVar.Enabled = True
        txtVar.BackColor = Color.Yellow
        cboVar.Enabled = True

        lblKnotLog.Visible = False
        txtKnotLog.Visible = False
        txtKnotLog.BackColor = Color.Aqua

        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0.0
        cboAdvType.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        grpAdvInfo.Visible = False
        DRAdvanceMode = False
        Exit Sub
    End Sub
    Private Sub ResetScreenFieldsforGPS()
        grpbxPlan.Visible = False
        grpWeather.Visible = True
        chkPlanGCR.Visible = False

        txtSpeed.Enabled = True
        txtSpeed.BackColor = Color.Yellow
        txtDev.Enabled = True
        txtDev.BackColor = Color.Yellow
        cboDev.Enabled = True
        chkDev.Visible = True

        txtCompass.Clear()
        txtCompass.Enabled = False
        txtCompass.BackColor = Color.Aqua
        txtCTrue.Enabled = True
        'txtCTrue.Text = 0
        txtCTrue.BackColor = Color.Yellow
        txtVar.Enabled = True
        txtVar.BackColor = Color.Yellow
        cboVar.Enabled = True

        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0.0
        cboAdvType.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        grpAdvInfo.Visible = False
        DRAdvanceMode = False

        lblKnotLog.Visible = True
        txtKnotLog.Visible = True
        txtKnotLog.BackColor = Color.Yellow
        Exit Sub
    End Sub
    Private Sub ResetScreenFieldsforDRAdvance()
        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0.0
        cboAdvType.Visible = True
        cboAdvType.Enabled = True
        lblAdvNm.Visible = True
        cboAdvNm.Visible = True
        lblAdvHrMin.Visible = True
        cboAdvHrs.Visible = True
        cboAdvMin.Visible = True
        grpAdvInfo.Visible = True
        cboAdvType.SelectedIndex = 0

        'DRAdvanceDGSave = DataGridView1.CurrentCell.RowIndex
        DTAdvDTSave = DTDateZoneTime.Value
        ' the DR Advance processing takes place when the Zone Date/Time field is changed and the subroutine to advance the DR is activated
        ' For a DR calc (Advance this DR to future time) 
        btnAddNew.Visible = True
        btnClearFields.Visible = True
        btnUpdateExisting.Visible = False
        btnDeleteSight.Visible = False
        ' make invisible plan dest fields and disable 
        grpbxPlan.Visible = False
        chkPlanGCR.Visible = False
        ' protect all speed, heading, variation, and deviation fields because we are advancing using them
        txtSpeed.Enabled = True
        txtSpeed.BackColor = Color.Yellow
        txtDev.Enabled = True
        txtDev.BackColor = Color.Yellow
        cboDev.Enabled = True
        chkDev.Visible = True

        txtCompass.Enabled = False
        txtCompass.BackColor = Color.Aqua

        txtCTrue.Enabled = False
        txtCTrue.BackColor = Color.Aqua
        txtVar.BackColor = Color.Aqua
        txtVar.Enabled = False
        txtDev.Enabled = False
        txtDev.BackColor = Color.Aqua
        'txtSpeed.Enabled = False
        'txtSpeed.BackColor = Color.Aqua
        lblKnotLog.Visible = True
        txtKnotLog.Visible = True
        txtKnotLog.BackColor = Color.Yellow

        grpWeather.Visible = True
        Exit Sub
    End Sub
    Private Sub ResetScreenFieldsforDR()
        grpWeather.Visible = True
        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0.0
        cboAdvType.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        grpAdvInfo.Visible = False

        DRAdvanceMode = False
        ' make invisible plan dest fields and disable 
        grpbxPlan.Visible = False
        chkPlanGCR.Visible = False

        txtSpeed.Enabled = True
        txtSpeed.BackColor = Color.Yellow
        txtDev.Enabled = True
        txtDev.BackColor = Color.Yellow
        cboDev.Enabled = True
        chkDev.Visible = True

        txtCompass.Enabled = True
        txtCompass.BackColor = Color.Yellow
        txtCTrue.Enabled = False
        txtCTrue.BackColor = Color.Aqua
        txtCTrue.Clear()
        txtVar.Enabled = True
        txtVar.BackColor = Color.Yellow
        cboVar.Enabled = True
        'cboVar.SelectedIndex = 0
        lblKnotLog.Visible = True
        txtKnotLog.Visible = True
        txtKnotLog.BackColor = Color.Yellow
        Exit Sub
    End Sub
    Private Sub ResetScreenFieldsForWPFix()

        txtCompass.Clear()
        txtCompass.Enabled = False
        txtCompass.BackColor = Color.Aqua
        txtVar.Clear()
        txtVar.Enabled = False
        txtVar.BackColor = Color.Aqua
        cboVar.Enabled = False
        cboVar.SelectedIndex = 0
        txtDev.Clear()
        txtDev.Enabled = False
        txtDev.BackColor = Color.Aqua
        cboDev.Enabled = False
        chkDev.Visible = False
        txtCTrue.Clear()
        txtCTrue.Enabled = False
        txtCTrue.BackColor = Color.Aqua
        txtSpeed.Clear()
        txtSpeed.Enabled = False
        txtSpeed.BackColor = Color.Aqua
        txtWeather.Clear()
        txtWeather.Enabled = False
        txtRemarks.Clear()
        txtRemarks.Enabled = False

        txtWind.Clear()
        cboWindDir.Text = ""
        txtSeas.Clear()
        grpWeather.Visible = False

        txtDestLDeg.Clear()
        txtDestLMin.Clear()
        txtDestLoDeg.Clear()
        txtDestLoMin.Clear()
        txtDestTrue.Clear()
        txtDestDist.Clear()
        txtDestElapsed.Clear()
        txtEstArrival.Clear()

        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0.0

        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        cboAdvType.Visible = False
        grpAdvInfo.Visible = False
        grpbxPlan.Visible = False

        chkPlanGCR.Visible = False
        lblKnotLog.Visible = False
        txtKnotLog.Visible = False
        txtKnotLog.BackColor = Color.Aqua

        DTChanged = False
        DRAdvanceMode = False
        'UpdtRow = Nothing
        AddNewMode = False
        'HideCommonButtons()
        Exit Sub
    End Sub
    Public Sub ResetAllScreenFields()
        txtVessel.Clear()
        txtNavigator.Clear()
        txtFrom.Clear()
        txtTo.Clear()
        DTDateZoneTime.Value = Now
        txtCompass.Clear()
        txtVar.Clear()
        txtDev.Clear()
        txtCTrue.Clear()
        txtSpeed.Clear()
        txtLDeg.Clear()
        txtLMin.Clear()
        txtLoDeg.Clear()
        txtLoMin.Clear()
        txtWeather.Clear()
        txtWind.Clear()
        cboWindDir.Text = ""
        txtSeas.Clear()

        txtRemarks.Clear()
        cboLocType.Text = ""
        cboL.SelectedIndex = 0
        cboLo.SelectedIndex = 0
        cboVar.SelectedIndex = 0
        cboDev.SelectedIndex = 0
        chkDev.Checked = False
        txtDestLDeg.Clear()
        txtDestLMin.Clear()
        txtDestLoDeg.Clear()
        txtDestLoMin.Clear()
        txtDestTrue.Clear()
        txtDestDist.Clear()
        txtDestElapsed.Clear()
        txtEstArrival.Clear()

        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        cboAdvType.Visible = False
        grpAdvInfo.Visible = False

        grpbxPlan.Visible = False

        txtVar.Clear()
        txtDev.Clear()
        CompassInput = False
        TrueInput = False

        DTChanged = False
        DRAdvanceMode = False
        UpdtRow = Nothing
        AddNewMode = False
        HideCommonButtons()
        Exit Sub
    End Sub
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        btnDeleteSight.Visible = False
        btnUpdateExisting.Visible = False
        ResetAllScreenFields()
        Exit Sub
    End Sub
    Private Function FindDeleteRows() As Integer
        Dim DGLimit As Integer = DataGridView1.Rows.Count
        For i As Integer = 0 To DGLimit - 1
            If DataGridView1.Rows(i).Cells(LogTypeCell).Value = "Delete" Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub RemoveEmptyRowsinDG()
        Dim DGLimit As Integer = DataGridView1.Rows.Count
        For i As Integer = 0 To DGLimit - 1
            If DataGridView1.Rows(i).Cells(LogTypeCell).Value = vbNullString Or DataGridView1.Rows(i).Cells(LogTypeCell).Value = "" Then
                DataGridView1.Rows(i).Cells(LogTypeCell).Value = "Delete"
                DataGridView1.Rows(i).Cells(DTCell).Value = MaxDate
            End If
        Next
        Dim DltRow As Integer = FindDeleteRows()
        While DltRow <> -1
            Dim RowToDlt As DataGridViewRow = DataGridView1.Rows(DltRow)
            DataGridView1.Rows.Remove(RowToDlt)
            DltRow = FindDeleteRows()
        End While
        Exit Sub
    End Sub
    Private Sub SortDataGridonDate()
        SortingDG = True

        DataGridView1.Sort(DataGridView1.Columns(DTCell), System.ComponentModel.ListSortDirection.Ascending)
        'For i As Integer = 0 To DataGridView1.Columns.Count - 1
        '    DataGridView1.AutoResizeColumn(i)
        'Next
        ' select last row in data grid - this code removed when filtering display on all/plan/track added. It was making the filtering impossible.
        'Dim LastRow As Integer = DataGridView1.Rows.Count - 1
        'DataGridView1.CurrentCell = DataGridView1.Rows(LastRow).Cells(4)
        'DataGridView1.Rows(LastRow).Selected = True
        SortingDG = False
        Exit Sub
    End Sub
    Private Sub evaluateDG()
        If InitialLoad = True Then Exit Sub
        If FileLoading = True Then Exit Sub
        Dim DGlimit As Integer = DataGridView1.Rows.Count
        Dim PrevGPSFIXExists As Boolean = False
        Dim PrevGPSFix As Integer = 0
        Dim PrevDRExists As Boolean = False
        Dim PrevDR As Integer = 0
        Dim PrevWPTFixExists As Boolean = False
        Dim PrevWPTFix As Integer = 0
        If DGlimit = 1 Then
            'ErrorMsgBox("Nothing to evaluate - the Data Grid only has one entry")
            Exit Sub
        End If

        ' spin thru the datagridview and install the current and correct ZD based on the longitude
        For i As Integer = 0 To DGlimit - 1
            If DataGridView1.Rows(i).Cells(LogTypeCell).Value = vbNullString Or DataGridView1.Rows(i).Cells(LogTypeCell).Value = "" Then
                ' nothing
            Else
                Dim GeoLLo1 As Device.Location.GeoCoordinate = ParseLatLong(DataGridView1.Rows(i).Cells(DestLogTypeCell).Value)
                DataGridView1.Rows(i).Cells(ZDCell).Value = Math.Round(GeoLLo1.Longitude / 15, 0)
            End If
        Next

        If DataGridView1.Rows(0).Cells(LogTypeCell).Value = g_LogTypeGPS Or DataGridView1.Rows(0).Cells(LogTypeCell).Value = g_LogTypeOldGPS Then
            If DataGridView1.Rows(0).Cells(UseForEvalCell).Value = "Y" Then
                PrevGPSFIXExists = True
                PrevGPSFix = 0
            End If
        End If

        If DataGridView1.Rows(0).Cells(LogTypeCell).Value = g_LogTypeDR Or DataGridView1.Rows(0).Cells(LogTypeCell).Value = g_LogTypeOldDR Then
            If DataGridView1.Rows(0).Cells(UseForEvalCell).Value = "Y" Then
                PrevDRExists = True
                PrevDR = 0
            End If

        End If
        If DataGridView1.Rows(0).Cells(LogTypeCell).Value = g_LogTypeFix Or DataGridView1.Rows(0).Cells(LogTypeCell).Value = g_LogTypeWayPoint Then
            If DataGridView1.Rows(0).Cells(UseForEvalCell).Value = "Y" Then
                PrevWPTFixExists = True
                PrevWPTFix = 0
            End If
        End If


        ' now pass thru the data grid from the second record to the end evaluate each pair of records and calculating the final route results
        For i As Integer = 1 To DGlimit - 1

            If DataGridView1.Rows(i).Cells(LogTypeCell).Value <> g_LogTypePlan Then
                DataGridView1.Rows(i).Cells(ElapsedCell).Value = "" ' Elapsed Time
                DataGridView1.Rows(i).Cells(DistCell).Value = "" ' Distance
                DataGridView1.Rows(i).Cells(CalcDestLogTypeCell).Value = "" ' Calc Loc L/Lo
                DataGridView1.Rows(i).Cells(CalcDestTrueCell).Value = "" ' CMG
                DataGridView1.Rows(i).Cells(CalcDestSpeedCell).Value = "" ' SMG
                DataGridView1.Rows(i).Cells(CalcSetCell).Value = "" ' Set 
                DataGridView1.Rows(i).Cells(CalcDriftCell).Value = "" ' Drift
                DataGridView1.Rows(i).Cells(EvalCell).Value = "" ' Eval Based On
            Else
                DataGridView1.Rows(i).Cells(CalcSetCell).Value = "" ' Set 
                DataGridView1.Rows(i).Cells(CalcDriftCell).Value = "" ' Drift
                DataGridView1.Rows(i).Cells(EvalCell).Value = "" ' Eval Based On
            End If

            ' now pass thru the datagridview and evaluate pairs of log entries - GPS entries, DR and Fix entries, and WayPoints. 
            ' Ignore Plan entries because they are analyzed when they are created
            If DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypePlan Then
                DataGridView1.Rows(i).Cells(EvalCell).Value = "Planned Route Entry"
            ElseIf DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypeGPS Or
                DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypeOldGPS Then
                If PrevGPSFIXExists = True Then
                    EvaluateDBPairs(i, PrevGPSFix, True)
                    DataGridView1.Rows(i).Cells(EvalCell).Value = "GPS Track: " & DataGridView1.Rows(PrevGPSFix).Cells(DTCell).Value
                    If DataGridView1.Rows(i).Cells(UseForEvalCell).Value = "Y" Then
                        PrevGPSFix = i
                    End If
                Else
                    If DataGridView1.Rows(i).Cells(UseForEvalCell).Value = "Y" Then
                        PrevGPSFIXExists = True
                        PrevGPSFix = i
                    End If
                End If
                ' evaluate DR Tracks and Fixes together since a Fix should be taken relative to the DR track (although a GPS basis could be argued as needed here)
            ElseIf DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypeDR Or
            DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypeOldDR Or
            DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypeFix Then
                If PrevDRExists = True Then
                    EvaluateDBPairs(i, PrevDR, False)
                    DataGridView1.Rows(i).Cells(EvalCell).Value = "DR/Fix from: " & DataGridView1.Rows(PrevDR).Cells(DTCell).Value
                    If DataGridView1.Rows(i).Cells(UseForEvalCell).Value = "Y" Then
                        PrevDR = i
                    End If
                Else
                    If DataGridView1.Rows(i).Cells(UseForEvalCell).Value = "Y" Then
                        PrevDRExists = True
                        PrevDR = i
                    End If
                End If
                ' evaluate the distances and courses between waypoints - if they are flagged with use for eval indicator = Y
            ElseIf DataGridView1.Rows(i).Cells(LogTypeCell).Value = g_LogTypeWayPoint Then
                If PrevWPTFixExists = True Then
                    EvaluateDBPairs(i, PrevWPTFix, False)
                    DataGridView1.Rows(i).Cells(EvalCell).Value = "WPT from: " & DataGridView1.Rows(PrevWPTFix).Cells(DTCell).Value
                    If DataGridView1.Rows(i).Cells(UseForEvalCell).Value = "Y" Then
                        PrevWPTFix = i
                    End If

                Else
                    If DataGridView1.Rows(i).Cells(UseForEvalCell).Value = "Y" Then
                        PrevWPTFixExists = True
                        PrevWPTFix = i
                    End If

                End If
            End If

        Next
        Exit Sub
    End Sub
    Private Sub EvaluateDBPairs(ByVal CurrRec As Integer, ByVal PrevRec As Integer, ByVal GPSFixEntry As Boolean)
        ' evaluate Elapsed time from last entry
        Dim DT1 As DateTime = Convert.ToDateTime(DataGridView1.Rows(PrevRec).Cells(DTCell).Value)
        Dim DT2 As DateTime = Convert.ToDateTime(DataGridView1.Rows(CurrRec).Cells(DTCell).Value)

        Dim ZDLoc1 As Integer = Convert.ToInt32(DataGridView1.Rows(PrevRec).Cells(ZDCell).Value)
        Dim ZDLoc2 As Integer = Convert.ToInt32(DataGridView1.Rows(CurrRec).Cells(ZDCell).Value)

        Dim TS As TimeSpan = DT2 - DT1

        If ZDLoc1 <> ZDLoc2 Then
            Dim IncrHr As Integer = 0
            If Math.Sign(ZDLoc1) <> Math.Sign(ZDLoc2) Then ' we have crossed the IDL
                If ZDLoc1 < 0 And ZDLoc2 > 0 Then ' moving from West (ZD negative) to East (ZD positive)
                    IncrHr = ZDLoc1 - ZDLoc2
                End If
                If ZDLoc1 > 0 And ZDLoc2 < 0 Then ' moving from East (ZD positive) to West (ZD negative)
                    IncrHr = ZDLoc1 + ZDLoc2
                End If
            Else
                IncrHr = -1 * (ZDLoc2 - ZDLoc1)
            End If
            Dim TmpTS As TimeSpan = New TimeSpan(IncrHr, 0, 0)
            TS = TS.Add(TmpTS)
        End If

        If TS.Days = 0 Then
            DataGridView1.Rows(CurrRec).Cells(ElapsedCell).Value = TS.ToString("hh\:mm\:ss")
        Else
            DataGridView1.Rows(CurrRec).Cells(ElapsedCell).Value = TS.ToString("d\d\y\ hh\:mm\:ss")
        End If

        ' evaluate Calculate destination location - start with location of previous entry 
        Dim GeoLLo1 As Device.Location.GeoCoordinate = ParseLatLong(DataGridView1.Rows(PrevRec).Cells(DestLogTypeCell).Value)
        Dim TempcboL1 As String = g_LatN
        Dim TempL1 As Double = GeoLLo1.Latitude
        Dim TempL1Disp As Double = GeoLLo1.Latitude
        If GeoLLo1.Latitude <0 Then
            TempcboL1= g_LatS
            TempL1Disp= -1 * TempL1 ' A South latitude value is set to negative in the ParseLatLong routine
        Else
            TempcboL1 = g_LatN
            TempL1Disp = TempL1
        End If
        Dim TempcboLo1 As String = ""
        Dim TempLo1Disp As Double = GeoLLo1.Longitude
        Dim TempLo1 As Double = GeoLLo1.Longitude
        If GeoLLo1.Longitude <0 Then
            TempcboLo1= g_LongW
            TempLo1Disp= -1 * TempLo1 ' An West longitude value is set to negative in the ParseLatLong routine
        Else
            TempcboLo1 = g_LongE
            TempLo1Disp = TempLo1
        End If

        ' now calculate the location for the current entry
        Dim GeoLLo2 As Device.Location.GeoCoordinate = ParseLatLong(DataGridView1.Rows(CurrRec).Cells(DestLogTypeCell).Value)
        Dim TempcboL As String = g_LatN
        Dim TempL As Double = GeoLLo2.Latitude
        Dim TempLDisp As Double = GeoLLo2.Latitude
        If GeoLLo2.Latitude < 0 Then
            TempcboL = g_LatS
            TempLDisp = -1 * TempL ' A South latitude value is set to negative in the ParseLatLong routine
        Else
            TempcboL = g_LatN
            TempLDisp = TempL
        End If
        Dim TempcboLo As String = ""
        Dim TempLoDisp As Double = GeoLLo2.Longitude
        Dim TempLo As Double = GeoLLo2.Longitude
        If GeoLLo2.Longitude < 0 Then
            TempcboLo = g_LongW
            TempLoDisp = -1 * TempLo  ' An West longitude value is set to negative in the ParseLatLong routine
        Else
            TempcboLo = g_LongE
            TempLoDisp = TempLo
        End If

        Dim tlen As Integer = DataGridView1.Rows(PrevRec).Cells(TrueCell).Value.ToString.Length
        Dim TempTrue As Double = 0
        Dim TempSpeed As Double = 0
        ' get the distance from the previous location to the current entry location
        Dim Dist As Double = 0
        If DataGridView1.Rows(PrevRec).Cells(LogTypeCell).Value.ToString = g_LogTypeFix Or DataGridView1.Rows(PrevRec).Cells(LogTypeCell).Value.ToString = g_LogTypeWayPoint Then
            Dist = GetDistance(GeoLLo1.Latitude, GeoLLo1.Longitude, GeoLLo2.Latitude, GeoLLo2.Longitude)
        Else
            Dist = GetDistanceDG(PrevRec, CurrRec)
        End If
        If DataGridView1.Rows(CurrRec).Cells(LogTypeCell).Value = g_LogTypeFix Or DataGridView1.Rows(CurrRec).Cells(LogTypeCell).Value = g_LogTypeWayPoint Then
            TempTrue = GetHeading(GeoLLo1.Latitude, GeoLLo1.Longitude, GeoLLo2.Latitude, GeoLLo2.Longitude)
            'TempSpeed = Calc60DSTSpeed(DT1, DT2, Dist)
            TempSpeed = Calc60DSTSpeedTS(TS, Dist)
        Else
            TempTrue = Convert.ToDouble(DataGridView1.Rows(PrevRec).Cells(TrueCell).Value.ToString.Substring(0, tlen - 1))
            tlen = DataGridView1.Rows(PrevRec).Cells(DRSpeedCell).Value.ToString.Length
            TempSpeed = Convert.ToDouble(DataGridView1.Rows(PrevRec).Cells(DRSpeedCell).Value.ToString.Substring(0, tlen - 2))
        End If

        DataGridView1.Rows(CurrRec).Cells(DistCell).Value = Dist.ToString("#0.0") & " nm"

        ' now calculate the destination location using the previous loc, the distance using prev speed and elapsed time, and true course of prev entry
        Dim TempLoc As System.Device.Location.GeoCoordinate = SailingsFindDestLLo(TempL1, TempLo1, Dist, TempTrue)
        'Dim TempLoc As System.Device.Location.GeoCoordinate = C_FindDestLatLong(TempL1, TempLo1, Dist, TempTrue)
        Dim TempL3 As Double = TempLoc.Latitude
        Dim TempL3NS As String = TempcboL
        Dim TempL3Disp As Double = 0
        If TempL3 < 0 Then
            TempL3NS = g_LatS
            TempL3Disp = -1 * TempL3
        Else
            TempL3NS = g_LatN
            TempL3Disp = TempL3
        End If
        Dim TempL3Deg As Integer = Int(TempL3Disp)
        Dim TempL3Min As Double = (TempL3Disp - TempL3Deg) * 60

        Dim TempLo3 As Double = TempLoc.Longitude
        Dim TempLo3EW As String = TempcboLo
        Dim TempLo3Disp As Double = 0
        If TempLo3 < 0 Then
            TempLo3EW = g_LongW
            TempLo3Disp = -1 * TempLo3
        Else
            TempLo3EW = g_LongE
            TempLo3Disp = TempLo3
        End If
        Dim TempLo3Deg As Integer = Int(TempLo3Disp)
        Dim TempLo3Min As Double = (TempLo3Disp - TempLo3Deg) * 60

        DataGridView1.Rows(CurrRec).Cells(CalcDestLogTypeCell).Value = "L=" & TempL3Deg.ToString("##0") & Chr(176) & TempL3Min.ToString("#0.0") & "'" & TempL3NS & " " &
                                                    "Lo=" & TempLo3Deg.ToString("##0") & Chr(176) & TempLo3Min.ToString("#0.0") & "'" & TempLo3EW

        ' if the previous date/time is the same as the current record date/time then no true course or speed is available
        If TS.Days = 0 And TS.Hours = 0 And TS.Minutes = 0 And TS.Seconds = 0 Then
            DataGridView1.Rows(CurrRec).Cells(CalcDestTrueCell).Value = "0" & Chr(176)
            DataGridView1.Rows(CurrRec).Cells(CalcDestSpeedCell).Value = "0kn"
        Else
            ' Calculate the actual course between the previous loc and the current loc 
            Dim CMG As Double = GetHeading(TempL1, TempLo1, TempL3, TempLo3)
            DataGridView1.Rows(CurrRec).Cells(CalcDestTrueCell).Value = CMG.ToString("##0") & Chr(176)
            ' Calculate the actual speed using the calculate distance between previous loc and current loc and the elapsed time
            Dim SMG As Double = Calc60DSTSpeedTS(TS, Dist)
            DataGridView1.Rows(CurrRec).Cells(CalcDestSpeedCell).Value = SMG.ToString("##0.0") & "kn "
        End If
        If GPSFixEntry = True Then
            ' calculate the Direction of Set from current loc to actual computed loc 
            Dim SetCalc As Double = GetHeading(TempL, TempLo, TempL3, TempLo3)
            DataGridView1.Rows(CurrRec).Cells(CalcSetCell).Value = SetCalc.ToString("##0.0") & Chr(176)
            ' Calculate Drift distance and speed from current loc to actual computed loc
            Dim DistDrift As Double = GetDistance(TempL, TempLo, TempL3, TempLo3)
            Dim DriftSpeed As Double = Calc60DSTSpeedTS(TS, DistDrift)
            DataGridView1.Rows(CurrRec).Cells(CalcDriftCell).Value = DriftSpeed.ToString("##0.0") & "kn "
        End If

        Exit Sub
    End Sub
    Private Function GetDistanceDG(ByVal PrevRec As Integer, ByVal CurrRec As Integer) As Double
        Dim DT1 As DateTime = Convert.ToDateTime(DataGridView1.Rows(PrevRec).Cells(DTCell).Value)
        Dim DT2 As DateTime = Convert.ToDateTime(DataGridView1.Rows(CurrRec).Cells(DTCell).Value)

        Dim ZDLoc1 As Integer = Convert.ToInt32(DataGridView1.Rows(PrevRec).Cells(ZDCell).Value)
        Dim ZDLoc2 As Integer = Convert.ToInt32(DataGridView1.Rows(CurrRec).Cells(ZDCell).Value)

        Dim TS As TimeSpan = DT2 - DT1
        If ZDLoc1 <> ZDLoc2 Then
            Dim IncrHr As Integer = 0
            If Math.Sign(ZDLoc1) <> Math.Sign(ZDLoc2) Then ' we have crossed the IDL
                If ZDLoc1 < 0 And ZDLoc2 > 0 Then ' moving from West (ZD negative) to East (ZD positive)
                    IncrHr = ZDLoc1 - ZDLoc2
                End If
                If ZDLoc1 > 0 And ZDLoc2 < 0 Then ' moving from East (ZD positive) to West (ZD negative)
                    IncrHr = ZDLoc1 + ZDLoc2
                End If
            Else
                IncrHr = -1 * (ZDLoc2 - ZDLoc1)
            End If
            Dim TmpTS As TimeSpan = New TimeSpan(IncrHr, 0, 0)
            TS = TS.Add(TmpTS)
        End If

        Dim tlen As Integer = DataGridView1.Rows(PrevRec).Cells(TrueCell).Value.ToString.Length
        Dim TempTrue As Double = Convert.ToDouble(DataGridView1.Rows(PrevRec).Cells(TrueCell).Value.ToString.Substring(0, tlen - 1))
        tlen = DataGridView1.Rows(PrevRec).Cells(DRSpeedCell).Value.ToString.Length
        Dim TempSpeed As Double = Convert.ToDouble(DataGridView1.Rows(PrevRec).Cells(DRSpeedCell).Value.ToString.Substring(0, tlen - 2))
        ' get the distance from the previous location to the current entry location
        Dim Dist As Double = TempSpeed * (TS.TotalMinutes / 60)
        Return Dist
    End Function
    Private Shared Function GetDistance(ByVal Lat1In As Double, ByVal Long1In As Double, ByVal Lat2In As Double, ByVal Long2In As Double) As Double
        Dim Coord1 As System.Device.Location.GeoCoordinate = New System.Device.Location.GeoCoordinate(Lat1In, Long1In)
        Dim Coord2 As System.Device.Location.GeoCoordinate = New System.Device.Location.GeoCoordinate(Lat2In, Long2In)
        Return (Coord1.GetDistanceTo(Coord2)) / 1852.0  ' GetDistanceTo returns distance between geo coords in meters - there are 1852 meters in a nautical mile
    End Function
    Private Shared Function GetHeading(ByVal lat1 As Double, ByVal long1 As Double, ByVal lat2 As Double, ByVal long2 As Double) As Double

        Dim x As Double = Math.Cos(DegreesToRadians(lat1)) * Math.Sin(DegreesToRadians(lat2)) - Math.Sin(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) * Math.Cos(DegreesToRadians(long2) - DegreesToRadians(long1))
        Dim y As Double = Math.Sin(DegreesToRadians(long2) - DegreesToRadians(long1)) * Math.Cos(DegreesToRadians(lat2))
        'Dim DegX As Double = RadiansToDegrees(x)
        'Dim DegY As Double = RadiansToDegrees(y)
        Dim Angle As Double = RadiansToDegrees(Math.Atan2(y, x))
        Return (Angle + 360) Mod 360
    End Function
    Private Shared Function DegreesToRadians(ByVal angle As Double) As Double
        Return angle * Math.PI / 180
    End Function
    Private Shared Function RadiansToDegrees(ByVal angle As Double) As Double
        Return angle * 180 / Math.PI
    End Function

    Private Shared Function Calc60DSTDistance(ByVal DT1 As DateTime, ByVal DT2 As DateTime, ByVal Speed As Double) As Double
        Dim TS As TimeSpan = DT2 - DT1
        Return (Speed * TS.TotalHours)
    End Function
    Private Shared Function Calc60DSTSpeed(ByVal DT1 As DateTime, ByVal DT2 As DateTime, ByVal Dist As Double) As Double
        Dim TS As TimeSpan = DT2 - DT1
        Return (60 * Dist / TS.TotalMinutes)
    End Function
    Private Shared Function Calc60DSTSpeedTS(ByVal TSIn As TimeSpan, ByVal Dist As Double) As Double
        Return (60 * Dist / TSIn.TotalMinutes)
    End Function
    Private Shared Function Calc60DSTElapsed(ByVal DT1 As DateTime, ByVal Speed As Double, ByVal Distance As Double) As TimeSpan
        Dim ElapsedMin As Double = (60 * Distance) / Speed
        Dim newDT As DateTime = DT1
        newDT = newDT.AddMinutes(ElapsedMin)
        Dim TS As TimeSpan = newDT - DT1
        Return TS
    End Function

    Private Shared Function ParseLatLong(ByVal StrIn As String) As System.Device.Location.GeoCoordinate
        ' evaluate Calculate destination location - start with location of previous entry 
        Dim LLo1 As String = StrIn  'DataGridView1.Rows(i - 1).Cells(DestLogTypeCell).Value
        Dim LPos1 As Integer = LLo1.IndexOf("=", StringComparison.CurrentCultureIgnoreCase)
        Dim LDegPos1 As Integer = LLo1.IndexOf(Chr(176))
        Dim LMinPos1 As Integer = LLo1.IndexOf("'", StringComparison.CurrentCultureIgnoreCase)
        Dim LoPos1 As Integer = LLo1.IndexOf("=", LPos1 + 1, StringComparison.CurrentCultureIgnoreCase)
        Dim LoDegPos1 As Integer = LLo1.IndexOf(Chr(176), LDegPos1 + 1)
        Dim LoMinPos1 As Integer = LLo1.IndexOf("'", LMinPos1 + 1, StringComparison.CurrentCultureIgnoreCase)
        Dim TempL1 As Double = Convert.ToDouble(LLo1.Substring(LPos1 + 1, (LDegPos1 - 1) - (LPos1 + 1) + 1)) +
            Convert.ToDouble(LLo1.Substring(LDegPos1 + 1, (LMinPos1 - 1) - (LDegPos1 + 1) + 1) / 60)
        Dim TempcboL1 As String = LLo1.Substring(LMinPos1 + 1, 1)
        Dim TempL1Disp As Double = 0
        If TempcboL1 = g_LatS Then
            TempL1Disp = -1 * TempL1
        Else
            TempL1Disp = TempL1
        End If
        Dim TempLo1 As Double = Convert.ToDouble(LLo1.Substring(LoPos1 + 1, (LoDegPos1 - 1) - (LoPos1 + 1) + 1)) +
            Convert.ToDouble(LLo1.Substring(LoDegPos1 + 1, (LoMinPos1 - 1) - (LoDegPos1 + 1) + 1) / 60)
        Dim TempcboLo1 As String = LLo1.Substring(LoMinPos1 + 1, 1)
        Dim TempLo1Disp As Double = 0
        If TempcboLo1 = g_LongW Then
            TempLo1Disp = -1 * TempLo1
        Else
            TempLo1Disp = TempLo1
        End If

        Dim RtnLLo As Device.Location.GeoCoordinate = New Device.Location.GeoCoordinate(TempL1Disp, TempLo1Disp)
        Return RtnLLo
    End Function

    Private Sub cboLocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocType.SelectedIndexChanged
        If InitialLoad = True Then Exit Sub
        If FileLoading = True Then Exit Sub
        If DRAdvanceMode = True Then Exit Sub

        CompassInput = False
        TrueInput = False

        cboAdvHrs.Value = 0
        cboAdvMin.Value = 0
        cboAdvNm.Value = 0.0
        cboAdvType.Visible = False
        lblAdvNm.Visible = False
        cboAdvNm.Visible = False
        lblAdvHrMin.Visible = False
        cboAdvHrs.Visible = False
        cboAdvMin.Visible = False
        'DRAdvanceDGSave = 0
        DRAdvanceMode = False
        ' set default colors - input fields are encoded yellow while those protected from input are encoded in aqua

        txtLDeg.BackColor = Color.Yellow
        txtLMin.BackColor = Color.Yellow
        txtLoDeg.BackColor = Color.Yellow
        txtLoMin.BackColor = Color.Yellow
        txtSpeed.BackColor = Color.Yellow
        txtDestLDeg.BackColor = Color.Yellow
        txtDestLMin.BackColor = Color.Yellow
        txtDestLoDeg.BackColor = Color.Yellow
        txtDestLoMin.BackColor = Color.Yellow

        txtCompass.BackColor = Color.Aqua
        txtDev.BackColor = Color.Aqua
        txtVar.BackColor = Color.Aqua
        txtCTrue.BackColor = Color.Aqua
        txtKnotLog.BackColor = Color.Aqua
        ' now set fields access and color according to Entry type
        ' no matter what type of entry is selected, the deviation field must be set according to whether the use Devform check box is checked
        If chkDev.Checked = True Then
            txtDev.Enabled = False
            cboDev.Enabled = False
            txtDev.BackColor = Color.Aqua
        Else
            txtDev.Enabled = True
            cboDev.Enabled = True
            txtDev.BackColor = Color.Yellow
        End If


        txtSpeed.Visible = True
        txtDev.Visible = True
        cboDev.Visible = True
        chkDev.Visible = True
        txtCompass.Visible = True
        txtVar.Visible = True
        cboVar.Visible = True
        txtCTrue.Visible = True

        grpLogNotes.Visible = True
        grpWeather.Visible = False

        If cboLocType.Text = g_LogTypePlan Then
            ResetScreenFieldsforPlan()

        ElseIf cboLocType.Text = g_LogTypeGPS Then
            ResetScreenFieldsforGPS()

        ElseIf cboLocType.Text = g_LogTypeDRAdv Then
            If IsNothing(UpdtRow) Or DataGridView1.Rows(UpdtRow).Cells(LogTypeCell).Value.ToString <> g_LogTypeDR Then
                ErrorMsgBox("You can only Advance a DR Entry - This Entry Type Selection is Invalid - Selection is reset to DR")
                cboLocType.SelectedIndex = 0
                DRAdvanceMode = False
                Me.Refresh()
                Exit Sub
            Else
                ResetScreenFieldsforDRAdvance()
                cboAdvType_SelectedIndexChanged(sender, e)
            End If
        ElseIf cboLocType.Text = g_LogTypeDR Then
            ResetScreenFieldsforDR()
        ElseIf cboLocType.Text = g_LogTypeFix Or cboLocType.Text = g_LogTypeWayPoint Then
            ResetScreenFieldsForWPFix()
            DRAdvanceMode = False
        End If
        ' you can only update the currently selected row with the same log type - if it is changed then you must add or delete not change to a new type
        If UpdtRow <> Nothing And DataGridView1.Rows.Count <> 0 And cboLocType.Text.ToString = DataGridView1.Rows(UpdtRow).Cells(LogTypeCell).Value.ToString Then
            btnUpdateExisting.Visible = True
        Else
            btnUpdateExisting.Visible = False
        End If
        ' now set color coding of grpLogEntryInfo box to match the color coding for entries in the datagridview
        Select Case cboLocType.Text.ToString
            Case g_LogTypeGPS, g_LogTypeOldGPS
                grpLogEntryInfo.BackColor = GPSBackColor
                grpLogEntryInfo.ForeColor = GPSForeColor
            Case g_LogTypeDR, g_LogTypeOldDR
                grpLogEntryInfo.BackColor = DRBackColor
                grpLogEntryInfo.ForeColor = DRForeColor
            Case g_LogTypeDRAdv
                grpLogEntryInfo.BackColor = DRBackColor
                grpLogEntryInfo.ForeColor = DRForeColor
                grpAdvInfo.BackColor = DRBackColor
                grpAdvInfo.ForeColor = DRForeColor
            Case g_LogTypePlan, g_LogTypeOldPlan
                grpLogEntryInfo.BackColor = PlanBackColor
                grpLogEntryInfo.ForeColor = PlanForeColor
            Case g_LogTypeFix
                grpLogEntryInfo.BackColor = FixBackColor
                grpLogEntryInfo.ForeColor = FixForeColor
            Case g_LogTypeWayPoint
                grpLogEntryInfo.BackColor = WPTBackColor
                grpLogEntryInfo.ForeColor = WPTForeColor
            Case Else
                grpLogEntryInfo.BackColor = DefBackColor
                grpLogEntryInfo.ForeColor = DefForeColor
        End Select
        ClearPlanFields()
        Me.Refresh()
        Exit Sub
    End Sub
    Private Sub ClearPlanFields()
        txtDestLDeg.Clear()
        txtDestLMin.Clear()
        txtDestLoDeg.Clear()
        txtDestLoMin.Clear()
        cboDestL.SelectedIndex = 0
        cboDestLo.SelectedIndex = 0
        txtDestTrue.Clear()
        txtDestDist.Clear()
        txtDestElapsed.Clear()
        txtEstArrival.Clear()
        'txtWeather.Clear()
        'txtRemarks.Clear()
        Exit Sub
    End Sub

    Private Sub chkHideFirst4Col_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideFirst4Col.CheckedChanged
        DisplayHideFirst4Col()
        SortDataGridonDate()
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = Nothing
        DataGridView1.Refresh()
        Me.Refresh()
        Exit Sub
    End Sub
    Private Sub DisplayHideFirst4Col()
        If chkHideFirst4Col.Checked = True Then
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(12).Visible = False
        Else
            DataGridView1.Columns(0).Visible = True
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True
            DataGridView1.Columns(12).Visible = True
        End If
    End Sub

    Private Sub btnStartFresh_Click(sender As Object, e As EventArgs) Handles btnStartFresh.Click
        If IsUpdated = True Then
            Dim MsgBack As MsgBoxResult = MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
            If MsgBack = MsgBoxResult.Yes Then
                SaveDataGrid()
            End If
            IsUpdated = False
        End If
        FormDeckLogUpdate_Load(sender, e)
        'FileLoading = True
        'DataSet1.Tables(tablename).Clear()
        'ClearPlanFields()
        'ResetAllScreenFields()
        'Me.Refresh()
        'FileLoading = False
        Exit Sub
    End Sub
    Private ReadOnly BadLLoStr As String = "L=°'N Lo=°'W"
    Private Sub btnExportGPX_Click(sender As Object, e As EventArgs) Handles btnExportGPX.Click
        'Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
        Dim saveFileDialog1 As New SaveFileDialog With {
            .InitialDirectory = "./DeckLog/",
            .Filter = "gpx files (*.gpx)|*.gpx",
            .Title = "Export Deck Log Plan Entries to GPX",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFileDialog1.FileName = vbNullString Then
                saveFileDialog1.Dispose()
                Exit Sub
            End If
            FName = saveFileDialog1.FileName
        End If

        Dim textstr As New System.Text.StringBuilder()
        textstr.AppendLine(GetGPXHdr)
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNothing(DataGridView1.Rows(x).Cells(VesselCell).Value) = False And DataGridView1.Rows(x).Cells(DestLogTypeCell).Value.ToString <> "" And
                DataGridView1.Rows(x).Cells(DestLogTypeCell).Value.ToString <> BadLLoStr Then
                'If DataGridView1.Rows(x).Cells(LogTypeCell).Value <> g_LogTypePlan Then ' if this is NOT a Plan type log entry then it is GPS or Fix or a WPT as a WayPoint type
                If DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeGPS Or DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeOldGPS Or
                       DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeWayPoint Or DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeFix Then
                    Dim TmpGeo As System.Device.Location.GeoCoordinate = ParseLatLong(DataGridView1.Rows(x).Cells(DestLogTypeCell).Value)
                    Dim TmpLat As String = TmpGeo.Latitude.ToString("00.00000")
                    Dim TmpLong As Double = TmpGeo.Longitude.ToString("000.00000")
                    Dim TimeZone As Integer = Math.Round(TmpLong / 15, 0, MidpointRounding.AwayFromZero)
                    Dim displayName As String = "Custom TZ "
                    Dim standardName As String = "Custom TZ"
                    Dim offset As TimeSpan = New TimeSpan(TimeZone, 0, 0)
                    Dim customtz As TimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName)
                    Dim ZT As DateTime = Convert.ToDateTime(DataGridView1.Rows(x).Cells(DTCell).Value)
                    Dim UT As DateTime = TimeZoneInfo.ConvertTimeToUtc(ZT, customtz)
                    Dim UTStr As String = UT.ToString("yyyy-MM-ddTHH:mm:ssZ")
                    Dim LocalNm As String = DataGridView1.Rows(x).Cells(FromCell).Value.ToString & "/" & DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString & " WayPt"
                    Dim GPSFixType As String = "<fix>" & "dgps" & "</fix>"
                    Dim FixFixType As String = "<fix>" & "2d" & "</fix>"

                    Dim WptStr1 As String = ""
                    If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeGPS Or DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldGPS Then
                        WptStr1 = "<wpt lat=""" & TmpLat & """ lon=""" & TmpLong & """>" & "<time>" & UTStr & "</time><name>" & LocalNm & "</name>" & GPSFixType & vbNewLine & "</wpt>"
                    ElseIf DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeFix Then
                        WptStr1 = "<wpt lat=""" & TmpLat & """ lon=""" & TmpLong & """>" & "<time>" & UTStr & "</time><name>" & LocalNm & "</name>" & FixFixType & vbNewLine & "</wpt>"
                    ElseIf DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeWayPoint Then
                        WptStr1 = "<wpt lat=""" & TmpLat & """ lon=""" & TmpLong & """>" & "<time>" & UTStr & "</time><name>" & LocalNm & "</name>" & GPSFixType & vbNewLine & "</wpt>"
                    Else
                        WptStr1 = "<wpt lat=""" & TmpLat & """ lon=""" & TmpLong & """>" & "<time>" & UTStr & "</time><name>" & LocalNm & "</name>" & "</wpt>"
                    End If

                    textstr.AppendLine(WptStr1)
                End If

            End If
        Next
        textstr.Append(vbNewLine & "<rte>")
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNothing(DataGridView1.Rows(x).Cells(VesselCell).Value) = False And DataGridView1.Rows(x).Cells(DestLogTypeCell).Value.ToString <> "" And
                DataGridView1.Rows(x).Cells(DestLogTypeCell).Value.ToString <> BadLLoStr Then
                ' If this entry type is a Plan Entry or Waypoint Entry then it is a RTE candidate
                If DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypePlan Or DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeOldPlan Then
                    'DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeWayPoint Then
                    If x = 0 Then
                        textstr.Append("<name>" & DataGridView1.Rows(x).Cells(FromCell).Value.ToString &
                                "/" & DataGridView1.Rows(x).Cells(ToCell).Value.ToString & "/" & "Planned Route" & "</name>")
                    End If
                    Dim TmpGeo As System.Device.Location.GeoCoordinate = ParseLatLong(DataGridView1.Rows(x).Cells(DestLogTypeCell).Value)
                    Dim TmpLat As String = TmpGeo.Latitude.ToString("00.00000")
                    Dim TmpLong As Double = TmpGeo.Longitude.ToString("000.00000")
                    Dim TimeZone As Integer = Math.Round(TmpLong / 15, 0, MidpointRounding.AwayFromZero)
                    Dim displayName As String = "Custom TZ "
                    Dim standardName As String = "Custom TZ"
                    Dim offset As TimeSpan = New TimeSpan(TimeZone, 0, 0)
                    Dim customtz As TimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName)
                    Dim ZT As DateTime = Convert.ToDateTime(DataGridView1.Rows(x).Cells(DTCell).Value)
                    Dim UT As DateTime = TimeZoneInfo.ConvertTimeToUtc(ZT, customtz)
                    Dim UTStr As String = UT.ToString("yyyy-MM-ddTHH:mm:ssZ")
                    Dim LocalNm As String = DataGridView1.Rows(x).Cells(FromCell).Value.ToString & "/" & DataGridView1.Rows(x).Cells(ToCell).Value.ToString & "/" & DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString & " RoutePt"
                    Dim RteStr As String = "<rtept lat=""" & TmpLat & """ lon=""" & TmpLong & """>" & "<time>" & UTStr & "</time><name>" & LocalNm & "</name>" & vbNewLine & "</rtept>"
                    textstr.AppendLine(RteStr)
                End If
            End If
        Next
        textstr.Append(vbNewLine & "</rte>")

        textstr.Append(vbNewLine & "<trk>")
        textstr.Append(vbNewLine & "<trkseg>")
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNothing(DataGridView1.Rows(x).Cells(VesselCell).Value) = False And DataGridView1.Rows(x).Cells(DestLogTypeCell).Value.ToString <> "" And
                DataGridView1.Rows(x).Cells(DestLogTypeCell).Value.ToString <> BadLLoStr Then
                ' if this is a  DR Track or GPS Track or Fix type it is a TRK candidate (exclude Plan and WPT entries)
                If DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeGPS Or DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeOldGPS Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeDR Or DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeOldDR Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeFix Then
                    Dim TmpGeo As System.Device.Location.GeoCoordinate = ParseLatLong(DataGridView1.Rows(x).Cells(DestLogTypeCell).Value)
                    Dim TmpLat As String = TmpGeo.Latitude.ToString("00.00000")
                    Dim TmpLong As Double = TmpGeo.Longitude.ToString("000.00000")
                    Dim TimeZone As Integer = Math.Round(TmpLong / 15, 0, MidpointRounding.AwayFromZero)
                    Dim displayName As String = "Custom TZ "
                    Dim standardName As String = "Custom TZ"
                    Dim offset As TimeSpan = New TimeSpan(TimeZone, 0, 0)
                    Dim customtz As TimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName)
                    Dim ZT As DateTime = Convert.ToDateTime(DataGridView1.Rows(x).Cells(DTCell).Value)
                    Dim UT As DateTime = TimeZoneInfo.ConvertTimeToUtc(ZT, customtz)
                    Dim UTStr As String = UT.ToString("yyyy-MM-ddTHH:mm:ssZ")
                    Dim LocalNm As String = DataGridView1.Rows(x).Cells(FromCell).Value.ToString & "/" & DataGridView1.Rows(x).Cells(ToCell).Value.ToString & " TrackPt"
                    Dim TrkStr As String = "<trkpt lat=""" & TmpLat & """ lon=""" & TmpLong & """>" & "<time>" & UTStr & "</time><name>" & LocalNm & "</name>" & vbNewLine & "</trkpt>"
                    textstr.AppendLine(TrkStr)
                End If
            End If
        Next
        textstr.Append(vbNewLine & "</trkseg>")
        textstr.Append(vbNewLine & "</trk>")

        textstr.Append(vbNewLine & "</gpx>")
        IO.File.WriteAllText(FName, textstr.ToString(), System.Text.Encoding.Default)
        saveFileDialog1.Dispose()
        Exit Sub
    End Sub
    Private Function GetGPXHdr() As String
        Dim tmpstr As String = "<gpx xmlns="" http://www.topografix.com/GPX/1/1"" " & vbNewLine &
                                   "xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance"" " & vbNewLine &
                                   "xsi:schemaLocation=""http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd""" & vbNewLine &
                                   "version=""1.1""" & vbNewLine &
                                   "creator=""" & DataGridView1.Rows(0).Cells(VesselCell).Value & " " & DataGridView1.Rows(0).Cells(FromCell).Value & "Plan Entries" & """>" & vbNewLine
        Return (tmpstr)
    End Function

    Private Sub DTDateZoneTime_ValueChanged(sender As Object, e As EventArgs) Handles DTDateZoneTime.ValueChanged
        'If DRAdvanceMode = True Then
        '    If AdvMin = 0 Then
        '        Dim TS As TimeSpan = DTDateZoneTime.Value - DTAdvDTSave
        '        AdvMin = Convert.ToInt32(TS.TotalMinutes)
        '    End If
        '    FindInstallAdvancedDR()
        '    'DTChanged = False
        '    DRAdvanceMode = False
        '    DRAdvanceDGSave = 0
        'End If
        'Me.Refresh()
        Exit Sub
    End Sub
    Private Sub FindInstallAdvancedDR()
        If DRAdvanceMode = True Then

            Dim TmpTrue As Double = Convert.ToDouble(txtCTrue.Text)
            Dim TempSpeed As Double = Convert.ToDouble(txtSpeed.Text.ToString)

            If cboAdvType.SelectedIndex = 1 Then
                AdvNm = Convert.ToDouble(cboAdvNm.Value)
                AdvMin = (60 * AdvNm) / TempSpeed
                Dim tmpHrMinD As Double = AdvMin / 60
                If Int(tmpHrMinD) > cboAdvHrs.Maximum Then
                    cboAdvHrs.Maximum = tmpHrMinD + 24
                End If
                cboAdvHrs.Value = Int(tmpHrMinD)
                cboAdvMin.Value = (tmpHrMinD - Int(tmpHrMinD)) * 60
            ElseIf cboAdvType.SelectedIndex = 0 Then
                AdvMin = ((Convert.ToInt32(cboAdvHrs.Value.ToString)) * 60) + Convert.ToInt32(cboAdvMin.Value.ToString)
                AdvNm = (TempSpeed * AdvMin) / 60
                If AdvNm > cboAdvNm.Maximum Then
                    cboAdvNm.Maximum = AdvNm + 1
                End If
                cboAdvNm.Value = AdvNm
            Else
                AdvMin = 0
                AdvNm = 0
                cboAdvHrs.Value = 0
                cboAdvMin.Value = 0
                cboAdvNm.Value = 0
                MessageBox.Show("Invalid AdvType selected index - Advancing DR edits stopped")
                Exit Sub
            End If

            DTAdvDTSave = DTDateZoneTime.Value
            DTAdvDTSave = DTAdvDTSave.AddHours(cboAdvHrs.Value)
            DTAdvDTSave = DTAdvDTSave.AddMinutes(cboAdvMin.Value)
            DTDateZoneTime.Value = DTAdvDTSave
            'DTDateZoneTime.Value = DTDateZoneTime.Value.AddMinutes(AdvMin)

            Dim TempLLo As String = "L=" & txtLDeg.Text.ToString & Chr(176) & txtLMin.Text.ToString & "'" & cboL.Text.ToString &
            " Lo=" & txtLoDeg.Text.ToString & Chr(176) & txtLoMin.Text.ToString & "'" & cboLo.Text.ToString
            Dim TempLoc As System.Device.Location.GeoCoordinate = ParseLatLong(TempLLo)
            'Dim TempDist As Double = TempSpeed * (AdvMin / 60)
            Dim TempLoc1 As System.Device.Location.GeoCoordinate = SailingsFindDestLLo(TempLoc.Latitude, TempLoc.Longitude, AdvNm, TmpTrue)
            Dim TmpLoc1Lat As Double = TempLoc1.Latitude
            If TempLoc1.Latitude < 0 Then ' if temploc1.latitude is negative it is South latitude
                cboL.SelectedIndex = 1
                TmpLoc1Lat = -1 * TempLoc1.Latitude
            Else
                cboL.SelectedIndex = 0
                TmpLoc1Lat = TempLoc1.Latitude
            End If
            txtLDeg.Text = Int(TmpLoc1Lat).ToString("#0")
            txtLMin.Text = ((TmpLoc1Lat - Int(TmpLoc1Lat)) * 60).ToString("00.0")

            Dim TmpLoc1Long As Double = TempLoc1.Longitude
            If TempLoc1.Longitude < 0 Then ' if temploc1.longitude is negative, it is West longitude
                cboLo.SelectedIndex = 0
                TmpLoc1Long = -1 * TempLoc1.Longitude
            Else
                cboLo.SelectedIndex = 1
                TmpLoc1Long = TempLoc1.Longitude
            End If
            txtLoDeg.Text = Int(TmpLoc1Long).ToString("##0")
            txtLoMin.Text = ((TmpLoc1Long - Int(TmpLoc1Long)) * 60).ToString("00.0")
            cboLocType.SelectedIndex = 0 ' set log entry type to DR Track (index = 0)
            Dim TmpZD As Integer = Math.Round(TempLoc.Longitude / 15, 0)
            Dim TmpZD1 As Integer = Math.Round(TempLoc1.Longitude / 15, 0)
            If TmpZD <> TmpZD1 Then
                'ProcessAddNew()
                DTDateZoneTime.Value = ReturnDestinationZoneTime(TmpZD, TmpZD1, 0, DTDateZoneTime.Value)
                If txtRemarks.Text <> "" Then
                    txtRemarks.AppendText(vbNewLine)
                End If
                txtRemarks.AppendText("DR Advance moved L/Lo from ZD " & TmpZD.ToString("#0") & " To ZD " & TmpZD1.ToString("#0"))
            End If
            ProcessAddNew()
        End If
        ' now process adding this new DR entry

        Exit Sub
    End Sub
    Private Sub FindInstallAdvancedPlan()

        Dim TmpTrue As Double = Convert.ToDouble(txtCTrue.Text.ToString)
        Dim TempSpeed As Double = Convert.ToDouble(txtSpeed.Text.ToString)

        If cboAdvType.SelectedIndex = 1 Then
            AdvNm = Convert.ToDouble(cboAdvNm.Value)
            AdvMin = (60 * AdvNm) / TempSpeed
            Dim tmpHrMinD As Double = AdvMin / 60
            cboAdvHrs.Value = Int(tmpHrMinD)
            cboAdvMin.Value = (tmpHrMinD - Int(tmpHrMinD)) * 60
        ElseIf cboAdvType.SelectedIndex = 0 Then
            AdvMin = ((Convert.ToInt32(cboAdvHrs.Value.ToString)) * 60) + Convert.ToInt32(cboAdvMin.Value.ToString)
            AdvNm = (TempSpeed * AdvMin) / 60
            cboAdvNm.Value = AdvNm
        Else
            'AdvMin = 0
            'AdvNm = 0
            'cboAdvHrs.Value = 0
            'cboAdvMin.Value = 0
            'cboAdvNm.Value = 0
            MessageBox.Show("Invalid AdvType selected index - Advancing DR edits stopped")
            Exit Sub
        End If

        Dim TempLLo As String = "L=" & txtLDeg.Text.ToString & Chr(176) & txtLMin.Text.ToString & "'" & cboL.Text.ToString &
           " Lo=" & txtLoDeg.Text.ToString & Chr(176) & txtLoMin.Text.ToString & "'" & cboLo.Text.ToString
        Dim TempLoc As System.Device.Location.GeoCoordinate = ParseLatLong(TempLLo)
        Dim TempDist As Double = AdvNm  'TempSpeed * (AdvMin / 60)
        Dim TempLoc1 As System.Device.Location.GeoCoordinate = C_FindDestLatLong(TempLoc.Latitude, TempLoc.Longitude, TempDist, TmpTrue)
        Dim TmpLoc1Lat As Double = TempLoc1.Latitude
        If TempLoc1.Latitude < 0 Then
            cboDestL.SelectedIndex = 1
            TmpLoc1Lat = -1 * TempLoc1.Latitude
        Else
            cboDestL.SelectedIndex = 0
            TmpLoc1Lat = TempLoc1.Latitude
        End If
        txtDestLDeg.Text = Int(TmpLoc1Lat).ToString("#0")
        txtDestLMin.Text = ((TmpLoc1Lat - Int(TmpLoc1Lat)) * 60).ToString("00.0")

        Dim TmpLoc1Long As Double = TempLoc1.Longitude
        If TempLoc1.Longitude < 0 Then
            cboDestLo.SelectedIndex = 0
            TmpLoc1Long = -1 * TempLoc1.Longitude
        Else
            cboDestLo.SelectedIndex = 1
            TmpLoc1Long = TempLoc1.Longitude
        End If
        txtDestLoDeg.Text = Int(TmpLoc1Long).ToString("##0")
        txtDestLoMin.Text = ((TmpLoc1Long - Int(TmpLoc1Long)) * 60).ToString("00.0")

        Exit Sub
    End Sub

    Private Sub linkLblNOAAVar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLblNOAAVar.LinkClicked
        Dim URLNOAAMagVar As String = "https://www.ngdc.noaa.gov/geomag/calculators/magcalc.shtml"
        System.Diagnostics.Process.Start(URLNOAAMagVar)
    End Sub

    Private Sub btnCreateReportFile_Click(sender As Object, e As EventArgs)
        'Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
        Dim saveFileDialog1 As New SaveFileDialog With {
            .InitialDirectory = "./DeckLog/",
            .Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
            .Title = "Save Deck Log File",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFileDialog1.FileName = vbNullString Then
                saveFileDialog1.Dispose()
                Exit Sub
            End If
            FName = saveFileDialog1.FileName
        End If

        Dim textstr As New System.Text.StringBuilder()
        Dim FileHdrStr As String = vbNullString
        For i As Integer = 0 To UBound(HdrStr)
            If i > 0 Then
                textstr.Append("," & vbTab)
            End If
            textstr.Append(HdrStr(i))
        Next
        textstr.AppendLine()
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNothing(DataGridView1.Rows(x).Cells(VesselCell).Value) = False Then
                For v As Integer = 0 To DataGridView1.Columns.Count - 1
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then
                        textstr.Append("," & vbTab)
                    End If
                    Dim tempstr As String = DataGridView1.Rows(x).Cells(v).Value.ToString()
                    tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
                    textstr.Append(tempstr)
                Next
            End If
            'adding new line to text
            textstr.AppendLine()
        Next
        IO.File.WriteAllText(FName, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"))
        saveFileDialog1.Dispose()
        Exit Sub
    End Sub

    Private Sub btnUseTVMDC_Click(sender As Object, e As EventArgs) Handles btnUseTVMDC.Click
        FormTVMDC.Show()
        Exit Sub
    End Sub
    Private ReadOnly g_ZeroStr As String = "0"
    Private Sub btnUseZTInfoForm_Click(sender As Object, e As EventArgs) Handles btnUseZTInfoForm.Click
        ZTInfo.InvokedbyDeckLog = True
        DestDTUpdatedbyZTInfo = False
        ZTInfo.txtLoDegA.Text = txtLoDeg.Text
        ZTInfo.txtLoMinA.Text = txtLoMin.Text
        ZTInfo.cboLoA.Text = cboLo.Text
        ZTInfo.DTLocA.Value = DTDateZoneTime.Value

        If cboAdvHrs.Value <> 0 Or cboAdvMin.Value <> 0 Then
            ZTInfo.DT1Days.Value = 0
            ZTInfo.DT1Hours.Value = Convert.ToInt32(cboAdvHrs.Value.ToString, CultureInfo.CurrentCulture)
            ZTInfo.DT1Minutes.Value = Convert.ToInt32(cboAdvMin.Value.ToString, CultureInfo.CurrentCulture)
        Else
            ZTInfo.DT1Days.Value = 0
            ZTInfo.DT1Hours.Value = 0
            ZTInfo.DT1Minutes.Value = 0
        End If

        If cboLocType.Text = g_LogTypePlan Or DRAdvanceMode = True Then
            ZTInfo.txtLoDegB.Text = txtDestLoDeg.Text
            ZTInfo.txtLoMinB.Text = txtDestLoMin.Text
            ZTInfo.cboLoB.Text = cboDestLo.Text
        Else
            ZTInfo.txtLoDegB.Text = g_ZeroStr
            ZTInfo.txtLoMinB.Text = g_ZeroStr
            ZTInfo.cboLoB.Text = g_LongW
        End If
        ZTInfo.Show()
        ZTInfo.InvokedbyDeckLog = False
        Exit Sub
    End Sub
    Private Sub CleanUp()
        If System.Windows.Forms.Application.OpenForms().OfType(Of FormTVMDC).Any Then
            FormTVMDC.Close()
        End If
        If System.Windows.Forms.Application.OpenForms().OfType(Of ZTInfo).Any Then
            ZTInfo.Close()
        End If
        If System.Windows.Forms.Application.OpenForms().OfType(Of DevForm).Any Then
            DevForm.SaveDevDataGrid()
            DevForm.Close()
        End If
        DataSet1.Dispose()
        Exit Sub
    End Sub

    Private Sub cboDisplayRows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDisplayRows.SelectedIndexChanged
        If InitialLoad = True Then Exit Sub
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = Nothing
        DisplayDGRows()
        ResetAllScreenFields()
        DisplayCommonButtons()
        DataGridView1.Refresh()
        Me.Refresh()
        SortingDG = False
        Exit Sub
    End Sub

    Private Sub DisplayDGRows()
        Dim currencyManager1 As CurrencyManager
        currencyManager1 = CType(Me.BindingContext(DataSet1), CurrencyManager)
        SortingDG = True

        'DataGridView1.ClearSelection()
        'DataGridView1.CurrentCell = Nothing
        currencyManager1.SuspendBinding()

        'All
        'Plan/Route
        'DR/GPS Track
        'Fix/WPT
        'DR/GPS/Fix/WPT

        Select Case cboDisplayRows.Text
            Case "All"
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    'If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeGPS Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldGPS Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeDR Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldDR Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeFix Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeWayPoint Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypePlan Or
                    '    DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldPlan Then
                    DataGridView1.Rows(x).Visible = True
                    ColorDisplayRow(x)
                    'Else
                    '    DataGridView1.Rows(x).Visible = False
                    'End If
                Next
            Case "Fix/WPT"
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeFix Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeWayPoint Then
                        DataGridView1.Rows(x).Visible = True
                        ColorDisplayRow(x)
                    Else
                        DataGridView1.Rows(x).Visible = False
                    End If
                Next
            Case "Plan/Route"
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypePlan Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldPlan Then
                        DataGridView1.Rows(x).Visible = True
                        ColorDisplayRow(x)
                    Else
                        DataGridView1.Rows(x).Visible = False
                    End If
                Next
            Case "DR/GPS Track"
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeDR Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldDR Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeGPS Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldGPS Then
                        DataGridView1.Rows(x).Visible = True
                        ColorDisplayRow(x)
                    Else
                        DataGridView1.Rows(x).Visible = False
                    End If
                Next

            Case "DR/GPS Track/Fix/WPT"
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeGPS Or
                            DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldGPS Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeDR Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldDR Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeWayPoint Or
                        DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeFix Then
                        DataGridView1.Rows(x).Visible = True
                        ColorDisplayRow(x)
                    Else
                        DataGridView1.Rows(x).Visible = False
                    End If
                Next
        End Select
        currencyManager1.ResumeBinding()
        SortingDG = False
        Exit Sub
    End Sub

    ' background and foreground colors for each type of Log Type - whether displayed in grid or for entry fields at top of form
    Private GPSBackColor As Color = Color.DeepSkyBlue
    Private GPSForeColor As Color = Color.DarkBlue
    Private DRBackColor As Color = Color.LimeGreen
    Private DRForeColor As Color = Color.DarkBlue
    Private PlanBackColor As Color = Color.AntiqueWhite
    Private PlanForeColor As Color = Color.DarkBlue
    Private FixBackColor As Color = Color.LawnGreen
    Private FixForeColor As Color = Color.DarkBlue
    Private WPTBackColor As Color = Color.SeaGreen
    Private WPTForeColor As Color = Color.DarkBlue
    Private DefBackColor As Color = Color.White
    Private DefForeColor As Color = Color.DarkBlue

    Private Sub ColorDisplayRow(ByVal rowin As Integer)
        Select Case DataGridView1.Rows(rowin).Cells(LogTypeCell).Value.ToString
            Case g_LogTypeGPS, g_LogTypeOldGPS
                DataGridView1.Rows(rowin).DefaultCellStyle.BackColor = GPSBackColor
                DataGridView1.Rows(rowin).DefaultCellStyle.ForeColor = GPSForeColor
            Case g_LogTypeDR, g_LogTypeOldDR
                DataGridView1.Rows(rowin).DefaultCellStyle.BackColor = DRBackColor
                DataGridView1.Rows(rowin).DefaultCellStyle.ForeColor = DRForeColor
            Case g_LogTypePlan, g_LogTypeOldPlan
                DataGridView1.Rows(rowin).DefaultCellStyle.BackColor = PlanBackColor
                DataGridView1.Rows(rowin).DefaultCellStyle.ForeColor = PlanForeColor
            Case g_LogTypeFix
                DataGridView1.Rows(rowin).DefaultCellStyle.BackColor = FixBackColor
                DataGridView1.Rows(rowin).DefaultCellStyle.ForeColor = FixForeColor
            Case g_LogTypeWayPoint
                DataGridView1.Rows(rowin).DefaultCellStyle.BackColor = WPTBackColor
                DataGridView1.Rows(rowin).DefaultCellStyle.ForeColor = WPTForeColor
            Case Else
                DataGridView1.Rows(rowin).DefaultCellStyle.BackColor = DefBackColor
                DataGridView1.Rows(rowin).DefaultCellStyle.ForeColor = DefForeColor
        End Select
        Exit Sub
    End Sub

    Private Sub HideCommonButtons()
        linkLblNOAAVar.Visible = False
        chkHideFirst4Col.Visible = False
        Label14.Visible = False
        cboDisplayRows.Visible = False
        btnUseTVMDC.Visible = False
        btnUseZTInfoForm.Visible = False
        btnSaveFile.Visible = False
        btnExit.Visible = False
        'btnCreateReportFile.Visible = False
        btnEvalDG.Visible = False
        btnExportGPX.Visible = False
        btnUpdateExisting.Visible = False
        btnDeleteSight.Visible = False
        Exit Sub
    End Sub
    Private Sub DisplayCommonButtons()
        If My.Computer.Network.IsAvailable Then
            linkLblNOAAVar.Visible = True
            linkLblNOAAVar.Enabled = True
        End If
        chkHideFirst4Col.Visible = True
        Label14.Visible = True
        cboDisplayRows.Visible = True
        btnUseTVMDC.Visible = True
        btnUseZTInfoForm.Visible = True
        btnSaveFile.Visible = True
        btnExit.Visible = True
        'btnCreateReportFile.Visible = True
        btnEvalDG.Visible = True
        btnExportGPX.Visible = True
        Exit Sub
    End Sub

    Private Sub chkDev_CheckedChanged(sender As Object, e As EventArgs) Handles chkDev.CheckedChanged
        If InitialLoad = True Then Exit Sub
        If chkDev.CheckState = CheckState.Checked Then
            txtDev.Enabled = False
            cboDev.Enabled = False
            txtDev.BackColor = Color.Aqua
            'cboDev.BackColor = Color.Aqua
            DevForm.Show()
            DevformLoaded = True
            DevForm.SignalDeckLog = True
            Exit Sub
        End If
        If chkDev.CheckState = CheckState.Unchecked Then
            If DevformLoaded = True Then
                txtDev.Enabled = True
                cboDev.Enabled = True
                txtDev.BackColor = Color.Yellow
                'cboDev.BackColor = Color.Yellow
                'DevForm.btnExit.PerformClick()
                'DevForm.Close()
                'DevformLoaded = False
                Exit Sub
            End If

        End If
        Exit Sub
    End Sub

    Private Sub chkPlanGCR_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlanGCR.CheckedChanged
        'If InitialLoad = True Then Exit Sub
        'MessageBox.Show("You have changed the Convert Plan to GCR Pts selection - Now Click either the Add New or Change Existing button to make any changes in this Plan Log Entry")
    End Sub
    Private RcdCount As Integer = 0
    Private Sub ProcessGCRArray()
        AutoGCRMode = True

        For i As Integer = 1 To UBound(GCRArray)
            RcdCount += 1
            ' encode the Lat/Long entries in array into same encoding from saved DeckLog file 
            If i = 1 Then
                UpdtRtn.PositionLatLong = "L=" & GCRArray(i - 1).LatStr & "Lo=" & GCRArray(i - 1).LongStr
                Dim LLo1 As String = "L=" & GCRArray(i - 1).LatStr & "Lo=" & GCRArray(i - 1).LongStr
                Dim LPos1 As Integer = LLo1.IndexOf("=", StringComparison.OrdinalIgnoreCase)
                Dim LDegPos1 As Integer = LLo1.IndexOf(Chr(176))
                Dim LMinPos1 As Integer = LLo1.IndexOf("'", StringComparison.OrdinalIgnoreCase)
                Dim LoPos1 As Integer = LLo1.IndexOf("=", LPos1 + 1, StringComparison.OrdinalIgnoreCase)
                Dim LoDegPos1 As Integer = LLo1.IndexOf(Chr(176), LDegPos1 + 1)
                Dim LoMinPos1 As Integer = LLo1.IndexOf("'", LMinPos1 + 1, StringComparison.OrdinalIgnoreCase)
                txtLDeg.Text = LLo1.Substring(LPos1 + 1, (LDegPos1 - 1) - (LPos1 + 1) + 1)
                txtLMin.Text = LLo1.Substring(LDegPos1 + 1, (LMinPos1 - 1) - (LDegPos1 + 1) + 1)
                cboL.Text = LLo1.Substring(LMinPos1 + 1, 1)
                txtLoDeg.Text = LLo1.Substring(LoPos1 + 1, (LoDegPos1 - 1) - (LoPos1 + 1) + 1)
                txtLoMin.Text = LLo1.Substring(LoDegPos1 + 1, (LoMinPos1 - 1) - (LoDegPos1 + 1) + 1)
                cboLo.Text = LLo1.Substring(LoMinPos1 + 1, 1)
            End If

            ' Now Destring the encode Long & Lat into the screen fields the same as opening a file
            UpdtRtn.DestLatLongStr = "L=" & GCRArray(i).LatStr & "Lo=" & GCRArray(i).LongStr
            Dim DestLLo As String = "L=" & GCRArray(i).LatStr & "Lo=" & GCRArray(i).LongStr
            Dim LPos As Integer = DestLLo.IndexOf("=", StringComparison.OrdinalIgnoreCase)
            Dim LDegPos As Integer = DestLLo.IndexOf(Chr(176))
            Dim LMinPos As Integer = DestLLo.IndexOf("'", StringComparison.OrdinalIgnoreCase)
            Dim LoPos As Integer = DestLLo.IndexOf("=", LPos + 1, StringComparison.OrdinalIgnoreCase)
            Dim LoDegPos As Integer = DestLLo.IndexOf(Chr(176), LDegPos + 1)
            Dim LoMinPos As Integer = DestLLo.IndexOf("'", LMinPos + 1, StringComparison.OrdinalIgnoreCase)
            txtDestLDeg.Text = DestLLo.Substring(LPos + 1, (LDegPos - 1) - (LPos + 1) + 1)
            txtDestLMin.Text = DestLLo.Substring(LDegPos + 1, (LMinPos - 1) - (LDegPos + 1) + 1)
            cboDestL.Text = DestLLo.Substring(LMinPos + 1, 1)
            txtDestLoDeg.Text = DestLLo.Substring(LoPos + 1, (LoDegPos - 1) - (LoPos + 1) + 1)
            txtDestLoMin.Text = DestLLo.Substring(LoDegPos + 1, (LoMinPos - 1) - (LoDegPos + 1) + 1)
            'IF the destination Longitude is 0 degree 0 minutes then it is possible an E or W is not formatted by the Sailings FormSailings - take that into account in this last edit
            If LoMinPos + 1 > DestLLo.Length - 1 Then
                cboDestLo.Text = g_LongW
            Else
                cboDestLo.Text = DestLLo.Substring(LoMinPos + 1, 1)
            End If
            ' the entry distance and true course are calculated in the ProcessAddNew() subroutine, and are not entered here
            ProcessAddNew()
            ' all the hard work is done in the ProcessAddNew() - go there and trace the path where AutoGCRMode = true

        Next
        MessageBox.Show(RcdCount.ToString("##0", CultureInfo.CurrentCulture) & " Records were added to this DeckLog using Great Circle Route calculations")
        AutoGCRMode = False

        cboLocType.SelectedIndex = 0
        DisplayCommonButtons()
        ResetAllScreenFields()
        Exit Sub
    End Sub
    Private Sub LoadGCRSaved()
        ReDim GCRArray(UBound(FormSailings.GCRArray))

        For i As Integer = 0 To UBound(FormSailings.GCRArray)
            GCRArray(i).LongStr = FormSailings.GCRArray(i).LongStr
            GCRArray(i).LatStr = FormSailings.GCRArray(i).LatStr
            GCRArray(i).CTrue = FormSailings.GCRArray(i).CTrue
            GCRArray(i).GCRDist = FormSailings.GCRArray(i).GCRDist
        Next

        ' Process the captured GCR array into new Plan entries 
        ProcessGCRArray()
        ' Clean out the capture GCR array in case this is done back to back 
        ReDim GCRArray(0)
    End Sub

    Private Sub chkImportGCR_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboAdvType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAdvType.SelectedIndexChanged
        If cboAdvType.SelectedIndex = 0 Then
            cboAdvHrs.ReadOnly = False
            cboAdvMin.ReadOnly = False
            cboAdvNm.ReadOnly = True
            cboAdvNm.Value = 0.0

            cboAdvHrs.Visible = True
            cboAdvMin.Visible = True
            lblAdvHrMin.Visible = True
            cboAdvNm.Visible = False
            lblAdvNm.Visible = False
            Exit Sub
        End If
        If cboAdvType.SelectedIndex = 1 Then
            cboAdvHrs.ReadOnly = True
            cboAdvMin.ReadOnly = True
            cboAdvNm.ReadOnly = False
            cboAdvHrs.Value = 0
            cboAdvMin.Value = 0

            cboAdvHrs.Visible = False
            cboAdvMin.Visible = False
            lblAdvHrMin.Visible = False
            cboAdvNm.Visible = True
            lblAdvNm.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub btnEvalDG_Click(sender As Object, e As EventArgs) Handles btnEvalDG.Click
        SortDataGridonDate()
        evaluateDG()
        DisplayDGRows()
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = Nothing
        DataGridView1.Refresh()
        IsUpdated = True
        Exit Sub
    End Sub

    Private Sub txtCompass_TextChanged(sender As Object, e As EventArgs) Handles txtCompass.TextChanged

        Exit Sub
    End Sub

    Private Sub txtCTrue_TextChanged(sender As Object, e As EventArgs) Handles txtCTrue.TextChanged

        Exit Sub
    End Sub

    Private Sub txtCompass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompass.KeyPress
        'If InitialLoad = True Then Exit Sub
        'If FileLoading = True Then Exit Sub
        'If DRAdvanceMode = True Then Exit Sub

        'CompassInput = True
    End Sub

    Private Sub txtCTrue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCTrue.KeyPress
        'If InitialLoad = True Then Exit Sub
        'If FileLoading = True Then Exit Sub
        'If DRAdvanceMode = True Then Exit Sub

        'TrueInput = True
    End Sub
End Class
