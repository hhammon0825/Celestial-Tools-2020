Public Class SRFTimeDiagram

    Private bm As Bitmap
    Private BMFname As String = "./Graphics/TimeDiagram.jpg"
    Private TDgraphics As Graphics

    Private DrawBasicTimeDiagram As Boolean = False
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub SRFTimeDiagram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DrawEqTDiagram = False
        If FormSRF.BNType = "Sun" Then
            chkDispEqt.Visible = True
        Else
            chkDispEqt.Visible = False
        End If
        DisplayTimeDiagram()
        Exit Sub
    End Sub
    Public Sub DisplayTimeDiagram()
        Dim XTD1, YTD1 As Single
        Dim XTD2 As Single
        Dim TwoPi, i As Single
        'FormSRF.Font.Name = "MS Sans Serif"
        TwoPi = 8 * System.Math.Atan(1)
        EqtPicBx.Enabled = True
        EqtPicBx.Visible = True

        'set up fresh / new bitmap and graphics drawwing object for diagram and later additions
        ' The EqtPicBx width and height MUST be exactly equal in pixel size for all the graphics drawwing to work properly
        Dim DrawWidth As Integer = (EqtPicBx.Width / 2) - 40
        Dim CircleRadii As Integer = (EqtPicBx.Width / 2) - 35

        bm = New Bitmap(EqtPicBx.Width, EqtPicBx.Height)
        TDgraphics = Graphics.FromImage(bm)
        TDgraphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        TDgraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        TDgraphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        Dim DPen As Pen = New Pen(Color.Black, 1)
        Dim DPen2 As Pen = New Pen(Color.Blue, 2)
        DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        DPen2.DashStyle = Drawing2D.DashStyle.Solid

        TDgraphics.DrawString("SRF Time Diagram Expanded", New Font("Arial", 14, FontStyle.Bold), Brushes.Blue, -EqtPicBx.Width / 2, -EqtPicBx.Height / 2)

        ' draw the basic circle for the time diagram
        TDgraphics.DrawEllipse(DPen, -(CircleRadii), -(CircleRadii), 2 * CircleRadii, 2 * CircleRadii)
        TDgraphics.FillEllipse(Brushes.LightGoldenrodYellow, -(CircleRadii), -(CircleRadii), 2 * CircleRadii, 2 * CircleRadii)
        ' draww the small ticks on main circle for every 20 minutes or every 5 degrees of arc
        For i = 0 To 360 Step 1
            XTD1 = DrawWidth + 2 '* System.Math.Cos(i)
            XTD2 = (DrawWidth + 5) '* System.Math.Cos(i)
            TDgraphics.DrawLine(DPen, XTD1, 0, XTD2, 0)
            TDgraphics.RotateTransform(1)
        Next i
        TDgraphics.ResetTransform()
        TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        For i = 0 To TwoPi Step TwoPi / 72
            XTD1 = DrawWidth - 1 '* System.Math.Cos(i)
            XTD2 = (DrawWidth + 5) '* System.Math.Cos(i)
            TDgraphics.DrawLine(DPen, XTD1, 0, XTD2, 0)
            TDgraphics.RotateTransform((TwoPi / 72) * (180 / System.Math.PI))
        Next i
        TDgraphics.ResetTransform()
        TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        ' draw the major ticks on the main circle for every hour or 15 degrees of arc
        For i = 0 To TwoPi Step TwoPi / 24
            XTD1 = (DrawWidth - 5)   '* System.Math.Cos(i) '600
            XTD2 = (DrawWidth + 10)   '* System.Math.Cos(i)
            TDgraphics.DrawLine(DPen, XTD1, 0, XTD2, 0)
            TDgraphics.RotateTransform((TwoPi / 24) * (180 / System.Math.PI))
            'TDgraphics.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
        Next i
        TDgraphics.ResetTransform()
        TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))

        ' if only drawwing basic time circle for initial load then stop here and exit - set true in form load 
        If DrawBasicTimeDiagram = True Then
            DrawBasicTimeDiagram = False
            GoTo ExitDrawTime
        End If

        ' recap info from SRF form in upper left corner
        TDgraphics.DrawString("Body: " & FormSRF.BNBodyName & vbCrLf &
                              " Lat: " & CnvtDbltoDegMin(System.Math.Abs(FormSRF.Lat)).ToString & FormSRF.cboL.Text & vbCrLf &
                              " Lo : " & CnvtDbltoDegMin(System.Math.Abs(FormSRF.Lo)).ToString & FormSRF.cboLo.Text & vbCrLf &
                              " ZT : " & FormSRF.ZTHours.ToString("00") & ":" & FormSRF.ZTMinutes.ToString("00") & ":" & FormSRF.ZTSeconds.ToString("00") & vbCrLf &
                              " LHA: " & CnvtDbltoDegMin(FormSRF.LHAOriginal) & vbCrLf,
                              New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -EqtPicBx.Width / 2, -EqtPicBx.Height / 2 + 25)

        TDgraphics.DrawString("Major Arc Ticks = 1 hour of time or 15" & Chr(176) & " of arc" & vbCrLf &
                              "Minor Ticks = 20 minutes of time or 5" & Chr(176) & " of arc" & vbCrLf &
                              "Smallest Ticks = 4 minutes of time or 1" & Chr(176) & " of arc",
                              New Font("Arial", 8, FontStyle.Regular), Brushes.Blue, -EqtPicBx.Width / 2, EqtPicBx.Height / 2 - 35)

        ' draw meridian line to the top
        TDgraphics.DrawLine(DPen2, 0, 0, 0, -(CircleRadii))
        ' Label the Main meridian line with cap M and 12H (noon) text - add longitude for this sight on the Main Meridian Line
        TDgraphics.DrawString("M", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, -5, -(CircleRadii + 20))
        TDgraphics.RotateTransform(-90)
        TDgraphics.DrawString("Lo=" & CnvtDbltoDegMin(FormSRF.Lo).ToString & FormSRF.cboLo.Text, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
        TDgraphics.ResetTransform()
        TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))

        ' draw lower meridian line for 0/24 Hr (local midnight) and label accordingly
        DPen2.DashStyle = Drawing2D.DashStyle.Dash
        DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
        TDgraphics.DrawLine(DPen2, 0, 0, 0, (CircleRadii))
        TDgraphics.DrawString("m", New Font("Arial", 10, FontStyle.Bold), Brushes.Red, -5, CircleRadii + 15)

        ' draw an arc from the lower meridian line for 45 degrees to the right and label to show that time and arc degrees increase thru rotation to the right
        Dim ArcPen As Pen = New Pen(Color.Blue, 3)
        ArcPen.EndCap = Drawing2D.LineCap.ArrowAnchor
        Dim Rect As Rectangle = New Rectangle(-(CircleRadii) - 10, -(CircleRadii) - 10, 2 * CircleRadii + 20, 2 * CircleRadii + 20)
        TDgraphics.DrawArc(ArcPen, Rect, 90, -45)
        XTD1 = (CircleRadii + 15) * (System.Math.Cos((45) * System.Math.PI / 180))
        YTD1 = (CircleRadii + 15) * (System.Math.Sin((45) * System.Math.PI / 180))
        Dim PtText1 As Point = New Point(XTD1, YTD1)
        TDgraphics.DrawString("Time & Angles" & vbCrLf & "Increase In" & vbCrLf & "This Direction", New Font("Arial", 8, FontStyle.Regular), Brushes.Blue, PtText1)

        ' otherwise continue on drawwing rest of time diagram for sight reduction data entered
        'Greenwich lower branch - rotate drawing according to whether the lower greenwich meridian is in positive or negative x location and label
        XTD1 = CircleRadii * (System.Math.Cos((90 + FormSRF.Lo) * System.Math.PI / 180))
        YTD1 = CircleRadii * (System.Math.Sin((90 + FormSRF.Lo) * System.Math.PI / 180))

        If XTD1 < 0 Then
            TDgraphics.RotateTransform(180 + 90 + FormSRF.Lo)
            DPen2.DashStyle = Drawing2D.DashStyle.Dash
            TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
            TDgraphics.DrawString("g", New Font("Arial", 12, FontStyle.Bold), Brushes.Red, -(CircleRadii + 20), 0)
            TDgraphics.ResetTransform()
            TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        Else
            TDgraphics.RotateTransform(+90 + FormSRF.Lo)
            DPen2.DashStyle = Drawing2D.DashStyle.Dash
            TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
            TDgraphics.DrawString("g", New Font("Arial", 12, FontStyle.Bold), Brushes.Red, CircleRadii + 8, 0)
            TDgraphics.ResetTransform()
            TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        End If

        'Greenwich upper branch - rotate drawing according to whether the Upper Greenwich Meridina is in positive or negative x location and label 
        XTD1 = CircleRadii * (System.Math.Cos((-90 + FormSRF.Lo) * System.Math.PI / 180))
        YTD1 = CircleRadii * (System.Math.Sin((-90 + FormSRF.Lo) * System.Math.PI / 180))
        If XTD1 < 0 Then
            TDgraphics.RotateTransform(180 - 90 + FormSRF.Lo)
            DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
            DPen2.DashStyle = Drawing2D.DashStyle.Solid
            TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
            TDgraphics.DrawString("Greenwich Meridian", New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -CircleRadii / 2, -15)
            TDgraphics.DrawString("G", New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, -(CircleRadii + 20), -10)
            TDgraphics.ResetTransform()
            TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        Else
            TDgraphics.RotateTransform(-90 + FormSRF.Lo)
            DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
            DPen2.DashStyle = Drawing2D.DashStyle.Solid
            TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
            TDgraphics.DrawString("Greenwich Meridian", New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
            TDgraphics.DrawString("G", New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, CircleRadii + 8, -10)
            TDgraphics.ResetTransform()
            TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
        End If


        'if doing a star sight then put up Aries and GHA of Aries on drawwing 
        If FormSRF.BN <= 57 Then
            XTD1 = CircleRadii * (System.Math.Cos((-90 + FormSRF.Lo - FormSRF.GHAAries) * System.Math.PI / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-90 + FormSRF.Lo - FormSRF.GHAAries) * System.Math.PI / 180))
            If XTD1 < 0 Then
                TDgraphics.RotateTransform(180 - 90 + FormSRF.Lo - FormSRF.GHAAries)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
                TDgraphics.DrawString(Aries_Uchar, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, -(CircleRadii + 20), -10)
                TDgraphics.DrawString("GHA Aries: " & CnvtDbltoDegMin(FormSRF.GHAAries).ToString, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -(0.75) * CircleRadii, -15)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            Else
                TDgraphics.RotateTransform(-90 + FormSRF.Lo - FormSRF.GHAAries)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
                TDgraphics.DrawString(Aries_Uchar, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, CircleRadii + 8, -10)
                TDgraphics.DrawString("GHA Aries: " & CnvtDbltoDegMin(FormSRF.GHAAries).ToString, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            End If
        End If

        Dim DString As String = vbNullString

        'Any body other than Sun: Is this a star sight, a planet sight, or a moon sight
        If FormSRF.BNType <> "Sun" Then '64 Then
            If FormSRF.BNType = "Stars" Then ' <= 57 Then
                DString = Black_Star_Uchar.ToString '"*"
            End If
            If FormSRF.BNType = "Planets" Then  '>= 58 And FormSRF.BN <= 61 Then
                Select Case FormSRF.BNBodyName
                    Case "Mercury"
                        DString = Mercury_Uchar
                    Case "Venus"
                        DString = Venus_Uchar
                    Case "Mars"
                        DString = Mars_Uchar
                    Case "Jupiter"
                        DString = Jupiter_Uchar
                    Case "Saturn"
                        DString = Saturn_Uchar
                    Case "Neptune"
                        DString = Neptune_Uchar
                    Case "Uranus"
                        DString = Uranus_Uchar
                    Case "Pluto"
                        DString = Pluto_Uchar
                    Case Else
                        DString = "P"
                End Select

            End If
            If FormSRF.BNType = "Moon" Then  ' = 62 Or FormSRF.BN = 63 Then
                DString = Moon_Uchar
            End If

            XTD1 = CircleRadii * (System.Math.Cos((-90 - (FormSRF.LHAOriginal)) * System.Math.PI / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-90 - (FormSRF.LHAOriginal)) * System.Math.PI / 180))
            ' rotate drawing according to whether x location of end of line is positive or negative then draw sight object character and label line with body LHA
            If XTD1 < 0 Then
                TDgraphics.RotateTransform(180 - 90 - (FormSRF.LHAOriginal))
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
                TDgraphics.DrawString(FormSRF.BNBodyName.ToString & " LHA: " & CnvtDbltoDegMin(FormSRF.LHAOriginal).ToString,
                                      New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15)
                TDgraphics.DrawString(DString, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, -(CircleRadii + 20), -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            Else
                TDgraphics.RotateTransform(-90 - (FormSRF.LHAOriginal))
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
                TDgraphics.DrawString(FormSRF.BNBodyName.ToString & " LHA: " & CnvtDbltoDegMin(FormSRF.LHAOriginal).ToString,
                                      New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
                TDgraphics.DrawString(DString, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, CircleRadii + 8, -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            End If

        End If
        FormSRF.GetValidBN()
        'Mean Sun for all sights except sun - add mean sun location for all sights but Sun sight
        If FormSRF.BNType <> "Sun" Then

            FormSRF.Sun()
            FormSRF.HourAngles()

            XTD1 = CircleRadii * (System.Math.Cos((90 + FormSRF.Lo - FormSRF.HG * 15) * System.Math.PI / 180))
            YTD1 = CircleRadii * (System.Math.Sin((90 + FormSRF.Lo - FormSRF.HG * 15) * System.Math.PI / 180))
            Dim StrDisp As String = "Sun GMT: " & CnvtDbltoHrMin(FormSRF.HG).ToString
            If XTD1 < 0 Then
                'TDgraphics.DrawString(StrDisp, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, PtText.X + 25, PtText.Y)
                TDgraphics.RotateTransform(180 + 90 + FormSRF.Lo - FormSRF.HG * 15)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
                TDgraphics.DrawString(StrDisp, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15)
                TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, -(CircleRadii + 20), -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            Else
                TDgraphics.RotateTransform(90 + FormSRF.Lo - FormSRF.HG * 15)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
                TDgraphics.DrawString(StrDisp, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
                TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, CircleRadii + 8, -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            End If

        Else
            ' for Sun sight add upper and lower mean meridian and label with both GMT and ZT (corrected) 
            FormSRF.Sun()
            FormSRF.HourAngles()
            ' calculate and draw Sun mean time Upper / Main  meridian line and mark with Main sun character and GMT and ZT (corrected)
            XTD1 = CircleRadii * (System.Math.Cos((90 + FormSRF.Lo - FormSRF.HG * 15) * System.Math.PI / 180))
            YTD1 = CircleRadii * (System.Math.Sin((90 + FormSRF.Lo - FormSRF.HG * 15) * System.Math.PI / 180))

            DPen.DashStyle = Drawing2D.DashStyle.Solid
            TDgraphics.DrawLine(DPen, 0, 0, XTD1, YTD1)
            Dim StrDisp As String = " GMT: " & CnvtDbltoHrMin(FormSRF.HG).ToString & " "
            If XTD1 < 0 Then
                TDgraphics.RotateTransform(180 + 90 + FormSRF.Lo - FormSRF.HG * 15)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
                TDgraphics.DrawString(FormSRF.BNBodyName.ToString & StrDisp, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15)
                TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, -(CircleRadii + 20), -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            Else
                TDgraphics.RotateTransform(90 + FormSRF.Lo - FormSRF.HG * 15)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Solid
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
                TDgraphics.DrawString(FormSRF.BNBodyName.ToString & StrDisp, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
                TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.Blue, CircleRadii + 8, -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            End If

            ' calculate and draw Sun mean time lower meridian line and mark with lesser sun character
            XTD1 = CircleRadii * (System.Math.Cos((-90 + FormSRF.Lo - FormSRF.HG * 15) * System.Math.PI / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-90 + FormSRF.Lo - FormSRF.HG * 15) * System.Math.PI / 180))

            If XTD1 < 0 Then
                TDgraphics.RotateTransform(180 - 90 + FormSRF.Lo - FormSRF.HG * 15)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Dash
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
                TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.Red, -(CircleRadii + 20), -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            Else
                TDgraphics.RotateTransform(-90 + FormSRF.Lo - FormSRF.HG * 15)
                DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                DPen2.DashStyle = Drawing2D.DashStyle.Dash
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
                TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.Red, CircleRadii + 8, -10)
                TDgraphics.ResetTransform()
                TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
            End If
            If chkDispEqt.Checked = True Then
                ' now display apparent sun and EqT factor
                FormSRF.EqTinSeconds = FormSRF.GHA * 240 - FormSRF.UTinSeconds
                Do While System.Math.Abs(FormSRF.EqTinSeconds) >= 1020 '17 minutes
                    If FormSRF.EqTinSeconds >= 0 Then
                        FormSRF.EqTinSeconds = FormSRF.EqTinSeconds - 43200 '43200 is 12 hours in second
                        If FormSRF.EqTinSeconds < 0 Then Exit Do
                    End If
                    If FormSRF.EqTinSeconds < 0 Then
                        FormSRF.EqTinSeconds = FormSRF.EqTinSeconds + 43200 '43200 is 12 hours in seconds
                        If FormSRF.EqTinSeconds >= 0 Then Exit Do
                    End If
                Loop
                Dim HGCalc As Double = (FormSRF.EqTinSeconds / 60)
                FormSRF.EqTminutes = Int(System.Math.Abs(FormSRF.EqTinSeconds / 60))
                FormSRF.EqTseconds = System.Math.Abs(FormSRF.EqTinSeconds) - FormSRF.EqTminutes * 60
                Dim HGCalcHR As Double = FormSRF.HG + FormSRF.EqTinSeconds / 3600 ' convert HGCalc Minutes/second into Hours for subsequent calcs
                Dim DTTemp As Date = New Date(FormSRF.DTSight.Value.Year, FormSRF.DTSight.Value.Month, FormSRF.DTSight.Value.Day, FormSRF.ZTHours, FormSRF.ZTMinutes, FormSRF.ZTSeconds)
                DTTemp = DTTemp.AddMinutes(HGCalc)

                Dim EQTsign As String = ""
                StrDisp = "Apparent Sun: " & DTTemp.Hour.ToString("00") & ":" & DTTemp.Minute.ToString("00") & ":" & DTTemp.Second.ToString("00") & vbCrLf
                If System.Math.Sign(FormSRF.EqTinSeconds) = 1 Then EQTsign = ("(+)")
                If System.Math.Sign(FormSRF.EqTinSeconds) = 0 Then EQTsign = ("   ")
                If System.Math.Sign(FormSRF.EqTinSeconds) = -1 Then EQTsign = ("(-)")
                StrDisp &= "Eqt Factor: " & EQTsign.ToString & (Strings.Format(FormSRF.EqTminutes, "00") & "m" & Strings.Format(FormSRF.EqTseconds, "00") & "s")
                ' redraw the general info block to include the App Sun ZT and Eqt factor
                TDgraphics.DrawString("Body: " & FormSRF.BNBodyName & vbCrLf &
                              " Lat: " & CnvtDbltoDegMin(System.Math.Abs(FormSRF.Lat)).ToString & FormSRF.cboL.Text & vbCrLf &
                              " Lo : " & CnvtDbltoDegMin(System.Math.Abs(FormSRF.Lo)).ToString & FormSRF.cboLo.Text & vbCrLf &
                              " ZT : " & FormSRF.ZTHours.ToString("00") & ":" & FormSRF.ZTMinutes.ToString("00") & ":" & FormSRF.ZTSeconds.ToString("00") & vbCrLf &
                              " LHA: " & CnvtDbltoDegMin(FormSRF.LHAOriginal) & vbCrLf & StrDisp,
                              New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -EqtPicBx.Width / 2, -EqtPicBx.Height / 2 + 25)

                ' calculate and draw Sun mean time lower meridian line and mark with lesser sun character
                XTD1 = CircleRadii * (System.Math.Cos((90 + FormSRF.Lo - HGCalcHR * 15) * System.Math.PI / 180))
                YTD1 = CircleRadii * (System.Math.Sin((90 + FormSRF.Lo - HGCalcHR * 15) * System.Math.PI / 180))

                If XTD1 < 0 Then
                    TDgraphics.RotateTransform(180 + 90 + FormSRF.Lo - HGCalcHR * 15)
                    DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                    DPen2.DashStyle = Drawing2D.DashStyle.Solid
                    TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0)
                    TDgraphics.DrawString(FormSRF.BNBodyName.ToString & " App Sun", New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15)
                    TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.LightBlue, -(CircleRadii + 20), -10)
                    TDgraphics.ResetTransform()
                    TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
                Else
                    TDgraphics.RotateTransform(90 + FormSRF.Lo - HGCalcHR * 15)
                    DPen2.EndCap = Drawing2D.LineCap.ArrowAnchor
                    DPen2.DashStyle = Drawing2D.DashStyle.Solid
                    TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0)
                    TDgraphics.DrawString(FormSRF.BNBodyName.ToString & " App Sun", New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, CircleRadii / 2, -15)
                    TDgraphics.DrawString(Sun_Uchar.ToString, New Font("Arial", 12, FontStyle.Bold), Brushes.LightBlue, CircleRadii + 8, -10)
                    TDgraphics.ResetTransform()
                    TDgraphics.TranslateTransform((EqtPicBx.Width / 2), (EqtPicBx.Height / 2))
                End If
            End If
        End If

