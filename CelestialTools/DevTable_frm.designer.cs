using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormDevTable_frm
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormDevTable_frm() : base()
        {
            // This call is required by the Windows Form Designer.
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

        public TextBox _txtEW_8;
        public TextBox _D_8;
        public TextBox _txtM_8;
        public TextBox _txtC_8;
        public TextBox _txtEW_7;
        public TextBox _txtEW_6;
        public TextBox _txtEW_5;
        public TextBox _txtEW_4;
        public TextBox _txtEW_3;
        public TextBox _txtEW_2;
        public TextBox _txtEW_1;
        public TextBox _txtEW_0;
        public TextBox _txtC_7;
        public TextBox _txtC_6;
        public TextBox _txtC_5;
        public TextBox _txtC_4;
        public TextBox _txtC_3;
        public TextBox _txtC_2;
        public TextBox _txtC_1;
        public TextBox _txtC_0;
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

        public TextBox _D_7;
        public TextBox _D_6;
        public TextBox _D_5;
        public TextBox _D_4;
        public TextBox _D_3;
        public TextBox _D_2;
        public TextBox _D_1;
        public TextBox _D_0;
        private TextBox __txtM_7;

        public TextBox _txtM_7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_7 != null)
                {
                    __txtM_7.TextChanged -= _txtM_7_TextChanged;
                }

                __txtM_7 = value;
                if (__txtM_7 != null)
                {
                    __txtM_7.TextChanged += _txtM_7_TextChanged;
                }
            }
        }

        private TextBox __txtM_6;

        public TextBox _txtM_6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_6 != null)
                {
                    __txtM_6.TextChanged -= _txtM_6_TextChanged;
                }

                __txtM_6 = value;
                if (__txtM_6 != null)
                {
                    __txtM_6.TextChanged += _txtM_6_TextChanged;
                }
            }
        }

        private TextBox __txtM_5;

        public TextBox _txtM_5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_5 != null)
                {
                    __txtM_5.TextChanged -= _txtM_5_TextChanged;
                }

                __txtM_5 = value;
                if (__txtM_5 != null)
                {
                    __txtM_5.TextChanged += _txtM_5_TextChanged;
                }
            }
        }

        private TextBox __txtM_4;

        public TextBox _txtM_4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_4 != null)
                {
                    __txtM_4.TextChanged -= _txtM_4_TextChanged;
                }

                __txtM_4 = value;
                if (__txtM_4 != null)
                {
                    __txtM_4.TextChanged += _txtM_4_TextChanged;
                }
            }
        }

        private TextBox __txtM_3;

        public TextBox _txtM_3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_3 != null)
                {
                    __txtM_3.TextChanged -= _txtM_3_TextChanged;
                }

                __txtM_3 = value;
                if (__txtM_3 != null)
                {
                    __txtM_3.TextChanged += _txtM_3_TextChanged;
                }
            }
        }

        private TextBox __txtM_2;

        public TextBox _txtM_2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_2 != null)
                {
                    __txtM_2.TextChanged -= _txtM_2_TextChanged;
                }

                __txtM_2 = value;
                if (__txtM_2 != null)
                {
                    __txtM_2.TextChanged += _txtM_2_TextChanged;
                }
            }
        }

        private TextBox __txtM_1;

        public TextBox _txtM_1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_1 != null)
                {
                    __txtM_1.TextChanged -= _txtM_1_TextChanged;
                }

                __txtM_1 = value;
                if (__txtM_1 != null)
                {
                    __txtM_1.TextChanged += _txtM_1_TextChanged;
                }
            }
        }

        private TextBox __txtM_0;

        public TextBox _txtM_0
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __txtM_0;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (__txtM_0 != null)
                {
                    __txtM_0.TextChanged -= _txtM_0_TextChanged;
                }

                __txtM_0 = value;
                if (__txtM_0 != null)
                {
                    __txtM_0.TextChanged += _txtM_0_TextChanged;
                }
            }
        }

        public Label Label1;
        public Label Label3;
        public Label Label2;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevTable_frm));
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtM_8 = new TextBox();
            __txtM_7 = new TextBox();
            __txtM_7.TextChanged += new EventHandler(_txtM_7_TextChanged);
            __txtM_6 = new TextBox();
            __txtM_6.TextChanged += new EventHandler(_txtM_6_TextChanged);
            __txtM_5 = new TextBox();
            __txtM_5.TextChanged += new EventHandler(_txtM_5_TextChanged);
            __txtM_4 = new TextBox();
            __txtM_4.TextChanged += new EventHandler(_txtM_4_TextChanged);
            __txtM_3 = new TextBox();
            __txtM_3.TextChanged += new EventHandler(_txtM_3_TextChanged);
            __txtM_2 = new TextBox();
            __txtM_2.TextChanged += new EventHandler(_txtM_2_TextChanged);
            __txtM_1 = new TextBox();
            __txtM_1.TextChanged += new EventHandler(_txtM_1_TextChanged);
            __txtM_0 = new TextBox();
            __txtM_0.TextChanged += new EventHandler(_txtM_0_TextChanged);
            _txtEW_8 = new TextBox();
            _D_8 = new TextBox();
            _txtC_8 = new TextBox();
            _txtEW_7 = new TextBox();
            _txtEW_6 = new TextBox();
            _txtEW_5 = new TextBox();
            _txtEW_4 = new TextBox();
            _txtEW_3 = new TextBox();
            _txtEW_2 = new TextBox();
            _txtEW_1 = new TextBox();
            _txtEW_0 = new TextBox();
            _txtC_7 = new TextBox();
            _txtC_6 = new TextBox();
            _txtC_5 = new TextBox();
            _txtC_4 = new TextBox();
            _txtC_3 = new TextBox();
            _txtC_2 = new TextBox();
            _txtC_1 = new TextBox();
            _txtC_0 = new TextBox();
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            _D_7 = new TextBox();
            _D_6 = new TextBox();
            _D_5 = new TextBox();
            _D_4 = new TextBox();
            _D_3 = new TextBox();
            _D_2 = new TextBox();
            _D_1 = new TextBox();
            _D_0 = new TextBox();
            Label1 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            Label4 = new Label();
            _btnSaveData = new Button();
            _btnSaveData.Click += new EventHandler(btnSaveData_Click);
            PictureBox1 = new PictureBox();
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
            _cmdPrint.Location = new Point(228, 8);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 39;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // _txtM_8
            // 
            _txtM_8.AcceptsReturn = true;
            _txtM_8.BackColor = SystemColors.Window;
            _txtM_8.Cursor = Cursors.IBeam;
            _txtM_8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtM_8.ForeColor = SystemColors.WindowText;
            _txtM_8.Location = new Point(107, 176);
            _txtM_8.MaxLength = 3;
            _txtM_8.Name = "_txtM_8";
            _txtM_8.RightToLeft = RightToLeft.No;
            _txtM_8.Size = new Size(25, 21);
            _txtM_8.TabIndex = 40;
            _txtM_8.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(_txtM_8, "Range 0 to 359");
            _txtM_8.Visible = false;
            // 
            // _txtM_7
            // 
            __txtM_7.AcceptsReturn = true;
            __txtM_7.BackColor = SystemColors.Window;
            __txtM_7.Cursor = Cursors.IBeam;
            __txtM_7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_7.ForeColor = SystemColors.WindowText;
            __txtM_7.Location = new Point(107, 160);
            __txtM_7.MaxLength = 3;
            __txtM_7.Name = "__txtM_7";
            __txtM_7.RightToLeft = RightToLeft.No;
            __txtM_7.Size = new Size(25, 21);
            __txtM_7.TabIndex = 9;
            __txtM_7.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_7, "Range 0 to 359");
            // 
            // _txtM_6
            // 
            __txtM_6.AcceptsReturn = true;
            __txtM_6.BackColor = SystemColors.Window;
            __txtM_6.Cursor = Cursors.IBeam;
            __txtM_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_6.ForeColor = SystemColors.WindowText;
            __txtM_6.Location = new Point(107, 144);
            __txtM_6.MaxLength = 3;
            __txtM_6.Name = "__txtM_6";
            __txtM_6.RightToLeft = RightToLeft.No;
            __txtM_6.Size = new Size(25, 21);
            __txtM_6.TabIndex = 8;
            __txtM_6.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_6, "Range 0 to 359");
            // 
            // _txtM_5
            // 
            __txtM_5.AcceptsReturn = true;
            __txtM_5.BackColor = SystemColors.Window;
            __txtM_5.Cursor = Cursors.IBeam;
            __txtM_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_5.ForeColor = SystemColors.WindowText;
            __txtM_5.Location = new Point(107, 128);
            __txtM_5.MaxLength = 3;
            __txtM_5.Name = "__txtM_5";
            __txtM_5.RightToLeft = RightToLeft.No;
            __txtM_5.Size = new Size(25, 21);
            __txtM_5.TabIndex = 7;
            __txtM_5.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_5, "Range 0 to 359");
            // 
            // _txtM_4
            // 
            __txtM_4.AcceptsReturn = true;
            __txtM_4.BackColor = SystemColors.Window;
            __txtM_4.Cursor = Cursors.IBeam;
            __txtM_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_4.ForeColor = SystemColors.WindowText;
            __txtM_4.Location = new Point(107, 112);
            __txtM_4.MaxLength = 3;
            __txtM_4.Name = "__txtM_4";
            __txtM_4.RightToLeft = RightToLeft.No;
            __txtM_4.Size = new Size(25, 21);
            __txtM_4.TabIndex = 6;
            __txtM_4.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_4, "Range 0 to 359");
            // 
            // _txtM_3
            // 
            __txtM_3.AcceptsReturn = true;
            __txtM_3.BackColor = SystemColors.Window;
            __txtM_3.Cursor = Cursors.IBeam;
            __txtM_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_3.ForeColor = SystemColors.WindowText;
            __txtM_3.Location = new Point(107, 96);
            __txtM_3.MaxLength = 3;
            __txtM_3.Name = "__txtM_3";
            __txtM_3.RightToLeft = RightToLeft.No;
            __txtM_3.Size = new Size(25, 21);
            __txtM_3.TabIndex = 5;
            __txtM_3.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_3, "Range 0 to 359");
            // 
            // _txtM_2
            // 
            __txtM_2.AcceptsReturn = true;
            __txtM_2.BackColor = SystemColors.Window;
            __txtM_2.Cursor = Cursors.IBeam;
            __txtM_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_2.ForeColor = SystemColors.WindowText;
            __txtM_2.Location = new Point(107, 80);
            __txtM_2.MaxLength = 3;
            __txtM_2.Name = "__txtM_2";
            __txtM_2.RightToLeft = RightToLeft.No;
            __txtM_2.Size = new Size(25, 21);
            __txtM_2.TabIndex = 4;
            __txtM_2.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_2, "Range 0 to 359");
            // 
            // _txtM_1
            // 
            __txtM_1.AcceptsReturn = true;
            __txtM_1.BackColor = SystemColors.Window;
            __txtM_1.Cursor = Cursors.IBeam;
            __txtM_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_1.ForeColor = SystemColors.WindowText;
            __txtM_1.Location = new Point(107, 64);
            __txtM_1.MaxLength = 3;
            __txtM_1.Name = "__txtM_1";
            __txtM_1.RightToLeft = RightToLeft.No;
            __txtM_1.Size = new Size(25, 21);
            __txtM_1.TabIndex = 3;
            __txtM_1.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_1, "Range 0 to 359");
            // 
            // _txtM_0
            // 
            __txtM_0.AcceptsReturn = true;
            __txtM_0.BackColor = SystemColors.Window;
            __txtM_0.Cursor = Cursors.IBeam;
            __txtM_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            __txtM_0.ForeColor = SystemColors.WindowText;
            __txtM_0.Location = new Point(107, 48);
            __txtM_0.MaxLength = 3;
            __txtM_0.Name = "__txtM_0";
            __txtM_0.RightToLeft = RightToLeft.No;
            __txtM_0.Size = new Size(25, 21);
            __txtM_0.TabIndex = 2;
            __txtM_0.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(__txtM_0, "Range 0 to 359");
            // 
            // _txtEW_8
            // 
            _txtEW_8.AcceptsReturn = true;
            _txtEW_8.BackColor = SystemColors.Window;
            _txtEW_8.BorderStyle = BorderStyle.None;
            _txtEW_8.Cursor = Cursors.IBeam;
            _txtEW_8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_8.ForeColor = SystemColors.WindowText;
            _txtEW_8.Location = new Point(203, 176);
            _txtEW_8.MaxLength = 0;
            _txtEW_8.Name = "_txtEW_8";
            _txtEW_8.ReadOnly = true;
            _txtEW_8.RightToLeft = RightToLeft.No;
            _txtEW_8.Size = new Size(17, 14);
            _txtEW_8.TabIndex = 38;
            _txtEW_8.Visible = false;
            // 
            // _D_8
            // 
            _D_8.AcceptsReturn = true;
            _D_8.BackColor = SystemColors.Window;
            _D_8.BorderStyle = BorderStyle.None;
            _D_8.Cursor = Cursors.IBeam;
            _D_8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_8.ForeColor = SystemColors.WindowText;
            _D_8.Location = new Point(171, 176);
            _D_8.MaxLength = 0;
            _D_8.Name = "_D_8";
            _D_8.ReadOnly = true;
            _D_8.RightToLeft = RightToLeft.No;
            _D_8.Size = new Size(25, 14);
            _D_8.TabIndex = 37;
            _D_8.TextAlign = HorizontalAlignment.Right;
            _D_8.Visible = false;
            // 
            // _txtC_8
            // 
            _txtC_8.AcceptsReturn = true;
            _txtC_8.BackColor = SystemColors.Window;
            _txtC_8.BorderStyle = BorderStyle.None;
            _txtC_8.Cursor = Cursors.IBeam;
            _txtC_8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_8.ForeColor = SystemColors.WindowText;
            _txtC_8.Location = new Point(27, 176);
            _txtC_8.MaxLength = 0;
            _txtC_8.Name = "_txtC_8";
            _txtC_8.ReadOnly = true;
            _txtC_8.RightToLeft = RightToLeft.No;
            _txtC_8.Size = new Size(25, 14);
            _txtC_8.TabIndex = 36;
            _txtC_8.Text = "360";
            _txtC_8.Visible = false;
            // 
            // _txtEW_7
            // 
            _txtEW_7.AcceptsReturn = true;
            _txtEW_7.BackColor = SystemColors.Window;
            _txtEW_7.BorderStyle = BorderStyle.None;
            _txtEW_7.CausesValidation = false;
            _txtEW_7.Cursor = Cursors.IBeam;
            _txtEW_7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_7.ForeColor = SystemColors.WindowText;
            _txtEW_7.Location = new Point(203, 160);
            _txtEW_7.MaxLength = 0;
            _txtEW_7.Name = "_txtEW_7";
            _txtEW_7.ReadOnly = true;
            _txtEW_7.RightToLeft = RightToLeft.No;
            _txtEW_7.Size = new Size(17, 14);
            _txtEW_7.TabIndex = 34;
            // 
            // _txtEW_6
            // 
            _txtEW_6.AcceptsReturn = true;
            _txtEW_6.BackColor = SystemColors.Window;
            _txtEW_6.BorderStyle = BorderStyle.None;
            _txtEW_6.Cursor = Cursors.IBeam;
            _txtEW_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_6.ForeColor = SystemColors.WindowText;
            _txtEW_6.Location = new Point(203, 144);
            _txtEW_6.MaxLength = 0;
            _txtEW_6.Name = "_txtEW_6";
            _txtEW_6.ReadOnly = true;
            _txtEW_6.RightToLeft = RightToLeft.No;
            _txtEW_6.Size = new Size(17, 14);
            _txtEW_6.TabIndex = 33;
            // 
            // _txtEW_5
            // 
            _txtEW_5.AcceptsReturn = true;
            _txtEW_5.BackColor = SystemColors.Window;
            _txtEW_5.BorderStyle = BorderStyle.None;
            _txtEW_5.Cursor = Cursors.IBeam;
            _txtEW_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_5.ForeColor = SystemColors.WindowText;
            _txtEW_5.Location = new Point(203, 128);
            _txtEW_5.MaxLength = 0;
            _txtEW_5.Name = "_txtEW_5";
            _txtEW_5.ReadOnly = true;
            _txtEW_5.RightToLeft = RightToLeft.No;
            _txtEW_5.Size = new Size(17, 14);
            _txtEW_5.TabIndex = 32;
            // 
            // _txtEW_4
            // 
            _txtEW_4.AcceptsReturn = true;
            _txtEW_4.BackColor = SystemColors.Window;
            _txtEW_4.BorderStyle = BorderStyle.None;
            _txtEW_4.Cursor = Cursors.IBeam;
            _txtEW_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_4.ForeColor = SystemColors.WindowText;
            _txtEW_4.Location = new Point(203, 112);
            _txtEW_4.MaxLength = 0;
            _txtEW_4.Name = "_txtEW_4";
            _txtEW_4.ReadOnly = true;
            _txtEW_4.RightToLeft = RightToLeft.No;
            _txtEW_4.Size = new Size(17, 14);
            _txtEW_4.TabIndex = 31;
            // 
            // _txtEW_3
            // 
            _txtEW_3.AcceptsReturn = true;
            _txtEW_3.BackColor = SystemColors.Window;
            _txtEW_3.BorderStyle = BorderStyle.None;
            _txtEW_3.Cursor = Cursors.IBeam;
            _txtEW_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_3.ForeColor = SystemColors.WindowText;
            _txtEW_3.Location = new Point(203, 96);
            _txtEW_3.MaxLength = 0;
            _txtEW_3.Name = "_txtEW_3";
            _txtEW_3.ReadOnly = true;
            _txtEW_3.RightToLeft = RightToLeft.No;
            _txtEW_3.Size = new Size(17, 14);
            _txtEW_3.TabIndex = 30;
            // 
            // _txtEW_2
            // 
            _txtEW_2.AcceptsReturn = true;
            _txtEW_2.BackColor = SystemColors.Window;
            _txtEW_2.BorderStyle = BorderStyle.None;
            _txtEW_2.Cursor = Cursors.IBeam;
            _txtEW_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_2.ForeColor = SystemColors.WindowText;
            _txtEW_2.Location = new Point(203, 80);
            _txtEW_2.MaxLength = 0;
            _txtEW_2.Name = "_txtEW_2";
            _txtEW_2.ReadOnly = true;
            _txtEW_2.RightToLeft = RightToLeft.No;
            _txtEW_2.Size = new Size(17, 14);
            _txtEW_2.TabIndex = 29;
            // 
            // _txtEW_1
            // 
            _txtEW_1.AcceptsReturn = true;
            _txtEW_1.BackColor = SystemColors.Window;
            _txtEW_1.BorderStyle = BorderStyle.None;
            _txtEW_1.Cursor = Cursors.IBeam;
            _txtEW_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_1.ForeColor = SystemColors.WindowText;
            _txtEW_1.Location = new Point(203, 64);
            _txtEW_1.MaxLength = 0;
            _txtEW_1.Name = "_txtEW_1";
            _txtEW_1.ReadOnly = true;
            _txtEW_1.RightToLeft = RightToLeft.No;
            _txtEW_1.Size = new Size(17, 14);
            _txtEW_1.TabIndex = 28;
            // 
            // _txtEW_0
            // 
            _txtEW_0.AcceptsReturn = true;
            _txtEW_0.BackColor = SystemColors.Window;
            _txtEW_0.BorderStyle = BorderStyle.None;
            _txtEW_0.Cursor = Cursors.IBeam;
            _txtEW_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEW_0.ForeColor = SystemColors.WindowText;
            _txtEW_0.Location = new Point(203, 48);
            _txtEW_0.MaxLength = 0;
            _txtEW_0.Name = "_txtEW_0";
            _txtEW_0.ReadOnly = true;
            _txtEW_0.RightToLeft = RightToLeft.No;
            _txtEW_0.Size = new Size(17, 14);
            _txtEW_0.TabIndex = 27;
            // 
            // _txtC_7
            // 
            _txtC_7.AcceptsReturn = true;
            _txtC_7.BackColor = SystemColors.Window;
            _txtC_7.BorderStyle = BorderStyle.None;
            _txtC_7.Cursor = Cursors.IBeam;
            _txtC_7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_7.ForeColor = SystemColors.WindowText;
            _txtC_7.Location = new Point(27, 160);
            _txtC_7.MaxLength = 0;
            _txtC_7.Name = "_txtC_7";
            _txtC_7.ReadOnly = true;
            _txtC_7.RightToLeft = RightToLeft.No;
            _txtC_7.Size = new Size(25, 14);
            _txtC_7.TabIndex = 26;
            _txtC_7.Text = "315";
            // 
            // _txtC_6
            // 
            _txtC_6.AcceptsReturn = true;
            _txtC_6.BackColor = SystemColors.Window;
            _txtC_6.BorderStyle = BorderStyle.None;
            _txtC_6.Cursor = Cursors.IBeam;
            _txtC_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_6.ForeColor = SystemColors.WindowText;
            _txtC_6.Location = new Point(27, 144);
            _txtC_6.MaxLength = 0;
            _txtC_6.Name = "_txtC_6";
            _txtC_6.ReadOnly = true;
            _txtC_6.RightToLeft = RightToLeft.No;
            _txtC_6.Size = new Size(25, 14);
            _txtC_6.TabIndex = 25;
            _txtC_6.Text = "270";
            // 
            // _txtC_5
            // 
            _txtC_5.AcceptsReturn = true;
            _txtC_5.BackColor = SystemColors.Window;
            _txtC_5.BorderStyle = BorderStyle.None;
            _txtC_5.Cursor = Cursors.IBeam;
            _txtC_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_5.ForeColor = SystemColors.WindowText;
            _txtC_5.Location = new Point(27, 128);
            _txtC_5.MaxLength = 0;
            _txtC_5.Name = "_txtC_5";
            _txtC_5.ReadOnly = true;
            _txtC_5.RightToLeft = RightToLeft.No;
            _txtC_5.Size = new Size(25, 14);
            _txtC_5.TabIndex = 24;
            _txtC_5.Text = "225";
            // 
            // _txtC_4
            // 
            _txtC_4.AcceptsReturn = true;
            _txtC_4.BackColor = SystemColors.Window;
            _txtC_4.BorderStyle = BorderStyle.None;
            _txtC_4.Cursor = Cursors.IBeam;
            _txtC_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_4.ForeColor = SystemColors.WindowText;
            _txtC_4.Location = new Point(27, 112);
            _txtC_4.MaxLength = 0;
            _txtC_4.Name = "_txtC_4";
            _txtC_4.ReadOnly = true;
            _txtC_4.RightToLeft = RightToLeft.No;
            _txtC_4.Size = new Size(25, 14);
            _txtC_4.TabIndex = 23;
            _txtC_4.Text = "180";
            // 
            // _txtC_3
            // 
            _txtC_3.AcceptsReturn = true;
            _txtC_3.BackColor = SystemColors.Window;
            _txtC_3.BorderStyle = BorderStyle.None;
            _txtC_3.Cursor = Cursors.IBeam;
            _txtC_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_3.ForeColor = SystemColors.WindowText;
            _txtC_3.Location = new Point(27, 96);
            _txtC_3.MaxLength = 0;
            _txtC_3.Name = "_txtC_3";
            _txtC_3.ReadOnly = true;
            _txtC_3.RightToLeft = RightToLeft.No;
            _txtC_3.Size = new Size(25, 14);
            _txtC_3.TabIndex = 22;
            _txtC_3.Text = "135";
            // 
            // _txtC_2
            // 
            _txtC_2.AcceptsReturn = true;
            _txtC_2.BackColor = SystemColors.Window;
            _txtC_2.BorderStyle = BorderStyle.None;
            _txtC_2.Cursor = Cursors.IBeam;
            _txtC_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_2.ForeColor = SystemColors.WindowText;
            _txtC_2.Location = new Point(27, 80);
            _txtC_2.MaxLength = 0;
            _txtC_2.Name = "_txtC_2";
            _txtC_2.ReadOnly = true;
            _txtC_2.RightToLeft = RightToLeft.No;
            _txtC_2.Size = new Size(25, 14);
            _txtC_2.TabIndex = 21;
            _txtC_2.Text = " 90";
            // 
            // _txtC_1
            // 
            _txtC_1.AcceptsReturn = true;
            _txtC_1.BackColor = SystemColors.Window;
            _txtC_1.BorderStyle = BorderStyle.None;
            _txtC_1.Cursor = Cursors.IBeam;
            _txtC_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_1.ForeColor = SystemColors.WindowText;
            _txtC_1.Location = new Point(27, 64);
            _txtC_1.MaxLength = 0;
            _txtC_1.Name = "_txtC_1";
            _txtC_1.ReadOnly = true;
            _txtC_1.RightToLeft = RightToLeft.No;
            _txtC_1.Size = new Size(25, 14);
            _txtC_1.TabIndex = 20;
            _txtC_1.Text = " 45";
            // 
            // _txtC_0
            // 
            _txtC_0.AcceptsReturn = true;
            _txtC_0.BackColor = SystemColors.Window;
            _txtC_0.BorderStyle = BorderStyle.None;
            _txtC_0.Cursor = Cursors.IBeam;
            _txtC_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtC_0.ForeColor = SystemColors.WindowText;
            _txtC_0.Location = new Point(27, 48);
            _txtC_0.MaxLength = 0;
            _txtC_0.Name = "_txtC_0";
            _txtC_0.ReadOnly = true;
            _txtC_0.RightToLeft = RightToLeft.No;
            _txtC_0.Size = new Size(25, 14);
            _txtC_0.TabIndex = 19;
            _txtC_0.Text = "  0";
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = SystemColors.Control;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(27, 210);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(81, 25);
            _cmdClear.TabIndex = 18;
            _cmdClear.Text = "&Clear Data";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // _D_7
            // 
            _D_7.AcceptsReturn = true;
            _D_7.BackColor = SystemColors.Window;
            _D_7.BorderStyle = BorderStyle.None;
            _D_7.Cursor = Cursors.IBeam;
            _D_7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_7.ForeColor = SystemColors.WindowText;
            _D_7.Location = new Point(171, 160);
            _D_7.MaxLength = 0;
            _D_7.Name = "_D_7";
            _D_7.ReadOnly = true;
            _D_7.RightToLeft = RightToLeft.No;
            _D_7.Size = new Size(25, 14);
            _D_7.TabIndex = 17;
            _D_7.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_6
            // 
            _D_6.AcceptsReturn = true;
            _D_6.BackColor = SystemColors.Window;
            _D_6.BorderStyle = BorderStyle.None;
            _D_6.Cursor = Cursors.IBeam;
            _D_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_6.ForeColor = SystemColors.WindowText;
            _D_6.Location = new Point(171, 144);
            _D_6.MaxLength = 0;
            _D_6.Name = "_D_6";
            _D_6.ReadOnly = true;
            _D_6.RightToLeft = RightToLeft.No;
            _D_6.Size = new Size(25, 14);
            _D_6.TabIndex = 16;
            _D_6.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_5
            // 
            _D_5.AcceptsReturn = true;
            _D_5.BackColor = SystemColors.Window;
            _D_5.BorderStyle = BorderStyle.None;
            _D_5.Cursor = Cursors.IBeam;
            _D_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_5.ForeColor = SystemColors.WindowText;
            _D_5.Location = new Point(171, 128);
            _D_5.MaxLength = 0;
            _D_5.Name = "_D_5";
            _D_5.ReadOnly = true;
            _D_5.RightToLeft = RightToLeft.No;
            _D_5.Size = new Size(25, 14);
            _D_5.TabIndex = 15;
            _D_5.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_4
            // 
            _D_4.AcceptsReturn = true;
            _D_4.BackColor = SystemColors.Window;
            _D_4.BorderStyle = BorderStyle.None;
            _D_4.Cursor = Cursors.IBeam;
            _D_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_4.ForeColor = SystemColors.WindowText;
            _D_4.Location = new Point(171, 112);
            _D_4.MaxLength = 0;
            _D_4.Name = "_D_4";
            _D_4.ReadOnly = true;
            _D_4.RightToLeft = RightToLeft.No;
            _D_4.Size = new Size(25, 14);
            _D_4.TabIndex = 14;
            _D_4.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_3
            // 
            _D_3.AcceptsReturn = true;
            _D_3.BackColor = SystemColors.Window;
            _D_3.BorderStyle = BorderStyle.None;
            _D_3.Cursor = Cursors.IBeam;
            _D_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_3.ForeColor = SystemColors.WindowText;
            _D_3.Location = new Point(171, 96);
            _D_3.MaxLength = 0;
            _D_3.Name = "_D_3";
            _D_3.ReadOnly = true;
            _D_3.RightToLeft = RightToLeft.No;
            _D_3.Size = new Size(25, 14);
            _D_3.TabIndex = 13;
            _D_3.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_2
            // 
            _D_2.AcceptsReturn = true;
            _D_2.BackColor = SystemColors.Window;
            _D_2.BorderStyle = BorderStyle.None;
            _D_2.Cursor = Cursors.IBeam;
            _D_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_2.ForeColor = SystemColors.WindowText;
            _D_2.Location = new Point(171, 80);
            _D_2.MaxLength = 0;
            _D_2.Name = "_D_2";
            _D_2.ReadOnly = true;
            _D_2.RightToLeft = RightToLeft.No;
            _D_2.Size = new Size(25, 14);
            _D_2.TabIndex = 12;
            _D_2.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_1
            // 
            _D_1.AcceptsReturn = true;
            _D_1.BackColor = SystemColors.Window;
            _D_1.BorderStyle = BorderStyle.None;
            _D_1.Cursor = Cursors.IBeam;
            _D_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_1.ForeColor = SystemColors.WindowText;
            _D_1.Location = new Point(171, 64);
            _D_1.MaxLength = 0;
            _D_1.Name = "_D_1";
            _D_1.ReadOnly = true;
            _D_1.RightToLeft = RightToLeft.No;
            _D_1.Size = new Size(25, 14);
            _D_1.TabIndex = 11;
            _D_1.TextAlign = HorizontalAlignment.Right;
            // 
            // _D_0
            // 
            _D_0.AcceptsReturn = true;
            _D_0.BackColor = SystemColors.Window;
            _D_0.BorderStyle = BorderStyle.None;
            _D_0.Cursor = Cursors.IBeam;
            _D_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _D_0.ForeColor = SystemColors.WindowText;
            _D_0.Location = new Point(171, 48);
            _D_0.MaxLength = 0;
            _D_0.Name = "_D_0";
            _D_0.ReadOnly = true;
            _D_0.RightToLeft = RightToLeft.No;
            _D_0.Size = new Size(25, 14);
            _D_0.TabIndex = 10;
            _D_0.TextAlign = HorizontalAlignment.Right;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(11, 32);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(65, 17);
            Label1.TabIndex = 35;
            Label1.Text = "Compass  (°)";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(171, 32);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(65, 17);
            Label3.TabIndex = 1;
            Label3.Text = "Deviation (°)";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(91, 32);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(65, 17);
            Label2.TabIndex = 0;
            Label2.Text = "Magnetic (°)";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = Color.White;
            _ExitBtn.Location = new Point(178, 241);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(81, 25);
            _ExitBtn.TabIndex = 41;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(50, 12);
            Label4.Name = "Label4";
            Label4.Size = new Size(140, 13);
            Label4.TabIndex = 42;
            Label4.Text = "Saved Deviation Table Data";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveData
            // 
            _btnSaveData.BackColor = SystemColors.Control;
            _btnSaveData.Cursor = Cursors.Default;
            _btnSaveData.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSaveData.ForeColor = SystemColors.ControlText;
            _btnSaveData.Location = new Point(178, 209);
            _btnSaveData.Name = "_btnSaveData";
            _btnSaveData.RightToLeft = RightToLeft.No;
            _btnSaveData.Size = new Size(81, 25);
            _btnSaveData.TabIndex = 43;
            _btnSaveData.Text = "&Save Data";
            _btnSaveData.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(27, 271);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(232, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 103;
            PictureBox1.TabStop = false;
            // 
            // FormDevTable_frm
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(283, 330);
            Controls.Add(PictureBox1);
            Controls.Add(_btnSaveData);
            Controls.Add(Label4);
            Controls.Add(_ExitBtn);
            Controls.Add(_cmdPrint);
            Controls.Add(_txtEW_8);
            Controls.Add(_D_8);
            Controls.Add(_txtM_8);
            Controls.Add(_txtC_8);
            Controls.Add(_txtEW_7);
            Controls.Add(_txtEW_6);
            Controls.Add(_txtEW_5);
            Controls.Add(_txtEW_4);
            Controls.Add(_txtEW_3);
            Controls.Add(_txtEW_2);
            Controls.Add(_txtEW_1);
            Controls.Add(_txtEW_0);
            Controls.Add(_txtC_7);
            Controls.Add(_txtC_6);
            Controls.Add(_txtC_5);
            Controls.Add(_txtC_4);
            Controls.Add(_txtC_3);
            Controls.Add(_txtC_2);
            Controls.Add(_txtC_1);
            Controls.Add(_txtC_0);
            Controls.Add(_cmdClear);
            Controls.Add(_D_7);
            Controls.Add(_D_6);
            Controls.Add(_D_5);
            Controls.Add(_D_4);
            Controls.Add(_D_3);
            Controls.Add(_D_2);
            Controls.Add(_D_1);
            Controls.Add(_D_0);
            Controls.Add(__txtM_7);
            Controls.Add(__txtM_6);
            Controls.Add(__txtM_5);
            Controls.Add(__txtM_4);
            Controls.Add(__txtM_3);
            Controls.Add(__txtM_2);
            Controls.Add(__txtM_1);
            Controls.Add(__txtM_0);
            Controls.Add(Label1);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormDevTable_frm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Deviation Table";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormDevTable_frm_Load);
            FormClosed += new FormClosedEventHandler(FormDevTable_frm_FormClosed);
            ResumeLayout(false);
            PerformLayout();
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

        internal Label Label4;
        private Button _btnSaveData;

        public Button btnSaveData
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveData;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveData != null)
                {
                    _btnSaveData.Click -= btnSaveData_Click;
                }

                _btnSaveData = value;
                if (_btnSaveData != null)
                {
                    _btnSaveData.Click += btnSaveData_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal DataSet DataSet1;
        internal DataTable DataTable1;
        internal DataColumn DataColumn1;
        internal DataColumn DataColumn2;
        internal DataColumn DataColumn3;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}