﻿using System;

namespace CelestialTools
{
    static class MarsFunctions
    {
        public static double Mars_L01(ref double T)
        {
            // L0 Segment #1 of 3
            double q = 0.0d;
            q = q + 6.20347711583d * Math.Cos(0d + 0d * T);
            q = q + 0.186563681d * Math.Cos(5.05037100303d + 3340.6124266998d * T);
            q = q + 0.01108216792d * Math.Cos(5.40099836958d + 6681.2248533996d * T);
            q = q + 0.00091798394d * Math.Cos(5.75478745111d + 10021.8372800994d * T);
            q = q + 0.00027744987d * Math.Cos(5.97049512942d + 3.523118349d * T);
            q = q + 0.00012315897d * Math.Cos(0.84956081238d + 2810.9214616052d * T);
            q = q + 0.0001061023d * Math.Cos(2.93958524973d + 2281.2304965106d * T);
            q = q + 0.00008926772d * Math.Cos(4.15697845939d + 0.0172536522d * T);
            q = q + 0.00008715688d * Math.Cos(6.11005159792d + 13362.4497067992d * T);
            q = q + 0.00007774867d * Math.Cos(3.33968655074d + 5621.8429232104d * T);
            q = q + 0.00006797552d * Math.Cos(0.36462243626d + 398.1490034082d * T);
            q = q + 0.00004161101d * Math.Cos(0.2281497533d + 2942.4634232916d * T);
            q = q + 0.00003575079d * Math.Cos(1.66186540141d + 2544.3144198834d * T);
            q = q + 0.0000307525d * Math.Cos(0.85696597082d + 191.4482661116d * T);
            q = q + 0.00002937543d * Math.Cos(6.07893711408d + 0.0673103028d * T);
            q = q + 0.00002628122d * Math.Cos(0.6480614357d + 3337.0893083508d * T);
            q = q + 0.00002579842d * Math.Cos(0.02996706197d + 3344.1355450488d * T);
            q = q + 0.0000238942d * Math.Cos(5.03896401349d + 796.2980068164d * T);
            q = q + 0.00001798808d * Math.Cos(0.65634026844d + 529.6909650946d * T);
            q = q + 0.00001546408d * Math.Cos(2.91579633392d + 1751.539531416d * T);
            q = q + 0.0000152814d * Math.Cos(1.1497930622799999d + 6151.533888305d * T);
            q = q + 0.00001286232d * Math.Cos(3.06795924626d + 2146.1654164752d * T);
            q = q + 0.00001264356d * Math.Cos(3.62275092231d + 5092.1519581158d * T);
            q = q + 0.00001024907d * Math.Cos(3.69334293555d + 8962.4553499102d * T);
            q = q + 0.00000891567d * Math.Cos(0.1829389909d + 16703.062133499d * T);
            q = q + 0.0000085876d * Math.Cos(2.40093704204d + 2914.0142358238d * T);
            q = q + 0.00000832724d * Math.Cos(4.49495753458d + 3340.629680352d * T);
            q = q + 0.00000832718d * Math.Cos(2.46418591282d + 3340.5951730476d * T);
            q = q + 0.00000748724d * Math.Cos(3.82248399468d + 155.4203994342d * T);
            q = q + 0.00000723863d * Math.Cos(0.67497565801d + 3738.761430108d * T);
            q = q + 0.00000712899d * Math.Cos(3.66336014788d + 1059.3819301892d * T);
            q = q + 0.00000655163d * Math.Cos(0.48864075176d + 3127.3133312618d * T);
            q = q + 0.00000635557d * Math.Cos(2.92182704275d + 8432.7643848156d * T);
            q = q + 0.00000552746d * Math.Cos(4.47478863016d + 1748.016413067d * T);
            q = q + 0.00000550472d * Math.Cos(3.81001205408d + 0.9803210682d * T);
            q = q + 0.00000472164d * Math.Cos(3.6254781941d + 1194.4470102246d * T);
            q = q + 0.00000425972d * Math.Cos(0.55365138172d + 6283.0758499914d * T);
            q = q + 0.00000415132d * Math.Cos(0.49662314774d + 213.299095438d * T);
            q = q + 0.00000312141d * Math.Cos(0.99853322843d + 6677.7017350506d * T);
            q = q + 0.00000306552d * Math.Cos(0.38052862973d + 6684.7479717486d * T);
            q = q + 0.00000302377d * Math.Cos(4.48618150321d + 3532.0606928114d * T);
            q = q + 0.00000299396d * Math.Cos(2.78323705697d + 6254.6266625236d * T);
            q = q + 0.00000293199d * Math.Cos(4.22131277914d + 20.7753954924d * T);
            q = q + 0.000002836d * Math.Cos(5.76885494123d + 3149.1641605882d * T);
            q = q + 0.00000281073d * Math.Cos(5.88163372945d + 1349.8674096588d * T);
            q = q + 0.00000274028d * Math.Cos(0.54222141841d + 3340.545116397d * T);
            q = q + 0.00000274035d * Math.Cos(0.13372501211d + 3340.6797370026d * T);
            q = q + 0.00000238857d * Math.Cos(5.37155471672d + 4136.9104335162d * T);
            q = q + 0.00000236114d * Math.Cos(5.75504515576d + 3333.498879699d * T);
            q = q + 0.00000231185d * Math.Cos(1.28240685294d + 3870.3033917944d * T);
            q = q + 0.00000221225d * Math.Cos(3.50466672203d + 382.8965322232d * T);
            q = q + 0.00000204161d * Math.Cos(2.82133266185d + 1221.8485663214d * T);
            q = q + 0.00000193126d * Math.Cos(3.35715137745d + 3.5904286518d * T);
            q = q + 0.00000188639d * Math.Cos(1.49103016486d + 9492.1463150048d * T);
            q = q + 0.00000179196d * Math.Cos(1.00561112574d + 951.7184062506d * T);
            q = q + 0.00000174068d * Math.Cos(2.41360332576d + 553.5694028424d * T);
            q = q + 0.0000017211d * Math.Cos(0.43943041719d + 5486.777843175d * T);
            q = q + 0.00000160011d * Math.Cos(3.94854735192d + 4562.4609930212d * T);
            q = q + 0.00000144305d * Math.Cos(1.41874193418d + 135.0650800354d * T);
            q = q + 0.00000139897d * Math.Cos(3.32592516164d + 2700.7151403858d * T);
            q = q + 0.00000138245d * Math.Cos(4.30145176915d + 7.1135470008d * T);
            q = q + 0.00000130993d * Math.Cos(4.04491720264d + 12303.06777661d * T);
            q = q + 0.00000128102d * Math.Cos(2.20806651008d + 1592.5960136328d * T);
            q = q + 0.00000128062d * Math.Cos(1.80665643332d + 5088.6288397668d * T);
            q = q + 0.00000116945d * Math.Cos(3.12805282207d + 7903.073419721d * T);
            q = q + 0.00000113486d * Math.Cos(3.70070798123d + 1589.0728952838d * T);
            q = q + 0.00000110375d * Math.Cos(1.05195079687d + 242.728603974d * T);
            q = q + 0.00000104541d * Math.Cos(0.78535382076d + 8827.3902698748d * T);
            q = q + 0.0000010009d * Math.Cos(3.24343740861d + 11773.3768115154d * T);
            return q * 1d;
        }

