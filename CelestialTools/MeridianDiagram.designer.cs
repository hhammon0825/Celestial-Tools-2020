using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormMeridianDiagram
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormMeridianDiagram() : base()
        {
            // This is required by the Windows Form Designer.
            InitializeComponent();
            // Form_Initialize_renamed()
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
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeridianDiagram));
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _MeridianPicBx = new PictureBox();
            _MeridianPicBx.Paint += new PaintEventHandler(MeridianPicBx_Paint);
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            Label1 = new Label();
            _chkTwiLites = new CheckBox();
            _chkTwiLites.CheckedChanged += new EventHandler(chkTwiLites_CheckedChanged);
            _chkDispZnLHA = new CheckBox();
            _chkDispZnLHA.CheckedChanged += new EventHandler(chkDispZnLHA_CheckedChanged);
            grpOptions = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)_MeridianPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            grpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(682, 7);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 4;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // MeridianPicBx
            // 
            _MeridianPicBx.BackColor = Color.LightGray;
            _MeridianPicBx.Location = new Point(3, 35);
            _MeridianPicBx.Name = "_MeridianPicBx";
            _MeridianPicBx.Size = new Size(700, 700);
            _MeridianPicBx.TabIndex = 13;
            _MeridianPicBx.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(646, 745);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(57, 27);
            _ExitBtn.TabIndex = 14;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(220, 745);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(167, 10);
            Label1.Name = "Label1";
            Label1.Size = new Size(340, 18);
            Label1.TabIndex = 103;
            Label1.Text = "Projection on the Plane of the Celestial Meridian";
            // 
            // chkTwiLites
            // 
            _chkTwiLites.AutoSize = true;
            _chkTwiLites.Location = new Point(32, 41);
            _chkTwiLites.Name = "_chkTwiLites";
            _chkTwiLites.Size = new Size(104, 17);
            _chkTwiLites.TabIndex = 104;
            _chkTwiLites.Text = "Display Twilights";
            _chkTwiLites.UseVisualStyleBackColor = true;
            // 
            // chkDispZnLHA
            // 
            _chkDispZnLHA.AutoSize = true;
            _chkDispZnLHA.Checked = true;
            _chkDispZnLHA.CheckState = CheckState.Checked;
            _chkDispZnLHA.Location = new Point(32, 20);
            _chkDispZnLHA.Name = "_chkDispZnLHA";
            _chkDispZnLHA.Size = new Size(118, 17);
            _chkDispZnLHA.TabIndex = 105;
            _chkDispZnLHA.Text = "Display Zn and LHA";
            _chkDispZnLHA.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(_chkDispZnLHA);
            grpOptions.Controls.Add(_chkTwiLites);
            grpOptions.Location = new Point(3, 737);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(156, 67);
            grpOptions.TabIndex = 106;
            grpOptions.TabStop = false;
            grpOptions.Text = "Display Options";
            // 
            // FormMeridianDiagram
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(716, 812);
            Controls.Add(grpOptions);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(_cmdPrint);
            Controls.Add(_MeridianPicBx);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormMeridianDiagram";
            RightToLeft = RightToLeft.No;
            Text = "Projection on the Plane of the Celestial Meridian";
            ((System.ComponentModel.ISupportInitialize)_MeridianPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            Load += new EventHandler(FormMeridianDiagram_Load);
            FormClosed += new FormClosedEventHandler(FormMeridianDiagram_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox _MeridianPicBx;

        internal PictureBox MeridianPicBx
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MeridianPicBx;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MeridianPicBx != null)
                {
                    _MeridianPicBx.Paint -= MeridianPicBx_Paint;
                }

                _MeridianPicBx = value;
                if (_MeridianPicBx != null)
                {
                    _MeridianPicBx.Paint += MeridianPicBx_Paint;
                }
            }
        }

        private Button _ExitBtn;

        internal Button ExitBtn
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

        internal PictureBox PictureBox1;
        internal Label Label1;
        private CheckBox _chkTwiLites;

        internal CheckBox chkTwiLites
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkTwiLites;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkTwiLites != null)
                {
                    _chkTwiLites.CheckedChanged -= chkTwiLites_CheckedChanged;
                }

                _chkTwiLites = value;
                if (_chkTwiLites != null)
                {
                    _chkTwiLites.CheckedChanged += chkTwiLites_CheckedChanged;
                }
            }
        }

        private CheckBox _chkDispZnLHA;

        internal CheckBox chkDispZnLHA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDispZnLHA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDispZnLHA != null)
                {
                    _chkDispZnLHA.CheckedChanged -= chkDispZnLHA_CheckedChanged;
                }

                _chkDispZnLHA = value;
                if (_chkDispZnLHA != null)
                {
                    _chkDispZnLHA.CheckedChanged += chkDispZnLHA_CheckedChanged;
                }
            }
        }

        internal GroupBox grpOptions;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}