Option Strict Off
Option Explicit On
Friend Class FormDevTable_frm
    Inherits System.Windows.Forms.Form

    Public fnumeral As String
    Public i As Short
    Public DevValue(8) As String ', D(8) As Variant
    Public Dev(8) As Integer
    Public D1(8) As TextBox '= {_D_0, _D_1, _D_2, _D_3, _D_4, _D_5, _D_6, _D_7}
    Public txtM1(8) As TextBox '= {_txtM_0, _txtM_1, _txtM_2, _txtM_3, _txtM_4, _txtM_5, _txtM_6, _txtM_7}
    Public txtEW1(8) As TextBox '= {_txtEW_0, _txtEW_1, _txtEW_2, _txtEW_3, _txtEW_4, _txtEW_5, _txtEW_6, _txtEW_7}
    Public txtC1(8) As TextBox '= {_txtC_0, _txtC_1, _txtC_2, _txtC_3, _txtC_4, _txtC_5, _txtC_6, _txtC_7}
    Public FileOpenChk As Boolean = False
    Public FormDevTable_frmOpen As Boolean = False
    Public SLDir As String = "./DeviationTbl/"
    Public SLDefName As String = "Deviation_Table.txt" '& Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
    Public SLOpenFName As String = SLDir & SLDefName
    'Public SLDefNameDG As String = "DeviationDG_Table.txt" '& Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
    'Public SLOpenFNameDG As String = SLDir & SLDefNameDG
    Public Index As Integer = 0
    Public ClearingFields As Boolean = False
    'Public DataSet2 As DataSet = New DataSet
    Public CellHasChg As Boolean = False
    Public CellRowIdxChg As Integer = 0
    'Public FlagMChange As Boolean

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub FormDevTable_frm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        FileOpenChk = False
        Dim InitMag As Integer = 0
        D1 = {_D_0, _D_1, _D_2, _D_3, _D_4, _D_5, _D_6, _D_7}
        txtM1 = {_txtM_0, _txtM_1, _txtM_2, _txtM_3, _txtM_4, _txtM_5, _txtM_6, _txtM_7}
        txtEW1 = {_txtEW_0, _txtEW_1, _txtEW_2, _txtEW_3, _txtEW_4, _txtEW_5, _txtEW_6, _txtEW_7}
        txtC1 = {_txtC_0, _txtC_1, _txtC_2, _txtC_3, _txtC_4, _txtC_5, _txtC_6, _txtC_7}
        ClearingFields = True
        For i = 0 To 7
            DevValue(i) = vbNullString
            txtM1(i).Clear()
            D1(i).Clear()
            txtEW1(i).Clear()
            txtM1(i).Text = Strings.Format("##0", InitMag.ToString)
            InitMag += 45
        Next i

        'Dim DevHdr As String() = {"Compass", "Magnetic", "Deviation"}
        'Dim DataSet1 As DataSet = New DataSet()
        'DataSet2.Tables.Add("Table1")
        'DataSet2.DataSetName = "Table1"
        'DGDev.DataSource = DataSet1
        'For i As Integer = 0 To UBound(DevHdr)
        '    DataSet2.Tables("Table1").Columns.Add(DevHdr(i))
        '    DataSet2.Tables("Table1").Columns(i).AllowDBNull = False
        '    DataSet2.Tables("Table1").Columns(i).DefaultValue = ""
        'Next
        'DGDev.DataSource = DataSet2.Tables(0).DefaultView
        'For i As Integer = 0 To DGDev.Columns.Count - 1
        '    DGDev.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        '    DGDev.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    DGDev.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'Next
        'DGDev.Columns(0).ReadOnly = True
        'DGDev.Columns(2).ReadOnly = True
        'DGDev.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ''DGDev.DefaultCellStyle.SelectionBackColor = DGDev.DefaultCellStyle.BackColor
        ''DGDev.DefaultCellStyle.SelectionForeColor = DGDev.DefaultCellStyle.ForeColor
        'DGDev.Columns(0).MinimumWidth = 15
        'DGDev.Columns(1).MinimumWidth = 15
        'DGDev.Columns(2).MinimumWidth = 15
        'Dim Compass As Integer = 0
        'For i As Integer = 0 To 8
        '    DataSet2.Tables("Table1").Rows.Add(Compass, Compass, "0 W")
        '    Compass += 45
        'Next
        'DGDev.Rows(8).Cells(1).ReadOnly = True

        ClearingFields = False
        ReadDevTblFile()
        FileOpenChk = True
        FormDevTable_frmOpen = True
        FormTVMDC.FormDevTable_frmHasOpenedForBusiness = True
        Exit Sub

    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        ' Confirm is Clear is really requested
        If System.Windows.Forms.MessageBox.Show("Clear All Deviation Entries - Are you sure? Yes / No ?", "Clear Entries?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button2,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.No Then
            Exit Sub
        End If
        ' Clear all entries in Dev Table
        Dim InitMag As Integer = 0
        ClearingFields = True
        For i = 0 To 7
            txtM1(i).Clear()
            D1(i).Clear()
            txtEW1(i).Clear()
            txtM1(i).Text = Strings.Format("##0", InitMag.ToString)
            InitMag += 45
        Next i
        ClearingFields = False
    End Sub

    Private Sub Save()
        If FileOpenChk = False Then
            Exit Sub
        End If

        Dim objWriter As New System.IO.StreamWriter(SLOpenFName, False)
        i = 0
        For i = 0 To 7
            objWriter.WriteLine(txtM1(i).Text)
        Next
        objWriter.Close()
        'objWriter.Dispose()
        FileOpenChk = False
        Exit Sub
    End Sub

    Private Sub txtM_TextChanged()
        'Dim Index As Integer = txtM1.GetIndex(eventSender)
        Dim TryInt As Integer = 0
        txtM1(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Integer.TryParse(txtM1(Index).Text, TryInt) Then
            If TryInt > 359 Then
                txtM1(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                ErrorMsgBox("Dev Mag Value too large - must be 0 to 359")
                Beep()
            End If
        Else
            txtM1(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Dev Mag Value Must an Integer between 0 to 359")
            Beep()
        End If
        Deviation(Index)
        D1(Index).Text = CStr(System.Math.Abs(Dev(Index)))
        If CDbl(D1(Index).Text) > 7 Then
            txtM1(Index).BackColor = System.Drawing.Color.Yellow
        Else
            txtM1(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        If Dev(Index) < 0 Then Me.txtEW1(Index).Text = g_LongE Else Me.txtEW1(Index).Text = g_LongW
        Exit Sub
    End Sub


    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub
    Private Sub FormDevTable_frm_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CloseFormDevTable_frm()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        CloseFormDevTable_frm()
    End Sub
    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        Save()
        MessageBox.Show("Data saved to " & SLOpenFName.ToString & " file")
        Exit Sub
    End Sub
    Public Sub CloseFormDevTable_frm()
        If FormDevTable_frmOpen = True Then
            Save()
            FormDevTable_frmOpen = False
            FormTVMDC.FormDevTable_frmHasOpenedForBusiness = False
            FormTVMDC.chkDev.CheckState = System.Windows.Forms.CheckState.Unchecked
            Me.Close()
        End If

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
    Private Sub ReadDevTblFile()
        Dim SLFName As String = vbNullString

        Dim ReadError As Boolean = False
        Dim FileLoading As Boolean = False

        Dim myStream As System.IO.StreamReader = Nothing
        Dim rdline As String = vbNullString
        ReadError = False
        FileLoading = True
        Try
            myStream = New System.IO.StreamReader(SLOpenFName)
            If (myStream IsNot Nothing) Then

                i = 0
                Do While myStream.Peek() <> -1
                    rdline = myStream.ReadLine()
                    If rdline <> vbNullString Then
                        DevValue(i) = rdline
                        txtM1(i).Text = DevValue(i)
                        i += 1
                        rdline = vbNullString
                    End If
                Loop
                myStream.Close()

            End If
            myStream.Dispose()
            FileLoading = False
            Exit Sub
        Catch Ex As Exception
            ErrorMsgBox("Dev Table Form will be closed - Cannot read Dev Table file from disk. Original error: " & Ex.Message)
        Finally
            ' Check this again, since we need to make sure we didn't throw an exception on open.
            If (myStream IsNot Nothing) Then
                myStream.Close()
            End If
            CloseFormDevTable_frm()

        End Try
            'End If
            Exit Sub

    End Sub

    Private Sub _txtM_0_TextChanged(sender As Object, e As EventArgs) Handles _txtM_0.TextChanged
        If ClearingFields = True Then Exit Sub
        Index = 0
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_1_TextChanged(sender As Object, e As EventArgs) Handles _txtM_1.TextChanged
        If ClearingFields = True Then Exit Sub
        Index = 1
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_2_TextChanged(sender As Object, e As EventArgs) Handles _txtM_2.TextChanged
        If ClearingFields = True Then Exit Sub
        Index = 2
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_3_TextChanged(sender As Object, e As EventArgs) Handles _txtM_3.TextChanged
        Index = 3
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_4_TextChanged(sender As Object, e As EventArgs) Handles _txtM_4.TextChanged
        Index = 4
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_5_TextChanged(sender As Object, e As EventArgs) Handles _txtM_5.TextChanged
        If ClearingFields = True Then Exit Sub
        Index = 5
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_6_TextChanged(sender As Object, e As EventArgs) Handles _txtM_6.TextChanged
        If ClearingFields = True Then Exit Sub
        Index = 6
        txtM_TextChanged()
    End Sub

    Private Sub _txtM_7_TextChanged(sender As Object, e As EventArgs) Handles _txtM_7.TextChanged
        If ClearingFields = True Then Exit Sub
        Index = 7
        txtM_TextChanged()
    End Sub
    Public Sub Deviation(ByRef Index As Integer)
        Dev(Index) = Val(Me.txtC1(Index).Text) - Val(Me.txtM1(Index).Text)
        If Index = 0 And Val(Me.txtM1(Index).Text) > 180 Then
            Dev(Index) = (360 - Math.Abs(Dev(Index)))      'added in V5.6.1
        End If
        Dev(8) = Dev(0)
    End Sub

    'Private Sub DGDev_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

    '    If EditDGCellChg(e.RowIndex) = True Then
    '        Exit Sub
    '    End If
    '    Exit Sub
    'End Sub

    'Private Sub DGDev_CellLeave(sender As Object, e As DataGridViewCellEventArgs)

    'End Sub
    'Private Function EditDGCellChg(ByVal Idx As Integer) As Boolean
    '    Dim TryInt As Integer = 0
    '    If Integer.TryParse(DGDev.Rows(Idx).Cells(1).Value, TryInt) Then
    '        If TryInt > 359 Then
    '            DGDev.Rows(Idx).Cells(1).Selected = True
    '            ErrorMsgBox("Magnetic Heading Value too large - must be 0 to 359")
    '            Beep()
    '            Return False
    '        End If
    '    Else
    '        DGDev.Rows(Idx).Cells(1).Selected = True
    '        ErrorMsgBox("Magnetic Heading Value Must an Integer between 0 to 359")
    '        Beep()
    '        Return False
    '    End If
    '    If Idx = 0 And TryInt > 180 Then
    '        TryInt = 360 - TryInt
    '    End If
    '    Dim tempdev As Integer = Convert.ToInt32(DGDev.Rows(Idx).Cells(0).Value) - TryInt
    '    If Index = 0 And tempdev > 180 Then
    '        tempdev = (360 - Math.Abs(tempdev))     'added in V5.6.1
    '    End If
    '    Dim tempdevew As String
    '    If tempdev < 0 Then
    '        tempdevew = g_LongE
    '    Else
    '        tempdevew = g_LongW
    '    End If
    '    DGDev.Rows(Idx).Cells(2).Value = System.Math.Abs(tempdev).ToString("#0") & tempdevew

    '    If Idx = 0 Then
    '        DGDev.Rows(8).Cells(2).Value = DGDev.Rows(Idx).Cells(2).Value
    '        DGDev.Rows(8).Cells(1).Value = DGDev.Rows(Idx).Cells(1).Value
    '        DGDev.Rows(8).Cells(1).ReadOnly = True
    '    End If
    '    Return True
    'End Function
End Class