        public static double Mars_L02(ref double T)
        {
            // L0 Segment #2 of 3
            double q = 0.0d;
            return q * 1d;
        }

        public static double Mars_L03(ref double T)
        {
            // L0 Segment #3 of 3
            double q = 0.0d;
            return q * 1d;
        }

        public static double Mars_L11(ref double T)
        {
            // L1 Segment #1 of 2
            double q = 0.0d;
            q = q + 3340.85627474342d * Math.Cos(0d + 0d * T);
            q = q + 0.01458227051d * Math.Cos(3.60426053609d + 3340.6124266998d * T);
            q = q + 0.00164901343d * Math.Cos(3.92631250962d + 6681.2248533996d * T);
            q = q + 0.00019963338d * Math.Cos(4.2659406103d + 10021.8372800994d * T);
            q = q + 0.00003452399d * Math.Cos(4.73210386365d + 3.523118349d * T);
            q = q + 0.0000248548d * Math.Cos(4.61277567318d + 13362.4497067992d * T);
            q = q + 0.00000841551d * Math.Cos(4.45858256765d + 2281.2304965106d * T);
            q = q + 0.00000537566d * Math.Cos(5.01589727492d + 398.1490034082d * T);
            q = q + 0.00000521041d * Math.Cos(4.99422678175d + 3344.1355450488d * T);
            q = q + 0.00000432614d * Math.Cos(2.5606640286d + 191.4482661116d * T);
            q = q + 0.00000429656d * Math.Cos(5.31646162367d + 155.4203994342d * T);
            q = q + 0.00000381747d * Math.Cos(3.53881289437d + 796.2980068164d * T);
            q = q + 0.00000314129d * Math.Cos(4.96335266049d + 16703.062133499d * T);
            q = q + 0.00000282804d * Math.Cos(3.15967518204d + 2544.3144198834d * T);
            q = q + 0.00000205664d * Math.Cos(4.5689145566d + 2146.1654164752d * T);
            q = q + 0.00000168805d * Math.Cos(1.32894813366d + 3337.0893083508d * T);
            q = q + 0.00000157587d * Math.Cos(4.18501035954d + 1751.539531416d * T);
            q = q + 0.00000133686d * Math.Cos(2.23325104196d + 0.9803210682d * T);
            q = q + 0.00000133563d * Math.Cos(5.97421903927d + 1748.016413067d * T);
            q = q + 0.00000117591d * Math.Cos(6.02407213861d + 6151.533888305d * T);
            q = q + 0.00000116561d * Math.Cos(2.21347652545d + 1059.3819301892d * T);
            q = q + 0.00000113876d * Math.Cos(2.12869455089d + 1194.4470102246d * T);
            q = q + 0.00000113595d * Math.Cos(5.42803224317d + 3738.761430108d * T);
            q = q + 0.00000091098d * Math.Cos(1.09627836591d + 1349.8674096588d * T);
            q = q + 0.00000085342d * Math.Cos(3.90854841008d + 553.5694028424d * T);
            q = q + 0.00000083301d * Math.Cos(5.29636626272d + 6684.7479717486d * T);
            q = q + 0.00000080776d * Math.Cos(4.42813405865d + 529.6909650946d * T);
            q = q + 0.00000079531d * Math.Cos(2.2486426633d + 8962.4553499102d * T);
            q = q + 0.00000072946d * Math.Cos(2.50189460554d + 951.7184062506d * T);
            q = q + 0.00000072505d * Math.Cos(5.8420816324d + 242.728603974d * T);
            q = q + 0.00000071487d * Math.Cos(3.85636094435d + 2914.0142358238d * T);
            q = q + 0.00000067582d * Math.Cos(5.02327686473d + 382.8965322232d * T);
            q = q + 0.00000065089d * Math.Cos(1.01802439311d + 3340.5951730476d * T);
            q = q + 0.00000065089d * Math.Cos(3.04879603978d + 3340.629680352d * T);
            q = q + 0.00000061508d * Math.Cos(4.151831598d + 3149.1641605882d * T);
            q = q + 0.0000005652d * Math.Cos(3.8881369932d + 4136.9104335162d * T);
            q = q + 0.00000048477d * Math.Cos(4.87362121538d + 213.299095438d * T);
            q = q + 0.00000047613d * Math.Cos(1.18238046057d + 3333.498879699d * T);
            q = q + 0.00000046584d * Math.Cos(1.31452419914d + 3185.1920272656d * T);
            q = q + 0.00000041343d * Math.Cos(0.71385375517d + 1592.5960136328d * T);
            q = q + 0.00000040272d * Math.Cos(2.72542480614d + 7.1135470008d * T);
            q = q + 0.00000040055d * Math.Cos(5.31611875491d + 20043.6745601988d * T);
            q = q + 0.00000032886d * Math.Cos(5.41067411968d + 6283.0758499914d * T);
            q = q + 0.00000028244d * Math.Cos(0.04534124888d + 9492.1463150048d * T);
            q = q + 0.00000026579d * Math.Cos(3.88960724782d + 1221.8485663214d * T);
            q = q + 0.00000026554d * Math.Cos(5.11271747607d + 2700.7151403858d * T);
            return q * T;
        }

