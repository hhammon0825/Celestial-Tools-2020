using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class HelpV2 : Form
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
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            _cboHelpList = new ComboBox();
            _cboHelpList.SelectedIndexChanged += new EventHandler(cboHelpList_SelectedIndexChanged);
            txtHelpInfo = new RichTextBox();
            lblSelScreen = new Label();
            _btnPrintThisInfo = new Button();
            _btnPrintThisInfo.Click += new EventHandler(btnPrintThisInfo_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = Color.White;
            _ExitBtn.Location = new Point(587, 661);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(75, 23);
            _ExitBtn.TabIndex = 38;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BorderStyle = BorderStyle.Fixed3D;
            Label1.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(190, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(257, 26);
            Label1.TabIndex = 40;
            Label1.Text = "Celestial Tools Help Info ";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(190, 653);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 123;
            PictureBox1.TabStop = false;
            // 
            // cboHelpList
            // 
            _cboHelpList.BackColor = SystemColors.Window;
            _cboHelpList.Cursor = Cursors.Default;
            _cboHelpList.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboHelpList.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboHelpList.ForeColor = SystemColors.WindowText;
            _cboHelpList.Location = new Point(210, 42);
            _cboHelpList.Name = "_cboHelpList";
            _cboHelpList.RightToLeft = RightToLeft.No;
            _cboHelpList.Size = new Size(225, 22);
            _cboHelpList.TabIndex = 124;
            // 
            // txtHelpInfo
            // 
            txtHelpInfo.Location = new Point(13, 70);
            txtHelpInfo.Margin = new Padding(10);
            txtHelpInfo.Name = "txtHelpInfo";
            txtHelpInfo.ReadOnly = true;
            txtHelpInfo.Size = new Size(649, 573);
            txtHelpInfo.TabIndex = 125;
            txtHelpInfo.TabStop = false;
            txtHelpInfo.Text = "";
            // 
            // lblSelScreen
            // 
            lblSelScreen.AutoSize = true;
            lblSelScreen.Location = new Point(33, 47);
            lblSelScreen.Name = "lblSelScreen";
            lblSelScreen.Size = new Size(169, 13);
            lblSelScreen.TabIndex = 126;
            lblSelScreen.Text = "Select Screen Name For Help Info";
            // 
            // btnPrintThisInfo
            // 
            _btnPrintThisInfo.BackColor = Color.Yellow;
            _btnPrintThisInfo.Location = new Point(512, 42);
            _btnPrintThisInfo.Name = "_btnPrintThisInfo";
            _btnPrintThisInfo.Size = new Size(150, 23);
            _btnPrintThisInfo.TabIndex = 127;
            _btnPrintThisInfo.Text = "Print This Help Info";
            _btnPrintThisInfo.UseVisualStyleBackColor = false;
            // 
            // HelpV2
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 715);
            Controls.Add(_btnPrintThisInfo);
            Controls.Add(lblSelScreen);
            Controls.Add(txtHelpInfo);
            Controls.Add(_cboHelpList);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Controls.Add(_ExitBtn);
            Name = "HelpV2";
            Text = "Celestial Tools Help";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(HelpV2_Load);
            ResumeLayout(false);
            PerformLayout();
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

        internal Label Label1;
        internal PictureBox PictureBox1;
        private ComboBox _cboHelpList;

        public ComboBox cboHelpList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboHelpList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboHelpList != null)
                {
                    _cboHelpList.SelectedIndexChanged -= cboHelpList_SelectedIndexChanged;
                }

                _cboHelpList = value;
                if (_cboHelpList != null)
                {
                    _cboHelpList.SelectedIndexChanged += cboHelpList_SelectedIndexChanged;
                }
            }
        }

        internal RichTextBox txtHelpInfo;
        internal Label lblSelScreen;
        private Button _btnPrintThisInfo;

        internal Button btnPrintThisInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrintThisInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrintThisInfo != null)
                {
                    _btnPrintThisInfo.Click -= btnPrintThisInfo_Click;
                }

                _btnPrintThisInfo = value;
                if (_btnPrintThisInfo != null)
                {
                    _btnPrintThisInfo.Click += btnPrintThisInfo_Click;
                }
            }
        }
    }
}