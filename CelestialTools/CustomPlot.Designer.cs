using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class CustomPlot : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPlot));
            _btnPrtSights = new Button();
            _btnPrtSights.Click += new EventHandler(btnPrtSights_Click);
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            lblMidLat = new Label();
            lblMidLong = new Label();
            _cboPlotSize = new ComboBox();
            _cboPlotSize.SelectedIndexChanged += new EventHandler(cboPlotSize_SelectedIndexChanged);
            lblPlotZoom = new Label();
            _chkDisplayRose = new CheckBox();
            _chkDisplayRose.CheckedChanged += new EventHandler(chkDisplayRose_CheckedChanged);
            _txtLatActive = new TextBox();
            _txtLatActive.TextChanged += new EventHandler(txtLatActive_TextChanged);
            _txtLongActive = new TextBox();
            _txtLongActive.TextChanged += new EventHandler(txtLongActive_TextChanged);
            txtUserInfo = new TextBox();
            Label7 = new Label();
            PanelPlot = new Panel();
            _PicBoxPlot = new PictureBox();
            _PicBoxPlot.Paint += new PaintEventHandler(PicBoxPlot_Paint);
            _PicBoxPlot.MouseClick += new MouseEventHandler(PicBoxPlot_MouseClick);
            _PicBoxPlot.MouseEnter += new EventHandler(PicBoxPlot_MouseEnter);
            _PicBoxPlot.MouseLeave += new EventHandler(PicBoxPlot_MouseLeave);
            txtDispLoc = new TextBox();
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            PanelPlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PicBoxPlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrtSights
            // 
            _btnPrtSights.BackColor = Color.Yellow;
            _btnPrtSights.Cursor = Cursors.Default;
            _btnPrtSights.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPrtSights.ForeColor = SystemColors.ControlText;
            _btnPrtSights.ImageAlign = ContentAlignment.MiddleRight;
            _btnPrtSights.Location = new Point(738, 4);
            _btnPrtSights.Name = "_btnPrtSights";
            _btnPrtSights.RightToLeft = RightToLeft.No;
            _btnPrtSights.Size = new Size(105, 25);
            _btnPrtSights.TabIndex = 197;
            _btnPrtSights.Text = "Display Sight Data ";
            _btnPrtSights.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(853, 4);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(78, 25);
            _ExitBtn.TabIndex = 194;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // lblMidLat
            // 
            lblMidLat.AutoSize = true;
            lblMidLat.Location = new Point(28, 36);
            lblMidLat.Name = "lblMidLat";
            lblMidLat.Size = new Size(45, 13);
            lblMidLat.TabIndex = 198;
            lblMidLat.Text = "Mid Lat:";
            lblMidLat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMidLong
            // 
            lblMidLong.AutoSize = true;
            lblMidLong.Location = new Point(198, 36);
            lblMidLong.Name = "lblMidLong";
            lblMidLong.Size = new Size(54, 13);
            lblMidLong.TabIndex = 200;
            lblMidLong.Text = "Mid Long:";
            lblMidLong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboPlotSize
            // 
            _cboPlotSize.Enabled = false;
            _cboPlotSize.FormattingEnabled = true;
            _cboPlotSize.Items.AddRange(new object[] { "Zoom Out to 100 nm / side", "Zoom Out to 80 nm / side", "Default to 60 nm / side", "Zoom in to 40 nm / side", "Zoom In to 20 nm / side" });
            _cboPlotSize.Location = new Point(475, 31);
            _cboPlotSize.Name = "_cboPlotSize";
            _cboPlotSize.Size = new Size(150, 21);
            _cboPlotSize.TabIndex = 203;
            // 
            // lblPlotZoom
            // 
            lblPlotZoom.AutoSize = true;
            lblPlotZoom.Location = new Point(420, 35);
            lblPlotZoom.Name = "lblPlotZoom";
            lblPlotZoom.Size = new Size(51, 13);
            lblPlotZoom.TabIndex = 202;
            lblPlotZoom.Text = "Plot Size:";
            // 
            // chkDisplayRose
            // 
            _chkDisplayRose.AutoSize = true;
            _chkDisplayRose.Location = new Point(475, 8);
            _chkDisplayRose.Name = "_chkDisplayRose";
            _chkDisplayRose.Size = new Size(127, 17);
            _chkDisplayRose.TabIndex = 206;
            _chkDisplayRose.Text = "Show Compass Rose";
            _chkDisplayRose.UseVisualStyleBackColor = true;
            // 
            // txtLatActive
            // 
            _txtLatActive.Location = new Point(74, 32);
            _txtLatActive.Name = "_txtLatActive";
            _txtLatActive.ReadOnly = true;
            _txtLatActive.Size = new Size(120, 20);
            _txtLatActive.TabIndex = 207;
            // 
            // txtLongActive
            // 
            _txtLongActive.Location = new Point(255, 32);
            _txtLongActive.Name = "_txtLongActive";
            _txtLongActive.ReadOnly = true;
            _txtLongActive.Size = new Size(120, 20);
            _txtLongActive.TabIndex = 208;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(74, 5);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(387, 20);
            txtUserInfo.TabIndex = 211;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(19, 8);
            Label7.Name = "Label7";
            Label7.Size = new Size(51, 14);
            Label7.TabIndex = 210;
            Label7.Text = "User Info";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelPlot
            // 
            PanelPlot.AutoScroll = true;
            PanelPlot.AutoScrollMargin = new Size(10, 10);
            PanelPlot.AutoScrollMinSize = new Size(10, 10);
            PanelPlot.AutoSize = true;
            PanelPlot.BorderStyle = BorderStyle.Fixed3D;
            PanelPlot.Controls.Add(_PicBoxPlot);
            PanelPlot.Location = new Point(11, 57);
            PanelPlot.Name = "PanelPlot";
            PanelPlot.Size = new Size(935, 929);
            PanelPlot.TabIndex = 204;
            // 
            // PicBoxPlot
            // 
            _PicBoxPlot.InitialImage = null;
            _PicBoxPlot.Location = new Point(12, 4);
            _PicBoxPlot.Name = "_PicBoxPlot";
            _PicBoxPlot.Size = new Size(900, 900);
            _PicBoxPlot.TabIndex = 0;
            _PicBoxPlot.TabStop = false;
            // 
            // txtDispLoc
            // 
            txtDispLoc.Font = new Font("Times New Roman", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDispLoc.Location = new Point(739, 32);
            txtDispLoc.Name = "txtDispLoc";
            txtDispLoc.ReadOnly = true;
            txtDispLoc.Size = new Size(189, 20);
            txtDispLoc.TabIndex = 212;
            txtDispLoc.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(642, 36);
            Label1.Name = "Label1";
            Label1.Size = new Size(94, 13);
            Label1.TabIndex = 213;
            Label1.Text = "Mouse Click L/Lo:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(334, 995);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(312, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 209;
            PictureBox1.TabStop = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = Color.Yellow;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.ImageAlign = ContentAlignment.MiddleRight;
            _cmdPrint.Location = new Point(646, 4);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(78, 25);
            _cmdPrint.TabIndex = 195;
            _cmdPrint.Text = "Print Plot";
            _cmdPrint.TextAlign = ContentAlignment.MiddleLeft;
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // CustomPlot
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(10, 10);
            ClientSize = new Size(967, 1061);
            Controls.Add(Label1);
            Controls.Add(txtDispLoc);
            Controls.Add(txtUserInfo);
            Controls.Add(PictureBox1);
            Controls.Add(Label7);
            Controls.Add(_txtLongActive);
            Controls.Add(_txtLatActive);
            Controls.Add(_chkDisplayRose);
            Controls.Add(PanelPlot);
            Controls.Add(_cboPlotSize);
            Controls.Add(lblPlotZoom);
            Controls.Add(lblMidLong);
            Controls.Add(lblMidLat);
            Controls.Add(_btnPrtSights);
            Controls.Add(_cmdPrint);
            Controls.Add(_ExitBtn);
            Name = "CustomPlot";
            Text = "Adjustable Scale Plot Form";
            PanelPlot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_PicBoxPlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(CustomPlot_Load);
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal Label lblMidLat;
        internal Label lblMidLong;
        private ComboBox _cboPlotSize;

        internal ComboBox cboPlotSize
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboPlotSize;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboPlotSize != null)
                {
                    _cboPlotSize.SelectedIndexChanged -= cboPlotSize_SelectedIndexChanged;
                }

                _cboPlotSize = value;
                if (_cboPlotSize != null)
                {
                    _cboPlotSize.SelectedIndexChanged += cboPlotSize_SelectedIndexChanged;
                }
            }
        }

        internal Label lblPlotZoom;
        private CheckBox _chkDisplayRose;

        internal CheckBox chkDisplayRose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDisplayRose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDisplayRose != null)
                {
                    _chkDisplayRose.CheckedChanged -= chkDisplayRose_CheckedChanged;
                }

                _chkDisplayRose = value;
                if (_chkDisplayRose != null)
                {
                    _chkDisplayRose.CheckedChanged += chkDisplayRose_CheckedChanged;
                }
            }
        }

        private TextBox _txtLatActive;

        internal TextBox txtLatActive
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLatActive;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLatActive != null)
                {
                    _txtLatActive.TextChanged -= txtLatActive_TextChanged;
                }

                _txtLatActive = value;
                if (_txtLatActive != null)
                {
                    _txtLatActive.TextChanged += txtLatActive_TextChanged;
                }
            }
        }

        private TextBox _txtLongActive;

        internal TextBox txtLongActive
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLongActive;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLongActive != null)
                {
                    _txtLongActive.TextChanged -= txtLongActive_TextChanged;
                }

                _txtLongActive = value;
                if (_txtLongActive != null)
                {
                    _txtLongActive.TextChanged += txtLongActive_TextChanged;
                }
            }
        }

        internal TextBox txtUserInfo;
        internal Label Label7;
        private PictureBox _PicBoxPlot;

        internal PictureBox PicBoxPlot
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PicBoxPlot;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PicBoxPlot != null)
                {
                    _PicBoxPlot.Paint -= PicBoxPlot_Paint;
                    _PicBoxPlot.MouseClick -= PicBoxPlot_MouseClick;
                    _PicBoxPlot.MouseEnter -= PicBoxPlot_MouseEnter;
                    _PicBoxPlot.MouseLeave -= PicBoxPlot_MouseLeave;
                }

                _PicBoxPlot = value;
                if (_PicBoxPlot != null)
                {
                    _PicBoxPlot.Paint += PicBoxPlot_Paint;
                    _PicBoxPlot.MouseClick += PicBoxPlot_MouseClick;
                    _PicBoxPlot.MouseEnter += PicBoxPlot_MouseEnter;
                    _PicBoxPlot.MouseLeave += PicBoxPlot_MouseLeave;
                }
            }
        }

        internal Panel PanelPlot;
        internal TextBox txtDispLoc;
        internal Label Label1;
        internal PictureBox PictureBox1;
    }
}