ExitDrawTime:
        ' draw a small circle in the middle and fill it with red
        TDgraphics.DrawEllipse(DPen, -4, -4, 8, 8)
        TDgraphics.FillEllipse(Brushes.Red, -4, -4, 8, 8)
        ' save off this graphics object into single file name - delete that file name if it already exists then save to it and lodge file name into ImageLocation
        If System.IO.File.Exists(BMFname) Then
            System.IO.File.Delete(BMFname)
        End If
        bm.Save(BMFname)
        EqtPicBx.ImageLocation = BMFname

        EqtPicBx.Refresh()
        ' dispose of bitmap graphics object so garbage cleanup can free the Save links asserted
        bm.Dispose()

        Exit Sub
    End Sub
    Private Function CnvtDbltoDegMin(ByVal DblIn As Double) As String
        Dim DegIn As Integer = Int(DblIn)
        Dim MinIn As Double = (DblIn - DegIn) * 60
        Return DegIn.ToString("##0") & Chr(176) & " " & MinIn.ToString("#0.0") & "'"
    End Function
    Private Function CnvtDbltoHrMin(ByVal DblIn As Double) As String
        Dim HrIn As Integer = Int(DblIn)
        Dim MinIn As Double = (DblIn - HrIn) * 60
        Dim MinInInt As Integer = Int(MinIn)
        Dim SecIn As Double = (MinIn - MinInInt) * 60
        If HrIn >= 24 Then HrIn = 24 - HrIn
        If HrIn < 0 Then HrIn = System.Math.Abs(HrIn)
        Return HrIn.ToString("00") & ":" & MinInInt.ToString("00") & ":" & SecIn.ToString("00")
    End Function

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
        Me.Focus()
        Exit Sub
    End Sub

    Private Sub chkDispEqt_CheckedChanged(sender As Object, e As EventArgs) Handles chkDispEqt.CheckedChanged
        DisplayTimeDiagram()
        Exit Sub
    End Sub
End Class