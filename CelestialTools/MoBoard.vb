Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FormMoBoard
    Inherits System.Windows.Forms.Form
    Dim Y1, X1, Pi, CPABearing, X2, Y2 As Double
    Dim Time1Minutes, Time2Minutes As Single
    Dim Dist2, A, Range, Dist, k, D, DRM As Double
    Dim SRM As Single
    Dim TimeOfCPA, TimeToCPA, TimeOfCPAm As Single
    Dim TimeOfCPAh As Short
    Dim dot, xVel, x, y, yVel, B As Double
    Dim fnumeral As String
    Dim intResponse As Short
    Dim CPAexists As Boolean
    Dim V1Course, V1Speed As Single
    Dim V2Course, V2Speed As Double
    Dim DRMZ, Z1 As Double
    Dim SignZ1 As Short
    Dim xV1S, xDRM, yDRM, yV1S As Short
    Dim DeltaX, DeltaY As Double
    Dim V11y, V21y, V20y, V2Dist, V1Dist, V20x, V21x, V11x, Bearing As Double
    Dim xV11, xV21, xV20, yV20, yV21, yV11 As Short
    Dim Course1, Course2 As Single
    Dim ApparentWindDir As Single
    Dim TrueWindSpeed, Course, TrueWindDir, ApparentWindSpeed As Double
    Dim PointingAngle As Double

    Private Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click
        Pi = 4 * System.Math.Atan(1.0#)
        CPAexists = True
        If optCPATypeA.Checked = True Then
            txtMoB.Clear()
            If Val(txtRange1.Text) = 0 Or Val(txtRange2.Text) = 0 Then ErrorMsgBox("Ranges cannot be zero or blank.") : Exit Sub
            Time1Minutes = 60 * Val(VB.Left(txtTime1.Text, 2)) + Val(VB.Right(txtTime1.Text, 2))
            Time2Minutes = 60 * Val(VB.Left(txtTime2.Text, 2)) + Val(VB.Right(txtTime2.Text, 2))
            If Time2Minutes <= Time1Minutes Then

                If System.Windows.Forms.MessageBox.Show("Is Time2 on the day after Time1?", "Same Day?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
                    Time2Minutes = Time2Minutes + 1440

                Else
                    txtTime2.BackColor = System.Drawing.Color.Red
                    txtTime2.Focus()

                    Exit Sub
                End If
            End If
            If (Val(txtBearing1.Text) <> (Val(txtBearing2.Text) + 180) And Val(txtBearing1.Text) <> (Val(txtBearing2.Text) - 180)) And Val(txtRange2.Text) >= Val(txtRange1.Text) Then
                txtMoB.AppendText("No further closure between vessels." & vbNewLine)
                CPAexists = False
            End If 'Exit Sub
            If Val(txtRange1.Text) * System.Math.Sin(Val(txtBearing1.Text) * Pi / 180) - Val(txtRange2.Text) * System.Math.Sin(Val(txtBearing2.Text) * Pi / 180) < 0.0000001 Then CPABearing = 0 Else
            CPABearing = System.Math.Atan((Val(txtRange2.Text) * System.Math.Cos(Val(txtBearing2.Text) * Pi / 180) - Val(txtRange1.Text) * System.Math.Cos(Val(txtBearing1.Text) * Pi / 180)) / (Val(txtRange1.Text) * System.Math.Sin(Val(txtBearing1.Text) * Pi / 180) - Val(txtRange2.Text) * System.Math.Sin(Val(txtBearing2.Text) * Pi / 180) + 9.999999E-21))
            Y1 = Val(txtRange1.Text) * System.Math.Cos(Val(txtBearing1.Text) * Pi / 180) 'Y is NS component
            Y2 = Val(txtRange2.Text) * System.Math.Cos(Val(txtBearing2.Text) * Pi / 180)
            X1 = Val(txtRange1.Text) * System.Math.Sin(Val(txtBearing1.Text) * Pi / 180) 'X is EW component
            X2 = Val(txtRange2.Text) * System.Math.Sin(Val(txtBearing2.Text) * Pi / 180)
            Dist = System.Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1))
            Range = Val(txtRange2.Text) * System.Math.Cos(CPABearing - Val(txtBearing2.Text) * Pi / 180) 'Does not agree with Allen, agrees with Lapook
            If Range < 0 Then CPABearing = CPABearing + Pi
            DRMZ = System.Math.Atan((X2 - X1) / (Y2 - Y1)) * 180 / Pi
            DRMZ = System.Math.Abs(DRMZ)
            DRM = System.Math.Abs(DRMZ)
            If (X2 - X1) >= 0 And (Y2 - Y1) >= 0 Then DRM = DRM : xDRM = 1 : yDRM = 1
            If (X2 - X1) >= 0 And (Y2 - Y1) < 0 Then DRM = 180 - DRM : xDRM = 1 : yDRM = -1
            If (X2 - X1) < 0 And (Y2 - Y1) < 0 Then DRM = DRM - 180 : xDRM = -1 : yDRM = -1
            If (X2 - X1) < 0 And (Y2 - Y1) >= 0 Then DRM = 360 - DRM : xDRM = -1 : yDRM = 1
            k = System.Math.Sin(System.Math.Abs(Val(txtBearing1.Text) - Val(txtBearing2.Text)) * Pi / 180) * Val(txtRange1.Text) / Dist
            A = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1))
            If A < 0 Then A = A + 2 * Pi
            D = Val(txtRange2.Text) * System.Math.Sin(A)
            Dist2 = Val(txtRange2.Text) * System.Math.Sin((Pi / 2) - A)
            CPABearing = CPABearing * 180 / Pi
            If CPABearing > 360 Then CPABearing = CPABearing - 360
            If CPABearing < 0 Then CPABearing = CPABearing + 360
            If DRM > 360 Then DRM = DRM - 360
            If DRM < 0 Then DRM = DRM + 360
            SRM = Dist / (Time2Minutes - Time1Minutes) * 60

            If Val(txtV1Course.Text) >= 0 And Val(txtV1Course.Text) < 90 Then V1Course = Val(txtV1Course.Text) : xV1S = 1 : yV1S = 1
            If Val(txtV1Course.Text) >= 90 And Val(txtV1Course.Text) < 180 Then V1Course = 180 - Val(txtV1Course.Text) : xV1S = 1 : yV1S = -1
            If Val(txtV1Course.Text) >= 180 And Val(txtV1Course.Text) < 270 Then V1Course = Val(txtV1Course.Text) - 180 : xV1S = -1 : yV1S = -1
            If Val(txtV1Course.Text) >= 270 And Val(txtV1Course.Text) < 360 Then V1Course = 360 - Val(txtV1Course.Text) : xV1S = -1 : yV1S = 1
            DeltaX = xV1S * Val(txtV1Speed.Text) * System.Math.Sin(V1Course * Pi / 180) + xDRM * SRM * System.Math.Sin(DRMZ * Pi / 180)
            DeltaY = yV1S * Val(txtV1Speed.Text) * System.Math.Cos(V1Course * Pi / 180) + yDRM * SRM * System.Math.Cos(DRMZ * Pi / 180)
            V2Course = System.Math.Atan(System.Math.Abs(DeltaY) / (System.Math.Abs(DeltaX) + 9.999999E-21)) * 180 / Pi
            If DeltaY >= 0 And DeltaX >= 0 Then V2Course = 90 - V2Course
            If DeltaY >= 0 And DeltaX < 0 Then V2Course = 270 + V2Course
            If DeltaY < 0 And DeltaX >= 0 Then V2Course = 90 + V2Course
            If DeltaY < 0 And DeltaX < 0 Then V2Course = 270 - V2Course
            If Val(txtV1Speed.Text) = 0 Then V2Course = DRM
            V2Speed = System.Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY)
            If V2Course >= 360 Then V2Course = V2Course - 360
            If V2Course < 0 Then V2Course = V2Course + 360
            V2Course = Int(V2Course * 10 + 0.5) / 10
            V2Speed = Int(V2Speed * 10 + 0.5) / 10

            TimeToCPA = (Dist2 / Dist) * (Time2Minutes - Time1Minutes)
            If A > Pi / 2 Then TimeToCPA = -TimeToCPA
            TimeOfCPA = Time2Minutes + TimeToCPA
            Range = System.Math.Abs(Range) : Range = Int(Range * 100 + 0.5) / 100
            CPABearing = Int(CPABearing * 10 + 0.5) / 10
            TimeToCPA = Int(TimeToCPA * 10 + 0.5) / 10
            SRM = Int(SRM * 10 + 0.5) / 10
            TimeOfCPA = TimeOfCPA / 60 'decimal hours
            TimeOfCPAh = Int(TimeOfCPA)
            TimeOfCPAm = (TimeOfCPA - TimeOfCPAh) * 60 : TimeOfCPAm = Int(TimeOfCPAm + 0.5)
            If TimeOfCPAh >= 24 Then TimeOfCPAh = TimeOfCPAh - 24
            TimeOfCPA = 100 * TimeOfCPAh + TimeOfCPAm
            DRM = Int(DRM * 10 + 0.5) / 10
            If CPAexists = True Then
                txtMoB.AppendText("CPA = " & Strings.Format(Range, "0.00") & " nm in " & Strings.Format(TimeToCPA, "0.0") & " minutes" & vbNewLine) ';
                txtMoB.AppendText("Bearing at CPA = " & Strings.Format(CPABearing, "000.0") & Chr(176) & vbNewLine)
                txtMoB.AppendText("Time of CPA = " & Strings.Format(TimeOfCPA, "0000") & vbNewLine)
            End If
            If CPAexists = False Then
            End If
            txtMoB.AppendText("DRM = " & Strings.Format(DRM, "000.0") & Chr(176) & vbNewLine)
            txtMoB.AppendText("SRM = " & Strings.Format(SRM, "0.0") & " knots" & vbNewLine)
            txtMoB.AppendText("Vessel 2 Course = " & Strings.Format(V2Course, "000.0") & Chr(176) & vbNewLine)
            txtMoB.AppendText("Vessel 2 Speed = " & Strings.Format(V2Speed, "0.0") & " knots" & vbNewLine)
        End If
        If optCPATypeB.Checked = True Then
            txtMoB.Clear()

            x = Val(txtRange.Text) * System.Math.Cos(Val(txtBearing.Text) * Pi / 180)
            y = Val(txtRange.Text) * System.Math.Sin(Val(txtBearing.Text) * Pi / 180)
            xVel = Val(txtSpeed2.Text) * System.Math.Cos(Val(txtCourse2.Text) * Pi / 180) - Val(txtSpeed1.Text) * System.Math.Cos(Val(txtCourse1.Text) * Pi / 180)
            yVel = Val(txtSpeed2.Text) * System.Math.Sin(Val(txtCourse2.Text) * Pi / 180) - Val(txtSpeed1.Text) * System.Math.Sin(Val(txtCourse1.Text) * Pi / 180)
            dot = x * xVel + y * yVel
            If dot >= 0 Then
                txtMoB.AppendText("No further closure between vessels.")
                CPAexists = False
            End If 'Exit Sub
            A = xVel * xVel + yVel * yVel + 9.999999E-21

            DRM = System.Math.Atan(yVel / (xVel + 9.999999E-21)) * 180 / Pi
            If xVel >= 0 And yVel >= 0 Then DRM = DRM
            If xVel >= 0 And yVel < 0 Then DRM = 180 - DRM
            If xVel < 0 And yVel >= 0 Then DRM = 360 - DRM
            If xVel < 0 And yVel < 0 Then DRM = 180 + DRM
            If DRM < 0 Then DRM = DRM + 360
            If DRM > 360 Then DRM = DRM - 360

            SRM = System.Math.Sqrt(A)
            SRM = Int(SRM * 10 + 0.5) / 10
            B = 2 * dot
            Range = System.Math.Abs(Val(txtRange.Text) * Val(txtRange.Text) - ((B * B) / (4 * A))) 'Abs prevents slightly negative numbers from creating error in Sqr(Range)
            TimeToCPA = 60 * (-B / (2 * A))
            V1Dist = Val(txtSpeed1.Text) * TimeToCPA / 60
            V2Dist = Val(txtSpeed2.Text) * TimeToCPA / 60
            If Val(txtBearing.Text) >= 0 And Val(txtBearing.Text) < 90 Then Bearing = Val(txtBearing.Text) : xV20 = 1 : yV20 = 1
            If Val(txtBearing.Text) >= 90 And Val(txtBearing.Text) < 180 Then Bearing = 180 - Val(txtBearing.Text) : xV20 = 1 : yV20 = -1
            If Val(txtBearing.Text) >= 180 And Val(txtBearing.Text) < 270 Then Bearing = Val(txtBearing.Text) - 180 : xV20 = -1 : yV20 = -1
            If Val(txtBearing.Text) >= 270 And Val(txtBearing.Text) < 360 Then Bearing = 360 - Val(txtBearing.Text) : xV20 = -1 : yV20 = 1
            V20x = xV20 * Val(txtRange.Text) * System.Math.Sin(Bearing * Pi / 180)
            V20y = yV20 * Val(txtRange.Text) * System.Math.Cos(Bearing * Pi / 180)
            If Val(txtCourse1.Text) >= 0 And Val(txtCourse1.Text) < 90 Then Course1 = Val(txtCourse1.Text) : xV11 = 1 : yV11 = 1
            If Val(txtCourse1.Text) >= 90 And Val(txtCourse1.Text) < 180 Then Course1 = 180 - Val(txtCourse1.Text) : xV11 = 1 : yV11 = -1
            If Val(txtCourse1.Text) >= 180 And Val(txtCourse1.Text) < 270 Then Course1 = Val(txtCourse1.Text) - 180 : xV11 = -1 : yV11 = -1
            If Val(txtCourse1.Text) >= 270 And Val(txtCourse1.Text) < 360 Then Course1 = 360 - Val(txtCourse1.Text) : xV11 = -1 : yV11 = 1
            V11x = xV11 * V1Dist * System.Math.Sin(Course1 * Pi / 180)
            V11y = yV11 * V1Dist * System.Math.Cos(Course1 * Pi / 180)
            If Val(txtCourse2.Text) >= 0 And Val(txtCourse2.Text) < 90 Then Course2 = Val(txtCourse2.Text) : xV21 = 1 : yV21 = 1
            If Val(txtCourse2.Text) >= 90 And Val(txtCourse2.Text) < 180 Then Course2 = 180 - Val(txtCourse2.Text) : xV21 = 1 : yV21 = -1
            If Val(txtCourse2.Text) >= 180 And Val(txtCourse2.Text) < 270 Then Course2 = Val(txtCourse2.Text) - 180 : xV21 = -1 : yV21 = -1
            If Val(txtCourse2.Text) >= 270 And Val(txtCourse2.Text) < 360 Then Course2 = 360 - Val(txtCourse2.Text) : xV21 = -1 : yV21 = 1
            V21x = V20x + xV21 * V2Dist * System.Math.Sin(Course2 * Pi / 180)
            V21y = V20y + yV21 * V2Dist * System.Math.Cos(Course2 * Pi / 180)
            DeltaX = V21x - V11x
            DeltaY = V21y - V11y
            CPABearing = System.Math.Atan(System.Math.Abs(DeltaY) / (System.Math.Abs(DeltaX) + 9.999999E-21)) * 180 / Pi
            If DeltaY >= 0 And DeltaX >= 0 Then CPABearing = 90 - CPABearing
            If DeltaY >= 0 And DeltaX < 0 Then CPABearing = 270 + CPABearing
            If DeltaY < 0 And DeltaX >= 0 Then CPABearing = 90 + CPABearing
            If DeltaY < 0 And DeltaX < 0 Then CPABearing = 270 - CPABearing
            CPABearing = Int(CPABearing * 10 + 0.5) / 10

            TimeToCPA = Int(TimeToCPA * 10 + 0.5) / 10
            Range = System.Math.Sqrt(Range)
            Range = Int(Range * 100 + 0.5) / 100
            If CPAexists = True Then
                txtMoB.AppendText("CPA = " & Strings.Format(Range, "0.00") & " nm in " & Strings.Format(TimeToCPA, "0.0") & " minutes" & vbNewLine) ';
                txtMoB.AppendText("Bearing at CPA = " & Strings.Format(CPABearing, "000.0") & Chr(176) & vbNewLine)
            End If
            If CPAexists = False Then
            End If
            txtMoB.AppendText("DRM = " & Strings.Format(DRM, "000.0") & Chr(176) & vbNewLine)
            txtMoB.AppendText("SRM = " & Strings.Format(SRM, "0.0") & " knots" & vbNewLine)
        End If
        If optWind.Checked = True Then
            txtMoB.Clear()
            ApparentWindDir = Val(txtCourse.Text) + Val(txtWindDir.Text)
            If ApparentWindDir >= 360 Then ApparentWindDir = ApparentWindDir - 360
            If Val(txtCourse.Text) >= 0 And Val(txtCourse.Text) < 90 Then Course = Val(txtCourse.Text) : xV1S = 1 : yV1S = 1
            If Val(txtCourse.Text) >= 90 And Val(txtCourse.Text) < 180 Then Course = 180 - Val(txtCourse.Text) : xV1S = 1 : yV1S = -1
            If Val(txtCourse.Text) >= 180 And Val(txtCourse.Text) < 270 Then Course = Val(txtCourse.Text) - 180 : xV1S = -1 : yV1S = -1
            If Val(txtCourse.Text) >= 270 And Val(txtCourse.Text) < 360 Then Course = 360 - Val(txtCourse.Text) : xV1S = -1 : yV1S = 1
            DeltaX = xV1S * Val(txtSpeed.Text) * System.Math.Sin(Course * Pi / 180) + Val(txtWindSpeed.Text) * System.Math.Sin((ApparentWindDir - 180) * Pi / 180)
            DeltaY = yV1S * Val(txtSpeed.Text) * System.Math.Cos(Course * Pi / 180) + Val(txtWindSpeed.Text) * System.Math.Cos((ApparentWindDir - 180) * Pi / 180)
            TrueWindDir = System.Math.Atan(System.Math.Abs(DeltaY) / System.Math.Abs(DeltaX + 9.999999E-21)) * 180 / Pi
            If DeltaY >= 0 And DeltaX >= 0 Then TrueWindDir = 90 - TrueWindDir
            If DeltaY >= 0 And DeltaX < 0 Then TrueWindDir = 270 + TrueWindDir
            If DeltaY < 0 And DeltaX >= 0 Then TrueWindDir = 90 + TrueWindDir
            If DeltaY < 0 And DeltaX < 0 Then TrueWindDir = 270 - TrueWindDir
            TrueWindDir = TrueWindDir - 180
            TrueWindSpeed = System.Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY)
            If TrueWindDir >= 360 Then TrueWindDir = TrueWindDir - 360
            If TrueWindDir < 0 Then TrueWindDir = TrueWindDir + 360
            TrueWindDir = Int(TrueWindDir * 10 + 0.5) / 10
            TrueWindSpeed = Int(TrueWindSpeed * 10 + 0.5) / 10
            txtMoB.AppendText("True wind from " & Strings.Format(TrueWindDir, "000.0") & Chr(176) & " at " & Strings.Format(TrueWindSpeed, "0.0") & " knots" & vbNewLine)
        End If
        If optWindApp.Checked = True Then
            txtMoB.Clear()
            PointingAngle = Val(txtWindDir.Text) - Val(txtCourse.Text) 'if both the same, gives 0 (upwind), should give 180 (downwind)
            If PointingAngle < 0 Then PointingAngle = PointingAngle + 360
            PointingAngle = PointingAngle * Pi / 180 'radians
            If PointingAngle < 0 Then PointingAngle = PointingAngle + 2 * Pi
            ApparentWindSpeed = System.Math.Sqrt(Val(txtWindSpeed.Text) * Val(txtWindSpeed.Text) + Val(txtSpeed.Text) * Val(txtSpeed.Text) + 2 * Val(txtWindSpeed.Text) * Val(txtSpeed.Text) * System.Math.Cos(PointingAngle))
            If ApparentWindSpeed = 0 Then ApparentWindSpeed = 1.0E-21 'prevents overflow error
            ApparentWindDir = (Val(txtWindSpeed.Text) * System.Math.Cos(PointingAngle) + Val(txtSpeed.Text)) / ApparentWindSpeed
            If ApparentWindDir = 1 Then ApparentWindDir = ApparentWindDir - 0.0000001 'prevents divide-by-zero error
            ApparentWindDir = System.Math.Atan(-ApparentWindDir / System.Math.Sqrt(-ApparentWindDir * ApparentWindDir + 1)) + Pi / 2 'arccos in radians
            ApparentWindDir = ApparentWindDir * 180 / Pi
            If PointingAngle > Pi Then ApparentWindDir = 360 - ApparentWindDir '180º
            ApparentWindDir = Int(ApparentWindDir * 10 + 0.5) / 10
            ApparentWindSpeed = Int(ApparentWindSpeed * 10 + 0.5) / 10
            txtMoB.AppendText("Apparent wind from " & Strings.Format(ApparentWindDir, "000.0") & Chr(176) & " relative at " & Strings.Format(ApparentWindSpeed, "0.0") & " knots" & vbNewLine)
        End If
        'intResponse = ErrorMsgBoxResult.Ignore
    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        If optCPATypeA.Checked = True Then
            txtTime1.Text = ""
            txtTime2.Text = ""
            txtRange1.Text = ""
            txtRange2.Text = ""
            txtBearing1.Text = ""
            txtBearing2.Text = ""
            txtV1Speed.Text = ""
            txtV1Course.Text = ""
            txtMoB.Clear()
            txtTime1.Focus()

        End If
        If optCPATypeB.Checked = True Then
            txtSpeed1.Text = ""
            txtSpeed2.Text = ""
            txtCourse1.Text = ""
            txtCourse2.Text = ""
            txtRange.Text = ""
            txtBearing.Text = ""
            txtMoB.Clear()
            txtCourse1.Focus()
        End If
        If optWind.Checked = True Or optWindApp.Checked = True Then
            txtCourse.Text = ""
            txtSpeed.Text = ""
            txtWindSpeed.Text = ""
            txtWindDir.Text = ""
            txtMoB.Clear()
            txtCourse.Focus()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub optCPATypeA_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCPATypeA.CheckedChanged
        If eventSender.Checked Then
            If optCPATypeA.Checked = True Then
                cmdCalculate.TabIndex = 14
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label8.Visible = False
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                Label15.Visible = False
                txtTime1.Visible = True
                txtTime2.Visible = True
                txtRange1.Visible = True
                txtRange2.Visible = True
                txtBearing1.Visible = True
                txtBearing2.Visible = True
                txtSpeed1.Visible = False
                txtSpeed2.Visible = False
                txtCourse1.Visible = False
                txtCourse2.Visible = False
                txtRange.Visible = False
                txtBearing.Visible = False
                Label16.Visible = True
                Label17.Visible = True
                txtV1Course.Visible = True
                txtV1Speed.Visible = True
                txtTime1.Focus()
                Label18.Visible = False
                Label19.Visible = False
                Label20.Visible = False
                Label21.Visible = False
                Label22.Visible = False
                Label23.Visible = False
                txtCourse.Visible = False
                txtSpeed.Visible = False
                txtWindSpeed.Visible = False
                txtWindDir.Visible = False
            End If
            txtMoB.Clear()
        End If
    End Sub
    Private Sub optCPATypeB_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCPATypeB.CheckedChanged
        If eventSender.Checked Then
            If optCPATypeB.Checked = True Then
                cmdCalculate.TabIndex = 27
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
                Label15.Visible = True
                txtTime1.Visible = False
                txtTime2.Visible = False
                txtRange1.Visible = False
                txtRange2.Visible = False
                txtBearing1.Visible = False
                txtBearing2.Visible = False
                txtSpeed1.Visible = True
                txtSpeed2.Visible = True
                txtCourse1.Visible = True
                txtCourse2.Visible = True
                txtRange.Visible = True
                txtBearing.Visible = True
                Label16.Visible = False
                Label17.Visible = False
                txtV1Course.Visible = False
                txtV1Speed.Visible = False
                txtCourse1.Focus()
                Label18.Visible = False
                Label19.Visible = False
                Label20.Visible = False
                Label21.Visible = False
                Label22.Visible = False
                Label23.Visible = False
                txtCourse.Visible = False
                txtSpeed.Visible = False
                txtWindSpeed.Visible = False
                txtWindDir.Visible = False
            End If
            txtMoB.Clear()
        End If
    End Sub
    Private Sub optWind_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optWind.CheckedChanged
        If eventSender.Checked Then
            If optWind.Checked = True Then
                cmdCalculate.TabIndex = 27
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                Label8.Visible = False
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                Label15.Visible = False
                txtTime1.Visible = False
                txtTime2.Visible = False
                txtRange1.Visible = False
                txtRange2.Visible = False
                txtBearing1.Visible = False
                txtBearing2.Visible = False
                txtSpeed1.Visible = False
                txtSpeed2.Visible = False
                txtCourse1.Visible = False
                txtCourse2.Visible = False
                txtRange.Visible = False
                txtBearing.Visible = False
                Label16.Visible = False
                Label17.Visible = False
                txtV1Course.Visible = False
                txtV1Speed.Visible = False
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label21.Visible = True
                Label22.Visible = False
                Label23.Visible = False
                txtCourse.Visible = True
                txtCourse.Focus()
                txtSpeed.Visible = True
                txtWindSpeed.Visible = True
                txtWindDir.Visible = True
            End If
            cmdClear_Click(cmdClear, New System.EventArgs())
        End If
    End Sub
    Private Sub optWindApp_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optWindApp.CheckedChanged
        If eventSender.Checked Then
            If optWindApp.Checked = True Then
                cmdCalculate.TabIndex = 27
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                Label8.Visible = False
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                Label15.Visible = False
                txtTime1.Visible = False
                txtTime2.Visible = False
                txtRange1.Visible = False
                txtRange2.Visible = False
                txtBearing1.Visible = False
                txtBearing2.Visible = False
                txtSpeed1.Visible = False
                txtSpeed2.Visible = False
                txtCourse1.Visible = False
                txtCourse2.Visible = False
                txtRange.Visible = False
                txtBearing.Visible = False
                Label16.Visible = False
                Label17.Visible = False
                txtV1Course.Visible = False
                txtV1Speed.Visible = False
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = False
                Label21.Visible = False
                Label22.Visible = True
                Label23.Visible = True
                txtCourse.Visible = True
                txtCourse.Focus()
                txtSpeed.Visible = True
                txtWindSpeed.Visible = True
                txtWindDir.Visible = True
            End If
            cmdClear_Click(cmdClear, New System.EventArgs())
        End If
    End Sub
    Private Sub txtBearing_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing.TextChanged
        If Val(txtBearing.Text) > 359.9 Then
            txtBearing.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtBearing.Text) < 359.9 Then
            txtBearing.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtBearing_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBearing.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtBearing.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtBearing_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBearing.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtBearing.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtBearing_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing.Enter
        SelectAllText(txtBearing)
    End Sub

    Private Sub txtBearing1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing1.TextChanged
        If Val(txtBearing1.Text) > 359.9 Then
            txtBearing1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtBearing1.Text) < 359.9 Then
            txtBearing1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtBearing1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBearing1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtBearing1.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtBearing1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBearing1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtBearing1.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtBearing1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing1.Enter
        SelectAllText(txtBearing1)
    End Sub

    Private Sub txtBearing2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing2.TextChanged
        If Val(txtBearing2.Text) > 359.9 Then
            txtBearing2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtBearing2.Text) < 359.9 Then
            txtBearing2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtBearing2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBearing2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtBearing2.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtBearing2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBearing2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtBearing2.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtBearing2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing2.Enter
        SelectAllText(txtBearing2)
    End Sub

    Private Sub txtCourse1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse1.TextChanged
        If Val(txtCourse1.Text) > 359.9 Then
            txtCourse1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtCourse1.Text) < 359.9 Then
            'txtCourse.ForeColor = &H80000008
            txtCourse1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCourse1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCourse1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtCourse1.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtCourse1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCourse1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCourse1.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCourse1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse1.Enter
        SelectAllText(txtCourse1)
    End Sub

    Private Sub txtCourse2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse2.TextChanged
        If Val(txtCourse2.Text) > 359.9 Then
            txtCourse2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtCourse2.Text) < 359.9 Then
            txtCourse2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCourse2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCourse2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtCourse2.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtCourse2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCourse2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCourse2.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCourse2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse2.Enter
        SelectAllText(txtCourse2)
    End Sub

    Private Sub txtRange_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRange.TextChanged
        If Val(txtRange.Text) > 99.99 Then
            txtRange.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtRange.Text) <= 99.99 Then
            'txtDist.ForeColor = &H80000008
            txtRange.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtRange_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRange.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtRange.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtRange_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtRange.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtDist.Text) > 600 Then
        '    KeepFocus = True
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtRange_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRange.Enter
        SelectAllText(txtRange)
    End Sub

    Private Sub txtRange1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRange1.TextChanged
        If Val(txtRange1.Text) > 99.99 Then
            txtRange1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtRange1.Text) <= 99.99 Then
            txtRange1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtRange1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRange1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtRange1.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtRange1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtRange1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtDist.Text) > 600 Then
        '    KeepFocus = True
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtRange1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRange1.Enter
        SelectAllText(txtRange1)
    End Sub

    Private Sub txtRange2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRange2.TextChanged
        If Val(txtRange2.Text) > 99.99 Then
            txtRange2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtRange2.Text) <= 99.99 Then
            txtRange2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtRange2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRange2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtRange2.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()

    End Sub

    Private Sub txtRange2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtRange2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtDist.Text) > 600 Then
        '    KeepFocus = True
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtRange2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRange2.Enter
        SelectAllText(txtRange2)
    End Sub

    Private Sub txtSpeed1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed1.TextChanged
        If Val(txtSpeed1.Text) > 99.9 Then
            txtSpeed1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSpeed1.Text) <= 99.9 Then
            txtSpeed1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtSpeed1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSpeed1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtSpeed1.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtSpeed1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSpeed1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSpeed1.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSpeed1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed1.Enter
        SelectAllText(txtSpeed1)
    End Sub

    Private Sub txtSpeed2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed2.TextChanged
        If Val(txtSpeed2.Text) > 99.9 Then
            txtSpeed2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSpeed2.Text) <= 99.9 Then
            txtSpeed2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtSpeed2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSpeed2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtSpeed2.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtSpeed2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSpeed2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSpeed2.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSpeed2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed2.Enter
        SelectAllText(txtSpeed2)
    End Sub

    Private Sub txtTime1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.TextChanged
        txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime1.Text) = 4 And (Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(Mid(txtTime1.Text, 3, 2)) > 59) Then
            txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub
    Private Sub txtTime1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtTime1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(Mid(txtTime1.Text, 3, 2)) > 59 Or Len(txtTime1.Text) <> 4 Then
            KeepFocus = True
            If txtTime1.Text = "" Then KeepFocus = False
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.Enter
        SelectAllText(txtTime1)
    End Sub

    Private Sub txtTime2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime2.TextChanged
        txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime2.Text) = 4 And (Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59) Then
            txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub
    Private Sub txtTime2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtTime2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59 Or Len(txtTime2.Text) <> 4 Then
            KeepFocus = True
            If txtTime2.Text = "" Then KeepFocus = False
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime2.Enter
        SelectAllText(txtTime2)
    End Sub

    Private Sub txtV1Course_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtV1Course.TextChanged
        If Val(txtV1Course.Text) > 359.9 Then
            txtV1Course.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtV1Course.Text) < 359.9 Then
            txtV1Course.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtV1Course_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtV1Course.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtV1Course.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtV1Course_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtV1Course.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtV1Course.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtV1Course_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtV1Course.Enter
        SelectAllText(txtV1Course)
    End Sub

    Private Sub txtV1Speed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtV1Speed.TextChanged
        If Val(txtV1Speed.Text) > 99.9 Then
            txtV1Speed.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtV1Speed.Text) <= 99.9 Then
            txtV1Speed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtV1Speed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtV1Speed.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtV1Speed.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtV1Speed_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtV1Speed.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtV1Speed.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtV1Speed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtV1Speed.Enter
        SelectAllText(txtV1Speed)
    End Sub

    Private Sub txtCourse_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.TextChanged
        If Val(txtCourse.Text) > 359.9 Then
            txtCourse.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtCourse.Text) < 359.9 Then
            txtCourse.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCourse_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCourse.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtCourse.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtCourse_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCourse.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCourse.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCourse_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.Enter
        SelectAllText(txtCourse)
    End Sub

    Private Sub txtSpeed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.TextChanged
        If Val(txtSpeed.Text) > 99.9 Then
            txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSpeed.Text) <= 99.9 Then
            txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtSpeed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSpeed.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtSpeed.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtSpeed_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSpeed.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSpeed.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSpeed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.Enter
        SelectAllText(txtSpeed)
    End Sub

    Private Sub txtWindDir_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWindDir.TextChanged
        If System.Math.Abs(Val(txtWindDir.Text)) > 359.9 Then
            txtWindDir.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If System.Math.Abs(Val(txtWindDir.Text)) < 359.9 Then
            txtWindDir.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtWindDir_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWindDir.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        Static bPlusSignAlready As Boolean
        bMinusSignAlready = False
        bPlusSignAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                'do nothing
            Case Asc("-")
                'If Len(txtWindDir.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtWindDir.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")
                'If Len(txtWindDir.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If

                If txtWindDir.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If

            Case Asc(".") 'only allows one decimal point
                If InStr(txtWindDir.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtWindDir_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtWindDir.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtWindDir.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtWindDir_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWindDir.Enter
        SelectAllText(txtWindDir)
    End Sub

    Private Sub txtWindSpeed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWindSpeed.TextChanged
        If Val(txtWindSpeed.Text) > 99.9 Then
            txtWindSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtWindSpeed.Text) <= 99.9 Then
            txtWindSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtWindSpeed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWindSpeed.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtWindSpeed.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtWindSpeed_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtWindSpeed.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtWindSpeed.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtWindSpeed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWindSpeed.Enter
        SelectAllText(txtWindSpeed)
    End Sub

    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub

    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
End Class