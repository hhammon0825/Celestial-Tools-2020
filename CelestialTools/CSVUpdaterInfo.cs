using System;

namespace CelestialTools
{
    public partial class CSVUpdaterInfo
    {
        public CSVUpdaterInfo()
        {
            InitializeComponent();
            _btnInfoExit.Name = "btnInfoExit";
        }

        private void btnInfoExit_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }
    }
}