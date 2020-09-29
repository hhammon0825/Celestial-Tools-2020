Public Class HelpV2

    Public Structure CTHelpFile
        Public ScrIdx As Integer
        Public ScrnName As String
        Public HelpFileName As String
    End Structure
    Public HelpScrnTbl() As CTHelpFile
    Public LDFname As String

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub LoadTextFiletoTxtBx(ByVal FName As String, ByRef TxtBx As RichTextBox)
        TxtBx.Clear()

        Dim streamToPrint As IO.StreamReader
        Dim line As String = Nothing
        Try
            streamToPrint = New IO.StreamReader(FName)
            Try
                line = streamToPrint.ReadLine()
                While line IsNot Nothing
                    TxtBx.AppendText(line & vbNewLine)
                    line = streamToPrint.ReadLine()
                End While
            Finally
                streamToPrint.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub HelpV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim HelpScrnTbl(21)
        HelpScrnTbl(0) = InitHSTbl(0, "General Celestial Tools", "GeneralTxtBx.txt")
        HelpScrnTbl(1) = InitHSTbl(1, "Sight Planning", "SightPlanTxtBx.txt")
        HelpScrnTbl(2) = InitHSTbl(2, "Sight Reduction And Fix (SRF)", "SRFixTxtBx.txt")
        HelpScrnTbl(3) = InitHSTbl(3, "Noon Sight Planning", "NoonSightTxtBx.txt")
        HelpScrnTbl(4) = InitHSTbl(4, "Alternate Sight Reduction Methods", "SRMethodsTxtBx.txt")
        HelpScrnTbl(5) = InitHSTbl(5, "Sight Log", "SightLogTxtBx.txt")
        HelpScrnTbl(6) = InitHSTbl(6, "Shared Locations", "SharedLocsTxtBx.txt")
        HelpScrnTbl(7) = InitHSTbl(7, "I&C Yellow Pages", "YellowPagesTxtBx.txt")
        HelpScrnTbl(8) = InitHSTbl(8, "Arc Time", "ArcTimeTxtBx.txt")
        HelpScrnTbl(9) = InitHSTbl(9, "Navigational Math", "NavMathTxtBx.txt")
        HelpScrnTbl(10) = InitHSTbl(10, "Degree Length", "DegLenTxtBx.txt")
        HelpScrnTbl(11) = InitHSTbl(11, "Sailings", "SailingxTxtBx.txt")
        HelpScrnTbl(12) = InitHSTbl(12, "60 DST", "SixtyDSTTxtBx.txt")
        HelpScrnTbl(13) = InitHSTbl(13, "TVMDC", "TVMDCTxtBx.txt")
        HelpScrnTbl(14) = InitHSTbl(14, "Maneuvering Board", "MoBoardTxtBx.txt")
        HelpScrnTbl(15) = InitHSTbl(15, "2/3 Bearings", "BearingsTxtBx.txt")
        HelpScrnTbl(16) = InitHSTbl(16, "Wind And Current", "WindCurrTxtBx.txt")
        HelpScrnTbl(17) = InitHSTbl(17, "Distances", "DistantcesTxtBx.txt")
        HelpScrnTbl(18) = InitHSTbl(18, "Tides", "TidesTxtBx.txt")
        HelpScrnTbl(19) = InitHSTbl(19, "Currents", "CurrentsTxtBx.txt")
        HelpScrnTbl(20) = InitHSTbl(20, "CLS Plot", "CLSPlotFormTxtBx.txt")
        HelpScrnTbl(21) = InitHSTbl(21, "Custom Plot", "CustomPlotFormTxtBx.txt")


        For idx As Integer = 0 To UBound(HelpScrnTbl)
            cboHelpList.Items.Add(HelpScrnTbl(idx).ScrnName)
        Next
        cboHelpList.SelectedIndex = 0
    End Sub
    Public Function InitHSTbl(ScrIdx As Integer, ScrNm As String, HFName As String) As CTHelpFile
        Dim rtn As CTHelpFile
        rtn.ScrIdx = ScrIdx
        rtn.ScrnName = ScrNm
        rtn.HelpFileName = HFName
        Return rtn
    End Function

    Private Sub cboHelpList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHelpList.SelectedIndexChanged
        Dim idx As Integer = cboHelpList.SelectedIndex
        LDFname = ".\HelpFiles\" & HelpScrnTbl(idx).HelpFileName.ToString
        LoadTextFiletoTxtBx(LDFname, txtHelpInfo)
    End Sub

    Private Sub btnPrintThisInfo_Click(sender As Object, e As EventArgs) Handles btnPrintThisInfo.Click
        printTxtFile1(LDFname)
    End Sub
End Class