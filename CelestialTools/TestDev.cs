using System;

namespace CelestialTools
{
    public partial class TestDev
    {
        public TestDev()
        {
            InitializeComponent();
            _btnCompassDev.Name = "btnCompassDev";
            _btnMagDev.Name = "btnMagDev";
            _btnExit.Name = "btnExit";
        }

        private void btnCompassDev_Click(object sender, EventArgs e)
        {
            txtCompassDev.Clear();
            var RtnRec = My.MyProject.Forms.DevForm.DevInterpolateCompass(Convert.ToInt32(UpDwnCompass.Value));
            txtCompassDev.Text = "Compass:" + RtnRec.TblCompass.ToString("000") + '°' + " Magnetic:" + RtnRec.TblMagnetic.ToString("000") + '°' + " Dev:" + RtnRec.TblDev.ToString("#0") + RtnRec.TblDevEW;
            return;
        }

        private void btnMagDev_Click(object sender, EventArgs e)
        {
            txtMagDev.Clear();
            var RtnRec = My.MyProject.Forms.DevForm.DevInterpolateMagnetic(Convert.ToInt32(UpDwnMag.Value));
            txtMagDev.Text = "Compass:" + RtnRec.TblCompass.ToString("000") + '°' + " Magnetic:" + RtnRec.TblMagnetic.ToString("000") + '°' + " Dev:" + RtnRec.TblDev.ToString("#0") + RtnRec.TblDevEW;
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }
    }
}