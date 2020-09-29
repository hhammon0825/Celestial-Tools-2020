using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class SRFTimeDiagram : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SRFTimeDiagram));
            EqtPicBx = new PictureBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _chkDispEqt = new CheckBox();
            _chkDispEqt.CheckedChanged += new EventHandler(chkDispEqt_CheckedChanged);
            ((System.ComponentModel.ISupportInitialize)EqtPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EqtPicBx
            // 
            EqtPicBx.BackColor = Color.LightGray;
            EqtPicBx.Location = new Point(13, 7);
            EqtPicBx.Name = "EqtPicBx";
            EqtPicBx.Size = new Size(700, 700);
            EqtPicBx.TabIndex = 0;
            EqtPicBx.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(650, 711);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(63, 25);
            _ExitBtn.TabIndex = 108;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(229, 711);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 123;
            PictureBox1.TabStop = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(690, 740);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 124;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // chkDispEqt
            // 
            _chkDispEqt.AutoSize = true;
            _chkDispEqt.Location = new Point(22, 727);
            _chkDispEqt.Name = "_chkDispEqt";
            _chkDispEqt.Size = new Size(201, 17);
            _chkDispEqt.TabIndex = 125;
            _chkDispEqt.Text = "Display Apparent Sun and Eqt Factor";
            _chkDispEqt.UseVisualStyleBackColor = true;
            // 
            // SRFTimeDiagram
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 766);
            Controls.Add(_chkDispEqt);
            Controls.Add(_cmdPrint);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(EqtPicBx);
            Name = "SRFTimeDiagram";
            Text = "SRFTimeDiagram";
            ((System.ComponentModel.ISupportInitialize)EqtPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(SRFTimeDiagram_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox EqtPicBx;
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

        internal CheckBox chkDisplayEqt;
        internal PictureBox PictureBox1;
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

        private CheckBox _chkDispEqt;

        internal CheckBox chkDispEqt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDispEqt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDispEqt != null)
                {
                    _chkDispEqt.CheckedChanged -= chkDispEqt_CheckedChanged;
                }

                _chkDispEqt = value;
                if (_chkDispEqt != null)
                {
                    _chkDispEqt.CheckedChanged += chkDispEqt_CheckedChanged;
                }
            }
        }
    }
}