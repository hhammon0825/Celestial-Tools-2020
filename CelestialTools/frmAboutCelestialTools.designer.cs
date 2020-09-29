using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class frmAbout
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public frmAbout() : base()
        {
            // This is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTip1;
        public PictureBox picIcon;
        private Button _cmdOK;

        public Button cmdOK
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdOK;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdOK != null)
                {
                    _cmdOK.Click -= cmdOK_Click;
                }

                _cmdOK = value;
                if (_cmdOK != null)
                {
                    _cmdOK.Click += cmdOK_Click;
                }
            }
        }

        public Label Label1;
        public Label lblAuthor;
        public Label lblTitle;
        public Label lblVersion;
        public Label lblDisclaimer;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            ToolTip1 = new ToolTip(components);
            picIcon = new PictureBox();
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(cmdOK_Click);
            Label1 = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblVersion = new Label();
            lblDisclaimer = new Label();
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picIcon
            // 
            picIcon.BackColor = SystemColors.Control;
            picIcon.BorderStyle = BorderStyle.Fixed3D;
            picIcon.Cursor = Cursors.Default;
            picIcon.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            picIcon.ForeColor = SystemColors.ControlText;
            picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new Point(10, 8);
            picIcon.Name = "picIcon";
            picIcon.RightToLeft = RightToLeft.No;
            picIcon.Size = new Size(36, 36);
            picIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            picIcon.TabIndex = 1;
            picIcon.TabStop = false;
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.DialogResult = DialogResult.Cancel;
            _cmdOK.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(394, 399);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(84, 23);
            _cmdOK.TabIndex = 0;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(174, 59);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(314, 17);
            Label1.TabIndex = 8;
            Label1.Text = "Copyright © 2004-2017 United States Power Squadrons";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = SystemColors.Control;
            lblAuthor.Cursor = Cursors.Default;
            lblAuthor.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAuthor.ForeColor = SystemColors.ControlText;
            lblAuthor.Location = new Point(9, 233);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.RightToLeft = RightToLeft.No;
            lblAuthor.Size = new Size(469, 165);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = resources.GetString("lblAuthor.Text");
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Cursor = Cursors.Default;
            lblTitle.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(128)));
            lblTitle.Location = new Point(52, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(119, 23);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Celestial Tools";
            // 
            // lblVersion
            // 
            lblVersion.BackColor = SystemColors.Control;
            lblVersion.BorderStyle = BorderStyle.Fixed3D;
            lblVersion.Cursor = Cursors.Default;
            lblVersion.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblVersion.ForeColor = SystemColors.ControlText;
            lblVersion.Location = new Point(18, 82);
            lblVersion.Name = "lblVersion";
            lblVersion.RightToLeft = RightToLeft.No;
            lblVersion.Size = new Size(444, 63);
            lblVersion.TabIndex = 5;
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDisclaimer
            // 
            lblDisclaimer.BackColor = SystemColors.Control;
            lblDisclaimer.Cursor = Cursors.Default;
            lblDisclaimer.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDisclaimer.ForeColor = Color.Red;
            lblDisclaimer.Location = new Point(12, 156);
            lblDisclaimer.Name = "lblDisclaimer";
            lblDisclaimer.RightToLeft = RightToLeft.No;
            lblDisclaimer.Size = new Size(463, 64);
            lblDisclaimer.TabIndex = 3;
            lblDisclaimer.Text = "Warning: NOT FOR NAVIGATION" + '\r' + '\n' + "Although this program will provide fairly accurate r" + "esults, its primary purpose is instructional, and it should not be used for navi" + "gation.";
            lblDisclaimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(172, 6);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 123;
            PictureBox1.TabStop = false;
            // 
            // frmAbout
            // 
            AcceptButton = _cmdOK;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = _cmdOK;
            ClientSize = new Size(496, 435);
            Controls.Add(PictureBox1);
            Controls.Add(picIcon);
            Controls.Add(_cmdOK);
            Controls.Add(Label1);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(lblVersion);
            Controls.Add(lblDisclaimer);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(85, 300);
            MaximizeBox = false;
            Name = "frmAbout";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Celestial Tools";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(frmAbout_Load);
            FormClosed += new FormClosedEventHandler(frmAbout_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox PictureBox1;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}