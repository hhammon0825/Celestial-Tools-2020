﻿using System;

namespace CelestialTools
{
    static class EarthFunctions
    {
        public static double Earth_L01(ref double T)
        {
            // L0 Segment #1 of 2
            double q = 0.0d;
            q = q + 1.75347045673d * Math.Cos(0d + 0d * T);
            q = q + 0.03341656456d * Math.Cos(4.66925680417d + 6283.0758499914d * T);
            q = q + 0.00034894275d * Math.Cos(4.62610241759d + 12566.1516999828d * T);
            q = q + 0.00003497056d * Math.Cos(2.74411800971d + 5753.3848848968d * T);
            q = q + 0.00003417571d * Math.Cos(2.82886579606d + 3.523118349d * T);
            q = q + 0.00003135896d * Math.Cos(3.62767041758d + 77713.7714681205d * T);
            q = q + 0.00002676218d * Math.Cos(4.41808351397d + 7860.4193924392d * T);
            q = q + 0.00002342687d * Math.Cos(6.13516237631d + 3930.2096962196d * T);
            q = q + 0.00001324292d * Math.Cos(0.74246356352d + 11506.7697697936d * T);
            q = q + 0.00001273166d * Math.Cos(2.03709655772d + 529.6909650946d * T);
            q = q + 0.00001199167d * Math.Cos(1.10962944315d + 1577.3435424478d * T);
            q = q + 0.0000099025d * Math.Cos(5.23268129594d + 5884.9268465832d * T);
            q = q + 0.00000901855d * Math.Cos(2.04505443513d + 26.2983197998d * T);
            q = q + 0.00000857223d * Math.Cos(3.50849156957d + 398.1490034082d * T);
            q = q + 0.00000779786d * Math.Cos(1.17882652114d + 5223.6939198022d * T);
            q = q + 0.00000753141d * Math.Cos(2.53339053818d + 5507.5532386674d * T);
            q = q + 0.00000505264d * Math.Cos(4.58292563052d + 18849.2275499742d * T);
            q = q + 0.00000492379d * Math.Cos(4.20506639861d + 775.522611324d * T);
            q = q + 0.00000356655d * Math.Cos(2.91954116867d + 0.0673103028d * T);
            q = q + 0.00000317087d * Math.Cos(5.84901952218d + 11790.6290886588d * T);
            q = q + 0.00000284125d * Math.Cos(1.89869034186d + 796.2980068164d * T);
            q = q + 0.00000271039d * Math.Cos(0.31488607649d + 10977.078804699d * T);
            q = q + 0.0000024281d * Math.Cos(0.34481140906d + 5486.777843175d * T);
            q = q + 0.0000020616d * Math.Cos(4.80646606059d + 2544.3144198834d * T);
            q = q + 0.00000205385d * Math.Cos(1.86947813692d + 5573.1428014331d * T);
            q = q + 0.00000202261d * Math.Cos(2.45767795458d + 6069.7767545534d * T);
            q = q + 0.00000155516d * Math.Cos(0.83306073807d + 213.299095438d * T);
            q = q + 0.00000132212d * Math.Cos(3.41118275555d + 2942.4634232916d * T);
            q = q + 0.00000126184d * Math.Cos(1.0830263021d + 20.7753954924d * T);
            q = q + 0.00000115132d * Math.Cos(0.64544911683d + 0.9803210682d * T);
            q = q + 0.00000102851d * Math.Cos(0.63599846727d + 4694.0029547076d * T);
            q = q + 0.00000101895d * Math.Cos(0.97569221824d + 15720.8387848784d * T);
            q = q + 0.00000101724d * Math.Cos(4.26679821365d + 7.1135470008d * T);
            q = q + 0.00000099206d * Math.Cos(6.20992940258d + 2146.1654164752d * T);
            q = q + 0.00000097607d * Math.Cos(0.6810127227d + 155.4203994342d * T);
            q = q + 0.00000085803d * Math.Cos(5.98322631256d + 161000.685737674d * T);
            q = q + 0.00000085128d * Math.Cos(1.29870743025d + 6275.9623029906d * T);
            q = q + 0.00000084711d * Math.Cos(3.67080093025d + 71430.6956181291d * T);
            q = q + 0.00000079637d * Math.Cos(1.807913307d + 17260.1546546904d * T);
            q = q + 0.00000078756d * Math.Cos(3.03698313141d + 12036.4607348882d * T);
            q = q + 0.00000074651d * Math.Cos(1.75508916159d + 5088.6288397668d * T);
            q = q + 0.00000073874d * Math.Cos(3.50319443167d + 3154.6870848956d * T);
            q = q + 0.00000073547d * Math.Cos(4.67926565481d + 801.8209311238d * T);
            q = q + 0.00000069627d * Math.Cos(0.83297596966d + 9437.762934887d * T);
            q = q + 0.00000062449d * Math.Cos(3.97763880587d + 8827.3902698748d * T);
            q = q + 0.00000061148d * Math.Cos(1.81839811024d + 7084.8967811152d * T);
            q = q + 0.00000056963d * Math.Cos(2.78430398043d + 6286.5989683404d * T);
            q = q + 0.00000056116d * Math.Cos(4.38694880779d + 14143.4952424306d * T);
            q = q + 0.00000055577d * Math.Cos(3.47006009062d + 6279.5527316424d * T);
            q = q + 0.00000051992d * Math.Cos(0.18914945834d + 12139.5535091068d * T);
            q = q + 0.00000051605d * Math.Cos(1.33282746983d + 1748.016413067d * T);
            q = q + 0.00000051145d * Math.Cos(0.28306864501d + 5856.4776591154d * T);
            q = q + 0.00000049d * Math.Cos(0.48735065033d + 1194.4470102246d * T);
            q = q + 0.00000041036d * Math.Cos(5.36817351402d + 8429.2412664666d * T);
            q = q + 0.00000040938d * Math.Cos(2.39850881707d + 19651.048481098d * T);
            q = q + 0.000000392d * Math.Cos(6.16832995016d + 10447.3878396044d * T);
            q = q + 0.0000003677d * Math.Cos(6.04133859347d + 10213.285546211d * T);
            q = q + 0.00000036596d * Math.Cos(2.56955238628d + 1059.3819301892d * T);
            q = q + 0.00000035954d * Math.Cos(1.70876111898d + 2352.8661537718d * T);
            q = q + 0.00000035566d * Math.Cos(1.77597314691d + 6812.766815086d * T);
            q = q + 0.00000033291d * Math.Cos(0.59309499459d + 17789.845619785d * T);
            q = q + 0.00000030412d * Math.Cos(0.44294464135d + 83996.8473181119d * T);
            q = q + 0.00000030047d * Math.Cos(2.73975123935d + 1349.8674096588d * T);
            q = q + 0.00000025352d * Math.Cos(3.16470953405d + 4690.4798363586d * T);
            return q * 1d;
        }

