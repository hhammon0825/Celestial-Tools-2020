Option Strict Off
Option Explicit On
Friend Class FormMeridianDiagram
    Inherits System.Windows.Forms.Form
    Public L As Double = 0
    Public Ho As Double = 0
    Public ZN As Double = 0
    Public LHA As Double = 0
    Public Dec As Double = 0
    Public FormSRFFlagMD As Boolean = False
    Public FormAltSRFlagMD As Boolean = False
    Dim Pi As Double = System.Math.PI
    Dim ZNoriginal, LHAoriginal As Single
    Dim TwoPi As Double = 2 * Pi
    Dim X2, X1, XAlt, YAlt, Y1, Y2 As Single
    ' Dim M As Double ', B As Double
    'Dim ColorCode As Color
    ' Added March 2017 as part of conversion to DotNet - added bitmap to implement new graphics code in meridian diagram routine
    Dim bm As Bitmap
    Dim BMFname As String = "./Graphics/MeridDiag.jpg"
    Dim meridgraphic As Graphics
    Dim DrawWidth As Integer
    Dim FormMeridianDiagramLoaded As Boolean = False
    Public DrawBasicEqTDiagram As Boolean = False
    Public PtAInt As Point = New Point
    Public PtBInt As Point = New Point
    Public PtCInt As Point = New Point
    Public PtDInt As Point = New Point
    Public PtIntercept As Point = New Point
    Public PNpt As Point = New Point
    Public PSpt As Point = New Point
    Public CtrPt As Point = New Point
    Public BodyName As String = ""
    Public InitialLoad As Boolean = True

    Private Sub MeridianPicBx_Paint(sender As Object, e As PaintEventArgs) Handles MeridianPicBx.Paint
        'If Not FormMeridianDiagramLoaded Then Exit Sub
        'MeridianPicBx.Load(BMFname)
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub CommonTranslate()
        meridgraphic.ResetTransform()
        CtrPt.X = MeridianPicBx.Location.X + (MeridianPicBx.Width / 2) - 10
        CtrPt.Y = MeridianPicBx.Location.Y + (MeridianPicBx.Height / 2) - 35
        meridgraphic.TranslateTransform(CtrPt.X, CtrPt.Y)
        Exit Sub
    End Sub
    Public Sub DisplayMerDiag()
        Dim Y2Dec As Double
        Dim X2Dec As Double
        Dim Y1Dec As Double
        Dim X1Dec As Double
        'Dim Ho As Double
        Dim i As Single ', XAlt As Single, YAlt As Single

        ZNoriginal = ZN
        LHAoriginal = LHA

        Dim drawdelta As Integer = 35
        DrawWidth = (MeridianPicBx.Width / 2) - drawdelta

        bm = New Bitmap(MeridianPicBx.Width, MeridianPicBx.Height)
        meridgraphic = Graphics.FromImage(bm)
        meridgraphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        meridgraphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        meridgraphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

        Dim LatStr As String = ""
        Dim Decstr As String = ""
        Dim LHAstr As String = ""
        Dim tmpLDeg As Double = 0
        Dim tmpLMin As Double = 0
        Dim tmpDec As Double = 0
        Dim tmpLHADeg As Double = 0
        Dim tmpLHAMin As Double = 0
        If DrawBasicEqTDiagram = False Then
            Dim tempLat As Double = 0
            If L < 0 Then
                tempLat = -L
                'tmpLDeg = -Int(L)
                'tmpLMin = (-L - tmpLDeg) * 60
            Else
                tempLat = L
                'tmpLDeg = Int(L)
                'tmpLMin = (L - tmpLDeg) * 60
            End If
            tmpLDeg = Int(tempLat)
            tmpLMin = (tempLat - tmpLDeg) * 60

            tmpLHADeg = Convert.ToDouble(Int(LHAoriginal))
            tmpLHAMin = (LHAoriginal - tmpLHADeg) * 60
            LHAstr = tmpLHADeg.ToString("##0") & Chr(176) & " " & tmpLHAMin.ToString("#0.0") & "'"

            LatStr = tmpLDeg.ToString("##0") & Chr(176)
            If L < 0 Then
                LatStr &= tmpLMin.ToString("#0.0") & "'" & g_LatS
            Else
                LatStr &= tmpLMin.ToString("#0.0") & "'" & g_LatN
            End If

            If Dec < 0 Then
                tmpDec = -Dec
            Else
                tmpDec = Dec
            End If
            Dim DecDeg As Double = Int(tmpDec)
            Dim DecMin As Double = (tmpDec - DecDeg) * 60
            Decstr = DecDeg.ToString("#0") & Chr(176) & " " & DecMin.ToString("#0.0") & "'"  'tmpDec.ToString("#0.0") & Chr(176)

            If Dec < 0 Then
                Decstr &= g_LatS
            Else
                Decstr &= g_LatN
            End If

            Dim HoDeg As Integer = Int(Ho)
            Dim HoMin As Double = (Ho - HoDeg) * 60
            Dim HoStr As String = HoDeg.ToString("#0") & Chr(176) & " " & HoMin.ToString("#0.0") & "'"
            If BodyName = "" Then
                meridgraphic.DrawString("Lat: " & LatStr & vbCrLf &
                                    "LHA: " & LHAstr & vbCrLf &
                                    "Zn : " & System.Math.Round(ZNoriginal, 0, MidpointRounding.AwayFromZero).ToString("##0") & Chr(176) & vbCrLf &
                                    "Ho : " & HoStr & vbCrLf &
                                    "Dec: " & Decstr, New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, 15, 15)
            Else
                meridgraphic.DrawString("Body: " & BodyName & vbCrLf &
                                    "Lat: " & LatStr & vbCrLf &
                                    "LHA: " & LHAstr & vbCrLf &
                                    "Zn : " & System.Math.Round(ZN, 0, MidpointRounding.AwayFromZero).ToString("##0") & Chr(176) & vbCrLf &
                                    "Ho : " & HoStr & vbCrLf &
                                    "Dec: " & Decstr, New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, 15, 15)
            End If
        End If

        CommonTranslate()

        Dim DPen As Pen = New Pen(Color.Black, 2)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point

        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0

        'Me.Circle(0, 0), 3000

        meridgraphic.DrawEllipse(DPen, -DrawWidth, -DrawWidth, 2 * DrawWidth, 2 * DrawWidth)
        meridgraphic.FillEllipse(Brushes.LightGoldenrodYellow, -DrawWidth, -DrawWidth, 2 * DrawWidth, 2 * DrawWidth)
        'draw the N / S horizon line
        ptA.X = -1 * DrawWidth
        ptA.Y = 0
        ptB.X = DrawWidth
        ptB.Y = 0
        meridgraphic.DrawLine(DPen, ptA, ptB)
        meridgraphic.DrawString(g_LatN, New Font("Arial", 10, FontStyle.Bold), Brushes.DarkBlue, -1 * DrawWidth - 20, -6)
        meridgraphic.DrawString(g_LatS, New Font("Arial", 10, FontStyle.Bold), Brushes.DarkBlue, DrawWidth + 20, 6)
        meridgraphic.DrawString("Visible Horizon", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, 20, -12)
        'draw the Zenith / Nadir line
        ptA.X = 0
        ptA.Y = -1 * DrawWidth
        ptB.X = 0
        ptB.Y = DrawWidth
        meridgraphic.DrawLine(DPen, ptA, ptB)
        meridgraphic.DrawString("Z at Lat=" & LatStr, New Font("Arial", 10, FontStyle.Bold), Brushes.DarkBlue, -10, -DrawWidth - 20)
        meridgraphic.DrawString("Na at Lat=" & LatStr, New Font("Arial", 10, FontStyle.Bold), Brushes.DarkBlue, -3, DrawWidth + 15)

        'draw the 5 degree and 10 degree tick marks on the surrounding circle
        Dim DPenC As Pen = New Pen(Color.Black, 1)
        For i = 0 To 359
            If i Mod 10 = 0 Then
                ptA.X = DrawWidth + 3  '* System.Math.Cos(i * Pi / 180)
                'ptA.Y = DrawWidth * System.Math.Sin(i * Pi / 180)
                ptB.X = (DrawWidth - 10)   '* System.Math.Cos(i * Pi / 180)
                'ptB.Y = (DrawWidth - 10) * System.Math.Sin(i * Pi / 180)
            ElseIf i Mod 5 = 0 Then
                ptA.X = DrawWidth  '* System.Math.Cos(i * Pi / 180)
                'ptA.Y = DrawWidth * System.Math.Sin(i * Pi / 180)
                ptB.X = (DrawWidth - 5)  '* System.Math.Cos(i * Pi / 180)
                'ptB.Y = (DrawWidth - 5) * System.Math.Sin(i * Pi / 180)
            Else
                ptA.X = DrawWidth  '* System.Math.Cos(i * Pi / 180)
                'ptA.Y = DrawWidth * System.Math.Sin(i * Pi / 180)
                ptB.X = (DrawWidth - 3) '* System.Math.Cos(i * Pi / 180)
                'ptB.Y = (DrawWidth - 3) * System.Math.Sin(i * Pi / 180)
            End If
            meridgraphic.DrawLine(DPenC, ptA.X, 0, ptB.X, 0)
            meridgraphic.RotateTransform(1)
        Next
        If DrawBasicEqTDiagram = True Then
            DrawBasicEqTDiagram = False
            GoTo ExitDrawTime
        End If

        CommonTranslate()

        meridgraphic.RotateTransform(L)
        'Draw the celestial equator line Q / Q' based on the Latitude L. Write the strings Q & Q' at each end
        DPen.Color = Color.Blue
        meridgraphic.DrawLine(DPen, DrawWidth, 0, -DrawWidth, 0)
        meridgraphic.DrawString("Q ", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, 0, -DrawWidth - 12)
        meridgraphic.DrawString("Q'", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, 0, DrawWidth + 12)
        meridgraphic.RotateTransform(-90)
        meridgraphic.DrawString("Celestial Equator", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, 20, -12)
        CommonTranslate()
        meridgraphic.RotateTransform(L)
        DPen.Color = Color.Black

        DPen.Color = Color.Blue
        meridgraphic.DrawLine(DPen, 0, -DrawWidth, 0, DrawWidth)
        'Draw the Pole North (Pn) and Pole South (Ps) line and ending strings - based on Latitude L 
        If System.Math.Sign(L) = 1 Or System.Math.Sign(L) = 0 Then
            meridgraphic.DrawString("Pn", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, -DrawWidth - 15, 0)
            meridgraphic.DrawString("Ps", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, DrawWidth + 15, 0)
            DPen.Color = Color.Black
        End If

        'South Pole
        If System.Math.Sign(L) = -1 Then
            meridgraphic.DrawString("Pn", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, DrawWidth + 15, 0)
            meridgraphic.DrawString("Ps", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkBlue, -DrawWidth - 15, 0)
            DPen.Color = Color.Black
        End If
        'meridgraphic.ResetTransform()
        CommonTranslate()

        DPen.Color = Color.DarkRed
        meridgraphic.RotateTransform(90)
        XAlt = DrawWidth * System.Math.Cos((-Ho) * Pi / 180)
        YAlt = DrawWidth * System.Math.Sin((-Ho) * Pi / 180)
        CommonTranslate()
        ptA.X = XAlt
        ptA.Y = YAlt
        PtAInt = ptA

        ptB.X = -XAlt
        ptB.Y = YAlt
        PtBInt = ptB

        meridgraphic.DrawLine(DPen, ptA, ptB)
        meridgraphic.DrawString("Ho=" & Ho.ToString("#0.0") & Chr(176) & " above horizon", New Font("Arial", 8, FontStyle.Bold), Brushes.DarkRed, ptB.X + 25, ptB.Y - 12)

        DPen.Color = Color.Green
        'Draw the declination line based on Latitude L, Declination dec.
        X1Dec = DrawWidth * System.Math.Cos(-((90 - L) + Dec) * Pi / 180)
        Y1Dec = DrawWidth * System.Math.Sin(-((90 - L) + Dec) * Pi / 180)
        ptA.X = X1Dec
        ptA.Y = Y1Dec
        PtCInt = ptA

        X2Dec = -DrawWidth * System.Math.Cos(-((90 - L) - Dec) * Pi / 180)
        Y2Dec = -DrawWidth * System.Math.Sin(-((90 - L) - Dec) * Pi / 180)
        ptB.X = X2Dec
        ptB.Y = Y2Dec
        PtDInt = ptB

        meridgraphic.RotateTransform(-(90 - L))
        X1Dec = DrawWidth * System.Math.Cos(-(Dec) * Pi / 180)
        Y1Dec = DrawWidth * System.Math.Sin(-(Dec) * Pi / 180)
        ptA.X = X1Dec
        ptA.Y = Y1Dec
        ptB.X = -X1Dec
        ptB.Y = Y1Dec
        meridgraphic.DrawLine(DPen, ptA, ptB)
        meridgraphic.DrawString("Dec " & Decstr & " of celestial equator", New Font("Arial", 8, FontStyle.Bold), Brushes.Green, ptB.X + 25, ptB.Y - 12)
        meridgraphic.RotateTransform((90 - L))
        CommonTranslate()

        PtIntercept = GetIntersection(PtAInt, PtBInt, PtCInt, PtDInt)
        'If PtIntercept.X = 0 And PtIntercept.Y = 0 Then ' this is when the Dec and Ho are parallel lines or have no intersection
        '    ErrorMsgBox("Dec and Ho lines are parallel lines. They have no intersection for plotting Point M or LHA and Zn ")
        '    GoTo ExitDrawTime
        'End If
        meridgraphic.DrawEllipse(DPen, PtIntercept.X - 5, PtIntercept.Y - 5, 10, 10)
        meridgraphic.FillEllipse(DPen.Brush, PtIntercept.X - 5, PtIntercept.Y - 5, 10, 10)
        meridgraphic.DrawString("M", New Font("Arial", 10, FontStyle.Bold), DPen.Brush, PtIntercept.X - 20, PtIntercept.Y - 20)

        If chkDispZnLHA.CheckState = CheckState.Checked Then
            Ellipses()
        End If

        If chkTwiLites.CheckState = CheckState.Checked Then
            DisPlayTwiLights()
        End If

