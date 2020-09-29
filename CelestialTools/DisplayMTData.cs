using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class DisplayMTData
    {
        public DisplayMTData()
        {
            InitializeComponent();
            _btnExit.Name = "btnExit";
        }

        private void DisplayMTData_Load(object sender, EventArgs e)
        {
            string FName = "./Graphics/MeridianTransitData.csv";
            string tablename = "Export2";
            var SR = new System.IO.StreamReader(FName);
            string allData = SR.ReadToEnd();
            var rows = allData.Split(Conversions.ToChar(Constants.vbCrLf)); // ("\r".ToCharArray())
            int incr1 = 0;
            foreach (string r in rows)
            {
                if (incr1 > 0)
                {
                    var items = r.Split(',');
                    if ((items[0] ?? "") != Constants.vbLf)
                    {
                        var DT = Convert.ToDateTime(items[2]);
                        items[0] = CnvtToDeg(items[0].ToString());
                        items[1] = CnvtToDeg(items[1].ToString());
                        items[3] = CnvtTime(items[3].ToString());
                        items[4] = CnvtEQT(items[4].ToString());
                        items[5] = CnvtDec(items[5].ToString());
                        // items(6) = CnvtHo(items(6).ToString)
                        DataSet2.Tables[tablename].Rows.Add(items);
                    }
                }

                incr1 += 1;
            }
            // DataGridView1.DataSource = DataSet2.Tables(0).DefaultView
            DataGridView1.Refresh();
            SR.Close();
            SR.Dispose();
            Refresh();
            // DisplayAnalema()
            return;
        }

        private string CnvtToDeg(object StrIn)
        {
            string NSEW = StrIn.ToString().Substring(StrIn.ToString().Length - 1, 1);
            string Str2 = StrIn.ToString().Substring(0, StrIn.ToString().Length - 1); // remove N/S on Lat and E/W on Long as last character
            double Tmp = Convert.ToDouble(Str2);
            int TmpDeg = (int)Conversion.Int(Tmp);
            double TmpMin = (Tmp - TmpDeg) * 60d;
            return TmpDeg.ToString("##0") + '°' + " " + TmpMin.ToString("#0.0") + "'" + NSEW.ToString();
        }

        private string CnvtEQT(object StrIn)
        {
            string EqtSpeed = "";
            if (StrIn.ToString().Substring(0, 1) == "-")
            {
                EqtSpeed = " Slow";
            }
            else
            {
                EqtSpeed = " Fast";
            }

            string Str2 = StrIn.ToString().TrimStart('-');
            double Tmp = Convert.ToDouble(Str2);
            int TmpDeg = (int)Conversion.Int(Tmp);
            double TmpMin = (Tmp - TmpDeg) * 60d;
            return TmpDeg.ToString("00") + ":" + TmpMin.ToString("00") + EqtSpeed;
        }

        private string CnvtDec(object StrIn)
        {
            string NSEW = "";
            if (StrIn.ToString().Substring(0, 1) == "-")
            {
                NSEW = " S";
            }
            else
            {
                NSEW = " N";
            }

            string Str2 = StrIn.ToString().TrimStart('-');
            double Tmp = Convert.ToDouble(Str2);
            int TmpDeg = (int)Conversion.Int(Tmp);
            double TmpMin = (Tmp - TmpDeg) * 60d;
            return TmpDeg.ToString("##0") + '°' + " " + TmpMin.ToString("#0.0") + "'" + NSEW.ToString();
        }

        private string CnvtHo(object StrIn)
        {
            string Str2 = StrIn.ToString();
            double Tmp = Convert.ToDouble(Str2);
            int TmpDeg = (int)Conversion.Int(Tmp);
            double TmpMin = (Tmp - TmpDeg) * 60d;
            return TmpDeg.ToString("##0") + '°' + " " + TmpMin.ToString("#0.0") + "'";
        }

        private string CnvtTime(object StrIn)
        {
            return StrIn.ToString().Substring(0, 2) + ":" + StrIn.ToString().Substring(2, 2) + ":" + StrIn.ToString().Substring(4, 2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}