Public Class FavoriteLocations

    Public Structure FavoriteLoc
        Public EntryStatus As String
        Public SLName As String
        Public SightNum As String
        Public DST As String
        Public DRLat As String 'format NN*NN.N'N or S where * = CHR(176) degree
        Public DRLong As String ' format NNN*NN.N'E or W where * = CHR(176) degree 
        Public HE As String ' N.N feet
        Public HorType As String ' N - Natural, D - Dip, or A - Artificial 
        Public HorDist As String
        Public HorDistType As String ' F - Feet, Y - Yards, M - Statute Mile, N - Nautical Mile
        Public ZD As String
        Public Remarks As String
        Public ApprxBrg As String
        Public FromAZ As String
        Public ToAZ As String
        Public hsIEFormat As String
    End Structure
    Public Structure SharedLoc
        Public EntryStatus As String
        Public SLName As String
        Public SightNum As String
        Public DST As String
        Public DRLat As String 'format NN*NN.N'N or S where * = CHR(176) degree
        Public DRLatDeg As Integer
        Public DRLatMin As Double
        Public DRLatNS As String
        Public DRLong As String ' format NNN*NN.N'E or W where * = CHR(176) degree 
        Public DRLongDeg As Integer
        Public DRLongMin As Double
        Public DRLongEW As String
        Public HE As Double ' N.N feet
        Public HEType As String
        Public HorType As String ' N - Natural, D - Dip, or A - Artificial 
        Public HorDist As Double
        Public HorDistType As String ' F - Feet, Y - Yards, M - Statute Mile, N - Nautical Mile
        Public ZD As String
        Public ZDhr As String
        Public ZDmin As String
        Public Remarks As String
        Public ApprxBrg As String
        Public FromAZ As Integer
        Public ToAZ As Integer
        Public hsIEFormat As String
        Public HorDistIndex As Integer
        Public HETypeIndex As Integer
        Public ZDAutoSelect As Boolean
    End Structure
    Public Structure ZDParms
        Public ZDField As String
        Public ZDIndex As Integer
        Public ZDHhours As String
        Public ZDMin As String

        Public Sub New(strIn As String, intIn As Integer, HourIn As Integer, MinIn As Integer)
            Me.New()
            Me.ZDField = strIn
            Me.ZDIndex = intIn
            Me.ZDHhours = HourIn.ToString
            Me.ZDMin = MinIn.ToString
        End Sub
    End Structure
    Public SharedLocUse As SharedLoc
    Public SRFa As Double = 0
    Public SRFZn As Double = 0
    Public SRFSightUpd As Boolean = False
    Private FavoriteLocArray As FavoriteLoc()
    Private SLFName As String = vbNullString
    Private SLDir As String = "./FavoriteLocs/"
    'Private SLDefName As String = "FavoriteLoc" & Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
    Private SLOpenFName As String = vbNullString

    Private EntryIndex As Integer = 0

    Private FileUpdated As Boolean = False
    Private CommonSE As FavoriteLoc
    Private ReadError As Boolean = False
    Private FileLoading As Boolean = False
    Private ZDArray As ZDParms() = {
        New ZDParms("+01", 0, 1, 0),
        New ZDParms("+02", 1, 2, 0),
        New ZDParms("+03", 2, 3, 0),
        New ZDParms("+03:30", 3, 3, 30),
        New ZDParms("+04", 4, 4, 0),
        New ZDParms("+04:30", 5, 4, 30),
        New ZDParms("+05", 6, 5, 0),
        New ZDParms("+05:30", 7, 5, 30),
        New ZDParms("+05:45", 8, 5, 45),
        New ZDParms("+06", 9, 6, 0),
        New ZDParms("+06:30", 10, 6, 30),
        New ZDParms("+07", 11, 7, 0),
        New ZDParms("+08", 12, 8, 0),
        New ZDParms("+08:45", 13, 8, 45),
        New ZDParms("+09", 14, 9, 0),
        New ZDParms("+09:30", 15, 9, 30),
        New ZDParms("+10", 16, 10, 0),
        New ZDParms("+10:30", 17, 10, 30),
        New ZDParms("+11", 18, 11, 0),
        New ZDParms("+12", 19, 12, 0),
        New ZDParms("+12:45", 20, 12, 45),
        New ZDParms("+13", 21, 13, 0),
        New ZDParms("+13:45", 22, 13, 45),
        New ZDParms("+14", 23, 14, 0),
        New ZDParms("+00", 24, 0, 0),
        New ZDParms("-01", 25, -1, 0),
        New ZDParms("-02", 26, -2, 0),
        New ZDParms("-02:30", 27, -2, 30),
        New ZDParms("-03", 28, -3, 0),
        New ZDParms("-03:30", 29, -3, 30),
        New ZDParms("-04", 30, -4, 0),
        New ZDParms("-05", 31, -5, 0),
        New ZDParms("-06", 32, -6, 0),
        New ZDParms("-07", 33, -7, 0),
        New ZDParms("-08", 34, -8, 0),
        New ZDParms("-09", 35, -9, 0),
        New ZDParms("-09:30", 36, -9, 30),
        New ZDParms("-10", 37, -10, 0),
        New ZDParms("-11", 38, -11, 0),
        New ZDParms("-12", 39, -12, 0),
        New ZDParms("Auto", 40, 0, 0)
    }
    Public ZDGMTIdx As Integer = 24
    Public ZDInitIdx As Integer = 40

    ' these are the indexes for the data grid view cells and they must ALWAY be kept in sync with the datagridview order of cells.
    Public SightNumCell As Integer = 0
    Public SLNameCell As Integer = 1
    Public DRLatCell As Integer = 2
    Public DRLongCell As Integer = 3
    Public ZDCell As Integer = 4
    Public DSTCell As Integer = 5
    Public FromAZCell As Integer = 6
    Public ToAZCell As Integer = 7
    Public HorTypeCell As Integer = 8
    Public HorDistCell As Integer = 9
    Public HECell As Integer = 10
    Public ApprxBrgCell As Integer = 11
    Public hsIEFmtCell As Integer = 12

    Public EditError As Boolean = False
    Public MasterDSTChecked As Boolean = False
    Public AutoZDSelected As Boolean = False
    ' Print Data Grid variable
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Private pages As Dictionary(Of Integer, pageDetails)
    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer

    Public Sub GetSharedLoc(ByRef SharedLocIn As SharedLoc)
        ' Init the SharedLocIn variable sent into this prog as a ref and only format it with real info if there is shared data otherwise it is an empty structure
        ' Program calling this subroutine must allocate local variable as ShareLoc and send it to this subroutine as a ref for local use in that prog 
        With SharedLocIn
            .EntryStatus = "Empty"
            .SightNum = vbNullString
            .SLName = vbNullString
            .DRLat = vbNullString
            .DRLatDeg = 0
            .DRLatMin = 0
            .DRLong = vbNullString
            .DRLongDeg = 0
            .DRLongMin = 0
            .ZD = vbNullString
            .DST = vbNullString
            .FromAZ = vbNullString
            .ToAZ = vbNullString
            .HorType = vbNullString
            .HorDist = 0
            .HorDistType = vbNullString
            .HE = 0
            .HEType = vbNullString
            .ApprxBrg = vbNullString
            .hsIEFormat = vbNullString
            .ZDAutoSelect = False
        End With
        If SharedLocUse.EntryStatus = "Shared" Then
            SharedLocIn = SharedLocUse
        End If
        Exit Sub
    End Sub
    Private Sub LoadZDDropDown()
        cboZD.Items.Clear()
        Dim lim As Integer = 0
        For lim = 0 To UBound(ZDArray)
            cboZD.Items.Add(ZDArray(lim).ZDField)
        Next
        cboZD.SelectedIndex = ZDInitIdx
        Exit Sub
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Before starting to exit, check to see if a location is shared. If a location is shared this form must offer the option to stay open so other programs can access shared loc data. 
        If SharedLocUse.EntryStatus = "Shared" Then
            If System.Windows.Forms.MessageBox.Show("A Location is Shared - Confirm Exit with Yes - Cancel Exit with No and Clear Shared Location?", "A Location is Shared - Confirm Exit?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.No Then

                Exit Sub
            End If
            ExecInitSharedLoc()

        End If
        ' Now to exit properly, see if the location data has been updated but not saved to a file. Offer the option to save location data to a file then exit
        If FileUpdated = True Then
            If System.Windows.Forms.MessageBox.Show("Save Current File?  Yes / No ?", "Save File?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
                ExecFileSave()
            Else
                'Me.Close()
            End If
        Else
            'Me.Close()
        End If
        Me.Close()
        Exit Sub
    End Sub
    Public Sub QuickExit()
        If SharedLocUse.EntryStatus = "Shared" Then
            ExecInitSharedLoc()
        End If
        If FileUpdated = True Then
            ExecFileSave()
        End If
        Me.Close()

        Exit Sub
    End Sub
    Private Sub FavoriteLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SharedLocUse = New SharedLoc()
        SharedLocUse.EntryStatus = "Empty"
        LoadZDDropDown()
        ExecInitScreen()
        SEDataGrid.Rows.Clear()
        SEDataGrid.Refresh()
        cboHSIEFmt.SelectedIndex = 0
        Exit Sub
    End Sub
    Private Sub ExecInitScreen()
        Dim CurrDir As String = My.Computer.FileSystem.CurrentDirectory()
        FileUpdated = False
        SLDir = CurrDir & "\FavoriteLocs"
        ' check if Sight Log Dir for files exists - if not then create dir - this protects the very first time program is run
        If My.Computer.FileSystem.DirectoryExists(SLDir) = False Then
            My.Computer.FileSystem.CreateDirectory(SLDir)
        End If

        ExecInitSharedLoc()

        ReDim FavoriteLocArray(1)
        FavoriteLocArray(0).EntryStatus = "Empty"

        btnUpdateExisting.Visible = False
        btnDeleteSight.Visible = False
        btnShowSharedLoc.Visible = False
        btnUseLocation.Visible = False
        btnClearShared.Visible = False
        btnSaveLog.Visible = False
        btnPrintDG.Visible = False
        btnSLReport.Visible = False
        'btnNewLog.Visible = False
        ExecClearScreenFields()
        SEDataGrid.Rows.Clear()
        SEDataGrid.Refresh()
        Exit Sub
    End Sub
    Private Sub ExecClearScreenFields()
        ' when you clear the input fields turn off the update button. when a row is selected from the data then this button appears
        btnUpdateExisting.Visible = False

        btnClearFields.Visible = False
        btnDeleteSight.Visible = False
        btnShowSharedLoc.Visible = False
        btnUseLocation.Visible = False
        btnClearShared.Visible = False

        txtName.Clear()
        cboLo.SelectedIndex = 0 'W
        cboL.SelectedIndex = 0 'N
        cboZD.SelectedIndex = ZDInitIdx
        chkbxDST.Checked = False

        cbHorizon.SelectedIndex = 0
        cbHorDistType.SelectedIndex = 0

        cboHEUnit.SelectedIndex = 0
        cboApprxBrg.SelectedIndex = 8 ' None

        txtSightNum.Clear()
        txtLDeg.Clear()
        txtLMin.Clear()
        cboL.SelectedIndex = 0
        txtLoDeg.Clear()
        txtLoMin.Clear()
        cboLo.SelectedIndex = 0
        txtFromAZ.Text = "0"
        txtToAZ.Text = "360"

        txtHorDist.Clear()
        cbHorizon.SelectedIndex = 0
        cbHorDistType.SelectedIndex = 0
        txtHE.Clear()
        cboHEUnit.SelectedIndex = 0
        cboApprxBrg.SelectedIndex = 0
        cboHSIEFmt.SelectedIndex = 0
        chkbxSharedLoc.Checked = False

        Dim ArraySize As Integer = UBound(FavoriteLocArray)
        Dim ActiveArray As Integer = 0
        For i = 0 To ArraySize
            If FavoriteLocArray(i).EntryStatus = "Active" Then
                ActiveArray += 1
            End If
        Next
        If ActiveArray = 0 Then
            btnUpdateExisting.Visible = False
            btnClearFields.Visible = False
            btnDeleteSight.Visible = False
            btnShowSharedLoc.Visible = False
            btnUseLocation.Visible = False
            btnClearShared.Visible = False
        End If

        Exit Sub
    End Sub

    Private Sub btnOpenLog_Click(sender As Object, e As EventArgs) Handles btnOpenLog.Click
        Dim myStream As System.IO.StreamReader = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        Dim rdline As String = vbNullString
        openFileDialog1.InitialDirectory = SLDir
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.Title = "Open Sight Log Text File"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        ExecInitSharedLoc()
        ExecClearScreenFields()

        ReDim FavoriteLocArray(1)
        FavoriteLocArray(0).EntryStatus = "Empty"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If openFileDialog1.FileName = vbNullString Then
                Exit Sub
            End If
            ReadError = False
            FileLoading = True
            Try
                myStream = New System.IO.StreamReader(openFileDialog1.FileName)
                If (myStream IsNot Nothing) Then
                    SLOpenFName = openFileDialog1.FileName
                    SEDataGrid.Rows.Clear()
                    SEDataGrid.Refresh()
                    Do While myStream.Peek() >= 0
                        rdline = myStream.ReadLine()
                        If rdline <> vbNullString Then
                            ParseReadLine(rdline)
                            rdline = vbNullString
                            If ReadError = True Then
                                GoTo LeaveReadLoop
                            End If
                        End If
                    Loop
LeaveReadLoop:
                    myStream.Close()

                    PrepareSightArray()
                    BuildDGFromSightArray()

                End If
                'myStream.Dispose()
                SEDataGrid.Refresh()
                FileLoading = False
                btnPrintDG.Visible = True
                btnSLReport.Visible = True
            Catch Ex As Exception
                ErrorMsgBox("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnSaveLog_Click(sender As Object, e As EventArgs) Handles btnSaveLog.Click

        ExecFileSave()
        FileUpdated = False
        Exit Sub
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ExecAddNew()
        ExecClearScreenFields()
        Exit Sub
    End Sub

    Private Sub btnUpdateExisting_Click(sender As Object, e As EventArgs) Handles btnUpdateExisting.Click
        ' updating a sight entry do not carry forward the old sight reduction - may no longer be valid so zero out Int and Zn fields
        ExecUpdateExisting()
        ExecClearScreenFields()
        Exit Sub
    End Sub
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        ExecClearScreenFields()
        Exit Sub
    End Sub
    Private Sub ExecUpdateExisting()
        Dim SaveSightNum As String = txtSightNum.Text
        FileUpdated = True
        EditError = False
        If EditScreenFields() = True Then
            ' Mark the current sight num entry in sight log array as 'Deleted' 
            Dim i As Integer = 0
            Dim DidDelete As Boolean = False
            For i = 0 To UBound(FavoriteLocArray)
                If FavoriteLocArray(i).SightNum = SaveSightNum Then
                    If FavoriteLocArray(i).EntryStatus = "Active" Then
                        FavoriteLocArray(i).EntryStatus = "Deleted"
                        DidDelete = True
                    End If
                End If
            Next
            If DidDelete = False Then
                ErrorMsgBox("Did Not Mark Old Entry as Deleted - Debug This")
                Exit Sub
            End If
            ' build new sight entry into array from screen data
            BuildArrayFromscreen()
            ' now rebuild list box display of sight array
            PrepareSightArray()
            BuildDGFromSightArray()
            If CountActiveSEArray() > 0 Then
                btnSaveLog.Visible = True
                btnPrintDG.Visible = True
                btnSLReport.Visible = True
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
                btnShowSharedLoc.Visible = True
                btnUseLocation.Visible = True
                btnClearShared.Visible = True
            End If
            FileUpdated = True
            FileLoading = False

        Else
            EditError = True
        End If

        Exit Sub
    End Sub

    Private Sub btnDeleteSight_Click(sender As Object, e As EventArgs) Handles btnDeleteSight.Click
        FileUpdated = True
        ' to delete a location, you must first select it and bring its info to the top. 
        ' first check if selected info for deletion is a shared set of info - if so, then set shared check box off and init shared loc block info
        If chkbxSharedLoc.Checked = True Then
            Dim DYesNo As DialogResult

            DYesNo = System.Windows.Forms.MessageBox.Show("This location is shared. Delete shared location? Yes / No", "Delete Shared Location?",
                                                    System.Windows.Forms.MessageBoxButtons.YesNo,
                                                    System.Windows.Forms.MessageBoxIcon.Question,
                                                    System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                    System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
            If DYesNo = DialogResult.Yes Then
                chkbxSharedLoc.Checked = False
                With SharedLocUse
                    .EntryStatus = "Empty"
                    .SightNum = vbNullString
                    .SLName = vbNullString
                    .DRLat = vbNullString
                    .DRLatDeg = 0
                    .DRLatMin = 0
                    .DRLong = vbNullString
                    .DRLongDeg = 0
                    .DRLongMin = 0
                    .ZD = vbNullString
                    .DST = vbNullString
                    .FromAZ = vbNullString
                    .ToAZ = vbNullString
                    .HorType = vbNullString
                    .HorDist = 0
                    .HorDistType = vbNullString
                    .HE = 0
                    .HEType = vbNullString
                    .ApprxBrg = vbNullString
                    .hsIEFormat = vbNullString
                End With
            Else
                Exit Sub
            End If
        End If

        Dim i As Integer = 0
        Dim DidDelete As Boolean = False
        For i = 0 To UBound(FavoriteLocArray)
            If FavoriteLocArray(i).SightNum = txtSightNum.Text Then
                If FavoriteLocArray(i).EntryStatus = "Active" Then
                    FavoriteLocArray(i).EntryStatus = "Deleted"
                    DidDelete = True
                End If
            End If
        Next
        If DidDelete = False Then
            ErrorMsgBox("Did Not Mark Old Entry as Deleted - Debug This")
            Exit Sub
        End If

        PrepareSightArray()
        BuildDGFromSightArray()
        ExecClearScreenFields()
        Exit Sub
    End Sub
    Private Sub btnNewLog_Click(sender As Object, e As EventArgs) Handles btnNewLog.Click
        Dim DYesNo As DialogResult
        FileLoading = True
        If FileUpdated = True Then

            DYesNo = System.Windows.Forms.MessageBox.Show("Save Current File? Yes / No", "Save file?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
            If DYesNo = DialogResult.Yes Then
                ExecFileSave()
            Else
                ExecInitScreen()
            End If
        Else
            ExecInitScreen()
        End If
        SEDataGrid.Rows.Clear()
        SEDataGrid.Refresh()
        FileLoading = False
        Exit Sub
    End Sub
    Private Sub ExecFileSave()
        Dim i As Integer = 0
        Dim iCnt As Integer = 0
        Dim SE As FavoriteLoc = New FavoriteLoc

        For i = 0 To UBound(FavoriteLocArray)
            SE = FavoriteLocArray(i)
            If SE.EntryStatus = "Active" Then
                iCnt += 1
            End If
        Next
        If iCnt = 0 Then
            ErrorMsgBox("No Data to Save to File - Add Data or Exit")
            FileUpdated = False
            Me.Show()
            Exit Sub
        End If
        Me.BringToFront()
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.Title = "Save this Shared Location Data File"
        saveFileDialog1.InitialDirectory = SLDir
        saveFileDialog1.FileName = SLOpenFName
        saveFileDialog1.ShowDialog(Me)

        If saveFileDialog1.FileName <> "" Then
            SLOpenFName = saveFileDialog1.FileName
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog1.FileName, False)
            i = 0
            For i = 0 To UBound(FavoriteLocArray)
                SE = FavoriteLocArray(i)
                If SE.EntryStatus = "Active" Then
                    objWriter.WriteLine(FormatSightForSave(SE))
                End If
            Next
            objWriter.Close()
            'objWriter.Dispose()
        End If
        FileUpdated = False
        Exit Sub
    End Sub

    Private Function FormatSightForSave(ByVal SE As FavoriteLoc) As String
        Dim SaveStr As String = vbNullString
        Dim StrParm As String = ";"
        SaveStr = "No=" & SE.SightNum & StrParm &
            "Name=" & SE.SLName & StrParm &
            "DRLat=" & SE.DRLat & StrParm &
            "DRLong=" & SE.DRLong & StrParm &
            "ZD=" & SE.ZD & StrParm &
            "DST=" & SE.DST & StrParm &
            "HorType=" & SE.HorType & StrParm &
            "HorDist=" & SE.HorDist & StrParm &
            "HorDistType=" & SE.HorDistType & StrParm &
            "HE=" & SE.HE & StrParm &
            "ApprxBrg=" & SE.ApprxBrg & StrParm &
            "FromAZ=" & SE.FromAZ & StrParm &
            "ToAZ=" & SE.ToAZ & StrParm &
            "hsIEFmt=" & SE.hsIEFormat
        Return SaveStr
    End Function
    Private Sub ExecFilePrint()
        Dim i As Integer = 0
        Dim iCnt As Integer = 0
        Dim SE As FavoriteLoc = New FavoriteLoc
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder

        For i = 0 To UBound(FavoriteLocArray)
            SE = FavoriteLocArray(i)
            If SE.EntryStatus = "Active" Then
                iCnt += 1
            End If
        Next
        If iCnt = 0 Then
            ErrorMsgBox("No Data to Print - Add Data or Exit")
            FileUpdated = False
            Me.Show()
            Exit Sub
        End If
        Dim SLReportFname As String = SLOpenFName.Replace(".txt", "SLReport.txt")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.Title = "Save an Sight Log Text File"
        saveFileDialog1.InitialDirectory = SLDir
        saveFileDialog1.FileName = SLReportFname
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            SLOpenFName = saveFileDialog1.FileName
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog1.FileName, False)
            i = 0
            For i = 0 To UBound(FavoriteLocArray)
                SE = FavoriteLocArray(i)
                If SE.EntryStatus = "Active" Then
                    objWriter.WriteLine(FormatSightForPrint(SE))
                End If
            Next
            objWriter.Close()
            'objWriter.Dispose()
        End If
    End Sub
    Private Function FormatSightForPrint(ByVal SE As FavoriteLoc) As String
        Dim SaveStr As String = vbNullString
        Dim StrParm As String = vbTab
        Dim SepLine As String = "__________________________________________________________________________________________"
        SaveStr = "Name = " & SE.SLName & StrParm &
            "No = " & SE.SightNum & StrParm &
            "DST = " & SE.DST & StrParm &
            "ZD = " & SE.ZD & StrParm &
            "DR Lat = " & SE.DRLat & StrParm &
            "DR Long = " & SE.DRLong & vbNewLine &
            "ApprxBrg=" & SE.ApprxBrg & StrParm &
            "HE = " & SE.HE & StrParm &
            "Horizon = " & SE.HorType & StrParm &
            "Dip Short = " & SE.HorDist & " " & SE.HorDistType & vbNewLine &
            "From AZ =" & SE.FromAZ & vbNewLine &
            "To AZ = " & SE.ToAZ & vbNewLine &
            "hsIEFmt =" & SE.hsIEFormat & vbNewLine &
            "Remarks = " & SE.Remarks & vbNewLine & SepLine.ToString & vbNewLine
        Return SaveStr
        Exit Function
    End Function
    Private Sub FormatSightintoDG(ByVal SE As FavoriteLoc)
        Try
            ' The order of these Sight Array fields must be same as the display order of the grid view field order
            SEDataGrid.Rows.Add(SE.SightNum, SE.SLName, SE.DRLat, SE.DRLong, SE.ZD, SE.DST, SE.FromAZ, SE.ToAZ, SE.HorType, SE.HorDist & " " & SE.HorDistType, SE.HE, SE.ApprxBrg, SE.hsIEFormat)
            Exit Sub
        Catch Ex As Exception
            ErrorMsgBox("Error Adding DataGrid Record: " & Ex.Message)
        End Try
    End Sub
    Private Sub BuildDGFromSightArray()
        Dim i As Integer = 0
        'SEDataGrid.SelectAll()
        'SEDataGrid.ClearSelection()
        SEDataGrid.Rows.Clear()
        SEDataGrid.Refresh()
        For i = 0 To UBound(FavoriteLocArray)
            Dim SE As FavoriteLoc = FavoriteLocArray(i)
            If SE.EntryStatus = "Active" Then
                FormatSightintoDG(SE)
            End If
        Next
        SEDataGrid.ClearSelection()
        SEDataGrid.CurrentCell = Nothing
        SEDataGrid.Refresh()

        Exit Sub
    End Sub
    Private Sub ParseReadLine(ByVal rdline As String)
        EntryIndex = UBound(FavoriteLocArray)
        If ParseLineIntoSLArray(rdline) = True Then
            FavoriteLocArray(EntryIndex) = CommonSE
            FavoriteLocArray(EntryIndex).EntryStatus = "Active"
            EntryIndex += 1
            ReDim Preserve FavoriteLocArray(EntryIndex)
            FavoriteLocArray(EntryIndex).EntryStatus = "Empty"
            Exit Sub
        End If
        Exit Sub
    End Sub
    Private Function ParseLineIntoSLArray(ByVal rdline As String) As Boolean
        Dim SE As FavoriteLoc = New FavoriteLoc
        Dim ParseArray As String()
        ReDim ParseArray(22)
        ParseArray = Split(rdline, ";")
        Dim i As Integer = 0
        Dim Idx As Integer = 0
        Dim Param As String = vbNullString
        Dim DataSt As Integer = 0
        Dim DataEnd As Integer = 0
        For i = 0 To UBound(ParseArray)
            Idx = ParseArray(i).IndexOf("=")
            If Idx > 0 Then
                Param = ParseArray(i).Substring(0, Idx)
                DataSt = Idx + 1
                DataEnd = ParseArray(i).Length - (Idx + 1)
                Select Case Param
                    Case "Name"
                        SE.SLName = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "Num", "No"
                        SE.SightNum = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "DST"
                        SE.DST = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "DRLat"
                        SE.DRLat = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "DRLong"
                        SE.DRLong = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HE"
                        SE.HE = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HorType"
                        SE.HorType = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HorDist"
                        SE.HorDist = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HorDistType"
                        SE.HorDistType = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "ZD"
                        SE.ZD = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "ApprxBrg"
                        SE.ApprxBrg = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "FromAZ"
                        SE.FromAZ = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "ToAZ"
                        SE.ToAZ = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "hsIEFmt"
                        SE.hsIEFormat = ParseArray(i).Substring(DataSt, DataEnd)
                    Case Else
                        Dim Msg As DialogResult = System.Windows.Forms.MessageBox.Show("Invalid Record Read: " & rdline & vbNewLine & "Ignore & Continue = Yes; Stop = No", "Invalid Record",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
                        If Msg = DialogResult.Yes Then
                            ReadError = False
                            Return False
                            Exit Function
                        Else
                            ReadError = True
                            Return False
                            Exit Function
                        End If

                End Select
            End If
        Next
        CommonSE = SE
        Return True
        Exit Function
    End Function

    Private Sub PrepareSightArray()
        Dim FirstActive As Boolean = True

        Dim i As Integer = 0
        Dim LastActiveIdx As Integer = -1
        For i = 0 To UBound(FavoriteLocArray)
            If FavoriteLocArray(i).EntryStatus = "Active" Then
                FavoriteLocArray(i).SightNum = i.ToString
                If FirstActive = True Then
                    FirstActive = False
                ElseIf i > 0 And LastActiveIdx <> -1 Then
                    'Dim TempTS1 As TimeSpan = FavoriteLocArray(i).SightDateTime - FavoriteLocArray(LastActiveIdx).SightDateTime
                End If
                LastActiveIdx = i
            End If
EvalNextSE:
        Next
        FavoriteLocArray = FavoriteLocArray.OrderBy(Function(SE) SE.SightNum).ToArray
        Exit Sub
    End Sub
    Public Function CnvtHSStrtoDouble(ByVal HSStr) As Double
        Dim HSDbl As Double = 0
        Dim HSDegLoc As Integer = Strings.InStr(HSStr, Chr(176))
        Dim HSMinLoc As Integer = Strings.InStr(HSStr, "'")
        Dim HSSecLoc As Integer = Strings.InStr(HSStr, Chr(34))
        HSDbl = Convert.ToDouble(Strings.Mid(HSStr, 1, HSDegLoc - 1))
        HSDbl += (Convert.ToDouble(Strings.Mid(HSStr, HSDegLoc + 1, HSMinLoc - HSDegLoc - 1))) / 60
        If HSSecLoc <> 0 Then
            HSDbl += (Convert.ToDouble(Strings.Mid(HSStr, HSMinLoc + 1, HSSecLoc - HSMinLoc - 1))) / 3600
        End If
        Return HSDbl
    End Function

    Private Sub ExecAddNew()
        FileLoading = True
        EditError = False
        If EditScreenFields() = True Then
            ' build new sight entry into array from screen data
            BuildArrayFromscreen()
            ' now rebuild list box display of sight array
            PrepareSightArray()
            BuildDGFromSightArray()
            If CountActiveSEArray() > 0 Then
                btnSaveLog.Visible = True
                btnPrintDG.Visible = True
                btnSLReport.Visible = True
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
                btnShowSharedLoc.Visible = True
                btnUseLocation.Visible = True
                btnClearShared.Visible = True
            End If
            FileUpdated = True
            FileLoading = False

        Else
            EditError = True
        End If

        Exit Sub
    End Sub
    Private Sub BuildArrayFromscreen()
        Dim Idx As Integer = UBound(FavoriteLocArray)
        If FavoriteLocArray(Idx).EntryStatus = "Active" Then
            Idx += 1
            ReDim Preserve FavoriteLocArray(Idx)
        End If

        FavoriteLocArray(Idx).SightNum = Idx.ToString
        FavoriteLocArray(Idx).EntryStatus = "Active"
        FavoriteLocArray(Idx).SLName = txtName.Text
        If chkbxDST.Checked = True Then
            FavoriteLocArray(Idx).DST = "X"
        Else
            FavoriteLocArray(Idx).DST = ""
        End If

        Dim LatStr As String = txtLDeg.Text.ToString & Chr(176) & String.Format(txtLMin.Text.ToString, "00.0") & "'"
        If cboL.SelectedIndex = 0 Then
            LatStr = LatStr & g_LatN
        Else
            LatStr = LatStr & g_LatS
        End If
        FavoriteLocArray(Idx).DRLat = LatStr

        Dim LongStr As String = txtLoDeg.Text.ToString & Chr(176) & String.Format(txtLoMin.Text.ToString, "00.0") & "'"
        If cboLo.SelectedIndex = 0 Then
            LongStr = LongStr & g_LongW
        Else
            LongStr = LongStr & g_LongE
        End If
        FavoriteLocArray(Idx).DRLong = LongStr

        FavoriteLocArray(Idx).HE = txtHE.Text.ToString
        Select Case cboHEUnit.SelectedIndex
            Case 0
                FavoriteLocArray(Idx).HE &= " ft"
            Case 1
                FavoriteLocArray(Idx).HE &= " in"
            Case 2
                FavoriteLocArray(Idx).HE &= " m "
            Case 3
                FavoriteLocArray(Idx).HE &= " cm"
        End Select


        Select Case cbHorizon.SelectedIndex
            Case 0
                FavoriteLocArray(Idx).HorType = "Natural"
            Case 1
                FavoriteLocArray(Idx).HorType = "Dip Short"
            Case 2
                FavoriteLocArray(Idx).HorType = "Artificial"
            Case 3
                FavoriteLocArray(Idx).HorType = "Bubble"
            Case Else
                FavoriteLocArray(Idx).HorType = "Natural"
        End Select
        FavoriteLocArray(Idx).HorDist = txtHorDist.Text.ToString
        Select Case cbHorDistType.SelectedIndex
            Case 0
                FavoriteLocArray(Idx).HorDistType = "Feet"
            Case 1
                FavoriteLocArray(Idx).HorDistType = "Yards"
            Case 2
                FavoriteLocArray(Idx).HorDistType = "Meters"
            Case 3
                FavoriteLocArray(Idx).HorDistType = "Statute Mile"
            Case 4
                FavoriteLocArray(Idx).HorDistType = "Nautical Mile"
            Case Else
                FavoriteLocArray(Idx).HorDistType = "Feet"
        End Select
        FavoriteLocArray(Idx).ZD = cboZD.Items(cboZD.SelectedIndex).ToString

        FavoriteLocArray(Idx).ApprxBrg = cboApprxBrg.Items(cboApprxBrg.SelectedIndex).ToString
        FavoriteLocArray(Idx).FromAZ = txtFromAZ.Text.ToString
        FavoriteLocArray(Idx).ToAZ = txtToAZ.Text.ToString

        Select Case cboHSIEFmt.SelectedIndex
            Case 0
                FavoriteLocArray(Idx).hsIEFormat = "DM "
            Case 1
                FavoriteLocArray(Idx).hsIEFormat = "DMS"
            Case Else
                FavoriteLocArray(Idx).hsIEFormat = "UNK"
        End Select
        ' sort sight array by date/time field and assign sight num to each record
        PrepareSightArray()

        EntryIndex = UBound(FavoriteLocArray)
        EntryIndex += 1
        ReDim Preserve FavoriteLocArray(EntryIndex)
        FavoriteLocArray(EntryIndex).EntryStatus = "Empty"
        Exit Sub
    End Sub
    Private Function EditScreenFields() As Boolean
        If Not EditNameField() Then
            Return False
        End If
        If Not EditDSTField() Then
            Return False
        End If
        If Not EditDRLatField() Then
            Return False
        End If
        If Not EditDRLongField() Then
            Return False
        End If
        If Not EditHEField() Then
            Return False
        End If
        If Not EditDSField() Then
            Return False
        End If
        If Not EditFromAZField() Then
            Return False
        End If
        If Not EditToAZField() Then
            Return False
        End If
        If Not EditApprxBrg() Then
            Return False
        End If
        Return True
    End Function
    Private Function EditFromAZField() As Boolean
        Dim TestStr As String = txtFromAZ.Text.ToString
        If TestStr = vbNullString Or TestStr = "" Then
            ErrorMsgBox("From AZ is Required")
            Return False
        End If
        If Not IsNumeric(TestStr) Then
            ErrorMsgBox("From AZ must be numeric")
            Return False
        End If
        Dim TestInt As Integer = Convert.ToInt32(TestStr)
        If TestInt < 0 Or TestInt > 360 Then
            ErrorMsgBox("From AZ values must be between 0 and 360")
            Return False
        End If
        Return True
        Exit Function
    End Function
    Private Function EditToAZField() As Boolean
        Dim TestStr As String = txtToAZ.Text.ToString
        If TestStr = vbNullString Or TestStr = "" Then
            ErrorMsgBox("To AZ is Required")
            Return False
        End If
        If Not IsNumeric(TestStr) Then
            ErrorMsgBox("To AZ must be numeric")
            Return False
        End If
        Dim TestInt As Integer = Convert.ToInt32(TestStr)
        If TestInt < 0 Or TestInt > 360 Then
            ErrorMsgBox("To AZ values must be between 0 and 360")
            Return False
        End If
        Dim TestFromAZ As Integer = Convert.ToInt32(txtFromAZ.Text.ToString)
        If TestFromAZ >= TestInt Then
            ErrorMsgBox("To AZ  must be greater than From AZ")
            Return False
        End If
        Return True
        Exit Function
    End Function
    Private Function EditApprxBrg() As Boolean
        If cboApprxBrg.Items(cboApprxBrg.SelectedIndex).ToString = "None" Then
            ErrorMsgBox("Approximate Bearing Selection Required")
            Return False
        End If
        Return True
        Exit Function
    End Function

    Private Function EditNameField() As Boolean
        If txtName.Text = "" Then
            ErrorMsgBox("Missing Name - Enter A Name")
            Return False
        End If
        Return True
    End Function

    Private Function EditDSTField() As Boolean
        ' if the DST box is unchecked and the Date/Time select is DayLightSavingsTime = true then set DST to checked

        Return True
    End Function
    Private Function EditDRLatField() As Boolean
        If txtLDeg.Text = "" Then
            ErrorMsgBox("Missing DRLat Degrees - Required Field")
            Return False
        End If
        If txtLMin.Text = "" Then
            txtLMin.Text = "00"
        End If
        Try ' if either the Deg or Min field has data that will not convert to Int or Double, catch the exception and show error message
            Dim DRLatDeg As Integer = Convert.ToInt32(txtLDeg.Text.ToString)
            If DRLatDeg < 0 Or DRLatDeg > 89 Then
                ErrorMsgBox("Invalid DR Lat Degrees Entered - Must > 0 And < 90")
                Return False
            End If
            Dim DRLatMin As Double = Convert.ToDouble(txtLMin.Text.ToString.Trim)
            If DRLatMin < 0 Or DRLatMin > 59.9 Then
                ErrorMsgBox("Invalid DRLat Minutes Entered - Must >= 0 And < 60")
                Return False
            End If
            Return True
        Catch Ex As Exception
            ErrorMsgBox("Error in DRLat Degree Or Minutes Field.  Original error:  " & Ex.Message)
            Return False
        End Try
        Return True
        Exit Function
    End Function
    Private Function EditDRLongField() As Boolean
        If txtLoDeg.Text = "" Then
            ErrorMsgBox("Missing DRLong Degrees - Required Field")
            Return False
        End If
        If txtLoMin.Text = "" Then
            txtLoMin.Text = "00"
        End If
        Try
            Dim DRLongDeg As Integer = Convert.ToInt32(txtLoDeg.Text.ToString)
            If DRLongDeg < 0 Or DRLongDeg > 179 Then
                ErrorMsgBox("Invalid DR Long Degrees Entered - Must > 0 And < 90")
                Return False
            End If
            Dim DRLongMin As Double = Convert.ToDouble(txtLoMin.Text.ToString)
            If DRLongMin < 0 Or DRLongMin > 59.9 Then
                ErrorMsgBox("Invalid DRLong Minutes Entered - Must >= 0 And < 60")
                Return False
            End If
            'If cboZD.SelectedIndex = ZDInitIdx Then ' Is the ZD Type "Auto" - then calc the ZD based on longitude (ignore DST) and set the cboZD index to correct time zone value
            '    Dim DRZDLoEW As String = vbNullString
            '    If cboLo.SelectedIndex = 0 Then
            '        DRZDLoEW = g_LongW
            '    Else
            '        DRZDLoEW = g_LongE
            '    End If

            '    Dim DRZDCalc As Integer = Convert.ToInt32((DRLongDeg + (DRLongMin / 60.0)) / 15)

            '    Dim DRLongZDStr As String = String.Format(DRZDCalc.ToString, "00")
            '    If DRLongZDStr.Length = 1 Then ' failsafe edit so ZD is always two positions
            '        DRLongZDStr = "0" & DRLongZDStr
            '    End If
            '    If DRZDLoEW = g_LongW Then
            '        DRLongZDStr = "+" & DRLongZDStr
            '    Else
            '        DRLongZDStr = "-" & DRLongZDStr
            '    End If
            '    cboZD.SelectedIndex = GetZDIndex(DRLongZDStr)
            'End If

            Return True
        Catch Ex As Exception
            ErrorMsgBox("Error in DRLong Degree Or Minutes Fields.  Original error: " & Ex.Message)
            Return False
        End Try
        Return True
        Exit Function
    End Function
    Private Function EditHEField() As Boolean
        If txtHE.Text = "" Then
            txtHE.Text = "00"
        End If
        Try
            Dim HECalc As Double = Convert.ToDouble(txtHE.Text.ToString)
            If HECalc <= 0 Or HECalc > 99.9 Then
                ErrorMsgBox("Invalid HE Entered - Must >= 0 Or < 100 ")
                Return False
            End If
            Return True
        Catch Ex As Exception
            ErrorMsgBox("Error in HE Fields.  Original error: " & Ex.Message)
            Return False
        End Try
        Return True
        Exit Function
    End Function
    Private Function EditDSField() As Boolean
        If txtHorDist.Text = "" Then
            txtHorDist.Text = "00"
        End If
        Try
            Dim DSCalc As Double = Convert.ToDouble(txtHorDist.Text.ToString)
            If DSCalc < 0 Or DSCalc > 9999.9 Then
                ErrorMsgBox("Invalid Dip Short Distance - Must >= 0 Or < 100 ")
                Return False
            End If
            Return True
            If cbHorizon.SelectedIndex = 1 And DSCalc = 0 Then
                ErrorMsgBox("Missing Dip Short Distance Entered - Cannot be Zero  ")
                Return False
            End If
        Catch Ex As Exception
            ErrorMsgBox("Error in Dis Distance.  Original error: " & Ex.Message)
            Return False
        End Try
        Return True
        Exit Function
    End Function
    Private Function CountActiveSEArray() As Integer
        Dim ActiveCnt As Integer = 0
        Dim i As Integer = 0
        For i = 0 To UBound(FavoriteLocArray)
            If FavoriteLocArray(i).EntryStatus = "Active" Then
                ActiveCnt += 1
            End If
        Next
        Return ActiveCnt
    End Function

    Private Sub SEDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles SEDataGrid.SelectionChanged
        If FileLoading = True Then Exit Sub
        Dim n As Integer = SEDataGrid.CurrentRow.Index
        ' The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid

        txtName.Text = SEDataGrid.Rows(n).Cells(SLNameCell).Value
        txtSightNum.Text = SEDataGrid.Rows(n).Cells(SightNumCell).Value
        ' If there is a shared location and the sight number being selected is the shared location number then set check box to checked
        If SharedLocUse.EntryStatus = "Shared" And SharedLocUse.SightNum = SEDataGrid.Rows(n).Cells(SightNumCell).Value Then
            chkbxSharedLoc.Checked = True
        Else
            chkbxSharedLoc.Checked = False
        End If

        If SEDataGrid.Rows(n).Cells(DSTCell).Value.ToString = "X" Then
            chkbxDST.Checked = True
        Else
            chkbxDST.Checked = False
        End If

        Dim DegIdx As Integer = SEDataGrid.Rows(n).Cells(DRLatCell).Value.ToString.IndexOf(Chr(176).ToString)
        txtLDeg.Text = SEDataGrid.Rows(n).Cells(DRLatCell).Value.ToString.Substring(0, DegIdx)
        Dim MinIdx As Integer = SEDataGrid.Rows(n).Cells(DRLatCell).Value.ToString.IndexOf("'") - 1
        txtLMin.Text = SEDataGrid.Rows(n).Cells(DRLatCell).Value.ToString.Substring(DegIdx + 1, (MinIdx - DegIdx))
        MinIdx = SEDataGrid.Rows(n).Cells(DRLatCell).Value.ToString.IndexOf("'")
        If SEDataGrid.Rows(n).Cells(DRLatCell).Value.ToString.Substring(MinIdx + 1, 1) = g_LatN Then
            cboL.SelectedIndex = 0
        Else
            cboL.SelectedIndex = 1
        End If

        DegIdx = SEDataGrid.Rows(n).Cells(DRLongCell).Value.ToString.IndexOf(Chr(176).ToString)
        txtLoDeg.Text = SEDataGrid.Rows(n).Cells(DRLongCell).Value.ToString.Substring(0, DegIdx)
        MinIdx = SEDataGrid.Rows(n).Cells(DRLongCell).Value.ToString.IndexOf("'") - 1
        txtLoMin.Text = SEDataGrid.Rows(n).Cells(DRLongCell).Value.ToString.Substring(DegIdx + 1, (MinIdx - DegIdx))
        MinIdx = SEDataGrid.Rows(n).Cells(DRLongCell).Value.ToString.IndexOf("'")
        If SEDataGrid.Rows(n).Cells(DRLongCell).Value.ToString.Substring(MinIdx + 1, 1) = g_LongW Then
            cboLo.SelectedIndex = 0
        Else
            cboLo.SelectedIndex = 1
        End If

        Dim firstSpace As Integer = SEDataGrid.Rows(n).Cells(HECell).Value.ToString.IndexOf(g_StrSpace)
        Dim HEstr As String = String.Empty
        Dim HEUnit As String = String.Empty
        If firstSpace = -1 Then
            HEstr = SEDataGrid.Rows(n).Cells(HECell).Value.ToString
        Else
            HEstr = SEDataGrid.Rows(n).Cells(HECell).Value.ToString.Substring(0, firstSpace)
            HEUnit = SEDataGrid.Rows(n).Cells(HECell).Value.ToString.Substring(firstSpace)
        End If

        txtHE.Text = HEstr
        Select Case HEUnit
            Case " ft"
                cboHEUnit.SelectedIndex = 0
            Case " in"
                cboHEUnit.SelectedIndex = 1
            Case " m "
                cboHEUnit.SelectedIndex = 2
            Case " cm"
                cboHEUnit.SelectedIndex = 3
            Case Else
                cboHEUnit.SelectedIndex = 0
        End Select

        Dim HorType1 As String = SEDataGrid.Rows(n).Cells(HorTypeCell).Value.ToString.Substring(0, 1)
        Select Case HorType1
            Case g_LatN
                cbHorizon.SelectedIndex = 0
            Case "D"
                cbHorizon.SelectedIndex = 1
            Case "A"
                cbHorizon.SelectedIndex = 2
            Case "B"
                cbHorizon.SelectedIndex = 3
        End Select

        txtFromAZ.Text = SEDataGrid.Rows(n).Cells(FromAZCell).Value.ToString
        txtToAZ.Text = SEDataGrid.Rows(n).Cells(ToAZCell).Value.ToString

        Select Case SEDataGrid.Rows(n).Cells(hsIEFmtCell).Value.ToString
            Case "DMS"
                cboHSIEFmt.SelectedIndex = 1
            Case "DM"
                cboHSIEFmt.SelectedIndex = 0
            Case Else
                cboHSIEFmt.SelectedIndex = 0
        End Select

        Dim DSSpace As Integer = SEDataGrid.Rows(n).Cells(HorDistCell).Value.ToString.IndexOf(g_StrSpace)
        Dim DSLen As Integer = SEDataGrid.Rows(n).Cells(HorDistCell).Value.ToString.Length
        txtHorDist.Text = SEDataGrid.Rows(n).Cells(HorDistCell).Value.ToString.Substring(0, DSSpace)
        Dim HDType As String = SEDataGrid.Rows(n).Cells(HorDistCell).Value.ToString.Substring(DSSpace + 1, DSLen - (DSSpace + 1))
        Select Case HDType
            Case "Feet"
                cbHorDistType.SelectedIndex = 0
            Case "Yards"
                cbHorDistType.SelectedIndex = 1
            Case "Meters"
                cbHorDistType.SelectedIndex = 2
            Case "Statute Mile"
                cbHorDistType.SelectedIndex = 3
            Case "Nautical Mile"
                cbHorDistType.SelectedIndex = 4
            Case Else
                cbHorDistType.SelectedIndex = 0
        End Select

        Dim ZDIdx As Integer = GetZDIndex(SEDataGrid.Rows(n).Cells(ZDCell).Value.ToString())
        If ZDIdx <> 99 Then
            cboZD.SelectedIndex = ZDIdx
        Else
            cboZD.SelectedIndex = 0
        End If

        If IsNothing(SEDataGrid.Rows(n).Cells(ApprxBrgCell).Value) Then
            cboApprxBrg.SelectedIndex = 8
        Else
            Select Case SEDataGrid.Rows(n).Cells(ApprxBrgCell).Value.ToString
                Case g_LatN
                    cboApprxBrg.SelectedIndex = 0
                Case "NE"
                    cboApprxBrg.SelectedIndex = 1
                Case g_LongE
                    cboApprxBrg.SelectedIndex = 2
                Case "SE"
                    cboApprxBrg.SelectedIndex = 3
                Case g_LatS
                    cboApprxBrg.SelectedIndex = 4
                Case "SW"
                    cboApprxBrg.SelectedIndex = 5
                Case g_LongW
                    cboApprxBrg.SelectedIndex = 6
                Case "NW"
                    cboApprxBrg.SelectedIndex = 7
                Case "None"
                    cboApprxBrg.SelectedIndex = 8
                Case Else
                    cboApprxBrg.SelectedIndex = 8
            End Select
        End If

        btnClearFields.Visible = True
        btnUpdateExisting.Visible = True
        btnDeleteSight.Visible = True
        btnShowSharedLoc.Visible = True
        btnUseLocation.Visible = True
        btnClearShared.Visible = True
        Exit Sub
    End Sub

    Private Function GetZDIndex(ByVal ZDFldin As String) As Integer
        Dim i As Integer = 0
        For i = 0 To UBound(ZDArray)
            If ZDArray(i).ZDField = ZDFldin Then
                Return ZDArray(i).ZDIndex
                Exit Function
            End If
        Next
        Return 99
        Exit Function
    End Function
    Private Function GetZDHour(ByVal ZDFldin As String) As Integer
        Dim i As Integer = 0
        For i = 0 To UBound(ZDArray)
            If ZDArray(i).ZDField = ZDFldin Then
                Return ZDArray(i).ZDHhours
                Exit Function
            End If
        Next
        Return 99
        Exit Function
    End Function
    Private Function GetZDMin(ByVal ZDFldin As String) As Integer
        Dim i As Integer = 0
        For i = 0 To UBound(ZDArray)
            If ZDArray(i).ZDField = ZDFldin Then
                Return ZDArray(i).ZDMin
                Exit Function
            End If
        Next
        Return 99
        Exit Function
    End Function

    Private Sub btnPrintDG_Click(sender As Object, e As EventArgs) Handles btnPrintDG.Click
        'Dim PrintDialog As PrintDialog = New PrintDialog()
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.UseEXDialog = True
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.DocumentName = "Sight Log: " & SLFName
            PrintDocument1.Print()
        End If
        Exit Sub
    End Sub

    Private Sub btnSLReport_Click(sender As Object, e As EventArgs) Handles btnSLReport.Click
        ExecFilePrint()
        Exit Sub
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DocumentName = SLOpenFName.ToString

        pages = New Dictionary(Of Integer, pageDetails)
        ' transpose for landscape printing
        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40 + lblName.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = SEDataGrid.RowHeadersWidth

        For c As Integer = 0 To SEDataGrid.Columns.Count - 1

            If columnSum + SEDataGrid.Columns(c).Width < maxWidth Then
                columnSum += SEDataGrid.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = SEDataGrid.RowHeadersWidth + SEDataGrid.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = SEDataGrid.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If

        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = SEDataGrid.ColumnHeadersHeight

        For r As Integer = 0 To SEDataGrid.Rows.Count - 1
            If rowSum + SEDataGrid.Rows(r).Height < maxHeight Then
                rowSum += SEDataGrid.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = SEDataGrid.ColumnHeadersHeight + SEDataGrid.Rows(r).Height
                rowCounter = 1
            End If
            If r = SEDataGrid.Rows.Count - 1 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), lblName.Height)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(lblName.Text, lblName.Font, Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, SEDataGrid.RowHeadersWidth, SEDataGrid.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += SEDataGrid.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, SEDataGrid.RowHeadersWidth, SEDataGrid.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(SEDataGrid.Rows(r).HeaderCell.Value, SEDataGrid.Font, Brushes.Black, cell, sf)
                startY += SEDataGrid.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, SEDataGrid.Columns(c).Width, SEDataGrid.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(SEDataGrid.Columns(c).HeaderCell.Value, SEDataGrid.Font, Brushes.Black, cell, sf)
                startX += SEDataGrid.Columns(c).Width
            Next

            startY = rect.Bottom + SEDataGrid.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 50 + SEDataGrid.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, SEDataGrid.Columns(c).Width, SEDataGrid.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(SEDataGrid(c, r).Value, SEDataGrid.Font, Brushes.Black, cell, sf)
                    startX += SEDataGrid.Columns(c).Width
                Next
                startY += SEDataGrid.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub

    Private Sub cboHSIEFmt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHSIEFmt.SelectedIndexChanged
        Select Case cboHSIEFmt.SelectedIndex
            Case 0
            Case 1
        End Select
        Me.Refresh()

    End Sub

    Private Sub cbHorizon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHorizon.SelectedIndexChanged
        Select Case cbHorizon.SelectedIndex
            Case 0, 2, 3
                lblDistance.Visible = False
                txtHorDist.Visible = False
                cbHorDistType.Visible = False
                txtHorDist.Clear()
            Case 1
                lblDistance.Visible = True
                txtHorDist.Visible = True
                cbHorDistType.Visible = True
                txtHorDist.Clear()
            Case Else
                lblDistance.Visible = False
                txtHorDist.Visible = False
                cbHorDistType.Visible = False
                txtHorDist.Clear()
        End Select
        Me.Refresh()
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


    Private Sub CheckBoxAutoReduce_CheckedChanged(sender As Object, e As EventArgs)
        ' handler for change to automatically reduce all error free new or changed sights
        Exit Sub
    End Sub

    Private Sub btnUseLocation_Click(sender As Object, e As EventArgs) Handles btnUseLocation.Click
        chkbxSharedLoc.Checked = True
        Dim LatStr As String = txtLDeg.Text.ToString & Chr(176) & String.Format(txtLMin.Text.ToString, "00.0") & "'"
        If cboL.SelectedIndex = 0 Then
            LatStr = LatStr & g_LatN
        Else
            LatStr = LatStr & g_LatS
        End If

        Dim LongStr As String = txtLoDeg.Text.ToString & Chr(176) & String.Format(txtLoMin.Text.ToString, "00.0") & "'"
        If cboLo.SelectedIndex = 0 Then
            LongStr = LongStr & g_LongW
        Else
            LongStr = LongStr & g_LongE
        End If

        With SharedLocUse
            .EntryStatus = "Shared"
            .SightNum = txtSightNum.Text
            .SLName = txtName.Text
            .DRLat = LatStr
            .DRLatDeg = Convert.ToInt32(txtLDeg.Text)
            .DRLatMin = Convert.ToDouble(txtLMin.Text)
            .DRLatNS = Strings.Right(LatStr, 1)
            .DRLong = LongStr
            .DRLongDeg = Convert.ToInt32(txtLoDeg.Text)
            .DRLongMin = Convert.ToDouble(txtLoMin.Text)
            .DRLongEW = Strings.Right(LongStr, 1)
            .ZD = cboZD.Items(cboZD.SelectedIndex).ToString
            .ZDhr = GetZDHour(.ZD).ToString
            .ZDmin = GetZDMin(.ZD).ToString
            If MasterDSTChecked = True Then
                'If chkbxDST.Checked = True Then
                .DST = "X"
            Else
                .DST = vbNullString
            End If

            .FromAZ = Convert.ToInt32(txtFromAZ.Text.ToString)
            .ToAZ = Convert.ToInt32(txtToAZ.Text.ToString)
            .HorType = cbHorizon.Items(cbHorizon.SelectedIndex).ToString
            .HorDist = Convert.ToDouble(txtHorDist.Text)
            .HorDistType = cbHorDistType.Items(cbHorDistType.SelectedIndex).ToString
            .HE = Convert.ToDouble(txtHE.Text)
            .HEType = cboHEUnit.Items(cboHEUnit.SelectedIndex).ToString
            .ApprxBrg = cboApprxBrg.Items(cboApprxBrg.SelectedIndex).ToString
            .hsIEFormat = cboHSIEFmt.Items(cboHSIEFmt.SelectedIndex).ToString
            .HorDistIndex = cbHorDistType.SelectedIndex
            .HETypeIndex = cboHEUnit.SelectedIndex
            .ZDAutoSelect = AutoZDSelected
        End With
        ' update the common working area stored in the Menu / MainMenu 
        With SharedLocUse
            ' Now check if SRF / FormSRF is already open and being used
            If Application.OpenForms().OfType(Of FormSRF).Any Then
                If CommonYesNoMsgBox("The Sight Reduction Form is already open - Confirm you want to push shared location data to it") = True Then
                    FormSRF.txtLDeg.Text = .DRLatDeg.ToString
                    FormSRF.txtLMin.Text = .DRLatMin.ToString
                    If .DRLatNS = g_LatN Then
                        FormSRF.cboL.SelectedIndex = 0
                    Else
                        FormSRF.cboL.SelectedIndex = 1
                    End If
                    FormSRF.txtLoDeg.Text = .DRLongDeg.ToString
                    FormSRF.txtLoMin.Text = .DRLongMin.ToString
                    If .DRLongEW = g_LongW Then
                        FormSRF.cboLo.SelectedIndex = 0
                    Else
                        FormSRF.cboLo.SelectedIndex = 1
                    End If
                    Select Case .HorType
                        Case "Dip Short"
                            FormSRF.optHorizonDipShort.Checked = True
                            FormSRF.txtDsDist.Text = .HorDist.ToString
                            FormSRF.cboDsUnit.SelectedIndex = .HorDistIndex
                        Case "Artificial"
                            FormSRF.optHorizonArtificial.Checked = True
                        Case "Natural"
                            FormSRF.optHorizonNatural.Checked = True
                        Case "Bubble"
                            FormSRF.optHorizonBubble.Checked = True
                        Case Else
                            FormSRF.optHorizonNatural.Checked = True
                    End Select


                    If .DST = "X" Then
                        FormSRF.chkDST.Checked = True
                    Else
                        FormSRF.chkDST.Checked = False
                    End If

                    FormSRF.txtHE.Text = .HE.ToString
                    FormSRF.cboHE.SelectedIndex = .HETypeIndex

                    If .ZDAutoSelect = True Then
                        FormSRF.optZDAuto.Checked = True
                    Else
                        FormSRF.optZDManual.Checked = True
                        FormSRF.txtZDh.Text = .ZDhr.ToString
                        If .ZDmin = "0" Then
                            FormSRF.cboZDm.SelectedIndex = 0
                            FormSRF.cboZDm.Visible = False
                        Else
                            FormSRF.cboZDm.Visible = True
                            If .ZDmin = "30" Then
                                FormSRF.cboZDm.SelectedIndex = 1
                            ElseIf .ZDmin = "45" Then
                                FormSRF.cboZDm.SelectedIndex = 2
                            Else
                                FormSRF.cboZDm.SelectedIndex = 0
                            End If
                        End If
                    End If
                End If
            End If
            ' Now check if Plan1 / FormSightPlan is already open and in use
            If Application.OpenForms().OfType(Of FormSightPlan).Any Then
                If CommonYesNoMsgBox("The Sight Planning Form is already open - Confirm you want to push shared location data to it") = True Then
                    FormSightPlan.txtLDeg.Text = .DRLatDeg.ToString
                    FormSightPlan.txtLMin.Text = .DRLatMin.ToString
                    If .DRLatNS = g_LatN Then
                        FormSightPlan.cboL.SelectedIndex = 0
                    Else
                        FormSightPlan.cboL.SelectedIndex = 1
                    End If
                    FormSightPlan.txtLoDeg.Text = .DRLongDeg.ToString
                    FormSightPlan.txtLoMin.Text = .DRLongMin.ToString
                    If .DRLongEW = g_LongW Then
                        FormSightPlan.cboLo.SelectedIndex = 0
                    Else
                        FormSightPlan.cboLo.SelectedIndex = 1
                    End If
                    If .FromAZ <> 0 Then
                        FormSightPlan.txtLowAz.Text = .FromAZ.ToString
                        FormSightPlan.txtLowAz.Visible = True
                    End If
                    If .ToAZ <> 0 Then
                        FormSightPlan.txtHighAz.Text = .ToAZ.ToString
                        FormSightPlan.txtHighAz.Visible = True
                    End If


                    If .ZDAutoSelect = True Then
                        FormSightPlan.optZDAuto.Checked = True
                    Else
                        FormSightPlan.optZDManual.Checked = True
                        FormSightPlan.txtZDh.Text = .ZDhr.ToString
                        If .ZDmin = "0" Then
                            FormSightPlan.cboZDm.SelectedIndex = 0
                            FormSightPlan.cboZDm.Visible = False
                        Else
                            FormSightPlan.cboZDm.Visible = True
                            If .ZDmin = "30" Then
                                FormSightPlan.cboZDm.SelectedIndex = 1
                            ElseIf .ZDmin = "45" Then
                                FormSightPlan.cboZDm.SelectedIndex = 2
                            Else
                                FormSightPlan.cboZDm.SelectedIndex = 0
                            End If
                        End If
                    End If
                End If
            End If
            ' Now check if NoonSight / FormNoonSight is already open and in use
            If Application.OpenForms().OfType(Of FormNoonSight).Any Then
                If CommonYesNoMsgBox("The Noonsight Form is already open - Confirm you want to push shared location data to it") = True Then
                    FormNoonSight.optDRL.Checked = True
                    FormNoonSight.txtDRLDeg.Text = .DRLatDeg.ToString
                    FormNoonSight.txtDRLMin.Text = .DRLatMin.ToString
                    If .DRLatNS = g_LatN Then
                        FormNoonSight.cboDRL.SelectedIndex = 0
                    Else
                        FormNoonSight.cboDRL.SelectedIndex = 1
                    End If

                    FormNoonSight.txtLoDeg.Text = .DRLongDeg.ToString
                    FormNoonSight.txtLoMin.Text = .DRLongMin.ToString
                    If .DRLongEW = g_LongW Then
                        FormNoonSight.cboLo.SelectedIndex = 0
                    Else
                        FormNoonSight.cboLo.SelectedIndex = 1
                    End If

                    Select Case .HorType
                        Case "Dip Short"
                            FormNoonSight.optHorizonDipShort.Checked = True
                            FormNoonSight.txtDsDist.Text = .HorDist.ToString
                            FormNoonSight.cboDsUnit.SelectedIndex = .HorDistIndex
                        Case "Artificial"
                            FormNoonSight.optHorizonArtificial.Checked = True
                        Case "Natural"
                            FormNoonSight.optHorizonNatural.Checked = True
                        Case "Bubble"
                            FormNoonSight.optHorizonBubble.Checked = True
                        Case Else
                            FormNoonSight.optHorizonNatural.Checked = True
                    End Select
                    FormNoonSight.txtHE.Text = .HE.ToString
                    FormNoonSight.cboHE.SelectedIndex = .HETypeIndex

                    If .ZDAutoSelect = True Then
                        FormNoonSight.optZDAuto.Checked = True
                    Else
                        FormNoonSight.optZDManual.Checked = True
                        FormNoonSight.txtZDh.Text = .ZDhr.ToString
                        If .ZDmin = "0" Then
                            FormNoonSight.cboZDm.SelectedIndex = 0
                            FormNoonSight.cboZDm.Visible = False
                        Else
                            FormNoonSight.cboZDm.Visible = True
                            If .ZDmin = "30" Then
                                FormNoonSight.cboZDm.SelectedIndex = 1
                            ElseIf .ZDmin = "45" Then
                                FormNoonSight.cboZDm.SelectedIndex = 2
                            Else
                                FormNoonSight.cboZDm.SelectedIndex = 0
                            End If
                        End If
                    End If

                End If
            End If
            ' Now check if SRMethods / FormAltSR is already open and in use
            If Application.OpenForms().OfType(Of FormAltSR).Any Then
                If CommonYesNoMsgBox("The SR Alt Methods Form is already open - Confirm you want to push shared location data to it") = True Then
                    FormAltSR.txtLDeg.Text = .DRLatDeg.ToString
                    FormAltSR.txtLMin.Text = .DRLatDeg.ToString
                    If .DRLatNS = g_LatN Then
                        FormAltSR.cboL.SelectedIndex = 0
                    Else
                        FormAltSR.cboL.SelectedIndex = 1
                    End If
                    FormAltSR.txtLoDeg.Text = .DRLongDeg.ToString
                    FormAltSR.txtLoMin.Text = .DRLongMin.ToString
                    If .DRLongEW = g_LongW Then
                        FormAltSR.cboLo.SelectedIndex = 0
                    Else
                        FormAltSR.cboLo.SelectedIndex = 1
                    End If
                End If
            End If

        End With
        Exit Sub
    End Sub

    Private Sub btnClearShared_Click(sender As Object, e As EventArgs) Handles btnClearShared.Click
        ExecInitSharedLoc()

        Exit Sub
    End Sub
    Private Sub ExecInitSharedLoc()
        chkbxSharedLoc.Checked = False
        With SharedLocUse
            .EntryStatus = "Empty"
            .SightNum = vbNullString
            .SLName = vbNullString
            .DRLat = vbNullString
            .DRLatDeg = 0
            .DRLatMin = 0
            .DRLong = vbNullString
            .DRLongDeg = 0
            .DRLongMin = 0
            .ZD = vbNullString
            .ZDhr = vbNullString
            .ZDmin = vbNullString
            .DST = vbNullString
            .FromAZ = vbNullString
            .ToAZ = vbNullString
            .HorType = vbNullString
            .HorDist = 0
            .HorDistType = vbNullString
            .HE = 0
            .HEType = vbNullString
            .ApprxBrg = vbNullString
            .hsIEFormat = vbNullString
        End With
        Exit Sub
    End Sub

    Private Sub btnShowSharedLoc_Click(sender As Object, e As EventArgs) Handles btnShowSharedLoc.Click
        If SharedLocUse.EntryStatus = "Empty" Then
            ErrorMsgBox("There is no Shared Location to display")
            Exit Sub
        End If
        System.Windows.Forms.MessageBox.Show("Shared Location: Number = " & SharedLocUse.SightNum.ToString & " Name = " & SharedLocUse.SLName.ToString, "Shared Location Num and Name",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Information,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
    Public Function CommonYesNoMsgBox(ByVal MsgString As String) As Boolean
        If System.Windows.Forms.MessageBox.Show(MsgString, "Confirm Pushing Shared Location Data",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
            Return True
            Exit Function
        End If
        Return False
        Exit Function
    End Function

    Private Sub chkbxDST_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxDST.CheckedChanged
        If chkbxDST.Checked = True Then
            MasterDSTChecked = True
        Else
            MasterDSTChecked = False
        End If
    End Sub

    Private Sub cboZD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZD.SelectedIndexChanged
        If cboZD.SelectedIndex = ZDInitIdx Then ' this is auto ZD calc
            AutoZDSelected = True
        Else
            AutoZDSelected = False
        End If
    End Sub
End Class