        public static double Earth_L02(ref double T)
        {
            // L0 Segment #2 of 2
            double q = 0.0d;
            return q * 1d;
        }

        public static double Earth_L11(ref double T)
        {
            // L1 Segment #1 of 1
            double q = 0.0d;
            q = q + 6283.31966747491d * Math.Cos(0d + 0d * T);
            q = q + 0.00206058863d * Math.Cos(2.67823455584d + 6283.0758499914d * T);
            q = q + 0.0000430343d * Math.Cos(2.63512650414d + 12566.1516999828d * T);
            q = q + 0.00000425264d * Math.Cos(1.59046980729d + 3.523118349d * T);
            q = q + 0.00000119261d * Math.Cos(5.79557487799d + 26.2983197998d * T);
            q = q + 0.00000108977d * Math.Cos(2.96618001993d + 1577.3435424478d * T);
            q = q + 0.00000093478d * Math.Cos(2.59212835365d + 18849.2275499742d * T);
            q = q + 0.00000072122d * Math.Cos(1.13846158196d + 529.6909650946d * T);
            q = q + 0.00000067768d * Math.Cos(1.87472304791d + 398.1490034082d * T);
            q = q + 0.00000067327d * Math.Cos(4.40918235168d + 5507.5532386674d * T);
            q = q + 0.00000059027d * Math.Cos(2.8879703846d + 5223.6939198022d * T);
            q = q + 0.00000055976d * Math.Cos(2.17471680261d + 155.4203994342d * T);
            q = q + 0.00000045407d * Math.Cos(0.39803079805d + 796.2980068164d * T);
            q = q + 0.00000036369d * Math.Cos(0.46624739835d + 775.522611324d * T);
            q = q + 0.00000028958d * Math.Cos(2.64707383882d + 7.1135470008d * T);
            q = q + 0.00000020844d * Math.Cos(5.34138275149d + 0.9803210682d * T);
            q = q + 0.00000019097d * Math.Cos(1.84628332577d + 5486.777843175d * T);
            q = q + 0.00000018508d * Math.Cos(4.96855124577d + 213.299095438d * T);
            q = q + 0.00000017293d * Math.Cos(2.99116864949d + 6275.9623029906d * T);
            q = q + 0.00000016233d * Math.Cos(0.03216483047d + 2544.3144198834d * T);
            q = q + 0.00000015832d * Math.Cos(1.43049285325d + 2146.1654164752d * T);
            q = q + 0.00000014615d * Math.Cos(1.20532366323d + 10977.078804699d * T);
            q = q + 0.00000012461d * Math.Cos(2.83432285512d + 1748.016413067d * T);
            q = q + 0.00000011877d * Math.Cos(3.25804815607d + 5088.6288397668d * T);
            q = q + 0.00000011808d * Math.Cos(5.2737979048d + 1194.4470102246d * T);
            q = q + 0.00000011514d * Math.Cos(2.07502418155d + 4694.0029547076d * T);
            q = q + 0.00000010641d * Math.Cos(0.76614199202d + 553.5694028424d * T);
            q = q + 0.00000009969d * Math.Cos(1.30262991097d + 6286.5989683404d * T);
            q = q + 0.00000009721d * Math.Cos(4.23925472239d + 1349.8674096588d * T);
            q = q + 0.00000009452d * Math.Cos(2.69957062864d + 242.728603974d * T);
            q = q + 0.00000008577d * Math.Cos(5.64475868067d + 951.7184062506d * T);
            q = q + 0.00000007576d * Math.Cos(5.30062664886d + 2352.8661537718d * T);
            q = q + 0.00000006385d * Math.Cos(2.65033984967d + 9437.762934887d * T);
            q = q + 0.00000006101d * Math.Cos(4.66632584188d + 4690.4798363586d * T);
            return q * T;
        }

