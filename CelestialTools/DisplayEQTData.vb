Public Class DisplayEQTData
    Public AnalemaFileName As String = "./Graphics/AnalemaBitMapSave.jpg"
    Private Sub DisplayEQTData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FName As String = "./Graphics/EQTData.csv"
        Dim tablename As String = "Export"
        'Dim DataSet As DataSet = New DataSet()
        'DataSet.Tables.Add(tablename)
        'DataSet.Tables(tablename).Columns.Add("Latitude")
        'DataSet.Tables(tablename).Columns.Add("Longitude")
        'DataSet.Tables(tablename).Columns.Add("LAN Date")
        'DataSet.Tables(tablename).Columns.Add("LAN Time")
        'DataSet.Tables(tablename).Columns.Add("EQT Factor")
        'DataSet.Tables(tablename).Columns.Add("Declination")
        'DataSet.Tables(tablename).Columns.Add("Calc Ho")
        Dim SR As System.IO.StreamReader = New System.IO.StreamReader(FName)
        Dim allData As String = SR.ReadToEnd()
        Dim rows As String() = allData.Split(vbCrLf) '("\r".ToCharArray())
        Dim incr1 As Integer = 0
        For Each r As String In rows
            If incr1 > 0 Then
                Dim items As String() = r.Split(",")
                If items(0) <> vbLf Then
                    Dim DT As Date = Convert.ToDateTime(items(2))
                    If DT.Day = 1 Or DT.Day = 15 Or DT.Day = 30 Then
                        items(0) = CnvtToDeg(items(0).ToString)
                        items(1) = CnvtToDeg(items(1).ToString)
                        items(3) = CnvtTime(items(3).ToString)
                        items(4) = CnvtEQT(items(4).ToString)
                        items(5) = CnvtDec(items(5).ToString)
                        items(6) = CnvtHo(items(6).ToString)
                        DataSet1.Tables(tablename).Rows.Add(items)
                    End If

                End If
            End If
            incr1 += 1
        Next
        DataGridView1.DataSource = DataSet1.Tables(0).DefaultView

        SR.Close()
        SR.Dispose()

        Me.Refresh()
        DisplayAnalema()
        Exit Sub

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub DisplayAnalema()
        Dim AnalemaCenter As Point = New Point(pbAnalema.Location.X + pbAnalema.Width / 2, pbAnalema.Location.Y + pbAnalema.Height / 2)
        Dim AnalemaGraphic As Graphics
        Dim bm As Bitmap
        Dim DrawWidth As Integer = (pbAnalema.Width / 2) - 20
        bm = New Bitmap(pbAnalema.Width, pbAnalema.Height)
        AnalemaGraphic = Graphics.FromImage(bm)
        AnalemaGraphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        AnalemaGraphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        AnalemaGraphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        AnalemaGraphic.TranslateTransform(pbAnalema.Width / 2, pbAnalema.Height / 2)
        Dim FontA As Font = New Font("Arial", 7, FontStyle.Regular)
        Dim FontB As Font = New Font("Arial", 8, FontStyle.Bold)

        Dim tmpDate As Date = Convert.ToDateTime(FormNoonSight.EqtTable(0).EqTimeDate)
        Dim tmpYear As Integer = tmpDate.Year

        Dim DPen As Pen = New Pen(Color.Black, 1)
        Dim BPen As Pen = New Pen(Color.Blue, 1)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point
        ptA.X = -DrawWidth - 10
        ptA.Y = -DrawWidth - 10
        AnalemaGraphic.DrawString("Analema Graph drawn" & vbCrLf & "for Latitude: " & CnvtToDeg(FormNoonSight.EqtTable(0).EqtLat.ToString) &
                                  vbCrLf & "and Longitude: " & CnvtToDeg(FormNoonSight.EqtTable(0).EqtLong.ToString) & vbCrLf &
                                  "for calendar year: " & tmpYear.ToString("0000"), FontB, Brushes.Black, ptA)
        ptA.X = -DrawWidth
        ptA.Y = 0
        ptB.X = DrawWidth
        ptB.Y = 0
        AnalemaGraphic.DrawLine(DPen, ptA, ptB)
        ptA.Y = -30
        ptB.Y = -30
        ptB.X = ptB.X - 40
        AnalemaGraphic.DrawString("Eqt Slow", FontA, Brushes.Blue, ptA)
        AnalemaGraphic.DrawString("Eqt Fast", FontA, Brushes.Blue, ptB)
        Dim OneinPixels As Integer = DrawWidth / 25

        ptA.Y = -DrawWidth
        ptA.X = 0
        ptB.Y = DrawWidth
        ptB.X = 0
        AnalemaGraphic.DrawLine(DPen, ptA, ptB)
        ptA.Y = -DrawWidth - 15
        ptA.X = -30
        ptB.Y = DrawWidth + 5
        ptB.X = -30
        AnalemaGraphic.DrawString("South Declination", FontA, Brushes.Blue, ptA)
        AnalemaGraphic.DrawString("North Declination", FontA, Brushes.Blue, ptB)
        ' first draw the quadrnat where x and y are positive
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0
        For incr As Integer = 1 To 24 Step 1
            ptA.X = incr * OneinPixels
            If incr Mod 5 = 0 Then
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X, ptA.Y - 20))
                AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, New Point(ptA.X, ptA.Y + 10))
            Else
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X, ptA.Y - 10))
            End If
        Next
        ' draw the x and y axis with a tick mark every 5 to 10 counts
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0
        For incr As Integer = -1 To -24 Step -1
            ptA.X = incr * OneinPixels
            If incr Mod 5 = 0 Then
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X, ptA.Y - 20))
                AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, New Point(ptA.X, ptA.Y + 10))
            Else
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X, ptA.Y - 10))
            End If
        Next
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0
        For incr As Integer = 1 To 24 Step 1
            ptA.Y = incr * OneinPixels
            If incr Mod 5 = 0 Then
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X - 20, ptA.Y))
                AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, New Point(ptA.X + 10, ptA.Y))
            Else
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X - 10, ptA.Y))
            End If
        Next
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0
        For incr As Integer = -1 To -24 Step -1
            ptA.Y = incr * OneinPixels
            If incr Mod 5 = 0 Then
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X - 20, ptA.Y))
                AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, New Point(ptA.X + 10, ptA.Y))
            Else
                AnalemaGraphic.DrawLine(DPen, ptA, New Point(ptA.X - 10, ptA.Y))
            End If
        Next
        ' new draw the Eqt Analema data on the graphed x and y axis'
        Dim Limit As Integer = UBound(FormNoonSight.EqtTable)

        For incr As Integer = 0 To Limit - 2 Step 1
            Dim ptx As Point = New Point((FormNoonSight.EqtTable(incr).EqTimeFactor) * OneinPixels, (FormNoonSight.EqtTable(incr).EqTimeDec) * OneinPixels)

            Dim TDate As Date = Convert.ToDateTime(FormNoonSight.EqtTable(incr).EqTimeDate)
            If TDate.Day = 1 Or TDate.Day = 15 Then
                AnalemaGraphic.DrawEllipse(BPen, New Rectangle(ptx.X - 6, ptx.Y - 6, 6, 6))
                AnalemaGraphic.FillEllipse(Brushes.Blue, New Rectangle(ptx.X - 6, ptx.Y - 6, 6, 6))
            Else
                AnalemaGraphic.DrawEllipse(DPen, New Rectangle(ptx.X - 2, ptx.Y - 2, 2, 2))
                AnalemaGraphic.FillEllipse(Brushes.LawnGreen, New Rectangle(ptx.X - 2, ptx.Y - 2, 2, 2))
            End If

            Dim strDtTm As String = "On " & FormNoonSight.EqtTable(incr).EqTimeDate & vbCrLf &
                "LAN=" & CnvtTime(FormNoonSight.EqtTable(incr).EqTZTLAN.ToString) &
                " Ho=" & CnvtHo(FormNoonSight.EqtTable(incr).EqTimeHo.ToString) & Chr(176)
            Dim strlen As Integer = (strDtTm.Length / 2) * 6
            If TDate.Day = 1 Or TDate.Day = 15 Then
                If TDate.Month = 6 And TDate.Day = 15 Then
                    AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X + 8, ptx.Y - 4)
                Else
                    If ptx.X > 0 Then
                        If ptx.Y > 0 Then
                            AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X + 8, ptx.Y - 8)
                        Else
                            AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X + 8, ptx.Y - 8)
                        End If
                    Else
                        If ptx.Y > 0 Then
                            AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X - strlen, ptx.Y - 8)
                        Else
                            AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X - strlen, ptx.Y - 8)
                        End If
                    End If
                End If
            End If
        Next
        If FileIO.FileSystem.FileExists(AnalemaFileName) Then
            FileIO.FileSystem.DeleteFile(AnalemaFileName)
        End If
        bm.Save(AnalemaFileName)
        pbAnalema.ImageLocation = AnalemaFileName

        pbAnalema.Visible = True
        pbAnalema.Refresh()

        DPen.Dispose()
        Exit Sub
    End Sub
    Private Function CnvtToDeg(ByVal StrIn) As String
        Dim NSEW As String = StrIn.ToString.Substring(StrIn.ToString.Length - 1, 1)
        Dim Str2 As String = StrIn.ToString.Substring(0, StrIn.ToString.Length - 1) ' remove N/S on Lat and E/W on Long as last character
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("##0") & Chr(176) & " " & TmpMin.ToString("#0.0") & "'" & NSEW.ToString
    End Function
    Private Function CnvtEQT(ByVal StrIn) As String
        Dim EqtSpeed As String = ""
        If StrIn.ToString.Substring(0, 1) = "-" Then
            EqtSpeed = " Slow"
        Else
            EqtSpeed = " Fast"
        End If
        Dim Str2 As String = StrIn.ToString.TrimStart("-")
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("00") & ":" & TmpMin.ToString("00") & EqtSpeed
    End Function
    Private Function CnvtDec(ByVal StrIn) As String
        Dim NSEW As String = ""
        If StrIn.ToString.Substring(0, 1) = "-" Then
            NSEW = " S"
        Else
            NSEW = " N"
        End If
        Dim Str2 As String = StrIn.ToString.TrimStart("-")
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("##0") & Chr(176) & " " & TmpMin.ToString("#0.0") & "'" & NSEW.ToString
    End Function
    Private Function CnvtHo(ByVal StrIn) As String
        Dim Str2 As String = StrIn.ToString
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("##0") & Chr(176) & " " & TmpMin.ToString("#0.0") & "'"
    End Function
    Private Function CnvtTime(ByVal StrIn) As String
        Return StrIn.ToString.Substring(0, 2) & ":" & StrIn.ToString.Substring(2, 2) & ":" & StrIn.ToString.Substring(4, 2)
    End Function
End Class