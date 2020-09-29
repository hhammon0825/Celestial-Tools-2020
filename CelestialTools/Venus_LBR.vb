Option Strict Off
Option Explicit On
Module VenusFunctions
    Public Function Venus_L01(ByRef T As Double) As Double
        ' L0 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 3.17614666774 * System.Math.Cos(0 + 0 * T)
        q = q + 0.01353968419 * System.Math.Cos(5.59313319619 + 10213.285546211 * T)
        q = q + 0.00089891645 * System.Math.Cos(5.30650048468 + 20426.571092422 * T)
        q = q + 0.00005477201 * System.Math.Cos(4.41630652531 + 7860.4193924392 * T)
        q = q + 0.00003455732 * System.Math.Cos(2.69964470778 + 11790.6290886588 * T)
        q = q + 0.00002372061 * System.Math.Cos(2.99377539568 + 3930.2096962196 * T)
        q = q + 0.00001664069 * System.Math.Cos(4.2501893503 + 1577.3435424478 * T)
        q = q + 0.00001438322 * System.Math.Cos(4.15745043958 + 9683.5945811164 * T)
        q = q + 0.00001317108 * System.Math.Cos(5.18668219093 + 26.2983197998 * T)
        q = q + 0.00001200521 * System.Math.Cos(6.15357115319 + 30639.856638633 * T)
        q = q + 0.00000769314 * System.Math.Cos(0.81629615911 + 9437.762934887 * T)
        q = q + 0.0000076138 * System.Math.Cos(1.9501470212 + 529.6909650946 * T)
        q = q + 0.00000707676 * System.Math.Cos(1.06466707214 + 775.522611324 * T)
        q = q + 0.00000584836 * System.Math.Cos(3.99839884762 + 191.4482661116 * T)
        q = q + 0.00000499915 * System.Math.Cos(4.12340210074 + 15720.8387848784 * T)
        q = q + 0.00000429498 * System.Math.Cos(3.58642859752 + 19367.1891622328 * T)
        q = q + 0.00000326967 * System.Math.Cos(5.67736583705 + 5507.5532386674 * T)
        q = q + 0.00000326221 * System.Math.Cos(4.59056473097 + 10404.7338123226 * T)
        q = q + 0.00000231937 * System.Math.Cos(3.16251057072 + 9153.9036160218 * T)
        q = q + 0.00000179695 * System.Math.Cos(4.65337915578 + 1109.3785520934 * T)
        q = q + 0.00000155464 * System.Math.Cos(5.57043888948 + 19651.048481098 * T)
        q = q + 0.00000128263 * System.Math.Cos(4.22604493736 + 20.7753954924 * T)
        q = q + 0.00000127907 * System.Math.Cos(0.96209822685 + 5661.3320491522 * T)
        q = q + 0.00000105547 * System.Math.Cos(1.53721191253 + 801.8209311238 * T)
        Return (q * 1)
    End Function
    Public Function Venus_L11(ByRef T As Double) As Double
        ' L1 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 10213.529430529 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00095707712 * System.Math.Cos(2.46424448979 + 10213.285546211 * T)
        q = q + 0.00014444977 * System.Math.Cos(0.51624564679 + 20426.571092422 * T)
        q = q + 0.00000213374 * System.Math.Cos(1.79547929368 + 30639.856638633 * T)
        q = q + 0.00000173904 * System.Math.Cos(2.65535879443 + 26.2983197998 * T)
        q = q + 0.00000151669 * System.Math.Cos(6.10635282369 + 1577.3435424478 * T)
        q = q + 0.00000082233 * System.Math.Cos(5.7023413373 + 191.4482661116 * T)
        q = q + 0.00000069734 * System.Math.Cos(2.68136034979 + 9437.762934887 * T)
        q = q + 0.00000052408 * System.Math.Cos(3.60013087656 + 775.522611324 * T)
        q = q + 0.00000038318 * System.Math.Cos(1.03379038025 + 529.6909650946 * T)
        q = q + 0.00000029633 * System.Math.Cos(1.25056322354 + 5507.5532386674 * T)
        q = q + 0.00000025056 * System.Math.Cos(6.10664792855 + 10404.7338123226 * T)
        Return (q * T)
    End Function
    Public Function Venus_L21(ByRef T As Double) As Double
        ' L2 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00054127076 * System.Math.Cos(0 + 0 * T)
        q = q + 0.0000389146 * System.Math.Cos(0.34514360047 + 10213.285546211 * T)
        q = q + 0.0000133788 * System.Math.Cos(2.02011286082 + 20426.571092422 * T)
        q = q + 0.00000023836 * System.Math.Cos(2.04592119012 + 26.2983197998 * T)
        q = q + 0.00000019331 * System.Math.Cos(3.53527371458 + 30639.856638633 * T)
        q = q + 0.00000009984 * System.Math.Cos(3.97130221102 + 775.522611324 * T)
        q = q + 0.00000007046 * System.Math.Cos(1.51962593409 + 1577.3435424478 * T)
        q = q + 0.00000006014 * System.Math.Cos(0.99926757893 + 191.4482661116 * T)
        Return (q * T * T)
    End Function
    Public Function Venus_L31(ByRef T As Double) As Double
        ' L3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000135742 * System.Math.Cos(4.80389020993 + 10213.285546211 * T)
        q = q + 0.00000077846 * System.Math.Cos(3.66876371591 + 20426.571092422 * T)
        q = q + 0.00000026023 * System.Math.Cos(0 + 0 * T)
        Return (q * T * T * T)
    End Function
    Public Function Venus_L41(ByRef T As Double) As Double
        ' L4 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000114016 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000003209 * System.Math.Cos(5.20514170164 + 20426.571092422 * T)
        q = q + 0.00000001714 * System.Math.Cos(2.51099591706 + 10213.285546211 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Venus_L51(ByRef T As Double) As Double
        ' L5 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000000874 * System.Math.Cos(3.14159265359 + 0 * T)
        Return (q * T * T * T * T * T)
    End Function
    Public Function Venus_B01(ByRef T As Double) As Double
        ' B0 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.05923638472 * System.Math.Cos(0.26702775813 + 10213.285546211 * T)
        q = q + 0.00040107978 * System.Math.Cos(1.14737178106 + 20426.571092422 * T)
        q = q + 0.00032814918 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00001011392 * System.Math.Cos(1.08946123021 + 30639.856638633 * T)
        q = q + 0.00000149458 * System.Math.Cos(6.25390296069 + 18073.7049386502 * T)
        q = q + 0.00000137788 * System.Math.Cos(0.86020146523 + 1577.3435424478 * T)
        q = q + 0.00000129973 * System.Math.Cos(3.67152483651 + 9437.762934887 * T)
        q = q + 0.00000119507 * System.Math.Cos(3.70468812804 + 2352.8661537718 * T)
        q = q + 0.00000107971 * System.Math.Cos(4.53903677647 + 22003.9146348698 * T)
        Return (q * 1)
    End Function
    Public Function Venus_B11(ByRef T As Double) As Double
        ' B1 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00513347602 * System.Math.Cos(1.80364310797 + 10213.285546211 * T)
        q = q + 0.000043801 * System.Math.Cos(3.38615711591 + 20426.571092422 * T)
        q = q + 0.00000199162 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000196586 * System.Math.Cos(2.53001197486 + 30639.856638633 * T)
        Return (q * T)
    End Function
    Public Function Venus_B21(ByRef T As Double) As Double
        ' B2 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00022377665 * System.Math.Cos(3.38509143877 + 10213.285546211 * T)
        q = q + 0.00000281739 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000173164 * System.Math.Cos(5.25563766915 + 20426.571092422 * T)
        q = q + 0.00000026945 * System.Math.Cos(3.87040891568 + 30639.856638633 * T)
        Return (q * T * T)
    End Function
    Public Function Venus_B31(ByRef T As Double) As Double
        ' B3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000646671 * System.Math.Cos(4.99166565277 + 10213.285546211 * T)
        q = q + 0.00000019952 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.0000000554 * System.Math.Cos(0.77376923951 + 20426.571092422 * T)
        q = q + 0.00000002526 * System.Math.Cos(5.4449376302 + 30639.856638633 * T)
        Return (q * T * T * T)
    End Function
    Public Function Venus_B41(ByRef T As Double) As Double
        ' B4 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000014102 * System.Math.Cos(0.31537190181 + 10213.285546211 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Venus_B51(ByRef T As Double) As Double
        ' B5 Segment #1 of 1
        Dim q As Double = 0.0
        Return (q * T * T * T * T * T)
    End Function
    Public Function Venus_R01(ByRef T As Double) As Double
        ' R0 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.72334820905 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00489824185 * System.Math.Cos(4.02151832268 + 10213.285546211 * T)
        q = q + 0.00001658058 * System.Math.Cos(4.90206728012 + 20426.571092422 * T)
        q = q + 0.00001632093 * System.Math.Cos(2.84548851892 + 7860.4193924392 * T)
        q = q + 0.00001378048 * System.Math.Cos(1.128465906 + 11790.6290886588 * T)
        q = q + 0.00000498399 * System.Math.Cos(2.58682187717 + 9683.5945811164 * T)
        q = q + 0.00000373958 * System.Math.Cos(1.42314837063 + 3930.2096962196 * T)
        q = q + 0.00000263616 * System.Math.Cos(5.5293818592 + 9437.762934887 * T)
        q = q + 0.00000237455 * System.Math.Cos(2.55135903978 + 15720.8387848784 * T)
        q = q + 0.00000221983 * System.Math.Cos(2.01346776772 + 19367.1891622328 * T)
        q = q + 0.00000125896 * System.Math.Cos(2.72769833559 + 1577.3435424478 * T)
        q = q + 0.00000119467 * System.Math.Cos(3.01975365264 + 10404.7338123226 * T)
        Return (q * 1)
    End Function
    Public Function Venus_R11(ByRef T As Double) As Double
        ' R1 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00034551039 * System.Math.Cos(0.89198710598 + 10213.285546211 * T)
        q = q + 0.00000234203 * System.Math.Cos(1.77224942714 + 20426.571092422 * T)
        q = q + 0.00000233998 * System.Math.Cos(3.14159265359 + 0 * T)
        Return (q * T)
    End Function
    Public Function Venus_R21(ByRef T As Double) As Double
        ' R2 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00001406587 * System.Math.Cos(5.0636639519 + 10213.285546211 * T)
        q = q + 0.00000015529 * System.Math.Cos(5.47321687981 + 20426.571092422 * T)
        q = q + 0.00000013059 * System.Math.Cos(0 + 0 * T)
        Return (q * T * T)
    End Function
    Public Function Venus_R31(ByRef T As Double) As Double
        ' R3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000049582 * System.Math.Cos(3.2226355452 + 10213.285546211 * T)
        Return (q * T * T * T)
    End Function
    Public Function Venus_R41(ByRef T As Double) As Double
        ' R4 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000000573 * System.Math.Cos(0.9222969782 + 10213.285546211 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Venus_R51(ByRef T As Double) As Double
        ' R5 Segment #1 of 1
        Dim q As Double = 0.0
        Return (q * T * T * T * T * T)
    End Function
End Module