        public static double Earth_L21(ref double T)
        {
            // L2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.0005291887d * Math.Cos(0d + 0d * T);
            q = q + 0.00008719837d * Math.Cos(1.07209665242d + 6283.0758499914d * T);
            q = q + 0.00000309125d * Math.Cos(0.86728818832d + 12566.1516999828d * T);
            q = q + 0.00000027339d * Math.Cos(0.05297871691d + 3.523118349d * T);
            q = q + 0.00000016334d * Math.Cos(5.18826691036d + 26.2983197998d * T);
            q = q + 0.00000015752d * Math.Cos(3.6845788943d + 155.4203994342d * T);
            q = q + 0.00000009541d * Math.Cos(0.75742297675d + 18849.2275499742d * T);
            q = q + 0.00000008937d * Math.Cos(2.05705419118d + 77713.7714681205d * T);
            q = q + 0.00000006952d * Math.Cos(0.8267330541d + 775.522611324d * T);
            q = q + 0.00000005064d * Math.Cos(4.66284525271d + 1577.3435424478d * T);
            q = q + 0.00000004061d * Math.Cos(1.03057162962d + 7.1135470008d * T);
            q = q + 0.0000000381d * Math.Cos(3.4405080349d + 5573.1428014331d * T);
            q = q + 0.00000003463d * Math.Cos(5.14074632811d + 796.2980068164d * T);
            q = q + 0.00000003169d * Math.Cos(6.05291851171d + 5507.5532386674d * T);
            q = q + 0.0000000302d * Math.Cos(1.19246506441d + 242.728603974d * T);
            q = q + 0.00000002886d * Math.Cos(6.11652627155d + 529.6909650946d * T);
            q = q + 0.00000002714d * Math.Cos(0.30637881025d + 398.1490034082d * T);
            q = q + 0.00000002538d * Math.Cos(2.27992810679d + 553.5694028424d * T);
            q = q + 0.00000002371d * Math.Cos(4.38118838167d + 5223.6939198022d * T);
            q = q + 0.00000002079d * Math.Cos(3.75435330484d + 0.9803210682d * T);
            return q * T * T;
        }

