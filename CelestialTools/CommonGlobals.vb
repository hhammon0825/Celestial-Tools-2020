Module CommonGlobals
    Public CommonPublicVars As String = ""
    ' These are the common unicode symbol defs for astronomical bodies that can be used in text strings and graphics drawstrings
    ' solar system bodies symbols
    Public Sun_Uchar As Char = ChrW(&H2609)
    Public Moon_Uchar As Char = ChrW(&H263D)
    Public Mercury_Uchar As Char = ChrW(&H263F)
    Public Venus_Uchar As Char = ChrW(&H2640)
    Public Earth_Uchar As Char = ChrW(&H2295)
    Public Mars_Uchar As Char = ChrW(&H2642)
    Public Jupiter_Uchar As Char = ChrW(&H2643)
    Public Saturn_Uchar As Char = ChrW(&H2644)
    Public Uranus_Uchar As Char = ChrW(&H2645)
    Public Neptune_Uchar As Char = ChrW(&H2646)
    Public Pluto_Uchar As Char = ChrW(&H2BD3)
    ' Symbols of the ecliptic and aries
    Public Aries_Uchar As Char = ChrW(&H2648)
    Public Taurus_Uchar As Char = ChrW(&H2649)
    Public Gemini_Uchar As Char = ChrW(&H264A)
    Public Cancer_Uchar As Char = ChrW(&H264B)
    Public Leo_Uchar As Char = ChrW(&H264C)
    Public Virgo_Uchar As Char = ChrW(&H264D)
    Public Libra_Uchar As Char = ChrW(&H264E)
    Public Scorpio_Uchar As Char = ChrW(&H264F)
    Public Sagittarius_Uchar As Char = ChrW(&H2650)
    Public Capricorn_Uchar As Char = ChrW(&H2651)
    Public Aquarius_Uchar As Char = ChrW(&H2652)
    Public Pisces_Uchar As Char = ChrW(&H2653)
    Public Ophiuchus_Uchar As Char = ChrW(&H26CE)
    ' Miscellaneous symbols for sun, moon, anchors, and a sailboat
    Public Sun_with_Rays_Uchar As Char = ChrW(&H2600)
    Public Black_Star_Uchar As Char = ChrW(&H2605)
    Public White_Star_Uchar As Char = ChrW(&H2606)
    Public White_Sun_with_Rays_Uchar As Char = ChrW(&H263C)
    Public Moon_FirstQtr_Uchar As Char = ChrW(&H263D)
    Public Moon_LastQtr_Uchar As Char = ChrW(&H263E)
    Public Sailboat_Uchar As Char = ChrW(&H26F5)
    Public Anchor_Uchar As Char = ChrW(&H2693)
    ' these extended characters require special code handling to use - do not use without research
    Public New_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F311)
    Public Crescent_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F312)
    Public First_quarter_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F313)
    Public Gibbous_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F314)
    Public Full_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F315)
    Public Disseminating_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F316)
    Public Last_quarter_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F317)
    Public Balsamic_moon_Uchar As Char = Char.ConvertFromUtf32(&H1F318)
    ' Common Lat and Long strings
    Public g_LongW As String = "W"
    Public g_LongE As String = "E"
    Public g_LatN As String = "N"
    Public g_LatS As String = "S"
    Public g_StrSpace As String = " "
    ' Degrees in an hour for sun/planets, aries, and moon for I&C calcs and SRF
    Public g_SunPlanetsHrDeg As Double = 15.0  ' 360 deg / 24 hrs
    Public g_AriesHrDeg As Double = 15.04106864 ' 23 hrs 56 min 4.1 sec 
    Public g_MoonHrDeg As Double = 14 + 19 / 60
    Public g_TextZero As String = "0"

    Public Function SailingsFindDestLLo(ByVal LatIn As Double, ByVal LonIn As Double, ByVal Dist As Double, ByVal Course As Double) As System.Device.Location.GeoCoordinate

        Dim LatDiff As Double = (Dist * Math.Cos(Course * Math.PI / 180)) / 60
        If Course > 90 And Course < 270 Then
            LatDiff = -LatDiff
        End If
        Dim L2 As Double = LatIn + LatDiff

        L2 = (LatIn * Math.PI / 180) + (Dist / 60 * Math.PI / 180) * Math.Cos(Course * Math.PI / 180)
        Dim q As Double = 0
        Dim dphi As Double = 0
        If Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001) Then
            q = Math.Cos(LatIn * Math.PI / 180)
        Else
            dphi = Math.Log(Math.Tan((L2) / 2 + Math.PI / 4) / Math.Tan((LatIn * Math.PI / 180) / 2 + Math.PI / 4))
            q = (LatDiff * Math.PI / 180) / dphi
        End If
        Dim DLo As Double = (Dist / 60 * Math.PI / 180) * Math.Sin(Course * Math.PI / 180) / q
        DLo = DLo * 180 / Math.PI
        L2 = L2 * 180 / Math.PI
        'End If
        Dim LoSign As Integer = Math.Sign(LonIn)
        Dim Lo2 As Double = LoSign * (Math.Abs(LonIn) + DLo)
        Do While Lo2 >= 360
            Lo2 = Lo2 - 360
        Loop
        'Crossing IDL
        If Math.Abs(Lo2) > 180 Then
            Lo2 = -Math.Sign(Lo2) * (360 - Math.Abs(Lo2))
        End If
        Dim RtnGC As System.Device.Location.GeoCoordinate = New System.Device.Location.GeoCoordinate(L2, Lo2)
        Return (RtnGC)
    End Function
    ' These are common subroutines and functions that perform common nautical and math functions
    Public Function C_FindDestLatLong(ByVal LatIn As Double, ByVal LonIn As Double, ByVal Dist As Double, ByVal Course As Double) As System.Device.Location.GeoCoordinate
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
        'Dim DegreesToRadians As Double = System.Math.PI / 180
        'Dim RadiansToDegrees As Double = 180 / System.Math.PI
        'Dim lat1 As Double = DegreesToRadians * (LatIn)
        'Dim Lon1 As Double = LonIn
        'Dim Theta As Double = DegreesToRadians * (Course)
        'Dim R As Double = 3443.92  ' this is the radius of the earth in nautical miles
        'Dim d As Double = Dist    ' this is the distance travelled in nautical miles
        'Dim DDivR As Double = (d / R)

        'Dim lat2 As Double = RadiansToDegrees * (Math.Asin(Math.Sin(lat1) * Math.Cos(DDivR) + Math.Cos(lat1) * Math.Sin(DDivR) * Math.Cos(Theta)))
        'Dim lon2 As Double = Lon1 + RadiansToDegrees * (Math.Atan2((Math.Sin(Theta) * Math.Sin(DDivR) * Math.Cos(lat1)), (Math.Cos(DDivR) - (Math.Sin(lat1) * Math.Sin(lat2)))))
        'Dim RtnGC As System.Device.Location.GeoCoordinate = New System.Device.Location.GeoCoordinate(lat2, lon2)
        'Return RtnGC
    End Function
    Public Function C_IsFileInUse(sFile As String) As Boolean
        Try
            Using f As New System.IO.FileStream(sFile, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None)
            End Using
        Catch Ex As Exception
            Return True
        End Try
        Return False
    End Function
End Module