ExitDrawTime:
        If System.IO.File.Exists(BMFname) Then
            System.IO.File.Delete(BMFname)
        End If
        bm.Save(BMFname)
        MeridianPicBx.ImageLocation = BMFname
        bm.Dispose()
        MeridianPicBx.Refresh()
        Exit Sub
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Form_Initialize_Renamed()
        Pi = System.Math.PI ' 4 * System.Math.Atan(1.0#)
        TwoPi = 8 * System.Math.PI '  System.Math.Atan(1)
        Exit Sub
    End Sub
    Private Sub FormMeridianDiagram_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Form_Initialize_Renamed()
        DisplayMerDiag()
        MeridianPicBx.Refresh()
        FormMeridianDiagramLoaded = True
    End Sub

    Private Sub chkTwiLites_CheckedChanged(sender As Object, e As EventArgs) Handles chkTwiLites.CheckedChanged
        If Not FormMeridianDiagramLoaded Then Exit Sub
        DisplayMerDiag()
        Exit Sub
    End Sub

    Private Sub chkDispZnLHA_CheckedChanged(sender As Object, e As EventArgs) Handles chkDispZnLHA.CheckedChanged
        If Not FormMeridianDiagramLoaded Then Exit Sub
        DisplayMerDiag()
        Exit Sub
    End Sub

    Public Sub Ellipses()
        Dim Y3 As Integer = 0
        Dim X3 As Integer = 0
        Dim SignY3 As Integer = 0
        Dim SignX3 As Integer = 0
        Dim Length As Integer = 0
        Dim y As Integer = 0
        Dim x As Integer = 0
        Dim DPen As Pen = New Pen(Color.Black, 2)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0
        Dim ZNCalc As Double = 0
        If ZN > 180 Then
            ZNCalc = 360 - ZN
        Else
            ZNCalc = ZN
        End If
        Dim ColorCode As Color = System.Drawing.Color.Magenta
        'construction line
        DPen.DashStyle = Drawing2D.DashStyle.Dot
        DPen.Color = Color.DarkMagenta
        x = DrawWidth * System.Math.Cos(-((180 - ZNCalc) * Pi / 180))
        y = DrawWidth * System.Math.Sin(-((180 - ZNCalc) * Pi / 180))

        'draw Zn tangent line and label
        ptA.X = x
        Dim SaveX As Integer = x
        ptA.Y = y
        Dim SaveY As Integer = y
        ptB.X = x
        ptB.Y = -y
        meridgraphic.DrawLine(DPen, ptA, ptB)
        'x = 15 * System.Math.Cos(-((180 - ZNCalc) * Pi / 180))
        'y = 15 * System.Math.Sin(-((180 - ZNCalc) * Pi / 180))
        Dim ZnFont As Font = New Font("Arial", 10, FontStyle.Bold)

        If L < 0 Then ' is Lat South
            meridgraphic.DrawString("Zn", ZnFont, Brushes.DarkMagenta, ptB.X - 10 - StrWidth("Zn", ZnFont), 0)
        Else
            meridgraphic.DrawString("Zn", ZnFont, Brushes.DarkMagenta, ptA.X + 10, 0)
        End If
        DPen.DashStyle = Drawing2D.DashStyle.Dash
        ' draw ZN arc 
        DPen.Color = Color.DarkBlue
        If x < 0 Then
            meridgraphic.DrawArc(DPen, SaveX, -DrawWidth, 2 * System.Math.Abs(SaveX), 2 * DrawWidth, 90, 180)
        Else
            meridgraphic.DrawArc(DPen, -SaveX, -DrawWidth, 2 * System.Math.Abs(SaveX), 2 * DrawWidth, 270, 180)
        End If

        'X1, Y1 and X2,Y2 are the two possible ends of the construction line, where it hits meridian circle
        DPen.DashStyle = Drawing2D.DashStyle.Dot

        Dim X1Angle As Double = -(LHAoriginal + 90 - L)
        Dim X2Angle As Double = -(90 - LHAoriginal - L)
        Dim LSlope As Double = (X2Angle - X1Angle) / 2
        Dim X3calc As Integer = (DrawWidth * System.Math.Cos(LSlope * Pi / 180))
        Dim Y3calc As Integer = (DrawWidth * System.Math.Sin(LSlope * Pi / 180))

        X3 = PtIntercept.X
        Y3 = PtIntercept.Y

        X1 = DrawWidth * System.Math.Cos(X1Angle * Pi / 180)
        Y1 = DrawWidth * System.Math.Sin(X1Angle * Pi / 180)
        X2 = DrawWidth * System.Math.Cos(X2Angle * Pi / 180)
        Y2 = DrawWidth * System.Math.Sin(X2Angle * Pi / 180)
        DPen.Color = Color.Crimson
        DPen.Brush = Brushes.Crimson
        meridgraphic.DrawEllipse(DPen, X3 - 5, Y3 - 5, 10, 10)
        meridgraphic.FillEllipse(DPen.Brush, X3 - 5, Y3 - 5, 10, 10)
        meridgraphic.DrawString("M", ZnFont, DPen.Brush, X3 - 20, Y3 - 20)

        ' DarkGreen is the Pen color for the LHA lines, arcs, and strings
        DPen.Color = Color.DarkGreen
        'Dim StartAngle As Integer = (-180 + L)
        DPen.DashStyle = Drawing2D.DashStyle.Dash
        ' draw tangent line to LHA arc
        meridgraphic.DrawLine(DPen, X1, Y1, X2, Y2)

        ' get the end points of the Q - Q' line and calculate the intersection with the LHA tangent line - the coordinates value defines the width of LHA arc
        ' because of graphics rotation and translation used to prepare plot, the calc below for the Q-Q' line are required
        Dim tmpPT1 As Point = New Point(DrawWidth * System.Math.Cos((90 - L) * (Pi / 180)), -DrawWidth * System.Math.Sin((90 - L) * (Pi / 180)))
        Dim tmpPT2 As Point = New Point(-DrawWidth * System.Math.Cos((90 - L) * (Pi / 180)), DrawWidth * System.Math.Sin((90 - L) * (Pi / 180)))
        ' get the intersection of the tangent line and the Q-Q' line
        Dim tmpInt As Point = GetIntersection(New Point(X1, Y1), New Point(X2, Y2), tmpPT1, tmpPT2)
        If tmpInt.X = 0 And tmpInt.Y = 0 Then
            ' this error message editted out due to erratic error messages while plots were good
            'ErrorMsgBox("LHA and Q-Q' have no intersection and cannot be plotted - check data")
            Exit Sub
        End If
        DPen.Color = Color.DarkGreen
        Length = System.Math.Sqrt((tmpInt.X) ^ 2 + (tmpInt.Y) ^ 2)
        Dim LHAFont As Font = New Font("Arial", 8, FontStyle.Bold)
        If L < 0 Then
            meridgraphic.DrawString("LHA", LHAFont, Brushes.DarkGreen, tmpInt.X - 10 - StrWidth("LHA", LHAFont), tmpInt.Y)
        Else
            meridgraphic.DrawString("LHA", LHAFont, Brushes.DarkGreen, tmpInt.X + 10, tmpInt.Y)
        End If

        Dim PnRect As Rectangle = New Rectangle(New Point(-Length, -DrawWidth), New Size(2 * System.Math.Abs(Length), 2 * DrawWidth))
        ' new reset to standard graphics translate and rotate setting and then rotate drawwing for LHA arc
        CommonTranslate()
        meridgraphic.RotateTransform(-(90 - L))
        If L >= 0 Then ' if lat is N 
            If tmpInt.X < 0 Then
                meridgraphic.DrawArc(DPen, PnRect, 90, 180)
            Else
                meridgraphic.DrawArc(DPen, PnRect, -90, 180)
            End If
        Else ' else if Lat is S
            If tmpInt.X < 0 Then
                meridgraphic.DrawArc(DPen, PnRect, -90, 180)
            Else
                meridgraphic.DrawArc(DPen, PnRect, +90, 180)
            End If
        End If

        DPen.Dispose()
        ZnFont.Dispose()
        CommonTranslate()
        Exit Sub
    End Sub
    'Private Sub Circles()
    'Dim sign As Integer = 1
    'Dim M2h As Double = 0
    'Dim M1h As Double = 0
    'Dim Dec As Double = 0
    'Dim Y3 As Double = 0
    'Dim X3 As Double = 0
    'Dim y2h As Double = 0
    'Dim x2h As Double = 0
    'Dim y1h As Double = 0
    'Dim x1h As Double = 0
    'Dim Theta As Double = 0
    'Dim Z As Double = 0
    'Dim EndPoint As Single = 0
    'Dim m2V As Double = 0
    'Dim m1V As Double = 0
    'Dim DPen As Pen = New Pen(Color.Black, 2)
    'DPen.DashStyle = Drawing2D.DashStyle.Solid
    'Dim ptA As Point = New Point
    'Dim ptB As Point = New Point
    'ptA.X = 0
    'ptA.Y = 0
    'ptB.X = 0
    'ptB.Y = 0
    ''Body is at XBody, YAlt
    ''vertical circle
    'If XBody = 0 Then
    '    XBody = 1.0E-21
    'End If
    'm1V = (YAlt - DrawWidth) / (XBody - 0)
    'm2V = (-(DrawWidth) - YAlt) / (0 - XBody)
    'oxV = (m1V * m2V * (-DrawWidth - DrawWidth) + m1V * (XBody + 0) - m2V * (0 + XBody)) / (2 * (m1V - m2V))
    'oyV = 0
    'radiusV = System.Math.Sqrt((XBody - oxV) * (XBody - oxV) + (YAlt - 0) * (YAlt - 0))
    'If oxV >= 0 Then
    '    StartPoint = Pi - System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
    'Else
    '    StartPoint = 2 * Pi - System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
    'End If
    'If oxV >= 0 Then
    '    EndPoint = Pi + System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
    'Else
    '    EndPoint = System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
    'End If
    'If System.Math.Abs(oxV) < 0.0001 And (ZNoriginal < 90 Or ZNoriginal > 270) Then
    '    DPen.DashStyle = Drawing2D.DashStyle.Solid
    '    DPen.Color = Color.DarkMagenta
    '    meridgraphic.DrawArc(DPen, 0, 0, DrawWidth, DrawWidth, Pi / 2, 3 * Pi / 2)
    'End If
    'If System.Math.Abs(oxV) < 0.0001 And (ZNoriginal < 90 And ZNoriginal > 270) Then
    '    DPen.DashStyle = Drawing2D.DashStyle.Dash
    '    DPen.Color = Color.Magenta
    '    meridgraphic.DrawArc(DPen, 0, 0, DrawWidth, DrawWidth, 3 * Pi / 2, Pi / 2)
    'End If
    'DPen.DashStyle = Drawing2D.DashStyle.Solid

    'If ZNoriginal < 180 Then
    '    DPen.DashStyle = Drawing2D.DashStyle.Dash
    'End If
    'If ZNoriginal = 90 Then
    '    DPen.DashStyle = Drawing2D.DashStyle.Dash
    '    DPen.Color = Color.Magenta
    '    ptA.X = 0
    '    ptA.Y = DrawWidth
    '    ptB.X = 0
    '    ptB.Y = -DrawWidth
    '    meridgraphic.DrawLine(DPen, ptA, ptB)
    'End If
    'If ZNoriginal = 270 Then
    '    DPen.DashStyle = Drawing2D.DashStyle.Solid
    '    DPen.Color = Color.Magenta
    '    ptA.X = 0
    '    ptA.Y = DrawWidth
    '    ptB.X = 0
    '    ptB.Y = -DrawWidth
    '    meridgraphic.DrawLine(DPen, ptA, ptB)
    'End If
    'DPen.DashStyle = Drawing2D.DashStyle.Solid
    'If ZNoriginal <> 90 And ZNoriginal <> 270 And System.Math.Abs(oxV) >= 0.0001 And radiusV < 10000000000.0# Then
    '    DPen.Color = Color.Magenta
    '    meridgraphic.DrawArc(DPen, oxV, Convert.ToInt32(oxH), radiusV, radiusH, StartPoint, EndPoint)
    '    'Me.Circle(oxV, oyV), radiusV, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta), StartPoint, EndPoint 'And Abs(oxV) >= 0.0001
    'End If

    ''construction line
    ''point where vertical circle intersects horizon is (oxV+radiusV,0), but can be on either side of y axis
    'X1 = radiusV - System.Math.Abs(oxV)
    ''point where construction line intersects meridian circle is (oxV + radiusV,3000*sin(arccos((oxV + radiusV)/3000)
    'Z = X1 / DrawWidth
    'If Z = 1 Then Z = -0.99999999999999
    'Theta = System.Math.Atan(-Z / System.Math.Sqrt(-Z * Z + 1)) + Pi / 2 'arccos
    'Y2 = (DrawWidth * System.Math.Sin(Theta))
    'If ZNoriginal >= 180 Then Y2 = -Y2
    'If oxV >= 0 Then X1 = -X1
    'DPen.DashStyle = Drawing2D.DashStyle.Dot
    'DPen.Color = Color.Magenta
    'ptA.X = X1
    'ptA.Y = 0
    'ptB.X = X1
    'ptB.Y = Y2
    'meridgraphic.DrawLine(DPen, ptA, ptB)
    ''hour circle
    ''End points for hour circle are X1H=-3000*cos(L*Pi/180),Y1H=3000*sin(L*Pi/180),X2H=3000*cos(L*Pi/180),Y2H=-3000*sin(L*Pi/180) referred to original circle
    'x1h = -DrawWidth * System.Math.Cos(L * Pi / 180)
    'y1h = DrawWidth * System.Math.Sin(L * Pi / 180)
    'x2h = DrawWidth * System.Math.Cos(L * Pi / 180)
    'y2h = -DrawWidth * System.Math.Sin(L * Pi / 180)
    'If 90 - System.Math.Abs(Dec) <= 0.0006 Then
    '    XBody = X3
    '    YAlt = Y3
    'End If
    'M1h = (YAlt - y1h) / (XBody - x1h) ': If Abs(YAlt - y1h) < 0.01 Then M1h = 0
    'M2h = (y2h - YAlt) / (x2h - XBody) ': If Abs(y2h - YAlt) < 0.01 Then M2h = 0
    'If M1h = M2h Then Exit Sub
    'oxH = (M1h * M2h * (y2h - y1h) + M1h * (XBody + x2h) - M2h * (x1h + XBody)) / (2 * (M1h - M2h))
    'If oxH > 214716800.0# Then oxH = 214716800.0# 'was 2183349376
    'If oxH < -2183356799.0# Then oxH = -2183356799.0#
    'oyH = ((-1 / M1h) * (oxH - (x1h + XBody) / 2) + (y1h + YAlt) / 2)
    'If oyH > 2199896192.0# Then oyH = 2199896192.0#
    'If oyH < -2199889024.0# Then oyH = -2199889024.0#
    'radiusH = System.Math.Sqrt((XBody - oxH) * (XBody - oxH) + (YAlt - oyH) * (YAlt - oyH))

    ''NEED FOUR CONDITIONS?
    'If oxH >= 0 And oyH >= 0 Then
    '    StartPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
    '    EndPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH)) + 2 * Pi
    '    sign = -1
    'End If
    'If oxH >= 0 And oyH < 0 Then
    '    StartPoint = Pi + System.Math.Atan((y2h - oyH) / (x2h - oxH))
    '    EndPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
    '    sign = 1
    'End If
    'If oxH < 0 And oyH >= 0 Then
    '    StartPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
    '    EndPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH)) + 2 * Pi
    '    sign = -1
    'End If
    'If oxH < 0 And oyH < 0 Then
    '    StartPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH))
    '    EndPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
    '    sign = 1
    'End If
    ''x = (y1h - oyH) / radiusH

    'If System.Math.Abs(StartPoint - EndPoint) >= Pi Then EndPoint = EndPoint - Pi
    'If StartPoint < 0 Then StartPoint = StartPoint + 2 * Pi
    'If StartPoint > 2 * Pi Then StartPoint = StartPoint - 2 * Pi
    'If StartPoint > EndPoint And StartPoint < EndPoint + Pi Then StartPoint = StartPoint - Pi
    'If EndPoint < 0 Then EndPoint = EndPoint + 2 * Pi
    'If EndPoint > 2 * Pi Then EndPoint = EndPoint - 2 * Pi

    'If oxH < 0 And oyH >= 0 Then
    '    StartPoint = StartPoint + Pi
    '    EndPoint = EndPoint + Pi
    '    If StartPoint > 2 * Pi Then StartPoint = StartPoint - 2 * Pi
    '    If EndPoint > 2 * Pi Then EndPoint = EndPoint - 2 * Pi
    'End If

    'DPen.DashStyle = Drawing2D.DashStyle.Solid

    'If ZNoriginal < 180 Then DPen.DashStyle = Drawing2D.DashStyle.Dash
    'DPen.Color = Color.Magenta
    'meridgraphic.DrawArc(DPen, Convert.ToInt32(oxH), Convert.ToInt32(oyH), radiusV, radiusH, StartPoint, EndPoint)

    ''construction line
    ''point where hour circle intersects equator is (X1,Y1)
    'X1 = radiusH * System.Math.Sin(L * Pi / 180) + sign * oxH
    'X1 = sign * X1
    'Y1 = (radiusH * System.Math.Cos(L * Pi / 180) + sign * oyH)
    'Y1 = sign * Y1
    'DPen.DashStyle = Drawing2D.DashStyle.Dot
    'M = -System.Math.Sin(L * Pi / 180) / System.Math.Cos(L * Pi / 180)
    'X2 = X1
    'Do
    '    X2 = X2 + SlopeEDir
    '    Y2 = Y1 + M * (X2 - X1)
    '    'Debug.Print Abs(9000000 - (X2 * X2 + Y2 * Y2))
    'Loop Until System.Math.Abs(9000000 - (X2 * X2 + Y2 * Y2)) < 15000
    'ptA.X = X1
    'ptA.Y = Y1
    'ptB.X = X2
    'ptB.Y = Y2
    'DPen.Color = Color.DarkBlue
    'meridgraphic.DrawLine(DPen, ptA, ptB)
    'DPen.DashStyle = Drawing2D.DashStyle.Solid
    'Exit Sub
    'End Sub

    Private Sub FormMeridianDiagram_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
    Private Sub optEllipse_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Not FormMeridianDiagramLoaded Then Exit Sub
        DisplayMerDiag()
        Exit Sub
    End Sub
    Public Function GetIntersection(ByVal A As Point, ByVal B As Point, ByVal C As Point, ByVal D As Point) As Point
        Dim dy1 As Double = B.Y - A.Y
        Dim dx1 As Double = B.X - A.X
        Dim dy2 As Double = D.Y - C.Y
        Dim dx2 As Double = D.X - C.X
        'Dim p As New Point
        'check whether the two line parallel
        If dy1 * dx2 = dy2 * dx1 Then
            'ErrorMsgBox("Lines for intersection are parallel - No point of intersection to plot")
            'Return P with a specific data
            Dim pbad As Point = New Point(0, 0)
            Return pbad
        Else
            Dim x As Double = ((C.Y - A.Y) * dx1 * dx2 + dy1 * dx2 * A.X - dy2 * dx1 * C.X) / (dy1 * dx2 - dy2 * dx1)
            Dim y As Double = A.Y + (dy1 / dx1) * (x - A.X)
            Dim p As Point = New Point(x, y)
            Return p
        End If
    End Function

    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
    Private Sub DisPlayTwiLights()
        Dim DPen As Pen = New Pen(Color.Black, 2) With {.DashStyle = Drawing2D.DashStyle.Dot}
        Dim FontArial8Bold As Font = New Font("Arial", 8, FontStyle.Bold)
        'DPen.DashStyle = Drawing2D.DashStyle.Dot
        Dim CivilTwi As Double = 6 * Pi / 180
        Dim NauticalTwi As Double = 12 * Pi / 180
        Dim AstroTwi As Double = 18 * Pi / 180
        Dim x1 As Integer = DrawWidth * System.Math.Cos(CivilTwi)
        Dim y1 As Integer = DrawWidth * System.Math.Sin(CivilTwi)
        Dim x2 As Integer = -x1
        Dim y2 As Integer = y1
        meridgraphic.DrawLine(DPen, x1, y1, x2, y2)
        meridgraphic.DrawString("6" & Chr(176) & " Civil Twilight", FontArial8Bold, Brushes.Black, x2 + 20, y2 - 11)
        x1 = DrawWidth * System.Math.Cos(NauticalTwi)
        y1 = DrawWidth * System.Math.Sin(NauticalTwi)
        x2 = -x1
        y2 = y1
        meridgraphic.DrawLine(DPen, x1, y1, x2, y2)
        meridgraphic.DrawString("12" & Chr(176) & " Nautical Twilight", FontArial8Bold, Brushes.Black, x2 + 20, y2 - 11)
        x1 = DrawWidth * System.Math.Cos(AstroTwi)
        y1 = DrawWidth * System.Math.Sin(AstroTwi)
        x2 = -x1
        y2 = y1
        meridgraphic.DrawLine(DPen, x1, y1, x2, y2)
        meridgraphic.DrawString("18" & Chr(176) & " Astronomical Twilight", FontArial8Bold, Brushes.Black, x2 + 20, y2 - 11)
        DPen.Dispose()
        FontArial8Bold.Dispose()
        Exit Sub
    End Sub
    Private Function StrWidth(ByVal StrIn As String, ByVal FontIn As Font) As Integer
        Dim measureString As String = StrIn
        Dim stringSize As SizeF = New SizeF()
        Dim E As PaintEventArgs = New PaintEventArgs(meridgraphic, Rectangle.Round(meridgraphic.ClipBounds))
        stringSize = E.Graphics.MeasureString(measureString, FontIn)
        Return Convert.ToInt32(stringSize.Width)
        Exit Function
    End Function
End Class