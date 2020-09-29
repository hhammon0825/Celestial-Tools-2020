using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class frmCredits
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public frmCredits() : base()
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
        public TextBox Text1;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredits));
            ToolTip1 = new ToolTip(components);
            Text1 = new TextBox();
            SuspendLayout();
            // 
            // Text1
            // 
            Text1.AcceptsReturn = true;
            Text1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            Text1.CausesValidation = false;
            Text1.Cursor = Cursors.Default;
            Text1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Text1.ForeColor = SystemColors.WindowText;
            Text1.Location = new Point(0, 0);
            Text1.MaxLength = 0;
            Text1.Multiline = true;
            Text1.Name = "Text1";
            Text1.ReadOnly = true;
            Text1.RightToLeft = RightToLeft.No;
            Text1.Size = new Size(345, 209);
            Text1.TabIndex = 0;
            Text1.TabStop = false;
            Text1.Text = resources.GetString("Text1.Text");
            // 
            // frmCredits
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(346, 210);
            Controls.Add(Text1);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "frmCredits";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credits";
            ResumeLayout(false);
            PerformLayout();
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}