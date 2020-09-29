using System;

namespace CelestialTools
{
    static class VenusFunctions
    {
        public static double Venus_L01(ref double T)
        {
            // L0 Segment #1 of 1
            double q = 0.0d;
            q = q + 3.17614666774d * Math.Cos(0d + 0d * T);
            q = q + 0.01353968419d * Math.Cos(5.59313319619d + 10213.285546211d * T);
            q = q + 0.00089891645d * Math.Cos(5.30650048468d + 20426.571092422d * T);
            q = q + 0.00005477201d * Math.Cos(4.41630652531d + 7860.4193924392d * T);
            q = q + 0.00003455732d * Math.Cos(2.69964470778d + 11790.6290886588d * T);
            q = q + 0.00002372061d * Math.Cos(2.99377539568d + 3930.2096962196d * T);
            q = q + 0.00001664069d * Math.Cos(4.2501893503d + 1577.3435424478d * T);
            q = q + 0.00001438322d * Math.Cos(4.15745043958d + 9683.5945811164d * T);
            q = q + 0.00001317108d * Math.Cos(5.18668219093d + 26.2983197998d * T);
            q = q + 0.00001200521d * Math.Cos(6.15357115319d + 30639.856638633d * T);
            q = q + 0.00000769314d * Math.Cos(0.81629615911d + 9437.762934887d * T);
            q = q + 0.0000076138d * Math.Cos(1.9501470212d + 529.6909650946d * T);
            q = q + 0.00000707676d * Math.Cos(1.06466707214d + 775.522611324d * T);
            q = q + 0.00000584836d * Math.Cos(3.99839884762d + 191.4482661116d * T);
            q = q + 0.00000499915d * Math.Cos(4.12340210074d + 15720.8387848784d * T);
            q = q + 0.00000429498d * Math.Cos(3.58642859752d + 19367.1891622328d * T);
            q = q + 0.00000326967d * Math.Cos(5.67736583705d + 5507.5532386674d * T);
            q = q + 0.00000326221d * Math.Cos(4.59056473097d + 10404.7338123226d * T);
            q = q + 0.00000231937d * Math.Cos(3.16251057072d + 9153.9036160218d * T);
            q = q + 0.00000179695d * Math.Cos(4.65337915578d + 1109.3785520934d * T);
            q = q + 0.00000155464d * Math.Cos(5.57043888948d + 19651.048481098d * T);
            q = q + 0.00000128263d * Math.Cos(4.22604493736d + 20.7753954924d * T);
            q = q + 0.00000127907d * Math.Cos(0.96209822685d + 5661.3320491522d * T);
            q = q + 0.00000105547d * Math.Cos(1.53721191253d + 801.8209311238d * T);
            return q * 1d;
        }

        public static double Venus_L11(ref double T)
        {
            // L1 Segment #1 of 1
            double q = 0.0d;
            q = q + 10213.529430529d * Math.Cos(0d + 0d * T);
            q = q + 0.00095707712d * Math.Cos(2.46424448979d + 10213.285546211d * T);
            q = q + 0.00014444977d * Math.Cos(0.51624564679d + 20426.571092422d * T);
            q = q + 0.00000213374d * Math.Cos(1.79547929368d + 30639.856638633d * T);
            q = q + 0.00000173904d * Math.Cos(2.65535879443d + 26.2983197998d * T);
            q = q + 0.00000151669d * Math.Cos(6.10635282369d + 1577.3435424478d * T);
            q = q + 0.00000082233d * Math.Cos(5.7023413373d + 191.4482661116d * T);
            q = q + 0.00000069734d * Math.Cos(2.68136034979d + 9437.762934887d * T);
            q = q + 0.00000052408d * Math.Cos(3.60013087656d + 775.522611324d * T);
            q = q + 0.00000038318d * Math.Cos(1.03379038025d + 529.6909650946d * T);
            q = q + 0.00000029633d * Math.Cos(1.25056322354d + 5507.5532386674d * T);
            q = q + 0.00000025056d * Math.Cos(6.10664792855d + 10404.7338123226d * T);
            return q * T;
        }

        public static double Venus_L21(ref double T)
        {
            // L2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00054127076d * Math.Cos(0d + 0d * T);
            q = q + 0.0000389146d * Math.Cos(0.34514360047d + 10213.285546211d * T);
            q = q + 0.0000133788d * Math.Cos(2.02011286082d + 20426.571092422d * T);
            q = q + 0.00000023836d * Math.Cos(2.04592119012d + 26.2983197998d * T);
            q = q + 0.00000019331d * Math.Cos(3.53527371458d + 30639.856638633d * T);
            q = q + 0.00000009984d * Math.Cos(3.97130221102d + 775.522611324d * T);
            q = q + 0.00000007046d * Math.Cos(1.51962593409d + 1577.3435424478d * T);
            q = q + 0.00000006014d * Math.Cos(0.99926757893d + 191.4482661116d * T);
            return q * T * T;
        }

        public static double Venus_L31(ref double T)
        {
            // L3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000135742d * Math.Cos(4.80389020993d + 10213.285546211d * T);
            q = q + 0.00000077846d * Math.Cos(3.66876371591d + 20426.571092422d * T);
            q = q + 0.00000026023d * Math.Cos(0d + 0d * T);
            return q * T * T * T;
        }

        public static double Venus_L41(ref double T)
        {
            // L4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000114016d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00000003209d * Math.Cos(5.20514170164d + 20426.571092422d * T);
            q = q + 0.00000001714d * Math.Cos(2.51099591706d + 10213.285546211d * T);
            return q * T * T * T * T;
        }