        public static double Mars_L12(ref double T)
        {
            // L1 Segment #2 of 2
            double q = 0.0d;
            return q * T;
        }

        public static double Mars_L21(ref double T)
        {
            // L2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00058015791d * Math.Cos(2.04979463279d + 3340.6124266998d * T);
            q = q + 0.00054187645d * Math.Cos(0d + 0d * T);
            q = q + 0.00013908426d * Math.Cos(2.45742359888d + 6681.2248533996d * T);
            q = q + 0.00002465104d * Math.Cos(2.80000020929d + 10021.8372800994d * T);
            q = q + 0.00000398379d * Math.Cos(3.14118428289d + 13362.4497067992d * T);
            q = q + 0.00000222022d * Math.Cos(3.19436080019d + 3.523118349d * T);
            q = q + 0.00000120957d * Math.Cos(0.54325292454d + 155.4203994342d * T);
            q = q + 0.00000061517d * Math.Cos(3.48529427371d + 16703.062133499d * T);
            q = q + 0.00000053638d * Math.Cos(3.54191121461d + 3344.1355450488d * T);
            q = q + 0.00000034268d * Math.Cos(6.00188499119d + 2281.2304965106d * T);
            q = q + 0.00000031665d * Math.Cos(4.14015171788d + 191.4482661116d * T);
            q = q + 0.00000029839d * Math.Cos(1.99870679845d + 796.2980068164d * T);
            q = q + 0.00000023168d * Math.Cos(4.33403365928d + 242.728603974d * T);
            q = q + 0.00000021659d * Math.Cos(3.44532466378d + 398.1490034082d * T);
            q = q + 0.0000002037d * Math.Cos(5.421913754d + 553.5694028424d * T);
            q = q + 0.00000016227d * Math.Cos(0.65678953303d + 0.9803210682d * T);
            q = q + 0.00000016044d * Math.Cos(6.11000472441d + 2146.1654164752d * T);
            q = q + 0.00000015648d * Math.Cos(1.2208612194d + 1748.016413067d * T);
            q = q + 0.00000014927d * Math.Cos(6.09541783564d + 3185.1920272656d * T);
            q = q + 0.00000014416d * Math.Cos(4.01923812101d + 951.7184062506d * T);
            q = q + 0.00000014317d * Math.Cos(2.61851897591d + 1349.8674096588d * T);
            q = q + 0.00000013352d * Math.Cos(0.60189008414d + 1194.4470102246d * T);
            q = q + 0.00000011934d * Math.Cos(3.86122163021d + 6684.7479717486d * T);
            q = q + 0.0000001126d * Math.Cos(4.71822363671d + 2544.3144198834d * T);
            q = q + 0.00000010396d * Math.Cos(0.25038714677d + 382.8965322232d * T);
            q = q + 0.00000009468d * Math.Cos(0.68170713564d + 1059.3819301892d * T);
            q = q + 0.00000009229d * Math.Cos(3.83209092321d + 20043.6745601988d * T);
            q = q + 0.00000009005d * Math.Cos(3.88271826102d + 3738.761430108d * T);
            q = q + 0.00000007501d * Math.Cos(5.46498630412d + 1751.539531416d * T);
            q = q + 0.00000006859d * Math.Cos(2.57522504136d + 3149.1641605882d * T);
            q = q + 0.00000006681d * Math.Cos(2.37843690339d + 4136.9104335162d * T);
            q = q + 0.00000006497d * Math.Cos(5.47773072872d + 1592.5960136328d * T);
            q = q + 0.00000006311d * Math.Cos(2.34104793674d + 3097.88382272579d * T);
            return q * T * T;
        }

