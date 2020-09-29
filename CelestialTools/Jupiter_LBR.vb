Option Strict Off
Option Explicit On
Module JupiterFunctions
    Public Function Jupiter_L01(ByRef T As Double) As Double
        ' L0 Segment #1 of 2
        Dim q As Double = 0.0
        q = q + 0.59954691495 * System.Math.Cos(0 + 0 * T)
        q = q + 0.09695898711 * System.Math.Cos(5.06191793105 + 529.6909650946 * T)
        q = q + 0.00573610145 * System.Math.Cos(1.44406205976 + 7.1135470008 * T)
        q = q + 0.0030638918 * System.Math.Cos(5.41734729976 + 1059.3819301892 * T)
        q = q + 0.0009717828 * System.Math.Cos(4.14264708819 + 632.7837393132 * T)
        q = q + 0.00072903096 * System.Math.Cos(3.64042909255 + 522.5774180938 * T)
        q = q + 0.00064263986 * System.Math.Cos(3.41145185203 + 103.0927742186 * T)
        q = q + 0.00039806051 * System.Math.Cos(2.29376744855 + 419.4846438752 * T)
        q = q + 0.0003885778 * System.Math.Cos(1.2723172486 + 316.3918696566 * T)
        q = q + 0.00027964622 * System.Math.Cos(1.78454589485 + 536.8045120954 * T)
        q = q + 0.00013589738 * System.Math.Cos(5.7748103159 + 1589.0728952838 * T)
        q = q + 0.00008768686 * System.Math.Cos(3.63000324417 + 949.1756089698 * T)
        q = q + 0.00008246362 * System.Math.Cos(3.58227961655 + 206.1855484372 * T)
        q = q + 0.00007368057 * System.Math.Cos(5.08101125612 + 735.8765135318 * T)
        q = q + 0.00006263171 * System.Math.Cos(0.02497643742 + 213.299095438 * T)
        q = q + 0.0000611405 * System.Math.Cos(4.51319531666 + 1162.4747044078 * T)
        q = q + 0.00005305457 * System.Math.Cos(4.18625053495 + 1052.2683831884 * T)
        q = q + 0.00005305283 * System.Math.Cos(1.30671236848 + 14.2270940016 * T)
        q = q + 0.00004905419 * System.Math.Cos(1.32084631684 + 110.2063212194 * T)
        q = q + 0.00004647249 * System.Math.Cos(4.69958109497 + 3.9321532631 * T)
        q = q + 0.00003045009 * System.Math.Cos(4.31675960318 + 426.598190876 * T)
        q = q + 0.00002610001 * System.Math.Cos(1.5666759485 + 846.0828347512 * T)
        q = q + 0.00002028191 * System.Math.Cos(1.06376547379 + 3.1813937377 * T)
        q = q + 0.00001920959 * System.Math.Cos(0.97168928755 + 639.897286314 * T)
        q = q + 0.00001764768 * System.Math.Cos(2.14148077766 + 1066.49547719 * T)
        q = q + 0.00001722983 * System.Math.Cos(3.88036008872 + 1265.5674786264 * T)
        q = q + 0.00001633217 * System.Math.Cos(3.58201089758 + 515.463871093 * T)
        q = q + 0.00001431997 * System.Math.Cos(4.29683690269 + 625.6701923124 * T)
        q = q + 0.00000973278 * System.Math.Cos(4.09764957065 + 95.9792272178 * T)
        q = q + 0.00000884439 * System.Math.Cos(2.43701426123 + 412.3710968744 * T)
        q = q + 0.00000732875 * System.Math.Cos(6.08534113239 + 838.9692877504 * T)
        q = q + 0.00000731072 * System.Math.Cos(3.80591233956 + 1581.959348283 * T)
        q = q + 0.0000070919 * System.Math.Cos(1.29272573658 + 742.9900605326 * T)
        q = q + 0.00000691928 * System.Math.Cos(6.13368222939 + 2118.7638603784 * T)
        q = q + 0.00000614464 * System.Math.Cos(4.10853496756 + 1478.8665740644 * T)
        q = q + 0.00000581902 * System.Math.Cos(4.53967717552 + 309.2783226558 * T)
        q = q + 0.00000495224 * System.Math.Cos(3.75567461379 + 323.5054166574 * T)
        q = q + 0.00000440854 * System.Math.Cos(2.95818460943 + 454.9093665273 * T)
        q = q + 0.00000417266 * System.Math.Cos(1.03554430161 + 2.4476805548 * T)
        q = q + 0.00000389864 * System.Math.Cos(4.89716105852 + 1692.1656695024 * T)
        q = q + 0.00000375657 * System.Math.Cos(4.70299124833 + 1368.660252845 * T)
        q = q + 0.00000341006 * System.Math.Cos(5.71452525783 + 533.6231183577 * T)
        q = q + 0.00000330458 * System.Math.Cos(4.74049819491 + 0.0481841098 * T)
        q = q + 0.0000026154 * System.Math.Cos(1.87652461032 + 0.9632078465 * T)
        q = q + 0.00000261009 * System.Math.Cos(0.82047246448 + 380.12776796 * T)
        q = q + 0.00000256568 * System.Math.Cos(3.72410724159 + 199.0720014364 * T)
        q = q + 0.0000024417 * System.Math.Cos(5.220208789 + 728.762966531 * T)
        q = q + 0.00000235141 * System.Math.Cos(1.22693908124 + 909.8187330546 * T)
        q = q + 0.00000220382 * System.Math.Cos(1.65115015995 + 543.9180590962 * T)
        q = q + 0.00000207327 * System.Math.Cos(1.85461666594 + 525.7588118315 * T)
        q = q + 0.00000201996 * System.Math.Cos(1.80684574186 + 1375.7737998458 * T)
        q = q + 0.00000197046 * System.Math.Cos(5.29252149016 + 1155.361157407 * T)
        q = q + 0.00000175191 * System.Math.Cos(3.72966554761 + 942.062061969 * T)
        q = q + 0.00000175184 * System.Math.Cos(3.22634903433 + 1898.3512179396 * T)
        q = q + 0.00000174809 * System.Math.Cos(5.90973505276 + 956.2891559706 * T)
        q = q + 0.00000157909 * System.Math.Cos(4.36483921766 + 1795.258443721 * T)
        q = q + 0.00000150502 * System.Math.Cos(3.90625022622 + 74.7815985673 * T)
        q = q + 0.00000149368 * System.Math.Cos(4.37745104275 + 1685.0521225016 * T)
        q = q + 0.00000141445 * System.Math.Cos(3.13568357861 + 491.5579294568 * T)
        q = q + 0.00000137871 * System.Math.Cos(1.31797920785 + 1169.5882514086 * T)
        q = q + 0.00000130531 * System.Math.Cos(4.16867945489 + 1045.1548361876 * T)
        q = q + 0.00000117495 * System.Math.Cos(2.5002214089 + 1596.1864422846 * T)
        q = q + 0.00000116757 * System.Math.Cos(3.38920921041 + 0.5212648618 * T)
        q = q + 0.00000105895 * System.Math.Cos(4.55439798236 + 526.5095713569 * T)
        Return (q * 1)
    End Function
    Public Function Jupiter_L02(ByRef T As Double) As Double
        ' L0 Segment #2 of 2
        Dim q As Double = 0.0
        'q = 0#
        Return (q * 1)
    End Function
    Public Function Jupiter_L11(ByRef T As Double) As Double
        ' L1 Segment #1 of 1
        Dim q As Double = 0.0
        '  q = 0#
        q = q + 529.93480757497 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00489741194 * System.Math.Cos(4.22066689928 + 529.6909650946 * T)
        q = q + 0.00228918538 * System.Math.Cos(6.02647464016 + 7.1135470008 * T)
        q = q + 0.0002765538 * System.Math.Cos(4.57265956824 + 1059.3819301892 * T)
        q = q + 0.00020720943 * System.Math.Cos(5.45938936295 + 522.5774180938 * T)
        q = q + 0.00012105732 * System.Math.Cos(0.16985765041 + 536.8045120954 * T)
        q = q + 0.00006068051 * System.Math.Cos(4.42419502005 + 103.0927742186 * T)
        q = q + 0.00005433924 * System.Math.Cos(3.98478382565 + 419.4846438752 * T)
        q = q + 0.00004237795 * System.Math.Cos(5.89009351271 + 14.2270940016 * T)
        q = q + 0.00002211854 * System.Math.Cos(5.26771446618 + 206.1855484372 * T)
        q = q + 0.00001745919 * System.Math.Cos(4.92669378486 + 1589.0728952838 * T)
        q = q + 0.00001295769 * System.Math.Cos(5.55132765087 + 3.1813937377 * T)
        q = q + 0.00001173129 * System.Math.Cos(5.8564730435 + 1052.2683831884 * T)
        q = q + 0.00001163411 * System.Math.Cos(0.51450895328 + 3.9321532631 * T)
        q = q + 0.00001098735 * System.Math.Cos(5.30704981594 + 515.463871093 * T)
        q = q + 0.00001007216 * System.Math.Cos(0.46478398551 + 735.8765135318 * T)
        q = q + 0.00001003574 * System.Math.Cos(3.15040301822 + 426.598190876 * T)
        q = q + 0.00000847678 * System.Math.Cos(5.7580585045 + 110.2063212194 * T)
        q = q + 0.00000827329 * System.Math.Cos(4.80312015734 + 213.299095438 * T)
        q = q + 0.00000816397 * System.Math.Cos(0.58643054886 + 1066.49547719 * T)
        q = q + 0.00000725447 * System.Math.Cos(5.51827471473 + 639.897286314 * T)
        q = q + 0.00000567845 * System.Math.Cos(5.98867049451 + 625.6701923124 * T)
        q = q + 0.00000474181 * System.Math.Cos(4.13245269168 + 412.3710968744 * T)
        q = q + 0.0000041293 * System.Math.Cos(5.73652891261 + 95.9792272178 * T)
        q = q + 0.00000345249 * System.Math.Cos(4.2415956541 + 632.7837393132 * T)
        q = q + 0.00000335817 * System.Math.Cos(3.73248749046 + 1162.4747044078 * T)
        q = q + 0.0000023434 * System.Math.Cos(4.03469970332 + 949.1756089698 * T)
        q = q + 0.00000234066 * System.Math.Cos(6.24302226646 + 309.2783226558 * T)
        q = q + 0.00000198525 * System.Math.Cos(1.50458442825 + 838.9692877504 * T)
        q = q + 0.00000194784 * System.Math.Cos(2.21879010911 + 323.5054166574 * T)
        q = q + 0.00000186899 * System.Math.Cos(6.08620565908 + 742.9900605326 * T)
        q = q + 0.00000183938 * System.Math.Cos(6.27963588822 + 543.9180590962 * T)
        q = q + 0.0000017138 * System.Math.Cos(5.41655983845 + 199.0720014364 * T)
        q = q + 0.00000130771 * System.Math.Cos(0.62643377351 + 728.762966531 * T)
        q = q + 0.00000115393 * System.Math.Cos(0.68019050174 + 846.0828347512 * T)
        q = q + 0.00000115047 * System.Math.Cos(5.28641699144 + 2118.7638603784 * T)
        q = q + 0.00000107575 * System.Math.Cos(4.49282760117 + 956.2891559706 * T)
        q = q + 0.00000079686 * System.Math.Cos(5.82412400273 + 1045.1548361876 * T)
        q = q + 0.00000071643 * System.Math.Cos(5.34162650321 + 942.062061969 * T)
        q = q + 0.00000069618 * System.Math.Cos(5.97263450278 + 532.8723588323 * T)
        q = q + 0.00000066824 * System.Math.Cos(5.73365126533 + 21.3406410024 * T)
        q = q + 0.00000065635 * System.Math.Cos(0.1292419143 + 526.5095713569 * T)
        q = q + 0.0000006485 * System.Math.Cos(6.08803490288 + 1581.959348283 * T)
        q = q + 0.00000058509 * System.Math.Cos(0.58626971028 + 1155.361157407 * T)
        q = q + 0.00000057939 * System.Math.Cos(0.99453087342 + 1596.1864422846 * T)
        q = q + 0.00000057368 * System.Math.Cos(5.96851304799 + 1169.5882514086 * T)
        q = q + 0.000000566 * System.Math.Cos(1.41198438841 + 533.6231183577 * T)
        q = q + 0.00000054935 * System.Math.Cos(5.42806383723 + 10.2949407385 * T)
        q = q + 0.00000052309 * System.Math.Cos(5.72661448388 + 117.3198682202 * T)
        q = q + 0.00000052016 * System.Math.Cos(0.22981299129 + 1368.660252845 * T)
        q = q + 0.00000050418 * System.Math.Cos(6.08075147811 + 525.7588118315 * T)
        q = q + 0.00000047418 * System.Math.Cos(3.62611843241 + 1478.8665740644 * T)
        q = q + 0.00000046678 * System.Math.Cos(0.51144073175 + 1265.5674786264 * T)
        q = q + 0.00000039888 * System.Math.Cos(4.161580136 + 1692.1656695024 * T)
        q = q + 0.00000033558 * System.Math.Cos(0.09913904872 + 302.164775655 * T)
        q = q + 0.00000032827 * System.Math.Cos(5.03596689455 + 220.4126424388 * T)
        q = q + 0.00000032449 * System.Math.Cos(5.37492530697 + 508.3503240922 * T)
        q = q + 0.00000029483 * System.Math.Cos(5.42208897099 + 1272.6810256272 * T)
        q = q + 0.00000029379 * System.Math.Cos(3.35927241533 + 4.665866446 * T)
        q = q + 0.00000029307 * System.Math.Cos(0.75907909735 + 88.865680217 * T)
        q = q + 0.00000025195 * System.Math.Cos(1.60723063387 + 831.8557407496 * T)
        Return (q * T)
    End Function
    Public Function Jupiter_L21(ByRef T As Double) As Double
        ' L2 Segment #1 of 1
        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00047233598 * System.Math.Cos(4.32148323554 + 7.1135470008 * T)
        q = q + 0.0003896555 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00030629053 * System.Math.Cos(2.93021440216 + 529.6909650946 * T)
        q = q + 0.00003189317 * System.Math.Cos(1.05504615595 + 522.5774180938 * T)
        q = q + 0.00002729292 * System.Math.Cos(4.84545481351 + 536.8045120954 * T)
        q = q + 0.00002723358 * System.Math.Cos(3.41411526638 + 1059.3819301892 * T)
        q = q + 0.00001721069 * System.Math.Cos(4.18734385158 + 14.2270940016 * T)
        q = q + 0.00000383258 * System.Math.Cos(5.76790714387 + 419.4846438752 * T)
        q = q + 0.00000377524 * System.Math.Cos(0.76048964872 + 515.463871093 * T)
        q = q + 0.00000367498 * System.Math.Cos(6.05509120409 + 103.0927742186 * T)
        q = q + 0.00000337386 * System.Math.Cos(3.78644384244 + 3.1813937377 * T)
        q = q + 0.000003082 * System.Math.Cos(0.69356654052 + 206.1855484372 * T)
        q = q + 0.00000218408 * System.Math.Cos(3.81389191353 + 1589.0728952838 * T)
        q = q + 0.00000198883 * System.Math.Cos(5.33996443444 + 1066.49547719 * T)
        q = q + 0.00000197445 * System.Math.Cos(2.48356402053 + 3.9321532631 * T)
        q = q + 0.00000155862 * System.Math.Cos(1.40642426467 + 1052.2683831884 * T)
        q = q + 0.0000014623 * System.Math.Cos(3.81373196838 + 639.897286314 * T)
        q = q + 0.00000141932 * System.Math.Cos(1.63435169016 + 426.598190876 * T)
        q = q + 0.0000012957 * System.Math.Cos(5.83738872525 + 412.3710968744 * T)
        q = q + 0.00000117327 * System.Math.Cos(1.41435462588 + 625.6701923124 * T)
        q = q + 0.00000096733 * System.Math.Cos(4.03383427887 + 110.2063212194 * T)
        q = q + 0.00000090823 * System.Math.Cos(1.10630629042 + 95.9792272178 * T)
        q = q + 0.00000087292 * System.Math.Cos(2.52235174825 + 632.7837393132 * T)
        q = q + 0.00000078769 * System.Math.Cos(4.63726131329 + 543.9180590962 * T)
        q = q + 0.00000072392 * System.Math.Cos(2.21716670026 + 735.8765135318 * T)
        q = q + 0.00000058475 * System.Math.Cos(0.83216317444 + 199.0720014364 * T)
        q = q + 0.0000005691 * System.Math.Cos(3.12292059854 + 213.299095438 * T)
        q = q + 0.00000048622 * System.Math.Cos(1.67283791618 + 309.2783226558 * T)
        q = q + 0.0000004015 * System.Math.Cos(4.0248544474 + 21.3406410024 * T)
        q = q + 0.00000039784 * System.Math.Cos(0.62416945827 + 323.5054166574 * T)
        q = q + 0.00000035718 * System.Math.Cos(2.32581247002 + 728.762966531 * T)
        q = q + 0.00000029255 * System.Math.Cos(3.60838327799 + 10.2949407385 * T)
        q = q + 0.00000027814 * System.Math.Cos(3.23992013743 + 838.9692877504 * T)
        q = q + 0.00000025993 * System.Math.Cos(4.5011829829 + 742.9900605326 * T)
        q = q + 0.0000002562 * System.Math.Cos(2.51240623862 + 1162.4747044078 * T)
        q = q + 0.00000025194 * System.Math.Cos(1.21868110687 + 1045.1548361876 * T)
        q = q + 0.00000023591 * System.Math.Cos(3.00532139306 + 956.2891559706 * T)
        q = q + 0.00000019458 * System.Math.Cos(4.29028644674 + 532.8723588323 * T)
        q = q + 0.0000001766 * System.Math.Cos(0.8095394156 + 508.3503240922 * T)
        q = q + 0.00000017058 * System.Math.Cos(4.20001977723 + 2118.7638603784 * T)
        q = q + 0.0000001704 * System.Math.Cos(1.8340214664 + 526.5095713569 * T)
        q = q + 0.00000015355 * System.Math.Cos(5.81037986941 + 1596.1864422846 * T)
        q = q + 0.00000015292 * System.Math.Cos(0.68174165476 + 942.062061969 * T)
        q = q + 0.00000014661 * System.Math.Cos(3.99989622586 + 117.3198682202 * T)
        q = q + 0.0000001392 * System.Math.Cos(5.95169568482 + 316.3918696566 * T)
        q = q + 0.00000013639 * System.Math.Cos(1.80336677963 + 302.164775655 * T)
        q = q + 0.0000001323 * System.Math.Cos(2.51856643603 + 88.865680217 * T)
        q = q + 0.00000012756 * System.Math.Cos(4.36856232414 + 1169.5882514086 * T)
        q = q + 0.00000010986 * System.Math.Cos(4.43586634639 + 525.7588118315 * T)
        q = q + 0.00000009681 * System.Math.Cos(1.71563161051 + 1581.959348283 * T)
        q = q + 0.00000009437 * System.Math.Cos(2.17684563456 + 1155.361157407 * T)
        q = q + 0.00000008812 * System.Math.Cos(3.29452783338 + 220.4126424388 * T)
        q = q + 0.0000000869 * System.Math.Cos(3.31924493607 + 831.8557407496 * T)
        q = q + 0.00000007823 * System.Math.Cos(5.75672228354 + 846.0828347512 * T)
        q = q + 0.00000007549 * System.Math.Cos(2.70955516779 + 533.6231183577 * T)
        q = q + 0.00000006685 * System.Math.Cos(2.17560093281 + 1265.5674786264 * T)
        q = q + 0.00000006285 * System.Math.Cos(0.49939863541 + 949.1756089698 * T)
        Return (q * T * T)
    End Function
    Public Function Jupiter_L31(ByRef T As Double) As Double
        ' L3 Segment #1 of 1
        Dim q As Double = 0.0
        q = q + 0.00006501665 * System.Math.Cos(2.59862880482 + 7.1135470008 * T)
        q = q + 0.00001356524 * System.Math.Cos(1.34635886411 + 529.6909650946 * T)
        q = q + 0.00000470716 * System.Math.Cos(2.47503977883 + 14.2270940016 * T)
        q = q + 0.0000041696 * System.Math.Cos(3.24451243214 + 536.8045120954 * T)
        q = q + 0.00000352851 * System.Math.Cos(2.97360159003 + 522.5774180938 * T)
        q = q + 0.0000015488 * System.Math.Cos(2.07565585817 + 1059.3819301892 * T)
        q = q + 0.00000086771 * System.Math.Cos(2.51431584316 + 515.463871093 * T)
        q = q + 0.00000044378 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000033538 * System.Math.Cos(3.82633794497 + 1066.49547719 * T)
        q = q + 0.00000028457 * System.Math.Cos(2.44754756058 + 206.1855484372 * T)
        q = q + 0.00000023737 * System.Math.Cos(1.27667172313 + 412.3710968744 * T)
        q = q + 0.00000022644 * System.Math.Cos(2.98231326774 + 543.9180590962 * T)
        q = q + 0.00000019798 * System.Math.Cos(2.10099934005 + 639.897286314 * T)
        q = q + 0.0000001974 * System.Math.Cos(1.40255938973 + 419.4846438752 * T)
        q = q + 0.00000018768 * System.Math.Cos(1.593684035 + 103.0927742186 * T)
        q = q + 0.00000017033 * System.Math.Cos(2.30214681202 + 21.3406410024 * T)
        q = q + 0.00000016774 * System.Math.Cos(2.59821460673 + 1589.0728952838 * T)
        q = q + 0.00000016214 * System.Math.Cos(3.14521117299 + 625.6701923124 * T)
        q = q + 0.00000016055 * System.Math.Cos(3.36030126297 + 1052.2683831884 * T)
        q = q + 0.00000013392 * System.Math.Cos(2.75973892202 + 95.9792272178 * T)
        q = q + 0.00000013234 * System.Math.Cos(2.5386224434 + 199.0720014364 * T)
        q = q + 0.00000012611 * System.Math.Cos(6.265781104 + 426.598190876 * T)
        q = q + 0.00000008701 * System.Math.Cos(1.76334960737 + 10.2949407385 * T)
        q = q + 0.00000008637 * System.Math.Cos(2.26563256289 + 110.2063212194 * T)
        q = q + 0.00000006725 * System.Math.Cos(3.42566433316 + 309.2783226558 * T)
        q = q + 0.00000006527 * System.Math.Cos(4.03869562907 + 728.762966531 * T)
        q = q + 0.00000005675 * System.Math.Cos(2.52096417685 + 508.3503240922 * T)
        q = q + 0.00000005399 * System.Math.Cos(2.91184687105 + 1045.1548361876 * T)
        q = q + 0.00000005368 * System.Math.Cos(5.25196153539 + 323.5054166574 * T)
        q = q + 0.00000003996 * System.Math.Cos(4.30290261177 + 88.865680217 * T)
        q = q + 0.00000003857 * System.Math.Cos(3.52381361552 + 302.164775655 * T)
        q = q + 0.00000003774 * System.Math.Cos(4.09125315146 + 735.8765135318 * T)
        q = q + 0.00000003269 * System.Math.Cos(1.43175991274 + 956.2891559706 * T)
        q = q + 0.00000002783 * System.Math.Cos(4.3581750767 + 1596.1864422846 * T)
        q = q + 0.00000002661 * System.Math.Cos(1.25276590759 + 213.299095438 * T)
        q = q + 0.00000002656 * System.Math.Cos(5.01505839848 + 838.9692877504 * T)
        q = q + 0.00000002553 * System.Math.Cos(2.23785673285 + 117.3198682202 * T)
        q = q + 0.00000002371 * System.Math.Cos(2.89662409244 + 742.9900605326 * T)
        q = q + 0.00000002279 * System.Math.Cos(2.3558187123 + 942.062061969 * T)
        Return (q * T * T * T)
    End Function
    Public Function Jupiter_L41(ByRef T As Double) As Double
        ' L4 Segment #1 of 1
        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00000669483 * System.Math.Cos(0.8528242109 + 7.1135470008 * T)
        q = q + 0.00000114019 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000099961 * System.Math.Cos(0.74258947751 + 14.2270940016 * T)
        q = q + 0.00000050024 * System.Math.Cos(1.65346208248 + 536.8045120954 * T)
        q = q + 0.00000043585 * System.Math.Cos(5.82026386621 + 529.6909650946 * T)
        q = q + 0.00000031813 * System.Math.Cos(4.8582998665 + 522.5774180938 * T)
        q = q + 0.00000014742 * System.Math.Cos(4.29061635784 + 515.463871093 * T)
        q = q + 0.00000008899 * System.Math.Cos(0.71478520741 + 1059.3819301892 * T)
        q = q + 0.00000004957 * System.Math.Cos(1.29502259434 + 543.9180590962 * T)
        q = q + 0.00000004484 * System.Math.Cos(2.31715516627 + 1066.49547719 * T)
        q = q + 0.00000004251 * System.Math.Cos(0.48326797501 + 21.3406410024 * T)
        q = q + 0.000000031 * System.Math.Cos(3.00245542678 + 412.3710968744 * T)
        q = q + 0.00000002055 * System.Math.Cos(0.39858940218 + 639.897286314 * T)
        q = q + 0.00000001902 * System.Math.Cos(4.25925620271 + 199.0720014364 * T)
        q = q + 0.00000001762 * System.Math.Cos(4.90536207307 + 625.6701923124 * T)
        q = q + 0.00000001695 * System.Math.Cos(4.26147580803 + 206.1855484372 * T)
        q = q + 0.00000001375 * System.Math.Cos(5.25546955667 + 1052.2683831884 * T)
        q = q + 0.00000001203 * System.Math.Cos(4.71614633845 + 95.9792272178 * T)
        q = q + 0.00000001086 * System.Math.Cos(1.28604571172 + 1589.0728952838 * T)
        Return (q * T * T * T * T)
    End Function
    ' ************************
    Public Function Jupiter_L51(ByRef T As Object) As Object
        ' L5 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00000049577 * System.Math.Cos(5.25658966184 + 7.1135470008 * T)
        q = q + 0.00000015761 * System.Math.Cos(5.25126837478 + 14.2270940016 * T)
        q = q + 0.00000004343 * System.Math.Cos(0.01461869263 + 536.8045120954 * T)
        q = q + 0.00000001526 * System.Math.Cos(1.09739911439 + 522.5774180938 * T)
        q = q + 0.00000000845 * System.Math.Cos(3.14159265359 + 0 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L51. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_L51 = q * T * T * T * T * T
    End Function
    ' ************************
    Public Function Jupiter_B01(ByRef T As Object) As Object
        ' B0 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.02268615703 * System.Math.Cos(3.55852606718 + 529.6909650946 * T)
        q = q + 0.00110090358 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00109971634 * System.Math.Cos(3.90809347389 + 1059.3819301892 * T)
        q = q + 0.00008101427 * System.Math.Cos(3.60509573368 + 522.5774180938 * T)
        q = q + 0.00006437782 * System.Math.Cos(0.30627121409 + 536.8045120954 * T)
        q = q + 0.00006043996 * System.Math.Cos(4.25883108794 + 1589.0728952838 * T)
        q = q + 0.0000110688 * System.Math.Cos(2.98534421928 + 1162.4747044078 * T)
        q = q + 0.00000944328 * System.Math.Cos(1.67522288396 + 426.598190876 * T)
        q = q + 0.00000941651 * System.Math.Cos(2.93619072405 + 1052.2683831884 * T)
        q = q + 0.00000894088 * System.Math.Cos(1.75447429921 + 7.1135470008 * T)
        q = q + 0.00000835861 * System.Math.Cos(5.17881973234 + 103.0927742186 * T)
        q = q + 0.0000076728 * System.Math.Cos(2.1547359406 + 632.7837393132 * T)
        q = q + 0.0000068422 * System.Math.Cos(3.67808770098 + 213.299095438 * T)
        q = q + 0.00000629223 * System.Math.Cos(0.64343282328 + 1066.49547719 * T)
        q = q + 0.00000558524 * System.Math.Cos(0.01354830508 + 846.0828347512 * T)
        q = q + 0.0000053167 * System.Math.Cos(2.70305954352 + 110.2063212194 * T)
        q = q + 0.00000464449 * System.Math.Cos(1.17337249185 + 949.1756089698 * T)
        q = q + 0.00000431072 * System.Math.Cos(2.60825000494 + 419.4846438752 * T)
        q = q + 0.00000351433 * System.Math.Cos(4.61062990714 + 2118.7638603784 * T)
        q = q + 0.0000013216 * System.Math.Cos(4.7781699067 + 742.9900605326 * T)
        q = q + 0.00000123148 * System.Math.Cos(3.34968181384 + 1692.1656695024 * T)
        q = q + 0.00000116379 * System.Math.Cos(1.38688232033 + 323.5054166574 * T)
        q = q + 0.00000115038 * System.Math.Cos(5.04892295442 + 316.3918696566 * T)
        q = q + 0.00000103762 * System.Math.Cos(3.7010383811 + 515.463871093 * T)
        q = q + 0.00000103402 * System.Math.Cos(2.31878999565 + 1478.8665740644 * T)
        q = q + 0.0000010242 * System.Math.Cos(3.15293785436 + 1581.959348283 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B01. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_B01 = q * 1
    End Function
    ' ************************
    Public Function Jupiter_B11(ByRef T As Object) As Object
        ' B1 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00177351787 * System.Math.Cos(5.70166488486 + 529.6909650946 * T)
        q = q + 0.00003230171 * System.Math.Cos(5.7794161934 + 1059.3819301892 * T)
        q = q + 0.00003081364 * System.Math.Cos(5.47464296527 + 522.5774180938 * T)
        q = q + 0.00002211914 * System.Math.Cos(4.73477480209 + 536.8045120954 * T)
        q = q + 0.00001694232 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000346445 * System.Math.Cos(4.74595174109 + 1052.2683831884 * T)
        q = q + 0.00000234264 * System.Math.Cos(5.18856099929 + 1066.49547719 * T)
        q = q + 0.00000196154 * System.Math.Cos(6.18554286642 + 7.1135470008 * T)
        q = q + 0.00000150468 * System.Math.Cos(3.92721226087 + 1589.0728952838 * T)
        q = q + 0.00000114128 * System.Math.Cos(3.4389727183 + 632.7837393132 * T)
        q = q + 0.00000096667 * System.Math.Cos(2.9142630409 + 949.1756089698 * T)
        q = q + 0.00000081671 * System.Math.Cos(5.07666097497 + 1162.4747044078 * T)
        q = q + 0.00000076599 * System.Math.Cos(2.50522188662 + 103.0927742186 * T)
        q = q + 0.00000076572 * System.Math.Cos(0.61288981445 + 419.4846438752 * T)
        q = q + 0.00000073875 * System.Math.Cos(5.49958292155 + 515.463871093 * T)
        q = q + 0.00000060544 * System.Math.Cos(5.44740084359 + 213.299095438 * T)
        q = q + 0.00000049915 * System.Math.Cos(3.94799616572 + 735.8765135318 * T)
        q = q + 0.00000046032 * System.Math.Cos(0.53850360901 + 110.2063212194 * T)
        q = q + 0.00000045123 * System.Math.Cos(1.89516645239 + 846.0828347512 * T)
        q = q + 0.00000036561 * System.Math.Cos(4.69828392839 + 543.9180590962 * T)
        q = q + 0.00000036019 * System.Math.Cos(6.10952578764 + 316.3918696566 * T)
        q = q + 0.00000031975 * System.Math.Cos(4.92452714629 + 1581.959348283 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B11. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_B11 = q * T
    End Function
    ' ************************
    Public Function Jupiter_B21(ByRef T As Object) As Object
        ' B2 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00008094051 * System.Math.Cos(1.46322843658 + 529.6909650946 * T)
        q = q + 0.00000813244 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000742415 * System.Math.Cos(0.95691639003 + 522.5774180938 * T)
        q = q + 0.00000398951 * System.Math.Cos(2.89888666447 + 536.8045120954 * T)
        q = q + 0.00000342226 * System.Math.Cos(1.44683789727 + 1059.3819301892 * T)
        q = q + 0.00000073948 * System.Math.Cos(0.40724675866 + 1052.2683831884 * T)
        q = q + 0.00000046151 * System.Math.Cos(3.48036895772 + 1066.49547719 * T)
        q = q + 0.00000029717 * System.Math.Cos(1.92504171329 + 1589.0728952838 * T)
        q = q + 0.00000029314 * System.Math.Cos(0.99088831805 + 515.463871093 * T)
        q = q + 0.00000022753 * System.Math.Cos(4.27124052435 + 7.1135470008 * T)
        q = q + 0.00000013916 * System.Math.Cos(2.92242387338 + 543.9180590962 * T)
        q = q + 0.00000012067 * System.Math.Cos(5.22168932482 + 632.7837393132 * T)
        q = q + 0.00000010703 * System.Math.Cos(4.88024222475 + 949.1756089698 * T)
        q = q + 0.00000006078 * System.Math.Cos(6.21089108431 + 1045.1548361876 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B21. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_B21 = q * T * T
    End Function
    ' ************************
    Public Function Jupiter_B31(ByRef T As Object) As Object
        ' B3 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00000251624 * System.Math.Cos(3.38087923084 + 529.6909650946 * T)
        q = q + 0.00000121738 * System.Math.Cos(2.733118372 + 522.5774180938 * T)
        q = q + 0.00000048694 * System.Math.Cos(1.03689996685 + 536.8045120954 * T)
        q = q + 0.00000010988 * System.Math.Cos(2.31463561347 + 1052.2683831884 * T)
        q = q + 0.00000008067 * System.Math.Cos(2.76729757621 + 515.463871093 * T)
        q = q + 0.00000007287 * System.Math.Cos(4.25268318975 + 1059.3819301892 * T)
        q = q + 0.00000006205 * System.Math.Cos(1.7811582737 + 1066.49547719 * T)
        q = q + 0.00000003627 * System.Math.Cos(1.13028917221 + 543.9180590962 * T)
        q = q + 0.00000002798 * System.Math.Cos(3.14159265359 + 0 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B31. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_B31 = q * T * T * T
    End Function
    ' ************************
    Public Function Jupiter_B41(ByRef T As Object) As Object
        ' B4 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.0000001505 * System.Math.Cos(4.52956999637 + 522.5774180938 * T)
        q = q + 0.0000000537 * System.Math.Cos(4.47427159142 + 529.6909650946 * T)
        q = q + 0.00000004456 * System.Math.Cos(5.43908581047 + 536.8045120954 * T)
        q = q + 0.00000003422 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000001833 * System.Math.Cos(4.51807036227 + 515.463871093 * T)
        q = q + 0.00000001322 * System.Math.Cos(4.20117611581 + 1052.2683831884 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B41. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_B41 = q * T * T * T * T
    End Function
    ' ************************
    Public Function Jupiter_B51(ByRef T As Object) As Object
        ' B5 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00000001445 * System.Math.Cos(0.09198554072 + 522.5774180938 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B51. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_B51 = q * T * T * T * T * T
    End Function
    ' ************************
    Public Function Jupiter_R01(ByRef T As Object) As Object
        ' R0 Segment #1 of 2
        Dim q As Object
        q = 0#
        q = q + 5.20887429471 * System.Math.Cos(0 + 0 * T)
        q = q + 0.2520932702 * System.Math.Cos(3.49108640015 + 529.6909650946 * T)
        q = q + 0.00610599902 * System.Math.Cos(3.84115365602 + 1059.3819301892 * T)
        q = q + 0.00282029465 * System.Math.Cos(2.57419879933 + 632.7837393132 * T)
        q = q + 0.00187647391 * System.Math.Cos(2.07590380082 + 522.5774180938 * T)
        q = q + 0.00086792941 * System.Math.Cos(0.71001090609 + 419.4846438752 * T)
        q = q + 0.00072062869 * System.Math.Cos(0.21465694745 + 536.8045120954 * T)
        q = q + 0.00065517227 * System.Math.Cos(5.97995850843 + 316.3918696566 * T)
        q = q + 0.00030135275 * System.Math.Cos(2.16132058449 + 949.1756089698 * T)
        q = q + 0.0002913462 * System.Math.Cos(1.6775924371 + 103.0927742186 * T)
        q = q + 0.0002394734 * System.Math.Cos(0.27457854894 + 7.1135470008 * T)
        q = q + 0.00023453209 * System.Math.Cos(3.54023147303 + 735.8765135318 * T)
        q = q + 0.0002228371 * System.Math.Cos(4.19362773546 + 1589.0728952838 * T)
        q = q + 0.000130326 * System.Math.Cos(2.96043055741 + 1162.4747044078 * T)
        q = q + 0.00012749004 * System.Math.Cos(2.71550102862 + 1052.2683831884 * T)
        q = q + 0.00009703346 * System.Math.Cos(1.90669572402 + 206.1855484372 * T)
        q = q + 0.00009161431 * System.Math.Cos(4.41352618935 + 213.299095438 * T)
        q = q + 0.00007894539 * System.Math.Cos(2.47907551404 + 426.598190876 * T)
        q = q + 0.00007057978 * System.Math.Cos(2.18184753111 + 1265.5674786264 * T)
        q = q + 0.00006137755 * System.Math.Cos(6.26417542514 + 846.0828347512 * T)
        q = q + 0.00005477093 * System.Math.Cos(5.65729325169 + 639.897286314 * T)
        q = q + 0.00004170012 * System.Math.Cos(2.01605033912 + 515.463871093 * T)
        q = q + 0.0000413689 * System.Math.Cos(2.72219979684 + 625.6701923124 * T)
        q = q + 0.00003502519 * System.Math.Cos(0.56531297394 + 1066.49547719 * T)
        q = q + 0.00002616955 * System.Math.Cos(2.00993967129 + 1581.959348283 * T)
        q = q + 0.00002499966 * System.Math.Cos(4.55182055941 + 838.9692877504 * T)
        q = q + 0.00002127644 * System.Math.Cos(6.1275146175 + 742.9900605326 * T)
        q = q + 0.00001911876 * System.Math.Cos(0.85621927419 + 412.3710968744 * T)
        q = q + 0.00001610549 * System.Math.Cos(3.08867789275 + 1368.660252845 * T)
        q = q + 0.00001479484 * System.Math.Cos(2.68026191372 + 1478.8665740644 * T)
        q = q + 0.00001230708 * System.Math.Cos(1.89042979701 + 323.5054166574 * T)
        q = q + 0.0000121681 * System.Math.Cos(1.80171561024 + 110.2063212194 * T)
        q = q + 0.00001014959 * System.Math.Cos(1.38673237666 + 454.9093665273 * T)
        q = q + 0.00000998579 * System.Math.Cos(2.8720894011 + 309.2783226558 * T)
        q = q + 0.00000961072 * System.Math.Cos(4.54876989805 + 2118.7638603784 * T)
        q = q + 0.00000885708 * System.Math.Cos(4.14785948471 + 533.6231183577 * T)
        q = q + 0.00000821465 * System.Math.Cos(1.59342534396 + 1898.3512179396 * T)
        q = q + 0.00000812036 * System.Math.Cos(5.94091899141 + 909.8187330546 * T)
        q = q + 0.000007767 * System.Math.Cos(3.6769695469 + 728.762966531 * T)
        q = q + 0.00000727162 * System.Math.Cos(3.98824686402 + 1155.361157407 * T)
        q = q + 0.00000655289 * System.Math.Cos(2.79065604219 + 1685.0521225016 * T)
        q = q + 0.00000653981 * System.Math.Cos(3.38150775269 + 1692.1656695024 * T)
        q = q + 0.00000620798 * System.Math.Cos(4.82284338962 + 956.2891559706 * T)
        q = q + 0.00000614784 * System.Math.Cos(2.27624915604 + 942.062061969 * T)
        q = q + 0.0000056212 * System.Math.Cos(0.08095987241 + 543.9180590962 * T)
        q = q + 0.00000542221 * System.Math.Cos(0.28360266386 + 525.7588118315 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R01. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R01 = q * 1
    End Function
    ' ************************
    Public Function Jupiter_R02(ByRef T As Object) As Object
        ' R0 Segment #2 of 2
        Dim q As Object
        q = 0#
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R02. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R02 = q * 1
    End Function
    ' ************************
    Public Function Jupiter_R11(ByRef T As Object) As Object
        ' R1 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.01271801596 * System.Math.Cos(2.64937511122 + 529.6909650946 * T)
        q = q + 0.00061661771 * System.Math.Cos(3.00076251018 + 1059.3819301892 * T)
        q = q + 0.00053443592 * System.Math.Cos(3.89717644226 + 522.5774180938 * T)
        q = q + 0.00041390257 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00031185167 * System.Math.Cos(4.88276663526 + 536.8045120954 * T)
        q = q + 0.0001184719 * System.Math.Cos(2.41329588176 + 419.4846438752 * T)
        q = q + 0.0000916636 * System.Math.Cos(4.75979408587 + 7.1135470008 * T)
        q = q + 0.00003403605 * System.Math.Cos(3.34688537997 + 1589.0728952838 * T)
        q = q + 0.00003203446 * System.Math.Cos(5.21083285476 + 735.8765135318 * T)
        q = q + 0.00003175763 * System.Math.Cos(2.79297987071 + 103.0927742186 * T)
        q = q + 0.00002806064 * System.Math.Cos(3.7422369358 + 515.463871093 * T)
        q = q + 0.00002676575 * System.Math.Cos(4.33052878699 + 1052.2683831884 * T)
        q = q + 0.00002600003 * System.Math.Cos(3.63435101622 + 206.1855484372 * T)
        q = q + 0.00002412207 * System.Math.Cos(1.46947308304 + 426.598190876 * T)
        q = q + 0.00002100507 * System.Math.Cos(3.92762682306 + 639.897286314 * T)
        q = q + 0.00001646182 * System.Math.Cos(5.30953510947 + 1066.49547719 * T)
        q = q + 0.00001641257 * System.Math.Cos(4.41628669824 + 625.6701923124 * T)
        q = q + 0.00001049866 * System.Math.Cos(3.16113622955 + 213.299095438 * T)
        q = q + 0.00001024802 * System.Math.Cos(2.55432643018 + 412.3710968744 * T)
        q = q + 0.00000806404 * System.Math.Cos(2.6775080138 + 632.7837393132 * T)
        q = q + 0.00000740996 * System.Math.Cos(2.17094630558 + 1162.4747044078 * T)
        q = q + 0.00000676928 * System.Math.Cos(6.2495347979 + 838.9692877504 * T)
        q = q + 0.00000567076 * System.Math.Cos(4.57655414712 + 742.9900605326 * T)
        q = q + 0.00000484689 * System.Math.Cos(2.46882793186 + 949.1756089698 * T)
        q = q + 0.00000468895 * System.Math.Cos(4.70973463481 + 543.9180590962 * T)
        q = q + 0.00000444683 * System.Math.Cos(0.40281181402 + 323.5054166574 * T)
        q = q + 0.00000415894 * System.Math.Cos(5.36836018215 + 728.762966531 * T)
        q = q + 0.00000401738 * System.Math.Cos(4.60528841541 + 309.2783226558 * T)
        q = q + 0.00000347378 * System.Math.Cos(4.68148808722 + 14.2270940016 * T)
        q = q + 0.00000337555 * System.Math.Cos(3.1678195112 + 956.2891559706 * T)
        q = q + 0.00000260753 * System.Math.Cos(5.34290306101 + 846.0828347512 * T)
        q = q + 0.00000246603 * System.Math.Cos(3.92313823537 + 942.062061969 * T)
        q = q + 0.00000220084 * System.Math.Cos(4.84210964963 + 1368.660252845 * T)
        q = q + 0.00000203217 * System.Math.Cos(5.59995425432 + 1155.361157407 * T)
        q = q + 0.0000020019 * System.Math.Cos(4.43888814441 + 1045.1548361876 * T)
        q = q + 0.00000197134 * System.Math.Cos(3.70551461394 + 2118.7638603784 * T)
        q = q + 0.00000196005 * System.Math.Cos(3.75877587139 + 199.0720014364 * T)
        q = q + 0.00000183504 * System.Math.Cos(4.26526769703 + 95.9792272178 * T)
        q = q + 0.00000180134 * System.Math.Cos(4.40165491159 + 532.8723588323 * T)
        q = q + 0.00000170225 * System.Math.Cos(4.84647488867 + 526.5095713569 * T)
        q = q + 0.00000146335 * System.Math.Cos(6.12958365535 + 533.6231183577 * T)
        q = q + 0.00000133483 * System.Math.Cos(1.32245735855 + 110.2063212194 * T)
        q = q + 0.00000132076 * System.Math.Cos(4.51187950811 + 525.7588118315 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R11. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R11 = q * T
    End Function
    ' ************************
    Public Function Jupiter_R21(ByRef T As Object) As Object
        ' R2 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00079644833 * System.Math.Cos(1.35865896596 + 529.6909650946 * T)
        q = q + 0.00008251618 * System.Math.Cos(5.77773935444 + 522.5774180938 * T)
        q = q + 0.00007029864 * System.Math.Cos(3.27476965833 + 536.8045120954 * T)
        q = q + 0.00005314006 * System.Math.Cos(1.83835109712 + 1059.3819301892 * T)
        q = q + 0.00001860833 * System.Math.Cos(2.97682139367 + 7.1135470008 * T)
        q = q + 0.00000964466 * System.Math.Cos(5.48031822015 + 515.463871093 * T)
        q = q + 0.00000836267 * System.Math.Cos(4.19889881718 + 419.4846438752 * T)
        q = q + 0.0000049792 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.0000042657 * System.Math.Cos(2.22753101795 + 639.897286314 * T)
        q = q + 0.00000406453 * System.Math.Cos(3.78250730354 + 1066.49547719 * T)
        q = q + 0.00000377316 * System.Math.Cos(2.24248352873 + 1589.0728952838 * T)
        q = q + 0.00000362943 * System.Math.Cos(5.36761847267 + 206.1855484372 * T)
        q = q + 0.00000342048 * System.Math.Cos(6.09922969324 + 1052.2683831884 * T)
        q = q + 0.00000339043 * System.Math.Cos(6.12690864038 + 625.6701923124 * T)
        q = q + 0.00000332578 * System.Math.Cos(0.00328961161 + 426.598190876 * T)
        q = q + 0.0000027992 * System.Math.Cos(4.26162555827 + 412.3710968744 * T)
        q = q + 0.0000025729 * System.Math.Cos(0.96295364983 + 632.7837393132 * T)
        q = q + 0.00000229777 * System.Math.Cos(0.70530766213 + 735.8765135318 * T)
        q = q + 0.00000200783 * System.Math.Cos(3.06850623368 + 543.9180590962 * T)
        q = q + 0.00000199807 * System.Math.Cos(4.42884165317 + 103.0927742186 * T)
        q = q + 0.00000138606 * System.Math.Cos(2.93235671606 + 14.2270940016 * T)
        q = q + 0.00000113535 * System.Math.Cos(0.78713911289 + 728.762966531 * T)
        q = q + 0.00000094565 * System.Math.Cos(1.70498041073 + 838.9692877504 * T)
        q = q + 0.00000086025 * System.Math.Cos(5.14434751994 + 323.5054166574 * T)
        q = q + 0.00000083469 * System.Math.Cos(0.05834873484 + 309.2783226558 * T)
        q = q + 0.00000080328 * System.Math.Cos(2.98122361797 + 742.9900605326 * T)
        q = q + 0.00000075198 * System.Math.Cos(1.60495195911 + 956.2891559706 * T)
        q = q + 0.00000070451 * System.Math.Cos(1.50988357484 + 213.299095438 * T)
        q = q + 0.00000066572 * System.Math.Cos(5.47307178077 + 199.0720014364 * T)
        q = q + 0.00000061649 * System.Math.Cos(6.10137889854 + 1045.1548361876 * T)
        q = q + 0.00000056203 * System.Math.Cos(0.95534810533 + 1162.4747044078 * T)
        q = q + 0.00000051904 * System.Math.Cos(5.58435625607 + 942.062061969 * T)
        q = q + 0.00000050057 * System.Math.Cos(2.72063162317 + 532.8723588323 * T)
        q = q + 0.00000044548 * System.Math.Cos(5.52445621411 + 508.3503240922 * T)
        q = q + 0.00000044282 * System.Math.Cos(0.27118152557 + 526.5095713569 * T)
        q = q + 0.00000039833 * System.Math.Cos(5.94566506227 + 95.9792272178 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R21. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R21 = q * T * T
    End Function
    ' ************************
    Public Function Jupiter_R31(ByRef T As Object) As Object
        ' R3 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00003519257 * System.Math.Cos(6.05800633846 + 529.6909650946 * T)
        q = q + 0.00001073239 * System.Math.Cos(1.6732134576 + 536.8045120954 * T)
        q = q + 0.00000915666 * System.Math.Cos(1.41329676116 + 522.5774180938 * T)
        q = q + 0.00000341593 * System.Math.Cos(0.52296542656 + 1059.3819301892 * T)
        q = q + 0.00000254893 * System.Math.Cos(1.19625473533 + 7.1135470008 * T)
        q = q + 0.00000221512 * System.Math.Cos(0.95225226237 + 515.463871093 * T)
        q = q + 0.00000089729 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000069078 * System.Math.Cos(2.26885282314 + 1066.49547719 * T)
        q = q + 0.00000057827 * System.Math.Cos(1.41389745339 + 543.9180590962 * T)
        q = q + 0.00000057653 * System.Math.Cos(0.52580117593 + 639.897286314 * T)
        q = q + 0.00000051079 * System.Math.Cos(5.98016364677 + 412.3710968744 * T)
        q = q + 0.00000046935 * System.Math.Cos(1.57864237959 + 625.6701923124 * T)
        q = q + 0.00000042824 * System.Math.Cos(6.11689609099 + 419.4846438752 * T)
        q = q + 0.00000037477 * System.Math.Cos(1.1826276233 + 14.2270940016 * T)
        q = q + 0.00000033816 * System.Math.Cos(1.66671706951 + 1052.2683831884 * T)
        q = q + 0.00000033531 * System.Math.Cos(0.84784977903 + 206.1855484372 * T)
        q = q + 0.00000031195 * System.Math.Cos(1.04290245896 + 1589.0728952838 * T)
        q = q + 0.00000030023 * System.Math.Cos(4.63236245032 + 426.598190876 * T)
        q = q + 0.00000020804 * System.Math.Cos(2.50071243814 + 728.762966531 * T)
        q = q + 0.00000015023 * System.Math.Cos(0.89136998434 + 199.0720014364 * T)
        q = q + 0.00000014466 * System.Math.Cos(0.96040197071 + 508.3503240922 * T)
        q = q + 0.00000012969 * System.Math.Cos(1.5023378855 + 1045.1548361876 * T)
        q = q + 0.00000012319 * System.Math.Cos(2.60952614503 + 735.8765135318 * T)
        q = q + 0.00000011654 * System.Math.Cos(3.55513510121 + 323.5054166574 * T)
        q = q + 0.0000001116 * System.Math.Cos(1.79041437555 + 309.2783226558 * T)
        q = q + 0.00000010554 * System.Math.Cos(6.27845112678 + 956.2891559706 * T)
        q = q + 0.00000009812 * System.Math.Cos(6.26016859519 + 103.0927742186 * T)
        q = q + 0.00000009301 * System.Math.Cos(3.45126812476 + 838.9692877504 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R31. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R31 = q * T * T * T
    End Function
    ' ************************
    Public Function Jupiter_R41(ByRef T As Object) As Object
        ' R4 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00000128628 * System.Math.Cos(0.08419309557 + 536.8045120954 * T)
        q = q + 0.00000113458 * System.Math.Cos(4.24858855779 + 529.6909650946 * T)
        q = q + 0.0000008265 * System.Math.Cos(3.29754909408 + 522.5774180938 * T)
        q = q + 0.00000037883 * System.Math.Cos(2.73326611144 + 515.463871093 * T)
        q = q + 0.00000026694 * System.Math.Cos(5.69142588558 + 7.1135470008 * T)
        q = q + 0.0000001765 * System.Math.Cos(5.40012536918 + 1059.3819301892 * T)
        q = q + 0.00000012612 * System.Math.Cos(6.01560416057 + 543.9180590962 * T)
        q = q + 0.00000009287 * System.Math.Cos(0.76813946494 + 1066.49547719 * T)
        q = q + 0.00000008107 * System.Math.Cos(5.68228065707 + 14.2270940016 * T)
        q = q + 0.00000006978 * System.Math.Cos(1.42751292055 + 412.3710968744 * T)
        q = q + 0.00000006271 * System.Math.Cos(5.12286932534 + 639.897286314 * T)
        q = q + 0.00000005377 * System.Math.Cos(3.33501947275 + 625.6701923124 * T)
        q = q + 0.00000002911 * System.Math.Cos(3.40334805052 + 1052.2683831884 * T)
        q = q + 0.00000002593 * System.Math.Cos(4.16090412984 + 728.762966531 * T)
        q = q + 0.00000002562 * System.Math.Cos(2.89802035072 + 426.598190876 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R41. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R41 = q * T * T * T * T
    End Function
    ' ************************
    Public Function Jupiter_R51(ByRef T As Object) As Object
        ' R5 Segment #1 of 1
        Dim q As Object
        q = 0#
        q = q + 0.00000011188 * System.Math.Cos(4.75249399945 + 536.8045120954 * T)
        q = q + 0.00000004255 * System.Math.Cos(5.9151622917 + 522.5774180938 * T)
        q = q + 0.00000002079 * System.Math.Cos(5.56781555864 + 515.463871093 * T)
        q = q + 0.00000001908 * System.Math.Cos(4.29659647286 + 543.9180590962 * T)
        q = q + 0.00000001875 * System.Math.Cos(3.69357495838 + 7.1135470008 * T)
        q = q + 0.00000001612 * System.Math.Cos(4.13222808529 + 1059.3819301892 * T)
        q = q + 0.0000000159 * System.Math.Cos(5.49312796166 + 1066.49547719 * T)
        'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R51. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Jupiter_R51 = q * T * T * T * T * T
    End Function
    ' ************************
End Module