        public static double Venus_L51(ref double T)
        {
            // L5 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000000874d * Math.Cos(3.14159265359d + 0d * T);
            return q * T * T * T * T * T;
        }

        public static double Venus_B01(ref double T)
        {
            // B0 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.05923638472d * Math.Cos(0.26702775813d + 10213.285546211d * T);
            q = q + 0.00040107978d * Math.Cos(1.14737178106d + 20426.571092422d * T);
            q = q + 0.00032814918d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.00001011392d * Math.Cos(1.08946123021d + 30639.856638633d * T);
            q = q + 0.00000149458d * Math.Cos(6.25390296069d + 18073.7049386502d * T);
            q = q + 0.00000137788d * Math.Cos(0.86020146523d + 1577.3435424478d * T);
            q = q + 0.00000129973d * Math.Cos(3.67152483651d + 9437.762934887d * T);
            q = q + 0.00000119507d * Math.Cos(3.70468812804d + 2352.8661537718d * T);
            q = q + 0.00000107971d * Math.Cos(4.53903677647d + 22003.9146348698d * T);
            return q * 1d;
        }

        public static double Venus_B11(ref double T)
        {
            // B1 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00513347602d * Math.Cos(1.80364310797d + 10213.285546211d * T);
            q = q + 0.000043801d * Math.Cos(3.38615711591d + 20426.571092422d * T);
            q = q + 0.00000199162d * Math.Cos(0d + 0d * T);
            q = q + 0.00000196586d * Math.Cos(2.53001197486d + 30639.856638633d * T);
            return q * T;
        }

        public static double Venus_B21(ref double T)
        {
            // B2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00022377665d * Math.Cos(3.38509143877d + 10213.285546211d * T);
            q = q + 0.00000281739d * Math.Cos(0d + 0d * T);
            q = q + 0.00000173164d * Math.Cos(5.25563766915d + 20426.571092422d * T);
            q = q + 0.00000026945d * Math.Cos(3.87040891568d + 30639.856638633d * T);
            return q * T * T;
        }

        public static double Venus_B31(ref double T)
        {
            // B3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000646671d * Math.Cos(4.99166565277d + 10213.285546211d * T);
            q = q + 0.00000019952d * Math.Cos(3.14159265359d + 0d * T);
            q = q + 0.0000000554d * Math.Cos(0.77376923951d + 20426.571092422d * T);
            q = q + 0.00000002526d * Math.Cos(5.4449376302d + 30639.856638633d * T);
            return q * T * T * T;
        }

        public static double Venus_B41(ref double T)
        {
            // B4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000014102d * Math.Cos(0.31537190181d + 10213.285546211d * T);
            return q * T * T * T * T;
        }

        public static double Venus_B51(ref double T)
        {
            // B5 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T * T * T;
        }

        public static double Venus_R01(ref double T)
        {
            // R0 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.72334820905d * Math.Cos(0d + 0d * T);
            q = q + 0.00489824185d * Math.Cos(4.02151832268d + 10213.285546211d * T);
            q = q + 0.00001658058d * Math.Cos(4.90206728012d + 20426.571092422d * T);
            q = q + 0.00001632093d * Math.Cos(2.84548851892d + 7860.4193924392d * T);
            q = q + 0.00001378048d * Math.Cos(1.128465906d + 11790.6290886588d * T);
            q = q + 0.00000498399d * Math.Cos(2.58682187717d + 9683.5945811164d * T);
            q = q + 0.00000373958d * Math.Cos(1.42314837063d + 3930.2096962196d * T);
            q = q + 0.00000263616d * Math.Cos(5.5293818592d + 9437.762934887d * T);
            q = q + 0.00000237455d * Math.Cos(2.55135903978d + 15720.8387848784d * T);
            q = q + 0.00000221983d * Math.Cos(2.01346776772d + 19367.1891622328d * T);
            q = q + 0.00000125896d * Math.Cos(2.72769833559d + 1577.3435424478d * T);
            q = q + 0.00000119467d * Math.Cos(3.01975365264d + 10404.7338123226d * T);
            return q * 1d;
        }

        public static double Venus_R11(ref double T)
        {
            // R1 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00034551039d * Math.Cos(0.89198710598d + 10213.285546211d * T);
            q = q + 0.00000234203d * Math.Cos(1.77224942714d + 20426.571092422d * T);
            q = q + 0.00000233998d * Math.Cos(3.14159265359d + 0d * T);
            return q * T;
        }

        public static double Venus_R21(ref double T)
        {
            // R2 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00001406587d * Math.Cos(5.0636639519d + 10213.285546211d * T);
            q = q + 0.00000015529d * Math.Cos(5.47321687981d + 20426.571092422d * T);
            q = q + 0.00000013059d * Math.Cos(0d + 0d * T);
            return q * T * T;
        }

        public static double Venus_R31(ref double T)
        {
            // R3 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000049582d * Math.Cos(3.2226355452d + 10213.285546211d * T);
            return q * T * T * T;
        }

        public static double Venus_R41(ref double T)
        {
            // R4 Segment #1 of 1
            double q = 0.0d;
            q = q + 0.00000000573d * Math.Cos(0.9222969782d + 10213.285546211d * T);
            return q * T * T * T * T;
        }

        public static double Venus_R51(ref double T)
        {
            // R5 Segment #1 of 1
            double q = 0.0d;
            return q * T * T * T * T * T;
        }
    }
}