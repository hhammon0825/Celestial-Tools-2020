using System;
using System.Linq;
using System.Windows.Forms;

namespace CelestialTools
{
    internal partial class MainMenu : Form
    {
        public readonly string latTemplate = "90º60.00'N";
        public readonly string lonTemplate = "180º60.00'E";
        public readonly string speedTemplate = "00.0kts";
        public readonly string rangeTemplate = "00.000nm";
        public readonly string rangeTemplateYds = "00000yds";
        public readonly string rangeTemplateMtrs = "00000m";
        public readonly string bearingTemplate = "360º";
        public readonly string inclinationTemplate = "00.0ºE";
        public readonly string timeTemplate = "000.0min";
        public readonly string minutesTemplate = "00min";
        public readonly string timeOfDayTemplate = "13:60:60.0AM";
        public readonly string shortTimeOfDayTemplate = "13:60:60AM";
        public readonly string timeOfDayTemplate24 = "24:60:60.0";
        public readonly string shortTimeOfDayTemplate24 = "24:60:60";

        // These are the shared variables between FormSRF SRF and FormAltSR SR methods and Meridian form
        public bool FormSRFFlagSRFLocNASR = false;
        public bool FormAltSRFlagSRFLocNASR = false;
        public bool FormSRFFlagMD = false;
        public bool FormAltSRFlagMD = false;
        public double FormSRFLat = 0d;
        public double FormSRFHc = 0d;
        public double FormSRFZN = 0d;
        public double FormSRFLHA = 0d;
        public double FormSRFTotDE = 0d;
        public double FormAltSRLat = 0d;
        public double FormAltSRHc = 0d;
        public double FormAltSRZN = 0d;
        public double FormAltSRLHA = 0d;
        public double FormAltSRDec = 0d;
        public double FormAltSRHtot = 0d;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // initialize common shared references and variable here
            // SFormMeridianDiag = New FormMeridianDiagram()

            return;
        }

