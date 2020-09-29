Public Class DevForm
    Public FName As String = "./DeviationTbl/Deviation_Table.csv"
    Public IsUpdated As Boolean = False
    Public DataSet1 As DataSet = New DataSet()
    Public tablename As String = "Table1"
    Public SignalDeckLog As Boolean = False
    Public Structure DeviationRec
        Public TblCompass As Integer
        Public TblMagnetic As Integer
        Public TblDev As Integer
        Public TblDevEW As String
    End Structure
    Public DevTbl() As DeviationRec


    Private Sub FormSRF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsUpdated = False
        'Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add(tablename)
        DataSet1.Tables(tablename).Columns.Add("Compass")
        DataSet1.Tables(tablename).Columns.Add("Magnetic")
        DataSet1.Tables(tablename).Columns.Add("Dev")
        DataSet1.Tables(tablename).Columns.Add("Dev E/W")

        DataSet1.Tables(tablename).Columns(0).MaxLength = 4
        DataSet1.Tables(tablename).Columns(1).MaxLength = 4
        DataSet1.Tables(tablename).Columns(2).MaxLength = 4
        DataSet1.Tables(tablename).Columns(3).MaxLength = 3

        DGDev.DataSource = DataSet1.Tables(0).DefaultView

        DGDev.Columns(0).ReadOnly = True
        DGDev.Columns(2).ReadOnly = True
        DGDev.Columns(3).ReadOnly = True

        DGDev.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGDev.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGDev.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGDev.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGDev.Columns(0).DefaultCellStyle.BackColor = Color.LightGray
        DGDev.Columns(1).DefaultCellStyle.BackColor = Color.Yellow
        DGDev.Columns(2).DefaultCellStyle.BackColor = Color.LightGray
        DGDev.Columns(3).DefaultCellStyle.BackColor = Color.LightGray

        ApplyDefaultValues()

        Me.Show()
        IsUpdated = False
        OpenDevFile()

        If DGDev.RowCount = 0 Then
            ' if for some reason the deviation table csv file is corrupted or empty then simply apply defaults to reinit the datagrid
            Dim MsgBack As MsgBoxResult = MsgBox("Default Deviation_Tbl.csv has no data in it. Apply default deviation values? - Yes=Apply or No=Exit ", MsgBoxStyle.YesNo, "Input File Has No Data")
            If MsgBack = MsgBoxResult.Yes Then
                ApplyDefaultValues()
            Else
                Me.Close()
                Exit Sub
            End If
        End If

        DGDev.Rows(8).Cells(1).ReadOnly = True
        DGDev.Rows(0).Cells(1).Selected = True
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub OpenDevFile()

        Dim ReadError As Boolean = False
        Dim myStream As System.IO.StreamReader = Nothing
        Dim openFileDialog2 As New OpenFileDialog()
        Dim CurrDir As String = System.IO.Directory.GetCurrentDirectory()

        If IsUpdated = True Then
            Dim MsgBack As MsgBoxResult = MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data")
            If MsgBack = MsgBoxResult.Yes Then
                SaveDevDataGrid()
                IsUpdated = False
            Else
                'Exit Sub
            End If

        End If

        openFileDialog2.Reset()
        openFileDialog2.InitialDirectory = CurrDir & "\DeviationTbl"
        openFileDialog2.Filter = "csv files (*.csv)|*.csv"
        openFileDialog2.Title = "Open Deviation Table File"
        openFileDialog2.FilterIndex = 2
        openFileDialog2.RestoreDirectory = True
        openFileDialog2.AutoUpgradeEnabled = True

        If openFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If openFileDialog2.FileName = vbNullString Then
                Exit Sub
            End If
            DataSet1.Tables(tablename).Clear()
            ReadError = False

            Dim ReadNum As Integer = 0
            Try
                myStream = New System.IO.StreamReader(openFileDialog2.FileName)
                If (myStream IsNot Nothing) Then
                    FName = openFileDialog2.FileName
                    Dim SLOpenFName As String = openFileDialog2.FileName
                    txtOpenFile.Text = "Current Deviation File is: " & SLOpenFName
                    Dim allData As String = myStream.ReadToEnd()
                    Dim rows As String() = allData.Split(vbCrLf) '("\r".ToCharArray())
                    Dim incr1 As Integer = 0
                    For Each r As String In rows
                        r = r.Trim(vbLf).Trim
                        r = r.Trim(vbLf).Trim
                        Dim items1 As String() = r.Split(",")
                        If items1(0) <> vbNullString And items1(0) <> Nothing Then
                            DataSet1.Tables(tablename).Rows.Add(items1)
                        End If
                        ReadNum += 1
                        incr1 += 1
                    Next
                    myStream.Close()

                End If
                openFileDialog2.Dispose()

                myStream.Dispose()
                DGDev.DataSource = DataSet1.Tables(0).DefaultView
                DGDev.ClearSelection()
                DGDev.CurrentCell = Nothing
                DGDev.Refresh()
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

        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If SignalDeckLog = True Then
            DeckLogUpdate.DevformLoaded = False
            DeckLogUpdate.chkDev.Checked = False
        End If
        If CheckOpenWinForms("FormTVMDC") = True Then
            FormTVMDC.FormDevTable_frmHasOpenedForBusiness = False
            FormTVMDC.chkDev.Checked = False
        End If

        SaveDevDataGrid()
        Me.Close()
    End Sub

    Public Shared Function CheckOpenWinForms(ByVal FormNameIn As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals(FormNameIn, StringComparison.CurrentCulture) Then
                Return True
                Exit Function
            End If
        Next
        Return False
        Exit Function
    End Function

    'Public Sub SaveDataGrid()
    '    Dim textstr As New System.Text.StringBuilder()
    '    For x As Integer = 0 To DGDev.Rows.Count - 1
    '        If IsNothing(DGDev.Rows(x).Cells(0).Value) = False Then
    '            For v As Integer = 0 To DGDev.Columns.Count - 1
    '                'extracting cell value from 0 to 9 and add it on list
    '                If v > 0 Then
    '                    textstr.Append(",")
    '                End If
    '                Dim tempstr As String = DGDev.Rows(x).Cells(v).Value.ToString()
    '                tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
    '                textstr.Append(tempstr)
    '            Next
    '        End If
    '        'adding new line to text
    '        textstr.AppendLine()
    '    Next
    '    IO.File.WriteAllText(FName, textstr.ToString())

    '    Exit Sub
    'End Sub

    Private Sub btnExitNoSave_Click(sender As Object, e As EventArgs)
        If SignalDeckLog = True Then
            DeckLogUpdate.DevformLoaded = False
            DeckLogUpdate.chkDev.Checked = False
        End If
        Me.Close()
        Exit Sub
    End Sub

    Private Sub btnSaveInput_Click(sender As Object, e As EventArgs) Handles btnSaveInput.Click

        SaveDevDataGrid()
        Exit Sub
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ApplyDefaultValues()
        Exit Sub
    End Sub
    Private Sub ApplyDefaultValues()
        DataSet1.Tables(tablename).Clear()
        DataSet1.Tables(tablename).Rows.Add("0", "0", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("45", "45", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("90", "90", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("135", "135", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("180", "180", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("225", "225", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("270", "270", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("315", "315", "0", g_LongW)
        DataSet1.Tables(tablename).Rows.Add("360", "360", "0", g_LongW)
        DGDev.Rows(0).Cells(1).Selected = True
        IsUpdated = True
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub DGDev_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGDev.CellValueChanged
        Dim idx As Integer = e.RowIndex
        If idx = 8 Then Exit Sub
        Dim TryInt As Integer = 0
        If Integer.TryParse(DGDev.Rows(idx).Cells(1).Value, TryInt) Then
            If TryInt > 359 Then
                DGDev.Rows(idx).Cells(1).Selected = True
                ErrorMsgBox("Dev Mag Value too large - must be 0 to 359")
                Beep()
                Exit Sub
            End If
        Else
            DGDev.Rows(idx).Cells(1).Selected = True
            ErrorMsgBox("Dev Mag Value Must an Integer between 0 to 359")
            Beep()
            Exit Sub
        End If
        Dim tempdev As Integer = 0  'DGDev.Rows(idx).Cells(2).Value
        tempdev = Convert.ToInt32(DGDev.Rows(idx).Cells(0).Value) - TryInt
        If idx = 0 And TryInt > 180 Then
            tempdev = 360 - Math.Abs(tempdev)
        End If

        DGDev.Rows(idx).Cells(2).Value = System.Math.Abs(tempdev).ToString("#0")
        If tempdev < 0 Then
            DGDev.Rows(idx).Cells(3).Value = g_LongE
        Else
            DGDev.Rows(idx).Cells(3).Value = g_LongW
        End If
        If idx = 0 Then
            DGDev.Rows(8).Cells(1).Value = DGDev.Rows(idx).Cells(1).Value
            DGDev.Rows(8).Cells(2).Value = System.Math.Abs(tempdev).ToString("#0")
            DGDev.Rows(8).Cells(3).Value = DGDev.Rows(idx).Cells(3).Value
        End If
        IsUpdated = True
        Exit Sub
    End Sub
    Private Sub BuildTblFromDG()
        ReDim DevTbl(9)
        For i As Integer = 0 To 8
            DevTbl(i).TblCompass = Convert.ToInt32(DGDev.Rows(i).Cells(0).Value)
            DevTbl(i).TblMagnetic = Convert.ToInt32(DGDev.Rows(i).Cells(1).Value)
            DevTbl(i).TblDevEW = DGDev.Rows(i).Cells(3).Value
            If DGDev.Rows(i).Cells(3).Value = g_LongW Then
                DevTbl(i).TblDev = Convert.ToInt32(DGDev.Rows(i).Cells(2).Value) * (-1)
            Else
                DevTbl(i).TblDev = Convert.ToInt32(DGDev.Rows(i).Cells(2).Value)
            End If
        Next
        If DevTbl(8).TblMagnetic < 10 Then
            DevTbl(8).TblMagnetic += 360
        End If
        Exit Sub
    End Sub
    Public Function DevInterpolateCompass(ByVal CompassIn As Integer) As DeviationRec
        Dim RtnRec As DeviationRec
        RtnRec.TblCompass = 0
        RtnRec.TblMagnetic = 0
        RtnRec.TblDev = 0
        RtnRec.TblDevEW = g_LongW
        BuildTblFromDG()
        Dim lastIdx As Integer = 0
        For i As Integer = 0 To 7
            If DevTbl(i).TblCompass = CompassIn Then
                RtnRec.TblCompass = CompassIn
                RtnRec.TblMagnetic = DevTbl(i).TblMagnetic
                RtnRec.TblDev = DevTbl(i).TblDev
                RtnRec.TblDevEW = DevTbl(i).TblDevEW
                Return RtnRec
                Exit Function
            End If
            Dim MagCompare1 As Integer = 0
            Dim MagCompare2 As Integer = 0
            'If i = 0 And DevTbl(i).TblMagnetic > 270 Then
            '    MagCompare1 = 360 - DevTbl(i).TblMagnetic
            'Else
            '    MagCompare1 = DevTbl(i).TblMagnetic
            'End If
            'If i = 7 And DevTbl(i + 1).TblMagnetic > 0 And DevTbl(i + 1).TblMagnetic < 90 Then
            '    MagCompare2 = 360 - DevTbl(i + 1).TblMagnetic
            'Else
            '    MagCompare2 = DevTbl(i + 1).TblMagnetic
            'End If
            If CompassIn > DevTbl(i).TblCompass And CompassIn < DevTbl(i + 1).TblCompass Then
                Dim DeltaCinC1 As Double = CompassIn - DevTbl(i).TblCompass
                Dim DeltaC2C1 As Double = DevTbl(i + 1).TblCompass - DevTbl(i).TblCompass
                Dim DeltaM2M1 As Double = DevTbl(i + 1).TblMagnetic - DevTbl(i).TblMagnetic
                If i = 0 And DevTbl(i).TblMagnetic > 270 Then
                    DeltaM2M1 = DevTbl(i + 1).TblMagnetic + (360 - DevTbl(i).TblMagnetic)
                End If
                If i = 7 And DevTbl(i + 1).TblMagnetic > 0 And DevTbl(i + 1).TblMagnetic < 90 Then
                    DeltaM2M1 = (360 - DevTbl(i + 1).TblMagnetic) + DevTbl(i).TblMagnetic
                End If
                Dim DeltaD2D1 As Double = DevTbl(i + 1).TblDev - DevTbl(i).TblDev
                Dim DevRtn As Double = ((DeltaCinC1 / DeltaC2C1) * (DeltaD2D1)) + DevTbl(i).TblDev
                Dim MagRtn As Double = ((DeltaCinC1 / DeltaC2C1) * (DeltaM2M1)) + DevTbl(i).TblMagnetic
                If MagRtn >= 360 Then
                    MagRtn = System.Math.Abs(360 - MagRtn)
                End If
                RtnRec.TblCompass = CompassIn
                RtnRec.TblMagnetic = Convert.ToInt32(MagRtn)
                RtnRec.TblDev = Convert.ToInt32(System.Math.Round(DevRtn, 0, MidpointRounding.AwayFromZero))
                If DevRtn < 0 Then
                    RtnRec.TblDevEW = g_LongW
                Else
                    RtnRec.TblDevEW = g_LongE
                End If
                Return RtnRec
                Exit Function
            End If
        Next
        Return RtnRec
        Exit Function
    End Function

    Public Function DevInterpolateMagnetic(ByVal MagneticIn As Integer) As DeviationRec
        Dim RtnRec As DeviationRec
        RtnRec.TblCompass = 0
        RtnRec.TblMagnetic = 0
        RtnRec.TblDev = 0
        RtnRec.TblDevEW = g_LongW
        BuildTblFromDG()
        If MagneticIn < DevTbl(0).TblMagnetic And DevTbl(0).TblMagnetic <= DevTbl(0).TblDev Then
            MagneticIn = DevTbl(0).TblMagnetic
        End If
        For i As Integer = 0 To 7
            If DevTbl(i).TblMagnetic = MagneticIn Then
                RtnRec.TblCompass = DevTbl(i).TblCompass
                RtnRec.TblMagnetic = MagneticIn
                RtnRec.TblDev = DevTbl(i).TblDev
                RtnRec.TblDevEW = DevTbl(i).TblDevEW
                Return RtnRec
                Exit Function
            End If
            Dim MagCompare1 As Integer = 0
            Dim MagCompare2 As Integer = 0

            If i = 0 And DevTbl(i).TblMagnetic > 270 Then
                MagCompare1 = DevTbl(i).TblMagnetic - 360
            Else
                MagCompare1 = DevTbl(i).TblMagnetic
            End If
            If i = 7 And DevTbl(i + 1).TblMagnetic > 0 And DevTbl(i + 1).TblMagnetic < 90 Then
                MagCompare2 = DevTbl(i + 1).TblMagnetic - 360
            Else
                MagCompare2 = DevTbl(i + 1).TblMagnetic
            End If
            If MagneticIn > MagCompare1 And MagneticIn < DevTbl(i + 1).TblMagnetic Then
                Dim DeltaMinM1 As Double = MagneticIn - MagCompare1
                Dim DeltaC2C1 As Double = DevTbl(i + 1).TblCompass - DevTbl(i).TblCompass
                Dim DeltaM2M1 As Double = MagCompare2 - MagCompare1 'DevTbl(i).TblMagnetic
                'If i = 0 And DevTbl(i).TblMagnetic > 270 Then
                'DeltaM2M1 = DevTbl(i + 1).TblMagnetic - MagCompare '(360 - DevTbl(i).TblMagnetic)
                'End If
                'If i = 7 And DevTbl(i + 1).TblMagnetic > 0 And DevTbl(i + 1).TblMagnetic < 90 Then
                'DeltaM2M1 = (360 - DevTbl(i + 1).TblMagnetic) - DevTbl(i).TblMagnetic
                'End If
                Dim DeltaD2D1 As Double = DevTbl(i + 1).TblDev - DevTbl(i).TblDev
                Dim DevRtn As Double = ((DeltaMinM1 / DeltaM2M1) * (DeltaD2D1)) + DevTbl(i).TblDev
                Dim CompassRtn As Double = ((DeltaMinM1 / DeltaM2M1) * (DeltaC2C1)) + DevTbl(i).TblCompass
                If CompassRtn >= 360 Then
                    CompassRtn = 360 - CompassRtn
                End If
                RtnRec.TblCompass = Convert.ToInt32(CompassRtn)
                RtnRec.TblMagnetic = MagneticIn
                RtnRec.TblDev = Convert.ToInt32(System.Math.Round(DevRtn, 0, MidpointRounding.AwayFromZero))
                If DevRtn < 0 Then
                    RtnRec.TblDevEW = g_LongW
                Else
                    RtnRec.TblDevEW = g_LongE
                End If
                Return RtnRec
                Exit Function
            End If

        Next
        If MagneticIn > DevTbl(8).TblMagnetic Then
            Dim DeltaMinM1 As Double = MagneticIn - DevTbl(0).TblMagnetic
            Dim DeltaC2C1 As Double = DevTbl(1).TblCompass - DevTbl(0).TblCompass
            Dim DeltaM2M1 As Double = DevTbl(1).TblMagnetic - (DevTbl(0).TblMagnetic - 360) 'DevTbl(i).TblMagnetic
            Dim DeltaD2D1 As Double = DevTbl(1).TblDev - DevTbl(0).TblDev
            Dim DevRtn As Double = ((DeltaMinM1 / DeltaM2M1) * (DeltaD2D1)) + DevTbl(0).TblDev
            Dim CompassRtn As Double = ((DeltaMinM1 / DeltaM2M1) * (DeltaC2C1)) + DevTbl(0).TblCompass
            If CompassRtn >= 360 Then
                CompassRtn = 360 - CompassRtn
            End If
            RtnRec.TblCompass = Convert.ToInt32(CompassRtn)
            RtnRec.TblMagnetic = MagneticIn
            RtnRec.TblDev = Convert.ToInt32(System.Math.Round(DevRtn, 0, MidpointRounding.AwayFromZero))
            If DevRtn < 0 Then
                RtnRec.TblDevEW = g_LongW
            Else
                RtnRec.TblDevEW = g_LongE
            End If
            Return RtnRec
        End If
        Return RtnRec
        Exit Function
    End Function
    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub btnTestInterp_Click(sender As Object, e As EventArgs) Handles btnTestInterp.Click
        TestDev.Show()
        Exit Sub

    End Sub

    Private Sub btnOpenDev_Click(sender As Object, e As EventArgs) Handles btnOpenDev.Click
        OpenDevFile()
    End Sub

    Public Sub SaveDevDataGrid()
        If IsUpdated = False Then Exit Sub

        Dim saveFileDialog1 As New SaveFileDialog()

        'Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
        saveFileDialog1.InitialDirectory = "./DeviationTbl/"
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv"
        saveFileDialog1.Title = "Save Deviation Table File"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFileDialog1.FileName = vbNullString Then
                Exit Sub
            End If
            FName = saveFileDialog1.FileName
        End If

        Dim textstr As New System.Text.StringBuilder()

        For x As Integer = 0 To DGDev.Rows.Count - 1
            If IsNothing(DGDev.Rows(x).Cells(0).Value) = False Then
                For v As Integer = 0 To DGDev.Columns.Count - 1
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then
                        textstr.Append(",")
                    End If
                    Dim tempstr As String = DGDev.Rows(x).Cells(v).Value.ToString()
                    tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
                    textstr.Append(tempstr)
                Next
            End If
            'adding new line to text
            textstr.AppendLine()
        Next
        IO.File.WriteAllText(FName, textstr.ToString())
        txtOpenFile.Text = "Open and Saved File Name is: " & FName
        Exit Sub
    End Sub
End Class