        public static double Mars_L31(ref double T)
        {
            // L3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00001482423d * Math.Cos(0.44434694876d + 3340.6124266998d * T);
            q = q + 0.00000662095d * Math.Cos(0.88469178686d + 6681.2248533996d * T);
            q = q + 0.00000188268d * Math.Cos(1.28799982497d + 10021.8372800994d * T);
            q = q + 0.00000041474d * Math.Cos(1.64850786997d + 13362.4497067992d * T);
            q = q + 0.00000025994d * Math.Cos(0d + 0d * T);
            q = q + 0.00000022661d * Math.Cos(2.05267665262d + 155.4203994342d * T);
            q = q + 0.00000010454d * Math.Cos(1.58006906385d + 3.523118349d * T);
            q = q + 0.00000008024d * Math.Cos(1.99858757687d + 16703.062133499d * T);
            q = q + 0.000000049d * Math.Cos(2.82452457966d + 242.728603974d * T);
            q = q + 0.00000003782d * Math.Cos(2.01914272515d + 3344.1355450488d * T);
            q = q + 0.00000003176d * Math.Cos(4.59144897927d + 3185.1920272656d * T);
            q = q + 0.00000003134d * Math.Cos(0.65044714325d + 553.5694028424d * T);
            return q * T * T * T;
        }