        public static double Earth_L31(ref double T)
        {
            // L3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000289226d * Math.Cos(5.84384198723d + 6283.0758499914d * T);
            q = q + 0.00000034955d * Math.Cos(0d + 0d * T);
            q = q + 0.00000016819d * Math.Cos(5.48766912348d + 12566.1516999828d * T);
            q = q + 0.00000002962d * Math.Cos(5.19577265202d + 155.4203994342d * T);
            q = q + 0.00000001288d * Math.Cos(4.72200252235d + 3.523118349d * T);
            q = q + 0.00000000714d * Math.Cos(5.30045809128d + 18849.2275499742d * T);
            q = q + 0.00000000635d * Math.Cos(5.96925937141d + 242.728603974d * T);
            return q * T * T * T;
        }

        public static double Earth_L41(ref double T)
        {
            // L4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000114084d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000007717d * Math.Cos(4.13446589358d + 6283.0758499914d * T);
            q = q + 0.00000000765d * Math.Cos(3.83803776214d + 12566.1516999828d * T);
            return q * T * T * T * T;
        }

        public static double Earth_L51(ref double T)
        {
            // L5 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000000878d * Math.Cos(3.14159265359d + 0d * T);
            return q * T * T * T * T * T;
        }

        public static double Earth_B01(ref double T)
        {
            // B0 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.0000027962d * Math.Cos(3.19870156017d + 84334.6615813083d * T);
            q = q + 0.00000101643d * Math.Cos(5.42248619256d + 5507.5532386674d * T);
            q = q + 0.00000080445d * Math.Cos(3.88013204458d + 5223.6939198022d * T);
            q = q + 0.00000043806d * Math.Cos(3.70444689758d + 2352.8661537718d * T);
            q = q + 0.00000031933d * Math.Cos(4.00026369781d + 1577.3435424478d * T);
            return q * 1d;
        }

        public static double Earth_B11(ref double T)
        {
            // B1 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.0000000903d * Math.Cos(3.8972906189d + 5507.5532386674d * T);
            q = q + 0.00000006177d * Math.Cos(1.73038850355d + 5223.6939198022d * T);
            return q * T;
        }

        public static double Earth_B21(ref double T)
        {
            // B2 Segment #1 of 1
            double q = 0.0d;
            return q * T * T;
        }

        public static double Earth_B31(ref double T)
        {
            // B3 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T;
        }

        public static double Earth_B41(ref double T)
        {
            // B4 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T * T;
        }

        public static double Earth_R01(ref double T)
        {
            // R0 Segment #1 of 2
            double q = 0.0d;
            q = q + 1.00013988799d * Math.Cos(0d + 0d * T);
            q = q + 0.01670699626d * Math.Cos(3.09846350771d + 6283.0758499914d * T);
            q = q + 0.00013956023d * Math.Cos(3.0552460962d + 12566.1516999828d * T);
            q = q + 0.0000308372d * Math.Cos(5.19846674381d + 77713.7714681205d * T);
            q = q + 0.00001628461d * Math.Cos(1.17387749012d + 5753.3848848968d * T);
            q = q + 0.00001575568d * Math.Cos(2.84685245825d + 7860.4193924392d * T);
            q = q + 0.00000924799d * Math.Cos(5.45292234084d + 11506.7697697936d * T);
            q = q + 0.00000542444d * Math.Cos(4.56409149777d + 3930.2096962196d * T);
            q = q + 0.0000047211d * Math.Cos(3.66100022149d + 5884.9268465832d * T);
            q = q + 0.00000345983d * Math.Cos(0.96368617687d + 5507.5532386674d * T);
            q = q + 0.0000032878d * Math.Cos(5.89983646482d + 5223.6939198022d * T);
            q = q + 0.00000306784d * Math.Cos(0.29867139512d + 5573.1428014331d * T);
            q = q + 0.00000243189d * Math.Cos(4.27349536153d + 11790.6290886588d * T);
            q = q + 0.00000211829d * Math.Cos(5.84714540314d + 1577.3435424478d * T);
            q = q + 0.00000185752d * Math.Cos(5.02194447178d + 10977.078804699d * T);
            q = q + 0.00000174844d * Math.Cos(3.01193636534d + 18849.2275499742d * T);
            q = q + 0.00000109835d * Math.Cos(5.05510636285d + 5486.777843175d * T);
            q = q + 0.00000098316d * Math.Cos(0.88681311277d + 6069.7767545534d * T);
            q = q + 0.00000086499d * Math.Cos(5.68959778254d + 15720.8387848784d * T);
            q = q + 0.00000085825d * Math.Cos(1.27083733351d + 161000.685737674d * T);
            q = q + 0.00000064903d * Math.Cos(0.27250613787d + 17260.1546546904d * T);
            q = q + 0.00000062916d * Math.Cos(0.92177108832d + 529.6909650946d * T);
            q = q + 0.00000057056d * Math.Cos(2.01374292014d + 83996.8473181119d * T);
            q = q + 0.00000055736d * Math.Cos(5.24159798933d + 71430.6956181291d * T);
            q = q + 0.00000049384d * Math.Cos(3.24501240359d + 2544.3144198834d * T);
            q = q + 0.00000046963d * Math.Cos(2.57805070386d + 775.522611324d * T);
            q = q + 0.00000044661d * Math.Cos(5.53715807302d + 9437.762934887d * T);
            q = q + 0.00000042515d * Math.Cos(6.01110242003d + 6275.9623029906d * T);
            q = q + 0.00000038968d * Math.Cos(5.36071738169d + 4694.0029547076d * T);
            q = q + 0.00000038245d * Math.Cos(2.39255343974d + 8827.3902698748d * T);
            q = q + 0.0000003749d * Math.Cos(0.82952922332d + 19651.048481098d * T);
            q = q + 0.00000036957d * Math.Cos(4.90107591914d + 12139.5535091068d * T);
            q = q + 0.0000003566d * Math.Cos(1.67468058995d + 12036.4607348882d * T);
            q = q + 0.00000034537d * Math.Cos(1.84270693282d + 2942.4634232916d * T);
            q = q + 0.00000033193d * Math.Cos(0.24370300098d + 7084.8967811152d * T);
            q = q + 0.00000031921d * Math.Cos(0.18368229781d + 5088.6288397668d * T);
            q = q + 0.00000031846d * Math.Cos(1.77775642085d + 398.1490034082d * T);
            q = q + 0.00000028464d * Math.Cos(1.21344868176d + 6286.5989683404d * T);
            q = q + 0.00000027793d * Math.Cos(1.89934330904d + 6279.5527316424d * T);
            q = q + 0.00000026275d * Math.Cos(4.58896850401d + 10447.3878396044d * T);
            return q * 1d;
        }

