using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CelestialTools
{
    internal partial class frmAbout : Form
    {
        private void cmdCredits_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.frmCredits.Show();
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            Close();
        }

        private void frmAbout_Load(object eventSender, EventArgs eventArgs)
        {
            // The project version information is set in Visual Studio 2019 by Automatic Version Tool VSIX loaded from the Microsoft VS Tools GetTools option
            // This VSIX tool should be loaded in your version of Visual Studio 2017 or 2019 and be set to update all project and file version info with MM - DD - YYYY - UTC HHMM
            lblVersion.Text = "Celestial Tools Version " + My.MyProject.Application.Info.Version.Major.ToString("00") + " - " + My.MyProject.Application.Info.Version.Minor.ToString("00") + " - " + My.MyProject.Application.Info.Version.Build.ToString("0000") + " - " + My.MyProject.Application.Info.Version.Revision.ToString("0000") + Constants.vbNewLine + ".NET Version:" + Environment.Version.ToString(); // Month of update
                                                                                                                                                                                                                                                                                                                                                                                                                      // Day of the Month of update
                                                                                                                                                                                                                                                                                                                                                                                                                      // Year of update
                                                                                                                                                                                                                                                                                                                                                                                                                      // UTC time HHMM of update
            lblTitle.Text = My.MyProject.Application.Info.Title;
        }

        private void frmAbout_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }
    }
}