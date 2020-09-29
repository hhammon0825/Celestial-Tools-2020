using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class FixDG : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FixDG));
            _DGFix = new DataGridView();
            _DGFix.SelectionChanged += new EventHandler(DGFix_SelectionChanged);
            DGSelect = new DataGridViewCheckBoxColumn();
            DGSightNum = new DataGridViewTextBoxColumn();
            DGBodyName = new DataGridViewTextBoxColumn();
            DGZoneTime = new DataGridViewTextBoxColumn();
            DGIntercept = new DataGridViewTextBoxColumn();
            DGAzimuth = new DataGridViewTextBoxColumn();
            DGLat = new DataGridViewTextBoxColumn();
            DGLong = new DataGridViewTextBoxColumn();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _btnPrint = new Button();
            _btnPrint.Click += new EventHandler(BtnPrint_Click);
            Label1 = new Label();
            lblFixZT = new Label();
            txtFixZT = new TextBox();
            txtFixLat = new TextBox();
            lbFixLat = new Label();
            txtFixLong = new TextBox();
            lblFixLong = new Label();
            txtFixIntercept = new TextBox();
            lblFixIntercept = new Label();
            txtFixBearing = new TextBox();
            lblFixAZ = new Label();
            GrpBxFix = new GroupBox();
            _btnUseCLS = new Button();
            _btnUseCLS.Click += new EventHandler(btnUseCLS_Click);
            _btnCustomPlot = new Button();
            _btnCustomPlot.Click += new EventHandler(btnCustomPlot_Click);
            PictureBox1 = new PictureBox();
            TextBox1 = new TextBox();
            txtUserInfo = new TextBox();
            Label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)_DGFix).BeginInit();
            GrpBxFix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGFix
            // 
            _DGFix.AllowUserToAddRows = false;
            _DGFix.AllowUserToDeleteRows = false;
            _DGFix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGFix.Columns.AddRange(new DataGridViewColumn[] { DGSelect, DGSightNum, DGBodyName, DGZoneTime, DGIntercept, DGAzimuth, DGLat, DGLong });
            _DGFix.Location = new Point(8, 120);
            _DGFix.Name = "_DGFix";
            _DGFix.ReadOnly = true;
            _DGFix.Size = new Size(635, 317);
            _DGFix.TabIndex = 0;
            // 
            // DGSelect
            // 
            DGSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGSelect.HeaderText = "Select";
            DGSelect.Name = "DGSelect";
            DGSelect.ReadOnly = true;
            DGSelect.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGSelect.Width = 62;
            // 
            // DGSightNum
            // 
            DGSightNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DGSightNum.HeaderText = "Sight #";
            DGSightNum.Name = "DGSightNum";
            DGSightNum.ReadOnly = true;
            DGSightNum.Resizable = DataGridViewTriState.False;
            DGSightNum.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGSightNum.Width = 66;
            // 
            // DGBodyName
            // 
            DGBodyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGBodyName.HeaderText = "Body Name";
            DGBodyName.Name = "DGBodyName";
            DGBodyName.ReadOnly = true;
            DGBodyName.Resizable = DataGridViewTriState.False;
            DGBodyName.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGBodyName.Width = 87;
            // 
            // DGZoneTime
            // 
            DGZoneTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGZoneTime.HeaderText = "Zone Time";
            DGZoneTime.Name = "DGZoneTime";
            DGZoneTime.ReadOnly = true;
            DGZoneTime.Resizable = DataGridViewTriState.False;
            DGZoneTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGZoneTime.Width = 83;
            // 
            // DGIntercept
            // 
            DGIntercept.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DGIntercept.HeaderText = "Intercept (nm)";
            DGIntercept.Name = "DGIntercept";
            DGIntercept.ReadOnly = true;
            DGIntercept.Resizable = DataGridViewTriState.False;
            DGIntercept.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGIntercept.Width = 97;
            // 
            // DGAzimuth
            // 
            DGAzimuth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGAzimuth.HeaderText = "Zn";
            DGAzimuth.Name = "DGAzimuth";
            DGAzimuth.ReadOnly = true;
            DGAzimuth.Resizable = DataGridViewTriState.False;
            DGAzimuth.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGAzimuth.Width = 45;
            // 
            // DGLat
            // 
            DGLat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGLat.HeaderText = "Latitude";
            DGLat.Name = "DGLat";
            DGLat.ReadOnly = true;
            DGLat.Resizable = DataGridViewTriState.False;
            DGLat.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGLat.Width = 70;
            // 
            // DGLong
            // 
            DGLong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGLong.HeaderText = "Longitude";
            DGLong.Name = "DGLong";
            DGLong.ReadOnly = true;
            DGLong.Resizable = DataGridViewTriState.False;
            DGLong.SortMode = DataGridViewColumnSortMode.Programmatic;
            DGLong.Width = 79;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(581, 443);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(62, 25);
            _ExitBtn.TabIndex = 25;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            _btnPrint.BackColor = SystemColors.Control;
            _btnPrint.Cursor = Cursors.Default;
            _btnPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPrint.ForeColor = SystemColors.ControlText;
            _btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            _btnPrint.Location = new Point(608, 12);
            _btnPrint.Name = "_btnPrint";
            _btnPrint.RightToLeft = RightToLeft.No;
            _btnPrint.Size = new Size(30, 26);
            _btnPrint.TabIndex = 26;
            _btnPrint.TextAlign = ContentAlignment.BottomCenter;
            _btnPrint.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(219, 3);
            Label1.Name = "Label1";
            Label1.Size = new Size(241, 16);
            Label1.TabIndex = 29;
            Label1.Text = "Calculated Fix for Sights Selected" + '\r' + '\n';
            // 
            // lblFixZT
            // 
            lblFixZT.AutoSize = true;
            lblFixZT.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFixZT.Location = new Point(52, 21);
            lblFixZT.Name = "lblFixZT";
            lblFixZT.Size = new Size(94, 16);
            lblFixZT.TabIndex = 31;
            lblFixZT.Text = "Zone Time =";
            lblFixZT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFixZT
            // 
            txtFixZT.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixZT.Location = new Point(146, 18);
            txtFixZT.Name = "txtFixZT";
            txtFixZT.ReadOnly = true;
            txtFixZT.Size = new Size(100, 22);
            txtFixZT.TabIndex = 32;
            txtFixZT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFixLat
            // 
            txtFixLat.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixLat.Location = new Point(293, 18);
            txtFixLat.Name = "txtFixLat";
            txtFixLat.ReadOnly = true;
            txtFixLat.Size = new Size(100, 22);
            txtFixLat.TabIndex = 34;
            txtFixLat.TextAlign = HorizontalAlignment.Center;
            // 
            // lbFixLat
            // 
            lbFixLat.AutoSize = true;
            lbFixLat.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lbFixLat.Location = new Point(252, 21);
            lbFixLat.Name = "lbFixLat";
            lbFixLat.Size = new Size(41, 16);
            lbFixLat.TabIndex = 33;
            lbFixLat.Text = "Lat =";
            lbFixLat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFixLong
            // 
            txtFixLong.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixLong.Location = new Point(464, 19);
            txtFixLong.Name = "txtFixLong";
            txtFixLong.ReadOnly = true;
            txtFixLong.Size = new Size(100, 22);
            txtFixLong.TabIndex = 36;
            txtFixLong.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFixLong
            // 
            lblFixLong.AutoSize = true;
            lblFixLong.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFixLong.Location = new Point(405, 21);
            lblFixLong.Name = "lblFixLong";
            lblFixLong.Size = new Size(54, 16);
            lblFixLong.TabIndex = 35;
            lblFixLong.Text = "Long =";
            lblFixLong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFixIntercept
            // 
            txtFixIntercept.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixIntercept.Location = new Point(293, 42);
            txtFixIntercept.Name = "txtFixIntercept";
            txtFixIntercept.ReadOnly = true;
            txtFixIntercept.Size = new Size(51, 22);
            txtFixIntercept.TabIndex = 38;
            txtFixIntercept.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFixIntercept
            // 
            lblFixIntercept.AutoSize = true;
            lblFixIntercept.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFixIntercept.Location = new Point(172, 45);
            lblFixIntercept.Name = "lblFixIntercept";
            lblFixIntercept.Size = new Size(115, 16);
            lblFixIntercept.TabIndex = 37;
            lblFixIntercept.Text = "Distance (nm) =";
            lblFixIntercept.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFixBearing
            // 
            txtFixBearing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixBearing.Location = new Point(507, 42);
            txtFixBearing.Name = "txtFixBearing";
            txtFixBearing.ReadOnly = true;
            txtFixBearing.Size = new Size(55, 22);
            txtFixBearing.TabIndex = 40;
            txtFixBearing.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFixAZ
            // 
            lblFixAZ.AutoSize = true;
            lblFixAZ.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFixAZ.Location = new Point(354, 45);
            lblFixAZ.Name = "lblFixAZ";
            lblFixAZ.Size = new Size(150, 16);
            lblFixAZ.TabIndex = 39;
            lblFixAZ.Text = "and Bearing (True) =";
            lblFixAZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GrpBxFix
            // 
            GrpBxFix.BackColor = SystemColors.ActiveCaption;
            GrpBxFix.Controls.Add(txtFixLat);
            GrpBxFix.Controls.Add(txtFixBearing);
            GrpBxFix.Controls.Add(lblFixZT);
            GrpBxFix.Controls.Add(lblFixAZ);
            GrpBxFix.Controls.Add(txtFixZT);
            GrpBxFix.Controls.Add(txtFixIntercept);
            GrpBxFix.Controls.Add(lbFixLat);
            GrpBxFix.Controls.Add(lblFixIntercept);
            GrpBxFix.Controls.Add(lblFixLong);
            GrpBxFix.Controls.Add(txtFixLong);
            GrpBxFix.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GrpBxFix.Location = new Point(13, 44);
            GrpBxFix.Name = "GrpBxFix";
            GrpBxFix.Size = new Size(630, 70);
            GrpBxFix.TabIndex = 41;
            GrpBxFix.TabStop = false;
            GrpBxFix.Text = "Fix calculated at:";
            // 
            // btnUseCLS
            // 
            _btnUseCLS.BackColor = Color.Yellow;
            _btnUseCLS.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUseCLS.ForeColor = SystemColors.WindowText;
            _btnUseCLS.Location = new Point(8, 445);
            _btnUseCLS.Name = "_btnUseCLS";
            _btnUseCLS.Size = new Size(110, 23);
            _btnUseCLS.TabIndex = 174;
            _btnUseCLS.Text = "CLS Form Plot";
            _btnUseCLS.UseVisualStyleBackColor = false;
            _btnUseCLS.Visible = false;
            // 
            // btnCustomPlot
            // 
            _btnCustomPlot.BackColor = Color.Yellow;
            _btnCustomPlot.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCustomPlot.ForeColor = SystemColors.WindowText;
            _btnCustomPlot.Location = new Point(8, 474);
            _btnCustomPlot.Name = "_btnCustomPlot";
            _btnCustomPlot.Size = new Size(110, 23);
            _btnCustomPlot.TabIndex = 175;
            _btnCustomPlot.Text = "Custom Plot Form";
            _btnCustomPlot.UseVisualStyleBackColor = false;
            _btnCustomPlot.Visible = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(177, 515);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(338, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 176;
            PictureBox1.TabStop = false;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Times New Roman", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(125, 443);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(450, 66);
            TextBox1.TabIndex = 177;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(148, 21);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(400, 20);
            txtUserInfo.TabIndex = 202;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(93, 24);
            Label7.Name = "Label7";
            Label7.Size = new Size(51, 14);
            Label7.TabIndex = 201;
            Label7.Text = "User Info";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FixDG
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 570);
            Controls.Add(txtUserInfo);
            Controls.Add(Label7);
            Controls.Add(TextBox1);
            Controls.Add(PictureBox1);
            Controls.Add(_btnCustomPlot);
            Controls.Add(_btnUseCLS);
            Controls.Add(GrpBxFix);
            Controls.Add(Label1);
            Controls.Add(_btnPrint);
            Controls.Add(_ExitBtn);
            Controls.Add(_DGFix);
            Name = "FixDG";
            Text = "Fix Calculation for Selected Sights";
            ((System.ComponentModel.ISupportInitialize)_DGFix).EndInit();
            GrpBxFix.ResumeLayout(false);
            GrpBxFix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FixDG_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView _DGFix;

        internal DataGridView DGFix
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGFix;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGFix != null)
                {
                    _DGFix.SelectionChanged -= DGFix_SelectionChanged;
                }

                _DGFix = value;
                if (_DGFix != null)
                {
                    _DGFix.SelectionChanged += DGFix_SelectionChanged;
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

        private Button _btnPrint;

        public Button btnPrint
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrint;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrint != null)
                {
                    _btnPrint.Click -= BtnPrint_Click;
                }

                _btnPrint = value;
                if (_btnPrint != null)
                {
                    _btnPrint.Click += BtnPrint_Click;
                }
            }
        }

        internal Label Label1;
        internal Label lblFixZT;
        internal TextBox txtFixZT;
        internal TextBox txtFixLat;
        internal Label lbFixLat;
        internal TextBox txtFixLong;
        internal Label lblFixLong;
        internal TextBox txtFixIntercept;
        internal Label lblFixIntercept;
        internal TextBox txtFixBearing;
        internal Label lblFixAZ;
        internal GroupBox GrpBxFix;
        private Button _btnUseCLS;

        internal Button btnUseCLS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUseCLS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUseCLS != null)
                {
                    _btnUseCLS.Click -= btnUseCLS_Click;
                }

                _btnUseCLS = value;
                if (_btnUseCLS != null)
                {
                    _btnUseCLS.Click += btnUseCLS_Click;
                }
            }
        }

        private Button _btnCustomPlot;

        internal Button btnCustomPlot
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCustomPlot;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCustomPlot != null)
                {
                    _btnCustomPlot.Click -= btnCustomPlot_Click;
                }

                _btnCustomPlot = value;
                if (_btnCustomPlot != null)
                {
                    _btnCustomPlot.Click += btnCustomPlot_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal DataGridViewCheckBoxColumn DGSelect;
        internal DataGridViewTextBoxColumn DGSightNum;
        internal DataGridViewTextBoxColumn DGBodyName;
        internal DataGridViewTextBoxColumn DGZoneTime;
        internal DataGridViewTextBoxColumn DGIntercept;
        internal DataGridViewTextBoxColumn DGAzimuth;
        internal DataGridViewTextBoxColumn DGLat;
        internal DataGridViewTextBoxColumn DGLong;
        internal TextBox TextBox1;
        internal TextBox txtUserInfo;
        internal Label Label7;
    }
}