        public static double Mars_L41(ref double T)
        {
            // L4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000113969d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000028725d * Math.Cos(5.63662412043d + 6681.2248533996d * T);
            q = q + 0.00000024447d * Math.Cos(5.13868481454d + 3340.6124266998d * T);
            q = q + 0.00000011187d * Math.Cos(6.03161074431d + 10021.8372800994d * T);
            q = q + 0.00000003252d * Math.Cos(0.13228350651d + 13362.4497067992d * T);
            q = q + 0.0000000319d * Math.Cos(3.56267988299d + 155.4203994342d * T);
            q = q + 0.00000000787d * Math.Cos(0.49340783377d + 16703.062133499d * T);
            q = q + 0.00000000776d * Math.Cos(1.31734531594d + 242.728603974d * T);
            return q * T * T * T * T;
        }

        public static double Mars_L51(ref double T)
        {
            // L5 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000000868d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.0000000071d * Math.Cos(4.04089996521d + 6681.2248533996d * T);
            return q * T * T * T * T * T;
        }
        // ************************
        public static double Mars_B01(ref double T)
        {
            // B0 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.03197134986d * Math.Cos(3.76832042432d + 3340.6124266998d * T);
            q = q + 0.00298033234d * Math.Cos(4.10616996243d + 6681.2248533996d * T);
            q = q + 0.00289104742d * Math.Cos(0d + 0d * T);
            q = q + 0.00031365538d * Math.Cos(4.44651052853d + 10021.8372800994d * T);
            q = q + 0.000034841d * Math.Cos(4.78812547889d + 13362.4497067992d * T);
            q = q + 0.00000443401d * Math.Cos(5.02642620491d + 3344.1355450488d * T);
            q = q + 0.00000442999d * Math.Cos(5.65233015876d + 3337.0893083508d * T);
            q = q + 0.00000399109d * Math.Cos(5.130568147d + 16703.062133499d * T);
            q = q + 0.00000292506d * Math.Cos(3.79290644595d + 2281.2304965106d * T);
            q = q + 0.00000181982d * Math.Cos(6.13648011704d + 6151.533888305d * T);
            q = q + 0.00000163159d * Math.Cos(4.26399626634d + 529.6909650946d * T);
            q = q + 0.00000159678d * Math.Cos(2.23194610246d + 1059.3819301892d * T);
            q = q + 0.00000149297d * Math.Cos(2.16501209917d + 5621.8429232104d * T);
            q = q + 0.00000142686d * Math.Cos(1.1821501611d + 3340.5951730476d * T);
            q = q + 0.00000142685d * Math.Cos(3.2129218082d + 3340.629680352d * T);
            q = q + 0.00000139323d * Math.Cos(2.41796344238d + 8962.4553499102d * T);
            return q * 1d;
        }

        public static double Mars_B11(ref double T)
        {
            // B1 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00350068845d * Math.Cos(5.36847836211d + 3340.6124266998d * T);
            q = q + 0.0001411603d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00009670755d * Math.Cos(5.47877786506d + 6681.2248533996d * T);
            q = q + 0.00001471918d * Math.Cos(3.20205766795d + 10021.8372800994d * T);
            q = q + 0.00000425864d * Math.Cos(3.40843812875d + 13362.4497067992d * T);
            q = q + 0.00000102039d * Math.Cos(0.77617286189d + 3337.0893083508d * T);
            q = q + 0.00000078848d * Math.Cos(3.71768293865d + 16703.062133499d * T);
            q = q + 0.00000032708d * Math.Cos(3.45803723682d + 5621.8429232104d * T);
            q = q + 0.00000026171d * Math.Cos(2.48293558065d + 2281.2304965106d * T);
            return q * T;
        }