        private void cmd60DST_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.Form60DST.Show();
            My.MyProject.Forms.Form60DST.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdAbout_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.frmAbout.Show();
            My.MyProject.Forms.frmAbout.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdArcTime_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormArcTime.Show();
            My.MyProject.Forms.FormArcTime.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdCPA_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormMoBoard.Show();
            My.MyProject.Forms.FormMoBoard.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdDistances_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormDistances.Show();
            My.MyProject.Forms.FormDistances.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdLengthDeg_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormLength.Show();
            My.MyProject.Forms.FormLength.SetDesktopLocation(5, 5); // 
        }

        private void cmdReduction_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormSRF.Show();
            My.MyProject.Forms.FormSRF.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdPlanning_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormSightPlan.Show();
            My.MyProject.Forms.FormSightPlan.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdNoon_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormNoonSight.Show();
            My.MyProject.Forms.FormNoonSight.SetDesktopLocation(5, 5); // 
            Show();
        }
        // Private Sub cmdSelectPrinter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // frmSelectPrinter.Show()
        // Me.Show()
        // End Sub
        private void cmdSailings_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormSailings.Show();
            My.MyProject.Forms.FormSailings.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdCTSSOA_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormCTSSOA.Show();
            My.MyProject.Forms.FormCTSSOA.SetDesktopLocation(5, 5); // 
        }

        private void cmdTVMDC_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormTVMDC.Show();
            My.MyProject.Forms.FormTVMDC.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdTwoBearings_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormTwoBearings.Show();
            My.MyProject.Forms.FormTwoBearings.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdYellow_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormIandC.Show();
            My.MyProject.Forms.FormIandC.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void MainMenu_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            cleanup();
            // Me.Close()
            return;
        }

        private void SRMethod_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormAltSR.Show();
            My.MyProject.Forms.FormAltSR.SetDesktopLocation(5, 5); // 
            Show();
        }
        // Private Sub cmdAveraging_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAveraging.Click
        // Form9.Show()
        // Me.Show()
        // End Sub
        private void cmdInterpolate_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormNavMath.Show();
            My.MyProject.Forms.FormNavMath.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdTides_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormTides.Show();
            My.MyProject.Forms.FormTides.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cmdCurrents_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FormCurrents.Show();
            My.MyProject.Forms.FormCurrents.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            cleanup();
            Close();
            return;
        }

        private void HelpV2Btn_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.HelpV2.Show();
            My.MyProject.Forms.HelpV2.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void btnSightLog_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SightLog.Show();
            My.MyProject.Forms.SightLog.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void btnFavLocs_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FavoriteLocations.Show();
            My.MyProject.Forms.FavoriteLocations.SetDesktopLocation(5, 5); // 
            Show();
        }

        private void cleanup()
        {
            // this sub moved from its own source code that was globally visible to thsi private sub only visible inside Menu. 
            // When this Menu form closes, it will exec this sub to see if any other forms are still open and close each
            // This sub should be exec'd if a user inappropriately uses the 'x' close button in the upper right corner instead of the Exit button

            if (Application.OpenForms.OfType<FormSRF>().Any())
            {
                My.MyProject.Forms.FormSRF.Close();  // SRF1
            }

            if (Application.OpenForms.OfType<FormSightPlan>().Any())
            {
                My.MyProject.Forms.FormSightPlan.Close();  // Plan1
            }

            if (Application.OpenForms.OfType<Form60DST>().Any())
            {
                My.MyProject.Forms.Form60DST.Close();  // 60DST
            }

            if (Application.OpenForms.OfType<frmAbout>().Any())
            {
                My.MyProject.Forms.frmAbout.Close();
            }

            if (Application.OpenForms.OfType<FormArcTime>().Any())
            {
                My.MyProject.Forms.FormArcTime.Close();  // ArcTime
            }

            if (Application.OpenForms.OfType<FormMoBoard>().Any())
            {
                My.MyProject.Forms.FormMoBoard.Close();  // CPA
            }

            if (Application.OpenForms.OfType<FormDistances>().Any())
            {
                My.MyProject.Forms.FormDistances.Close();  // Distances
            }

            if (Application.OpenForms.OfType<FormLength>().Any())
            {
                My.MyProject.Forms.FormLength.Close();  // Length of Deg
            }

            if (Application.OpenForms.OfType<FormNoonSight>().Any())
            {
                My.MyProject.Forms.FormNoonSight.Close();  // NoonSight
            }

            if (Application.OpenForms.OfType<FormSailings>().Any())
            {
                My.MyProject.Forms.FormSailings.Close();  // Sailings
            }

            if (Application.OpenForms.OfType<FormCTSSOA>().Any())
            {
                My.MyProject.Forms.FormCTSSOA.Close();   // CTS SOA
            }

            if (Application.OpenForms.OfType<FormTVMDC>().Any())
            {
                My.MyProject.Forms.FormTVMDC.Close();   // TVMDC 
            }

            if (Application.OpenForms.OfType<FormTwoBearings>().Any())
            {
                My.MyProject.Forms.FormTwoBearings.Close();   // 2 Bearings
            }

            if (Application.OpenForms.OfType<FormIandC>().Any())
            {
                My.MyProject.Forms.FormIandC.Close();   // Yellow
            }

            if (Application.OpenForms.OfType<FormAltSR>().Any())
            {
                My.MyProject.Forms.FormAltSR.Close();  // SRMethods
            }
            // If Application.OpenForms().OfType(Of Form9).Any Then
            // Form9.Close()  'Averaging
            // End If
            if (Application.OpenForms.OfType<FormNavMath>().Any())
            {
                My.MyProject.Forms.FormNavMath.Close();   // Interpolation
            }

            if (Application.OpenForms.OfType<FormTides>().Any())
            {
                My.MyProject.Forms.FormTides.Close();   // Tides
            }

            if (Application.OpenForms.OfType<FormCurrents>().Any())
            {
                My.MyProject.Forms.FormCurrents.Close();   // Currents
            }

            if (Application.OpenForms.OfType<HelpV2>().Any())
            {
                My.MyProject.Forms.HelpV2.Close();
            }

            if (Application.OpenForms.OfType<FormMeridianDiagram>().Any())
            {
                My.MyProject.Forms.FormMeridianDiagram.Close();
            }

            if (Application.OpenForms.OfType<CLSForm>().Any())
            {
                My.MyProject.Forms.CLSForm.Close();
            }

            if (Application.OpenForms.OfType<CustomPlot>().Any())
            {
                My.MyProject.Forms.CustomPlot.Close();
            }

            if (Application.OpenForms.OfType<FormMeridianDiagram>().Any()) // Meridian Diagram
            {
                My.MyProject.Forms.CustomPlot.Close();
            }

            if (Application.OpenForms.OfType<SightLog>().Any())
            {
                My.MyProject.Forms.SightLog.QuickExit();
                My.MyProject.Forms.SightLog.Close();
            }

            if (Application.OpenForms.OfType<FavoriteLocations>().Any())
            {
                My.MyProject.Forms.FavoriteLocations.QuickExit();
                My.MyProject.Forms.FavoriteLocations.Close();
            }

            if (Application.OpenForms.OfType<DeckLogUpdate>().Any())
            {
                My.MyProject.Forms.DeckLogUpdate.QuickExit();
                My.MyProject.Forms.DeckLogUpdate.Close();
            }

            if (Application.OpenForms.OfType<CSVUpdater>().Any())
            {
                My.MyProject.Forms.CSVUpdater.SaveDataGrid();
                My.MyProject.Forms.CSVUpdater.Close();
            }

            if (Application.OpenForms.OfType<DevForm>().Any())
            {
                My.MyProject.Forms.DevForm.SaveDevDataGrid();
                My.MyProject.Forms.DevForm.Close();
            }

            if (Application.OpenForms.OfType<SRFTimeDiagram>().Any())
            {
                My.MyProject.Forms.SRFTimeDiagram.Close();
            }

            if (Application.OpenForms.OfType<ZTInfo>().Any())
            {
                My.MyProject.Forms.SRFTimeDiagram.Close();
            }

            if (Application.OpenForms.OfType<TraverseTable>().Any())
            {
                My.MyProject.Forms.TraverseTable.Close();
            }

            return;
        }

        private void btnDeckLog_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DeckLogUpdate.Show();
            My.MyProject.Forms.DeckLogUpdate.SetDesktopLocation(5, 5); // 
            return;
        }

        private void btnCVSFile_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CSVUpdater.Show();
            My.MyProject.Forms.CSVUpdater.SetDesktopLocation(5, 5); // 
            return;
        }

        private void btnDevForm_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DevForm.Show();
            My.MyProject.Forms.DevForm.SetDesktopLocation(5, 5); // 
            return;
        }

        private void btnZoneTime_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ZTInfo.Show();
            My.MyProject.Forms.ZTInfo.SetDesktopLocation(5, 5); // 
            return;
        }

        private void btnTraverseTable_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TraverseTable.Show();
            My.MyProject.Forms.TraverseTable.SetDesktopLocation(5, 5); // 
            return;
        }
    }
}