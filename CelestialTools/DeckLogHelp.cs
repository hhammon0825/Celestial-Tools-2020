using System;

namespace CelestialTools
{
    public partial class DeckLogHelp
    {
        public DeckLogHelp()
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