        public static double Earth_R02(ref double T)
        {
            // R0 Segment #2 of 2
            double q = 0.0d;
            return q * 1d;
        }

        public static double Earth_R11(ref double T)
        {
            // R1 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00103018608d * Math.Cos(1.10748969588d + 6283.0758499914d * T);
            q = q + 0.00001721238d * Math.Cos(1.06442301418d + 12566.1516999828d * T);
            q = q + 0.00000702215d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000032346d * Math.Cos(1.02169059149d + 18849.2275499742d * T);
            q = q + 0.00000030799d * Math.Cos(2.84353804832d + 5507.5532386674d * T);
            q = q + 0.00000024971d * Math.Cos(1.31906709482d + 5223.6939198022d * T);
            q = q + 0.00000018485d * Math.Cos(1.42429748614d + 1577.3435424478d * T);
            q = q + 0.00000010078d * Math.Cos(5.91378194648d + 10977.078804699d * T);
            q = q + 0.00000008654d * Math.Cos(1.42046854427d + 6275.9623029906d * T);
            q = q + 0.00000008634d * Math.Cos(0.27146150602d + 5486.777843175d * T);
            return q * T;
        }

        public static double Earth_R21(ref double T)
        {
            // R2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00004359385d * Math.Cos(5.78455133738d + 6283.0758499914d * T);
            q = q + 0.00000123633d * Math.Cos(5.57934722157d + 12566.1516999828d * T);
            q = q + 0.00000012341d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000008792d * Math.Cos(3.62777733395d + 77713.7714681205d * T);
            q = q + 0.00000005689d * Math.Cos(1.86958905084d + 5573.1428014331d * T);
            q = q + 0.00000003301d * Math.Cos(5.47027913302d + 18849.2275499742d * T);
            return q * T * T;
        }

        public static double Earth_R31(ref double T)
        {
            // R3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000144595d * Math.Cos(4.27319435148d + 6283.0758499914d * T);
            q = q + 0.00000006729d * Math.Cos(3.91697608662d + 12566.1516999828d * T);
            return q * T * T * T;
        }

        public static double Earth_R41(ref double T)
        {
            // R4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000003858d * Math.Cos(2.56384387339d + 6283.0758499914d * T);
            return q * T * T * T * T;
        }

        public static double Earth_R51(ref double T)
        {
            // R5 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T * T * T;
        }
    }
}