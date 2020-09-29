using System;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    static class JupiterFunctions
    {
        public static double Jupiter_L01(ref double T)
        {
            // L0 Segment #1 of 2
            double q = 0.0d;
            q = q + 0.59954691495d * Math.Cos(0d + 0d * T);
            q = q + 0.09695898711d * Math.Cos(5.06191793105d + 529.6909650946d * T);
            q = q + 0.00573610145d * Math.Cos(1.44406205976d + 7.1135470008d * T);
            q = q + 0.0030638918d * Math.Cos(5.41734729976d + 1059.3819301892d * T);
            q = q + 0.0009717828d * Math.Cos(4.14264708819d + 632.7837393132d * T);
            q = q + 0.00072903096d * Math.Cos(3.64042909255d + 522.5774180938d * T);
            q = q + 0.00064263986d * Math.Cos(3.41145185203d + 103.0927742186d * T);
            q = q + 0.00039806051d * Math.Cos(2.29376744855d + 419.4846438752d * T);
            q = q + 0.0003885778d * Math.Cos(1.2723172486d + 316.3918696566d * T);
            q = q + 0.00027964622d * Math.Cos(1.78454589485d + 536.8045120954d * T);
            q = q + 0.00013589738d * Math.Cos(5.7748103159d + 1589.0728952838d * T);
            q = q + 0.00008768686d * Math.Cos(3.63000324417d + 949.1756089698d * T);
            q = q + 0.00008246362d * Math.Cos(3.58227961655d + 206.1855484372d * T);
            q = q + 0.00007368057d * Math.Cos(5.08101125612d + 735.8765135318d * T);
            q = q + 0.00006263171d * Math.Cos(0.02497643742d + 213.299095438d * T);
            q = q + 0.0000611405d * Math.Cos(4.51319531666d + 1162.4747044078d * T);
            q = q + 0.00005305457d * Math.Cos(4.18625053495d + 1052.2683831884d * T);
            q = q + 0.00005305283d * Math.Cos(1.30671236848d + 14.2270940016d * T);
            q = q + 0.00004905419d * Math.Cos(1.32084631684d + 110.2063212194d * T);
            q = q + 0.00004647249d * Math.Cos(4.69958109497d + 3.9321532631d * T);
            q = q + 0.00003045009d * Math.Cos(4.31675960318d + 426.598190876d * T);
            q = q + 0.00002610001d * Math.Cos(1.5666759485d + 846.0828347512d * T);
            q = q + 0.00002028191d * Math.Cos(1.06376547379d + 3.1813937377d * T);
            q = q + 0.00001920959d * Math.Cos(0.97168928755d + 639.897286314d * T);
            q = q + 0.00001764768d * Math.Cos(2.14148077766d + 1066.49547719d * T);
            q = q + 0.00001722983d * Math.Cos(3.88036008872d + 1265.5674786264d * T);
            q = q + 0.00001633217d * Math.Cos(3.58201089758d + 515.463871093d * T);
            q = q + 0.00001431997d * Math.Cos(4.29683690269d + 625.6701923124d * T);
            q = q + 0.00000973278d * Math.Cos(4.09764957065d + 95.9792272178d * T);
            q = q + 0.00000884439d * Math.Cos(2.43701426123d + 412.3710968744d * T);
            q = q + 0.00000732875d * Math.Cos(6.08534113239d + 838.9692877504d * T);
            q = q + 0.00000731072d * Math.Cos(3.80591233956d + 1581.959348283d * T);
            q = q + 0.0000070919d * Math.Cos(1.29272573658d + 742.9900605326d * T);
            q = q + 0.00000691928d * Math.Cos(6.13368222939d + 2118.7638603784d * T);
            q = q + 0.00000614464d * Math.Cos(4.10853496756d + 1478.8665740644d * T);
            q = q + 0.00000581902d * Math.Cos(4.53967717552d + 309.2783226558d * T);
            q = q + 0.00000495224d * Math.Cos(3.75567461379d + 323.5054166574d * T);
            q = q + 0.00000440854d * Math.Cos(2.95818460943d + 454.9093665273d * T);
            q = q + 0.00000417266d * Math.Cos(1.03554430161d + 2.4476805548d * T);
            q = q + 0.00000389864d * Math.Cos(4.89716105852d + 1692.1656695024d * T);
            q = q + 0.00000375657d * Math.Cos(4.70299124833d + 1368.660252845d * T);
            q = q + 0.00000341006d * Math.Cos(5.71452525783d + 533.6231183577d * T);
            q = q + 0.00000330458d * Math.Cos(4.74049819491d + 0.0481841098d * T);
            q = q + 0.0000026154d * Math.Cos(1.87652461032d + 0.9632078465d * T);
            q = q + 0.00000261009d * Math.Cos(0.82047246448d + 380.12776796d * T);
            q = q + 0.00000256568d * Math.Cos(3.72410724159d + 199.0720014364d * T);
            q = q + 0.0000024417d * Math.Cos(5.220208789d + 728.762966531d * T);
            q = q + 0.00000235141d * Math.Cos(1.22693908124d + 909.8187330546d * T);
            q = q + 0.00000220382d * Math.Cos(1.65115015995d + 543.9180590962d * T);
            q = q + 0.00000207327d * Math.Cos(1.85461666594d + 525.7588118315d * T);
            q = q + 0.00000201996d * Math.Cos(1.80684574186d + 1375.7737998458d * T);
            q = q + 0.00000197046d * Math.Cos(5.29252149016d + 1155.361157407d * T);
            q = q + 0.00000175191d * Math.Cos(3.72966554761d + 942.062061969d * T);
            q = q + 0.00000175184d * Math.Cos(3.22634903433d + 1898.3512179396d * T);
            q = q + 0.00000174809d * Math.Cos(5.90973505276d + 956.2891559706d * T);
            q = q + 0.00000157909d * Math.Cos(4.36483921766d + 1795.258443721d * T);
            q = q + 0.00000150502d * Math.Cos(3.90625022622d + 74.7815985673d * T);
            q = q + 0.00000149368d * Math.Cos(4.37745104275d + 1685.0521225016d * T);
            q = q + 0.00000141445d * Math.Cos(3.13568357861d + 491.5579294568d * T);
            q = q + 0.00000137871d * Math.Cos(1.31797920785d + 1169.5882514086d * T);
            q = q + 0.00000130531d * Math.Cos(4.16867945489d + 1045.1548361876d * T);
            q = q + 0.00000117495d * Math.Cos(2.5002214089d + 1596.1864422846d * T);
            q = q + 0.00000116757d * Math.Cos(3.38920921041d + 0.5212648618d * T);
            q = q + 0.00000105895d * Math.Cos(4.55439798236d + 526.5095713569d * T);
            return q * 1d;
        }

        public static double Jupiter_L02(ref double T)
        {
            // L0 Segment #2 of 2
            double q = 0.0d;
            // q = 0#
            return q * 1d;
        }

        public static double Jupiter_L11(ref double T)
        {
            // L1 Segment #1 of 1
            double q = 0.0d;
            // q = 0#
            q = q + 529.93480757497d * Math.Cos(0d + 0d * T);
            q = q + 0.00489741194d * Math.Cos(4.22066689928d + 529.6909650946d * T);
            q = q + 0.00228918538d * Math.Cos(6.02647464016d + 7.1135470008d * T);
            q = q + 0.0002765538d * Math.Cos(4.57265956824d + 1059.3819301892d * T);
            q = q + 0.00020720943d * Math.Cos(5.45938936295d + 522.5774180938d * T);
            q = q + 0.00012105732d * Math.Cos(0.16985765041d + 536.8045120954d * T);
            q = q + 0.00006068051d * Math.Cos(4.42419502005d + 103.0927742186d * T);
            q = q + 0.00005433924d * Math.Cos(3.98478382565d + 419.4846438752d * T);
            q = q + 0.00004237795d * Math.Cos(5.89009351271d + 14.2270940016d * T);
            q = q + 0.00002211854d * Math.Cos(5.26771446618d + 206.1855484372d * T);
            q = q + 0.00001745919d * Math.Cos(4.92669378486d + 1589.0728952838d * T);
            q = q + 0.00001295769d * Math.Cos(5.55132765087d + 3.1813937377d * T);
            q = q + 0.00001173129d * Math.Cos(5.8564730435d + 1052.2683831884d * T);
            q = q + 0.00001163411d * Math.Cos(0.51450895328d + 3.9321532631d * T);
            q = q + 0.00001098735d * Math.Cos(5.30704981594d + 515.463871093d * T);
            q = q + 0.00001007216d * Math.Cos(0.46478398551d + 735.8765135318d * T);
            q = q + 0.00001003574d * Math.Cos(3.15040301822d + 426.598190876d * T);
            q = q + 0.00000847678d * Math.Cos(5.7580585045d + 110.2063212194d * T);
            q = q + 0.00000827329d * Math.Cos(4.80312015734d + 213.299095438d * T);
            q = q + 0.00000816397d * Math.Cos(0.58643054886d + 1066.49547719d * T);
            q = q + 0.00000725447d * Math.Cos(5.51827471473d + 639.897286314d * T);
            q = q + 0.00000567845d * Math.Cos(5.98867049451d + 625.6701923124d * T);
            q = q + 0.00000474181d * Math.Cos(4.13245269168d + 412.3710968744d * T);
            q = q + 0.0000041293d * Math.Cos(5.73652891261d + 95.9792272178d * T);
            q = q + 0.00000345249d * Math.Cos(4.2415956541d + 632.7837393132d * T);
            q = q + 0.00000335817d * Math.Cos(3.73248749046d + 1162.4747044078d * T);
            q = q + 0.0000023434d * Math.Cos(4.03469970332d + 949.1756089698d * T);
            q = q + 0.00000234066d * Math.Cos(6.24302226646d + 309.2783226558d * T);
            q = q + 0.00000198525d * Math.Cos(1.50458442825d + 838.9692877504d * T);
            q = q + 0.00000194784d * Math.Cos(2.21879010911d + 323.5054166574d * T);
            q = q + 0.00000186899d * Math.Cos(6.08620565908d + 742.9900605326d * T);
            q = q + 0.00000183938d * Math.Cos(6.27963588822d + 543.9180590962d * T);
            q = q + 0.0000017138d * Math.Cos(5.41655983845d + 199.0720014364d * T);
            q = q + 0.00000130771d * Math.Cos(0.62643377351d + 728.762966531d * T);
            q = q + 0.00000115393d * Math.Cos(0.68019050174d + 846.0828347512d * T);
            q = q + 0.00000115047d * Math.Cos(5.28641699144d + 2118.7638603784d * T);
            q = q + 0.00000107575d * Math.Cos(4.49282760117d + 956.2891559706d * T);
            q = q + 0.00000079686d * Math.Cos(5.82412400273d + 1045.1548361876d * T);
            q = q + 0.00000071643d * Math.Cos(5.34162650321d + 942.062061969d * T);
            q = q + 0.00000069618d * Math.Cos(5.97263450278d + 532.8723588323d * T);
            q = q + 0.00000066824d * Math.Cos(5.73365126533d + 21.3406410024d * T);
            q = q + 0.00000065635d * Math.Cos(0.1292419143d + 526.5095713569d * T);
            q = q + 0.0000006485d * Math.Cos(6.08803490288d + 1581.959348283d * T);
            q = q + 0.00000058509d * Math.Cos(0.58626971028d + 1155.361157407d * T);
            q = q + 0.00000057939d * Math.Cos(0.99453087342d + 1596.1864422846d * T);
            q = q + 0.00000057368d * Math.Cos(5.96851304799d + 1169.5882514086d * T);
            q = q + 0.000000566d * Math.Cos(1.41198438841d + 533.6231183577d * T);
            q = q + 0.00000054935d * Math.Cos(5.42806383723d + 10.2949407385d * T);
            q = q + 0.00000052309d * Math.Cos(5.72661448388d + 117.3198682202d * T);
            q = q + 0.00000052016d * Math.Cos(0.22981299129d + 1368.660252845d * T);
            q = q + 0.00000050418d * Math.Cos(6.08075147811d + 525.7588118315d * T);
            q = q + 0.00000047418d * Math.Cos(3.62611843241d + 1478.8665740644d * T);
            q = q + 0.00000046678d * Math.Cos(0.51144073175d + 1265.5674786264d * T);
            q = q + 0.00000039888d * Math.Cos(4.161580136d + 1692.1656695024d * T);
            q = q + 0.00000033558d * Math.Cos(0.09913904872d + 302.164775655d * T);
            q = q + 0.00000032827d * Math.Cos(5.03596689455d + 220.4126424388d * T);
            q = q + 0.00000032449d * Math.Cos(5.37492530697d + 508.3503240922d * T);
            q = q + 0.00000029483d * Math.Cos(5.42208897099d + 1272.6810256272d * T);
            q = q + 0.00000029379d * Math.Cos(3.35927241533d + 4.665866446d * T);
            q = q + 0.00000029307d * Math.Cos(0.75907909735d + 88.865680217d * T);
            q = q + 0.00000025195d * Math.Cos(1.60723063387d + 831.8557407496d * T);
            return q * T;
        }

        public static double Jupiter_L21(ref double T)
        {
            // L2 Segment #1 of 1
            double q = 0.0d;
            // q = 0#
            q = q + 0.00047233598d * Math.Cos(4.32148323554d + 7.1135470008d * T);
            q = q + 0.0003896555d * Math.Cos(0d + 0d * T);
            q = q + 0.00030629053d * Math.Cos(2.93021440216d + 529.6909650946d * T);
            q = q + 0.00003189317d * Math.Cos(1.05504615595d + 522.5774180938d * T);
            q = q + 0.00002729292d * Math.Cos(4.84545481351d + 536.8045120954d * T);
            q = q + 0.00002723358d * Math.Cos(3.41411526638d + 1059.3819301892d * T);
            q = q + 0.00001721069d * Math.Cos(4.18734385158d + 14.2270940016d * T);
            q = q + 0.00000383258d * Math.Cos(5.76790714387d + 419.4846438752d * T);
            q = q + 0.00000377524d * Math.Cos(0.76048964872d + 515.463871093d * T);
            q = q + 0.00000367498d * Math.Cos(6.05509120409d + 103.0927742186d * T);
            q = q + 0.00000337386d * Math.Cos(3.78644384244d + 3.1813937377d * T);
            q = q + 0.000003082d * Math.Cos(0.69356654052d + 206.1855484372d * T);
            q = q + 0.00000218408d * Math.Cos(3.81389191353d + 1589.0728952838d * T);
            q = q + 0.00000198883d * Math.Cos(5.33996443444d + 1066.49547719d * T);
            q = q + 0.00000197445d * Math.Cos(2.48356402053d + 3.9321532631d * T);
            q = q + 0.00000155862d * Math.Cos(1.40642426467d + 1052.2683831884d * T);
            q = q + 0.0000014623d * Math.Cos(3.81373196838d + 639.897286314d * T);
            q = q + 0.00000141932d * Math.Cos(1.63435169016d + 426.598190876d * T);
            q = q + 0.0000012957d * Math.Cos(5.83738872525d + 412.3710968744d * T);
            q = q + 0.00000117327d * Math.Cos(1.41435462588d + 625.6701923124d * T);
            q = q + 0.00000096733d * Math.Cos(4.03383427887d + 110.2063212194d * T);
            q = q + 0.00000090823d * Math.Cos(1.10630629042d + 95.9792272178d * T);
            q = q + 0.00000087292d * Math.Cos(2.52235174825d + 632.7837393132d * T);
            q = q + 0.00000078769d * Math.Cos(4.63726131329d + 543.9180590962d * T);
            q = q + 0.00000072392d * Math.Cos(2.21716670026d + 735.8765135318d * T);
            q = q + 0.00000058475d * Math.Cos(0.83216317444d + 199.0720014364d * T);
            q = q + 0.0000005691d * Math.Cos(3.12292059854d + 213.299095438d * T);
            q = q + 0.00000048622d * Math.Cos(1.67283791618d + 309.2783226558d * T);
            q = q + 0.0000004015d * Math.Cos(4.0248544474d + 21.3406410024d * T);
            q = q + 0.00000039784d * Math.Cos(0.62416945827d + 323.5054166574d * T);
            q = q + 0.00000035718d * Math.Cos(2.32581247002d + 728.762966531d * T);
            q = q + 0.00000029255d * Math.Cos(3.60838327799d + 10.2949407385d * T);
            q = q + 0.00000027814d * Math.Cos(3.23992013743d + 838.9692877504d * T);
            q = q + 0.00000025993d * Math.Cos(4.5011829829d + 742.9900605326d * T);
            q = q + 0.0000002562d * Math.Cos(2.51240623862d + 1162.4747044078d * T);
            q = q + 0.00000025194d * Math.Cos(1.21868110687d + 1045.1548361876d * T);
            q = q + 0.00000023591d * Math.Cos(3.00532139306d + 956.2891559706d * T);
            q = q + 0.00000019458d * Math.Cos(4.29028644674d + 532.8723588323d * T);
            q = q + 0.0000001766d * Math.Cos(0.8095394156d + 508.3503240922d * T);
            q = q + 0.00000017058d * Math.Cos(4.20001977723d + 2118.7638603784d * T);
            q = q + 0.0000001704d * Math.Cos(1.8340214664d + 526.5095713569d * T);
            q = q + 0.00000015355d * Math.Cos(5.81037986941d + 1596.1864422846d * T);
            q = q + 0.00000015292d * Math.Cos(0.68174165476d + 942.062061969d * T);
            q = q + 0.00000014661d * Math.Cos(3.99989622586d + 117.3198682202d * T);
            q = q + 0.0000001392d * Math.Cos(5.95169568482d + 316.3918696566d * T);
            q = q + 0.00000013639d * Math.Cos(1.80336677963d + 302.164775655d * T);
            q = q + 0.0000001323d * Math.Cos(2.51856643603d + 88.865680217d * T);
            q = q + 0.00000012756d * Math.Cos(4.36856232414d + 1169.5882514086d * T);
            q = q + 0.00000010986d * Math.Cos(4.43586634639d + 525.7588118315d * T);
            q = q + 0.00000009681d * Math.Cos(1.71563161051d + 1581.959348283d * T);
            q = q + 0.00000009437d * Math.Cos(2.17684563456d + 1155.361157407d * T);
            q = q + 0.00000008812d * Math.Cos(3.29452783338d + 220.4126424388d * T);
            q = q + 0.0000000869d * Math.Cos(3.31924493607d + 831.8557407496d * T);
            q = q + 0.00000007823d * Math.Cos(5.75672228354d + 846.0828347512d * T);
            q = q + 0.00000007549d * Math.Cos(2.70955516779d + 533.6231183577d * T);
            q = q + 0.00000006685d * Math.Cos(2.17560093281d + 1265.5674786264d * T);
            q = q + 0.00000006285d * Math.Cos(0.49939863541d + 949.1756089698d * T);
            return q * T * T;
        }

        public static double Jupiter_L31(ref double T)
        {
            // L3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00006501665d * Math.Cos(2.59862880482d + 7.1135470008d * T);
            q = q + 0.00001356524d * Math.Cos(1.34635886411d + 529.6909650946d * T);
            q = q + 0.00000470716d * Math.Cos(2.47503977883d + 14.2270940016d * T);
            q = q + 0.0000041696d * Math.Cos(3.24451243214d + 536.8045120954d * T);
            q = q + 0.00000352851d * Math.Cos(2.97360159003d + 522.5774180938d * T);
            q = q + 0.0000015488d * Math.Cos(2.07565585817d + 1059.3819301892d * T);
            q = q + 0.00000086771d * Math.Cos(2.51431584316d + 515.463871093d * T);
            q = q + 0.00000044378d * Math.Cos(0d + 0d * T);
            q = q + 0.00000033538d * Math.Cos(3.82633794497d + 1066.49547719d * T);
            q = q + 0.00000028457d * Math.Cos(2.44754756058d + 206.1855484372d * T);
            q = q + 0.00000023737d * Math.Cos(1.27667172313d + 412.3710968744d * T);
            q = q + 0.00000022644d * Math.Cos(2.98231326774d + 543.9180590962d * T);
            q = q + 0.00000019798d * Math.Cos(2.10099934005d + 639.897286314d * T);
            q = q + 0.0000001974d * Math.Cos(1.40255938973d + 419.4846438752d * T);
            q = q + 0.00000018768d * Math.Cos(1.593684035d + 103.0927742186d * T);
            q = q + 0.00000017033d * Math.Cos(2.30214681202d + 21.3406410024d * T);
            q = q + 0.00000016774d * Math.Cos(2.59821460673d + 1589.0728952838d * T);
            q = q + 0.00000016214d * Math.Cos(3.14521117299d + 625.6701923124d * T);
            q = q + 0.00000016055d * Math.Cos(3.36030126297d + 1052.2683831884d * T);
            q = q + 0.00000013392d * Math.Cos(2.75973892202d + 95.9792272178d * T);
            q = q + 0.00000013234d * Math.Cos(2.5386224434d + 199.0720014364d * T);
            q = q + 0.00000012611d * Math.Cos(6.265781104d + 426.598190876d * T);
            q = q + 0.00000008701d * Math.Cos(1.76334960737d + 10.2949407385d * T);
            q = q + 0.00000008637d * Math.Cos(2.26563256289d + 110.2063212194d * T);
            q = q + 0.00000006725d * Math.Cos(3.42566433316d + 309.2783226558d * T);
            q = q + 0.00000006527d * Math.Cos(4.03869562907d + 728.762966531d * T);
            q = q + 0.00000005675d * Math.Cos(2.52096417685d + 508.3503240922d * T);
            q = q + 0.00000005399d * Math.Cos(2.91184687105d + 1045.1548361876d * T);
            q = q + 0.00000005368d * Math.Cos(5.25196153539d + 323.5054166574d * T);
            q = q + 0.00000003996d * Math.Cos(4.30290261177d + 88.865680217d * T);
            q = q + 0.00000003857d * Math.Cos(3.52381361552d + 302.164775655d * T);
            q = q + 0.00000003774d * Math.Cos(4.09125315146d + 735.8765135318d * T);
            q = q + 0.00000003269d * Math.Cos(1.43175991274d + 956.2891559706d * T);
            q = q + 0.00000002783d * Math.Cos(4.3581750767d + 1596.1864422846d * T);
            q = q + 0.00000002661d * Math.Cos(1.25276590759d + 213.299095438d * T);
            q = q + 0.00000002656d * Math.Cos(5.01505839848d + 838.9692877504d * T);
            q = q + 0.00000002553d * Math.Cos(2.23785673285d + 117.3198682202d * T);
            q = q + 0.00000002371d * Math.Cos(2.89662409244d + 742.9900605326d * T);
            q = q + 0.00000002279d * Math.Cos(2.3558187123d + 942.062061969d * T);
            return q * T * T * T;
        }

        public static double Jupiter_L41(ref double T)
        {
            // L4 Segment #1 of 1
            double q = 0.0d;
            // q = 0#
            q = q + 0.00000669483d * Math.Cos(0.8528242109d + 7.1135470008d * T);
            q = q + 0.00000114019d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000099961d * Math.Cos(0.74258947751d + 14.2270940016d * T);
            q = q + 0.00000050024d * Math.Cos(1.65346208248d + 536.8045120954d * T);
            q = q + 0.00000043585d * Math.Cos(5.82026386621d + 529.6909650946d * T);
            q = q + 0.00000031813d * Math.Cos(4.8582998665d + 522.5774180938d * T);
            q = q + 0.00000014742d * Math.Cos(4.29061635784d + 515.463871093d * T);
            q = q + 0.00000008899d * Math.Cos(0.71478520741d + 1059.3819301892d * T);
            q = q + 0.00000004957d * Math.Cos(1.29502259434d + 543.9180590962d * T);
            q = q + 0.00000004484d * Math.Cos(2.31715516627d + 1066.49547719d * T);
            q = q + 0.00000004251d * Math.Cos(0.48326797501d + 21.3406410024d * T);
            q = q + 0.000000031d * Math.Cos(3.00245542678d + 412.3710968744d * T);
            q = q + 0.00000002055d * Math.Cos(0.39858940218d + 639.897286314d * T);
            q = q + 0.00000001902d * Math.Cos(4.25925620271d + 199.0720014364d * T);
            q = q + 0.00000001762d * Math.Cos(4.90536207307d + 625.6701923124d * T);
            q = q + 0.00000001695d * Math.Cos(4.26147580803d + 206.1855484372d * T);
            q = q + 0.00000001375d * Math.Cos(5.25546955667d + 1052.2683831884d * T);
            q = q + 0.00000001203d * Math.Cos(4.71614633845d + 95.9792272178d * T);
            q = q + 0.00000001086d * Math.Cos(1.28604571172d + 1589.0728952838d * T);
            return q * T * T * T * T;
        }
        // ************************
        public static object Jupiter_L51(ref object T)
        {
            object Jupiter_L51Ret = default;
            // L5 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00000049577d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.25658966184d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000015761d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.25126837478d, Operators.MultiplyObject(14.2270940016d, T)))));
            q = Operators.AddObject(q, 0.00000004343d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.01461869263d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000001526d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.09739911439d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00000000845d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.14159265359d, Operators.MultiplyObject(0, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L51. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_L51Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T), T), T);
            return Jupiter_L51Ret;
        }
        // ************************
        public static object Jupiter_B01(ref object T)
        {
            object Jupiter_B01Ret = default;
            // B0 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.02268615703d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.55852606718d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00110090358d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.00109971634d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.90809347389d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00008101427d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.60509573368d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00006437782d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.30627121409d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00006043996d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.25883108794d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.0000110688d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.98534421928d, Operators.MultiplyObject(1162.4747044078d, T)))));
            q = Operators.AddObject(q, 0.00000944328d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.67522288396d, Operators.MultiplyObject(426.598190876d, T)))));
            q = Operators.AddObject(q, 0.00000941651d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.93619072405d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000894088d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.75447429921d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000835861d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.17881973234d, Operators.MultiplyObject(103.0927742186d, T)))));
            q = Operators.AddObject(q, 0.0000076728d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.1547359406d, Operators.MultiplyObject(632.7837393132d, T)))));
            q = Operators.AddObject(q, 0.0000068422d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.67808770098d, Operators.MultiplyObject(213.299095438d, T)))));
            q = Operators.AddObject(q, 0.00000629223d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.64343282328d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000558524d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.01354830508d, Operators.MultiplyObject(846.0828347512d, T)))));
            q = Operators.AddObject(q, 0.0000053167d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.70305954352d, Operators.MultiplyObject(110.2063212194d, T)))));
            q = Operators.AddObject(q, 0.00000464449d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.17337249185d, Operators.MultiplyObject(949.1756089698d, T)))));
            q = Operators.AddObject(q, 0.00000431072d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.60825000494d, Operators.MultiplyObject(419.4846438752d, T)))));
            q = Operators.AddObject(q, 0.00000351433d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.61062990714d, Operators.MultiplyObject(2118.7638603784d, T)))));
            q = Operators.AddObject(q, 0.0000013216d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.7781699067d, Operators.MultiplyObject(742.9900605326d, T)))));
            q = Operators.AddObject(q, 0.00000123148d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.34968181384d, Operators.MultiplyObject(1692.1656695024d, T)))));
            q = Operators.AddObject(q, 0.00000116379d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.38688232033d, Operators.MultiplyObject(323.5054166574d, T)))));
            q = Operators.AddObject(q, 0.00000115038d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.04892295442d, Operators.MultiplyObject(316.3918696566d, T)))));
            q = Operators.AddObject(q, 0.00000103762d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.7010383811d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000103402d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.31878999565d, Operators.MultiplyObject(1478.8665740644d, T)))));
            q = Operators.AddObject(q, 0.0000010242d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.15293785436d, Operators.MultiplyObject(1581.959348283d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B01. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_B01Ret = Operators.MultiplyObject(q, 1);
            return Jupiter_B01Ret;
        }
        // ************************
        public static object Jupiter_B11(ref object T)
        {
            object Jupiter_B11Ret = default;
            // B1 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00177351787d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.70166488486d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00003230171d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.7794161934d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00003081364d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.47464296527d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00002211914d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.73477480209d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00001694232d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.14159265359d, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.00000346445d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.74595174109d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000234264d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.18856099929d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000196154d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.18554286642d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000150468d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.92721226087d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.00000114128d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.4389727183d, Operators.MultiplyObject(632.7837393132d, T)))));
            q = Operators.AddObject(q, 0.00000096667d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.9142630409d, Operators.MultiplyObject(949.1756089698d, T)))));
            q = Operators.AddObject(q, 0.00000081671d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.07666097497d, Operators.MultiplyObject(1162.4747044078d, T)))));
            q = Operators.AddObject(q, 0.00000076599d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.50522188662d, Operators.MultiplyObject(103.0927742186d, T)))));
            q = Operators.AddObject(q, 0.00000076572d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.61288981445d, Operators.MultiplyObject(419.4846438752d, T)))));
            q = Operators.AddObject(q, 0.00000073875d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.49958292155d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000060544d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.44740084359d, Operators.MultiplyObject(213.299095438d, T)))));
            q = Operators.AddObject(q, 0.00000049915d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.94799616572d, Operators.MultiplyObject(735.8765135318d, T)))));
            q = Operators.AddObject(q, 0.00000046032d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.53850360901d, Operators.MultiplyObject(110.2063212194d, T)))));
            q = Operators.AddObject(q, 0.00000045123d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.89516645239d, Operators.MultiplyObject(846.0828347512d, T)))));
            q = Operators.AddObject(q, 0.00000036561d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.69828392839d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000036019d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.10952578764d, Operators.MultiplyObject(316.3918696566d, T)))));
            q = Operators.AddObject(q, 0.00000031975d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.92452714629d, Operators.MultiplyObject(1581.959348283d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B11. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_B11Ret = Operators.MultiplyObject(q, T);
            return Jupiter_B11Ret;
        }
        // ************************
        public static object Jupiter_B21(ref object T)
        {
            object Jupiter_B21Ret = default;
            // B2 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00008094051d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.46322843658d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00000813244d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.14159265359d, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.00000742415d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.95691639003d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00000398951d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.89888666447d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000342226d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.44683789727d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00000073948d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.40724675866d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000046151d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.48036895772d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000029717d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.92504171329d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.00000029314d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.99088831805d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000022753d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.27124052435d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000013916d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.92242387338d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000012067d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.22168932482d, Operators.MultiplyObject(632.7837393132d, T)))));
            q = Operators.AddObject(q, 0.00000010703d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.88024222475d, Operators.MultiplyObject(949.1756089698d, T)))));
            q = Operators.AddObject(q, 0.00000006078d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.21089108431d, Operators.MultiplyObject(1045.1548361876d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B21. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_B21Ret = Operators.MultiplyObject(Operators.MultiplyObject(q, T), T);
            return Jupiter_B21Ret;
        }
        // ************************
        public static object Jupiter_B31(ref object T)
        {
            object Jupiter_B31Ret = default;
            // B3 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00000251624d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.38087923084d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00000121738d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.733118372d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00000048694d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.03689996685d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000010988d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.31463561347d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000008067d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.76729757621d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000007287d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.25268318975d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00000006205d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.7811582737d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000003627d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.13028917221d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000002798d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.14159265359d, Operators.MultiplyObject(0, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B31. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_B31Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T);
            return Jupiter_B31Ret;
        }
        // ************************
        public static object Jupiter_B41(ref object T)
        {
            object Jupiter_B41Ret = default;
            // B4 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.0000001505d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.52956999637d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.0000000537d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.47427159142d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00000004456d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.43908581047d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000003422d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.00000001833d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.51807036227d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000001322d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.20117611581d, Operators.MultiplyObject(1052.2683831884d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B41. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_B41Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T), T);
            return Jupiter_B41Ret;
        }
        // ************************
        public static object Jupiter_B51(ref object T)
        {
            object Jupiter_B51Ret = default;
            // B5 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00000001445d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.09198554072d, Operators.MultiplyObject(522.5774180938d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B51. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_B51Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T), T), T);
            return Jupiter_B51Ret;
        }
        // ************************
        public static object Jupiter_R01(ref object T)
        {
            object Jupiter_R01Ret = default;
            // R0 Segment #1 of 2
            object q;
            q = 0d;
            q = Operators.AddObject(q, 5.20887429471d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.2520932702d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.49108640015d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00610599902d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.84115365602d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00282029465d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.57419879933d, Operators.MultiplyObject(632.7837393132d, T)))));
            q = Operators.AddObject(q, 0.00187647391d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.07590380082d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00086792941d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.71001090609d, Operators.MultiplyObject(419.4846438752d, T)))));
            q = Operators.AddObject(q, 0.00072062869d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.21465694745d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00065517227d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.97995850843d, Operators.MultiplyObject(316.3918696566d, T)))));
            q = Operators.AddObject(q, 0.00030135275d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.16132058449d, Operators.MultiplyObject(949.1756089698d, T)))));
            q = Operators.AddObject(q, 0.0002913462d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.6775924371d, Operators.MultiplyObject(103.0927742186d, T)))));
            q = Operators.AddObject(q, 0.0002394734d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.27457854894d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00023453209d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.54023147303d, Operators.MultiplyObject(735.8765135318d, T)))));
            q = Operators.AddObject(q, 0.0002228371d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.19362773546d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.000130326d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.96043055741d, Operators.MultiplyObject(1162.4747044078d, T)))));
            q = Operators.AddObject(q, 0.00012749004d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.71550102862d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00009703346d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.90669572402d, Operators.MultiplyObject(206.1855484372d, T)))));
            q = Operators.AddObject(q, 0.00009161431d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.41352618935d, Operators.MultiplyObject(213.299095438d, T)))));
            q = Operators.AddObject(q, 0.00007894539d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.47907551404d, Operators.MultiplyObject(426.598190876d, T)))));
            q = Operators.AddObject(q, 0.00007057978d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.18184753111d, Operators.MultiplyObject(1265.5674786264d, T)))));
            q = Operators.AddObject(q, 0.00006137755d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.26417542514d, Operators.MultiplyObject(846.0828347512d, T)))));
            q = Operators.AddObject(q, 0.00005477093d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.65729325169d, Operators.MultiplyObject(639.897286314d, T)))));
            q = Operators.AddObject(q, 0.00004170012d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.01605033912d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.0000413689d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.72219979684d, Operators.MultiplyObject(625.6701923124d, T)))));
            q = Operators.AddObject(q, 0.00003502519d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.56531297394d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00002616955d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.00993967129d, Operators.MultiplyObject(1581.959348283d, T)))));
            q = Operators.AddObject(q, 0.00002499966d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.55182055941d, Operators.MultiplyObject(838.9692877504d, T)))));
            q = Operators.AddObject(q, 0.00002127644d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.1275146175d, Operators.MultiplyObject(742.9900605326d, T)))));
            q = Operators.AddObject(q, 0.00001911876d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.85621927419d, Operators.MultiplyObject(412.3710968744d, T)))));
            q = Operators.AddObject(q, 0.00001610549d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.08867789275d, Operators.MultiplyObject(1368.660252845d, T)))));
            q = Operators.AddObject(q, 0.00001479484d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.68026191372d, Operators.MultiplyObject(1478.8665740644d, T)))));
            q = Operators.AddObject(q, 0.00001230708d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.89042979701d, Operators.MultiplyObject(323.5054166574d, T)))));
            q = Operators.AddObject(q, 0.0000121681d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.80171561024d, Operators.MultiplyObject(110.2063212194d, T)))));
            q = Operators.AddObject(q, 0.00001014959d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.38673237666d, Operators.MultiplyObject(454.9093665273d, T)))));
            q = Operators.AddObject(q, 0.00000998579d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.8720894011d, Operators.MultiplyObject(309.2783226558d, T)))));
            q = Operators.AddObject(q, 0.00000961072d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.54876989805d, Operators.MultiplyObject(2118.7638603784d, T)))));
            q = Operators.AddObject(q, 0.00000885708d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.14785948471d, Operators.MultiplyObject(533.6231183577d, T)))));
            q = Operators.AddObject(q, 0.00000821465d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.59342534396d, Operators.MultiplyObject(1898.3512179396d, T)))));
            q = Operators.AddObject(q, 0.00000812036d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.94091899141d, Operators.MultiplyObject(909.8187330546d, T)))));
            q = Operators.AddObject(q, 0.000007767d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.6769695469d, Operators.MultiplyObject(728.762966531d, T)))));
            q = Operators.AddObject(q, 0.00000727162d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.98824686402d, Operators.MultiplyObject(1155.361157407d, T)))));
            q = Operators.AddObject(q, 0.00000655289d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.79065604219d, Operators.MultiplyObject(1685.0521225016d, T)))));
            q = Operators.AddObject(q, 0.00000653981d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.38150775269d, Operators.MultiplyObject(1692.1656695024d, T)))));
            q = Operators.AddObject(q, 0.00000620798d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.82284338962d, Operators.MultiplyObject(956.2891559706d, T)))));
            q = Operators.AddObject(q, 0.00000614784d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.27624915604d, Operators.MultiplyObject(942.062061969d, T)))));
            q = Operators.AddObject(q, 0.0000056212d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.08095987241d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000542221d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.28360266386d, Operators.MultiplyObject(525.7588118315d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R01. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R01Ret = Operators.MultiplyObject(q, 1);
            return Jupiter_R01Ret;
        }
        // ************************
        public static object Jupiter_R02(ref object T)
        {
            object Jupiter_R02Ret = default;
            // R0 Segment #2 of 2
            object q;
            q = 0d;
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R02. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R02Ret = Operators.MultiplyObject(q, 1);
            return Jupiter_R02Ret;
        }
        // ************************
        public static object Jupiter_R11(ref object T)
        {
            object Jupiter_R11Ret = default;
            // R1 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.01271801596d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.64937511122d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00061661771d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.00076251018d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00053443592d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.89717644226d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00041390257d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.00031185167d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.88276663526d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.0001184719d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.41329588176d, Operators.MultiplyObject(419.4846438752d, T)))));
            q = Operators.AddObject(q, 0.0000916636d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.75979408587d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00003403605d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.34688537997d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.00003203446d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.21083285476d, Operators.MultiplyObject(735.8765135318d, T)))));
            q = Operators.AddObject(q, 0.00003175763d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.79297987071d, Operators.MultiplyObject(103.0927742186d, T)))));
            q = Operators.AddObject(q, 0.00002806064d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.7422369358d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00002676575d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.33052878699d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00002600003d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.63435101622d, Operators.MultiplyObject(206.1855484372d, T)))));
            q = Operators.AddObject(q, 0.00002412207d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.46947308304d, Operators.MultiplyObject(426.598190876d, T)))));
            q = Operators.AddObject(q, 0.00002100507d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.92762682306d, Operators.MultiplyObject(639.897286314d, T)))));
            q = Operators.AddObject(q, 0.00001646182d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.30953510947d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00001641257d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.41628669824d, Operators.MultiplyObject(625.6701923124d, T)))));
            q = Operators.AddObject(q, 0.00001049866d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.16113622955d, Operators.MultiplyObject(213.299095438d, T)))));
            q = Operators.AddObject(q, 0.00001024802d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.55432643018d, Operators.MultiplyObject(412.3710968744d, T)))));
            q = Operators.AddObject(q, 0.00000806404d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.6775080138d, Operators.MultiplyObject(632.7837393132d, T)))));
            q = Operators.AddObject(q, 0.00000740996d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.17094630558d, Operators.MultiplyObject(1162.4747044078d, T)))));
            q = Operators.AddObject(q, 0.00000676928d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.2495347979d, Operators.MultiplyObject(838.9692877504d, T)))));
            q = Operators.AddObject(q, 0.00000567076d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.57655414712d, Operators.MultiplyObject(742.9900605326d, T)))));
            q = Operators.AddObject(q, 0.00000484689d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.46882793186d, Operators.MultiplyObject(949.1756089698d, T)))));
            q = Operators.AddObject(q, 0.00000468895d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.70973463481d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000444683d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.40281181402d, Operators.MultiplyObject(323.5054166574d, T)))));
            q = Operators.AddObject(q, 0.00000415894d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.36836018215d, Operators.MultiplyObject(728.762966531d, T)))));
            q = Operators.AddObject(q, 0.00000401738d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.60528841541d, Operators.MultiplyObject(309.2783226558d, T)))));
            q = Operators.AddObject(q, 0.00000347378d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.68148808722d, Operators.MultiplyObject(14.2270940016d, T)))));
            q = Operators.AddObject(q, 0.00000337555d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.1678195112d, Operators.MultiplyObject(956.2891559706d, T)))));
            q = Operators.AddObject(q, 0.00000260753d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.34290306101d, Operators.MultiplyObject(846.0828347512d, T)))));
            q = Operators.AddObject(q, 0.00000246603d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.92313823537d, Operators.MultiplyObject(942.062061969d, T)))));
            q = Operators.AddObject(q, 0.00000220084d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.84210964963d, Operators.MultiplyObject(1368.660252845d, T)))));
            q = Operators.AddObject(q, 0.00000203217d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.59995425432d, Operators.MultiplyObject(1155.361157407d, T)))));
            q = Operators.AddObject(q, 0.0000020019d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.43888814441d, Operators.MultiplyObject(1045.1548361876d, T)))));
            q = Operators.AddObject(q, 0.00000197134d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.70551461394d, Operators.MultiplyObject(2118.7638603784d, T)))));
            q = Operators.AddObject(q, 0.00000196005d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.75877587139d, Operators.MultiplyObject(199.0720014364d, T)))));
            q = Operators.AddObject(q, 0.00000183504d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.26526769703d, Operators.MultiplyObject(95.9792272178d, T)))));
            q = Operators.AddObject(q, 0.00000180134d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.40165491159d, Operators.MultiplyObject(532.8723588323d, T)))));
            q = Operators.AddObject(q, 0.00000170225d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.84647488867d, Operators.MultiplyObject(526.5095713569d, T)))));
            q = Operators.AddObject(q, 0.00000146335d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.12958365535d, Operators.MultiplyObject(533.6231183577d, T)))));
            q = Operators.AddObject(q, 0.00000133483d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.32245735855d, Operators.MultiplyObject(110.2063212194d, T)))));
            q = Operators.AddObject(q, 0.00000132076d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.51187950811d, Operators.MultiplyObject(525.7588118315d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R11. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R11Ret = Operators.MultiplyObject(q, T);
            return Jupiter_R11Ret;
        }
        // ************************
        public static object Jupiter_R21(ref object T)
        {
            object Jupiter_R21Ret = default;
            // R2 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00079644833d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.35865896596d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00008251618d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.77773935444d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00007029864d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.27476965833d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00005314006d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.83835109712d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00001860833d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.97682139367d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000964466d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.48031822015d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000836267d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.19889881718d, Operators.MultiplyObject(419.4846438752d, T)))));
            q = Operators.AddObject(q, 0.0000049792d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.14159265359d, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.0000042657d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.22753101795d, Operators.MultiplyObject(639.897286314d, T)))));
            q = Operators.AddObject(q, 0.00000406453d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.78250730354d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000377316d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.24248352873d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.00000362943d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.36761847267d, Operators.MultiplyObject(206.1855484372d, T)))));
            q = Operators.AddObject(q, 0.00000342048d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.09922969324d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000339043d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.12690864038d, Operators.MultiplyObject(625.6701923124d, T)))));
            q = Operators.AddObject(q, 0.00000332578d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.00328961161d, Operators.MultiplyObject(426.598190876d, T)))));
            q = Operators.AddObject(q, 0.0000027992d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.26162555827d, Operators.MultiplyObject(412.3710968744d, T)))));
            q = Operators.AddObject(q, 0.0000025729d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.96295364983d, Operators.MultiplyObject(632.7837393132d, T)))));
            q = Operators.AddObject(q, 0.00000229777d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.70530766213d, Operators.MultiplyObject(735.8765135318d, T)))));
            q = Operators.AddObject(q, 0.00000200783d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.06850623368d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000199807d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.42884165317d, Operators.MultiplyObject(103.0927742186d, T)))));
            q = Operators.AddObject(q, 0.00000138606d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.93235671606d, Operators.MultiplyObject(14.2270940016d, T)))));
            q = Operators.AddObject(q, 0.00000113535d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.78713911289d, Operators.MultiplyObject(728.762966531d, T)))));
            q = Operators.AddObject(q, 0.00000094565d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.70498041073d, Operators.MultiplyObject(838.9692877504d, T)))));
            q = Operators.AddObject(q, 0.00000086025d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.14434751994d, Operators.MultiplyObject(323.5054166574d, T)))));
            q = Operators.AddObject(q, 0.00000083469d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.05834873484d, Operators.MultiplyObject(309.2783226558d, T)))));
            q = Operators.AddObject(q, 0.00000080328d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.98122361797d, Operators.MultiplyObject(742.9900605326d, T)))));
            q = Operators.AddObject(q, 0.00000075198d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.60495195911d, Operators.MultiplyObject(956.2891559706d, T)))));
            q = Operators.AddObject(q, 0.00000070451d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.50988357484d, Operators.MultiplyObject(213.299095438d, T)))));
            q = Operators.AddObject(q, 0.00000066572d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.47307178077d, Operators.MultiplyObject(199.0720014364d, T)))));
            q = Operators.AddObject(q, 0.00000061649d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.10137889854d, Operators.MultiplyObject(1045.1548361876d, T)))));
            q = Operators.AddObject(q, 0.00000056203d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.95534810533d, Operators.MultiplyObject(1162.4747044078d, T)))));
            q = Operators.AddObject(q, 0.00000051904d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.58435625607d, Operators.MultiplyObject(942.062061969d, T)))));
            q = Operators.AddObject(q, 0.00000050057d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.72063162317d, Operators.MultiplyObject(532.8723588323d, T)))));
            q = Operators.AddObject(q, 0.00000044548d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.52445621411d, Operators.MultiplyObject(508.3503240922d, T)))));
            q = Operators.AddObject(q, 0.00000044282d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.27118152557d, Operators.MultiplyObject(526.5095713569d, T)))));
            q = Operators.AddObject(q, 0.00000039833d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.94566506227d, Operators.MultiplyObject(95.9792272178d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R21. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R21Ret = Operators.MultiplyObject(Operators.MultiplyObject(q, T), T);
            return Jupiter_R21Ret;
        }
        // ************************
        public static object Jupiter_R31(ref object T)
        {
            object Jupiter_R31Ret = default;
            // R3 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00003519257d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.05800633846d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.00001073239d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.6732134576d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000915666d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.41329676116d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00000341593d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.52296542656d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00000254893d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.19625473533d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000221512d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.95225226237d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000089729d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.14159265359d, Operators.MultiplyObject(0, T)))));
            q = Operators.AddObject(q, 0.00000069078d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.26885282314d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000057827d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.41389745339d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000057653d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.52580117593d, Operators.MultiplyObject(639.897286314d, T)))));
            q = Operators.AddObject(q, 0.00000051079d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.98016364677d, Operators.MultiplyObject(412.3710968744d, T)))));
            q = Operators.AddObject(q, 0.00000046935d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.57864237959d, Operators.MultiplyObject(625.6701923124d, T)))));
            q = Operators.AddObject(q, 0.00000042824d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.11689609099d, Operators.MultiplyObject(419.4846438752d, T)))));
            q = Operators.AddObject(q, 0.00000037477d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.1826276233d, Operators.MultiplyObject(14.2270940016d, T)))));
            q = Operators.AddObject(q, 0.00000033816d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.66671706951d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000033531d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.84784977903d, Operators.MultiplyObject(206.1855484372d, T)))));
            q = Operators.AddObject(q, 0.00000031195d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.04290245896d, Operators.MultiplyObject(1589.0728952838d, T)))));
            q = Operators.AddObject(q, 0.00000030023d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.63236245032d, Operators.MultiplyObject(426.598190876d, T)))));
            q = Operators.AddObject(q, 0.00000020804d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.50071243814d, Operators.MultiplyObject(728.762966531d, T)))));
            q = Operators.AddObject(q, 0.00000015023d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.89136998434d, Operators.MultiplyObject(199.0720014364d, T)))));
            q = Operators.AddObject(q, 0.00000014466d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.96040197071d, Operators.MultiplyObject(508.3503240922d, T)))));
            q = Operators.AddObject(q, 0.00000012969d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.5023378855d, Operators.MultiplyObject(1045.1548361876d, T)))));
            q = Operators.AddObject(q, 0.00000012319d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.60952614503d, Operators.MultiplyObject(735.8765135318d, T)))));
            q = Operators.AddObject(q, 0.00000011654d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.55513510121d, Operators.MultiplyObject(323.5054166574d, T)))));
            q = Operators.AddObject(q, 0.0000001116d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.79041437555d, Operators.MultiplyObject(309.2783226558d, T)))));
            q = Operators.AddObject(q, 0.00000010554d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.27845112678d, Operators.MultiplyObject(956.2891559706d, T)))));
            q = Operators.AddObject(q, 0.00000009812d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.26016859519d, Operators.MultiplyObject(103.0927742186d, T)))));
            q = Operators.AddObject(q, 0.00000009301d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.45126812476d, Operators.MultiplyObject(838.9692877504d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R31. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R31Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T);
            return Jupiter_R31Ret;
        }
        // ************************
        public static object Jupiter_R41(ref object T)
        {
            object Jupiter_R41Ret = default;
            // R4 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00000128628d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.08419309557d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000113458d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.24858855779d, Operators.MultiplyObject(529.6909650946d, T)))));
            q = Operators.AddObject(q, 0.0000008265d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.29754909408d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00000037883d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.73326611144d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000026694d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.69142588558d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.0000001765d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.40012536918d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.00000012612d * Math.Cos(Conversions.ToDouble(Operators.AddObject(6.01560416057d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000009287d * Math.Cos(Conversions.ToDouble(Operators.AddObject(0.76813946494d, Operators.MultiplyObject(1066.49547719d, T)))));
            q = Operators.AddObject(q, 0.00000008107d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.68228065707d, Operators.MultiplyObject(14.2270940016d, T)))));
            q = Operators.AddObject(q, 0.00000006978d * Math.Cos(Conversions.ToDouble(Operators.AddObject(1.42751292055d, Operators.MultiplyObject(412.3710968744d, T)))));
            q = Operators.AddObject(q, 0.00000006271d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.12286932534d, Operators.MultiplyObject(639.897286314d, T)))));
            q = Operators.AddObject(q, 0.00000005377d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.33501947275d, Operators.MultiplyObject(625.6701923124d, T)))));
            q = Operators.AddObject(q, 0.00000002911d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.40334805052d, Operators.MultiplyObject(1052.2683831884d, T)))));
            q = Operators.AddObject(q, 0.00000002593d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.16090412984d, Operators.MultiplyObject(728.762966531d, T)))));
            q = Operators.AddObject(q, 0.00000002562d * Math.Cos(Conversions.ToDouble(Operators.AddObject(2.89802035072d, Operators.MultiplyObject(426.598190876d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R41. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R41Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T), T);
            return Jupiter_R41Ret;
        }
        // ************************
        public static object Jupiter_R51(ref object T)
        {
            object Jupiter_R51Ret = default;
            // R5 Segment #1 of 1
            object q;
            q = 0d;
            q = Operators.AddObject(q, 0.00000011188d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.75249399945d, Operators.MultiplyObject(536.8045120954d, T)))));
            q = Operators.AddObject(q, 0.00000004255d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.9151622917d, Operators.MultiplyObject(522.5774180938d, T)))));
            q = Operators.AddObject(q, 0.00000002079d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.56781555864d, Operators.MultiplyObject(515.463871093d, T)))));
            q = Operators.AddObject(q, 0.00000001908d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.29659647286d, Operators.MultiplyObject(543.9180590962d, T)))));
            q = Operators.AddObject(q, 0.00000001875d * Math.Cos(Conversions.ToDouble(Operators.AddObject(3.69357495838d, Operators.MultiplyObject(7.1135470008d, T)))));
            q = Operators.AddObject(q, 0.00000001612d * Math.Cos(Conversions.ToDouble(Operators.AddObject(4.13222808529d, Operators.MultiplyObject(1059.3819301892d, T)))));
            q = Operators.AddObject(q, 0.0000000159d * Math.Cos(Conversions.ToDouble(Operators.AddObject(5.49312796166d, Operators.MultiplyObject(1066.49547719d, T)))));
            // UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R51. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Jupiter_R51Ret = Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(q, T), T), T), T), T);
            return Jupiter_R51Ret;
        }
        // ************************
    }
}