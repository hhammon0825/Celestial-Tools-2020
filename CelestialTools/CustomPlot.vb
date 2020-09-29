Imports System.Drawing.Configuration
Imports System.Net.Http.Headers
Imports System.Runtime.CompilerServices
Imports System.Windows
Imports Microsoft.VisualBasic.Devices

Public Class CustomPlot
    Private OneNmPixels As Integer = 0
    'Private DefaultPixels As Double = 11
    Private OneNMLongPixels As Integer = 0
    Private NMSizeonSide As Integer = 0
    Private ReadOnly ToRad As Double = System.Math.PI / 180
    Private ReadOnly ToDeg As Double = 180 / System.Math.PI
    Private MidX As Integer
    Private MidY As Integer
    Private BottomY As Integer
    Private BottomX As Integer
    Private BottomCenter As Point
    Private CenterofPlot As Point
    Private LeftX As Integer
    Private RightX As Integer
    Private TopY As Integer
    Private TopX As Integer

    Private ULLat As Double
    Private ULLong As Double
    Private URLat As Double
    Private URLong As Double
    Private LLLat As Double
    Private LLLong As Double
    Private LRLat As Double
    Private LRLong As Double

    Private ReadOnly myPen As New Pen(Color.Black, 2)
    Private ReadOnly DPen As Pen = New Pen(Color.Black, 1)
    Private ReadOnly CompRosePen As Pen = New Pen(Color.DarkBlue, 1)
    Private ReadOnly myFont As New Font("Arial", 10, Drawing.FontStyle.Regular)
    Private ReadOnly ArialFont As Font = New Font("Arial", 8, Drawing.FontStyle.Bold)
    Private ReadOnly TimesNewFont As Font = New Font("Times New Roman", 8, Drawing.FontStyle.Bold)
    Private ReadOnly myFontBold As New Font("Arial", 10, Drawing.FontStyle.Bold)
    Private IssuingSendMsgBx As Boolean = False
    Private CentralLat As Double = 0
    Private CentralLatDeg As Integer
    Private CentralLatMin As Integer
    Private CentralLatNS As String
    Private CentralLong As Double = 0
    Private CentralLongDeg As Integer
    Private CentralLongMin As Integer
    Private CentralLongEW As String

    Private TopLeftLat As Double = 0
    Private TopLeftLatDeg As Integer
    Private TopLeftLatMin As Double
    Private TopLeftLatNS As String
    Private TopLeftLong As Double = 0
    Private TopLeftLongDeg As Integer
    Private TopLeftLongMin As Double
    Private TopLeftLongEW As String

    Private TopEdge As Integer = 40
    Private SideEdge As Integer = 48
    Private SideY As Integer = 0
    Private SideX As Integer = 0

    Private PlotArray(0) As CLSForm.PlotEntry
    Private Grph As System.Drawing.Graphics
    Private bm As Bitmap
    Private ReadOnly BMFname As String = "./Graphics/CustomPlotForm.jpg"
    Private DrawWidth As Integer
    'Private ptA As Point
    'Private ptB As Point
    Private myIdx As Integer = 0
    Private FormCLSLoading As Boolean = False
    Public Structure DegMinCalc
        Public CalcDeg As Integer
        Public CalcMin As Double
        Public CalcDMS As Double
        Public CalcMouseLoc As Integer
    End Structure
    Private DMCalc As DegMinCalc
    'Private XAxisArray As DegMinCalc()
    'Private YAxisArray As DegMinCalc()
    Private XAxisArrayCtr As Integer = 0
    Private YAxisArrayCtr As Integer = 0
    Private PlotIntCalc As Double
    Private PlotIntCalcTA As String
    Private PlotAzCalc As Double
    Private PlotLat As Double
    Private PlotLatNS As String
    Private PlotLong As Double
    Private PlotLongEW As String
    Private PlotDRTime As String = vbNullString
    Private PlotEPLat As Double
    'Private ReadOnly PlotEPLatNS As String
    Private PlotEPLong As Double
    'Private ReadOnly PlotEPLongEW As Double
    Private OrigFormSize As Size
    Private OrigPicBoxSize As Size
    Private PlotTimeCount As Integer = 0
    Private PlotDRTimeCount As Integer = 0
    Private PlotAPTimeCount As Integer = 0
    Private isRunningSunSight As Boolean = False
    'Private ReadOnly LatDelta As Double = 0
    'Private ReadOnly LongDelta As Double = 0
    Private RunSunSightNum As Integer = 0

    Private EPLineCount As Integer = 0
    Private EPLineLocX As Integer = 255
    Private EPLineLocY As Integer = 575
    Private EPLineLoc As Point = New Point(EPLineLocX, EPLineLocY)
    'Private Toggle As Boolean = False

    Public Structure SaveSuns
        Public SunIndex As Integer
        Public SunDt As Date
    End Structure
    Public SunArray(0) As SaveSuns
    Public Sub RunningSunSight()
        ReDim SunArray(0)
        Dim idx As Integer = 0
        Dim LastSun As Integer = -1
        Dim EarlySun As Integer = -1
        If UBound(PlotArray) >= 1 Then ' is there at least two entries in plot array
            For i As Integer = 0 To UBound(PlotArray) - 1
                If PlotArray(i).PlotBody.Contains("Sun") And PlotArray(i).PlotType = "FixSight" Then
                    SunArray(idx).SunIndex = i
                    SunArray(idx).SunDt = PlotArray(i).PlotDT
                    idx += 1
                    ReDim Preserve SunArray(idx)
                End If
            Next
        Else
            Exit Sub
        End If
        If idx = 2 Then
            If SunArray(0).SunDt = SunArray(1).SunDt And PlotArray(SunArray(0).SunIndex).PlotLat = PlotArray(SunArray(1).SunIndex).PlotLat And
                    PlotArray(SunArray(0).SunIndex).PlotLong = PlotArray(SunArray(1).SunIndex).PlotLong Then
                Exit Sub ' these will plot just fine as is
            End If
            If SunArray(0).SunDt > SunArray(1).SunDt Then
                LastSun = SunArray(0).SunIndex
                EarlySun = SunArray(1).SunIndex
            Else
                LastSun = SunArray(1).SunIndex
                EarlySun = SunArray(0).SunIndex
            End If

            Dim newplot As CLSForm.PlotEntry = PlotArray(EarlySun)
            newplot.PlotBody = newplot.PlotBody & " Original"

            PlotArray(EarlySun).PlotLat = PlotArray(LastSun).PlotLat
            PlotArray(EarlySun).PlotLatDeg = PlotArray(LastSun).PlotLatDeg
            PlotArray(EarlySun).PlotLatMin = PlotArray(LastSun).PlotLatMin
            PlotArray(EarlySun).PlotLatNS = PlotArray(LastSun).PlotLatNS
            PlotArray(EarlySun).PlotLatSec = PlotArray(LastSun).PlotLatSec
            PlotArray(EarlySun).PlotLong = PlotArray(LastSun).PlotLong
            PlotArray(EarlySun).PlotLongDeg = PlotArray(LastSun).PlotLongDeg
            PlotArray(EarlySun).PlotLongEW = PlotArray(LastSun).PlotLongEW
            PlotArray(EarlySun).PlotLongMin = PlotArray(LastSun).PlotLongMin
            PlotArray(EarlySun).PlotLongSec = PlotArray(LastSun).PlotLongSec
            PlotArray(EarlySun).PlotBody = PlotArray(EarlySun).PlotBody & " Advanced"

            isRunningSunSight = True
            RunSunSightNum = EarlySun
            AddPlotEntry(newplot)
        Else
            Exit Sub
        End If
        Exit Sub
    End Sub
    Public Sub AddPlotEntry(ByVal PlotIn As CLSForm.PlotEntry)
        Dim Idx As Integer = UBound(PlotArray)
        myIdx = Idx
        PlotArray(Idx) = PlotIn
        Idx += 1
        ReDim Preserve PlotArray(Idx)
        Exit Sub
    End Sub
    Public Function PlotSight() As Boolean
        FormCLSLoading = True
        PlotTimeCount = 0
        FirstTimeInit()
        RunningSunSight()

        If SetandEditCentralLatLong() = False Then
            'SendMsgBx("Error in Lat/Long Plot data - unrecoverable error in code - contact support to correct", MessageBoxIcon.Hand)
            Return False
            Exit Function
        End If
        SetPlotSideSize()
        'SetPlotInfoFields()
        DrawBasicPlotForm()
        DrawPlots()
        SaveDisplayBMFname()
        FormCLSLoading = False
        cboPlotSize.Enabled = True
        Me.Refresh()
        Me.BringToFront()
        Me.Show()

        Return True
        Exit Function
    End Function
    Private Sub CustomPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCLSLoading = True
        Dim PlotArray(0)
        Dim MapLattoY(0)
        Dim MapLongtoX(0)
        Dim XAxisArray(0)
        Dim YAxisArray(0)
        XAxisArrayCtr = 0
        YAxisArrayCtr = 0
        'txtPlots.ReadOnly = True
        'OrigFormSize = Me.Size
        'OrigPicBoxSize = PicBoxPlot.Size
        PicBoxPlot.SizeMode = PictureBoxSizeMode.StretchImage
        cboPlotSize.SelectedIndex = 2 ' Default size of 60 nm on a side
        cboPlotSize.Enabled = False
        FormCLSLoading = False
    End Sub
    Private Sub FirstTimeInit()
        'CleanOutOldFiles()
        'RenamePlotJpg()

        Dim DPen As Pen = New Pen(Color.Black, 2)
        DPen.DashStyle = Drawing2D.DashStyle.Solid

        bm = New Bitmap(PicBoxPlot.Width, PicBoxPlot.Height)
        bm = Bitmap.FromFile("./CLSForms/customplottemplateV1.jpg")
        Grph = PicBoxPlot.CreateGraphics
        Grph = Graphics.FromImage(bm)

        Grph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Grph.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Grph.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        Grph.TranslateTransform(0, 0)
        'SaveDisplayBMFname()
        If FormCLSLoading = True Then
            cboPlotSize.SelectedIndex = 2 ' Default size of 60 nm on a side
            chkDisplayRose.Checked = True
        End If
        Exit Sub
    End Sub
    Private WithEvents PrtDoc As PrintDocument
    Private WithEvents PrtDocTxt As PrintDocument
    Private PrtFileName As String = "./PrtScnCustomPlot.jpg"
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        'This code needs to be here instead of in PrintScreen module because the code here works and produces full image - the code in PrintScreen while identical does not ????
        Dim PrintDialog1 As PrintDialog = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintDialog1.AllowPrintToFile = False
        PrintDialog1.AllowCurrentPage = False
        PrintDialog1.AllowSelection = False
        PrintDialog1.AllowSomePages = False
        Dim PrtDoc As PrintDocument = New PrintDocument()
        AddHandler PrtDoc.PrintPage, AddressOf PrtDoc_PrintPage
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        capture = New System.Drawing.Bitmap(Me.Width, Me.Height) ' System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        graph.CopyFromScreen(Me.Location.X + 10, Me.Location.Y, 0, 0, Me.Size) ' CopyPixelOperation.SourceCopy)
        If My.Computer.FileSystem.FileExists(PrtFileName) Then
            My.Computer.FileSystem.DeleteFile(PrtFileName)
        End If
        capture.Save(PrtFileName, Imaging.ImageFormat.Jpeg)
        PrtDoc.DocumentName = PrtFileName
        PrintDialog1.Document = PrtDoc
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrtDoc.Print()
        End If
        graph.Dispose()
        capture.Dispose()
        PrintDialog1.Dispose()
        PrtDoc.Dispose()
        Exit Sub
    End Sub
    Private Sub PrtDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrtDoc.PrintPage
        Dim img As Image = Image.FromFile(PrtFileName)
        e.Graphics.DrawImage(img, 0, 0, Me.Width - 90, Me.Height)
        img.Dispose()
        Exit Sub
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        myPen.Dispose()
        myFont.Dispose()
        DPen.Dispose()
        CompRosePen.Dispose()
        ArialFont.Dispose()
        TimesNewFont.Dispose()
        myFontBold.Dispose()

        Grph.Dispose()
        Me.Close()
        Exit Sub
    End Sub
    Private Function SetandEditCentralLatLong() As Boolean
        Dim LowLat As Double = 0
        Dim HighLat As Double = 0
        Dim LowLong As Double = 0
        Dim HighLong As Double = 0
        Dim LatDiff As Double = 0
        Dim LongDiff As Double = 0
        Dim LatDiffMin As Double = 0
        Dim LongDiffMin As Double = 0
        Dim NSFactor As Integer = 1
        Dim EWFactor As Integer = 1
        Dim firsttime As Boolean = True
        If UBound(PlotArray) > 1 Then
            For i = 0 To UBound(PlotArray)
                If PlotArray(i).PlotType <> Nothing Then
                    PlotArray(i).PlotLat = System.Math.Abs(PlotArray(i).PlotLat)  ' do this to make sure S lats are mathematically correct 
                    PlotArray(i).PlotLong = System.Math.Abs(PlotArray(i).PlotLong) ' do this to make sure S lats are mathematically correct
                    If i > 1 Then

                        If PlotArray(i).PlotType <> Nothing And PlotArray(i - 1).PlotType <> Nothing Then
                            If PlotArray(i).PlotLatNS <> PlotArray(i - 1).PlotLatNS Then
                                SendMsgBx("Error: Plots must be in the same Latitude N or S - Exit and Try Again", MessageBoxIcon.Error)
                                Return False
                                Exit Function
                            End If
                            If PlotArray(i).PlotLongEW <> PlotArray(i - 1).PlotLongEW Then
                                SendMsgBx("Error: Plots must be in the same Longitude E or W - Exit and Try Again", MessageBoxIcon.Error)
                                Return False
                                Exit Function
                            End If
                        End If
                    End If
                    If i = 0 Or firsttime = True Then
                        LowLat = System.Math.Abs(PlotArray(i).PlotLat)
                        HighLat = System.Math.Abs(PlotArray(i).PlotLat)
                        LowLong = System.Math.Abs(PlotArray(i).PlotLong)
                        HighLong = System.Math.Abs(PlotArray(i).PlotLong)
                        firsttime = False
                    End If
                    If i > 0 Then
                        If PlotArray(i).PlotLat < LowLat Then
                            LowLat = System.Math.Abs(PlotArray(i).PlotLat)
                        End If
                        If PlotArray(i).PlotLat > HighLat Then
                            HighLat = System.Math.Abs(PlotArray(i).PlotLat)
                        End If
                        If PlotArray(i).PlotLong < LowLong Then
                            LowLong = System.Math.Abs(PlotArray(i).PlotLong)
                        End If
                        If PlotArray(i).PlotLong > HighLong Then
                            HighLong = System.Math.Abs(PlotArray(i).PlotLong)
                        End If
                    End If
                End If
            Next
            If LowLat <> HighLat Then
                If HighLat >= LowLat Then
                    LatDiff = HighLat - LowLat
                Else
                    LatDiff = LowLat - HighLat
                End If

                LatDiffMin = (LatDiff - Int(LatDiff)) * 60
                If LatDiffMin > 59.9 Or Int(LatDiff) > 1 Then
                    SendMsgBx("Error: Distances between all latitudes must be less than 60 miles to plot", MessageBoxIcon.Error)
                    Return False
                    Exit Function
                End If
            End If
            If LowLong <> HighLong Then
                If HighLong >= LowLong Then
                    LongDiff = HighLong - LowLong
                Else
                    LongDiff = LowLong - HighLong
                End If
                'LongDiff = HighLong - LowLong
                LongDiffMin = (LongDiff - Int(LongDiff)) * 60
                If LongDiffMin > 59.9 Or Int(LongDiff) > 1 Then
                    SendMsgBx("Error: Distances between all longitudes must be less than 60 miles to plot", MessageBoxIcon.Error)
                    Return False
                    Exit Function
                End If
            End If
        End If

        If UBound(PlotArray) = 1 Then
            CentralLatDeg = System.Math.Abs(Convert.ToInt32(PlotArray(myIdx).PlotLatDeg))
            CentralLatMin = System.Math.Abs(Convert.ToInt32((Int(Convert.ToDouble(PlotArray(myIdx).PlotLatMin))) / 10) * 10)
            If CentralLatMin = 60 Then
                CentralLatMin = 0
                CentralLatDeg += 1
            End If
            CentralLat = CentralLatDeg + CentralLatMin / 60
            CentralLongDeg = System.Math.Abs(Convert.ToInt32(PlotArray(myIdx).PlotLongDeg))
            CentralLongMin = System.Math.Abs(Convert.ToInt32((Int(Convert.ToDouble(PlotArray(myIdx).PlotLongMin))) / 10) * 10)
            If CentralLongMin = 60 Then
                CentralLongMin = 0
                CentralLongDeg += 1
            End If
            CentralLong = CentralLongDeg + CentralLongMin / 60
        Else
            Dim AvgLat As Double = 0
            Dim AvgLong As Double = 0
            Dim PlotCt As Integer = 0
            For i = 0 To UBound(PlotArray)
                If PlotArray(i).PlotType <> Nothing Then
                    AvgLat += PlotArray(i).PlotLat
                    AvgLong += PlotArray(i).PlotLong
                    PlotCt += 1
                End If
            Next
            AvgLat = AvgLat / PlotCt
            AvgLong = AvgLong / PlotCt
            CentralLatDeg = Int(AvgLat)
            CentralLatMin = Convert.ToInt32(((AvgLat - CentralLatDeg) * 60) / 10) * 10
            If CentralLatMin = 60 Then
                CentralLatMin = 0
                CentralLatDeg += 1
            End If
            CentralLat = CentralLatDeg + CentralLatMin / 60
            CentralLongDeg = Int(AvgLong)
            CentralLongMin = Convert.ToInt32(((AvgLong - CentralLongDeg) * 60) / 10) * 10
            If CentralLongMin = 60 Then
                CentralLongMin = 0
                CentralLongDeg += 1
            End If
            CentralLong = CentralLongDeg + CentralLongMin / 60

        End If

        CentralLatNS = PlotArray(myIdx).PlotLatNS.Trim
        txtLatActive.Text = CentralLatDeg.ToString("##0") & Chr(176) & " " & CentralLatMin.ToString("00.0") & "' " & CentralLatNS
        'cboMidLat.SelectedIndex = 0
        CentralLongEW = PlotArray(myIdx).PlotLongEW.Trim
        txtLongActive.Text = CentralLongDeg.ToString("##0") & Chr(176) & " " & CentralLongMin.ToString("00.0") & "' " & CentralLongEW
        'cboMidLong.SelectedIndex = 0
        Dim TopLeftAdjMin As Double = ((NMSizeonSide / 2) / 60) ' Take NM on a side divide by 2 to get total minutes then divide by 60 to get degrees
        If CentralLatNS = g_LatN Then
            TopLeftLat = CentralLat + TopLeftAdjMin
        Else
            TopLeftLat = CentralLat - TopLeftAdjMin
        End If
        If CentralLongEW = g_LongW Then
            TopLeftLong = CentralLong + TopLeftAdjMin
        Else
            TopLeftLong = CentralLong - TopLeftAdjMin
        End If
        TopLeftLatDeg = System.Math.Truncate(TopLeftLat)
        TopLeftLatMin = (TopLeftLat - TopLeftLatDeg) * 60
        TopLeftLatNS = CentralLatNS

        TopLeftLongDeg = System.Math.Truncate(TopLeftLong)
        TopLeftLongMin = (TopLeftLong - TopLeftLongDeg) * 60
        TopLeftLongEW = CentralLongEW

        Me.Refresh()
        Me.Show()

        Return True
        Exit Function
    End Function

    Public Sub SetPlotSideSize()
        Dim tempStr As String = cboPlotSize.Text   'Items(cboPlotSize.SelectedIndex).ToString
        tempStr = tempStr.Substring(tempStr.IndexOf("to") + 2, tempStr.IndexOf("nm") - (tempStr.IndexOf("to") + 2)).Trim
        Dim tempSize As Integer = Convert.ToInt32(tempStr)
        NMSizeonSide = tempSize

        Select Case NMSizeonSide
            Case 100
                'OneNmPixels = 6
                OneNmPixels = (PicBoxPlot.Width - 6 * SideEdge) / 100
                OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
            Case 80
                'OneNmPixels = 8
                OneNmPixels = (PicBoxPlot.Width - 6 * SideEdge) / 80
                OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
            Case 60
                'OneNmPixels = 11
                OneNmPixels = (PicBoxPlot.Width - 6 * SideEdge) / 60
                OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
            Case 40
                'OneNmPixels = 15
                OneNmPixels = (PicBoxPlot.Width - 6 * SideEdge) / 40
                OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
            Case 20
                'OneNmPixels = 30
                OneNmPixels = (PicBoxPlot.Width - 6 * SideEdge) / 20
                OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
            Case Else
                'OneNmPixels = 11
                OneNmPixels = (PicBoxPlot.Width - 6 * SideEdge) / 60
                OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
        End Select

        Exit Sub
    End Sub

    Private Sub DrawBasicPlotForm()
        'ReDim XAxisArray(0)
        'ReDim YAxisArray(0)
        XAxisArrayCtr = 0
        YAxisArrayCtr = 0


        SideY = OneNmPixels * NMSizeonSide
        SideX = OneNmPixels * NMSizeonSide
        TopY = PicBoxPlot.Location.Y + TopEdge
        TopX = PicBoxPlot.Location.X + SideEdge
        LeftX = PicBoxPlot.Location.X + SideEdge
        RightX = PicBoxPlot.Location.X + SideEdge + SideX

        MidX = PicBoxPlot.Location.X + SideEdge + (SideX / 2)
        MidY = PicBoxPlot.Location.Y + TopEdge + (SideY / 2)
        BottomY = PicBoxPlot.Location.Y + TopEdge + SideY
        BottomX = PicBoxPlot.Location.X + SideEdge + SideX
        BottomCenter = New Point(MidX, BottomY)
        CenterofPlot = New Point(MidX, MidY)

        ' Clear the pic box and then draw a rectangle
        Grph.Clear(Color.White)
        Grph.DrawRectangle(DPen, TopX, TopY, SideX, SideY)

        ' Draw the mid lat and mid long lines
        Grph.DrawLine(DPen, MidX, BottomY, MidX, TopY)
        Grph.DrawLine(DPen, RightX, MidY, LeftX, MidY)

        ' Now draw the tic marks on each axis - starting with the x-axis
        Dim TempXlen As Integer = 0
        Dim TempYLen As Integer = 0
        Dim i As Integer = 0
        'Dim TempLat As Double = CentralLat
        'Dim TempPt As Integer = MidX
        'AddXAxisArray(TempLat, TempPt)
        For i = 1 To NMSizeonSide / 2
            TempXlen = MidX + System.Math.Round(Convert.ToInt32(i * OneNMLongPixels), 0, MidpointRounding.AwayFromZero)
            If (i Mod 10) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, TopY)
            ElseIf (i Mod 5) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 10)
                Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 10)
            Else
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 5)
                Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 5)
            End If
            'TempLat = CalcDMSAxis(XAxisArray(i - 1), +1)
            'TempPt = TempXlen
            'AddXAxisArray(TempLat, TempPt)
        Next
        'TempLat = CentralLat
        'TempPt = MidX
        For i = 1 To NMSizeonSide / 2
            TempXlen = MidX - Convert.ToInt32(i * OneNMLongPixels)
            If (i Mod 10) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, TopY)
            ElseIf (i Mod 5) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 10)
                Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 10)
            Else
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 5)
                Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 5)
            End If
            'TempLat = CalcDMSAxis(XAxisArray(i - 1), -1)
            'TempPt = TempXlen
            'AddXAxisArray(TempLat, TempPt)
        Next
        'SortXAxisArray()
        'Dim TempLong As Double = CentralLong
        'TempPt = MidY
        'AddYAxisArray(TempLat, TempPt)
        For i = 1 To NMSizeonSide / 2
            TempYLen = MidY + Convert.ToInt32(i * OneNmPixels)
            If (i Mod 10) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                Grph.DrawLine(DPen, LeftX, TempYLen, RightX, TempYLen)
            ElseIf (i Mod 5) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, RightX, TempYLen, RightX - 10, TempYLen)
                Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 10, TempYLen)
            Else
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, RightX, TempYLen, RightX - 5, TempYLen)
                Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 5, TempYLen)
            End If
            'TempLong = CalcDMSAxis(YAxisArray(i - 1), +1)
            'TempPt = TempXlen
            'AddYAxisArray(TempLat, TempPt)
        Next
        'TempLong = CentralLong
        'TempPt = MidY
        For i = 1 To NMSizeonSide / 2
            TempYLen = MidY - Convert.ToInt32(i * OneNmPixels)
            If (i Mod 10) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                Grph.DrawLine(DPen, LeftX, TempYLen, RightX, TempYLen)
            ElseIf (i Mod 5) = 0 Then
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, RightX, TempYLen, RightX - 10, TempYLen)
                Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 10, TempYLen)
            Else
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                Grph.DrawLine(DPen, RightX, TempYLen, RightX - 5, TempYLen)
                Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 5, TempYLen)
            End If
            'TempLong = CalcDMSAxis(YAxisArray(i - 1), -1)
            'TempPt = TempXlen
            'AddYAxisArray(TempLat, TempPt)
        Next
        'SortYAxisArray()

        'Draw compass rose if the check box is checked
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        If chkDisplayRose.Checked = True Then
            'Dim CircleX As Integer = PicBoxPlot.Location.X + SideEdge + (SideX / 4)
            'Dim CircleY As Integer = PicBoxPlot.Location.Y + TopEdge + (SideY / 4)

            'Dim rectSide As Integer = Convert.ToInt32(System.Math.Round(SideX / 2, 0, MidpointRounding.AwayFromZero))
            Dim tempRect As Rectangle = New Rectangle(MidX - SideX / 4, MidY - SideX / 4, SideX / 2, SideX / 2)

            Grph.DrawArc(CompRosePen, tempRect, 0, 360)
            'Grph.DrawEllipse(CompRosePen, tempRect)
            DrawWidth = System.Math.Round((SideX / 4), 0, MidpointRounding.AwayFromZero)


            Dim tempDeg As Integer = 0
            For j = 0 To 179 Step 1
                Grph.TranslateTransform(MidX, MidY)
                Grph.RotateTransform(-90 + j)
                If (j Mod 5) = 0 Then
                    Grph.DrawLine(CompRosePen, DrawWidth - 5, 0, DrawWidth + 5, 0)
                    Grph.DrawLine(CompRosePen, -DrawWidth + 5, 0, -DrawWidth - 5, 0)
                Else
                    Grph.DrawLine(CompRosePen, DrawWidth - 3, 0, DrawWidth + 3, 0)
                    Grph.DrawLine(CompRosePen, -DrawWidth + 3, 0, -DrawWidth - 3, 0)
                End If
                If (j Mod 10) = 0 Then
                    Grph.DrawString(j.ToString("##0") & Chr(176), ArialFont, Brushes.DarkBlue, DrawWidth + 3, -7)
                    Grph.DrawString((j + 180).ToString("##0") & Chr(176), ArialFont, Brushes.DarkBlue, -DrawWidth - 25, -7)
                End If
                Grph.ResetTransform()
            Next
        End If

        Dim Efont As Font = New Font("Arial", 7, Drawing.FontStyle.Bold)
        ' now draw the lat and long test strings on the axis of this plot
        Dim TempStr As String = CentralLatDeg.ToString("##0") & Chr(176) & " " & CentralLatMin.ToString("##0.0") & "' " & CentralLatNS.ToString
        Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5)
        Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5)

        DMCalc.CalcDeg = CentralLatDeg
        DMCalc.CalcMin = CentralLatMin
        DPen.DashStyle = Drawing2D.DashStyle.Dash
        Dim tmpLim As Integer = (NMSizeonSide / 2) / 10
        If CentralLatNS = g_LatN Then
            For i = 1 To tmpLim
                Dim Incr1 As Integer = 10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, +10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 - (OneNmPixels * Incr1))
                Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 - (OneNmPixels * Incr1))
                If i < tmpLim Then
                    Grph.DrawLine(DPen, New PointF(LeftX, MidY - (OneNmPixels * Incr1)), New PointF(RightX, MidY - (OneNmPixels * Incr1)))
                End If
            Next
            URLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60
            ULLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60
            DMCalc.CalcDeg = CentralLatDeg
            DMCalc.CalcMin = CentralLatMin
            For i = 1 To tmpLim
                Dim Incr2 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 - (OneNmPixels * Incr2))
                Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 - (OneNmPixels * Incr2))
                If i < tmpLim Then
                    Grph.DrawLine(DPen, New PointF(LeftX, MidY - (OneNmPixels * Incr2)), New PointF(RightX, MidY - (OneNmPixels * Incr2)))
                End If
            Next
            LLLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60
            LRLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60
        Else
            For i = 1 To tmpLim
                Dim Incr3 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 + (OneNmPixels * Incr3))
                Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 + (OneNmPixels * Incr3))
                If i < tmpLim Then
                    Grph.DrawLine(DPen, New PointF(LeftX, MidY - (OneNmPixels * Incr3)), New PointF(RightX, MidY - (OneNmPixels * Incr3)))
                End If
            Next
            URLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
            ULLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
            DMCalc.CalcDeg = CentralLatDeg
            DMCalc.CalcMin = CentralLatMin
            For i = 1 To tmpLim
                Dim Incr4 As Integer = +10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, +10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 + (OneNmPixels * Incr4))
                Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 + (OneNmPixels * Incr4))
                If i < tmpLim Then
                    Grph.DrawLine(DPen, New PointF(LeftX, MidY - (OneNmPixels * Incr4)), New PointF(RightX, MidY - (OneNmPixels * Incr4)))
                End If
            Next
            LLLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
            LRLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
        End If

        TempStr = CentralLongDeg.ToString("##0") & Chr(176) & " " & CentralLongMin.ToString("##0.0") & "' " & CentralLongEW.ToString
        Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20, BottomY + 5)
        Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20, TopY - 15)
        DMCalc.CalcDeg = CentralLongDeg
        DMCalc.CalcMin = CentralLongMin
        If CentralLongEW = g_LongW Then
            For i = 1 To tmpLim
                Dim Incr1 As Integer = 10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, 10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr1), BottomY + 5)
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr1), TopY - 15)
            Next
            URLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60
            LRLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60
            DMCalc.CalcDeg = CentralLongDeg
            DMCalc.CalcMin = CentralLongMin
            For i = 1 To tmpLim
                Dim Incr2 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr2), BottomY + 5)
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr2), TopY - 15)
            Next
            ULLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60
            LLLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60
        Else
            For i = 1 To tmpLim
                Dim Incr3 As Integer = 10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, 10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr3), BottomY + 5)
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr3), TopY - 15)
            Next
            URLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
            LRLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
            DMCalc.CalcDeg = CentralLongDeg
            DMCalc.CalcMin = CentralLongMin
            For i = 1 To tmpLim
                Dim Incr4 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr4), BottomY + 5)
                Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr4), TopY - 15)
            Next
            ULLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
            LLLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60
        End If
        'SaveDisplayBMFname()
        Exit Sub
    End Sub
    Private Sub CalcDegMin(ByVal InDeg As Integer, ByVal InMin As Integer, ByVal InIncr As Integer)
        Dim tempmin As Integer = InMin + InIncr
        If InMin = 0 And InIncr < 0 Then
            DMCalc.CalcDeg = InDeg - 1
            DMCalc.CalcMin = 50
            Exit Sub
        End If
        If InIncr > 0 Then
            If tempmin = 60 Then
                DMCalc.CalcDeg = InDeg + 1
                DMCalc.CalcMin = 0
            Else
                DMCalc.CalcMin = tempmin
            End If
        Else
            If tempmin = 0 Then
                DMCalc.CalcDeg = InDeg
                DMCalc.CalcMin = 0
            Else
                DMCalc.CalcMin = tempmin
            End If
        End If

        Exit Sub
    End Sub
    Private Function CalcDMSAxis(ByVal DMSIn As DegMinCalc, ByVal InIncr As Integer) As Double
        Dim tempmin As Integer = DMSIn.CalcMin + InIncr
        Dim TempDMS As DegMinCalc = DMSIn
        If TempDMS.CalcMin = 0 And InIncr < 0 Then
            TempDMS.CalcDeg = DMSIn.CalcDeg - 1
            TempDMS.CalcMin = 50
            TempDMS.CalcDMS = TempDMS.CalcDeg + TempDMS.CalcMin / 60
            Return TempDMS.CalcDMS
        End If
        If InIncr > 0 Then
            If tempmin = 60 Then
                TempDMS.CalcDeg = DMSIn.CalcDeg + 1
                TempDMS.CalcMin = 0
            Else
                TempDMS.CalcMin = tempmin
            End If
        Else
            If tempmin = 0 Then
                TempDMS.CalcDeg = DMSIn.CalcDeg
                TempDMS.CalcMin = 0
            Else
                TempDMS.CalcMin = tempmin
            End If
        End If
        TempDMS.CalcDMS = TempDMS.CalcDeg + TempDMS.CalcMin / 60
        Return TempDMS.CalcDMS
        Exit Function
    End Function
    'Private Sub SetPlotInfoFields()
    'txtSummary.Clear()
    'Dim Idx As Integer = 0
    'For Idx = 0 To UBound(PlotArray)
    '    If PlotArray(Idx).PlotType <> Nothing Then
    '        txtSummary.AppendText(PlotArray(Idx).PlotType.ToString & " # " & PlotArray(Idx).PlotNumber.ToString & '" Name = " & PlotArray(Idx).PsnName.ToString & " Squadron = " & PlotArray(Idx).SquadronName.ToString &
    '    " ;Body = " & PlotArray(Idx).PlotBody.ToString & " ;Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") & 'vbNewLine &
    '    " ;L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
    '    " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString & 'vbNewLine &
    '    " ;Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & vbNewLine &
    '    vbTab & PlotArray(Idx).PlotLLoBy & " Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine)
    '    End If
    'Next
    'Exit Sub
    'End Sub
    Private Sub DrawPlots()
        'txtPlots.Clear()
        PlotTimeCount = 0
        PlotAPTimeCount = 0
        PlotDRTimeCount = 0
        EPLineCount = 0
        EPLineLocY = 575
        For i = 0 To UBound(PlotArray)
            If PlotArray(i).PlotType <> Nothing Then
                Select Case PlotArray(i).PlotType
                    Case "Sight"
                        PlotSightType(i)
                    Case "FixSight"
                        PlotSightType(i)
                    Case "Fix"
                        PlotFixType(i)
                    Case "DR"
                        PlotDRType(i)
                End Select
            End If
        Next
        PlotTimeCount = 0
        PlotAPTimeCount = 0
        PlotDRTimeCount = 0
        Exit Sub
    End Sub
    Private Sub PlotSightType(ByVal idx As Integer)
        Dim Inttemp As String
        Dim Aztemp As String
        Dim AzCalcPlus90 As Double = 0
        Dim AZCalcPlot As Double = 0
        Dim Leftside As Boolean = True
        Dim FactorNS As Integer = 1
        Dim FactorEW As Integer = +1

        Inttemp = PlotArray(idx).PlotIntercept
        Aztemp = PlotArray(idx).PlotAz
        If Inttemp.Contains("Tow") Then
            PlotIntCalcTA = "T"
        Else
            PlotIntCalcTA = "A"
        End If
        Inttemp = Inttemp.Substring(0, Inttemp.IndexOf("nm")).Trim
        Aztemp = Aztemp.Substring(0, Aztemp.IndexOf(Chr(176))).Trim
        PlotIntCalc = System.Math.Round(Convert.ToDouble(Inttemp), 1, MidpointRounding.AwayFromZero)
        PlotAzCalc = System.Math.Round(Convert.ToDouble(Aztemp), 0, MidpointRounding.AwayFromZero)

        PlotLat = PlotArray(idx).PlotLat
        PlotLatNS = PlotArray(idx).PlotLatNS
        PlotLong = PlotArray(idx).PlotLong
        PlotLongEW = PlotArray(idx).PlotLongEW
        If PlotArray(idx).PlotType = "Sight" Or PlotArray(idx).PlotType = "FixSight" Then
            UnStringEP(PlotArray(idx).PlotSLEP, idx)
        Else
            PlotEPLat = 0
            PlotEPLong = 0
        End If

        AZCalcPlot = PlotAzCalc
        If PlotLatNS = g_LatN Then
            FactorNS = +1
        Else
            FactorNS = -1
        End If
        If PlotLongEW = g_LongE Then
            FactorEW = -1
        Else
            FactorEW = +1
        End If
        ' Left side boolean tells me which side of the DR Plot to print the text
        If AZCalcPlot >= 0 And AZCalcPlot <= 180 Then
            If PlotIntCalcTA = "T" Then
                Leftside = True
            Else
                Leftside = False
            End If
        End If
        If AZCalcPlot > 180 And AZCalcPlot <= 360 Then
            If PlotIntCalcTA = "T" Then
                Leftside = False
            Else
                Leftside = True
            End If
        End If
        ' this is the direction of the perpendicular line for the LOP at the EP
        AzCalcPlus90 = PlotAzCalc - 90
        If AzCalcPlus90 > 360 Then
            AzCalcPlus90 -= 360
        End If
        Dim DRPoint As PointF = New PointF(0, 0)
        Dim XlateX As Integer = (FactorEW) * ((CentralLong - PlotLong) * 60) * OneNMLongPixels
        Dim XlateY As Integer = (FactorNS) * ((CentralLat - PlotLat) * 60) * OneNmPixels
        DRPoint.X = MidX + XlateX
        DRPoint.Y = MidY + XlateY

        Grph.DrawArc(myPen, Convert.ToInt32(DRPoint.X - 2), Convert.ToInt32(DRPoint.Y - 2), 4, 4, 0, 360)
        If PlotArray(idx).PlotLLoBy = "GPS" Then
            Grph.DrawArc(myPen, Convert.ToInt32(DRPoint.X - 6), Convert.ToInt32(DRPoint.Y - 6), 12, 12, 0, 360)
        Else
            Grph.DrawArc(myPen, Convert.ToInt32(DRPoint.X - 6), Convert.ToInt32(DRPoint.Y - 6), 12, 12, 180, 180)
        End If
        Grph.DrawLine(myPen, Convert.ToInt32(DRPoint.X - 6), Convert.ToInt32(DRPoint.Y), Convert.ToInt32(DRPoint.X + 6), Convert.ToInt32(DRPoint.Y))

        Dim lblHr As Integer = PlotArray(idx).PlotDT.Hour
        Dim lblMin As Integer = PlotArray(idx).PlotDT.Minute
        Dim lblSec As Integer = PlotArray(idx).PlotDT.Second
        If lblSec >= 30 Then
            lblMin += 1
        End If
        If lblMin > 59 Then
            lblMin = 0
            lblHr += 1
        End If
        PlotDRTime = lblHr.ToString("00") & lblMin.ToString("00")

        If PlotArray(idx).PlotLLoBy = "AP" Then
            PlotTimeCount = 0
            Grph.TranslateTransform(DRPoint.X, DRPoint.Y)
            Grph.RotateTransform(Convert.ToSingle((System.Math.Round(-45, 0, MidpointRounding.AwayFromZero))))
            Grph.DrawString(PlotDRTime & " " & PlotArray(idx).PlotLLoBy, ArialFont, Brushes.Blue, 6, -12)
            Grph.ResetTransform()
        Else
            PlotTimeCount = PlotDRTimeCount

            If Leftside = True Then
                If PlotTimeCount = 0 Then
                    Grph.DrawString(PlotDRTime & " " & PlotArray(idx).PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X - 6 - 8 * 8, DRPoint.Y - 12) ' HHmm is 4 characters and 1 char = 8 pixels roughly
                Else
                    Grph.DrawString(PlotDRTime & " " & PlotArray(idx).PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X - 6, DRPoint.Y - 12 * (PlotTimeCount + 1))
                End If
            Else
                If PlotTimeCount = 0 Then
                    Grph.DrawString(PlotDRTime & " " & PlotArray(idx).PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X + 6, DRPoint.Y - 12)
                Else
                    Grph.DrawString(PlotDRTime & " " & PlotArray(idx).PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X + 6, DRPoint.Y - 12 * (PlotTimeCount + 1))
                End If
            End If
        End If

        If PlotArray(idx).PlotLLoBy = "AP" Then
            PlotAPTimeCount += 1
        Else
            PlotDRTimeCount += 1
        End If

        Dim DRPointEP As PointF = New PointF(0, 0)
        Dim EPXlateX As Integer = 0
        Dim EPXlateY As Integer = 0
        If PlotArray(idx).PlotType = "Sight" Or PlotArray(idx).PlotType = "FixSight" Then
            EPXlateX = (FactorEW) * Convert.ToInt32(((CentralLong - PlotEPLong) * 60) * OneNMLongPixels)
            EPXlateY = (FactorNS) * Convert.ToInt32(((CentralLat - PlotEPLat) * 60) * OneNmPixels)
            DRPointEP.X = MidX + EPXlateX
            DRPointEP.Y = MidY + EPXlateY
        End If

        myPen.DashStyle = Drawing2D.DashStyle.Dot
        Grph.DrawLine(myPen, DRPoint, DRPointEP)
        myPen.DashStyle = Drawing2D.DashStyle.Solid
        Grph.DrawArc(myPen, Convert.ToInt32(DRPointEP.X - 2), Convert.ToInt32(DRPointEP.Y - 2), 4, 4, 0, 360)
        myPen.DashStyle = Drawing2D.DashStyle.Solid


        Dim RotateAngle As Double = PlotAzCalc ' AZangle
        Dim AZLOPAngle As Double = RotateAngle + 90
        If AZLOPAngle > 360 Then
            AZLOPAngle -= 360
        End If
        If RotateAngle > 90 And RotateAngle < 270 Then
            RotateAngle += 180
        End If
        Grph.TranslateTransform(DRPointEP.X, DRPointEP.Y)
        Grph.RotateTransform(Convert.ToSingle((System.Math.Round(RotateAngle, 0, MidpointRounding.AwayFromZero))))

        If PlotArray(idx).PlotExtendedLines = True Then
            Grph.DrawLine(myPen, New PointF(-(40 * OneNMLongPixels), 0), New PointF((40 * OneNMLongPixels), 0))
        Else
            Grph.DrawLine(myPen, New PointF(-(20 * OneNMLongPixels), 0), New PointF((20 * OneNMLongPixels), 0))
        End If

        'End If
        'Grph.DrawRectangle(myPen, -6, -6, 12, 12)
        Dim Xloc As Integer = 20 * OneNMLongPixels
        Dim pt As Point = New Point(-Xloc + 30, -14)
        If PlotArray(idx).PlotLLoBy <> "AP" Then
            Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, pt.X, pt.Y)
            pt = New Point(-Xloc + 30, 1)
            Grph.DrawString(PlotArray(idx).PlotBody, ArialFont, Brushes.Blue, pt.X, pt.Y)
        End If
        Grph.ResetTransform()

        If EPLineCount > 0 Then
            EPLineLocY += 12
            EPLineLoc = New Point(EPLineLocX, EPLineLocY)
        End If

        If PlotArray(idx).PlotType = "Sight" Then
            If PlotArray(idx).PlotLLoBy = "GPS" Then
                Grph.DrawString("S/Err: " & PlotIntCalc.ToString("#0.0"), ArialFont, Brushes.Black, EPLineLocX + 100, EPLineLocY)
            Else
                Grph.DrawString(PlotArray(idx).PlotBody & " " & PlotArray(idx).PlotLLoBy & " Position:" & PlotArray(idx).PlotSLEP.ToString.Replace("EP", ""), ArialFont, Brushes.Black, EPLineLocX, EPLineLocY)
            End If
            EPLineCount += 1
        End If
        If PlotArray(idx).PlotType = "FixSight" Then
            Grph.DrawString(PlotArray(idx).PlotSLEP.ToString, ArialFont, Brushes.Black, EPLineLocX, EPLineLocY)
            EPLineCount += 1
        End If

        Exit Sub
    End Sub
    Private Sub PlotFixType(ByVal idx As Integer)
        Dim index As Integer = idx
        Dim Inttemp As String
        Dim Aztemp As String
        Dim AzCalcPlus90 As Double = 0
        Dim AZCalcPlot As Double = 0
        Dim Leftside As Boolean = True
        Dim FactorNS As Integer = 1
        Dim FactorEW As Integer = +1


        Inttemp = PlotArray(idx).PlotIntercept
        Aztemp = PlotArray(idx).PlotAz
        If Inttemp.Contains("Tow") Then
            PlotIntCalcTA = "T"
        Else
            PlotIntCalcTA = "A"
        End If
        Inttemp = Inttemp.Substring(0, Inttemp.IndexOf("nm")).Trim
        Aztemp = Aztemp.Substring(0, Aztemp.IndexOf(Chr(176))).Trim
        PlotIntCalc = Convert.ToDouble(Inttemp)
        PlotAzCalc = Convert.ToDouble(Aztemp)
        If PlotIntCalcTA = "A" Then
            PlotAzCalc = -PlotAzCalc
        End If
        PlotLat = PlotArray(idx).PlotLat
        PlotLatNS = PlotArray(idx).PlotLatNS
        PlotLong = PlotArray(idx).PlotLong
        PlotLongEW = PlotArray(idx).PlotLongEW

        AZCalcPlot = PlotAzCalc
        If PlotLatNS = g_LatN Then
            FactorNS = +1
        Else
            FactorNS = -1
        End If
        If PlotLongEW = g_LongE Then
            FactorEW = -1
        Else
            FactorEW = +1
        End If
        ' Left side boolean tells me which side of the DR Plot to print the text
        If System.Math.Abs(AZCalcPlot) >= 0 And System.Math.Abs(AZCalcPlot) <= 180 Then
            If PlotIntCalcTA = "T" Then
                Leftside = True
            Else
                Leftside = False
            End If
        End If
        If System.Math.Abs(AZCalcPlot) > 180 And System.Math.Abs(AZCalcPlot) <= 360 Then
            If PlotIntCalcTA = "T" Then
                Leftside = False
            Else
                Leftside = True
            End If
        End If
        ' this is the direction of the perpendicular line for the LOP at the EP
        AzCalcPlus90 = PlotAzCalc - 90
        If AzCalcPlus90 > 360 Then
            AzCalcPlus90 -= 360
        End If
        Dim DRPoint As Point = New Point(0, 0)
        Dim XlateX As Integer = (FactorEW) * Convert.ToInt32(((CentralLong - PlotLong) * 60) * OneNMLongPixels)
        Dim XlateY As Integer = (FactorNS) * Convert.ToInt32(((CentralLat - PlotLat) * 60) * OneNmPixels)
        DRPoint.X = MidX + XlateX
        DRPoint.Y = MidY + XlateY
        Grph.TranslateTransform(DRPoint.X, DRPoint.Y)
        Grph.DrawArc(myPen, -1, -1, 2, 2, 0, 360)
        Grph.DrawArc(myPen, -2, -2, 4, 4, 0, 360)
        Grph.DrawArc(myPen, -8, -8, 16, 16, 0, 360)
        Grph.ResetTransform()

        Dim lblHr As Integer = PlotArray(idx).PlotDT.Hour
        Dim lblMin As Integer = PlotArray(idx).PlotDT.Minute
        Dim lblSec As Integer = PlotArray(idx).PlotDT.Second
        If lblSec >= 30 Then
            lblMin += 1
        End If
        If lblMin > 59 Then
            lblMin = 0
            lblHr += 1
        End If
        PlotDRTime = lblHr.ToString("00") & lblMin.ToString("00") & " Fix"

        ' the following logic will not print properly IF there are three or more plots and the third or later lat/long match the first lat/long and not the second
        ' are we on the second or later plotarray item
        'If idx > 0 Then ' if we are plotting the same lat / long as previous plot then leave plottimecount along to align printing properly
        '    If PlotArray(idx - 1).PlotLat <> PlotArray(idx).PlotLat Or PlotArray(idx - 1).PlotLong <> PlotArray(idx).PlotLong Then
        '        PlotTimeCount = 0 ' if this lat or long is not the same as the previous time then reset plottimecount to 0 so plot DR time printing is done properly
        '    End If
        'End If

        If Leftside = True Then
            'If PlotTimeCount = 0 Then
            Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X - 6 - PlotDRTime.Length * 8, DRPoint.Y - 12) ' HHmm is 4 characters and 1 char = 8 pixels roughly
            'Else
            'Grph.DrawString(PlotDRTime & ",", ArialFont, Brushes.Blue, DRPoint.X - 6 - (PlotDRTime.Length * 8 * (PlotTimeCount + 1)), DRPoint.Y - 12) ' HHmm is 4 characters and 1 char = 8 pixels roughly
            'End If
        Else
            'If PlotTimeCount = 0 Then
            Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X + 6, DRPoint.Y - 12)
            'Else
            'Grph.DrawString("," & PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X + 6 + (PlotDRTime.Length * 8 * PlotTimeCount), DRPoint.Y - 12)
            'end If
        End If
        PlotTimeCount += 1

        If EPLineCount > 0 Then
            EPLineLocY += 12
            EPLineLoc = New Point(EPLineLocX, EPLineLocY)
        End If

        Grph.DrawString(PlotArray(idx).PlotSLEP.ToString.Replace("EP", ""), ArialFont, Brushes.Black, EPLineLocX, EPLineLocY)

        EPLineCount += 1


        Exit Sub
    End Sub
    Private LastDR As Integer = 0
    Private Sub PlotDRType(ByVal idx As Integer)
        Dim index As Integer = idx
        If LastDR = 0 Then
            LastDR = idx
            'plot dr lat long as 
        End If
        SendMsgBx("PlotType = DR not implemented yet - Contact Support", MessageBoxIcon.Hand)
        Exit Sub
    End Sub

    Public Sub UnStringEP(ByVal EPStrIn As String, ByVal idx As Integer)
        Dim EPLLoc As Integer = EPStrIn.IndexOf("EP L ") + 5
        Dim EPLDegLoc As Integer = EPStrIn.IndexOf(Chr(176))
        Dim EPLMinLoc As Integer = EPStrIn.IndexOf("'")
        Dim EPLoLoc As Integer = EPStrIn.IndexOf("EP Lo ") + 6
        Dim EPLoDegLoc As Integer = EPStrIn.LastIndexOf(Chr(176))
        Dim EPLoMinLoc As Integer = EPStrIn.LastIndexOf("'")
        Dim EPLDeg As Double = Convert.ToDouble(EPStrIn.Substring(EPLLoc, (EPLDegLoc - EPLLoc)))
        Dim EPLMin As Double = Convert.ToDouble(EPStrIn.Substring(EPLDegLoc + 1, (EPLMinLoc - (EPLDegLoc + 1))))
        PlotEPLat = EPLDeg + EPLMin / 60
        Dim EPLoDeg As Double = Convert.ToDouble(EPStrIn.Substring(EPLoLoc, (EPLoDegLoc - EPLoLoc)))
        Dim EPLoMin As Double = Convert.ToDouble(EPStrIn.Substring(EPLoDegLoc + 1, (EPLoMinLoc - (EPLoDegLoc + 1))))
        PlotEPLong = EPLoDeg + EPLoMin / 60

        If isRunningSunSight = True And idx = RunSunSightNum Then
            Dim Inttemp As String = PlotArray(idx).PlotIntercept
            Dim Aztemp As String = PlotArray(idx).PlotAz
            If Inttemp.Contains("Tow") Then
                PlotIntCalcTA = "T"
            Else
                PlotIntCalcTA = "A"
            End If
            Inttemp = Inttemp.Substring(0, Inttemp.IndexOf("nm")).Trim
            Aztemp = Aztemp.Substring(0, Aztemp.IndexOf(Chr(176))).Trim
            Dim PlotIntCalc1 As Double = System.Math.Round(Convert.ToDouble(Inttemp), 1, MidpointRounding.AwayFromZero)
            Dim PlotAzCalc1 As Double = System.Math.Round(Convert.ToDouble(Aztemp), 0, MidpointRounding.AwayFromZero)

            If PlotArray(idx).PlotType = "FixSight" And PlotIntCalcTA = "A" Then
                PlotAzCalc1 = (180 + PlotAzCalc1)
                If PlotAzCalc1 > 360 Then
                    PlotAzCalc1 = PlotAzCalc1 - 360
                End If
            End If
            Dim TmpLat As Double = PlotArray(idx).PlotLat
            If PlotArray(idx).PlotLatNS = g_LatS Then
                TmpLat = -1 * TmpLat
            End If
            Dim TmpLong As Double = PlotArray(idx).PlotLong
            If PlotArray(idx).PlotLongEW = g_LongW Then
                TmpLong = -1 * TmpLong
            End If
            Dim GeoTmp As System.Device.Location.GeoCoordinate = FindDestLatLong(TmpLat, TmpLong, PlotIntCalc1, PlotAzCalc1)

            PlotEPLat = System.Math.Abs(GeoTmp.Latitude)
            PlotEPLong = System.Math.Abs(GeoTmp.Longitude)

        End If

        Exit Sub
    End Sub
    Public Sub SaveDisplayBMFname()
        If System.IO.File.Exists(BMFname) Then
            System.IO.File.Delete(BMFname)
        End If
        bm.Save(BMFname)
        PicBoxPlot.ImageLocation = BMFname
        PicBoxPlot.Refresh()
        bm.Dispose()

        Exit Sub
    End Sub

    Private Sub PicBoxPlot_Paint(sender As Object, e As PaintEventArgs) Handles PicBoxPlot.Paint

        Exit Sub
    End Sub
    Public Sub SendMsgBx(ByVal SendStr As String, ByVal IconType As MessageBoxIcon)
        ' this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
        IssuingSendMsgBx = True
        Dim HdrStr As String = vbNullString
        'HdrStr = IconType.ToString
        If IconType = MessageBoxIcon.Error Then
            HdrStr = "Input Error"
        ElseIf IconType = MessageBoxIcon.Warning Then
            HdrStr = "Warning Message"
        ElseIf IconType = MessageBoxIcon.Information Then
            HdrStr = "Information Message"
        ElseIf IconType = MessageBoxIcon.Stop Then
            HdrStr = "STOP - Program Error"
        Else
            HdrStr = "General Message"
        End If
        System.Windows.Forms.MessageBox.Show(SendStr, HdrStr,
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                IconType,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Me.Show()
        Exit Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PrintScreen(PicBoxPlot.Bounds)
        Exit Sub
    End Sub

    Private Sub btnPrtSights_Click(sender As Object, e As EventArgs) Handles btnPrtSights.Click
        Dim Idx As Integer = 0
        Dim TxtMsg As String = "Plotted Sight Data: "

        For Idx = 0 To UBound(PlotArray)
            If PlotArray(Idx).PlotType <> Nothing Then
                Dim TmpStr As String = (vbNewLine & "Type= " & PlotArray(Idx).PlotType & " " & " Sight #" & PlotArray(Idx).PlotNumber.ToString & " Name = " & PlotArray(Idx).PsnName.ToString & " Squadron = " & PlotArray(Idx).SquadronName.ToString &
                " Body = " & PlotArray(Idx).PlotBody.ToString & " Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") & vbNewLine &
                " L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
                " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString &
                " Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & " " & PlotArray(Idx).PlotLLoBy & " Est Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine)
                TxtMsg &= TmpStr
            End If

        Next
        Dim CaptionStr As String = "CLS Plot Sight Data"
        Dim unused = MessageBox.Show(TxtMsg, CaptionStr, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "")
        'Randomize()
        'Dim RandomInt As Single = Rnd()
        'Dim ReportName As String = "./CLSForms/CustomPlotReport" + NowTimeStr + RandomInt.ToString.Replace(".", "") + ".txt"
        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter(ReportName, False)

        'For Idx = 0 To UBound(PlotArray)
        '    If PlotArray(Idx).PlotType <> Nothing Then
        '        file.WriteLine(("Type= " & PlotArray(Idx).PlotType & " " & " Sight #" & PlotArray(Idx).PlotNumber.ToString & " Name = " & PlotArray(Idx).PsnName.ToString & " Squadron = " & PlotArray(Idx).SquadronName.ToString &
        '        " Body = " & PlotArray(Idx).PlotBody.ToString & " Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") & vbNewLine &
        '        " L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
        '        " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString &
        '        " Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & " Est Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine))
        '    End If

        'Next
        'file.Close()
        'SendMsgBx("Report of Plotted Sights saved in text file: " & ReportName, MessageBoxIcon.Information)
        Exit Sub
    End Sub

    Private Sub cboPlotSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlotSize.SelectedIndexChanged
        If FormCLSLoading = True Then Exit Sub
        'SaveDisplayBMFname()

        SetupandDisplayPlot()
        Exit Sub
    End Sub

    Private Sub chkDisplayRose_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayRose.CheckedChanged
        If FormCLSLoading = True Then Exit Sub
        SetupandDisplayPlot()
    End Sub
    Private Sub SetupandDisplayPlot()

        Grph.Clear(Color.White)
        FormCLSLoading = False
        FirstTimeInit()
        If SetandEditCentralLatLong() = False Then
            Exit Sub
        End If
        SetPlotSideSize()
        'SetPlotInfoFields()
        DrawBasicPlotForm()
        DrawPlots()
        SaveDisplayBMFname()
        Me.Refresh()
        Me.BringToFront()
        Me.Show()
        Exit Sub
    End Sub


    Private Sub txtLatActive_TextChanged(sender As Object, e As EventArgs) Handles txtLatActive.TextChanged
        'SaveDisplayBMFname()
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub txtLongActive_TextChanged(sender As Object, e As EventArgs) Handles txtLongActive.TextChanged
        'SaveDisplayBMFname()
        Me.Refresh()
        Exit Sub
    End Sub
    Private Function FindDestLatLong(ByVal LatIn As Double, ByVal LonIn As Double, ByVal Dist As Double, ByVal Course As Double) As System.Device.Location.GeoCoordinate
        Dim L2 As Double = Math.Sin(LatIn * Math.PI / 180) * Math.Cos(Dist / 3437.75) + Math.Cos(LatIn * Math.PI / 180) * Math.Sin(Dist / 3437.75) * Math.Cos(Course * Math.PI / 180)
        L2 = Math.Atan(L2 / Math.Sqrt(-L2 * L2 + 1))
        Dim Lo2 As Double = -1 * LonIn * Math.PI / 180 - System.Math.Atan2(Math.Sin(Course * Math.PI / 180) * Math.Sin(Dist / 3437.75) * Math.Cos(LatIn * Math.PI / 180), Math.Cos(Dist / 3437.75) - Math.Sin(LatIn * Math.PI / 180) * Math.Sin(L2))
        L2 = L2 * 180 / Math.PI
        Lo2 = Lo2 * 180 / Math.PI
        If Course = 0 And Dist > (90 - LatIn) * 60 Then
            Lo2 = -(180 - Lo2)
        End If
        If Math.Abs(Lo2) > 180 Then
            Lo2 = -Math.Sign(Lo2) * (360 - Math.Abs(Lo2))
        End If
        Dim RtnGC As System.Device.Location.GeoCoordinate = New System.Device.Location.GeoCoordinate(L2, -1 * Lo2)
        Return (RtnGC)
    End Function

    Private Sub PicBoxPlot_MouseClick(sender As Object, e As MouseEventArgs) Handles PicBoxPlot.MouseClick

        Dim XFactor As Integer = PanelPlot.Location.X + PicBoxPlot.Location.X + LeftX - 15 '+ PanelPlot.AutoScrollMargin.Width
        Dim YFactor As Integer = PanelPlot.Location.Y + PicBoxPlot.Location.Y + TopY - 20 '+ PanelPlot.AutoScrollMargin.Height - 20
        Dim CLoc1 As Point = New Point(e.X - XFactor, e.Y - YFactor)

        Dim XFctr As Integer = ((MidX - CLoc1.X) / 50) * 10 * (OneNMLongPixels / OneNmPixels)
        Dim YFctr As Integer = ((MidY - CLoc1.Y) / 50) * 10 '* OneNmPixels
        CLoc1.X += XFctr
        CLoc1.Y += YFctr
        Dim TmpLat As Double = 0
        If CentralLatNS = "N" Then   ' North Latitude
            TmpLat = CentralLat + Convert.ToDouble((((MidY - CLoc1.Y)) / OneNmPixels) / 60)
        Else
            TmpLat = CentralLat - Convert.ToDouble((((MidY - CLoc1.Y)) / OneNmPixels) / 60)
        End If
        Dim TmpLong As Double = 0
        If CentralLongEW = "W" Then   ' West Longitude
            TmpLong = CentralLong + Convert.ToDouble((((MidX - CLoc1.X)) / OneNMLongPixels) / 60)
        Else
            TmpLong = CentralLong - Convert.ToDouble((((MidX - CLoc1.X)) / OneNMLongPixels) / 60)
        End If
        Dim TmpLatD As Double = Int(Math.Abs(TmpLat))
        Dim TmpLatM As Double = Math.Round((Math.Abs(TmpLat) - TmpLatD) * 60, 1)
        Dim TmpLatNS As String = "N"
        If ULLat < 0 Then
            TmpLatNS = "S"
        End If

        Dim TmpLongD As Double = Int(Math.Abs(TmpLong))
        Dim TmpLongM As Double = Math.Round((Math.Abs(TmpLong) - TmpLongD) * 60, 1)
        Dim TmpLongEW As String = "W"
        If ULLong < 0 Then
            TmpLongEW = "E"
        End If
        txtDispLoc.Text = ("Lat=" & TmpLatD.ToString & Chr(176) & " " & TmpLatM.ToString("00.0") & "'" & TmpLatNS &
           " Lo=" & TmpLongD.ToString & Chr(176) & " " & TmpLongM.ToString("00.0") & "'" & TmpLongEW)
        Grph.Clear(Color.White)
        FormCLSLoading = False
        EPLineCount = 0
        EPLineLocY = 575
        FirstTimeInit()
        If SetandEditCentralLatLong() = False Then
            Exit Sub
        End If
        SetPlotSideSize()
        DrawBasicPlotForm()
        DrawPlots()
        Dim dpen1 As Pen = New Pen(Color.DarkBlue)
        dpen1.DashStyle = Drawing2D.DashStyle.DashDotDot
        dpen1.Width = 2
        dpen1.EndCap = Drawing2D.LineCap.ArrowAnchor

        Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), RightX, Convert.ToInt32(CLoc1.Y))
        Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), LeftX, Convert.ToInt32(CLoc1.Y))
        Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), Convert.ToInt32(CLoc1.X), TopY)
        Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), Convert.ToInt32(CLoc1.X), BottomY)

        dpen1.Dispose()
        SaveDisplayBMFname()
        Me.Refresh()
        Me.BringToFront()
        Me.Show()
    End Sub

    Private Sub PicBoxPlot_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxPlot.MouseEnter
        'txtDispLoc.Clear()
        'txtDispLoc.Visible = True
        Me.Cursor = Cursors.UpArrow
    End Sub

    Private Sub PicBoxPlot_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxPlot.MouseLeave
        'txtDispLoc.Clear()
        'txtDispLoc.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

End Class