using System;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    static class CommonGlobals
    {
        public static string CommonPublicVars = "";
        // These are the common unicode symbol defs for astronomical bodies that can be used in text strings and graphics drawstrings
        // solar system bodies symbols
        public static char Sun_Uchar = '☉';
        public static char Moon_Uchar = '☽';
        public static char Mercury_Uchar = '☿';
        public static char Venus_Uchar = '♀';
        public static char Earth_Uchar = '⊕';
        public static char Mars_Uchar = '♂';
        public static char Jupiter_Uchar = '♃';
        public static char Saturn_Uchar = '♄';
        public static char Uranus_Uchar = '♅';
        public static char Neptune_Uchar = '♆';
        public static char Pluto_Uchar = '\u2bd3';
        // Symbols of the ecliptic and aries
        public static char Aries_Uchar = '♈';
        public static char Taurus_Uchar = '♉';
        public static char Gemini_Uchar = '♊';
        public static char Cancer_Uchar = '♋';
        public static char Leo_Uchar = '♌';
        public static char Virgo_Uchar = '♍';
        public static char Libra_Uchar = '♎';
        public static char Scorpio_Uchar = '♏';
        public static char Sagittarius_Uchar = '♐';
        public static char Capricorn_Uchar = '♑';
        public static char Aquarius_Uchar = '♒';
        public static char Pisces_Uchar = '♓';
        public static char Ophiuchus_Uchar = '⛎';
        // Miscellaneous symbols for sun, moon, anchors, and a sailboat
        public static char Sun_with_Rays_Uchar = '☀';
        public static char Black_Star_Uchar = '★';
        public static char White_Star_Uchar = '☆';
        public static char White_Sun_with_Rays_Uchar = '☼';
        public static char Moon_FirstQtr_Uchar = '☽';
        public static char Moon_LastQtr_Uchar = '☾';
        public static char Sailboat_Uchar = '⛵';
        public static char Anchor_Uchar = '⚓';
        // these extended characters require special code handling to use - do not use without research
        public static char New_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F311));
        public static char Crescent_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F312));
        public static char First_quarter_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F313));
        public static char Gibbous_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F314));
        public static char Full_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F315));
        public static char Disseminating_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F316));
        public static char Last_quarter_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F317));
        public static char Balsamic_moon_Uchar = Conversions.ToChar(char.ConvertFromUtf32(0x1F318));
        // Common Lat and Long strings
        public static string g_LongW = "W";
        public static string g_LongE = "E";
        public static string g_LatN = "N";
        public static string g_LatS = "S";
        public static string g_StrSpace = " ";
        // Degrees in an hour for sun/planets, aries, and moon for I&C calcs and SRF
        public static double g_SunPlanetsHrDeg = 15.0d;  // 360 deg / 24 hrs
        public static double g_AriesHrDeg = 15.04106864d; // 23 hrs 56 min 4.1 sec 
        public static double g_MoonHrDeg = 14d + 19d / 60d;
        public static string g_TextZero = "0";

        public static System.Device.Location.GeoCoordinate SailingsFindDestLLo(double LatIn, double LonIn, double Dist, double Course)
        {
            double LatDiff = Dist * Math.Cos(Course * Math.PI / 180d) / 60d;
            if (Course > 90d & Course < 270d)
            {
                LatDiff = -LatDiff;
            }

            double L2 = LatIn + LatDiff;
            L2 = LatIn * Math.PI / 180d + Dist / 60d * Math.PI / 180d * Math.Cos(Course * Math.PI / 180d);
            double q = 0d;
            double dphi = 0d;
            if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
            {
                q = Math.Cos(LatIn * Math.PI / 180d);
            }
            else
            {
                dphi = Math.Log(Math.Tan(L2 / 2d + Math.PI / 4d) / Math.Tan(LatIn * Math.PI / 180d / 2d + Math.PI / 4d));
                q = LatDiff * Math.PI / 180d / dphi;
            }

            double DLo = Dist / 60d * Math.PI / 180d * Math.Sin(Course * Math.PI / 180d) / q;
            DLo = DLo * 180d / Math.PI;
            L2 = L2 * 180d / Math.PI;
            // End If
            int LoSign = Math.Sign(LonIn);
            double Lo2 = LoSign * (Math.Abs(LonIn) + DLo);
            while (Lo2 >= 360d)
                Lo2 = Lo2 - 360d;
            // Crossing IDL
            if (Math.Abs(Lo2) > 180d)
            {
                Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
            }

            var RtnGC = new System.Device.Location.GeoCoordinate(L2, Lo2);
            return RtnGC;
        }
        // These are common subroutines and functions that perform common nautical and math functions
        public static System.Device.Location.GeoCoordinate C_FindDestLatLong(double LatIn, double LonIn, double Dist, double Course)
        {
            double L2 = Math.Sin(LatIn * Math.PI / 180d) * Math.Cos(Dist / 3437.75d) + Math.Cos(LatIn * Math.PI / 180d) * Math.Sin(Dist / 3437.75d) * Math.Cos(Course * Math.PI / 180d);
            L2 = Math.Atan(L2 / Math.Sqrt(-L2 * L2 + 1d));
            double Lo2 = -1 * LonIn * Math.PI / 180d - Math.Atan2(Math.Sin(Course * Math.PI / 180d) * Math.Sin(Dist / 3437.75d) * Math.Cos(LatIn * Math.PI / 180d), Math.Cos(Dist / 3437.75d) - Math.Sin(LatIn * Math.PI / 180d) * Math.Sin(L2));
            L2 = L2 * 180d / Math.PI;
            Lo2 = Lo2 * 180d / Math.PI;
            if (Course == 0d & Dist > (90d - LatIn) * 60d)
            {
                Lo2 = -(180d - Lo2);
            }

            if (Math.Abs(Lo2) > 180d)
            {
                Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
            }

            var RtnGC = new System.Device.Location.GeoCoordinate(L2, -1 * Lo2);
            return RtnGC;
            // Dim DegreesToRadians As Double = System.Math.PI / 180
            // Dim RadiansToDegrees As Double = 180 / System.Math.PI
            // Dim lat1 As Double = DegreesToRadians * (LatIn)
            // Dim Lon1 As Double = LonIn
            // Dim Theta As Double = DegreesToRadians * (Course)
            // Dim R As Double = 3443.92  ' this is the radius of the earth in nautical miles
            // Dim d As Double = Dist    ' this is the distance travelled in nautical miles
            // Dim DDivR As Double = (d / R)

            // Dim lat2 As Double = RadiansToDegrees * (Math.Asin(Math.Sin(lat1) * Math.Cos(DDivR) + Math.Cos(lat1) * Math.Sin(DDivR) * Math.Cos(Theta)))
            // Dim lon2 As Double = Lon1 + RadiansToDegrees * (Math.Atan2((Math.Sin(Theta) * Math.Sin(DDivR) * Math.Cos(lat1)), (Math.Cos(DDivR) - (Math.Sin(lat1) * Math.Sin(lat2)))))
            // Dim RtnGC As System.Device.Location.GeoCoordinate = New System.Device.Location.GeoCoordinate(lat2, lon2)
            // Return RtnGC
        }

        public static bool C_IsFileInUse(string sFile)
        {
            try
            {
                using (var f = new System.IO.FileStream(sFile, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None))
                {
                }
            }
            catch (Exception Ex)
            {
                return true;
            }

            return false;
        }
    }
}