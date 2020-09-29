using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class frmPointsOnRhumb : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointsOnRhumb));
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            Label1 = new Label();
            lblLatitude = new Label();
            lblLongitude = new Label();
            cboLo = new ComboBox();
            cboL = new ComboBox();
            _txtLDeg = new TextBox();
            _txtLDeg.TextChanged += new EventHandler(txtLDeg_TextChanged);
            _txtLDeg.KeyPress += new KeyPressEventHandler(txtLDeg_KeyPress);
            _txtLDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLDeg_Validating);
            _txtLDeg.Enter += new EventHandler(txtLDeg_Enter);
            _txtLoMin = new TextBox();
            _txtLoMin.TextChanged += new EventHandler(txtLoMin_TextChanged);
            _txtLoMin.KeyPress += new KeyPressEventHandler(txtLoMin_KeyPress);
            _txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(txtLoMin_Validating);
            _txtLoMin.Enter += new EventHandler(txtLoMin_Enter);
            _txtLoDeg = new TextBox();
            _txtLoDeg.TextChanged += new EventHandler(txtLoDeg_TextChanged);
            _txtLoDeg.KeyPress += new KeyPressEventHandler(txtLoDeg_KeyPress);
            _txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLoDeg_Validating);
            _txtLoDeg.Enter += new EventHandler(txtLoDeg_Enter);
            _txtLMin = new TextBox();
            _txtLMin.TextChanged += new EventHandler(txtLMin_TextChanged);
            _txtLMin.KeyPress += new KeyPressEventHandler(txtLMin_KeyPress);
            _txtLMin.Validating += new System.ComponentModel.CancelEventHandler(txtLMin_Validating);
            _txtLMin.Enter += new EventHandler(txtLMin_Enter);
            lblLoMin = new Label();
            lblLoDeg = new Label();
            lblLMin = new Label();
            lblLDeg = new Label();
            _cmdCalculate = new Button();
            _cmdCalculate.Click += new EventHandler(cmdCalculate_Click);
            RhumbPointsTxtBx = new TextBox();
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            PictureBox1 = new PictureBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(292, -1);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 37;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(301, 26);
            Label1.TabIndex = 38;
            Label1.Text = "Enter a latitude and/or a longitude on the rhumb line.  " + '\r' + '\n' + "The corresponding longi" + "tude and/or latitude will be calculated.";
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(45, 59);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(45, 13);
            lblLatitude.TabIndex = 39;
            lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(205, 59);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(54, 13);
            lblLongitude.TabIndex = 40;
            lblLongitude.Text = "Longitude";
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(257, 77);
            cboLo.Name = "cboLo";
            cboLo.RightToLeft = RightToLeft.No;
            cboLo.Size = new Size(41, 22);
            cboLo.TabIndex = 48;
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(90, 75);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 22);
            cboL.TabIndex = 43;
            // 
            // txtLDeg
            // 
            _txtLDeg.AcceptsReturn = true;
            _txtLDeg.BackColor = SystemColors.Window;
            _txtLDeg.Cursor = Cursors.IBeam;
            _txtLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLDeg.ForeColor = SystemColors.WindowText;
            _txtLDeg.Location = new Point(18, 75);
            _txtLDeg.MaxLength = 2;
            _txtLDeg.Name = "_txtLDeg";
            _txtLDeg.RightToLeft = RightToLeft.No;
            _txtLDeg.Size = new Size(25, 20);
            _txtLDeg.TabIndex = 41;
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(217, 77);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 47;
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(177, 77);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 46;
            // 
            // txtLMin
            // 
            _txtLMin.AcceptsReturn = true;
            _txtLMin.BackColor = SystemColors.Window;
            _txtLMin.Cursor = Cursors.IBeam;
            _txtLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLMin.ForeColor = SystemColors.WindowText;
            _txtLMin.Location = new Point(50, 75);
            _txtLMin.MaxLength = 4;
            _txtLMin.Name = "_txtLMin";
            _txtLMin.RightToLeft = RightToLeft.No;
            _txtLMin.Size = new Size(33, 20);
            _txtLMin.TabIndex = 42;
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(250, 77);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 50;
            lblLoMin.Text = "'";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(210, 77);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 49;
            lblLoDeg.Text = "°";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(83, 74);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 45;
            lblLMin.Text = "'";
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(43, 75);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 44;
            lblLDeg.Text = "°";
            // 
            // cmdCalculate
            // 
            _cmdCalculate.Location = new Point(124, 115);
            _cmdCalculate.Name = "_cmdCalculate";
            _cmdCalculate.Size = new Size(75, 23);
            _cmdCalculate.TabIndex = 51;
            _cmdCalculate.Text = "&Calculate";
            _cmdCalculate.UseVisualStyleBackColor = true;
            // 
            // RhumbPointsTxtBx
            // 
            RhumbPointsTxtBx.Location = new Point(1, 151);
            RhumbPointsTxtBx.Multiline = true;
            RhumbPointsTxtBx.Name = "RhumbPointsTxtBx";
            RhumbPointsTxtBx.Size = new Size(312, 92);
            RhumbPointsTxtBx.TabIndex = 52;
            // 
            // cmdClear
            // 
            _cmdClear.Location = new Point(15, 115);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.Size = new Size(75, 23);
            _cmdClear.TabIndex = 53;
            _cmdClear.Text = "Clea&r";
            _cmdClear.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(1, 249);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(312, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(239, 115);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(63, 25);
            _ExitBtn.TabIndex = 108;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // frmPointsOnRhumb
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 309);
            Controls.Add(_ExitBtn);
            Controls.Add(PictureBox1);
            Controls.Add(_cmdClear);
            Controls.Add(RhumbPointsTxtBx);
            Controls.Add(_cmdCalculate);
            Controls.Add(cboLo);
            Controls.Add(cboL);
            Controls.Add(_txtLDeg);
            Controls.Add(_txtLoMin);
            Controls.Add(_txtLoDeg);
            Controls.Add(_txtLMin);
            Controls.Add(lblLoMin);
            Controls.Add(lblLoDeg);
            Controls.Add(lblLMin);
            Controls.Add(lblLDeg);
            Controls.Add(lblLongitude);
            Controls.Add(lblLatitude);
            Controls.Add(Label1);
            Controls.Add(_cmdPrint);
            Name = "frmPointsOnRhumb";
            Text = "frmPointsOnRhumb";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(frmPointsOnRhumb_Load);
            FormClosed += new FormClosedEventHandler(frmPointsOnRhumb_FormClosed);
            ResumeLayout(false);
            PerformLayout();
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

        internal Label Label1;
        internal Label lblLatitude;
        internal Label lblLongitude;
        public ComboBox cboLo;
        public ComboBox cboL;
        private TextBox _txtLDeg;

        public TextBox txtLDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLDeg != null)
                {
                    _txtLDeg.TextChanged -= txtLDeg_TextChanged;
                    _txtLDeg.KeyPress -= txtLDeg_KeyPress;
                    _txtLDeg.Validating -= txtLDeg_Validating;
                    _txtLDeg.Enter -= txtLDeg_Enter;
                }

                _txtLDeg = value;
                if (_txtLDeg != null)
                {
                    _txtLDeg.TextChanged += txtLDeg_TextChanged;
                    _txtLDeg.KeyPress += txtLDeg_KeyPress;
                    _txtLDeg.Validating += txtLDeg_Validating;
                    _txtLDeg.Enter += txtLDeg_Enter;
                }
            }
        }

        private TextBox _txtLoMin;

        public TextBox txtLoMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged -= txtLoMin_TextChanged;
                    _txtLoMin.KeyPress -= txtLoMin_KeyPress;
                    _txtLoMin.Validating -= txtLoMin_Validating;
                    _txtLoMin.Enter -= txtLoMin_Enter;
                }

                _txtLoMin = value;
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged += txtLoMin_TextChanged;
                    _txtLoMin.KeyPress += txtLoMin_KeyPress;
                    _txtLoMin.Validating += txtLoMin_Validating;
                    _txtLoMin.Enter += txtLoMin_Enter;
                }
            }
        }

        private TextBox _txtLoDeg;

        public TextBox txtLoDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged -= txtLoDeg_TextChanged;
                    _txtLoDeg.KeyPress -= txtLoDeg_KeyPress;
                    _txtLoDeg.Validating -= txtLoDeg_Validating;
                    _txtLoDeg.Enter -= txtLoDeg_Enter;
                }

                _txtLoDeg = value;
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged += txtLoDeg_TextChanged;
                    _txtLoDeg.KeyPress += txtLoDeg_KeyPress;
                    _txtLoDeg.Validating += txtLoDeg_Validating;
                    _txtLoDeg.Enter += txtLoDeg_Enter;
                }
            }
        }

        private TextBox _txtLMin;

        public TextBox txtLMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLMin != null)
                {
                    _txtLMin.TextChanged -= txtLMin_TextChanged;
                    _txtLMin.KeyPress -= txtLMin_KeyPress;
                    _txtLMin.Validating -= txtLMin_Validating;
                    _txtLMin.Enter -= txtLMin_Enter;
                }

                _txtLMin = value;
                if (_txtLMin != null)
                {
                    _txtLMin.TextChanged += txtLMin_TextChanged;
                    _txtLMin.KeyPress += txtLMin_KeyPress;
                    _txtLMin.Validating += txtLMin_Validating;
                    _txtLMin.Enter += txtLMin_Enter;
                }
            }
        }

        public Label lblLoMin;
        public Label lblLoDeg;
        public Label lblLMin;
        public Label lblLDeg;
        private Button _cmdCalculate;

        internal Button cmdCalculate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculate != null)
                {
                    _cmdCalculate.Click -= cmdCalculate_Click;
                }

                _cmdCalculate = value;
                if (_cmdCalculate != null)
                {
                    _cmdCalculate.Click += cmdCalculate_Click;
                }
            }
        }

        internal TextBox RhumbPointsTxtBx;
        private Button _cmdClear;

        internal Button cmdClear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClear != null)
                {
                    _cmdClear.Click -= cmdClear_Click;
                }

                _cmdClear = value;
                if (_cmdClear != null)
                {
                    _cmdClear.Click += cmdClear_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
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
    }
}