        public static double Mars_B21(ref double T)
        {
            // B2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.0001672669d * Math.Cos(0.60221392419d + 3340.6124266998d * T);
            q = q + 0.00004986799d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000302141d * Math.Cos(5.55871276021d + 6681.2248533996d * T);
            q = q + 0.00000025767d * Math.Cos(1.89662673499d + 13362.4497067992d * T);
            q = q + 0.00000021452d * Math.Cos(0.91749968618d + 10021.8372800994d * T);
            q = q + 0.0000001182d * Math.Cos(2.242407387d + 3337.0893083508d * T);
            q = q + 0.00000007985d * Math.Cos(2.24892866611d + 16703.062133499d * T);
            return q * T * T;
        }

        public static double Mars_B31(ref double T)
        {
            // B3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000606506d * Math.Cos(1.98050633529d + 3340.6124266998d * T);
            q = q + 0.00000042611d * Math.Cos(0d + 0d * T);
            q = q + 0.00000013652d * Math.Cos(1.795882288d + 6681.2248533996d * T);
            q = q + 0.0000000273d * Math.Cos(3.45377082121d + 10021.8372800994d * T);
            return q * T * T * T;
        }

        public static double Mars_B41(ref double T)
        {
            // B4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000013369d * Math.Cos(0d + 0d * T);
            q = q + 0.00000011334d * Math.Cos(3.45724352586d + 3340.6124266998d * T);
            q = q + 0.00000000744d * Math.Cos(0.50445805257d + 6681.2248533996d * T);
            return q * T * T * T * T;
        }

        public static double Mars_B51(ref double T)
        {
            // B5 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T * T * T;
        }

