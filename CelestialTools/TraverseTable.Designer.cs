using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class TraverseTable : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TraverseTable));
            cboLo1 = new ComboBox();
            _txtLo1Min = new TextBox();
            _txtLo1Min.TextChanged += new EventHandler(txtLo1Min_TextChanged);
            _txtLo1Min.KeyPress += new KeyPressEventHandler(txtLo1Min_KeyPress);
            _txtLo1Min.Validating += new System.ComponentModel.CancelEventHandler(txtLo1Min_Validating);
            _txtLo1Min.Enter += new EventHandler(txtLo1Min_Enter);
            _txtLo1Deg = new TextBox();
            _txtLo1Deg.TextChanged += new EventHandler(txtLo1Deg_TextChanged);
            _txtLo1Deg.KeyPress += new KeyPressEventHandler(txtLo1Deg_KeyPress);
            _txtLo1Deg.Validating += new System.ComponentModel.CancelEventHandler(txtLo1Deg_Validating);
            _txtLo1Deg.Enter += new EventHandler(txtLo1Deg_Enter);
            _txtL1Deg = new TextBox();
            _txtL1Deg.TextChanged += new EventHandler(txtL1Deg_TextChanged);
            _txtL1Deg.KeyPress += new KeyPressEventHandler(txtL1Deg_KeyPress);
            _txtL1Deg.Validating += new System.ComponentModel.CancelEventHandler(txtL1Deg_Validating);
            _txtL1Deg.Enter += new EventHandler(txtL1Deg_Enter);
            cboL1 = new ComboBox();
            _txtL1Min = new TextBox();
            _txtL1Min.TextChanged += new EventHandler(txtL1Min_TextChanged);
            _txtL1Min.KeyPress += new KeyPressEventHandler(txtL1Min_KeyPress);
            _txtL1Min.Validating += new System.ComponentModel.CancelEventHandler(txtL1Min_Validating);
            _txtL1Min.Enter += new EventHandler(txtL1Min_Enter);
            lblDRLo = new Label();
            lblDRL = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            lblCourse = new Label();
            _txtCourse = new TextBox();
            _txtCourse.TextChanged += new EventHandler(txtCourse_TextChanged);
            _txtCourse.KeyPress += new KeyPressEventHandler(txtCourse_KeyPress);
            _txtCourse.Validating += new System.ComponentModel.CancelEventHandler(txtCourse_Validating);
            _txtCourse.Enter += new EventHandler(txtCourse_Enter);
            lblnm = new Label();
            _txtDist = new TextBox();
            _txtDist.TextChanged += new EventHandler(txtDist_TextChanged);
            _txtDist.KeyPress += new KeyPressEventHandler(txtDist_KeyPress);
            _txtDist.Validating += new System.ComponentModel.CancelEventHandler(txtDist_Validating);
            _txtDist.Enter += new EventHandler(txtDist_Enter);
            lblDistance = new Label();
            txtSailings = new RichTextBox();
            _cmdCalculate = new Button();
            _cmdCalculate.Click += new EventHandler(cmdCalculate_Click);
            PictureBox1 = new PictureBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            cmdPrint = new Button();
            _btnPrintScreen = new Button();
            _btnPrintScreen.Click += new EventHandler(btnPrintScreen_Click);
            lblCourseDeg = new Label();
            Label1 = new Label();
            txtTraverseTbl = new RichTextBox();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboLo1
            // 
            cboLo1.BackColor = SystemColors.Window;
            cboLo1.Cursor = Cursors.Default;
            cboLo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo1.ForeColor = SystemColors.WindowText;
            cboLo1.Items.AddRange(new object[] { "W", "E" });
            cboLo1.Location = new Point(141, 46);
            cboLo1.Name = "cboLo1";
            cboLo1.RightToLeft = RightToLeft.No;
            cboLo1.Size = new Size(41, 22);
            cboLo1.TabIndex = 54;
            // 
            // txtLo1Min
            // 
            _txtLo1Min.AcceptsReturn = true;
            _txtLo1Min.BackColor = SystemColors.Window;
            _txtLo1Min.Cursor = Cursors.IBeam;
            _txtLo1Min.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo1Min.ForeColor = SystemColors.WindowText;
            _txtLo1Min.Location = new Point(101, 46);
            _txtLo1Min.MaxLength = 4;
            _txtLo1Min.Name = "_txtLo1Min";
            _txtLo1Min.RightToLeft = RightToLeft.No;
            _txtLo1Min.Size = new Size(33, 22);
            _txtLo1Min.TabIndex = 53;
            _txtLo1Min.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLo1Deg
            // 
            _txtLo1Deg.AcceptsReturn = true;
            _txtLo1Deg.BackColor = SystemColors.Window;
            _txtLo1Deg.Cursor = Cursors.IBeam;
            _txtLo1Deg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo1Deg.ForeColor = SystemColors.WindowText;
            _txtLo1Deg.Location = new Point(61, 46);
            _txtLo1Deg.MaxLength = 3;
            _txtLo1Deg.Name = "_txtLo1Deg";
            _txtLo1Deg.RightToLeft = RightToLeft.No;
            _txtLo1Deg.Size = new Size(33, 22);
            _txtLo1Deg.TabIndex = 52;
            _txtLo1Deg.TextAlign = HorizontalAlignment.Center;
            // 
            // txtL1Deg
            // 
            _txtL1Deg.AcceptsReturn = true;
            _txtL1Deg.BackColor = SystemColors.Window;
            _txtL1Deg.Cursor = Cursors.IBeam;
            _txtL1Deg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL1Deg.ForeColor = SystemColors.WindowText;
            _txtL1Deg.Location = new Point(69, 22);
            _txtL1Deg.MaxLength = 2;
            _txtL1Deg.Name = "_txtL1Deg";
            _txtL1Deg.RightToLeft = RightToLeft.No;
            _txtL1Deg.Size = new Size(25, 22);
            _txtL1Deg.TabIndex = 49;
            _txtL1Deg.TextAlign = HorizontalAlignment.Center;
            // 
            // cboL1
            // 
            cboL1.BackColor = SystemColors.Window;
            cboL1.Cursor = Cursors.Default;
            cboL1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL1.ForeColor = SystemColors.WindowText;
            cboL1.Items.AddRange(new object[] { "N", "S" });
            cboL1.Location = new Point(141, 22);
            cboL1.Name = "cboL1";
            cboL1.RightToLeft = RightToLeft.No;
            cboL1.Size = new Size(41, 22);
            cboL1.TabIndex = 51;
            // 
            // txtL1Min
            // 
            _txtL1Min.AcceptsReturn = true;
            _txtL1Min.BackColor = SystemColors.Window;
            _txtL1Min.Cursor = Cursors.IBeam;
            _txtL1Min.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL1Min.ForeColor = SystemColors.WindowText;
            _txtL1Min.Location = new Point(101, 22);
            _txtL1Min.MaxLength = 4;
            _txtL1Min.Name = "_txtL1Min";
            _txtL1Min.RightToLeft = RightToLeft.No;
            _txtL1Min.Size = new Size(33, 22);
            _txtL1Min.TabIndex = 50;
            _txtL1Min.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(4, 48);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(55, 17);
            lblDRLo.TabIndex = 62;
            lblDRLo.Text = "Initial Lo";
            lblDRLo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(4, 24);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(60, 17);
            lblDRL.TabIndex = 61;
            lblDRL.Text = "Initial Lat";
            lblDRL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(132, 46);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(9, 17);
            Label6.TabIndex = 60;
            Label6.Text = "'";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(92, 46);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 17);
            Label5.TabIndex = 59;
            Label5.Text = "°";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(132, 22);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 57;
            Label3.Text = "'";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(92, 22);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(9, 17);
            Label2.TabIndex = 56;
            Label2.Text = "°";
            // 
            // lblCourse
            // 
            lblCourse.BackColor = SystemColors.Window;
            lblCourse.Cursor = Cursors.Default;
            lblCourse.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCourse.ForeColor = SystemColors.ControlText;
            lblCourse.Location = new Point(189, 24);
            lblCourse.Name = "lblCourse";
            lblCourse.RightToLeft = RightToLeft.No;
            lblCourse.Size = new Size(90, 18);
            lblCourse.TabIndex = 76;
            lblCourse.Text = "Initial Course";
            lblCourse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCourse
            // 
            _txtCourse.AcceptsReturn = true;
            _txtCourse.BackColor = SystemColors.Window;
            _txtCourse.Cursor = Cursors.IBeam;
            _txtCourse.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCourse.ForeColor = SystemColors.WindowText;
            _txtCourse.Location = new Point(293, 23);
            _txtCourse.MaxLength = 5;
            _txtCourse.Name = "_txtCourse";
            _txtCourse.RightToLeft = RightToLeft.No;
            _txtCourse.Size = new Size(50, 22);
            _txtCourse.TabIndex = 75;
            _txtCourse.TextAlign = HorizontalAlignment.Center;
            // 
            // lblnm
            // 
            lblnm.BackColor = SystemColors.Window;
            lblnm.Cursor = Cursors.Default;
            lblnm.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblnm.ForeColor = SystemColors.ControlText;
            lblnm.Location = new Point(344, 50);
            lblnm.Name = "lblnm";
            lblnm.RightToLeft = RightToLeft.No;
            lblnm.Size = new Size(30, 17);
            lblnm.TabIndex = 80;
            lblnm.Text = "nm";
            lblnm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDist
            // 
            _txtDist.AcceptsReturn = true;
            _txtDist.BackColor = SystemColors.Window;
            _txtDist.Cursor = Cursors.IBeam;
            _txtDist.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDist.ForeColor = SystemColors.WindowText;
            _txtDist.Location = new Point(293, 48);
            _txtDist.MaxLength = 7;
            _txtDist.Name = "_txtDist";
            _txtDist.RightToLeft = RightToLeft.No;
            _txtDist.Size = new Size(50, 22);
            _txtDist.TabIndex = 78;
            _txtDist.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDistance
            // 
            lblDistance.BackColor = SystemColors.Window;
            lblDistance.Cursor = Cursors.Default;
            lblDistance.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDistance.ForeColor = SystemColors.ControlText;
            lblDistance.Location = new Point(190, 49);
            lblDistance.Name = "lblDistance";
            lblDistance.RightToLeft = RightToLeft.No;
            lblDistance.Size = new Size(100, 17);
            lblDistance.TabIndex = 79;
            lblDistance.Text = "Distance Traveled";
            lblDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSailings
            // 
            txtSailings.BackColor = SystemColors.Window;
            txtSailings.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSailings.Location = new Point(3, 71);
            txtSailings.Name = "txtSailings";
            txtSailings.ReadOnly = true;
            txtSailings.Size = new Size(471, 416);
            txtSailings.TabIndex = 108;
            txtSailings.Text = "";
            // 
            // cmdCalculate
            // 
            _cmdCalculate.BackColor = Color.Yellow;
            _cmdCalculate.Cursor = Cursors.Default;
            _cmdCalculate.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculate.ForeColor = SystemColors.ControlText;
            _cmdCalculate.Location = new Point(401, 40);
            _cmdCalculate.Name = "_cmdCalculate";
            _cmdCalculate.RightToLeft = RightToLeft.No;
            _cmdCalculate.Size = new Size(73, 25);
            _cmdCalculate.TabIndex = 107;
            _cmdCalculate.Text = "Calculate";
            _cmdCalculate.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(95, 564);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(295, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 112;
            PictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(401, 564);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(73, 25);
            _ExitBtn.TabIndex = 111;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // cmdPrint
            // 
            cmdPrint.BackColor = SystemColors.Control;
            cmdPrint.Cursor = Cursors.Default;
            cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cmdPrint.ForeColor = SystemColors.ControlText;
            cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            cmdPrint.Location = new Point(581, -55);
            cmdPrint.Name = "cmdPrint";
            cmdPrint.RightToLeft = RightToLeft.No;
            cmdPrint.Size = new Size(21, 21);
            cmdPrint.TabIndex = 110;
            cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            cmdPrint.UseVisualStyleBackColor = false;
            // 
            // btnPrintScreen
            // 
            _btnPrintScreen.BackColor = SystemColors.Control;
            _btnPrintScreen.Cursor = Cursors.Default;
            _btnPrintScreen.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPrintScreen.ForeColor = SystemColors.ControlText;
            _btnPrintScreen.Image = (Image)resources.GetObject("btnPrintScreen.Image");
            _btnPrintScreen.Location = new Point(453, 6);
            _btnPrintScreen.Name = "_btnPrintScreen";
            _btnPrintScreen.RightToLeft = RightToLeft.No;
            _btnPrintScreen.Size = new Size(21, 21);
            _btnPrintScreen.TabIndex = 113;
            _btnPrintScreen.TextAlign = ContentAlignment.BottomCenter;
            _btnPrintScreen.UseVisualStyleBackColor = false;
            // 
            // lblCourseDeg
            // 
            lblCourseDeg.BackColor = SystemColors.Window;
            lblCourseDeg.Cursor = Cursors.Default;
            lblCourseDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCourseDeg.ForeColor = SystemColors.ControlText;
            lblCourseDeg.Location = new Point(345, 25);
            lblCourseDeg.Name = "lblCourseDeg";
            lblCourseDeg.RightToLeft = RightToLeft.No;
            lblCourseDeg.Size = new Size(9, 17);
            lblCourseDeg.TabIndex = 114;
            lblCourseDeg.Text = "°";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(357, 25);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(35, 17);
            Label1.TabIndex = 115;
            Label1.Text = "True";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTraverseTbl
            // 
            txtTraverseTbl.BackColor = SystemColors.Window;
            txtTraverseTbl.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtTraverseTbl.Location = new Point(3, 493);
            txtTraverseTbl.Name = "txtTraverseTbl";
            txtTraverseTbl.ReadOnly = true;
            txtTraverseTbl.Size = new Size(471, 65);
            txtTraverseTbl.TabIndex = 116;
            txtTraverseTbl.Text = "";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(137, 4);
            Label4.Name = "Label4";
            Label4.Size = new Size(203, 15);
            Label4.TabIndex = 117;
            Label4.Text = "Simplified Traverse Table WorkSheet";
            // 
            // TraverseTable
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 621);
            Controls.Add(Label4);
            Controls.Add(txtTraverseTbl);
            Controls.Add(Label1);
            Controls.Add(lblCourseDeg);
            Controls.Add(_btnPrintScreen);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(cmdPrint);
            Controls.Add(txtSailings);
            Controls.Add(_cmdCalculate);
            Controls.Add(lblnm);
            Controls.Add(_txtDist);
            Controls.Add(lblDistance);
            Controls.Add(lblCourse);
            Controls.Add(_txtCourse);
            Controls.Add(cboLo1);
            Controls.Add(_txtLo1Min);
            Controls.Add(_txtLo1Deg);
            Controls.Add(_txtL1Deg);
            Controls.Add(cboL1);
            Controls.Add(_txtL1Min);
            Controls.Add(lblDRLo);
            Controls.Add(lblDRL);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Name = "TraverseTable";
            Text = "TraverseTable";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(TraverseTable_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        public ComboBox cboLo1;
        private TextBox _txtLo1Min;

        public TextBox txtLo1Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLo1Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLo1Min != null)
                {
                    _txtLo1Min.TextChanged -= txtLo1Min_TextChanged;
                    _txtLo1Min.KeyPress -= txtLo1Min_KeyPress;
                    _txtLo1Min.Validating -= txtLo1Min_Validating;
                    _txtLo1Min.Enter -= txtLo1Min_Enter;
                }

                _txtLo1Min = value;
                if (_txtLo1Min != null)
                {
                    _txtLo1Min.TextChanged += txtLo1Min_TextChanged;
                    _txtLo1Min.KeyPress += txtLo1Min_KeyPress;
                    _txtLo1Min.Validating += txtLo1Min_Validating;
                    _txtLo1Min.Enter += txtLo1Min_Enter;
                }
            }
        }

        private TextBox _txtLo1Deg;

        public TextBox txtLo1Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLo1Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLo1Deg != null)
                {
                    _txtLo1Deg.TextChanged -= txtLo1Deg_TextChanged;
                    _txtLo1Deg.KeyPress -= txtLo1Deg_KeyPress;
                    _txtLo1Deg.Validating -= txtLo1Deg_Validating;
                    _txtLo1Deg.Enter -= txtLo1Deg_Enter;
                }

                _txtLo1Deg = value;
                if (_txtLo1Deg != null)
                {
                    _txtLo1Deg.TextChanged += txtLo1Deg_TextChanged;
                    _txtLo1Deg.KeyPress += txtLo1Deg_KeyPress;
                    _txtLo1Deg.Validating += txtLo1Deg_Validating;
                    _txtLo1Deg.Enter += txtLo1Deg_Enter;
                }
            }
        }

        private TextBox _txtL1Deg;

        public TextBox txtL1Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL1Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL1Deg != null)
                {
                    _txtL1Deg.TextChanged -= txtL1Deg_TextChanged;
                    _txtL1Deg.KeyPress -= txtL1Deg_KeyPress;
                    _txtL1Deg.Validating -= txtL1Deg_Validating;
                    _txtL1Deg.Enter -= txtL1Deg_Enter;
                }

                _txtL1Deg = value;
                if (_txtL1Deg != null)
                {
                    _txtL1Deg.TextChanged += txtL1Deg_TextChanged;
                    _txtL1Deg.KeyPress += txtL1Deg_KeyPress;
                    _txtL1Deg.Validating += txtL1Deg_Validating;
                    _txtL1Deg.Enter += txtL1Deg_Enter;
                }
            }
        }

        public ComboBox cboL1;
        private TextBox _txtL1Min;

        public TextBox txtL1Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL1Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL1Min != null)
                {
                    _txtL1Min.TextChanged -= txtL1Min_TextChanged;
                    _txtL1Min.KeyPress -= txtL1Min_KeyPress;
                    _txtL1Min.Validating -= txtL1Min_Validating;
                    _txtL1Min.Enter -= txtL1Min_Enter;
                }

                _txtL1Min = value;
                if (_txtL1Min != null)
                {
                    _txtL1Min.TextChanged += txtL1Min_TextChanged;
                    _txtL1Min.KeyPress += txtL1Min_KeyPress;
                    _txtL1Min.Validating += txtL1Min_Validating;
                    _txtL1Min.Enter += txtL1Min_Enter;
                }
            }
        }

        public Label lblDRLo;
        public Label lblDRL;
        public Label Label6;
        public Label Label5;
        public Label Label3;
        public Label Label2;
        public Label lblCourse;
        private TextBox _txtCourse;

        public TextBox txtCourse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCourse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCourse != null)
                {
                    _txtCourse.TextChanged -= txtCourse_TextChanged;
                    _txtCourse.KeyPress -= txtCourse_KeyPress;
                    _txtCourse.Validating -= txtCourse_Validating;
                    _txtCourse.Enter -= txtCourse_Enter;
                }

                _txtCourse = value;
                if (_txtCourse != null)
                {
                    _txtCourse.TextChanged += txtCourse_TextChanged;
                    _txtCourse.KeyPress += txtCourse_KeyPress;
                    _txtCourse.Validating += txtCourse_Validating;
                    _txtCourse.Enter += txtCourse_Enter;
                }
            }
        }

        public Label lblnm;
        private TextBox _txtDist;

        public TextBox txtDist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDist != null)
                {
                    _txtDist.TextChanged -= txtDist_TextChanged;
                    _txtDist.KeyPress -= txtDist_KeyPress;
                    _txtDist.Validating -= txtDist_Validating;
                    _txtDist.Enter -= txtDist_Enter;
                }

                _txtDist = value;
                if (_txtDist != null)
                {
                    _txtDist.TextChanged += txtDist_TextChanged;
                    _txtDist.KeyPress += txtDist_KeyPress;
                    _txtDist.Validating += txtDist_Validating;
                    _txtDist.Enter += txtDist_Enter;
                }
            }
        }

        public Label lblDistance;
        internal RichTextBox txtSailings;
        private Button _cmdCalculate;

        public Button cmdCalculate
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

        public Button cmdPrint;
        private Button _btnPrintScreen;

        public Button btnPrintScreen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrintScreen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrintScreen != null)
                {
                    _btnPrintScreen.Click -= btnPrintScreen_Click;
                }

                _btnPrintScreen = value;
                if (_btnPrintScreen != null)
                {
                    _btnPrintScreen.Click += btnPrintScreen_Click;
                }
            }
        }

        public Label lblCourseDeg;
        public Label Label1;
        internal RichTextBox txtTraverseTbl;
        internal Label Label4;
    }
}