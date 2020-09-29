using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class CSVUpdaterInfo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVUpdaterInfo));
            lblInfo = new Label();
            _btnInfoExit = new Button();
            _btnInfoExit.Click += new EventHandler(btnInfoExit_Click);
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BorderStyle = BorderStyle.Fixed3D;
            lblInfo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblInfo.Location = new Point(21, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(753, 274);
            lblInfo.TabIndex = 8;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnInfoExit
            // 
            _btnInfoExit.BackColor = Color.Red;
            _btnInfoExit.ForeColor = Color.White;
            _btnInfoExit.Location = new Point(656, 302);
            _btnInfoExit.Name = "_btnInfoExit";
            _btnInfoExit.Size = new Size(118, 23);
            _btnInfoExit.TabIndex = 9;
            _btnInfoExit.Text = "Exit";
            _btnInfoExit.UseVisualStyleBackColor = false;
            // 
            // CSVUpdaterInfo
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 347);
            Controls.Add(_btnInfoExit);
            Controls.Add(lblInfo);
            Name = "CSVUpdaterInfo";
            Text = "CSVUpdaterInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label lblInfo;
        private Button _btnInfoExit;

        internal Button btnInfoExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnInfoExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnInfoExit != null)
                {
                    _btnInfoExit.Click -= btnInfoExit_Click;
                }

                _btnInfoExit = value;
                if (_btnInfoExit != null)
                {
                    _btnInfoExit.Click += btnInfoExit_Click;
                }
            }
        }
    }
}