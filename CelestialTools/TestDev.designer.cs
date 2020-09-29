using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class TestDev : Form
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
            UpDwnCompass = new NumericUpDown();
            Label1 = new Label();
            txtCompassDev = new TextBox();
            Label2 = new Label();
            _btnCompassDev = new Button();
            _btnCompassDev.Click += new EventHandler(btnCompassDev_Click);
            _btnMagDev = new Button();
            _btnMagDev.Click += new EventHandler(btnMagDev_Click);
            Label3 = new Label();
            txtMagDev = new TextBox();
            Label4 = new Label();
            UpDwnMag = new NumericUpDown();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            Label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)UpDwnCompass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDwnMag).BeginInit();
            SuspendLayout();
            // 
            // UpDwnCompass
            // 
            UpDwnCompass.Location = new Point(146, 40);
            UpDwnCompass.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            UpDwnCompass.Name = "UpDwnCompass";
            UpDwnCompass.Size = new Size(64, 20);
            UpDwnCompass.TabIndex = 0;
            UpDwnCompass.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(44, 43);
            Label1.Name = "Label1";
            Label1.Size = new Size(96, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Compass Heading:";
            // 
            // txtCompassDev
            // 
            txtCompassDev.BackColor = Color.White;
            txtCompassDev.Location = new Point(194, 76);
            txtCompassDev.Name = "txtCompassDev";
            txtCompassDev.ReadOnly = true;
            txtCompassDev.Size = new Size(282, 20);
            txtCompassDev.TabIndex = 2;
            txtCompassDev.TabStop = false;
            txtCompassDev.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(44, 80);
            Label2.Name = "Label2";
            Label2.Size = new Size(147, 13);
            Label2.TabIndex = 3;
            Label2.Text = "Compass Based Interpolation:";
            // 
            // btnCompassDev
            // 
            _btnCompassDev.BackColor = Color.Blue;
            _btnCompassDev.ForeColor = Color.White;
            _btnCompassDev.Location = new Point(238, 38);
            _btnCompassDev.Name = "_btnCompassDev";
            _btnCompassDev.Size = new Size(180, 23);
            _btnCompassDev.TabIndex = 4;
            _btnCompassDev.Text = "Get Compass Based Interpolation";
            _btnCompassDev.UseVisualStyleBackColor = false;
            // 
            // btnMagDev
            // 
            _btnMagDev.BackColor = Color.Yellow;
            _btnMagDev.Location = new Point(238, 110);
            _btnMagDev.Name = "_btnMagDev";
            _btnMagDev.Size = new Size(180, 23);
            _btnMagDev.TabIndex = 9;
            _btnMagDev.Text = "Get Magnetic Based Interpolation";
            _btnMagDev.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(43, 154);
            Label3.Name = "Label3";
            Label3.Size = new Size(148, 13);
            Label3.TabIndex = 8;
            Label3.Text = "Magnetic Based Interpolation:";
            // 
            // txtMagDev
            // 
            txtMagDev.BackColor = Color.White;
            txtMagDev.Location = new Point(194, 150);
            txtMagDev.Name = "txtMagDev";
            txtMagDev.ReadOnly = true;
            txtMagDev.Size = new Size(282, 20);
            txtMagDev.TabIndex = 7;
            txtMagDev.TabStop = false;
            txtMagDev.TextAlign = HorizontalAlignment.Center;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(44, 115);
            Label4.Name = "Label4";
            Label4.Size = new Size(97, 13);
            Label4.TabIndex = 6;
            Label4.Text = "Magnetic Heading:";
            // 
            // UpDwnMag
            // 
            UpDwnMag.Location = new Point(146, 112);
            UpDwnMag.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            UpDwnMag.Name = "UpDwnMag";
            UpDwnMag.Size = new Size(64, 20);
            UpDwnMag.TabIndex = 5;
            UpDwnMag.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.ForeColor = Color.White;
            _btnExit.Location = new Point(194, 201);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(117, 23);
            _btnExit.TabIndex = 10;
            _btnExit.Text = "Exit Interpolation Test";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Arial Narrow", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(42, 9);
            Label5.Name = "Label5";
            Label5.Size = new Size(442, 20);
            Label5.TabIndex = 11;
            Label5.Text = "Test Interpolation of Deviation Data for Compass or Magnetic Heading";
            // 
            // TestDev
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 239);
            Controls.Add(Label5);
            Controls.Add(_btnExit);
            Controls.Add(_btnMagDev);
            Controls.Add(Label3);
            Controls.Add(txtMagDev);
            Controls.Add(Label4);
            Controls.Add(UpDwnMag);
            Controls.Add(_btnCompassDev);
            Controls.Add(Label2);
            Controls.Add(txtCompassDev);
            Controls.Add(Label1);
            Controls.Add(UpDwnCompass);
            Name = "TestDev";
            Text = "TestDev";
            ((System.ComponentModel.ISupportInitialize)UpDwnCompass).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDwnMag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal NumericUpDown UpDwnCompass;
        internal Label Label1;
        internal TextBox txtCompassDev;
        internal Label Label2;
        private Button _btnCompassDev;

        internal Button btnCompassDev
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCompassDev;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCompassDev != null)
                {
                    _btnCompassDev.Click -= btnCompassDev_Click;
                }

                _btnCompassDev = value;
                if (_btnCompassDev != null)
                {
                    _btnCompassDev.Click += btnCompassDev_Click;
                }
            }
        }

        private Button _btnMagDev;

        internal Button btnMagDev
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnMagDev;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMagDev != null)
                {
                    _btnMagDev.Click -= btnMagDev_Click;
                }

                _btnMagDev = value;
                if (_btnMagDev != null)
                {
                    _btnMagDev.Click += btnMagDev_Click;
                }
            }
        }

        internal Label Label3;
        internal TextBox txtMagDev;
        internal Label Label4;
        internal NumericUpDown UpDwnMag;
        private Button _btnExit;

        internal Button btnExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExit != null)
                {
                    _btnExit.Click -= btnExit_Click;
                }

                _btnExit = value;
                if (_btnExit != null)
                {
                    _btnExit.Click += btnExit_Click;
                }
            }
        }

        internal Label Label5;
    }
}