        public static double Mars_R01(ref double T)
        {
            // R0 Segment #1 of 3
            double q = 0.0d;
            q = q + 1.53033488276d * Math.Cos(0d + 0d * T);
            q = q + 0.14184953153d * Math.Cos(3.47971283519d + 3340.6124266998d * T);
            q = q + 0.00660776357d * Math.Cos(3.81783442097d + 6681.2248533996d * T);
            q = q + 0.00046179117d * Math.Cos(4.15595316284d + 10021.8372800994d * T);
            q = q + 0.00008109738d * Math.Cos(5.55958460165d + 2810.9214616052d * T);
            q = q + 0.00007485315d * Math.Cos(1.77238998069d + 5621.8429232104d * T);
            q = q + 0.00005523193d * Math.Cos(1.3643631888d + 2281.2304965106d * T);
            q = q + 0.0000382516d * Math.Cos(4.49407182408d + 13362.4497067992d * T);
            q = q + 0.00002484385d * Math.Cos(4.92545577893d + 2942.4634232916d * T);
            q = q + 0.00002306539d * Math.Cos(0.09081742493d + 2544.3144198834d * T);
            q = q + 0.00001999399d * Math.Cos(5.36059605227d + 3337.0893083508d * T);
            q = q + 0.00001960198d * Math.Cos(4.74249386323d + 3344.1355450488d * T);
            q = q + 0.00001167115d * Math.Cos(2.11261501155d + 5092.1519581158d * T);
            q = q + 0.00001102828d * Math.Cos(5.0090826416d + 398.1490034082d * T);
            q = q + 0.00000992252d * Math.Cos(5.83862401067d + 6151.533888305d * T);
            q = q + 0.00000899077d * Math.Cos(4.40790433994d + 529.6909650946d * T);
            q = q + 0.00000807348d * Math.Cos(2.10216647104d + 1059.3819301892d * T);
            q = q + 0.0000079791d * Math.Cos(3.44839026172d + 796.2980068164d * T);
            q = q + 0.0000074098d * Math.Cos(1.49906336892d + 2146.1654164752d * T);
            q = q + 0.00000725583d * Math.Cos(1.24516913473d + 8432.7643848156d * T);
            q = q + 0.0000069234d * Math.Cos(2.13378814785d + 8962.4553499102d * T);
            q = q + 0.00000633144d * Math.Cos(0.89353285018d + 3340.5951730476d * T);
            q = q + 0.0000063314d * Math.Cos(2.92430448169d + 3340.629680352d * T);
            q = q + 0.00000629976d * Math.Cos(1.28738135858d + 1751.539531416d * T);
            q = q + 0.00000574352d * Math.Cos(0.82896196337d + 2914.0142358238d * T);
            q = q + 0.00000526187d * Math.Cos(5.38292276228d + 3738.761430108d * T);
            q = q + 0.00000472776d * Math.Cos(5.19850457873d + 3127.3133312618d * T);
            q = q + 0.00000348095d * Math.Cos(4.83219198908d + 16703.062133499d * T);
            q = q + 0.00000283702d * Math.Cos(2.90692294913d + 3532.0606928114d * T);
            q = q + 0.00000279552d * Math.Cos(5.25749247548d + 6283.0758499914d * T);
            q = q + 0.00000275501d * Math.Cos(1.21767967781d + 6254.6266625236d * T);
            q = q + 0.00000275224d * Math.Cos(2.90818883832d + 1748.016413067d * T);
            q = q + 0.00000269891d * Math.Cos(3.76394728622d + 5884.9268465832d * T);
            q = q + 0.00000239133d * Math.Cos(2.03669896238d + 1194.4470102246d * T);
            q = q + 0.00000233827d * Math.Cos(5.10546492529d + 5486.777843175d * T);
            q = q + 0.00000228128d * Math.Cos(3.2552902062d + 6872.6731195112d * T);
            q = q + 0.0000022319d * Math.Cos(4.19861593779d + 3149.1641605882d * T);
            q = q + 0.00000219428d * Math.Cos(5.58340248784d + 191.4482661116d * T);
            q = q + 0.00000208333d * Math.Cos(5.25476080773d + 3340.545116397d * T);
            q = q + 0.00000208336d * Math.Cos(4.84626442122d + 3340.6797370026d * T);
            q = q + 0.00000186213d * Math.Cos(5.69871555748d + 6677.7017350506d * T);
            q = q + 0.00000182686d * Math.Cos(5.08062683355d + 6684.7479717486d * T);
            q = q + 0.00000178613d * Math.Cos(4.18423025538d + 3333.498879699d * T);
            q = q + 0.00000175995d * Math.Cos(5.95341786369d + 3870.3033917944d * T);
            q = q + 0.00000163534d * Math.Cos(3.79889068111d + 4136.9104335162d * T);
            return q * 1d;
        }

        public static double Mars_R02(ref double T)
        {
            // R0 Segment #2 of 3
            double q = 0.0d;
            return q * 1d;
        }

