Imports System.IO

Public Class SightLog

    Public Structure SightEntry
        Public EntryStatus As String
        Public SLName As String
        Public SLSquadron As String
        Public SightNum As String
        Public SightDateTime As Date
        Public DST As String
        Public WE As String 'format MMSS, - = Fast and + = Slow
        Public WEType As String ' F - Fast or S - Slow
        Public DRLat As String 'format NN*NN.N'N or S where * = CHR(176) degree
        Public DRLong As String ' format NNN*NN.N'E or W where * = CHR(176) degree 
        Public LLoBy As String ' DR or GPS or KP for Known Position to match current Nav class 
        Public HS As String 'NN*NN.N'
        Public IC As String 'NN.N + is off the arc / - is on the arc
        Public ICType As String ' ON = on the arc, OFF = Off the arc
        Public HE As String ' N.N feet
        Public HorType As String ' N - Natural, D - Dip, or A - Artificial 
        Public BodyName As String
        Public BodyLimb As String 'U - upper, L - lower , C - central
        Public HorDist As String
        Public HorDistType As String ' F - Feet, Y - Yards, M - Statute Mile, N - Nautical Mile
        Public Intercept As String
        Public Zn As String
        Public ZD As String
        Public Remarks As String
        Public EP As String
        Public ApprxBrg As String
        Public HSDouble As Double
        Public WTDiff As String
        Public HSDiff As String
        Public HSWTRate As String
        Public SRGHA As String
        Public SRDec As String
        Public SRHo As String
        Public UserInfo As String
    End Structure
    Public Structure ZDParms
        Public ZDField As String
        Public ZDIndex As Integer
        Public ZDHhours As Integer
        Public ZDMin As Integer

        Public Sub New(strIn As String, intIn As Integer, HourIn As Integer, MinIn As Integer)
            Me.New()
            Me.ZDField = strIn
            Me.ZDIndex = intIn
            Me.ZDHhours = HourIn
            Me.ZDMin = MinIn
        End Sub
    End Structure
    Public SaveCLSFileName As String
    Public SRFa As Double = 0
    Public SRFZn As Double = 0
    Public SRFSightUpd As Boolean = False
    Private SightLogArray As SightEntry()
    Private SLFName As String = vbNullString
    Private SLDir As String = "\SightLogs"
    'Private GraphDir As String = "./Graphics/"
    'Private SLDefName As String = "SightLog" & Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
    Private SLOpenFName As String = vbNullString

    Private EntryIndex As Integer = 0
    Private ReadOnly BNameArray As String() = {"Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard",
"Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin",
"Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon",
"Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi"}

    Private FileUpdated As Boolean = False
    Private CommonSE As SightEntry
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
    Public SRFFormZN As Double
    Public SRFFormIntercept As Double
    Public SRFFormEP As String
    Public SRFFormGHADeg As Double
    Public SRFFormGHAMin As Double
    Public SRFFormDecDeg As Double
    Public SRFFormDecMin As Double
    Public SRFFormDecNS As String
    Public SRFFormHoDeg As Double
    Public SRFFormHoMin As Double
    Public FormSRFLoaded As Boolean = False  'SRF form
    Public FormNoonSightLoaded As Boolean = False  'Noon Sight Form
    Public FormAltSRLoaded As Boolean = False  'Alt SR Method form
    ' these are the indexes for the data grid view cells and they must ALWAY be kept in sync with the datagridview order of cells.
    Public SightNumCell As Integer = 0
    Public SightDateTimeCell As Integer = 1
    Public BodyNameCell As Integer = 2
    Public BodyLimbCell As Integer = 3
    Public DSTCell As Integer = 4
    Public WECell As Integer = 5
    Public WETypeCell As Integer = 6
    Public ZDCell As Integer = 7
    Public HSCell As Integer = 8
    Public HorTypeCell As Integer = 9
    Public HorDistCell As Integer = 10
    Public ApprxBrgCell As Integer = 11

    Public HECell As Integer = 12
    Public ICCell As Integer = 13
    Public ICTypeCell As Integer = 14
    Public DRLatCell As Integer = 15
    Public DRLongCell As Integer = 16
    Public LLoByCell As Integer = 17
    Public InterceptCell As Integer = 18
    Public ZnCell As Integer = 19
    Public SLEP As Integer = 20
    Public SLNameCell As Integer = 21
    Public SLSquadron As Integer = 22
    Public SLWTDiff As Integer = 23
    Public SLhsdiff As Integer = 24
    Public SLhsWT As Integer = 25
    Public RemarksCell As Integer = 26
    Public SLGHACell As Integer = 27
    Public SLDecCell As Integer = 28
    Public SLHoCell As Integer = 29
    Public UserInfoCell As Integer = 30
    'Public HorDistTypeCell As Integer = 25
    Public HdrStr As String() = {"Num", "DateTime", "Body", "Limb", "DST",
        "WE", "WEtype", "ZD", "Hs", "HorType", "HorDist", "Apprx Brg", "HEye", "IC",
        "ICType", "Lat", "Long", "LLoBy", "Int", "Az", "SLEP", "Name", "Squadron",
        "Remarks"}
    Public NullStr As String() = {vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString, vbNullString, vbNullString, vbNullString,
        vbNullString, vbNullString}
    Public EditError As Boolean = False
    Public MasterDST As Boolean = False
    Public PlotOut As CLSForm.PlotEntry
    Public PlotIntercept As String
    Public PlotAzimuth As String

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

    Private Sub LoadZDDropDown()
        cboZD.Items.Clear()
        Dim lim As Integer = 0
        For lim = 0 To UBound(ZDArray)
            cboZD.Items.Add(ZDArray(lim).ZDField)
        Next
        cboZD.SelectedIndex = ZDInitIdx
        Exit Sub
    End Sub
    Public Sub QuickExit()
        ExitSRFandAltSR()
        If FileUpdated = True Then
            ExecFileSave()
        End If
        Me.Close()
        Exit Sub
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ExitSRFandAltSR()

        'Dim DYesNo As DialogResult
        If FileUpdated = True Then

            If System.Windows.Forms.MessageBox.Show("Save Current File?  Yes / No ?", "Save File?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.ServiceNotification) = DialogResult.Yes Then
                ExecFileSave()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
        Me.Close()
        Exit Sub
    End Sub

    Private Sub SightLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        LoadZDDropDown()
        ExecInitScreen()
        SEDataGrid.Rows.Clear()
        SEDataGrid.ClearSelection()
        SEDataGrid.CurrentCell = Nothing
        SEDataGrid.Refresh()
        cboHSIEFmt.SelectedIndex = 0
        cboLLoBy.SelectedIndex = 0
        Exit Sub
    End Sub
    Private Sub ExecInitScreen()
        Dim CurrDir As String = My.Computer.FileSystem.CurrentDirectory()
        FileUpdated = False
        SLDir = CurrDir & "\SightLogs"
        ' check if Sight Log Dir for files exists - if not then create dir - this protects the very first time program is run
        If My.Computer.FileSystem.DirectoryExists(SLDir) = False Then
            My.Computer.FileSystem.CreateDirectory(SLDir)
        End If

        ReDim SightLogArray(2)
        SightLogArray(0).EntryStatus = "Deleted"
        SightLogArray(0).SightDateTime = Now().AddDays(365)
        SightLogArray(1).EntryStatus = "Empty"
        SightLogArray(1).SightDateTime = Now().AddDays(365)

        ExitSRFandAltSR()

        btnUpdateExisting.Visible = False
        btnDeleteSight.Visible = False
        btnSightReduce.Visible = False
        btnAltSR.Visible = False
        btnPlanSight.Visible = False
        btnSaveLog.Visible = False
        btnPrintDG.Visible = False
        btnSLReport.Visible = False
        btnSaveLogAsTxt.Visible = False
        'btnNewLog.Visible = False
        ExecClearScreenFields()
        SEDataGrid.Rows.Clear()
        SEDataGrid.ClearSelection()
        SEDataGrid.CurrentCell = Nothing
        SEDataGrid.Refresh()
        Exit Sub
    End Sub
    Private Sub ExecClearScreenFields()

        SightDateTime.Value = DateTime.Now() 'ToString("MM/dd/yyyy HH:mm:ss")
        txtWE.Clear()
        cboLo.SelectedIndex = 0 'W
        cboL.SelectedIndex = 0 'N
        cboZD.SelectedIndex = ZDInitIdx
        cbWEType.SelectedIndex = 0
        cboBody.SelectedIndex = 0
        cbLimb.SelectedIndex = 0
        cbHorizon.SelectedIndex = 0
        cbHorDistType.SelectedIndex = 0
        cbIEType.SelectedIndex = 0
        cboHEUnit.SelectedIndex = 0
        cboApprxBrg.SelectedIndex = 8 ' None
        chkbxDST.Checked = False
        txtSightNum.Clear()
        txtLDeg.Clear()
        txtLMin.Clear()
        txtLoDeg.Clear()
        txtLoMin.Clear()
        txtIEDeg.Clear()
        txtIE.Clear()
        txtIESec.Clear()

        txtHSDeg.Clear()
        txtHSMin.Clear()
        txtHSDeg.Clear()

        txtWE.Clear()
        txtHE.Clear()
        txtIntZn.Clear()
        txtSRFEP.Clear()
        txtRemarks.Clear()
        txtHorDist.Clear()
        txtSRFEP.Clear()
        txtSRGHA.Clear()
        txtSRDec.Clear()
        txtSRHo.Clear()
        txtUserInfo.Clear()

        InitSRFFormFields()
        SRFFormEP = vbNullString
        txtWE.Text = "0000"
        btnAddNew.Visible = True
        btnSightReduce.Visible = False
        btnPlanSight.Visible = False
        btnUpdateExisting.Visible = False
        btnClearFields.Visible = False
        btnDeleteSight.Visible = False
        btnAltSR.Visible = False
        Exit Sub
    End Sub

    Private Sub btnOpenLog_Click(sender As Object, e As EventArgs) Handles btnOpenLog.Click
        If FileUpdated = True Then

            If System.Windows.Forms.MessageBox.Show("Save Current File?  Yes / No ?", "Save File?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.ServiceNotification) = DialogResult.Yes Then
                ExecFileSave()
            Else
                ' nothing to do
            End If
        Else
            ' nothing to do
        End If

        Dim myStream As System.IO.StreamReader = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        Dim rdline As String = vbNullString
        Dim CurrDir As String = System.IO.Directory.GetCurrentDirectory()

        openFileDialog1.Reset()

        openFileDialog1.InitialDirectory = CurrDir & "\SightLogs"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.Title = "Open Sight Log Text File"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.AutoUpgradeEnabled = True

        ExecClearScreenFields()
        ReDim SightLogArray(1)
        SightLogArray(0).EntryStatus = "Empty"
        SightLogArray(0).SightDateTime = Now().AddDays(365)

        ExitSRFandAltSR()

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
                    SLFName = SLOpenFName
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
                myStream.Dispose()
                openFileDialog1.Dispose()
                SEDataGrid.ClearSelection()
                SEDataGrid.CurrentCell = Nothing
                SEDataGrid.Refresh()
                FileLoading = False
                btnPrintDG.Visible = True
                btnSLReport.Visible = True
                btnSaveLogAsTxt.Visible = True
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
        ExitSRFandAltSR()
        ExecFileSave()
        FileUpdated = False
        Exit Sub
    End Sub

    Private Sub InitSRFFormFields()
        SRFFormIntercept = 0
        SRFFormZN = 0
        SRFFormGHADeg = 0
        SRFFormGHAMin = 0
        SRFFormDecDeg = 0
        SRFFormDecMin = 0
        SRFFormHoDeg = 0
        SRFFormHoMin = 0
        'SRFFormEP = vbNullString
        SRFFormGHADeg = 0
        SRFFormGHAMin = 0
        SRFFormDecDeg = 0
        SRFFormDecMin = 0
        SRFFormHoDeg = 0
        SRFFormHoMin = 0

        Exit Sub
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        InitSRFFormFields()
        txtIntZn.Clear()
        txtSRFEP.Clear()
        SRFFormEP = vbNullString

        'ExitSRFandAltSR()

        EditError = False
        ExecAddNew()
        If EditError = False Then
            If chkClearFields.Checked = True Then
                ExecClearScreenFields()
            End If
        End If
        Exit Sub
    End Sub
    Private Sub btnSightReduce_Click(sender As Object, e As EventArgs) Handles btnSightReduce.Click
        If EditScreenFields() = True Then
            EditError = False
            PerformSRF()
            ExecUpdateExisting()
            If chkClearFields.Checked = True Then
                ExecClearScreenFields()
            End If
        Else
            EditError = True
        End If

        Exit Sub
    End Sub

    Public Sub PerformAltSR()
        If CheckOpenWinForms("FormAltSR") = True Then
            FormAltSRLoaded = True
            FormAltSR.cmdClear.PerformClick()
            FormAltSR.Show()
            FormAltSR.BringToFront()
            FormAltSR.SetDesktopLocation(5, 5) '
            FormAltSR.InvokedbySightLog = True
        Else
            FormAltSRLoaded = False
            FormAltSR.Show()
            FormAltSR.SetDesktopLocation(5, 5) '
            FormAltSR.InvokedbySightLog = True
            FormAltSRLoaded = True
        End If

        Dim IndexofDeg As Integer = txtSRGHA.Text.IndexOf(Chr(176))
        Dim IndexofMin As Integer = txtSRGHA.Text.IndexOf("'")
        Dim ghadeg As String = txtSRGHA.Text.Substring(0, IndexofDeg)
        Dim ghamin As String = txtSRGHA.Text.Substring(IndexofDeg + 1, IndexofMin - (IndexofDeg + 1)).Trim
        FormAltSR.txtGHADeg.Text = ghadeg
        FormAltSR.txtGHAMin.Text = ghamin

        FormAltSR.cboBody.SelectedIndex = cboBody.SelectedIndex
        FormAltSR.cbLimb.SelectedIndex = cbLimb.SelectedIndex
        FormAltSR.cboLLoBy.SelectedIndex = cboLLoBy.SelectedIndex
        FormAltSR.grpSLInfo.Visible = True

        IndexofDeg = txtSRDec.Text.IndexOf(Chr(176))
        IndexofMin = txtSRDec.Text.IndexOf("'")
        Dim decdeg As String = txtSRDec.Text.Substring(0, IndexofDeg)
        Dim decmin As String = txtSRDec.Text.Substring(IndexofDeg + 1, IndexofMin - (IndexofDeg + 1))
        Dim decNS As String = txtSRDec.Text.Substring(IndexofMin + 2, 1)
        FormAltSR.txtDecDeg.Text = decdeg
        FormAltSR.txtDecMin.Text = decmin
        Select Case decNS
            Case g_LatS
                FormAltSR.cboDec.SelectedIndex = 1
            Case g_LatN
                FormAltSR.cboDec.SelectedIndex = 0
            Case Else
                FormAltSR.cboDec.SelectedIndex = 0
        End Select

        IndexofDeg = txtSRHo.Text.IndexOf(Chr(176))
        IndexofMin = txtSRHo.Text.IndexOf("'")
        Dim hodeg As String = txtSRHo.Text.Substring(0, IndexofDeg)
        Dim homin As String = txtSRHo.Text.Substring(IndexofDeg + 1, IndexofMin - (IndexofDeg + 1))

        FormAltSR.txtHoDeg.Text = hodeg
        FormAltSR.txtHoMin.Text = homin

        FormAltSR.txtLDeg.Text = Me.txtLDeg.Text
        FormAltSR.txtLMin.Text = Me.txtLMin.Text
        FormAltSR.cboL.SelectedIndex = Me.cboL.SelectedIndex
        FormAltSR.txtLoDeg.Text = Me.txtLoDeg.Text
        FormAltSR.txtLoMin.Text = Me.txtLoMin.Text
        FormAltSR.cboLo.SelectedIndex = Me.cboLo.SelectedIndex
        FormAltSR.DTSight.Value = Me.SightDateTime.Value
        FormAltSR.txtUserInfo.Text = Me.txtUserInfo.Text
        FormAltSR.Show()

        Exit Sub
    End Sub
    Public Sub PerformSRF()
        If CheckOpenWinForms("FormSRF") = True Then
            FormSRFLoaded = True
            FormSRF.SetDesktopLocation(5, 5) '
            FormSRF.BringToFront()
            FormSRF.ClearAllBtn.PerformClick()
            FormSRF.Refresh()
            FormSRF.InvokedbySightLog = True
        Else
            FormSRFLoaded = False
            FormSRF.Show()
            FormSRF.SetDesktopLocation(5, 5) '
            'FormSRF.ClearAllBtn.PerformClick()
            FormSRF.InvokedbySightLog = True
            FormSRFLoaded = True
        End If

        InitSRFFormFields()
        SRFFormEP = vbNullString

        Dim DTHr As String = Strings.Format(SightDateTime.Value.Hour, "00")
        Dim DTMin As String = Strings.Format(SightDateTime.Value.Minute, "00")
        Dim DTSec As String = Strings.Format(SightDateTime.Value.Second, "00")
        Dim DTYear As String = Strings.Format(SightDateTime.Value.Year, "0000")
        FormSRF.DTSight.Value = SightDateTime.Value
        'FormSRF.cboDay.SelectedIndex = SightDateTime.Value.Day - 1
        'FormSRF.cboMonth.SelectedIndex = SightDateTime.Value.Month - 1
        'FormSRF.txtYear.Text = DTYear
        'FormSRF.txtTime.Text = DTHr & DTMin & DTSec
        FormSRF.cboLLoBy.SelectedIndex = cboLLoBy.SelectedIndex
        FormSRF.txtWEMin.Text = txtWE.Text.Substring(0, 2)
        FormSRF.txtWESec.Text = txtWE.Text.Substring(2, 2)

        If cbWEType.Items(cbWEType.SelectedIndex).ToString = "Fast" Then
            FormSRF.cboWE.SelectedIndex = 0
        Else
            FormSRF.cboWE.SelectedIndex = 1
        End If

        ' by default FormSRF SRF sets ZD to auto calc from Long - only change to manual if ZD Minutes is nonzero then select Manual Calc option
        If cboZD.SelectedIndex = ZDInitIdx Then
            FormSRF.optZDAuto.Checked = True
        Else
            FormSRF.optZDManual.Checked = True

            Dim ZDHours As Integer = GetZDHour(cboZD.Items(cboZD.SelectedIndex).ToString)
            Dim ZDMin As Integer = GetZDMin(cboZD.Items(cboZD.SelectedIndex).ToString)
            FormSRF.txtZDh.Text = ZDHours.ToString
            Select Case ZDMin
                Case 30
                    FormSRF.cboZDm.SelectedIndex = 1
                    FormSRF.optZDManual.Checked = True
                Case 45
                    FormSRF.cboZDm.SelectedIndex = 2
                    FormSRF.optZDManual.Checked = True
                Case Else
                    FormSRF.cboZDm.SelectedIndex = 0
            End Select
        End If


        If chkbxDST.Checked = True Then
            FormSRF.chkDST.Checked = True
        Else
            FormSRF.chkDST.Checked = False
        End If

        FormSRF.txtSightNo.Text = txtSightNum.Text
        FormSRF.cboBody.SelectedIndex = cboBody.SelectedIndex

        Select Case cbLimb.SelectedIndex
            Case 0
                FormSRF.optLower.Checked = True
            Case 1
                FormSRF.optUpper.Checked = True
            Case 2
                FormSRF.optCenter.Checked = True
            Case Else
                FormSRF.optLower.Checked = True
        End Select

        FormSRF.txtLoDeg.Text = txtLoDeg.Text
        FormSRF.txtLoMin.Text = txtLoMin.Text
        Select Case cboLo.SelectedIndex
            Case 0
                FormSRF.cboLo.SelectedIndex = 0
            Case 1
                FormSRF.cboLo.SelectedIndex = 1
        End Select

        FormSRF.txtLDeg.Text = txtLDeg.Text
        FormSRF.txtLMin.Text = txtLMin.Text
        Select Case cboL.SelectedIndex
            Case 0
                FormSRF.cboL.SelectedIndex = 0
            Case 1
                FormSRF.cboL.SelectedIndex = 1
        End Select

        FormSRF.txtHE.Text = txtHE.Text
        FormSRF.cboHE.SelectedIndex = cboHEUnit.SelectedIndex

        FormSRF.txtDsDist.Text = txtHorDist.Text
        Select Case cbHorDistType.SelectedIndex
            Case 0
                FormSRF.cboDsUnit.SelectedIndex = 0
            Case 1
                FormSRF.cboDsUnit.SelectedIndex = 1
            Case 2
                FormSRF.cboDsUnit.SelectedIndex = 2
            Case 3
                FormSRF.cboDsUnit.SelectedIndex = 3
            Case 4
                FormSRF.cboDsUnit.SelectedIndex = 4
        End Select

        If cboHSIEFmt.SelectedIndex = 1 Then
            FormSRF.optHsDMS.Checked = True
        Else
            FormSRF.optHsDMm.Checked = True
        End If

        FormSRF.txtIEdeg.Text = txtIEDeg.Text
        FormSRF.txtIEmin.Text = txtIE.Text
        If cboHSIEFmt.SelectedIndex = 1 Then
            FormSRF.txtIESec.Text = txtIESec.Text
        End If
        Select Case cbIEType.SelectedIndex
            Case 0
                FormSRF.cboIE.SelectedIndex = 0
            Case 1
                FormSRF.cboIE.SelectedIndex = 1
        End Select

        FormSRF.txtHsDeg.Text = txtHSDeg.Text
        FormSRF.txtHsMin.Text = txtHSMin.Text
        If cboHSIEFmt.SelectedIndex = 1 Then
            FormSRF.txtHsSec.Text = txtHsSec.Text
        End If

        Select Case cbHorizon.SelectedIndex
            Case 0
                FormSRF.optHorizonNatural.Checked = True
            Case 1
                FormSRF.optHorizonDipShort.Checked = True
            Case 2
                FormSRF.optHorizonArtificial.Checked = True
            Case 3
                FormSRF.optHorizonBubble.Checked = True
            Case Else
                FormSRF.optHorizonNatural.Checked = True
        End Select
        FormSRF.txtUserInfo.Text = Me.txtUserInfo.Text

        FormSRF.cmdReduce.PerformClick()
        FormSRF.BringToFront()

        SRFFormZN = FormSRF.ZN
        SRFFormIntercept = FormSRF.Intercept
        Dim TempTotGHA As Double = FormSRF.SaveGHA
        If TempTotGHA > 360 Then
            TempTotGHA -= 360
        End If
        Dim TempGHADeg As Integer = Int(TempTotGHA)
        Dim TempGHAMin As Double = (TempTotGHA - TempGHADeg) * 60
        SRFFormGHADeg = TempGHADeg
        SRFFormGHAMin = TempGHAMin
        SRFFormDecDeg = FormSRF.TotDecDegrees
        SRFFormDecMin = FormSRF.TotDecMinutes
        SRFFormHoDeg = FormSRF.HoDeg
        SRFFormHoMin = FormSRF.HoMin

        If FormSRF.DE1 > 0 Then SRFFormDecNS = (g_LatN)
        If FormSRF.DE1 = 0 Then SRFFormDecNS = (g_StrSpace)
        If FormSRF.DE1 < 0 Then SRFFormDecNS = (g_LatS)

        btnAltSR.Visible = True
        txtIntZn.Clear()
        txtSRFEP.Clear()
        txtSRGHA.Clear()
        txtSRDec.Clear()
        txtSRHo.Clear()

        txtSRGHA.Text = Convert.ToInt32(SRFFormGHADeg).ToString("##0") & Chr(176) & " " & SRFFormGHAMin.ToString("00.0") & "'"
        txtSRDec.Text = Convert.ToInt32(SRFFormDecDeg).ToString("##0") & Chr(176) & " " & SRFFormDecMin.ToString("00.0") & "' " & SRFFormDecNS.ToString
        txtSRHo.Text = Convert.ToInt32(SRFFormHoDeg).ToString("##0") & Chr(176) & " " & SRFFormHoMin.ToString("00.0") & "'"

        txtSRFEP.Text = SRFFormEP

        If SRFFormIntercept >= 0 Then
            txtIntZn.AppendText("a = " & System.Math.Abs(SRFFormIntercept).ToString & " nm Away ")
        End If
        If SRFFormIntercept < 0 Then
            txtIntZn.AppendText("a = " & System.Math.Abs(SRFFormIntercept).ToString & " nm Toward ")
        End If
        If SRFFormIntercept <> 0 Then
            txtIntZn.AppendText(" Zn = " & System.Math.Abs(SRFFormZN).ToString & Chr(176))
        End If
        Exit Sub
    End Sub

    Private Sub btnUpdateExisting_Click(sender As Object, e As EventArgs) Handles btnUpdateExisting.Click
        ' updating a sight entry do not carry forward the old sight reduction - may no longer be valid so zero out Int and Zn fields

        InitSRFFormFields()
        SRFFormEP = vbNullString
        txtIntZn.Clear()
        txtSRFEP.Clear()
        txtSRGHA.Clear()
        txtSRDec.Clear()
        txtSRHo.Clear()
        FileUpdated = False
        EditError = False
        If EditScreenFields() = False Then
            EditError = True
        End If
        If EditError = False Then ' was there an error in the updated info - No error then check to see if auto reduce is on else clear screen fields
            If CheckBoxAutoReduce.Checked = True Then
                PerformSRF()    ' do sight reduction first then update existing info
                ExecUpdateExisting()
                If chkClearFields.Checked = True Then
                    ExecClearScreenFields()
                End If
            Else
                ExecUpdateExisting()
                If chkClearFields.Checked = True Then
                    ExecClearScreenFields()
                End If
            End If
        Else
            ' do nothing if there was an error in the updated info
        End If

        Exit Sub
    End Sub
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click

        ExitSRFandAltSR()

        ExecClearScreenFields()
        Exit Sub
    End Sub
    Private Sub ExecUpdateExisting()
        Dim SaveSightNum As String = txtSightNum.Text
        Dim SaveSightDT As Date = SightDateTime.Value
        Dim SaveBodyName As String = cboBody.Items(cboBody.SelectedIndex).ToString

        FileUpdated = True
        EditError = False
        If EditScreenFields() = True Then
            ' Mark the current sight num entry in sight log array as 'Deleted' 
            Dim i As Integer = 0
            Dim DidDelete As Boolean = False
            For i = 0 To UBound(SightLogArray)
                If SightLogArray(i).SightNum = SaveSightNum Then
                    If SightLogArray(i).EntryStatus = "Active" Then
                        SightLogArray(i).EntryStatus = "Deleted"
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
                btnSaveLogAsTxt.Visible = True
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
                btnSightReduce.Visible = False
                btnPlanSight.Visible = False
                btnAltSR.Visible = False
            End If
            SelectDGRow(SaveSightDT, SaveBodyName)
            FileUpdated = True
            FileLoading = False

        Else
            EditError = True
        End If

        Exit Sub
    End Sub

    Private Sub btnDeleteSight_Click(sender As Object, e As EventArgs) Handles btnDeleteSight.Click
        FileUpdated = True
        Dim i As Integer = 0
        Dim DidDelete As Boolean = False
        For i = 0 To UBound(SightLogArray)
            If SightLogArray(i).SightNum = txtSightNum.Text Then
                If SightLogArray(i).EntryStatus = "Active" Then
                    SightLogArray(i).EntryStatus = "Deleted"
                    DidDelete = True
                End If
            End If
        Next
        If DidDelete = False Then
            ErrorMsgBox("Did Not Mark Old Entry as Deleted - Debug This")
            Exit Sub
        End If
        ExitSRFandAltSR()
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
        SEDataGrid.ClearSelection()
        SEDataGrid.CurrentCell = Nothing
        SEDataGrid.Refresh()
        FileLoading = False
        Exit Sub
    End Sub
    Private Sub ExecFileSave()
        Dim i As Integer = 0
        Dim iCnt As Integer = 0
        Dim SE As SightEntry = New SightEntry

        For i = 0 To UBound(SightLogArray)
            SE = SightLogArray(i)
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
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.Title = "Save an Sight Log Text File"
        saveFileDialog1.InitialDirectory = SLDir
        saveFileDialog1.FileName = SLOpenFName
        saveFileDialog1.ShowDialog(Me)

        If saveFileDialog1.FileName <> "" Then
            SLOpenFName = saveFileDialog1.FileName
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog1.FileName, False)
            i = 0
            For i = 0 To UBound(SightLogArray)
                SE = SightLogArray(i)
                If SE.EntryStatus = "Active" Then
                    objWriter.WriteLine(FormatSightForSave(SE))
                End If
            Next
            objWriter.Close()
            objWriter.Dispose()
        End If
        FileUpdated = False
        Exit Sub
    End Sub

    Private Function FormatSightForSave(ByVal SE As SightEntry) As String
        Dim SaveStr As String = vbNullString
        Dim StrParm As String = ";"
        SaveStr = "No=" & SE.SightNum & StrParm &
            "Date/Time=" & SE.SightDateTime.ToString("MM/dd/yyyy HH:mm:ss") & StrParm &
            "SDate=" & SE.SightDateTime.ToString("MM/dd/yyyy") & StrParm &
            "STime=" & SE.SightDateTime.ToString("HH:mm:ss") & StrParm &
            "BodyName=" & SE.BodyName & StrParm &
            "BodyLimb=" & SE.BodyLimb & StrParm &
            "DST=" & SE.DST & StrParm &
            "WE=" & SE.WE & StrParm &
            "WEType=" & SE.WEType & StrParm &
            "DRLat=" & SE.DRLat & StrParm &
            "DRLong=" & SE.DRLong & StrParm &
            "LLoBy=" & SE.LLoBy & StrParm &
            "HS=" & SE.HS & StrParm &
            "IC=" & SE.IC & StrParm &
            "ICType=" & SE.ICType & StrParm &
            "HE=" & SE.HE & StrParm &
            "HorDist=" & SE.HorDist & StrParm &
            "HorDistType=" & SE.HorDistType & StrParm &
            "HorType=" & SE.HorType & StrParm &
            "a=" & SE.Intercept & StrParm &
            "Zn=" & SE.Zn & StrParm &
            "Name=" & SE.SLName & StrParm &
            "Squadron=" & SE.SLSquadron & StrParm &
            "ZD=" & SE.ZD & StrParm &
            "EP=" & SE.EP & StrParm &
            "ApprxBrg=" & SE.ApprxBrg & StrParm &
            "Remarks=" & SE.Remarks & StrParm &
            "SRGHA=" & SE.SRGHA & StrParm &
            "SRDEC=" & SE.SRDec & StrParm &
            "SRHO=" & SE.SRHo & StrParm &
            "UserInfo=" & SE.UserInfo
        Return SaveStr
    End Function
    Private Sub ExecDataSaveasCSV()
        Dim i As Integer = 0
        Dim iCnt As Integer = 0
        Dim SE As SightEntry = New SightEntry
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim saveFileDialog1 As New SaveFileDialog()

        For i = 0 To UBound(SightLogArray)
            SE = SightLogArray(i)
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
        Dim SLReportFname As String = SLOpenFName.Replace(".txt", "SLReport.csv")
        saveFileDialog1.InitialDirectory = "./DeckLog/"
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv"
        saveFileDialog1.Title = "Save Sight Log as a CSV File"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = SLReportFname
        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFileDialog1.FileName = vbNullString Then
                Exit Sub
            End If
            SLReportFname = saveFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim textstr As New System.Text.StringBuilder()
        Dim FileHdrStr As String = vbNullString
        For idx As Integer = 0 To UBound(HdrStr)
            If idx > 0 Then
                textstr.Append(",")
            End If
            textstr.Append(HdrStr(idx).Trim)
        Next
        textstr.AppendLine()
        For x As Integer = 0 To SEDataGrid.Rows.Count - 1
            If IsNothing(SEDataGrid.Rows(x).Cells(0).Value) = False Then
                For v As Integer = 0 To SEDataGrid.Columns.Count - 8
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then
                        textstr.Append(",")
                    End If
                    If IsNothing(SEDataGrid.Rows(x).Cells(v).Value) = False Then
                        Dim tempstr As String = SEDataGrid.Rows(x).Cells(v).Value.ToString().Trim
                        tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
                        textstr.Append(tempstr)
                    Else
                        textstr.Append("")
                    End If
                Next
            End If
            'adding new line to text
            textstr.AppendLine()
        Next
        IO.File.WriteAllText(SLReportFname, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"))
        Exit Sub
    End Sub

    Private Sub FormatSightintoDG(ByVal SE As SightEntry)
        Try
            ' The order of these Sight Array fields must be same as the display order of the grid view field order
            SEDataGrid.Rows.Add(SE.SightNum, SE.SightDateTime.ToString("MM/dd/yyyy HH:mm:ss"), SE.BodyName, SE.BodyLimb,
                                SE.DST, SE.WE, SE.WEType, SE.ZD, SE.HS, SE.HorType, SE.HorDist & " " & SE.HorDistType, SE.ApprxBrg, SE.HE, SE.IC, SE.ICType,
                                SE.DRLat, SE.DRLong, SE.LLoBy, SE.Intercept, SE.Zn, SE.EP, SE.SLName, SE.SLSquadron, SE.WTDiff, SE.HSDiff, SE.HSWTRate, SE.Remarks, SE.SRGHA, SE.SRDec, SE.SRHo, SE.UserInfo)
            Exit Sub
        Catch Ex As Exception
            ErrorMsgBox("Error Adding DataGrid Record: " & Ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub SelectDGRow(ByVal SightDT As Date, ByVal SightBody As String)
        Dim DGLimit As Integer = SEDataGrid.DisplayedRowCount(True)
        Dim cellct As Integer = 0
        Dim rowct As Integer = 0
        Dim FoundDT As Boolean = False
        Dim FoundBody As Boolean = False
        Dim FoundRow As Boolean = False
        Dim SearchDT As String = SightDT.ToString("MM/dd/yyyy HH:mm:ss")
        SEDataGrid.ClearSelection()
        For Each row As DataGridViewRow In SEDataGrid.Rows
            FoundDT = False
            FoundBody = False
            FoundRow = False
            cellct = 0
            For Each cell As DataGridViewCell In row.Cells
                If cellct = 1 Then
                    If cell.Value.ToString = SearchDT Then
                        FoundDT = True
                    End If
                End If
                If cellct = 2 Then
                    If cell.Value.ToString = SightBody Then
                        FoundBody = True
                    End If
                End If
                If FoundDT = True And FoundBody = True Then
                    SEDataGrid.ClearSelection()

                    SEDataGrid.CurrentCell = SEDataGrid.Rows.SharedRow(rowct).Cells(cellct)
                    SEDataGrid.Rows(rowct).Selected = True
                    'row.Selected = True

                    Exit Sub
                End If
                cellct += 1

            Next
            rowct += 1
        Next
        Exit Sub
    End Sub
    Private Sub BuildDGFromSightArray()
        Dim i As Integer = 0
        SEDataGrid.Rows.Clear()

        SEDataGrid.Refresh()
        For i = 0 To UBound(SightLogArray)
            Dim SE As SightEntry = SightLogArray(i)
            If SE.EntryStatus = "Active" Then
                FormatSightintoDG(SE)
            End If
        Next
        SEDataGrid.Refresh()

        Exit Sub
    End Sub
    Private Sub ParseReadLine(ByVal rdline As String)
        EntryIndex = UBound(SightLogArray)
        If ParseLineIntoSLArray(rdline) = True Then
            SightLogArray(EntryIndex) = CommonSE
            SightLogArray(EntryIndex).EntryStatus = "Active"
            EntryIndex += 1
            ReDim Preserve SightLogArray(EntryIndex)
            SightLogArray(EntryIndex).EntryStatus = "Empty"
            SightLogArray(EntryIndex).SightDateTime = Now().AddDays(365)
            Exit Sub
        End If
        Exit Sub
    End Sub
    Private Function ParseLineIntoSLArray(ByVal rdline As String) As Boolean
        Dim SE As SightEntry = New SightEntry
        SE.LLoBy = "DR" ' new field added June 2020 - default is DR so preset field to this in case it does not come in on an older file
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
                    Case "Squadron"
                        SE.SLSquadron = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "Num", "No"
                        SE.SightNum = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "Date/Time"
                        Dim tempDT As String = ParseArray(i).Substring(DataSt, DataEnd).Replace("-", "/")
                        SE.SightDateTime = Convert.ToDateTime(ParseArray(i).Substring(DataSt, DataEnd))
                    Case "SDate"
                        'Dim tempDT1 As String = ParseArray(i).Substring(DataSt, DataEnd).Replace("-", "/")
                        'SE.SightDate = Convert.ToDateTime(tempDT1) 'ParseArray(i).Substring(DataSt, DataEnd)
                    Case "STime"
                        'SE.SightTime = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "DST"
                        SE.DST = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "WE"
                        SE.WE = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "WEType"
                        SE.WEType = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "DRLat"
                        SE.DRLat = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "DRLong"
                        SE.DRLong = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HS"
                        SE.HS = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "IC"
                        SE.IC = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "ICType"
                        SE.ICType = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HE"
                        SE.HE = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HorType"
                        SE.HorType = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "BodyName"
                        SE.BodyName = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "BodyLimb"
                        SE.BodyLimb = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HorDist"
                        SE.HorDist = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "HorDistType"
                        SE.HorDistType = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "Remarks"
                        SE.Remarks = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "a"
                        SE.Intercept = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "Zn"
                        SE.Zn = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "ZD"
                        SE.ZD = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "EP"
                        SE.EP = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "ApprxBrg"
                        SE.ApprxBrg = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "SRGHA"
                        SE.SRGHA = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "SRDEC"
                        SE.SRDec = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "SRHO"
                        SE.SRHo = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "UserInfo"
                        SE.UserInfo = ParseArray(i).Substring(DataSt, DataEnd)
                    Case "LLoBy"
                        SE.LLoBy = ParseArray(i).Substring(DataSt, DataEnd)
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
        ' first sort sight log array by sight date/time and assign result back to sight log array

        SightLogArray = SightLogArray.OrderBy(Function(SE) SE.SightDateTime.ToString("yyyy/MM/dd HH:mm:ss")).ToArray
        ' now run through sight log array and for each active entry assign sight number from index 
        Dim i As Integer = 0
        Dim LastActiveIdx As Integer = -1
        Dim SightNumTmp As Integer = 1
        For i = 0 To UBound(SightLogArray)
            If SightLogArray(i).EntryStatus = "Active" Then
                SightLogArray(i).SightNum = SightNumTmp
                SightNumTmp += 1
                If CheckBoxShowAvg.Checked = False Then GoTo EvalNextSE
                SightLogArray(i).HSDouble = CnvtHSStrtoDouble(SightLogArray(i).HS)
                If FirstActive = True Then
                    FirstActive = False
                    SightLogArray(i).WTDiff = "Skipped - 1st Sight"
                    SightLogArray(i).HSDiff = "Skipped - 1st Sight"
                    SightLogArray(i).HSWTRate = "Skipped - 1st Sight"
                ElseIf i > 0 And LastActiveIdx <> -1 Then
                    If SightLogArray(i).BodyName <> SightLogArray(i - 1).BodyName Or SightLogArray(i).BodyLimb <> SightLogArray(i - 1).BodyLimb Then
                        SightLogArray(i).WTDiff = "Not the same body"
                        SightLogArray(i).HSDiff = "Not the same body"
                        SightLogArray(i).HSWTRate = "Not the same body"
                        GoTo EvalNextSE
                    End If
                    Dim TempTS1 As TimeSpan = SightLogArray(i).SightDateTime - SightLogArray(LastActiveIdx).SightDateTime
                    If TempTS1.Days <> 0 Or TempTS1.Hours <> 0 Or TempTS1.Minutes > 30 Then
                        If TempTS1.Days <> 0 Then
                            SightLogArray(i).WTDiff = "WT=" + TempTS1.Days.ToString("#0") + "Dy " + TempTS1.Hours.ToString("#0") + "Hr, " + TempTS1.Minutes.ToString("#0") + "Min," + TempTS1.Seconds.ToString("#0") + "Sec"
                        ElseIf TempTS1.Hours <> 0 Then
                            SightLogArray(i).WTDiff = "WT Diff =" + TempTS1.Hours.ToString("#0") + "Hr, " + TempTS1.Minutes.ToString("#0") + "Min, " + TempTS1.Seconds.ToString("#0") + "Sec"
                        ElseIf TempTS1.TotalMinutes > 30 Then
                            SightLogArray(i).WTDiff = "WT=" + TempTS1.Minutes.ToString("#0") + "Min," + TempTS1.Seconds.ToString("#0") + "Sec"
                        End If
                        SightLogArray(i).HSDiff = "WT Diff Too Large"
                        SightLogArray(i).HSWTRate = "WT Diff Too Large"
                    Else
                        If TempTS1.TotalSeconds = 0 Then
                            SightLogArray(i).WTDiff = "0 Sec"
                            SightLogArray(i).HSWTRate = "0 '/sec"
                        Else
                            SightLogArray(i).WTDiff = TempTS1.TotalSeconds.ToString("##00") + " Sec"
                        End If
                        Dim HSTemp As Double = (SightLogArray(i).HSDouble - SightLogArray(LastActiveIdx).HSDouble) * 60
                        If HSTemp = 0 Then
                            SightLogArray(i).HSDiff = "0 '"
                            SightLogArray(i).HSWTRate = "0 '/sec"
                        Else
                            SightLogArray(i).HSDiff = ((SightLogArray(i).HSDouble - SightLogArray(LastActiveIdx).HSDouble) * 60).ToString("F2") + " '"
                        End If
                        If TempTS1.TotalSeconds <> 0 And HSTemp <> 0 Then
                            SightLogArray(i).HSWTRate = (HSTemp / TempTS1.TotalSeconds).ToString("F2") + " '/sec"
                        End If
                    End If
                End If
                LastActiveIdx = i
            End If
EvalNextSE:
        Next
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
        Dim SaveSightNum As String = txtSightNum.Text
        Dim SaveSightDT As Date = SightDateTime.Value
        Dim SaveBodyName As String = cboBody.Items(cboBody.SelectedIndex).ToString

        FileLoading = True
        EditError = False
        If EditScreenFields() = True Then
            '
            If CheckBoxAutoReduce.Checked = True Then
                PerformSRF()
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
                btnSaveLogAsTxt.Visible = True
                btnUpdateExisting.Visible = True
                btnDeleteSight.Visible = True
                btnSightReduce.Visible = False
                btnAltSR.Visible = False
                btnPlanSight.Visible = False
            End If
            FileUpdated = True
            FileLoading = False
        Else
            EditError = True
        End If
        SelectDGRow(SaveSightDT, SaveBodyName)
        Exit Sub
    End Sub
    Private Sub BuildArrayFromscreen()
        Dim Idx As Integer = UBound(SightLogArray)
        Dim SightNumTemp As Integer = Idx + 1
        SightLogArray(Idx).SightNum = SightNumTemp.ToString("###0")
        'txtSightNum.Text = SightNumTemp.ToString("###0")
        SightLogArray(Idx).EntryStatus = "Active"
        SightLogArray(Idx).SLName = txtName.Text
        SightLogArray(Idx).SLSquadron = txtSquadron.Text
        SightLogArray(Idx).SightDateTime = SightDateTime.Value
        'SightLogArray(Idx).SightDate = SightDateTime.Value.ToShortDateString
        'SightLogArray(Idx).SightTime = SightDateTime.Value.ToLongTimeString
        'If SightLogArray(Idx).SightDateTime.IsDaylightSavingTime Then
        'SightLogArray(Idx).DST = "X"
        'Else
        If chkbxDST.Checked = True Then
            SightLogArray(Idx).DST = "X"
        Else
            SightLogArray(Idx).DST = ""
        End If
        'End If
        SightLogArray(Idx).WE = txtWE.Text
        If cbWEType.SelectedIndex = 0 Then
            SightLogArray(Idx).WEType = "Fast"
        Else
            SightLogArray(Idx).WEType = "Slow"
        End If
        Dim LatStr As String = txtLDeg.Text.ToString & Chr(176) & String.Format(txtLMin.Text.ToString, "00.0") & "'"
        If cboL.SelectedIndex = 0 Then
            LatStr = LatStr & g_LatN
        Else
            LatStr = LatStr & g_LatS
        End If
        SightLogArray(Idx).DRLat = LatStr

        Dim LongStr As String = txtLoDeg.Text.ToString & Chr(176) & String.Format(txtLoMin.Text.ToString, "00.0") & "'"
        If cboLo.SelectedIndex = 0 Then
            LongStr = LongStr & g_LongW
        Else
            LongStr = LongStr & g_LongE
        End If
        SightLogArray(Idx).DRLong = LongStr

        SightLogArray(Idx).LLoBy = cboLLoBy.Items(cboLLoBy.SelectedIndex).ToString

        If cboHSIEFmt.SelectedIndex = 0 Then
            SightLogArray(Idx).HS = txtHSDeg.Text.ToString & Chr(176) & String.Format(txtHSMin.Text.ToString, "00.0") & "'"
            SightLogArray(Idx).HSDouble = Convert.ToDouble(txtHSDeg.Text.ToString) + (Convert.ToDouble(txtHSMin.Text.ToString)) / 60
        Else
            SightLogArray(Idx).HS = txtHSDeg.Text.ToString & Chr(176) & String.Format(txtHSMin.Text.ToString, "00") & "'" & String.Format(txtHsSec.Text.ToString, "00") & Chr(34)
            SightLogArray(Idx).HSDouble = Convert.ToDouble(txtHSDeg.Text.ToString) + (Convert.ToDouble(txtHSMin.Text.ToString)) / 60 + (Convert.ToDouble(txtHsSec.Text.ToString)) / 3600
        End If

        'SightLogArray(Idx).WTDiff = 0
        'SightLogArray(Idx).HSDiff = 0
        'SightLogArray(Idx).HSWTRate = 0

        If cboHSIEFmt.SelectedIndex = 0 Then
            SightLogArray(Idx).IC = txtIEDeg.Text.ToString & Chr(176) & String.Format(txtIE.Text.ToString, "00.0") & "'"
        Else
            SightLogArray(Idx).IC = txtIEDeg.Text.ToString & Chr(176) & String.Format(txtIE.Text.ToString, "00") & "'" & String.Format(txtIESec.Text.ToString, "00") & Chr(34)
        End If

        If cbIEType.SelectedIndex = 0 Then
            SightLogArray(Idx).ICType = "On"
        Else
            SightLogArray(Idx).ICType = "Off"
        End If

        SightLogArray(Idx).HE = txtHE.Text.ToString
        Select Case cboHEUnit.SelectedIndex
            Case 0
                SightLogArray(Idx).HE &= " ft"
            Case 1
                SightLogArray(Idx).HE &= " in"
            Case 2
                SightLogArray(Idx).HE &= " m "
            Case 3
                SightLogArray(Idx).HE &= " cm"
        End Select


        Select Case cbHorizon.SelectedIndex
            Case 0
                SightLogArray(Idx).HorType = "Natural"
            Case 1
                SightLogArray(Idx).HorType = "Dip Short"
            Case 2
                SightLogArray(Idx).HorType = "Artificial"
            Case 3
                SightLogArray(Idx).HorType = "Bubble"
            Case Else
                SightLogArray(Idx).HorType = "Natural"
        End Select
        SightLogArray(Idx).BodyName = cboBody.Items(cboBody.SelectedIndex).ToString
        Select Case cbLimb.SelectedIndex
            Case 0
                SightLogArray(Idx).BodyLimb = "Lower"
            Case 1
                SightLogArray(Idx).BodyLimb = "Upper"
            Case 2
                SightLogArray(Idx).BodyLimb = "Center"
        End Select
        SightLogArray(Idx).HorDist = txtHorDist.Text.ToString
        Select Case cbHorDistType.SelectedIndex
            Case 0
                SightLogArray(Idx).HorDistType = "Feet"
            Case 1
                SightLogArray(Idx).HorDistType = "Yards"
            Case 2
                SightLogArray(Idx).HorDistType = "Meters"
            Case 3
                SightLogArray(Idx).HorDistType = "Statute Mile"
            Case 4
                SightLogArray(Idx).HorDistType = "Nautical Mile"
            Case Else
                SightLogArray(Idx).HorDistType = "Feet"
        End Select
        SightLogArray(Idx).Remarks = txtRemarks.Text.ToString
        SightLogArray(Idx).ZD = cboZD.Items(cboZD.SelectedIndex).ToString
        SightLogArray(Idx).EP = txtSRFEP.Text.ToString
        SightLogArray(Idx).SRGHA = txtSRGHA.Text
        SightLogArray(Idx).SRDec = txtSRDec.Text
        SightLogArray(Idx).SRHo = txtSRHo.Text
        SightLogArray(Idx).UserInfo = txtUserInfo.Text

        If SRFFormIntercept <> 0 Or SRFFormZN <> 0 Then
            If SRFFormIntercept >= 0 Then
                SightLogArray(Idx).Intercept = System.Math.Abs(SRFFormIntercept).ToString & " nm Away"
            Else
                SightLogArray(Idx).Intercept = System.Math.Abs(SRFFormIntercept).ToString & " nm Toward"
            End If

            SightLogArray(Idx).Zn = SRFFormZN.ToString & Chr(176)
        Else
            SightLogArray(Idx).Intercept = vbNullString
            SightLogArray(Idx).Zn = vbNullString
        End If

        SightLogArray(Idx).ApprxBrg = cboApprxBrg.Items(cboApprxBrg.SelectedIndex).ToString

        ' sort sight array by date/time field and assign sight num to each record
        PrepareSightArray()

        EntryIndex = UBound(SightLogArray)
        EntryIndex += 1
        ReDim Preserve SightLogArray(EntryIndex)
        SightLogArray(EntryIndex).EntryStatus = "Empty"
        SightLogArray(EntryIndex).SightDateTime = Now().AddDays(365)
        Exit Sub
    End Sub
    Private Function EditScreenFields() As Boolean
        If Not EditNameField() Then
            Return False
        End If
        If Not EditSquadronField() Then
            Return False
        End If
        If Not EditWEField() Then
            Return False
        End If
        If Not EditDRLatField() Then
            Return False
        End If
        If Not EditDRLongField() Then
            Return False
        End If
        If Not EditDSTField() Then ' the DST edits need to occur after Lat & Long edits because it will use ZTInfo form to populate DST field
            Return False
        End If
        If Not EditHSField() Then
            Return False
        End If
        If Not EditIEField() Then
            Return False
        End If
        If Not EditHEField() Then
            Return False
        End If
        If Not EditDSField() Then
            Return False
        End If
        If Not EditLimbHorizon() Then
            Return False
        End If
        If Not EditApprxBrg() Then
            Return False
        End If
        Return True
    End Function

    Private Function EditApprxBrg() As Boolean
        If cboApprxBrg.Items(cboApprxBrg.SelectedIndex).ToString = "None" Then
            cboApprxBrg.SelectedIndex = 4 ' default to S - south approx bearing
            'ErrorMsgBox("Approximate Bearing Selection Required")
        End If
        Return True
        Exit Function
    End Function
    Private Function EditLimbHorizon() As Boolean
        If cbHorizon.SelectedText = "Bubble" Then
            If cbLimb.SelectedText = "Upper" Or cbLimb.SelectedText = "Lower" Then
                ErrorMsgBox("Invalid combination of Horizon and Limb selected")
                Return False
            End If
        End If
        If cbLimb.SelectedText = "Center" Then
            If cbHorizon.SelectedText = "Natural" Or cbHorizon.SelectedText = "Dip Short" Then
                ErrorMsgBox("Invalid combination of Horizon and Limb selected")
                Return False
            End If
        End If
        If cbLimb.SelectedText = "Center" Then
            If cboBody.SelectedText = "Sun" Or cboBody.SelectedText = "Moon" Then
                ErrorMsgBox("Invalid combination of Horizon and Limb selected")
                Return False
            End If
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
    Private Function EditSquadronField() As Boolean
        If txtSquadron.Text = "" Then
            ErrorMsgBox("Missing Squadron Name - Enter Squadron Name")
            Return False
        End If
        Return True
    End Function
    Private Function EditWEField() As Boolean
        If txtWE.Text = "" Or "0" Or "00" Or "000" Then
            txtWE.Text = "0000"
        End If

        If txtWE.Text.Length < 4 Then
            ErrorMsgBox("Watch Error format is mmss and must be 4 numbers in length - Correct And Reenter")
            Return False
        End If

        If IsNumeric(txtWE.Text) Then
            Dim WEMin As Integer = txtWE.Text.Substring(0, 2)
            If WEMin < 0 Or WEMin > 59 Then
                ErrorMsgBox("Invalid Watch Error Minutes - Must be 0 to 59 - Correct And Reenter")
                Return False
            End If
            Dim WESec As Integer = txtWE.Text.Substring(2, 2)
            If WESec < 0 Or WESec > 59 Then
                ErrorMsgBox("Invalid Watch Error Second - must be 0 to 59 - Correct And Reenter")
                Return False
            End If
        Else
            ErrorMsgBox("Watch Error Format is mmss and must be 4 numbers in length - Correct And Reenter")
            Return False
        End If

        Return True
    End Function

    Private Function EditDSTField() As Boolean
        'If chkUseZTInfo.Checked = True Then
        '    ZTInfo.Show()
        '    ZTInfo.txtLoDegA.Text = txtLoDeg.Text
        '    ZTInfo.txtLoMinA.Text = txtLoMin.Text
        '    ZTInfo.cboLoA.SelectedIndex = cboLo.SelectedIndex
        '    ZTInfo.DTLocA.Value = SightDateTime.Value
        '    ZTInfo.UpdateSLDST = True
        '    'If ZTInfo.LocALLoDTisDST = True Then
        '    '    chkbxDST.Checked = True
        '    'Else
        '    '    chkbxDST.Checked = False
        '    'End If
        'Else
        '    ZTInfo.UpdateSLDST = False
        'End If
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
            ErrorMsgBox("Error in DRLat Degree Or Minutes Field.  Original error: " & Ex.Message)
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

            Return True
        Catch Ex As Exception
            ErrorMsgBox("Error in DRLong Degree Or Minutes Fields.  Original error: " & Ex.Message)
            Return False
        End Try
        Return True
        Exit Function
    End Function
    Private Function EditHSField() As Boolean
        If txtHSDeg.Text = "" Then
            ErrorMsgBox("Missing HS Degrees - Required Field")
            Return False
        End If
        If txtHSMin.Text = "" Then
            txtHSMin.Text = "00"
        End If
        If cboHSIEFmt.SelectedIndex = 1 Then
            If txtHsSec.Text = "" Then
                txtHsSec.Text = "00"
            End If
            If txtHSMin.Text.ToString.Contains(".") Then
                ErrorMsgBox("Invalid HS Min and Sec Entered - Min can not contain decimal")
                Return False
            End If
        End If

        Try
            Dim HSDeg As Integer = Convert.ToInt32(txtHSDeg.Text.ToString)
            If HSDeg < 0 Or HSDeg > 89 Then
                ErrorMsgBox("Invalid HS Degrees Entered - Must >= 0 And < 90")
                Return False
            End If

            Dim HSMin As Double = Convert.ToDouble(txtHSMin.Text.ToString)
            If HSMin < 0 Or HSMin > 59.9 Then
                ErrorMsgBox("Invalid HS Minutes Entered - Must >= 0 And < 60")
                Return False
            End If

            If cboHSIEFmt.SelectedIndex = 1 Then
                Dim HSSec As Double = Convert.ToDouble(txtHsSec.Text.ToString)
                If HSSec < 0 Or HSSec > 59.9 Then
                    ErrorMsgBox("Invalid HS Seconds Entered - Must >= 0 And < 60")
                    Return False
                End If
            End If
            Return True
        Catch Ex As Exception
            ErrorMsgBox("Error in HS Degree Or Minutes Fields.  Original error: " & Ex.Message)
            Return False
        End Try
        Return True
        Exit Function
    End Function
    Private Function EditIEField() As Boolean
        If txtIE.Text = "" Then
            txtIE.Text = "00"
        End If
        If txtIEDeg.Text = "" Then
            txtIEDeg.Text = "00"
        End If
        If cboHSIEFmt.SelectedIndex = 1 Then
            If txtIESec.Text = "" Then
                txtIESec.Text = "00"
            End If
            If txtIESec.Text.ToString.Contains(".") Then
                ErrorMsgBox("Invalid IE Min and Sec Entered - Min can not contain decimal")
                Return False
            End If
        End If
        Try
            Dim IEdCalc As Double = Convert.ToDouble(txtIEDeg.Text.ToString)
            If IEdCalc < 0 Or IEdCalc > 59.9 Then
                ErrorMsgBox("Invalid IE Deg Entered - Must >= 0 And < 60")
                Return False
            End If

            Dim IECalc As Double = Convert.ToDouble(txtIE.Text.ToString)
            If IECalc < 0 Or IECalc > 59.9 Then
                ErrorMsgBox("Invalid IE Min Entered - Must >= 0 And < 60")
                Return False
            End If

            If cboHSIEFmt.SelectedIndex = 1 Then
                Dim IESec As Double = Convert.ToDouble(txtIESec.Text.ToString)
                If IESec < 0 Or IESec > 59.9 Then
                    ErrorMsgBox("Invalid IE Seconds Entered - Must >= 0 And < 60")
                    Return False
                End If
            End If
            Return True
        Catch Ex As Exception
            ErrorMsgBox("Error in IE Fields.  Original error: " & Ex.Message)
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
            If HECalc < 0 Or HECalc >= 99.9 Then
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
        For i = 0 To UBound(SightLogArray)
            If SightLogArray(i).EntryStatus = "Active" Then
                ActiveCnt += 1
            End If
        Next
        Return ActiveCnt
    End Function
    Private Function GetBNameIdx(ByVal NameStr As String) As Integer
        Dim i As Integer = 0
        For i = 0 To UBound(BNameArray)
            If BNameArray(i) = NameStr Then
                Return i
                Exit Function
            End If
        Next
        Return 0
        Exit Function
    End Function

    Private Sub SEDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles SEDataGrid.SelectionChanged
        If FileLoading = True Then Exit Sub
        Dim n As Integer = SEDataGrid.CurrentRow.Index
        ' The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
        btnNoonSight.Visible = False
        txtName.Text = SEDataGrid.Rows(n).Cells(SLNameCell).Value
        txtSquadron.Text = SEDataGrid.Rows(n).Cells(SLSquadron).Value
        txtSightNum.Text = SEDataGrid.Rows(n).Cells(SightNumCell).Value
        SightDateTime.Value = SEDataGrid.Rows(n).Cells(SightDateTimeCell).Value

        If SEDataGrid.Rows(n).Cells(DSTCell).Value.ToString = "X" Then
            chkbxDST.Checked = True
        Else
            chkbxDST.Checked = False
        End If

        txtWE.Text = SEDataGrid.Rows(n).Cells(WECell).Value

        If SEDataGrid.Rows(n).Cells(WETypeCell).Value.ToString = "Fast" Then
            cbWEType.SelectedIndex = 0
        Else
            cbWEType.SelectedIndex = 1
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

        If SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.Contains(Chr(34)) Or SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.Contains(Chr(34)) Then
            cboHSIEFmt.SelectedIndex = 1
        Else
            cboHSIEFmt.SelectedIndex = 0
        End If

        DegIdx = SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.IndexOf(Chr(176).ToString)
        txtHSDeg.Text = SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.Substring(0, DegIdx)
        MinIdx = SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.IndexOf("'") - 1
        txtHSMin.Text = SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.Substring(DegIdx + 1, (MinIdx - DegIdx))
        If SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.Contains(Chr(34)) Then
            Dim SecIdx As Integer = SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.IndexOf(Chr(34)) - 1
            txtHsSec.Text = SEDataGrid.Rows(n).Cells(HSCell).Value.ToString.Substring(MinIdx + 2, ((SecIdx - 1) - MinIdx))
        Else
            txtHsSec.Clear()
        End If

        DegIdx = SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.IndexOf(Chr(176).ToString)
        txtIEDeg.Text = SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.Substring(0, DegIdx)
        MinIdx = SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.IndexOf("'") - 1
        txtIE.Text = SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.Substring(DegIdx + 1, (MinIdx - DegIdx))
        If SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.Contains(Chr(34)) Then
            Dim SecIdx As Integer = SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.IndexOf(Chr(34)) - 1
            txtIESec.Text = SEDataGrid.Rows(n).Cells(ICCell).Value.ToString.Substring(MinIdx + 2, ((SecIdx - 1) - MinIdx))
        Else
            txtIESec.Clear()
        End If

        If SEDataGrid.Rows(n).Cells(ICTypeCell).Value.ToString.Substring(0, 2) = "On" Then
            cbIEType.SelectedIndex = 0
        Else
            cbIEType.SelectedIndex = 1
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

        If SEDataGrid.Rows(n).Cells(BodyNameCell).Value.ToString = "Sun" Then
            btnNoonSight.Visible = True
        End If

        cboBody.SelectedIndex = GetBNameIdx(SEDataGrid.Rows(n).Cells(BodyNameCell).Value.ToString)
        Dim Limb As String = SEDataGrid.Rows(n).Cells(BodyLimbCell).Value.ToString.Substring(0, 1)
        Select Case Limb
            Case "L"
                cbLimb.SelectedIndex = 0
            Case "U"
                cbLimb.SelectedIndex = 1
            Case "C"
                cbLimb.SelectedIndex = 2
            Case Else
                cbLimb.SelectedIndex = 3
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

        If SEDataGrid.Rows(n).Cells(RemarksCell).Value = vbNullString Then
            txtRemarks.Clear()
        Else
            txtRemarks.Text = SEDataGrid.Rows(n).Cells(RemarksCell).Value.ToString
        End If

        'If SEDataGrid.Rows(n).Cells(InterceptCell).Value = Nothing Or SEDataGrid.Rows(n).Cells(InterceptCell).Value = vbNullString Then
        '    txtIntZn.Clear()
        'Else
        '    txtIntZn.AppendText(" a= " & SEDataGrid.Rows(n).Cells(InterceptCell).Value.ToString & "  ")
        'End If

        If SEDataGrid.Rows(n).Cells(LLoByCell).Value = vbNullString Then
            cboLLoBy.SelectedIndex = 0
        Else
            cboLLoBy.Text = SEDataGrid.Rows(n).Cells(LLoByCell).Value.ToString
        End If

        If SEDataGrid.Rows(n).Cells(SLEP).Value = vbNullString Then
            txtSRFEP.Clear()
        Else
            txtSRFEP.Clear()
            txtSRFEP.AppendText(SEDataGrid.Rows(n).Cells(SLEP).Value.ToString)
        End If

        'If SEDataGrid.Rows(n).Cells(ZnCell).Value = vbNullString Then
        '    txtIntZn.Clear()
        'Else
        '    txtIntZn.AppendText(" a= " & SEDataGrid.Rows(n).Cells(ZnCell).Value.ToString & "  ")
        'End If

        If SEDataGrid.Rows(n).Cells(InterceptCell).Value = Nothing Or SEDataGrid.Rows(n).Cells(InterceptCell).Value = vbNullString Then
            txtIntZn.Clear()
            PlotIntercept = vbNullString
            PlotAzimuth = vbNullString
            btnUseCLS.Visible = False
            btnCustomPlot.Visible = False

        Else
            txtIntZn.Clear()
            txtIntZn.AppendText(SEDataGrid.Rows(n).Cells(InterceptCell).Value.ToString & " " & SEDataGrid.Rows(n).Cells(ZnCell).Value.ToString)
            PlotIntercept = SEDataGrid.Rows(n).Cells(InterceptCell).Value.ToString
            PlotAzimuth = SEDataGrid.Rows(n).Cells(ZnCell).Value.ToString
            btnUseCLS.Visible = True
            btnCustomPlot.Visible = True

        End If

        Dim TurnAltSROn As Integer = 0
        If SEDataGrid.Rows(n).Cells(SLGHACell).Value = Nothing Or SEDataGrid.Rows(n).Cells(SLGHACell).Value = vbNullString Then
            txtSRGHA.Clear()
        Else
            txtSRGHA.Clear()
            txtSRGHA.AppendText(SEDataGrid.Rows(n).Cells(SLGHACell).Value.ToString)
            TurnAltSROn += 1
        End If

        If SEDataGrid.Rows(n).Cells(SLDecCell).Value = Nothing Or SEDataGrid.Rows(n).Cells(SLDecCell).Value = vbNullString Then
            txtSRDec.Clear()
        Else
            txtSRDec.Clear()
            txtSRDec.AppendText(SEDataGrid.Rows(n).Cells(SLDecCell).Value.ToString)
            TurnAltSROn += 1
        End If

        If SEDataGrid.Rows(n).Cells(SLHoCell).Value = Nothing Or SEDataGrid.Rows(n).Cells(SLHoCell).Value = vbNullString Then
            txtSRHo.Clear()
        Else
            txtSRHo.Clear()
            txtSRHo.AppendText(SEDataGrid.Rows(n).Cells(SLHoCell).Value.ToString)
            TurnAltSROn += 1
        End If

        If SEDataGrid.Rows(n).Cells(UserInfoCell).Value = Nothing Or SEDataGrid.Rows(n).Cells(UserInfoCell).Value = vbNullString Then
            txtUserInfo.Clear()
        Else
            txtUserInfo.Clear()
            txtUserInfo.AppendText(SEDataGrid.Rows(n).Cells(UserInfoCell).Value.ToString)
        End If

        If TurnAltSROn = 3 Then
            btnAltSR.Visible = True
            'btnSightReduce.Visible = True
            'btnPlanSight.Visible = True

        Else
            btnAltSR.Visible = False
            'btnSightReduce.Visible = False
            'btnPlanSight.Visible = False
        End If

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
        'btnAddNew.Visible = False
        btnClearFields.Visible = True
        btnUpdateExisting.Visible = True
        btnDeleteSight.Visible = True
        btnPlanSight.Visible = True
        If CheckBoxAutoReduce.Checked = True Then
            btnSightReduce.Visible = False
        Else
            btnSightReduce.Visible = True
        End If


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
        ExecDataSaveasCSV()
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
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40 + Label1.Height

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
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf)

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
                txtHsSec.Visible = False
                lblHsSec.Visible = False
                txtIESec.Visible = False
                lblIEsec.Visible = False
            Case 1
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
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
            Case Else
                lblDistance.Visible = False
                txtHorDist.Visible = False
                cbHorDistType.Visible = False
                txtHorDist.Clear()
        End Select
        Me.Refresh()
        Exit Sub
    End Sub
    Private Shared Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub CheckBoxShowAvg_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowAvg.CheckedChanged

        If CheckBoxShowAvg.Checked = True Then
            SEDataGrid.Columns(22).Visible = True
            SEDataGrid.Columns(23).Visible = True
            SEDataGrid.Columns(24).Visible = True
            PrepareSightArray()
            BuildDGFromSightArray()
            SEDataGrid.ClearSelection()
            SEDataGrid.CurrentCell = Nothing
            SEDataGrid.Refresh()
            Me.Refresh()
        End If
        If CheckBoxShowAvg.Checked = False Then
            SEDataGrid.Columns(22).Visible = False
            SEDataGrid.Columns(23).Visible = False
            SEDataGrid.Columns(24).Visible = False
            PrepareSightArray()
            BuildDGFromSightArray()
            SEDataGrid.ClearSelection()
            SEDataGrid.CurrentCell = Nothing
            SEDataGrid.Refresh()
            Me.Refresh()

        End If
        Exit Sub
    End Sub

    Private Sub CheckBoxAutoReduce_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAutoReduce.CheckedChanged
        If CheckBoxAutoReduce.Checked = True And chkClearFields.Checked = True Then
            ErrorMsgBox("Can not set Auto Reduce On while Clear Fields is On")
            CheckBoxAutoReduce.Checked = False
            Exit Sub
        End If
        ' now the auto reduce options overrides the sight reduction button and makes it invisible at all times. 
        ' Otherwise clicking the sight reduction button with auto reduce option on cause duplicate and erroneous processing in sightlog and in SRF forms
        ' if auto reduce is set off (checked = false) and sight reduction button is not visible then set sight reduction button to visible
        If CheckBoxAutoReduce.Checked = False And btnSightReduce.Visible = False Then
            btnSightReduce.Visible = True
            Exit Sub
        End If
        ' conversely if you are setting the auto reduce option on and the sight reduction button is visible then set the sight reduction button visible off
        If CheckBoxAutoReduce.Checked = True And btnSightReduce.Visible = True Then
            btnSightReduce.Visible = False
            Exit Sub
        End If
        Exit Sub
    End Sub

    Private Sub cboBody_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBody.SelectedIndexChanged
        If cboBody.SelectedIndex > 1 Then ' index of 0 is sun and 1 is moon so upper or lower limb is okay. Anything else limb must be set to center
            cbLimb.SelectedIndex = 0 ' default to lower limb for objects other than sun or moon
            cbLimb.Visible = False ' but hide limb for those objects other than sun and moon
            lblLimb.Visible = False
        Else
            cbLimb.Visible = True
            lblLimb.Visible = True
        End If
        Me.Refresh()

    End Sub

    Private Sub chkbxDST_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxDST.CheckedChanged
        'If chkbxDST.Checked = True Then
        '    MasterDST = True
        'Else
        '    MasterDST = False
        'End If

    End Sub

    Private Sub ChkClearFields_CheckedChanged(sender As Object, e As EventArgs) Handles chkClearFields.CheckedChanged
        If CheckBoxAutoReduce.Checked = True And chkClearFields.Checked = True Then
            ErrorMsgBox("Can not set Clear Fields On while Auto Reduce is On")
            chkClearFields.Checked = False
        End If
        Exit Sub
    End Sub

    Private Sub BtnAltSR_Click(sender As Object, e As EventArgs) Handles btnAltSR.Click
        PerformAltSR()
        Exit Sub
    End Sub

    Private Sub ChkDispGHADecHo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDispGHADecHo.CheckedChanged
        If chkDispGHADecHo.Checked = True Then
            SEDataGrid.Columns(SLGHACell).Visible = True
            SEDataGrid.Columns(SLDecCell).Visible = True
            SEDataGrid.Columns(SLHoCell).Visible = True
            PrepareSightArray()
            BuildDGFromSightArray()
            SEDataGrid.ClearSelection()
            SEDataGrid.CurrentCell = Nothing
            SEDataGrid.Refresh()
            Me.Refresh()
        Else
            SEDataGrid.Columns(SLGHACell).Visible = False
            SEDataGrid.Columns(SLDecCell).Visible = False
            SEDataGrid.Columns(SLHoCell).Visible = False
            PrepareSightArray()
            BuildDGFromSightArray()
            SEDataGrid.ClearSelection()
            SEDataGrid.CurrentCell = Nothing
            SEDataGrid.Refresh()
            Me.Refresh()
        End If
    End Sub
    Private Sub ExitSRFandAltSR()
        If FormSRFLoaded = True Then
            FormSRF.ExitBtn.PerformClick()
            FormSRFLoaded = False
        End If
        If FormAltSRLoaded = True Then
            FormAltSR.ExitBtn.PerformClick()
            FormAltSRLoaded = False
        End If
        If FormNoonSightLoaded = True Then
            FormNoonSight.ExitNoonSight.PerformClick()
            FormNoonSightLoaded = False
        End If
        If CheckOpenWinForms("ZTInfo") = True Then
            ZTInfo.ExitBtn.PerformClick()
        End If
        Exit Sub
    End Sub

    Private Sub btnNoonSight_Click(sender As Object, e As EventArgs) Handles btnNoonSight.Click
        PerformNoonSight()
        Exit Sub
    End Sub
    Private Sub PerformNoonSight()
        If CheckOpenWinForms("FormNoonSight") = True Then
            FormNoonSightLoaded = True
            FormNoonSight.ClearScrBtn.PerformClick()
            FormNoonSight.SetDesktopLocation(5, 5) '
            FormNoonSight.BringToFront()
        Else
            FormNoonSightLoaded = False
            FormNoonSight.Show()
            FormNoonSight.SetDesktopLocation(5, 5) '
            FormNoonSightLoaded = True
        End If

        FormNoonSight.InvokedBySightLog = True
        Dim DTHr As String = Strings.Format(SightDateTime.Value.Hour, "00")
        Dim DTMin As String = Strings.Format(SightDateTime.Value.Minute, "00")
        Dim DTSec As String = Strings.Format(SightDateTime.Value.Second, "00")
        Dim DTYear As String = Strings.Format(SightDateTime.Value.Year, "0000")
        FormNoonSight.DTNoonSight.Value = SightDateTime.Value
        'FormNoonSight.txtTime.Text = DTHr & DTMin & DTSec

        ' by default FormSRF SRF sets ZD to auto calc from Long - only change to manual if ZD Minutes is nonzero then select Manual Calc option
        If cboZD.SelectedIndex = ZDInitIdx Then
            FormNoonSight.optZDAuto.Checked = True
        Else
            FormNoonSight.optZDManual.Checked = True

            Dim ZDHours As Integer = GetZDHour(cboZD.Items(cboZD.SelectedIndex).ToString)
            Dim ZDMin As Integer = GetZDMin(cboZD.Items(cboZD.SelectedIndex).ToString)
            FormNoonSight.txtZDh.Text = ZDHours.ToString
            Select Case ZDMin
                Case 30
                    FormNoonSight.cboZDm.SelectedIndex = 1
                    FormNoonSight.optZDManual.Checked = True
                Case 45
                    FormNoonSight.cboZDm.SelectedIndex = 2
                    FormNoonSight.optZDManual.Checked = True
                Case Else
                    FormNoonSight.cboZDm.SelectedIndex = 0
            End Select
        End If


        If chkbxDST.Checked = True Then
            FormNoonSight.chkDST.Checked = True
        Else
            FormNoonSight.chkDST.Checked = False
        End If

        Select Case cbLimb.SelectedIndex
            Case 0
                FormNoonSight.optLower.Checked = True
            Case 1
                FormNoonSight.optUpper.Checked = True
            Case 2
                FormNoonSight.optCenter.Checked = True
            Case Else
                FormNoonSight.optLower.Checked = True
        End Select

        FormNoonSight.txtLoDeg.Text = txtLoDeg.Text
        FormNoonSight.txtLoMin.Text = txtLoMin.Text
        Select Case cboLo.SelectedIndex
            Case 0
                FormNoonSight.cboLo.SelectedIndex = 0
            Case 1
                FormNoonSight.cboLo.SelectedIndex = 1
        End Select

        FormNoonSight.optDRL.Checked = True
        FormNoonSight.txtDRLDeg.Text = txtLDeg.Text
        FormNoonSight.txtDRLMin.Text = txtLMin.Text
        Select Case cboL.SelectedIndex
            Case 0
                FormNoonSight.cboDRL.SelectedIndex = 0
            Case 1
                FormNoonSight.cboDRL.SelectedIndex = 1
        End Select

        FormNoonSight.txtHE.Text = txtHE.Text
        FormNoonSight.cboHE.SelectedIndex = cboHEUnit.SelectedIndex

        FormNoonSight.txtDsDist.Text = txtHorDist.Text
        Select Case cbHorDistType.SelectedIndex
            Case 0
                FormNoonSight.cboDsUnit.SelectedIndex = 0
            Case 1
                FormNoonSight.cboDsUnit.SelectedIndex = 1
            Case 2
                FormNoonSight.cboDsUnit.SelectedIndex = 2
            Case 3
                FormNoonSight.cboDsUnit.SelectedIndex = 3
            Case 4
                FormNoonSight.cboDsUnit.SelectedIndex = 4
        End Select

        If cboHSIEFmt.SelectedIndex = 1 Then
            FormNoonSight.optHsDMS.Checked = True
        Else
            FormNoonSight.optHsDMm.Checked = True
        End If

        FormNoonSight.txtIEdeg.Text = txtIEDeg.Text
        FormNoonSight.txtIEmin.Text = txtIE.Text
        If cboHSIEFmt.SelectedIndex = 1 Then
            FormNoonSight.txtIESec.Text = txtIESec.Text
        End If
        Select Case cbIEType.SelectedIndex
            Case 0
                FormNoonSight.cboIE.SelectedIndex = 0
            Case 1
                FormNoonSight.cboIE.SelectedIndex = 1
        End Select

        FormNoonSight.txtHsDeg.Text = txtHSDeg.Text
        FormNoonSight.txtHsMin.Text = txtHSMin.Text
        If cboHSIEFmt.SelectedIndex = 1 Then
            FormNoonSight.txtHsSec.Text = txtHsSec.Text
        End If

        Select Case cbHorizon.SelectedIndex
            Case 0
                FormNoonSight.optHorizonNatural.Checked = True
            Case 1
                FormNoonSight.optHorizonDipShort.Checked = True
            Case 2
                FormNoonSight.optHorizonArtificial.Checked = True
            Case 3
                FormNoonSight.optHorizonBubble.Checked = True
            Case Else
                FormNoonSight.optHorizonNatural.Checked = True
        End Select
        FormNoonSight.txtUserInfo.Text = Me.txtUserInfo.Text
        FormNoonSight.cmdLAN.PerformClick()
        FormNoonSight.cmdNoonSight.PerformClick()
        FormNoonSight.BringToFront()
        Exit Sub
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

    Private Sub btnUseCLS_Click(sender As Object, e As EventArgs) Handles btnUseCLS.Click
        'If CheckOpenWinForms("CLSForm") = True Then
        'CLSForm.ExitBtn.PerformClick()
        'End If
        PlotOut.PsnName = txtName.Text
        PlotOut.SquadronName = txtSquadron.Text
        PlotOut.PlotType = "Sight"
        PlotOut.PlotNumber = txtSightNum.Text
        PlotOut.PlotDT = SightDateTime.Value
        PlotOut.PlotBody = cboBody.Items(cboBody.SelectedIndex).ToString
        PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60.0)
        PlotOut.PlotLatDeg = txtLDeg.Text
        PlotOut.PlotLatMin = txtLMin.Text
        PlotOut.PlotLatSec = "0"
        PlotOut.PlotLatNS = cboL.Items(cboL.SelectedIndex).ToString

        PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + (Convert.ToDouble(txtLoMin.Text) / 60.0)
        PlotOut.PlotLongDeg = txtLoDeg.Text
        PlotOut.PlotLongMin = txtLoMin.Text
        PlotOut.PlotLongSec = "0"
        PlotOut.PlotLongEW = cboLo.Items(cboLo.SelectedIndex).ToString

        PlotOut.PlotAz = PlotAzimuth
        PlotOut.PlotIntercept = PlotIntercept

        PlotOut.PlotSLEP = txtSRFEP.Text.ToString
        PlotOut.PlotLLoBy = cboLLoBy.Text.ToString
        PlotOut.PlotExtendedLines = False
        CLSForm.AddPlotEntry(PlotOut)
        CLSForm.txtUserInfo.Text = Me.txtUserInfo.Text
        If CLSForm.PlotSight() = True Then
            CLSForm.Show()
            CLSForm.SetDesktopLocation(5, 5) '(Me.Location.X - 40, Me.Location.Y - 40)
            CLSForm.BringToFront()
        Else
            'If CheckOpenWinForms("CLSForm") = True Then
            'CLSForm.ExitBtn.PerformClick()
            'End If
        End If

        Exit Sub
    End Sub

    Private Sub SightLog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If CheckOpenWinForms("CLSForm") = True Then
            CLSForm.ExitBtn.PerformClick()
        End If
    End Sub

    Private Sub btnCustomPlot_Click(sender As Object, e As EventArgs) Handles btnCustomPlot.Click
        'If CheckOpenWinForms("CLSForm") = True Then
        'CLSForm.ExitBtn.PerformClick()
        'End If
        PlotOut.PsnName = txtName.Text
        PlotOut.SquadronName = txtSquadron.Text
        PlotOut.PlotType = "Sight"
        PlotOut.PlotNumber = txtSightNum.Text
        PlotOut.PlotDT = SightDateTime.Value
        PlotOut.PlotBody = cboBody.Items(cboBody.SelectedIndex).ToString
        PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60.0)
        PlotOut.PlotLatDeg = txtLDeg.Text
        PlotOut.PlotLatMin = txtLMin.Text
        PlotOut.PlotLatSec = "0"
        PlotOut.PlotLatNS = cboL.Items(cboL.SelectedIndex).ToString

        PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + (Convert.ToDouble(txtLoMin.Text) / 60.0)
        PlotOut.PlotLongDeg = txtLoDeg.Text
        PlotOut.PlotLongMin = txtLoMin.Text
        PlotOut.PlotLongSec = "0"
        PlotOut.PlotLongEW = cboLo.Items(cboLo.SelectedIndex).ToString

        PlotOut.PlotAz = PlotAzimuth
        PlotOut.PlotIntercept = PlotIntercept

        PlotOut.PlotSLEP = txtSRFEP.Text.ToString
        PlotOut.PlotLLoBy = cboLLoBy.Text.ToString
        PlotOut.PlotExtendedLines = False

        CustomPlot.AddPlotEntry(PlotOut)
        CustomPlot.txtUserInfo.Text = Me.txtUserInfo.Text
        If CustomPlot.PlotSight() = True Then
            CustomPlot.Show()
            CustomPlot.SetDesktopLocation(5, 5) '
            CustomPlot.BringToFront()
        Else
            'If CheckOpenWinForms("CustomPlot") = True Then
            'CustomPlot.ExitBtn.PerformClick()
            'End If
        End If

        Exit Sub
    End Sub

    Private Sub btnPlanSight_Click(sender As Object, e As EventArgs) Handles btnPlanSight.Click
        If CheckOpenWinForms("FormSightPlan") = True Then
            FormNoonSightLoaded = True
            'FormSightPlan.ClearScrBtn.PerformClick()
            FormNoonSight.SetDesktopLocation(5, 5) '
            FormSightPlan.BringToFront()
        Else
            FormNoonSightLoaded = False
            FormSightPlan.Show()
            FormNoonSight.SetDesktopLocation(5, 5) '
            FormNoonSightLoaded = True
        End If

        'FormSightPlan.InvokedBySightLog = True
        Dim DTHr As String = Strings.Format(SightDateTime.Value.Hour, "00")
        Dim DTMin As String = Strings.Format(SightDateTime.Value.Minute, "00")
        Dim DTSec As String = Strings.Format(SightDateTime.Value.Second, "00")
        Dim DTYear As String = Strings.Format(SightDateTime.Value.Year, "0000")
        FormSightPlan.DTPlan.Value = SightDateTime.Value
        'FormSightPlan.txtTime.Text = DTHr & DTMin & DTSec

        ' by default FormSRF SRF sets ZD to auto calc from Long - only change to manual if ZD Minutes is nonzero then select Manual Calc option
        If cboZD.SelectedIndex = ZDInitIdx Then
            FormSightPlan.optZDAuto.Checked = True
        Else
            FormSightPlan.optZDManual.Checked = True

            Dim ZDHours As Integer = GetZDHour(cboZD.Items(cboZD.SelectedIndex).ToString)
            Dim ZDMin As Integer = GetZDMin(cboZD.Items(cboZD.SelectedIndex).ToString)
            FormSightPlan.txtZDh.Text = ZDHours.ToString
            Select Case ZDMin
                Case 30
                    FormSightPlan.cboZDm.SelectedIndex = 1
                    FormSightPlan.optZDManual.Checked = True
                Case 45
                    FormSightPlan.cboZDm.SelectedIndex = 2
                    FormSightPlan.optZDManual.Checked = True
                Case Else
                    FormSightPlan.cboZDm.SelectedIndex = 0
            End Select
        End If


        If chkbxDST.Checked = True Then
            FormSightPlan.chkDST.Checked = True
        Else
            FormSightPlan.chkDST.Checked = False
        End If

        FormSightPlan.txtLoDeg.Text = txtLoDeg.Text
        FormSightPlan.txtLoMin.Text = txtLoMin.Text
        Select Case cboLo.SelectedIndex
            Case 0
                FormSightPlan.cboLo.SelectedIndex = 0
            Case 1
                FormSightPlan.cboLo.SelectedIndex = 1
        End Select

        FormSightPlan.txtLDeg.Text = txtLDeg.Text
        FormSightPlan.txtLMin.Text = txtLMin.Text
        Select Case cboL.SelectedIndex
            Case 0
                FormSightPlan.cboL.SelectedIndex = 0
            Case 1
                FormSightPlan.cboL.SelectedIndex = 1
        End Select

        FormSightPlan.txtUserInfo.Text = Me.txtUserInfo.Text
        FormSightPlan.cmdTwilights.PerformClick()
        FormSightPlan.BringToFront()
        Exit Sub
    End Sub

    Private Sub btnSaveLogAsTxt_Click(sender As Object, e As EventArgs) Handles btnSaveLogAsTxt.Click
        ExecDataSaveasTXT()
    End Sub
    Private Sub ExecDataSaveasTXT()
        Dim i As Integer = 0
        Dim iCnt As Integer = 0
        Dim SE As SightEntry = New SightEntry
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        For i = 0 To UBound(SightLogArray)
            SE = SightLogArray(i)
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
        Dim SLReportFname As String = SLOpenFName.Replace(".txt", "SLTextFile.txt")
        saveFileDialog1.InitialDirectory = "./DeckLog/"
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        saveFileDialog1.Title = "Save Sight Log File as Formatted Text File"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = SLReportFname
        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFileDialog1.FileName = vbNullString Then
                Exit Sub
            End If
            SLReportFname = saveFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim textstr As New System.Text.StringBuilder()
        'Dim FileHdrStr As String = vbNullString
        'For idx As Integer = 0 To UBound(HdrStr)
        '    If idx > 0 Then
        '        textstr.Append("," & vbTab)
        '    End If
        '    textstr.Append(HdrStr(idx))
        'Next)
        'textstr.AppendLine()
        For i = 0 To UBound(SightLogArray)
            If SightLogArray(i).EntryStatus = "Active" Then
                textstr.Append(FormatSightForPrint(SightLogArray(i)))
                textstr.AppendLine()
            End If
        Next
        'For x As Integer = 0 To SEDataGrid.Rows.Count - 1
        '    If IsNothing(SEDataGrid.Rows(x).Cells(0).Value) = False Then
        '        For v As Integer = 0 To SEDataGrid.Columns.Count - 8
        '            'extracting cell value from 0 to 9 and add it on list
        '            If v > 0 Then
        '                textstr.Append("," & vbTab)
        '            End If
        '            Dim tempstr As String = SEDataGrid.Rows(x).Cells(v).Value.ToString()
        '            tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
        '            textstr.Append(tempstr)
        '        Next
        '    End If
        '    'adding new line to text
        '    textstr.AppendLine()
        'Next
        IO.File.WriteAllText(SLReportFname, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"))
        Exit Sub
    End Sub

    Private Shared Function FormatSightForPrint(ByVal SE As SightEntry) As String
        Dim SaveStr As String = vbNullString
        Dim StrParm As String = Space(3)
        Dim SepLine As String = "__________________________________________________________________________________________"
        SaveStr = 'SepLine & vbNewLine &
            "Sight # = " & SE.SightNum & StrParm &
            "Body = " & SE.BodyName & StrParm &
            "Limb = " & SE.BodyLimb & StrParm &
            "Lat = " & SE.DRLat & StrParm &
            "Long = " & SE.DRLong & StrParm &
            "L/Lo By = " & SE.LLoBy & vbNewLine &
            "Date/Zone Time = " & SE.SightDateTime.ToString("MM/dd/yyyy HH:mm:ss") & StrParm &
            "DST = " & SE.DST & StrParm &
            "ZD = " & SE.ZD & StrParm & StrParm &
            "WE = " & SE.WE & " " & SE.WEType & vbNewLine &
            "HS = " & SE.HS & StrParm &
            "ApprxBrg=" & SE.ApprxBrg & StrParm &
            "IC = " & SE.IC & " " & SE.ICType & StrParm &
            "HE = " & SE.HE & StrParm &
            "Horizon = " & SE.HorType & StrParm
        If SE.HorType = "Dip Short" Then
            SaveStr &= "Dip Short = " & SE.HorDist & " " & SE.HorDistType
        End If
        SaveStr &= vbNewLine &
            "SR Intercept = " & SE.Intercept & StrParm &
            "SR Azimuth = " & SE.Zn & StrParm &
            "SR EP = " & SE.EP & vbNewLine &
            "SR GHA = " & SE.SRGHA & StrParm & "SR Dec = " & SE.SRDec & StrParm & "SR Ho = " & SE.SRHo & vbNewLine &
            "Name = " & SE.SLName & StrParm &
            "Squadron = " & SE.SLSquadron
        If SE.WTDiff <> "" Then
            SaveStr &= vbNewLine & "WT Diff = " & SE.WTDiff & StrParm & "hs Diff = " & SE.HSDiff & StrParm & "hs/WT = " & SE.HSWTRate
        End If
        If SE.Remarks <> "" Then
            SaveStr &= vbNewLine & "Remarks=" & SE.Remarks
        End If
        If SE.UserInfo <> "" Then
            SaveStr &= vbNewLine & "UserInfo=" & SE.UserInfo
        End If

        SaveStr &= vbNewLine
        Return SaveStr
        Exit Function
    End Function

    'Private Sub chkUseZTInfo_CheckedChanged(sender As Object, e As EventArgs)
    '    If chkUseZTInfo.Checked = True Then
    '        ZTInfo.UpdateSLDST = True
    '    Else
    '        ZTInfo.UpdateSLDST = False
    '        If CheckOpenWinForms("ZTInfo") = True Then
    '            ZTInfo.ExitBtn.PerformClick()
    '        End If
    '    End If
    'End Sub
End Class