Option Strict Off
Option Explicit On
Module MarsFunctions
    Public Function Mars_L01(ByRef T As Double) As Double
        ' L0 Segment #1 of 3
        Dim q As Double = 0.0
        q = q + 6.20347711583 * System.Math.Cos(0 + 0 * T)
        q = q + 0.186563681 * System.Math.Cos(5.05037100303 + 3340.6124266998 * T)
        q = q + 0.01108216792 * System.Math.Cos(5.40099836958 + 6681.2248533996 * T)
        q = q + 0.00091798394 * System.Math.Cos(5.75478745111 + 10021.8372800994 * T)
        q = q + 0.00027744987 * System.Math.Cos(5.97049512942 + 3.523118349 * T)
        q = q + 0.00012315897 * System.Math.Cos(0.84956081238 + 2810.9214616052 * T)
        q = q + 0.0001061023 * System.Math.Cos(2.93958524973 + 2281.2304965106 * T)
        q = q + 0.00008926772 * System.Math.Cos(4.15697845939 + 0.0172536522 * T)
        q = q + 0.00008715688 * System.Math.Cos(6.11005159792 + 13362.4497067992 * T)
        q = q + 0.00007774867 * System.Math.Cos(3.33968655074 + 5621.8429232104 * T)
        q = q + 0.00006797552 * System.Math.Cos(0.36462243626 + 398.1490034082 * T)
        q = q + 0.00004161101 * System.Math.Cos(0.2281497533 + 2942.4634232916 * T)
        q = q + 0.00003575079 * System.Math.Cos(1.66186540141 + 2544.3144198834 * T)
        q = q + 0.0000307525 * System.Math.Cos(0.85696597082 + 191.4482661116 * T)
        q = q + 0.00002937543 * System.Math.Cos(6.07893711408 + 0.0673103028 * T)
        q = q + 0.00002628122 * System.Math.Cos(0.6480614357 + 3337.0893083508 * T)
        q = q + 0.00002579842 * System.Math.Cos(0.02996706197 + 3344.1355450488 * T)
        q = q + 0.0000238942 * System.Math.Cos(5.03896401349 + 796.2980068164 * T)
        q = q + 0.00001798808 * System.Math.Cos(0.65634026844 + 529.6909650946 * T)
        q = q + 0.00001546408 * System.Math.Cos(2.91579633392 + 1751.539531416 * T)
        q = q + 0.0000152814 * System.Math.Cos(1.1497930622799999 + 6151.533888305 * T)
        q = q + 0.00001286232 * System.Math.Cos(3.06795924626 + 2146.1654164752 * T)
        q = q + 0.00001264356 * System.Math.Cos(3.62275092231 + 5092.1519581158 * T)
        q = q + 0.00001024907 * System.Math.Cos(3.69334293555 + 8962.4553499102 * T)
        q = q + 0.00000891567 * System.Math.Cos(0.1829389909 + 16703.062133499 * T)
        q = q + 0.0000085876 * System.Math.Cos(2.40093704204 + 2914.0142358238 * T)
        q = q + 0.00000832724 * System.Math.Cos(4.49495753458 + 3340.629680352 * T)
        q = q + 0.00000832718 * System.Math.Cos(2.46418591282 + 3340.5951730476 * T)
        q = q + 0.00000748724 * System.Math.Cos(3.82248399468 + 155.4203994342 * T)
        q = q + 0.00000723863 * System.Math.Cos(0.67497565801 + 3738.761430108 * T)
        q = q + 0.00000712899 * System.Math.Cos(3.66336014788 + 1059.3819301892 * T)
        q = q + 0.00000655163 * System.Math.Cos(0.48864075176 + 3127.3133312618 * T)
        q = q + 0.00000635557 * System.Math.Cos(2.92182704275 + 8432.7643848156 * T)
        q = q + 0.00000552746 * System.Math.Cos(4.47478863016 + 1748.016413067 * T)
        q = q + 0.00000550472 * System.Math.Cos(3.81001205408 + 0.9803210682 * T)
        q = q + 0.00000472164 * System.Math.Cos(3.6254781941 + 1194.4470102246 * T)
        q = q + 0.00000425972 * System.Math.Cos(0.55365138172 + 6283.0758499914 * T)
        q = q + 0.00000415132 * System.Math.Cos(0.49662314774 + 213.299095438 * T)
        q = q + 0.00000312141 * System.Math.Cos(0.99853322843 + 6677.7017350506 * T)
        q = q + 0.00000306552 * System.Math.Cos(0.38052862973 + 6684.7479717486 * T)
        q = q + 0.00000302377 * System.Math.Cos(4.48618150321 + 3532.0606928114 * T)
        q = q + 0.00000299396 * System.Math.Cos(2.78323705697 + 6254.6266625236 * T)
        q = q + 0.00000293199 * System.Math.Cos(4.22131277914 + 20.7753954924 * T)
        q = q + 0.000002836 * System.Math.Cos(5.76885494123 + 3149.1641605882 * T)
        q = q + 0.00000281073 * System.Math.Cos(5.88163372945 + 1349.8674096588 * T)
        q = q + 0.00000274028 * System.Math.Cos(0.54222141841 + 3340.545116397 * T)
        q = q + 0.00000274035 * System.Math.Cos(0.13372501211 + 3340.6797370026 * T)
        q = q + 0.00000238857 * System.Math.Cos(5.37155471672 + 4136.9104335162 * T)
        q = q + 0.00000236114 * System.Math.Cos(5.75504515576 + 3333.498879699 * T)
        q = q + 0.00000231185 * System.Math.Cos(1.28240685294 + 3870.3033917944 * T)
        q = q + 0.00000221225 * System.Math.Cos(3.50466672203 + 382.8965322232 * T)
        q = q + 0.00000204161 * System.Math.Cos(2.82133266185 + 1221.8485663214 * T)
        q = q + 0.00000193126 * System.Math.Cos(3.35715137745 + 3.5904286518 * T)
        q = q + 0.00000188639 * System.Math.Cos(1.49103016486 + 9492.1463150048 * T)
        q = q + 0.00000179196 * System.Math.Cos(1.00561112574 + 951.7184062506 * T)
        q = q + 0.00000174068 * System.Math.Cos(2.41360332576 + 553.5694028424 * T)
        q = q + 0.0000017211 * System.Math.Cos(0.43943041719 + 5486.777843175 * T)
        q = q + 0.00000160011 * System.Math.Cos(3.94854735192 + 4562.4609930212 * T)
        q = q + 0.00000144305 * System.Math.Cos(1.41874193418 + 135.0650800354 * T)
        q = q + 0.00000139897 * System.Math.Cos(3.32592516164 + 2700.7151403858 * T)
        q = q + 0.00000138245 * System.Math.Cos(4.30145176915 + 7.1135470008 * T)
        q = q + 0.00000130993 * System.Math.Cos(4.04491720264 + 12303.06777661 * T)
        q = q + 0.00000128102 * System.Math.Cos(2.20806651008 + 1592.5960136328 * T)
        q = q + 0.00000128062 * System.Math.Cos(1.80665643332 + 5088.6288397668 * T)
        q = q + 0.00000116945 * System.Math.Cos(3.12805282207 + 7903.073419721 * T)
        q = q + 0.00000113486 * System.Math.Cos(3.70070798123 + 1589.0728952838 * T)
        q = q + 0.00000110375 * System.Math.Cos(1.05195079687 + 242.728603974 * T)
        q = q + 0.00000104541 * System.Math.Cos(0.78535382076 + 8827.3902698748 * T)
        q = q + 0.0000010009 * System.Math.Cos(3.24343740861 + 11773.3768115154 * T)
        Return (q * 1)
    End Function
    Public Function Mars_L02(ByRef T As Double) As Double
        ' L0 Segment #2 of 3
        Dim q As Double = 0.0
        Return (q * 1)
    End Function
    Public Function Mars_L03(ByRef T As Double) As Double
        ' L0 Segment #3 of 3
        Dim q As Double = 0.0
        Return (q * 1)
    End Function
    Public Function Mars_L11(ByRef T As Double) As Double
        ' L1 Segment #1 of 2
        Dim q As Double = 0.0
        q = q + 3340.85627474342 * System.Math.Cos(0 + 0 * T)
        q = q + 0.01458227051 * System.Math.Cos(3.60426053609 + 3340.6124266998 * T)
        q = q + 0.00164901343 * System.Math.Cos(3.92631250962 + 6681.2248533996 * T)
        q = q + 0.00019963338 * System.Math.Cos(4.2659406103 + 10021.8372800994 * T)
        q = q + 0.00003452399 * System.Math.Cos(4.73210386365 + 3.523118349 * T)
        q = q + 0.0000248548 * System.Math.Cos(4.61277567318 + 13362.4497067992 * T)
        q = q + 0.00000841551 * System.Math.Cos(4.45858256765 + 2281.2304965106 * T)
        q = q + 0.00000537566 * System.Math.Cos(5.01589727492 + 398.1490034082 * T)
        q = q + 0.00000521041 * System.Math.Cos(4.99422678175 + 3344.1355450488 * T)
        q = q + 0.00000432614 * System.Math.Cos(2.5606640286 + 191.4482661116 * T)
        q = q + 0.00000429656 * System.Math.Cos(5.31646162367 + 155.4203994342 * T)
        q = q + 0.00000381747 * System.Math.Cos(3.53881289437 + 796.2980068164 * T)
        q = q + 0.00000314129 * System.Math.Cos(4.96335266049 + 16703.062133499 * T)
        q = q + 0.00000282804 * System.Math.Cos(3.15967518204 + 2544.3144198834 * T)
        q = q + 0.00000205664 * System.Math.Cos(4.5689145566 + 2146.1654164752 * T)
        q = q + 0.00000168805 * System.Math.Cos(1.32894813366 + 3337.0893083508 * T)
        q = q + 0.00000157587 * System.Math.Cos(4.18501035954 + 1751.539531416 * T)
        q = q + 0.00000133686 * System.Math.Cos(2.23325104196 + 0.9803210682 * T)
        q = q + 0.00000133563 * System.Math.Cos(5.97421903927 + 1748.016413067 * T)
        q = q + 0.00000117591 * System.Math.Cos(6.02407213861 + 6151.533888305 * T)
        q = q + 0.00000116561 * System.Math.Cos(2.21347652545 + 1059.3819301892 * T)
        q = q + 0.00000113876 * System.Math.Cos(2.12869455089 + 1194.4470102246 * T)
        q = q + 0.00000113595 * System.Math.Cos(5.42803224317 + 3738.761430108 * T)
        q = q + 0.00000091098 * System.Math.Cos(1.09627836591 + 1349.8674096588 * T)
        q = q + 0.00000085342 * System.Math.Cos(3.90854841008 + 553.5694028424 * T)
        q = q + 0.00000083301 * System.Math.Cos(5.29636626272 + 6684.7479717486 * T)
        q = q + 0.00000080776 * System.Math.Cos(4.42813405865 + 529.6909650946 * T)
        q = q + 0.00000079531 * System.Math.Cos(2.2486426633 + 8962.4553499102 * T)
        q = q + 0.00000072946 * System.Math.Cos(2.50189460554 + 951.7184062506 * T)
        q = q + 0.00000072505 * System.Math.Cos(5.8420816324 + 242.728603974 * T)
        q = q + 0.00000071487 * System.Math.Cos(3.85636094435 + 2914.0142358238 * T)
        q = q + 0.00000067582 * System.Math.Cos(5.02327686473 + 382.8965322232 * T)
        q = q + 0.00000065089 * System.Math.Cos(1.01802439311 + 3340.5951730476 * T)
        q = q + 0.00000065089 * System.Math.Cos(3.04879603978 + 3340.629680352 * T)
        q = q + 0.00000061508 * System.Math.Cos(4.151831598 + 3149.1641605882 * T)
        q = q + 0.0000005652 * System.Math.Cos(3.8881369932 + 4136.9104335162 * T)
        q = q + 0.00000048477 * System.Math.Cos(4.87362121538 + 213.299095438 * T)
        q = q + 0.00000047613 * System.Math.Cos(1.18238046057 + 3333.498879699 * T)
        q = q + 0.00000046584 * System.Math.Cos(1.31452419914 + 3185.1920272656 * T)
        q = q + 0.00000041343 * System.Math.Cos(0.71385375517 + 1592.5960136328 * T)
        q = q + 0.00000040272 * System.Math.Cos(2.72542480614 + 7.1135470008 * T)
        q = q + 0.00000040055 * System.Math.Cos(5.31611875491 + 20043.6745601988 * T)
        q = q + 0.00000032886 * System.Math.Cos(5.41067411968 + 6283.0758499914 * T)
        q = q + 0.00000028244 * System.Math.Cos(0.04534124888 + 9492.1463150048 * T)
        q = q + 0.00000026579 * System.Math.Cos(3.88960724782 + 1221.8485663214 * T)
        q = q + 0.00000026554 * System.Math.Cos(5.11271747607 + 2700.7151403858 * T)
        Return (q * T)
    End Function
    Public Function Mars_L12(ByRef T As Double) As Double
        ' L1 Segment #2 of 2
        Dim q As Double = 0.0
        Return (q * T)
    End Function
    Public Function Mars_L21(ByRef T As Double) As Double
        ' L2 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00058015791 * System.Math.Cos(2.04979463279 + 3340.6124266998 * T)
        q = q + 0.00054187645 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00013908426 * System.Math.Cos(2.45742359888 + 6681.2248533996 * T)
        q = q + 0.00002465104 * System.Math.Cos(2.80000020929 + 10021.8372800994 * T)
        q = q + 0.00000398379 * System.Math.Cos(3.14118428289 + 13362.4497067992 * T)
        q = q + 0.00000222022 * System.Math.Cos(3.19436080019 + 3.523118349 * T)
        q = q + 0.00000120957 * System.Math.Cos(0.54325292454 + 155.4203994342 * T)
        q = q + 0.00000061517 * System.Math.Cos(3.48529427371 + 16703.062133499 * T)
        q = q + 0.00000053638 * System.Math.Cos(3.54191121461 + 3344.1355450488 * T)
        q = q + 0.00000034268 * System.Math.Cos(6.00188499119 + 2281.2304965106 * T)
        q = q + 0.00000031665 * System.Math.Cos(4.14015171788 + 191.4482661116 * T)
        q = q + 0.00000029839 * System.Math.Cos(1.99870679845 + 796.2980068164 * T)
        q = q + 0.00000023168 * System.Math.Cos(4.33403365928 + 242.728603974 * T)
        q = q + 0.00000021659 * System.Math.Cos(3.44532466378 + 398.1490034082 * T)
        q = q + 0.0000002037 * System.Math.Cos(5.421913754 + 553.5694028424 * T)
        q = q + 0.00000016227 * System.Math.Cos(0.65678953303 + 0.9803210682 * T)
        q = q + 0.00000016044 * System.Math.Cos(6.11000472441 + 2146.1654164752 * T)
        q = q + 0.00000015648 * System.Math.Cos(1.2208612194 + 1748.016413067 * T)
        q = q + 0.00000014927 * System.Math.Cos(6.09541783564 + 3185.1920272656 * T)
        q = q + 0.00000014416 * System.Math.Cos(4.01923812101 + 951.7184062506 * T)
        q = q + 0.00000014317 * System.Math.Cos(2.61851897591 + 1349.8674096588 * T)
        q = q + 0.00000013352 * System.Math.Cos(0.60189008414 + 1194.4470102246 * T)
        q = q + 0.00000011934 * System.Math.Cos(3.86122163021 + 6684.7479717486 * T)
        q = q + 0.0000001126 * System.Math.Cos(4.71822363671 + 2544.3144198834 * T)
        q = q + 0.00000010396 * System.Math.Cos(0.25038714677 + 382.8965322232 * T)
        q = q + 0.00000009468 * System.Math.Cos(0.68170713564 + 1059.3819301892 * T)
        q = q + 0.00000009229 * System.Math.Cos(3.83209092321 + 20043.6745601988 * T)
        q = q + 0.00000009005 * System.Math.Cos(3.88271826102 + 3738.761430108 * T)
        q = q + 0.00000007501 * System.Math.Cos(5.46498630412 + 1751.539531416 * T)
        q = q + 0.00000006859 * System.Math.Cos(2.57522504136 + 3149.1641605882 * T)
        q = q + 0.00000006681 * System.Math.Cos(2.37843690339 + 4136.9104335162 * T)
        q = q + 0.00000006497 * System.Math.Cos(5.47773072872 + 1592.5960136328 * T)
        q = q + 0.00000006311 * System.Math.Cos(2.34104793674 + 3097.88382272579 * T)
        Return (q * T * T)
    End Function
    Public Function Mars_L31(ByRef T As Double) As Double
        ' L3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00001482423 * System.Math.Cos(0.44434694876 + 3340.6124266998 * T)
        q = q + 0.00000662095 * System.Math.Cos(0.88469178686 + 6681.2248533996 * T)
        q = q + 0.00000188268 * System.Math.Cos(1.28799982497 + 10021.8372800994 * T)
        q = q + 0.00000041474 * System.Math.Cos(1.64850786997 + 13362.4497067992 * T)
        q = q + 0.00000025994 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000022661 * System.Math.Cos(2.05267665262 + 155.4203994342 * T)
        q = q + 0.00000010454 * System.Math.Cos(1.58006906385 + 3.523118349 * T)
        q = q + 0.00000008024 * System.Math.Cos(1.99858757687 + 16703.062133499 * T)
        q = q + 0.000000049 * System.Math.Cos(2.82452457966 + 242.728603974 * T)
        q = q + 0.00000003782 * System.Math.Cos(2.01914272515 + 3344.1355450488 * T)
        q = q + 0.00000003176 * System.Math.Cos(4.59144897927 + 3185.1920272656 * T)
        q = q + 0.00000003134 * System.Math.Cos(0.65044714325 + 553.5694028424 * T)
        Return (q * T * T * T)
    End Function
    Public Function Mars_L41(ByRef T As Double) As Double
        ' L4 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000113969 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000028725 * System.Math.Cos(5.63662412043 + 6681.2248533996 * T)
        q = q + 0.00000024447 * System.Math.Cos(5.13868481454 + 3340.6124266998 * T)
        q = q + 0.00000011187 * System.Math.Cos(6.03161074431 + 10021.8372800994 * T)
        q = q + 0.00000003252 * System.Math.Cos(0.13228350651 + 13362.4497067992 * T)
        q = q + 0.0000000319 * System.Math.Cos(3.56267988299 + 155.4203994342 * T)
        q = q + 0.00000000787 * System.Math.Cos(0.49340783377 + 16703.062133499 * T)
        q = q + 0.00000000776 * System.Math.Cos(1.31734531594 + 242.728603974 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Mars_L51(ByRef T As Double) As Double
        ' L5 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000000868 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.0000000071 * System.Math.Cos(4.04089996521 + 6681.2248533996 * T)
        Return (q * T * T * T * T * T)
    End Function
    ' ************************
    Public Function Mars_B01(ByRef T As Double) As Double
        ' B0 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.03197134986 * System.Math.Cos(3.76832042432 + 3340.6124266998 * T)
        q = q + 0.00298033234 * System.Math.Cos(4.10616996243 + 6681.2248533996 * T)
        q = q + 0.00289104742 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00031365538 * System.Math.Cos(4.44651052853 + 10021.8372800994 * T)
        q = q + 0.000034841 * System.Math.Cos(4.78812547889 + 13362.4497067992 * T)
        q = q + 0.00000443401 * System.Math.Cos(5.02642620491 + 3344.1355450488 * T)
        q = q + 0.00000442999 * System.Math.Cos(5.65233015876 + 3337.0893083508 * T)
        q = q + 0.00000399109 * System.Math.Cos(5.130568147 + 16703.062133499 * T)
        q = q + 0.00000292506 * System.Math.Cos(3.79290644595 + 2281.2304965106 * T)
        q = q + 0.00000181982 * System.Math.Cos(6.13648011704 + 6151.533888305 * T)
        q = q + 0.00000163159 * System.Math.Cos(4.26399626634 + 529.6909650946 * T)
        q = q + 0.00000159678 * System.Math.Cos(2.23194610246 + 1059.3819301892 * T)
        q = q + 0.00000149297 * System.Math.Cos(2.16501209917 + 5621.8429232104 * T)
        q = q + 0.00000142686 * System.Math.Cos(1.1821501611 + 3340.5951730476 * T)
        q = q + 0.00000142685 * System.Math.Cos(3.2129218082 + 3340.629680352 * T)
        q = q + 0.00000139323 * System.Math.Cos(2.41796344238 + 8962.4553499102 * T)
        Return (q * 1)
    End Function
    Public Function Mars_B11(ByRef T As Double) As Double
        ' B1 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00350068845 * System.Math.Cos(5.36847836211 + 3340.6124266998 * T)
        q = q + 0.0001411603 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00009670755 * System.Math.Cos(5.47877786506 + 6681.2248533996 * T)
        q = q + 0.00001471918 * System.Math.Cos(3.20205766795 + 10021.8372800994 * T)
        q = q + 0.00000425864 * System.Math.Cos(3.40843812875 + 13362.4497067992 * T)
        q = q + 0.00000102039 * System.Math.Cos(0.77617286189 + 3337.0893083508 * T)
        q = q + 0.00000078848 * System.Math.Cos(3.71768293865 + 16703.062133499 * T)
        q = q + 0.00000032708 * System.Math.Cos(3.45803723682 + 5621.8429232104 * T)
        q = q + 0.00000026171 * System.Math.Cos(2.48293558065 + 2281.2304965106 * T)
        Return (q * T)
    End Function
    Public Function Mars_B21(ByRef T As Double) As Double
        ' B2 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.0001672669 * System.Math.Cos(0.60221392419 + 3340.6124266998 * T)
        q = q + 0.00004986799 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000302141 * System.Math.Cos(5.55871276021 + 6681.2248533996 * T)
        q = q + 0.00000025767 * System.Math.Cos(1.89662673499 + 13362.4497067992 * T)
        q = q + 0.00000021452 * System.Math.Cos(0.91749968618 + 10021.8372800994 * T)
        q = q + 0.0000001182 * System.Math.Cos(2.242407387 + 3337.0893083508 * T)
        q = q + 0.00000007985 * System.Math.Cos(2.24892866611 + 16703.062133499 * T)
        Return (q * T * T)
    End Function
    Public Function Mars_B31(ByRef T As Double) As Double
        ' B3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000606506 * System.Math.Cos(1.98050633529 + 3340.6124266998 * T)
        q = q + 0.00000042611 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000013652 * System.Math.Cos(1.795882288 + 6681.2248533996 * T)
        q = q + 0.0000000273 * System.Math.Cos(3.45377082121 + 10021.8372800994 * T)
        Return (q * T * T * T)
    End Function
    Public Function Mars_B41(ByRef T As Double) As Double
        ' B4 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000013369 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000011334 * System.Math.Cos(3.45724352586 + 3340.6124266998 * T)
        q = q + 0.00000000744 * System.Math.Cos(0.50445805257 + 6681.2248533996 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Mars_B51(ByRef T As Double) As Double
        ' B5 Segment #1 of 1
        Dim q As Double = 0.0
        Return (q * T * T * T * T * T)
    End Function
    Public Function Mars_R01(ByRef T As Double) As Double
        ' R0 Segment #1 of 3
        Dim q As Double = 0.0
        q = q + 1.53033488276 * System.Math.Cos(0 + 0 * T)
        q = q + 0.14184953153 * System.Math.Cos(3.47971283519 + 3340.6124266998 * T)
        q = q + 0.00660776357 * System.Math.Cos(3.81783442097 + 6681.2248533996 * T)
        q = q + 0.00046179117 * System.Math.Cos(4.15595316284 + 10021.8372800994 * T)
        q = q + 0.00008109738 * System.Math.Cos(5.55958460165 + 2810.9214616052 * T)
        q = q + 0.00007485315 * System.Math.Cos(1.77238998069 + 5621.8429232104 * T)
        q = q + 0.00005523193 * System.Math.Cos(1.3643631888 + 2281.2304965106 * T)
        q = q + 0.0000382516 * System.Math.Cos(4.49407182408 + 13362.4497067992 * T)
        q = q + 0.00002484385 * System.Math.Cos(4.92545577893 + 2942.4634232916 * T)
        q = q + 0.00002306539 * System.Math.Cos(0.09081742493 + 2544.3144198834 * T)
        q = q + 0.00001999399 * System.Math.Cos(5.36059605227 + 3337.0893083508 * T)
        q = q + 0.00001960198 * System.Math.Cos(4.74249386323 + 3344.1355450488 * T)
        q = q + 0.00001167115 * System.Math.Cos(2.11261501155 + 5092.1519581158 * T)
        q = q + 0.00001102828 * System.Math.Cos(5.0090826416 + 398.1490034082 * T)
        q = q + 0.00000992252 * System.Math.Cos(5.83862401067 + 6151.533888305 * T)
        q = q + 0.00000899077 * System.Math.Cos(4.40790433994 + 529.6909650946 * T)
        q = q + 0.00000807348 * System.Math.Cos(2.10216647104 + 1059.3819301892 * T)
        q = q + 0.0000079791 * System.Math.Cos(3.44839026172 + 796.2980068164 * T)
        q = q + 0.0000074098 * System.Math.Cos(1.49906336892 + 2146.1654164752 * T)
        q = q + 0.00000725583 * System.Math.Cos(1.24516913473 + 8432.7643848156 * T)
        q = q + 0.0000069234 * System.Math.Cos(2.13378814785 + 8962.4553499102 * T)
        q = q + 0.00000633144 * System.Math.Cos(0.89353285018 + 3340.5951730476 * T)
        q = q + 0.0000063314 * System.Math.Cos(2.92430448169 + 3340.629680352 * T)
        q = q + 0.00000629976 * System.Math.Cos(1.28738135858 + 1751.539531416 * T)
        q = q + 0.00000574352 * System.Math.Cos(0.82896196337 + 2914.0142358238 * T)
        q = q + 0.00000526187 * System.Math.Cos(5.38292276228 + 3738.761430108 * T)
        q = q + 0.00000472776 * System.Math.Cos(5.19850457873 + 3127.3133312618 * T)
        q = q + 0.00000348095 * System.Math.Cos(4.83219198908 + 16703.062133499 * T)
        q = q + 0.00000283702 * System.Math.Cos(2.90692294913 + 3532.0606928114 * T)
        q = q + 0.00000279552 * System.Math.Cos(5.25749247548 + 6283.0758499914 * T)
        q = q + 0.00000275501 * System.Math.Cos(1.21767967781 + 6254.6266625236 * T)
        q = q + 0.00000275224 * System.Math.Cos(2.90818883832 + 1748.016413067 * T)
        q = q + 0.00000269891 * System.Math.Cos(3.76394728622 + 5884.9268465832 * T)
        q = q + 0.00000239133 * System.Math.Cos(2.03669896238 + 1194.4470102246 * T)
        q = q + 0.00000233827 * System.Math.Cos(5.10546492529 + 5486.777843175 * T)
        q = q + 0.00000228128 * System.Math.Cos(3.2552902062 + 6872.6731195112 * T)
        q = q + 0.0000022319 * System.Math.Cos(4.19861593779 + 3149.1641605882 * T)
        q = q + 0.00000219428 * System.Math.Cos(5.58340248784 + 191.4482661116 * T)
        q = q + 0.00000208333 * System.Math.Cos(5.25476080773 + 3340.545116397 * T)
        q = q + 0.00000208336 * System.Math.Cos(4.84626442122 + 3340.6797370026 * T)
        q = q + 0.00000186213 * System.Math.Cos(5.69871555748 + 6677.7017350506 * T)
        q = q + 0.00000182686 * System.Math.Cos(5.08062683355 + 6684.7479717486 * T)
        q = q + 0.00000178613 * System.Math.Cos(4.18423025538 + 3333.498879699 * T)
        q = q + 0.00000175995 * System.Math.Cos(5.95341786369 + 3870.3033917944 * T)
        q = q + 0.00000163534 * System.Math.Cos(3.79889068111 + 4136.9104335162 * T)
        Return (q * 1)
    End Function
    Public Function Mars_R02(ByRef T As Double) As Double
        ' R0 Segment #2 of 3
        Dim q As Double = 0.0
        Return (q * 1)
    End Function
    Public Function Mars_R03(ByRef T As Double) As Double
        ' R0 Segment #3 of 3
        Dim q As Double = 0.0
        Return (q * 1)
    End Function
    ' ************************
    Public Function Mars_R11(ByRef T As Double) As Double
        ' R1 Segment #1 of 2
        Dim q As Double = 0.0
        q = q + 0.0110743334 * System.Math.Cos(2.0325052495 + 3340.6124266998 * T)
        q = q + 0.00103175886 * System.Math.Cos(2.37071845682 + 6681.2248533996 * T)
        q = q + 0.000128772 * System.Math.Cos(0 + 0 * T)
        q = q + 0.0001081588 * System.Math.Cos(2.70888093803 + 10021.8372800994 * T)
        q = q + 0.0000119455 * System.Math.Cos(3.04702182503 + 13362.4497067992 * T)
        q = q + 0.00000438579 * System.Math.Cos(2.88835072628 + 2281.2304965106 * T)
        q = q + 0.00000395698 * System.Math.Cos(3.42324611291 + 3344.1355450488 * T)
        q = q + 0.00000182572 * System.Math.Cos(1.58428644001 + 2544.3144198834 * T)
        q = q + 0.0000013585 * System.Math.Cos(3.38507017993 + 16703.062133499 * T)
        q = q + 0.00000128362 * System.Math.Cos(6.04343360441 + 3337.0893083508 * T)
        q = q + 0.00000128204 * System.Math.Cos(0.6299122057 + 1059.3819301892 * T)
        q = q + 0.00000127068 * System.Math.Cos(1.9538977574 + 796.2980068164 * T)
        q = q + 0.00000118443 * System.Math.Cos(2.99761345074 + 2146.1654164752 * T)
        q = q + 0.00000087537 * System.Math.Cos(3.42052758979 + 398.1490034082 * T)
        q = q + 0.00000083026 * System.Math.Cos(3.85574986653 + 3738.761430108 * T)
        q = q + 0.00000075598 * System.Math.Cos(4.45101839349 + 6151.533888305 * T)
        q = q + 0.00000071999 * System.Math.Cos(2.7644218068 + 529.6909650946 * T)
        q = q + 0.00000066542 * System.Math.Cos(2.54892602695 + 1751.539531416 * T)
        q = q + 0.0000006643 * System.Math.Cos(4.40597549957 + 1748.016413067 * T)
        q = q + 0.00000057518 * System.Math.Cos(0.54354327916 + 1194.4470102246 * T)
        q = q + 0.00000054314 * System.Math.Cos(0.67750943459 + 8962.4553499102 * T)
        q = q + 0.00000051035 * System.Math.Cos(3.72585409207 + 6684.7479717486 * T)
        q = q + 0.00000049428 * System.Math.Cos(5.72959428364 + 3340.5951730476 * T)
        q = q + 0.00000049424 * System.Math.Cos(1.47717922226 + 3340.629680352 * T)
        q = q + 0.00000048318 * System.Math.Cos(2.58061691301 + 3149.1641605882 * T)
        q = q + 0.00000047863 * System.Math.Cos(2.28527896843 + 2914.0142358238 * T)
        q = q + 0.00000038953 * System.Math.Cos(2.31900090554 + 4136.9104335162 * T)
        Return (q * T)
    End Function
    Public Function Mars_R12(ByRef T As Double) As Double
        ' R1 Segment #2 of 2
        Dim q As Double = 0.0
        Return (q * T)
    End Function
    Public Function Mars_R21(ByRef T As Double) As Double
        ' R2 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00044242247 * System.Math.Cos(0.47930603943 + 3340.6124266998 * T)
        q = q + 0.00008138042 * System.Math.Cos(0.86998398093 + 6681.2248533996 * T)
        q = q + 0.00001274915 * System.Math.Cos(1.22594050809 + 10021.8372800994 * T)
        q = q + 0.00000187387 * System.Math.Cos(1.57298991982 + 13362.4497067992 * T)
        q = q + 0.00000052396 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000040744 * System.Math.Cos(1.9708017506 + 3344.1355450488 * T)
        q = q + 0.00000026616 * System.Math.Cos(1.91665615762 + 16703.062133499 * T)
        q = q + 0.00000017825 * System.Math.Cos(4.43499505333 + 2281.2304965106 * T)
        q = q + 0.00000011713 * System.Math.Cos(4.5251045373 + 3185.1920272656 * T)
        q = q + 0.00000010209 * System.Math.Cos(5.39143469548 + 1059.3819301892 * T)
        q = q + 0.0000000995 * System.Math.Cos(0.41870577185 + 796.2980068164 * T)
        Return (q * T * T)
    End Function
    Public Function Mars_R31(ByRef T As Double) As Double
        ' R3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00001113107 * System.Math.Cos(5.14987350142 + 3340.6124266998 * T)
        q = q + 0.00000424446 * System.Math.Cos(5.61343766478 + 6681.2248533996 * T)
        q = q + 0.00000100044 * System.Math.Cos(5.99726827028 + 10021.8372800994 * T)
        q = q + 0.00000019606 * System.Math.Cos(0.07633062094 + 13362.4497067992 * T)
        q = q + 0.00000004693 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000003477 * System.Math.Cos(0.42951907576 + 16703.062133499 * T)
        Return (q * T * T * T)
    End Function
    Public Function Mars_R41(ByRef T As Double) As Double
        ' R4 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00000019552 * System.Math.Cos(3.58211650473 + 3340.6124266998 * T)
        q = q + 0.00000016323 * System.Math.Cos(4.05116076923 + 6681.2248533996 * T)
        q = q + 0.00000005848 * System.Math.Cos(4.46383962094 + 10021.8372800994 * T)
        q = q + 0.00000001532 * System.Math.Cos(4.84374321619 + 13362.4497067992 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Mars_R51(ByRef T As Double) As Double
        ' R5 Segment #1 of 1
        Dim q As Double = 0.0
        Return (q * T * T * T * T * T)
    End Function
End Module