        public static double Mars_R03(ref double T)
        {
            // R0 Segment #3 of 3
            double q = 0.0d;
            return q * 1d;
        }
        // ************************
        public static double Mars_R11(ref double T)
        {
            // R1 Segment #1 of 2
            double q = 0.0d;
            q = q + 0.0110743334d * Math.Cos(2.0325052495d + 3340.6124266998d * T);
            q = q + 0.00103175886d * Math.Cos(2.37071845682d + 6681.2248533996d * T);
            q = q + 0.000128772d * Math.Cos(0d + 0d * T);
            q = q + 0.0001081588d * Math.Cos(2.70888093803d + 10021.8372800994d * T);
            q = q + 0.0000119455d * Math.Cos(3.04702182503d + 13362.4497067992d * T);
            q = q + 0.00000438579d * Math.Cos(2.88835072628d + 2281.2304965106d * T);
            q = q + 0.00000395698d * Math.Cos(3.42324611291d + 3344.1355450488d * T);
            q = q + 0.00000182572d * Math.Cos(1.58428644001d + 2544.3144198834d * T);
            q = q + 0.0000013585d * Math.Cos(3.38507017993d + 16703.062133499d * T);
            q = q + 0.00000128362d * Math.Cos(6.04343360441d + 3337.0893083508d * T);
            q = q + 0.00000128204d * Math.Cos(0.6299122057d + 1059.3819301892d * T);
            q = q + 0.00000127068d * Math.Cos(1.9538977574d + 796.2980068164d * T);
            q = q + 0.00000118443d * Math.Cos(2.99761345074d + 2146.1654164752d * T);
            q = q + 0.00000087537d * Math.Cos(3.42052758979d + 398.1490034082d * T);
            q = q + 0.00000083026d * Math.Cos(3.85574986653d + 3738.761430108d * T);
            q = q + 0.00000075598d * Math.Cos(4.45101839349d + 6151.533888305d * T);
            q = q + 0.00000071999d * Math.Cos(2.7644218068d + 529.6909650946d * T);
            q = q + 0.00000066542d * Math.Cos(2.54892602695d + 1751.539531416d * T);
            q = q + 0.0000006643d * Math.Cos(4.40597549957d + 1748.016413067d * T);
            q = q + 0.00000057518d * Math.Cos(0.54354327916d + 1194.4470102246d * T);
            q = q + 0.00000054314d * Math.Cos(0.67750943459d + 8962.4553499102d * T);
            q = q + 0.00000051035d * Math.Cos(3.72585409207d + 6684.7479717486d * T);
            q = q + 0.00000049428d * Math.Cos(5.72959428364d + 3340.5951730476d * T);
            q = q + 0.00000049424d * Math.Cos(1.47717922226d + 3340.629680352d * T);
            q = q + 0.00000048318d * Math.Cos(2.58061691301d + 3149.1641605882d * T);
            q = q + 0.00000047863d * Math.Cos(2.28527896843d + 2914.0142358238d * T);
            q = q + 0.00000038953d * Math.Cos(2.31900090554d + 4136.9104335162d * T);
            return q * T;
        }

        public static double Mars_R12(ref double T)
        {
            // R1 Segment #2 of 2
            double q = 0.0d;
            return q * T;
        }

        public static double Mars_R21(ref double T)
        {
            // R2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00044242247d * Math.Cos(0.47930603943d + 3340.6124266998d * T);
            q = q + 0.00008138042d * Math.Cos(0.86998398093d + 6681.2248533996d * T);
            q = q + 0.00001274915d * Math.Cos(1.22594050809d + 10021.8372800994d * T);
            q = q + 0.00000187387d * Math.Cos(1.57298991982d + 13362.4497067992d * T);
            q = q + 0.00000052396d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000040744d * Math.Cos(1.9708017506d + 3344.1355450488d * T);
            q = q + 0.00000026616d * Math.Cos(1.91665615762d + 16703.062133499d * T);
            q = q + 0.00000017825d * Math.Cos(4.43499505333d + 2281.2304965106d * T);
            q = q + 0.00000011713d * Math.Cos(4.5251045373d + 3185.1920272656d * T);
            q = q + 0.00000010209d * Math.Cos(5.39143469548d + 1059.3819301892d * T);
            q = q + 0.0000000995d * Math.Cos(0.41870577185d + 796.2980068164d * T);
            return q * T * T;
        }

        public static double Mars_R31(ref double T)
        {
            // R3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00001113107d * Math.Cos(5.14987350142d + 3340.6124266998d * T);
            q = q + 0.00000424446d * Math.Cos(5.61343766478d + 6681.2248533996d * T);
            q = q + 0.00000100044d * Math.Cos(5.99726827028d + 10021.8372800994d * T);
            q = q + 0.00000019606d * Math.Cos(0.07633062094d + 13362.4497067992d * T);
            q = q + 0.00000004693d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000003477d * Math.Cos(0.42951907576d + 16703.062133499d * T);
            return q * T * T * T;
        }

        public static double Mars_R41(ref double T)
        {
            // R4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000019552d * Math.Cos(3.58211650473d + 3340.6124266998d * T);
            q = q + 0.00000016323d * Math.Cos(4.05116076923d + 6681.2248533996d * T);
            q = q + 0.00000005848d * Math.Cos(4.46383962094d + 10021.8372800994d * T);
            q = q + 0.00000001532d * Math.Cos(4.84374321619d + 13362.4497067992d * T);
            return q * T * T * T * T;
        }

        public static double Mars_R51(ref double T)
        {
            // R5 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T * T * T;
        }
    }
}