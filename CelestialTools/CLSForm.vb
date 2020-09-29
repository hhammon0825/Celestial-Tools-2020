Imports System.Device.Location
Imports System.Security.Cryptography.X509Certificates

Public Class CLSForm
    Private OneNmPixels As Double = 12
    Private OneNMLongPixels As Double
    Private ToRad As Double = System.Math.PI / 180
    Private ToDeg As Double = 180 / System.Math.PI
    Private MidX As Integer
    Private MidY As Integer
    Private BottomY As Integer
    Private BottomCenter As Point
    Private CenterofPlot As Point
    Private LeftX As Integer
    Private RightX As Integer
    Private TopY As Integer
    Private TopX As Integer

    Private myPen As New Pen(Color.Black, 2)
    'Private myFont As New Font("Arial", 10, FontStyle.Regular)
    Private ArialFont As Font = New Font("Arial", 8, FontStyle.Bold)
    'Private TimesNewFont As Font = New Font("Times New Roman", 8, FontStyle.Bold)
    Private IssuingSendMsgBx As Boolean = False
    Private CentralLat As Double = 0
    Private CentralLatDeg As Integer
    Private CentralLatMin As Integer
    Private CentralLatNS As String
    Private CentralLong As Double = 0
    Private CentralLongDeg As Integer
    Private CentralLongMin As Integer
    Private CentralLongEW As String
    Public Structure PlotEntry
        ' These 1st 4 fields are common to all plot types and must contain data - they cannot be nothing
        Public PsnName As String
        Public SquadronName As String
        Public PlotNumber As String
        Public PlotType As String ' Sight or Fix or DR or APSight for sight from Alt SR methods - where Lat/Long are AP and real loc is in DRStartLat/Long fields below
        ' The next Fields are for Sight, SightFix, and Fix plots
        ' String field cannot be nothing - must at least contain a null string or " "
        Public PlotBody As String
        Public PlotLatNS As String
        Public PlotLatDeg As String
        Public PlotLatMin As String
        Public PlotLatSec As String
        Public PlotLongEW As String
        Public PlotLongDeg As String
        Public PlotLongMin As String
        Public PlotLongSec As String
        Public PlotAz As String
        Public PlotIntercept As String
        Public PlotSLEP As String
        Public PlotDT As Date
        Public PlotLat As Double
        Public PlotLong As Double
        Public PlotLLoBy As String ' DR, GPS, KP (Known Position), or AP (Assumed Position from Alt SR)
        ' The next fields are for DR Plots
        Public PlotDRCourse As Integer 'True course NNN
        Public PlotDRSpeed As Double  ' Speed as NN.N knots
        Public PlotDRTimeMin As Integer ' Elapsed time in minutes as NNNN
        Public PlotDRDT As DateTime
        Public PlotDREndDT As Date
        Public PlotDRGeoCoord As GeoCoordinate
        Public PlotDRStartLat As Double
        Public PlotDRStartNS As String
        Public PlotDRStartLong As Double
        Public PlotDRStartLongEW As String
        Public PlotDREndLat As Double
        Public PlotDREndNS As String
        Public PlotDREndLong As Double
        Public PlotDREndLongEW As String
        Public PlotExtendedLines As Boolean
    End Structure
    Public PlotArray(0) As PlotEntry
    Private Grph As System.Drawing.Graphics
    Private bm As Bitmap
    Private BMFname As String = "./Graphics/CLSPlotForm.jpg"
    Private DrawWidth As Integer
    Private DPen As Pen = New Pen(Color.Black, 1)
    Private ptA As Point
    Private ptB As Point
    Private myIdx As Integer = 0
    Private FormCLSLoading As Boolean = False
    Public Structure DegMinCalc
        Public CalcDeg As Integer
        Public CalcMin As Integer
    End Structure
    Private DMCalc As DegMinCalc
    Private PlotIntCalc As Double
    Private PlotIntCalcTA As String
    Private PlotAzCalc As Double
    Private PlotLat As Double
    Private PlotLatNS As String
    Private PlotLong As Double
    Private PlotLongEW As String
    Private PlotDRTime As String = vbNullString
    Private PlotEPLat As Double
    Private PlotEPLatNS As String
    Private PlotEPLong As Double
    Private PlotEPLongEW As Double
    Private OrigFormSize As Size
    Private OrigPicBoxSize As Size
    Private PlotTimeCount As Integer = 0
    Private PlotDRTimeCount As Integer = 0
    Private PlotAPTimeCount As Integer = 0
    Private isRunningSunSight As Boolean = False
    Private LatDelta As Double = 0
    Private LongDelta As Double = 0
    Private RunSunSightNum As Integer = 0
    Public Structure SaveSuns
        Public SunIndex As Integer
        Public SunDt As Date
    End Structure
    Public SunArray(0) As SaveSuns
    Public EPLineCount As Integer = 0
    Public EPLineLocX As Integer = 255
    Public EPLineLocY As Integer = 650
    Public EPLineLoc As Point = New Point(EPLineLocX, EPLineLocY)
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
            Dim newplot As PlotEntry = PlotArray(EarlySun)
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
    Public Sub AddPlotEntry(ByVal PlotIn As PlotEntry)
        Dim Idx As Integer = UBound(PlotArray)
        myIdx = Idx
        PlotArray(Idx) = PlotIn
        Idx += 1
        ReDim Preserve PlotArray(Idx)
        Exit Sub
    End Sub
    Public Function PlotSight() As Boolean
        FormCLSLoading = True
        RunningSunSight()

        FirstTimeInitGraphics()
        If SetCentralLatLong() = False Then
            Return False
            Exit Function
        End If
        'SetPlotInfoFields()
        DrawBasicPlotForm()
        DrawPlots()
        SaveDisplayBMFname()
        FormCLSLoading = False
        Return True
        Exit Function
    End Function
    Private Sub CLSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCLSLoading = True
        Dim PlotArray(0)
        OrigFormSize = Me.Size
        OrigPicBoxSize = PicBoxCLS.Size
        PicBoxCLS.SizeMode = PictureBoxSizeMode.StretchImage
        isRunningSunSight = False
        FormCLSLoading = False
    End Sub
    Private Sub FirstTimeInitGraphics()
        bm = New Bitmap(PicBoxCLS.Width, PicBoxCLS.Height)
        bm = Bitmap.FromFile("./CLSForms/cls98plottemplateV1.jpg")
        Grph = PicBoxCLS.CreateGraphics
        Grph = Graphics.FromImage(bm)

        Grph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Grph.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Grph.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        Grph.TranslateTransform(0, 0)
        Dim DPen As Pen = New Pen(Color.Black, 2)

        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point
        Exit Sub
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim newpt As Point = New Point(Me.Location.X + 20, Me.Location.Y)
        Dim newsize As Size = New Size(Me.Size.Width + 120, Me.Size.Height + 40)
        Dim newrect As Rectangle = New Rectangle(newpt, newsize)
        PrintScreen(newrect)
        Exit Sub
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        DPen.Dispose()
        bm.Dispose()
        myPen.Dispose()
        'myFont.Dispose()
        Grph.Dispose()
        Me.Close()
        Exit Sub
    End Sub
    Private Function SetCentralLatLong() As Boolean
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
                LongDiff = HighLong - LowLong
                LongDiffMin = (LongDiff - Int(LongDiff)) * 60
                If LongDiffMin > 59.9 Or Int(LongDiff) > 1 Then
                    SendMsgBx("Error: Distances between all longitudes must be less than 60 miles to plot", MessageBoxIcon.Error)
                    Return False
                    Exit Function
                End If
            End If
        End If

        If UBound(PlotArray) = 1 Then
            CentralLatDeg = Convert.ToInt32(PlotArray(myIdx).PlotLatDeg)
            CentralLatMin = Convert.ToInt32((Int(Convert.ToDouble(PlotArray(myIdx).PlotLatMin))) / 10) * 10
            If CentralLatMin = 60 Then
                CentralLatMin = 0
                CentralLatDeg += 1
            End If
            CentralLat = CentralLatDeg + CentralLatMin / 60
            CentralLongDeg = Convert.ToInt32(PlotArray(myIdx).PlotLongDeg)
            CentralLongMin = Convert.ToInt32((Int(Convert.ToDouble(PlotArray(myIdx).PlotLongMin))) / 10) * 10
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
        CentralLongEW = PlotArray(myIdx).PlotLongEW.Trim
        txtLatActive.Text = CentralLatDeg.ToString("##0") & Chr(176) & " " & CentralLatMin.ToString("00.0") & "' " & CentralLatNS
        txtLongActive.Text = CentralLongDeg.ToString("##0") & Chr(176) & " " & CentralLongMin.ToString("00.0") & "' " & CentralLongEW
        Return True
        Exit Function
    End Function
    Private Sub DrawBasicPlotForm()
        MidX = 411 - 20
        MidY = 509 - 145
        BottomY = 1070 - 145
        BottomCenter = New Point(MidX, BottomY)
        CenterofPlot = New Point(MidX, MidY)
        LeftX = 74 - 20
        RightX = 749 - 20
        TopY = 172 - 145

        OneNmPixels = (RightX - MidX) / 30
        OneNMLongPixels = OneNmPixels * System.Math.Cos(CentralLat * ToRad) ' (BottomY - MidY) / 50 

        Dim LineY As Double = BottomY - OneNmPixels * System.Math.Tan(CentralLat * ToRad) * 30
        Dim LineX As Double = OneNMLongPixels * 30 '(OneNmPixels * 30) * System.Math.Cos(CentralLat * oRad)

        ' draw longitude lines for mid latitude for this plot
        Grph.DrawLine(DPen, BottomCenter, New Point(RightX, Convert.ToInt32(LineY)))
        Grph.DrawLine(DPen, BottomCenter, New Point(LeftX, Convert.ToInt32(LineY)))
        DPen.DashStyle = Drawing2D.DashStyle.Dash
        Dim SingleX As Double = OneNmPixels * System.Math.Cos(CentralLat * ToRad)
        For i = 1 To 3
            LineX = (OneNmPixels * i * 10) * System.Math.Cos(CentralLat * ToRad)
            DPen.DashStyle = Drawing2D.DashStyle.Dash
            Grph.DrawLine(DPen, New Point(MidX + LineX, BottomY), New Point(MidX + LineX, TopY))
            Grph.DrawLine(DPen, New Point(MidX - LineX, BottomY), New Point(MidX - LineX, TopY))
            For j = 0 To 9
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                If j = 5 Then
                    Grph.DrawLine(DPen, New Point(MidX + LineX - SingleX * j, TopY), New Point(MidX + LineX - SingleX * j, TopY + 15))
                    Grph.DrawLine(DPen, New Point(MidX - LineX + SingleX * j, TopY), New Point(MidX - LineX + SingleX * j, TopY + 15))
                Else
                    Grph.DrawLine(DPen, New Point(MidX + LineX - SingleX * j, TopY), New Point(MidX + LineX - SingleX * j, TopY + 10))
                    Grph.DrawLine(DPen, New Point(MidX - LineX + SingleX * j, TopY), New Point(MidX - LineX + SingleX * j, TopY + 10))
                End If
            Next j

        Next i


        DPen.DashStyle = Drawing2D.DashStyle.Solid

        Dim TempStr As String = CentralLatDeg.ToString("##0") & Chr(176) & " " & CentralLatMin.ToString("##0.0") & "' " & CentralLatNS.ToString
        Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, MidY - 5)
        DMCalc.CalcDeg = CentralLatDeg
        DMCalc.CalcMin = CentralLatMin
        DPen.DashStyle = Drawing2D.DashStyle.Dash
        If CentralLatNS = g_LatN Then
            For i = 1 To 3
                Dim Incr1 As Integer = 10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, +10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, MidY - 5 - (OneNmPixels * Incr1))
                If i < 3 Then
                    Grph.DrawLine(DPen, New Point(LeftX, MidY - (OneNmPixels * Incr1)), New Point(RightX, MidY - (OneNmPixels * Incr1)))
                End If
            Next
            DMCalc.CalcDeg = CentralLatDeg
            DMCalc.CalcMin = CentralLatMin
            For i = 1 To 3
                Dim Incr2 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, MidY - 5 - (OneNmPixels * Incr2))
                If i < 3 Then
                    Grph.DrawLine(DPen, New Point(LeftX, MidY - (OneNmPixels * Incr2)), New Point(RightX, MidY - (OneNmPixels * Incr2)))
                End If
            Next
        Else
            For i = 1 To 3
                Dim Incr3 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, MidY - 5 + (OneNmPixels * Incr3))
                If i < 3 Then
                    Grph.DrawLine(DPen, New Point(LeftX, MidY - (OneNmPixels * Incr3)), New Point(RightX, MidY - (OneNmPixels * Incr3)))
                End If
            Next
            DMCalc.CalcDeg = CentralLatDeg
            DMCalc.CalcMin = CentralLatMin
            For i = 1 To 3
                Dim Incr4 As Integer = +10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, +10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLatNS.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, MidY - 5 + (OneNmPixels * Incr4))
                If i < 3 Then
                    Grph.DrawLine(DPen, New Point(LeftX, MidY - (OneNmPixels * Incr4)), New Point(RightX, MidY - (OneNmPixels * Incr4)))
                End If
            Next
        End If

        TempStr = CentralLongDeg.ToString("##0") & Chr(176) & " " & CentralLongMin.ToString("##0.0") & "' " & CentralLongEW.ToString
        Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20, BottomY + 5)
        Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20, TopY - 15)
        DMCalc.CalcDeg = CentralLongDeg
        DMCalc.CalcMin = CentralLongMin
        If CentralLongEW = g_LongW Then
            For i = 1 To 3
                Dim Incr1 As Integer = 10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, 10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr1), BottomY + 5)
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr1), TopY - 15)
            Next
            DMCalc.CalcDeg = CentralLongDeg
            DMCalc.CalcMin = CentralLongMin
            For i = 1 To 3
                Dim Incr2 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr2), BottomY + 5)
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 - (OneNMLongPixels * Incr2), TopY - 15)
            Next
        Else
            For i = 1 To 3
                Dim Incr3 As Integer = 10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, 10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr3), BottomY + 5)
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr3), TopY - 15)
            Next
            DMCalc.CalcDeg = CentralLongDeg
            DMCalc.CalcMin = CentralLongMin
            For i = 1 To 3
                Dim Incr4 As Integer = -10 * i
                CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10)
                TempStr = DMCalc.CalcDeg.ToString("##0") & Chr(176) & " " & DMCalc.CalcMin.ToString("##0.0") & "' " & CentralLongEW.ToString
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr4), BottomY + 5)
                Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20 + (OneNMLongPixels * Incr4), TopY - 15)
            Next
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
    'Private Sub SetPlotInfoFields()
    'txtSummary.Clear()
    'Dim Idx As Integer = 0
    'For Idx = 0 To UBound(PlotArray)
    '    If PlotArray(Idx).PlotType <> Nothing Then
    '        txtSummary.AppendText(PlotArray(Idx).PlotType.ToString & " # " & PlotArray(Idx).PlotNumber.ToString &
    '    " ;Body = " & PlotArray(Idx).PlotBody.ToString & " ;Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") &
    '    " ;L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
    '    " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString &
    '    " ;Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & vbNewLine &
    '    vbTab & PlotArray(Idx).PlotLLoBy & " Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine)
    '    End If
    'Next
    'Exit Sub
    'End Sub
    Private Sub DrawPlots()
        PlotTimeCount = 0
        PlotDRTimeCount = 0
        PlotAPTimeCount = 0
        EPLineCount = 0
        EPLineLocY = 650

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
        PlotDRTimeCount = 0
        PlotAPTimeCount = 0
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
        'PlotIntCalc = Convert.ToDouble(Inttemp)
        'PlotAzCalc = Convert.ToDouble(Aztemp)

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
        Dim DRPoint As Point = New Point(0, 0)
        Dim XlateX As Integer = (FactorEW) * ((CentralLong - PlotLong) * 60) * OneNMLongPixels
        Dim XlateY As Integer = (FactorNS) * ((CentralLat - PlotLat) * 60) * OneNmPixels
        DRPoint.X = MidX + XlateX
        DRPoint.Y = MidY + XlateY

        Grph.DrawArc(myPen, DRPoint.X - 2, DRPoint.Y - 2, 4, 4, 0, 360)
        If PlotArray(idx).PlotLLoBy = "GPS" Then
            Grph.DrawArc(myPen, DRPoint.X - 6, DRPoint.Y - 6, 12, 12, 0, 360)
        Else
            Grph.DrawArc(myPen, DRPoint.X - 6, DRPoint.Y - 6, 12, 12, 180, 180)
        End If
        Grph.DrawLine(myPen, DRPoint.X - 6, DRPoint.Y, DRPoint.X + 6, DRPoint.Y)

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

        Dim DRPointEP As Point = New Point(0, 0)
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
        Grph.DrawArc(myPen, DRPointEP.X - 2, DRPointEP.Y - 2, 4, 4, 0, 360)
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

        ' draw LOP line
        If PlotArray(idx).PlotExtendedLines = True Then
            Grph.DrawLine(myPen, New Point(-(40 * OneNMLongPixels), 0), New Point((40 * OneNMLongPixels), 0))
        Else
            Grph.DrawLine(myPen, New Point(-(20 * OneNMLongPixels), 0), New Point((20 * OneNMLongPixels), 0))
        End If

        ' for a Fix sight draw square where previous line intersects LOP line - do not draw for Sight type
        'If PlotArray(idx).PlotType = "FixSight" Then
        'Grph.DrawRectangle(myPen, -6, -6, 12, 12)
        'End If

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
        Inttemp = Inttemp.Substring(0, Inttemp.IndexOf(g_nm)).Trim
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
        Dim XlateX As Integer = (FactorEW) * ((CentralLong - PlotLong) * 60) * OneNMLongPixels
        Dim XlateY As Integer = (FactorNS) * ((CentralLat - PlotLat) * 60) * OneNmPixels
        DRPoint.X = MidX + XlateX
        DRPoint.Y = MidY + XlateY
        Grph.DrawArc(myPen, DRPoint.X - 1, DRPoint.Y - 1, 2, 2, 0, 360)
        Grph.DrawArc(myPen, DRPoint.X - 2, DRPoint.Y - 2, 4, 4, 0, 360)
        Grph.DrawArc(myPen, DRPoint.X - 8, DRPoint.Y - 8, 16, 16, 0, 360)

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

        'If PlotArray(idx).PlotLLoBy = "AP" Then
        '    PlotTimeCount = PlotAPTimeCount
        'Else
        '    PlotTimeCount = PlotDRTimeCount
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
        Exit Sub
    End Sub

    Private Sub PlotDRType(ByVal idx As Integer)
        Dim index As Integer = idx
        SendMsgBx("PlotType = DR not implemented yet - Contact Celestial Tools Support", MessageBoxIcon.Hand)
        Exit Sub
    End Sub
    Private g_EPLat As String = "EP L "
    Private g_EPLong As String = "EP Lo "
    Private g_SingleQuote As String = "'"
    Private g_nm As String = "nm"
    Public Sub UnStringEP(ByVal EPStrIn As String, ByVal idx As Integer)
        Dim EPLLoc As Integer = EPStrIn.IndexOf(g_EPLat, System.StringComparison.CurrentCulture) + 5
        Dim EPLDegLoc As Integer = EPStrIn.IndexOf(Chr(176))
        Dim EPLMinLoc As Integer = EPStrIn.IndexOf(g_SingleQuote, System.StringComparison.CurrentCulture)
        Dim EPLoLoc As Integer = EPStrIn.IndexOf(g_EPLong, System.StringComparison.CurrentCulture) + 6
        Dim EPLoDegLoc As Integer = EPStrIn.LastIndexOf(Chr(176))
        Dim EPLoMinLoc As Integer = EPStrIn.LastIndexOf(g_SingleQuote, System.StringComparison.CurrentCulture)
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
            Inttemp = Inttemp.Substring(0, Inttemp.IndexOf(g_nm, System.StringComparison.CurrentCulture)).Trim
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
        PicBoxCLS.ImageLocation = BMFname
        PicBoxCLS.Refresh()
        bm.Dispose()
        Exit Sub
    End Sub

    Private Sub PicBoxCLS_Paint(sender As Object, e As PaintEventArgs) Handles PicBoxCLS.Paint
        'Exit Sub
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
        PrintScreen(PicBoxCLS.Bounds)
        Exit Sub
    End Sub

    Private Sub btnPrtSights_Click(sender As Object, e As EventArgs) Handles btnPrtSights.Click
        Dim Idx As Integer = 0
        'Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "")
        'Randomize()
        'Dim RandomInt As Single = Rnd()
        'Dim ReportName As String = "./CLSForms/CLSPlotReport" + NowTimeStr + RandomInt.ToString.Replace(".", "") + ".txt"
        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter(ReportName, False)
        Dim TxtMsg As String = "Plotted Sight Data: "

        For Idx = 0 To UBound(PlotArray)
            If PlotArray(Idx).PlotType <> Nothing Then
                Dim TmpStr As String = (vbNewLine & "Type= " & PlotArray(Idx).PlotType & " " & " Sight #" & PlotArray(Idx).PlotNumber.ToString & " Name = " & PlotArray(Idx).PsnName.ToString & " Squadron = " & PlotArray(Idx).SquadronName.ToString &
                " Body = " & PlotArray(Idx).PlotBody.ToString & " Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") & vbNewLine &
                " L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
                " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString &
                " Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & " " & PlotArray(Idx).PlotLLoBy & " Est Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine)
                'file.WriteLine(TmpStr)
                TxtMsg &= TmpStr
            End If

        Next
        'file.Close()
        Dim CaptionStr As String = "CLS Plot Sight Data"
        Dim unused = MessageBox.Show(TxtMsg, CaptionStr, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'SendMsgBx(TxtMsg.ToString & vbNewLine & "Report of Plotted Sights saved in text file: " & ReportName, MessageBoxIcon.Information)
        Exit Sub
    End Sub
    Private Shared Function FindDestLatLong(ByVal LatIn As Double, ByVal LonIn As Double, ByVal Dist As Double, ByVal Course As Double) As System.Device.Location.GeoCoordinate
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

    Private Sub PicBoxPlot_MouseClick(sender As Object, e As MouseEventArgs) Handles PicBoxCLS.MouseClick
        Dim CLoc1 As Point = New Point(e.X - 11, e.Y - 5)
        Dim XFctr As Integer = ((MidX - CLoc1.X) / 600) * 10 '* (OneNMLongPixels / OneNmPixels)
        Dim YFctr As Integer = ((MidY - CLoc1.Y) / 600) * 10 '* 0.1
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
        If CentralLat < 0 Then
            TmpLatNS = "S"
        End If

        Dim TmpLongD As Double = Int(Math.Abs(TmpLong))
        Dim TmpLongM As Double = Math.Round((Math.Abs(TmpLong) - TmpLongD) * 60, 1)
        Dim TmpLongEW As String = "W"
        If CentralLong < 0 Then
            TmpLongEW = "E"
        End If
        txtDispLoc.Text = ("Lat=" & TmpLatD.ToString & Chr(176) & " " & TmpLatM.ToString("00.0") & "'" & TmpLatNS &
           " Lo=" & TmpLongD.ToString & Chr(176) & " " & TmpLongM.ToString("00.0") & "'" & TmpLongEW)
        Grph.Clear(Color.White)
        FormCLSLoading = False
        FirstTimeInitGraphics()
        If SetCentralLatLong() = False Then
            Exit Sub
        End If

        'SetPlotSideSize()
        DrawBasicPlotForm()
        DrawPlots()
        Dim dpen1 As Pen = New Pen(Color.DarkBlue)
        dpen1.DashStyle = Drawing2D.DashStyle.DashDotDot
        dpen1.Width = 2
        dpen1.EndCap = Drawing2D.LineCap.ArrowAnchor
        Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, RightX, CLoc1.Y)
        Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, LeftX, CLoc1.Y)
        Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, CLoc1.X, TopY)
        Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, CLoc1.X, BottomY)
        dpen1.Dispose()
        SaveDisplayBMFname()
        Me.Refresh()
        Me.BringToFront()
        Me.Show()
    End Sub

    Private Sub PicBoxPlot_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxCLS.MouseEnter
        'txtDispLoc.Clear()
        'txtDispLoc.Visible = True
        Me.Cursor = Cursors.UpArrow

    End Sub

    Private Sub PicBoxPlot_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxCLS.MouseLeave
        'txtDispLoc.Clear()
        'txtDispLoc.Visible = False
        Me.Cursor = Cursors.Default
    End Sub
End Class