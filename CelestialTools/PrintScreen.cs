using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;

namespace CelestialTools
{
    static class Print_Renamed
    {
        private static PrintDocument _PrtDoc;

        private static PrintDocument PrtDoc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrtDoc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrtDoc != null)
                {
                    _PrtDoc.PrintPage -= PrtDoc_PrintPage;
                }

                _PrtDoc = value;
                if (_PrtDoc != null)
                {
                    _PrtDoc.PrintPage += PrtDoc_PrintPage;
                }
            }
        }

        private static PrintDocument PrtDocTxt;
        private static string PrtFileName = "./PrtScn.jpg";
        private static Font printFont;
        private static System.IO.StreamReader streamToPrint;
        private static PrintDialog PrintDialog1;
        private static int StreamSize = 0;

        public static void PrintScreen(string FileName)
        {
            PrintDialog1 = new PrintDialog();
            PrintDialog1.UseEXDialog = true;
            PrintDialog1.AllowPrintToFile = false;
            PrintDialog1.AllowCurrentPage = false;
            PrintDialog1.AllowSelection = false;
            PrintDialog1.AllowSomePages = false;
            PrtDoc = new PrintDocument();
            PrtDoc.PrintPage += PrtDoc_PrintPage;
            Bitmap capture;
            Graphics graph;
            capture = (Bitmap)Image.FromFile(FileName);
            graph = Graphics.FromImage(capture);
            if (My.MyProject.Computer.FileSystem.FileExists(PrtFileName))
            {
                My.MyProject.Computer.FileSystem.DeleteFile(PrtFileName);
            }

            capture.Save(PrtFileName);
            PrtDoc.DocumentName = PrtFileName;
            PrintDialog1.Document = PrtDoc;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrtDoc.Print();
            }

            capture.Dispose();
            PrintDialog1.Dispose();
            PrtDoc.Dispose();
            return;
        }

        public static void PrintScreen(Rect ScrBounds)
        {
            PrintDialog1 = new PrintDialog();
            PrintDialog1.UseEXDialog = true;
            PrintDialog1.AllowPrintToFile = false;
            PrintDialog1.AllowCurrentPage = false;
            PrintDialog1.AllowSelection = false;
            PrintDialog1.AllowSomePages = false;
            PrtDoc = new PrintDocument();
            PrtDoc.PrintPage += PrtDoc_PrintPage;
            var area = ScrBounds;
            Bitmap capture;
            Graphics graph;
            // area = ScrBounds
            capture = new Bitmap((int)area.Width, (int)area.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graph = Graphics.FromImage(capture);
            graph.CopyFromScreen((int)area.X, (int)area.Y, 0, 0, new System.Drawing.Size((int)area.Width, (int)area.Height), CopyPixelOperation.SourceCopy);
            if (My.MyProject.Computer.FileSystem.FileExists(PrtFileName))
            {
                My.MyProject.Computer.FileSystem.DeleteFile(PrtFileName);
            }

            capture.Save(PrtFileName);
            PrtDoc.DocumentName = PrtFileName;
            PrintDialog1.Document = PrtDoc;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrtDoc.Print();
            }

            capture.Dispose();
            PrintDialog1.Dispose();
            PrtDoc.Dispose();
            return;
        }

        public static void PrintScreen(Rectangle ScrBounds)
        {
            PrintDialog1 = new PrintDialog();
            PrintDialog1.UseEXDialog = true;
            PrintDialog1.AllowPrintToFile = false;
            PrintDialog1.AllowCurrentPage = false;
            PrintDialog1.AllowSelection = false;
            PrintDialog1.AllowSomePages = false;
            PrtDoc = new PrintDocument();
            PrtDoc.PrintPage += PrtDoc_PrintPage;

            // Dim area As Rectangle
            Bitmap capture;
            Graphics graph;
            // area = ScrBounds
            capture = new Bitmap(ScrBounds.Width, ScrBounds.Height); // System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(capture);
            graph.Clip = new Region(ScrBounds);
            graph.CopyFromScreen(ScrBounds.X, ScrBounds.Y, 0, 0, ScrBounds.Size); // CopyPixelOperation.SourceCopy)
            if (My.MyProject.Computer.FileSystem.FileExists(PrtFileName))
            {
                My.MyProject.Computer.FileSystem.DeleteFile(PrtFileName);
            }

            capture.Save(PrtFileName);
            PrtDoc.DocumentName = PrtFileName;
            PrintDialog1.Document = PrtDoc;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrtDoc.Print();
            }

            graph.Dispose();
            capture.Dispose();
            PrintDialog1.Dispose();
            PrtDoc.Dispose();
            return;
        }

        private static void PrtDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var img = Image.FromFile(PrtFileName);
            e.Graphics.DrawImage(img, 0, 0);
            img.Dispose();
            return;
        }

        public static void printTxtFile1(string FName)
        {
            PrintDialog1 = new PrintDialog();
            PrintDialog1.UseEXDialog = true;
            PrintDialog1.AllowPrintToFile = false;
            PrintDialog1.AllowCurrentPage = false;
            PrintDialog1.AllowSelection = false;
            PrintDialog1.AllowSomePages = false;
            printFont = new Font("Arial", 10f);
            var pd = new PrintDocument();
            pd.PrintPage += pd_PrintPage;
            pd.DocumentName = FName;
            PrintDialog1.Document = pd;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    streamToPrint = new System.IO.StreamReader(FName);
                    try
                    {
                        // printFont = New Font("Arial", 10)
                        // Dim pd As New PrintDocument()
                        // AddHandler pd.PrintPage, AddressOf pd_PrintPage
                        pd.Print();
                    }
                    finally
                    {
                        streamToPrint.Close();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                }
            }

            PrintDialog1.Dispose();
            pd.Dispose();
            return;
        }

        // The PrintPage event is raised for each page to be printed.
        private static void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0f;
            float yPos = 0f;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage)
            {
                line = streamToPrint.ReadLine();
                if (line is null)
                {
                    break;
                }

                yPos = topMargin + count * printFont.GetHeight(ev.Graphics);
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count += 1;
            }

            // If more lines exist, print another page.
            if (line is object)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }
    }
}