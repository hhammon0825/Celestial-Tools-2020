using System;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class DisplayEQTData
    {
        public DisplayEQTData()
        {
            InitializeComponent();
            _btnExit.Name = "btnExit";
        }

        public string AnalemaFileName = "./Graphics/AnalemaBitMapSave.jpg";

        private void DisplayEQTData_Load(object sender, EventArgs e)
        {
            string FName = "./Graphics/EQTData.csv";
            string tablename = "Export";
            // Dim DataSet As DataSet = New DataSet()
            // DataSet.Tables.Add(tablename)
            // DataSet.Tables(tablename).Columns.Add("Latitude")
            // DataSet.Tables(tablename).Columns.Add("Longitude")
            // DataSet.Tables(tablename).Columns.Add("LAN Date")
            // DataSet.Tables(tablename).Columns.Add("LAN Time")
            // DataSet.Tables(tablename).Columns.Add("EQT Factor")
            // DataSet.Tables(tablename).Columns.Add("Declination")
            // DataSet.Tables(tablename).Columns.Add("Calc Ho")
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
                        if (DT.Day == 1 | DT.Day == 15 | DT.Day == 30)
                        {
                            items[0] = CnvtToDeg(items[0].ToString());
                            items[1] = CnvtToDeg(items[1].ToString());
                            items[3] = CnvtTime(items[3].ToString());
                            items[4] = CnvtEQT(items[4].ToString());
                            items[5] = CnvtDec(items[5].ToString());
                            items[6] = CnvtHo(items[6].ToString());
                            DataSet1.Tables[tablename].Rows.Add(items);
                        }
                    }
                }

                incr1 += 1;
            }

            DataGridView1.DataSource = DataSet1.Tables[0].DefaultView;
            SR.Close();
            SR.Dispose();
            Refresh();
            DisplayAnalema();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void DisplayAnalema()
        {
            var AnalemaCenter = new Point((int)(pbAnalema.Location.X + pbAnalema.Width / 2d), (int)(pbAnalema.Location.Y + pbAnalema.Height / 2d));
            Graphics AnalemaGraphic;
            Bitmap bm;
            int DrawWidth = (int)(pbAnalema.Width / 2d - 20d);
            bm = new Bitmap(pbAnalema.Width, pbAnalema.Height);
            AnalemaGraphic = Graphics.FromImage(bm);
            AnalemaGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            AnalemaGraphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            AnalemaGraphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            AnalemaGraphic.TranslateTransform((float)(pbAnalema.Width / 2d), (float)(pbAnalema.Height / 2d));
            var FontA = new Font("Arial", 7f, FontStyle.Regular);
            var FontB = new Font("Arial", 8f, FontStyle.Bold);
            var tmpDate = Convert.ToDateTime(My.MyProject.Forms.FormNoonSight.EqtTable[0].EqTimeDate);
            int tmpYear = tmpDate.Year;
            var DPen = new Pen(Color.Black, 1f);
            var BPen = new Pen(Color.Blue, 1f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new Point();
            var ptB = new Point();
            ptA.X = -DrawWidth - 10;
            ptA.Y = -DrawWidth - 10;
            AnalemaGraphic.DrawString("Analema Graph drawn" + Constants.vbCrLf + "for Latitude: " + CnvtToDeg(My.MyProject.Forms.FormNoonSight.EqtTable[0].EqtLat.ToString()) + Constants.vbCrLf + "and Longitude: " + CnvtToDeg(My.MyProject.Forms.FormNoonSight.EqtTable[0].EqtLong.ToString()) + Constants.vbCrLf + "for calendar year: " + tmpYear.ToString("0000"), FontB, Brushes.Black, ptA);
            ptA.X = -DrawWidth;
            ptA.Y = 0;
            ptB.X = DrawWidth;
            ptB.Y = 0;
            AnalemaGraphic.DrawLine(DPen, ptA, ptB);
            ptA.Y = -30;
            ptB.Y = -30;
            ptB.X = ptB.X - 40;
            AnalemaGraphic.DrawString("Eqt Slow", FontA, Brushes.Blue, ptA);
            AnalemaGraphic.DrawString("Eqt Fast", FontA, Brushes.Blue, ptB);
            int OneinPixels = (int)(DrawWidth / 25d);
            ptA.Y = -DrawWidth;
            ptA.X = 0;
            ptB.Y = DrawWidth;
            ptB.X = 0;
            AnalemaGraphic.DrawLine(DPen, ptA, ptB);
            ptA.Y = -DrawWidth - 15;
            ptA.X = -30;
            ptB.Y = DrawWidth + 5;
            ptB.X = -30;
            AnalemaGraphic.DrawString("South Declination", FontA, Brushes.Blue, ptA);
            AnalemaGraphic.DrawString("North Declination", FontA, Brushes.Blue, ptB);
            // first draw the quadrnat where x and y are positive
            ptA.X = 0;
            ptA.Y = 0;
            ptB.X = 0;
            ptB.Y = 0;
            for (int incr = 1; incr <= 24; incr += 1)
            {
                ptA.X = incr * OneinPixels;
                if (incr % 5 == 0)
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X, ptA.Y - 20));
                    AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, new Point(ptA.X, ptA.Y + 10));
                }
                else
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X, ptA.Y - 10));
                }
            }
            // draw the x and y axis with a tick mark every 5 to 10 counts
            ptA.X = 0;
            ptA.Y = 0;
            ptB.X = 0;
            ptB.Y = 0;
            for (int incr = -1; incr >= -24; incr -= 1)
            {
                ptA.X = incr * OneinPixels;
                if (incr % 5 == 0)
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X, ptA.Y - 20));
                    AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, new Point(ptA.X, ptA.Y + 10));
                }
                else
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X, ptA.Y - 10));
                }
            }

            ptA.X = 0;
            ptA.Y = 0;
            ptB.X = 0;
            ptB.Y = 0;
            for (int incr = 1; incr <= 24; incr += 1)
            {
                ptA.Y = incr * OneinPixels;
                if (incr % 5 == 0)
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X - 20, ptA.Y));
                    AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, new Point(ptA.X + 10, ptA.Y));
                }
                else
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X - 10, ptA.Y));
                }
            }

            ptA.X = 0;
            ptA.Y = 0;
            ptB.X = 0;
            ptB.Y = 0;
            for (int incr = -1; incr >= -24; incr -= 1)
            {
                ptA.Y = incr * OneinPixels;
                if (incr % 5 == 0)
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X - 20, ptA.Y));
                    AnalemaGraphic.DrawString(incr.ToString("#0"), FontA, Brushes.Blue, new Point(ptA.X + 10, ptA.Y));
                }
                else
                {
                    AnalemaGraphic.DrawLine(DPen, ptA, new Point(ptA.X - 10, ptA.Y));
                }
            }
            // new draw the Eqt Analema data on the graphed x and y axis'
            int Limit = Information.UBound(My.MyProject.Forms.FormNoonSight.EqtTable);
            for (int incr = 0, loopTo = Limit - 2; incr <= loopTo; incr += 1)
            {
                var ptx = new Point((int)(Conversions.ToDouble(My.MyProject.Forms.FormNoonSight.EqtTable[incr].EqTimeFactor) * OneinPixels), (int)(Conversions.ToDouble(My.MyProject.Forms.FormNoonSight.EqtTable[incr].EqTimeDec) * OneinPixels));
                var TDate = Convert.ToDateTime(My.MyProject.Forms.FormNoonSight.EqtTable[incr].EqTimeDate);
                if (TDate.Day == 1 | TDate.Day == 15)
                {
                    AnalemaGraphic.DrawEllipse(BPen, new Rectangle(ptx.X - 6, ptx.Y - 6, 6, 6));
                    AnalemaGraphic.FillEllipse(Brushes.Blue, new Rectangle(ptx.X - 6, ptx.Y - 6, 6, 6));
                }
                else
                {
                    AnalemaGraphic.DrawEllipse(DPen, new Rectangle(ptx.X - 2, ptx.Y - 2, 2, 2));
                    AnalemaGraphic.FillEllipse(Brushes.LawnGreen, new Rectangle(ptx.X - 2, ptx.Y - 2, 2, 2));
                }

                string strDtTm = "On " + My.MyProject.Forms.FormNoonSight.EqtTable[incr].EqTimeDate + Constants.vbCrLf + "LAN=" + CnvtTime(My.MyProject.Forms.FormNoonSight.EqtTable[incr].EqTZTLAN.ToString()) + " Ho=" + CnvtHo(My.MyProject.Forms.FormNoonSight.EqtTable[incr].EqTimeHo.ToString()) + '°';
                int strlen = (int)(strDtTm.Length / 2d * 6d);
                if (TDate.Day == 1 | TDate.Day == 15)
                {
                    if (TDate.Month == 6 & TDate.Day == 15)
                    {
                        AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X + 8, ptx.Y - 4);
                    }
                    else if (ptx.X > 0)
                    {
                        if (ptx.Y > 0)
                        {
                            AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X + 8, ptx.Y - 8);
                        }
                        else
                        {
                            AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X + 8, ptx.Y - 8);
                        }
                    }
                    else if (ptx.Y > 0)
                    {
                        AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X - strlen, ptx.Y - 8);
                    }
                    else
                    {
                        AnalemaGraphic.DrawString(strDtTm, FontB, Brushes.DarkBlue, ptx.X - strlen, ptx.Y - 8);
                    }
                }
            }

            if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(AnalemaFileName))
            {
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(AnalemaFileName);
            }

            bm.Save(AnalemaFileName);
            pbAnalema.ImageLocation = AnalemaFileName;
            pbAnalema.Visible = true;
            pbAnalema.Refresh();
            DPen.Dispose();
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
    }
}