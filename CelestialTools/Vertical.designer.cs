using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormVertical
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormVertical() : base()
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
        private TextBox _txtBH;

        public TextBox txtBH
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBH;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBH != null)
                {
                    _txtBH.TextChanged -= txtBH_TextChanged;
                    _txtBH.KeyPress -= txtBH_KeyPress;
                    _txtBH.Validating -= txtBH_Validating;
                    _txtBH.Enter -= txtBH_Enter;
                }

                _txtBH = value;
                if (_txtBH != null)
                {
                    _txtBH.TextChanged += txtBH_TextChanged;
                    _txtBH.KeyPress += txtBH_KeyPress;
                    _txtBH.Validating += txtBH_Validating;
                    _txtBH.Enter += txtBH_Enter;
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

        private Button _cmdClear;

        public Button cmdClear
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

        private TextBox _txtDraft;

        public TextBox txtDraft
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDraft;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDraft != null)
                {
                    _txtDraft.TextChanged -= txtDraft_TextChanged;
                    _txtDraft.KeyPress -= txtDraft_KeyPress;
                    _txtDraft.Validating -= txtDraft_Validating;
                    _txtDraft.Enter -= txtDraft_Enter;
                }

                _txtDraft = value;
                if (_txtDraft != null)
                {
                    _txtDraft.TextChanged += txtDraft_TextChanged;
                    _txtDraft.KeyPress += txtDraft_KeyPress;
                    _txtDraft.Validating += txtDraft_Validating;
                    _txtDraft.Enter += txtDraft_Enter;
                }
            }
        }

        private TextBox _txtCD;

        public TextBox txtCD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCD != null)
                {
                    _txtCD.TextChanged -= txtCD_TextChanged;
                    _txtCD.KeyPress -= txtCD_KeyPress;
                    _txtCD.Validating -= txtCD_Validating;
                    _txtCD.Enter -= txtCD_Enter;
                }

                _txtCD = value;
                if (_txtCD != null)
                {
                    _txtCD.TextChanged += txtCD_TextChanged;
                    _txtCD.KeyPress += txtCD_KeyPress;
                    _txtCD.Validating += txtCD_Validating;
                    _txtCD.Enter += txtCD_Enter;
                }
            }
        }

        private TextBox _txtHeight;

        public TextBox txtHeight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHeight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHeight != null)
                {
                    _txtHeight.TextChanged -= txtHeight_TextChanged;
                    _txtHeight.KeyPress -= txtHeight_KeyPress;
                    _txtHeight.Validating -= txtHeight_Validating;
                    _txtHeight.Enter -= txtHeight_Enter;
                }

                _txtHeight = value;
                if (_txtHeight != null)
                {
                    _txtHeight.TextChanged += txtHeight_TextChanged;
                    _txtHeight.KeyPress += txtHeight_KeyPress;
                    _txtHeight.Validating += txtHeight_Validating;
                    _txtHeight.Enter += txtHeight_Enter;
                }
            }
        }

        private TextBox _txtCH;

        public TextBox txtCH
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCH;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCH != null)
                {
                    _txtCH.TextChanged -= txtCH_TextChanged;
                    _txtCH.KeyPress -= txtCH_KeyPress;
                    _txtCH.Validating -= txtCH_Validating;
                    _txtCH.Enter -= txtCH_Enter;
                }

                _txtCH = value;
                if (_txtCH != null)
                {
                    _txtCH.TextChanged += txtCH_TextChanged;
                    _txtCH.KeyPress += txtCH_KeyPress;
                    _txtCH.Validating += txtCH_Validating;
                    _txtCH.Enter += txtCH_Enter;
                }
            }
        }

        private TextBox _txtMTR;

        public TextBox txtMTR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMTR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMTR != null)
                {
                    _txtMTR.TextChanged -= txtMTR_TextChanged;
                    _txtMTR.KeyPress -= txtMTR_KeyPress;
                    _txtMTR.Validating -= txtMTR_Validating;
                    _txtMTR.Enter -= txtMTR_Enter;
                }

                _txtMTR = value;
                if (_txtMTR != null)
                {
                    _txtMTR.TextChanged += txtMTR_TextChanged;
                    _txtMTR.KeyPress += txtMTR_KeyPress;
                    _txtMTR.Validating += txtMTR_Validating;
                    _txtMTR.Enter += txtMTR_Enter;
                }
            }
        }

        private TextBox _txtMTL;

        public TextBox txtMTL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMTL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMTL != null)
                {
                    _txtMTL.TextChanged -= txtMTL_TextChanged;
                    _txtMTL.KeyPress -= txtMTL_KeyPress;
                    _txtMTL.Validating -= txtMTL_Validating;
                    _txtMTL.Enter -= txtMTL_Enter;
                }

                _txtMTL = value;
                if (_txtMTL != null)
                {
                    _txtMTL.TextChanged += txtMTL_TextChanged;
                    _txtMTL.KeyPress += txtMTL_KeyPress;
                    _txtMTL.Validating += txtMTL_Validating;
                    _txtMTL.Enter += txtMTL_Enter;
                }
            }
        }

        private Button _cmdCalcVert;

        public Button cmdCalcVert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalcVert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalcVert != null)
                {
                    _cmdCalcVert.Click -= cmdCalcVert_Click;
                }

                _cmdCalcVert = value;
                if (_cmdCalcVert != null)
                {
                    _cmdCalcVert.Click += cmdCalcVert_Click;
                }
            }
        }

        public Label Label1;
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label14;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label9;
        public Label Label7;
        public Label Label6;
        public Label Label5;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVertical));
            ToolTip1 = new ToolTip(components);
            _txtBH = new TextBox();
            _txtBH.TextChanged += new EventHandler(txtBH_TextChanged);
            _txtBH.KeyPress += new KeyPressEventHandler(txtBH_KeyPress);
            _txtBH.Validating += new System.ComponentModel.CancelEventHandler(txtBH_Validating);
            _txtBH.Enter += new EventHandler(txtBH_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtDraft = new TextBox();
            _txtDraft.TextChanged += new EventHandler(txtDraft_TextChanged);
            _txtDraft.KeyPress += new KeyPressEventHandler(txtDraft_KeyPress);
            _txtDraft.Validating += new System.ComponentModel.CancelEventHandler(txtDraft_Validating);
            _txtDraft.Enter += new EventHandler(txtDraft_Enter);
            _txtCD = new TextBox();
            _txtCD.TextChanged += new EventHandler(txtCD_TextChanged);
            _txtCD.KeyPress += new KeyPressEventHandler(txtCD_KeyPress);
            _txtCD.Validating += new System.ComponentModel.CancelEventHandler(txtCD_Validating);
            _txtCD.Enter += new EventHandler(txtCD_Enter);
            _txtHeight = new TextBox();
            _txtHeight.TextChanged += new EventHandler(txtHeight_TextChanged);
            _txtHeight.KeyPress += new KeyPressEventHandler(txtHeight_KeyPress);
            _txtHeight.Validating += new System.ComponentModel.CancelEventHandler(txtHeight_Validating);
            _txtHeight.Enter += new EventHandler(txtHeight_Enter);
            _txtCH = new TextBox();
            _txtCH.TextChanged += new EventHandler(txtCH_TextChanged);
            _txtCH.KeyPress += new KeyPressEventHandler(txtCH_KeyPress);
            _txtCH.Validating += new System.ComponentModel.CancelEventHandler(txtCH_Validating);
            _txtCH.Enter += new EventHandler(txtCH_Enter);
            _txtMTR = new TextBox();
            _txtMTR.TextChanged += new EventHandler(txtMTR_TextChanged);
            _txtMTR.KeyPress += new KeyPressEventHandler(txtMTR_KeyPress);
            _txtMTR.Validating += new System.ComponentModel.CancelEventHandler(txtMTR_Validating);
            _txtMTR.Enter += new EventHandler(txtMTR_Enter);
            _txtMTL = new TextBox();
            _txtMTL.TextChanged += new EventHandler(txtMTL_TextChanged);
            _txtMTL.KeyPress += new KeyPressEventHandler(txtMTL_KeyPress);
            _txtMTL.Validating += new System.ComponentModel.CancelEventHandler(txtMTL_Validating);
            _txtMTL.Enter += new EventHandler(txtMTL_Enter);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            _cmdCalcVert = new Button();
            _cmdCalcVert.Click += new EventHandler(cmdCalcVert_Click);
            Label1 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label9 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            VerticalTxtBx = new RichTextBox();
            DepthTxtBx = new RichTextBox();
            PictureBox1 = new PictureBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBH
            // 
            _txtBH.AcceptsReturn = true;
            _txtBH.BackColor = SystemColors.Window;
            _txtBH.Cursor = Cursors.IBeam;
            _txtBH.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBH.ForeColor = SystemColors.WindowText;
            _txtBH.Location = new Point(320, 136);
            _txtBH.MaxLength = 5;
            _txtBH.Name = "_txtBH";
            _txtBH.RightToLeft = RightToLeft.No;
            _txtBH.Size = new Size(41, 21);
            _txtBH.TabIndex = 4;
            ToolTip1.SetToolTip(_txtBH, "Max. 999.9");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(460, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 17;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtDraft
            // 
            _txtDraft.AcceptsReturn = true;
            _txtDraft.BackColor = SystemColors.Window;
            _txtDraft.Cursor = Cursors.IBeam;
            _txtDraft.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDraft.ForeColor = SystemColors.WindowText;
            _txtDraft.Location = new Point(328, 304);
            _txtDraft.MaxLength = 4;
            _txtDraft.Name = "_txtDraft";
            _txtDraft.RightToLeft = RightToLeft.No;
            _txtDraft.Size = new Size(33, 21);
            _txtDraft.TabIndex = 6;
            ToolTip1.SetToolTip(_txtDraft, "Range 0 to 99.9");
            // 
            // txtCD
            // 
            _txtCD.AcceptsReturn = true;
            _txtCD.BackColor = SystemColors.Window;
            _txtCD.Cursor = Cursors.IBeam;
            _txtCD.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCD.ForeColor = SystemColors.WindowText;
            _txtCD.Location = new Point(328, 280);
            _txtCD.MaxLength = 4;
            _txtCD.Name = "_txtCD";
            _txtCD.RightToLeft = RightToLeft.No;
            _txtCD.Size = new Size(33, 21);
            _txtCD.TabIndex = 5;
            ToolTip1.SetToolTip(_txtCD, "Range 0 to 99.9");
            // 
            // txtHeight
            // 
            _txtHeight.AcceptsReturn = true;
            _txtHeight.BackColor = SystemColors.Window;
            _txtHeight.Cursor = Cursors.IBeam;
            _txtHeight.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHeight.ForeColor = SystemColors.WindowText;
            _txtHeight.Location = new Point(328, 8);
            _txtHeight.MaxLength = 5;
            _txtHeight.Name = "_txtHeight";
            _txtHeight.RightToLeft = RightToLeft.No;
            _txtHeight.Size = new Size(33, 21);
            _txtHeight.TabIndex = 0;
            ToolTip1.SetToolTip(_txtHeight, "Range -99.9 to 99.9");
            // 
            // txtCH
            // 
            _txtCH.AcceptsReturn = true;
            _txtCH.BackColor = SystemColors.Window;
            _txtCH.Cursor = Cursors.IBeam;
            _txtCH.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCH.ForeColor = SystemColors.WindowText;
            _txtCH.Location = new Point(320, 64);
            _txtCH.MaxLength = 5;
            _txtCH.Name = "_txtCH";
            _txtCH.RightToLeft = RightToLeft.No;
            _txtCH.Size = new Size(41, 21);
            _txtCH.TabIndex = 1;
            ToolTip1.SetToolTip(_txtCH, "Range 0 to 999.9");
            // 
            // txtMTR
            // 
            _txtMTR.AcceptsReturn = true;
            _txtMTR.BackColor = SystemColors.Window;
            _txtMTR.Cursor = Cursors.IBeam;
            _txtMTR.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMTR.ForeColor = SystemColors.WindowText;
            _txtMTR.Location = new Point(328, 88);
            _txtMTR.MaxLength = 4;
            _txtMTR.Name = "_txtMTR";
            _txtMTR.RightToLeft = RightToLeft.No;
            _txtMTR.Size = new Size(33, 21);
            _txtMTR.TabIndex = 2;
            ToolTip1.SetToolTip(_txtMTR, "Range 0 to 99.9");
            // 
            // txtMTL
            // 
            _txtMTL.AcceptsReturn = true;
            _txtMTL.BackColor = SystemColors.Window;
            _txtMTL.Cursor = Cursors.IBeam;
            _txtMTL.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMTL.ForeColor = SystemColors.WindowText;
            _txtMTL.Location = new Point(328, 112);
            _txtMTL.MaxLength = 4;
            _txtMTL.Name = "_txtMTL";
            _txtMTL.RightToLeft = RightToLeft.No;
            _txtMTL.Size = new Size(33, 21);
            _txtMTL.TabIndex = 3;
            ToolTip1.SetToolTip(_txtMTL, "Range 0 to 99.9");
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = SystemColors.Control;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(328, 376);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(89, 25);
            _cmdClear.TabIndex = 8;
            _cmdClear.Text = "&Clear";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // cmdCalcVert
            // 
            _cmdCalcVert.BackColor = SystemColors.Control;
            _cmdCalcVert.Cursor = Cursors.Default;
            _cmdCalcVert.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalcVert.ForeColor = SystemColors.ControlText;
            _cmdCalcVert.Location = new Point(64, 376);
            _cmdCalcVert.Name = "_cmdCalcVert";
            _cmdCalcVert.RightToLeft = RightToLeft.No;
            _cmdCalcVert.Size = new Size(177, 25);
            _cmdCalcVert.TabIndex = 7;
            _cmdCalcVert.Text = "Calculate &Vertical Clearances";
            _cmdCalcVert.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(120, 136);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(89, 17);
            Label1.TabIndex = 18;
            Label1.Text = "Boat (mast) height";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(96, 8);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(137, 17);
            Label14.TabIndex = 16;
            Label14.Text = "Height of tide at desired time";
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(120, 88);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(161, 17);
            Label13.TabIndex = 15;
            Label13.Text = "Mean Tidal Range (from Table 2)";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(120, 112);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(153, 17);
            Label12.TabIndex = 14;
            Label12.Text = "Mean Tide Level (from Table 2)";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(120, 64);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(193, 17);
            Label11.TabIndex = 13;
            Label11.Text = "Charted Height of object (above MHW)";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(120, 304);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(57, 17);
            Label9.TabIndex = 12;
            Label9.Text = "Boat's Draft";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(120, 280);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(73, 17);
            Label7.TabIndex = 11;
            Label7.Text = "Charted Depth";
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(200, 256);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(89, 17);
            Label6.TabIndex = 10;
            Label6.Text = "Depth Under Keel";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(200, 40);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(89, 17);
            Label5.TabIndex = 9;
            Label5.Text = "Vertical Clearance";
            // 
            // VerticalTxtBx
            // 
            VerticalTxtBx.BorderStyle = BorderStyle.None;
            VerticalTxtBx.Location = new Point(2, 159);
            VerticalTxtBx.Name = "VerticalTxtBx";
            VerticalTxtBx.ReadOnly = true;
            VerticalTxtBx.Size = new Size(476, 85);
            VerticalTxtBx.TabIndex = 20;
            VerticalTxtBx.Text = "";
            // 
            // DepthTxtBx
            // 
            DepthTxtBx.BorderStyle = BorderStyle.None;
            DepthTxtBx.Location = new Point(2, 327);
            DepthTxtBx.Name = "DepthTxtBx";
            DepthTxtBx.ReadOnly = true;
            DepthTxtBx.Size = new Size(476, 35);
            DepthTxtBx.TabIndex = 21;
            DepthTxtBx.Text = "";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(67, 405);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 103;
            PictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(406, 407);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(63, 25);
            _ExitBtn.TabIndex = 108;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // FormVertical
            // 
            AutoScaleDimensions = new SizeF(6.0f, 14.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(481, 458);
            Controls.Add(_ExitBtn);
            Controls.Add(PictureBox1);
            Controls.Add(DepthTxtBx);
            Controls.Add(VerticalTxtBx);
            Controls.Add(_txtBH);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdClear);
            Controls.Add(_txtDraft);
            Controls.Add(_txtCD);
            Controls.Add(_txtHeight);
            Controls.Add(_txtCH);
            Controls.Add(_txtMTR);
            Controls.Add(_txtMTL);
            Controls.Add(_cmdCalcVert);
            Controls.Add(Label1);
            Controls.Add(Label14);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(Label9);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Cursor = Cursors.Default;
            Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 22);
            MaximizeBox = false;
            Name = "FormVertical";
            RightToLeft = RightToLeft.No;
            Text = "Vertical Clearances";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormVertical_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal RichTextBox VerticalTxtBx;
        internal RichTextBox DepthTxtBx;
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
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}