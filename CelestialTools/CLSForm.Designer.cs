using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class CLSForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CLSForm));
            _PicBoxCLS = new PictureBox();
            _PicBoxCLS.Paint += new PaintEventHandler(PicBoxCLS_Paint);
            _PicBoxCLS.MouseClick += new MouseEventHandler(PicBoxPlot_MouseClick);
            _PicBoxCLS.MouseEnter += new EventHandler(PicBoxPlot_MouseEnter);
            _PicBoxCLS.MouseLeave += new EventHandler(PicBoxPlot_MouseLeave);
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _btnPrtSights = new Button();
            _btnPrtSights.Click += new EventHandler(btnPrtSights_Click);
            txtUserInfo = new TextBox();
            Label7 = new Label();
            txtLongActive = new TextBox();
            txtLatActive = new TextBox();
            lblMidLong = new Label();
            lblMidLat = new Label();
            lblPlotZoom = new Label();
            txtDispLoc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)_PicBoxCLS).BeginInit();
            SuspendLayout();
            // 
            // PicBoxCLS
            // 
            _PicBoxCLS.BackgroundImage = (Image)resources.GetObject("PicBoxCLS.BackgroundImage");
            _PicBoxCLS.BackgroundImageLayout = ImageLayout.Center;
            _PicBoxCLS.InitialImage = null;
            _PicBoxCLS.Location = new Point(8, 67);
            _PicBoxCLS.Name = "_PicBoxCLS";
            _PicBoxCLS.Size = new Size(820, 960);
            _PicBoxCLS.TabIndex = 0;
            _PicBoxCLS.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(722, 26);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(106, 25);
            _ExitBtn.TabIndex = 102;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = Color.Yellow;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.ImageAlign = ContentAlignment.MiddleRight;
            _cmdPrint.Location = new Point(497, 26);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(107, 25);
            _cmdPrint.TabIndex = 104;
            _cmdPrint.Text = "Print Plot";
            _cmdPrint.TextAlign = ContentAlignment.MiddleLeft;
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // btnPrtSights
            // 
            _btnPrtSights.BackColor = Color.Yellow;
            _btnPrtSights.Cursor = Cursors.Default;
            _btnPrtSights.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPrtSights.ForeColor = SystemColors.ControlText;
            _btnPrtSights.ImageAlign = ContentAlignment.MiddleRight;
            _btnPrtSights.Location = new Point(610, 26);
            _btnPrtSights.Name = "_btnPrtSights";
            _btnPrtSights.RightToLeft = RightToLeft.No;
            _btnPrtSights.Size = new Size(106, 25);
            _btnPrtSights.TabIndex = 193;
            _btnPrtSights.Text = "Display Sight Data";
            _btnPrtSights.UseVisualStyleBackColor = false;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(69, 3);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(387, 20);
            txtUserInfo.TabIndex = 202;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(12, 6);
            Label7.Name = "Label7";
            Label7.Size = new Size(51, 14);
            Label7.TabIndex = 201;
            Label7.Text = "User Info";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLongActive
            // 
            txtLongActive.Location = new Point(283, 30);
            txtLongActive.Name = "txtLongActive";
            txtLongActive.ReadOnly = true;
            txtLongActive.Size = new Size(150, 20);
            txtLongActive.TabIndex = 212;
            // 
            // txtLatActive
            // 
            txtLatActive.Location = new Point(69, 30);
            txtLatActive.Name = "txtLatActive";
            txtLatActive.ReadOnly = true;
            txtLatActive.Size = new Size(150, 20);
            txtLatActive.TabIndex = 211;
            // 
            // lblMidLong
            // 
            lblMidLong.AutoSize = true;
            lblMidLong.Location = new Point(225, 34);
            lblMidLong.Name = "lblMidLong";
            lblMidLong.Size = new Size(54, 13);
            lblMidLong.TabIndex = 210;
            lblMidLong.Text = "Mid Long:";
            lblMidLong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMidLat
            // 
            lblMidLat.AutoSize = true;
            lblMidLat.Location = new Point(18, 34);
            lblMidLat.Name = "lblMidLat";
            lblMidLat.Size = new Size(45, 13);
            lblMidLat.TabIndex = 209;
            lblMidLat.Text = "Mid Lat:";
            lblMidLat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlotZoom
            // 
            lblPlotZoom.AutoSize = true;
            lblPlotZoom.Location = new Point(462, 8);
            lblPlotZoom.Name = "lblPlotZoom";
            lblPlotZoom.Size = new Size(94, 13);
            lblPlotZoom.TabIndex = 216;
            lblPlotZoom.Text = "Mouse Click L/Lo:";
            // 
            // txtDispLoc
            // 
            txtDispLoc.Font = new Font("Times New Roman", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDispLoc.Location = new Point(560, 4);
            txtDispLoc.Name = "txtDispLoc";
            txtDispLoc.ReadOnly = true;
            txtDispLoc.Size = new Size(198, 20);
            txtDispLoc.TabIndex = 215;
            txtDispLoc.TextAlign = HorizontalAlignment.Center;
            // 
            // CLSForm
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(20, 20);
            AutoScrollMinSize = new Size(856, 1095);
            ClientSize = new Size(856, 1009);
            Controls.Add(lblPlotZoom);
            Controls.Add(txtDispLoc);
            Controls.Add(txtLongActive);
            Controls.Add(txtLatActive);
            Controls.Add(lblMidLong);
            Controls.Add(lblMidLat);
            Controls.Add(txtUserInfo);
            Controls.Add(Label7);
            Controls.Add(_btnPrtSights);
            Controls.Add(_cmdPrint);
            Controls.Add(_ExitBtn);
            Controls.Add(_PicBoxCLS);
            Name = "CLSForm";
            Text = "Constant Latitude Scale Plot Form";
            ((System.ComponentModel.ISupportInitialize)_PicBoxCLS).EndInit();
            Load += new EventHandler(CLSForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox _PicBoxCLS;

        internal PictureBox PicBoxCLS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PicBoxCLS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PicBoxCLS != null)
                {
                    _PicBoxCLS.Paint -= PicBoxCLS_Paint;
                    _PicBoxCLS.MouseClick -= PicBoxPlot_MouseClick;
                    _PicBoxCLS.MouseEnter -= PicBoxPlot_MouseEnter;
                    _PicBoxCLS.MouseLeave -= PicBoxPlot_MouseLeave;
                }

                _PicBoxCLS = value;
                if (_PicBoxCLS != null)
                {
                    _PicBoxCLS.Paint += PicBoxCLS_Paint;
                    _PicBoxCLS.MouseClick += PicBoxPlot_MouseClick;
                    _PicBoxCLS.MouseEnter += PicBoxPlot_MouseEnter;
                    _PicBoxCLS.MouseLeave += PicBoxPlot_MouseLeave;
                }
            }
        }

        private Button _ExitBtn;

        public Button ExitBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitBtn != null)
                {
                    _ExitBtn.Click -= ExitBtn_Click;
                }

                _ExitBtn = value;
                if (_ExitBtn != null)
                {
                    _ExitBtn.Click += ExitBtn_Click;
                }
            }
        }

        private Button _cmdPrint;

        public Button cmdPrint
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPrint;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPrint != null)
                {
                    _cmdPrint.Click -= cmdPrint_Click;
                }

                _cmdPrint = value;
                if (_cmdPrint != null)
                {
                    _cmdPrint.Click += cmdPrint_Click;
                }
            }
        }

        internal TextBox txtSquadron;
        internal Label lblSquadron;
        internal TextBox txtName;
        internal Label lblName;
        internal TextBox txtSightNum;
        internal Label lblSightNum;
        public Button btnPrtPlot;
        private Button _btnPrtSights;

        public Button btnPrtSights
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrtSights;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrtSights != null)
                {
                    _btnPrtSights.Click -= btnPrtSights_Click;
                }

                _btnPrtSights = value;
                if (_btnPrtSights != null)
                {
                    _btnPrtSights.Click += btnPrtSights_Click;
                }
            }
        }

        internal TextBox txtUserInfo;
        internal Label Label7;
        internal TextBox txtLongActive;
        internal TextBox txtLatActive;
        internal Label lblMidLong;
        internal Label lblMidLat;
        internal Label lblPlotZoom;
        internal TextBox txtDispLoc;
    }
}