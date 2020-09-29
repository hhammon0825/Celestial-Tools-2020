using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class Form7
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public Form7() : base()
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
        public ComboBox cboDsUnit;
        private TextBox _txtDsDist;

        public TextBox txtDsDist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDsDist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDsDist != null)
                {
                    _txtDsDist.KeyPress -= txtDsDist_KeyPress;
                    _txtDsDist.Enter -= txtDsDist_Enter;
                }

                _txtDsDist = value;
                if (_txtDsDist != null)
                {
                    _txtDsDist.KeyPress += txtDsDist_KeyPress;
                    _txtDsDist.Enter += txtDsDist_Enter;
                }
            }
        }

        private RadioButton _optHorizonNatural;

        public RadioButton optHorizonNatural
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonNatural;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonNatural != null)
                {
                    _optHorizonNatural.CheckedChanged -= optHorizonNatural_CheckedChanged;
                }

                _optHorizonNatural = value;
                if (_optHorizonNatural != null)
                {
                    _optHorizonNatural.CheckedChanged += optHorizonNatural_CheckedChanged;
                }
            }
        }

        private RadioButton _optHorizonArtificial;

        public RadioButton optHorizonArtificial
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonArtificial;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonArtificial != null)
                {
                    _optHorizonArtificial.CheckedChanged -= optHorizonArtificial_CheckedChanged;
                }

                _optHorizonArtificial = value;
                if (_optHorizonArtificial != null)
                {
                    _optHorizonArtificial.CheckedChanged += optHorizonArtificial_CheckedChanged;
                }
            }
        }

        private RadioButton _optHorizonDipShort;

        public RadioButton optHorizonDipShort
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonDipShort;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonDipShort != null)
                {
                    _optHorizonDipShort.CheckedChanged -= optHorizonDipShort_CheckedChanged;
                }

                _optHorizonDipShort = value;
                if (_optHorizonDipShort != null)
                {
                    _optHorizonDipShort.CheckedChanged += optHorizonDipShort_CheckedChanged;
                }
            }
        }

        private Button _cmdUse;

        public Button cmdUse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUse != null)
                {
                    _cmdUse.Click -= cmdUse_Click;
                }

                _cmdUse = value;
                if (_cmdUse != null)
                {
                    _cmdUse.Click += cmdUse_Click;
                }
            }
        }

        private Button _cmdSave;

        public Button cmdSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSave != null)
                {
                    _cmdSave.Click -= cmdSave_Click;
                }

                _cmdSave = value;
                if (_cmdSave != null)
                {
                    _cmdSave.Click += cmdSave_Click;
                }
            }
        }

        private Button _cmdRemoveLocation;

        public Button cmdRemoveLocation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRemoveLocation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRemoveLocation != null)
                {
                    _cmdRemoveLocation.Click -= cmdRemoveLocation_Click;
                }

                _cmdRemoveLocation = value;
                if (_cmdRemoveLocation != null)
                {
                    _cmdRemoveLocation.Click += cmdRemoveLocation_Click;
                }
            }
        }

        private TextBox _txtMaxAz;

        public TextBox txtMaxAz
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMaxAz;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMaxAz != null)
                {
                    _txtMaxAz.TextChanged -= txtMaxAz_TextChanged;
                    _txtMaxAz.KeyPress -= txtMaxAz_KeyPress;
                    _txtMaxAz.Validating -= txtMaxAz_Validating;
                    _txtMaxAz.Enter -= txtMaxAz_Enter;
                }

                _txtMaxAz = value;
                if (_txtMaxAz != null)
                {
                    _txtMaxAz.TextChanged += txtMaxAz_TextChanged;
                    _txtMaxAz.KeyPress += txtMaxAz_KeyPress;
                    _txtMaxAz.Validating += txtMaxAz_Validating;
                    _txtMaxAz.Enter += txtMaxAz_Enter;
                }
            }
        }

        private TextBox _txtMinAz;

        public TextBox txtMinAz
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMinAz;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMinAz != null)
                {
                    _txtMinAz.TextChanged -= txtMinAz_TextChanged;
                    _txtMinAz.KeyPress -= txtMinAz_KeyPress;
                    _txtMinAz.Validating -= txtMinAz_Validating;
                    _txtMinAz.Enter -= txtMinAz_Enter;
                }

                _txtMinAz = value;
                if (_txtMinAz != null)
                {
                    _txtMinAz.TextChanged += txtMinAz_TextChanged;
                    _txtMinAz.KeyPress += txtMinAz_KeyPress;
                    _txtMinAz.Validating += txtMinAz_Validating;
                    _txtMinAz.Enter += txtMinAz_Enter;
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

        public ComboBox cboL;
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

        public ComboBox cboLo;
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

        private TextBox _txtNewName;

        public TextBox txtNewName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtNewName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtNewName != null)
                {
                    _txtNewName.Enter -= txtNewName_Enter;
                }

                _txtNewName = value;
                if (_txtNewName != null)
                {
                    _txtNewName.Enter += txtNewName_Enter;
                }
            }
        }

        private Button _cmdAddLocation;

        public Button cmdAddLocation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAddLocation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAddLocation != null)
                {
                    _cmdAddLocation.Click -= cmdAddLocation_Click;
                }

                _cmdAddLocation = value;
                if (_cmdAddLocation != null)
                {
                    _cmdAddLocation.Click += cmdAddLocation_Click;
                }
            }
        }

        private ListBox _lstFavorites;

        public ListBox lstFavorites
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstFavorites;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstFavorites != null)
                {
                    _lstFavorites.DoubleClick -= lstFavorites_DoubleClick;
                }

                _lstFavorites = value;
                if (_lstFavorites != null)
                {
                    _lstFavorites.DoubleClick += lstFavorites_DoubleClick;
                }
            }
        }

        public Label Label3;
        public Label Label1;
        public Label lblDsDist;
        public Label lblHorizon;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblSelect;
        public Label Label2;
        public Label lblNewLocation;
        public Label lblMaxAzdeg;
        public Label lblMinAzDeg;
        public Label lblNewMaxAz;
        public Label lblNewMinAz;
        public Label lblNewLong;
        public Label lblNewLat;
        public Label lblLDeg;
        public Label lblLMin;
        public Label lblLoDeg;
        public Label lblLoMin;
        public Label lblNewName;
        public Label lblMaxAz;
        public Label lblMinAz;
        public Label lblLongitude;
        public Label lblLatitude;
        public Label lblName;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            ToolTip1 = new ToolTip(components);
            _txtDsDist = new TextBox();
            _txtDsDist.KeyPress += new KeyPressEventHandler(txtDsDist_KeyPress);
            _txtDsDist.Enter += new EventHandler(txtDsDist_Enter);
            _txtMaxAz = new TextBox();
            _txtMaxAz.TextChanged += new EventHandler(txtMaxAz_TextChanged);
            _txtMaxAz.KeyPress += new KeyPressEventHandler(txtMaxAz_KeyPress);
            _txtMaxAz.Validating += new System.ComponentModel.CancelEventHandler(txtMaxAz_Validating);
            _txtMaxAz.Enter += new EventHandler(txtMaxAz_Enter);
            _txtMinAz = new TextBox();
            _txtMinAz.TextChanged += new EventHandler(txtMinAz_TextChanged);
            _txtMinAz.KeyPress += new KeyPressEventHandler(txtMinAz_KeyPress);
            _txtMinAz.Validating += new System.ComponentModel.CancelEventHandler(txtMinAz_Validating);
            _txtMinAz.Enter += new EventHandler(txtMinAz_Enter);
            _txtLMin = new TextBox();
            _txtLMin.TextChanged += new EventHandler(txtLMin_TextChanged);
            _txtLMin.KeyPress += new KeyPressEventHandler(txtLMin_KeyPress);
            _txtLMin.Validating += new System.ComponentModel.CancelEventHandler(txtLMin_Validating);
            _txtLMin.Enter += new EventHandler(txtLMin_Enter);
            _txtLoDeg = new TextBox();
            _txtLoDeg.TextChanged += new EventHandler(txtLoDeg_TextChanged);
            _txtLoDeg.KeyPress += new KeyPressEventHandler(txtLoDeg_KeyPress);
            _txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLoDeg_Validating);
            _txtLoDeg.Enter += new EventHandler(txtLoDeg_Enter);
            _txtLoMin = new TextBox();
            _txtLoMin.TextChanged += new EventHandler(txtLoMin_TextChanged);
            _txtLoMin.KeyPress += new KeyPressEventHandler(txtLoMin_KeyPress);
            _txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(txtLoMin_Validating);
            _txtLoMin.Enter += new EventHandler(txtLoMin_Enter);
            _txtLDeg = new TextBox();
            _txtLDeg.TextChanged += new EventHandler(txtLDeg_TextChanged);
            _txtLDeg.KeyPress += new KeyPressEventHandler(txtLDeg_KeyPress);
            _txtLDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLDeg_Validating);
            _txtLDeg.Enter += new EventHandler(txtLDeg_Enter);
            _txtNewName = new TextBox();
            _txtNewName.Enter += new EventHandler(txtNewName_Enter);
            lblDsDist = new Label();
            // Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            // Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            cboDsUnit = new ComboBox();
            _optHorizonNatural = new RadioButton();
            _optHorizonNatural.CheckedChanged += new EventHandler(optHorizonNatural_CheckedChanged);
            _optHorizonArtificial = new RadioButton();
            _optHorizonArtificial.CheckedChanged += new EventHandler(optHorizonArtificial_CheckedChanged);
            _optHorizonDipShort = new RadioButton();
            _optHorizonDipShort.CheckedChanged += new EventHandler(optHorizonDipShort_CheckedChanged);
            _cmdUse = new Button();
            _cmdUse.Click += new EventHandler(cmdUse_Click);
            _cmdSave = new Button();
            _cmdSave.Click += new EventHandler(cmdSave_Click);
            _cmdRemoveLocation = new Button();
            _cmdRemoveLocation.Click += new EventHandler(cmdRemoveLocation_Click);
            cboL = new ComboBox();
            cboLo = new ComboBox();
            _cmdAddLocation = new Button();
            _cmdAddLocation.Click += new EventHandler(cmdAddLocation_Click);
            _lstFavorites = new ListBox();
            _lstFavorites.DoubleClick += new EventHandler(lstFavorites_DoubleClick);
            Label3 = new Label();
            Label1 = new Label();
            lblHorizon = new Label();
            lblSelect = new Label();
            Label2 = new Label();
            lblNewLocation = new Label();
            lblMaxAzdeg = new Label();
            lblMinAzDeg = new Label();
            lblNewMaxAz = new Label();
            lblNewMinAz = new Label();
            lblNewLong = new Label();
            lblNewLat = new Label();
            lblLDeg = new Label();
            lblLMin = new Label();
            lblLoDeg = new Label();
            lblLoMin = new Label();
            lblNewName = new Label();
            lblMaxAz = new Label();
            lblMinAz = new Label();
            lblLongitude = new Label();
            lblLatitude = new Label();
            lblName = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _btnOpenLocList = new Button();
            _btnOpenLocList.Click += new EventHandler(btnOpenLocList_Click);
            SuspendLayout();
            // 
            // txtDsDist
            // 
            _txtDsDist.AcceptsReturn = true;
            _txtDsDist.BackColor = SystemColors.Window;
            _txtDsDist.Cursor = Cursors.IBeam;
            _txtDsDist.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDsDist.ForeColor = SystemColors.WindowText;
            _txtDsDist.Location = new Point(224, 321);
            _txtDsDist.MaxLength = 5;
            _txtDsDist.Name = "_txtDsDist";
            _txtDsDist.RightToLeft = RightToLeft.No;
            _txtDsDist.Size = new Size(41, 20);
            _txtDsDist.TabIndex = 38;
            ToolTip1.SetToolTip(_txtDsDist, "Limited to four characters");
            _txtDsDist.Visible = false;
            // 
            // txtMaxAz
            // 
            _txtMaxAz.AcceptsReturn = true;
            _txtMaxAz.BackColor = SystemColors.Window;
            _txtMaxAz.Cursor = Cursors.IBeam;
            _txtMaxAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMaxAz.ForeColor = SystemColors.WindowText;
            _txtMaxAz.Location = new Point(296, 272);
            _txtMaxAz.MaxLength = 3;
            _txtMaxAz.Name = "_txtMaxAz";
            _txtMaxAz.RightToLeft = RightToLeft.No;
            _txtMaxAz.Size = new Size(33, 20);
            _txtMaxAz.TabIndex = 24;
            _txtMaxAz.Text = "360";
            ToolTip1.SetToolTip(_txtMaxAz, "Range 0 to 360");
            // 
            // txtMinAz
            // 
            _txtMinAz.AcceptsReturn = true;
            _txtMinAz.BackColor = SystemColors.Window;
            _txtMinAz.Cursor = Cursors.IBeam;
            _txtMinAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMinAz.ForeColor = SystemColors.WindowText;
            _txtMinAz.Location = new Point(232, 272);
            _txtMinAz.MaxLength = 3;
            _txtMinAz.Name = "_txtMinAz";
            _txtMinAz.RightToLeft = RightToLeft.No;
            _txtMinAz.Size = new Size(33, 20);
            _txtMinAz.TabIndex = 21;
            _txtMinAz.Text = "0";
            ToolTip1.SetToolTip(_txtMinAz, "Range 0 to 360");
            // 
            // txtLMin
            // 
            _txtLMin.AcceptsReturn = true;
            _txtLMin.BackColor = SystemColors.Window;
            _txtLMin.Cursor = Cursors.IBeam;
            _txtLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLMin.ForeColor = SystemColors.WindowText;
            _txtLMin.Location = new Point(256, 224);
            _txtLMin.MaxLength = 4;
            _txtLMin.Name = "_txtLMin";
            _txtLMin.RightToLeft = RightToLeft.No;
            _txtLMin.Size = new Size(33, 20);
            _txtLMin.TabIndex = 11;
            ToolTip1.SetToolTip(_txtLMin, "Range 0 to 59.9");
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(216, 248);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 15;
            ToolTip1.SetToolTip(_txtLoDeg, "Range 0 to 180");
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(256, 248);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 17;
            ToolTip1.SetToolTip(_txtLoMin, "Range 0 to 59.9");
            // 
            // txtLDeg
            // 
            _txtLDeg.AcceptsReturn = true;
            _txtLDeg.BackColor = SystemColors.Window;
            _txtLDeg.Cursor = Cursors.IBeam;
            _txtLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLDeg.ForeColor = SystemColors.WindowText;
            _txtLDeg.Location = new Point(224, 224);
            _txtLDeg.MaxLength = 2;
            _txtLDeg.Name = "_txtLDeg";
            _txtLDeg.RightToLeft = RightToLeft.No;
            _txtLDeg.Size = new Size(25, 20);
            _txtLDeg.TabIndex = 9;
            ToolTip1.SetToolTip(_txtLDeg, "Range 0 to 90");
            // 
            // txtNewName
            // 
            _txtNewName.AcceptsReturn = true;
            _txtNewName.BackColor = SystemColors.Window;
            _txtNewName.Cursor = Cursors.IBeam;
            _txtNewName.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtNewName.ForeColor = SystemColors.WindowText;
            _txtNewName.Location = new Point(200, 200);
            _txtNewName.MaxLength = 35;
            _txtNewName.Name = "_txtNewName";
            _txtNewName.RightToLeft = RightToLeft.No;
            _txtNewName.Size = new Size(393, 20);
            _txtNewName.TabIndex = 7;
            ToolTip1.SetToolTip(_txtNewName, "Max. 35 characters");
            // 
            // lblDsDist
            // 
            lblDsDist.BackColor = SystemColors.Control;
            lblDsDist.Cursor = Cursors.Default;
            lblDsDist.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDsDist.ForeColor = SystemColors.ControlText;
            lblDsDist.Location = new Point(160, 321);
            lblDsDist.Name = "lblDsDist";
            lblDsDist.RightToLeft = RightToLeft.No;
            lblDsDist.Size = new Size(57, 17);
            lblDsDist.TabIndex = 37;
            lblDsDist.Text = "Ds distance";
            ToolTip1.SetToolTip(lblDsDist, "Distance to dip short horizon");
            lblDsDist.Visible = false;
            // 
            // ShapeContainer1
            // 
            // Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
            // Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            // Me.ShapeContainer1.Name = "ShapeContainer1"
            // Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
            // Me.ShapeContainer1.Size = New System.Drawing.Size(776, 382)
            // Me.ShapeContainer1.TabIndex = 42
            // Me.ShapeContainer1.TabStop = False
            // 
            // Line1
            // 
            // Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
            // Me.Line1.BorderWidth = 2
            // Me.Line1.Name = "Line1"
            // Me.Line1.X1 = 0
            // Me.Line1.X2 = 776
            // Me.Line1.Y1 = 176
            // Me.Line1.Y2 = 176
            // 
            // cboDsUnit
            // 
            cboDsUnit.BackColor = SystemColors.Window;
            cboDsUnit.Cursor = Cursors.Default;
            cboDsUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDsUnit.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDsUnit.ForeColor = SystemColors.WindowText;
            cboDsUnit.Items.AddRange(new object[] { "feet", "yards", "meters", "statute miles", "nautical miles" });
            cboDsUnit.Location = new Point(272, 321);
            cboDsUnit.Name = "cboDsUnit";
            cboDsUnit.RightToLeft = RightToLeft.No;
            cboDsUnit.Size = new Size(89, 22);
            cboDsUnit.TabIndex = 39;
            cboDsUnit.Visible = false;
            // 
            // optHorizonNatural
            // 
            _optHorizonNatural.BackColor = SystemColors.Control;
            _optHorizonNatural.Checked = true;
            _optHorizonNatural.Cursor = Cursors.Default;
            _optHorizonNatural.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonNatural.ForeColor = SystemColors.ControlText;
            _optHorizonNatural.Location = new Point(216, 296);
            _optHorizonNatural.Name = "_optHorizonNatural";
            _optHorizonNatural.RightToLeft = RightToLeft.No;
            _optHorizonNatural.Size = new Size(65, 18);
            _optHorizonNatural.TabIndex = 35;
            _optHorizonNatural.TabStop = true;
            _optHorizonNatural.Text = "Natural";
            _optHorizonNatural.UseVisualStyleBackColor = false;
            // 
            // optHorizonArtificial
            // 
            _optHorizonArtificial.BackColor = SystemColors.Control;
            _optHorizonArtificial.Cursor = Cursors.Default;
            _optHorizonArtificial.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonArtificial.ForeColor = SystemColors.ControlText;
            _optHorizonArtificial.Location = new Point(284, 296);
            _optHorizonArtificial.Name = "_optHorizonArtificial";
            _optHorizonArtificial.RightToLeft = RightToLeft.No;
            _optHorizonArtificial.Size = new Size(68, 18);
            _optHorizonArtificial.TabIndex = 34;
            _optHorizonArtificial.TabStop = true;
            _optHorizonArtificial.Text = "Artificial";
            _optHorizonArtificial.UseVisualStyleBackColor = false;
            // 
            // optHorizonDipShort
            // 
            _optHorizonDipShort.BackColor = SystemColors.Control;
            _optHorizonDipShort.Cursor = Cursors.Default;
            _optHorizonDipShort.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonDipShort.ForeColor = SystemColors.ControlText;
            _optHorizonDipShort.Location = new Point(354, 296);
            _optHorizonDipShort.Name = "_optHorizonDipShort";
            _optHorizonDipShort.RightToLeft = RightToLeft.No;
            _optHorizonDipShort.Size = new Size(65, 18);
            _optHorizonDipShort.TabIndex = 33;
            _optHorizonDipShort.TabStop = true;
            _optHorizonDipShort.Text = "Dip Short";
            _optHorizonDipShort.UseVisualStyleBackColor = false;
            // 
            // cmdUse
            // 
            _cmdUse.BackColor = SystemColors.Control;
            _cmdUse.Cursor = Cursors.Default;
            _cmdUse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdUse.ForeColor = SystemColors.ControlText;
            _cmdUse.Location = new Point(664, 144);
            _cmdUse.Name = "_cmdUse";
            _cmdUse.RightToLeft = RightToLeft.No;
            _cmdUse.Size = new Size(105, 25);
            _cmdUse.TabIndex = 32;
            _cmdUse.Text = "&Use Location";
            _cmdUse.UseVisualStyleBackColor = false;
            // 
            // cmdSave
            // 
            _cmdSave.BackColor = SystemColors.Control;
            _cmdSave.Cursor = Cursors.Default;
            _cmdSave.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdSave.ForeColor = SystemColors.ControlText;
            _cmdSave.Location = new Point(123, 144);
            _cmdSave.Name = "_cmdSave";
            _cmdSave.RightToLeft = RightToLeft.No;
            _cmdSave.Size = new Size(105, 25);
            _cmdSave.TabIndex = 28;
            _cmdSave.Text = "&Save Location List";
            _cmdSave.UseVisualStyleBackColor = false;
            // 
            // cmdRemoveLocation
            // 
            _cmdRemoveLocation.BackColor = SystemColors.Control;
            _cmdRemoveLocation.Cursor = Cursors.Default;
            _cmdRemoveLocation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdRemoveLocation.ForeColor = SystemColors.ControlText;
            _cmdRemoveLocation.Location = new Point(553, 144);
            _cmdRemoveLocation.Name = "_cmdRemoveLocation";
            _cmdRemoveLocation.RightToLeft = RightToLeft.No;
            _cmdRemoveLocation.Size = new Size(105, 25);
            _cmdRemoveLocation.TabIndex = 27;
            _cmdRemoveLocation.Text = "&Remove Location";
            _cmdRemoveLocation.UseVisualStyleBackColor = false;
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(296, 224);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 22);
            cboL.TabIndex = 13;
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(296, 248);
            cboLo.Name = "cboLo";
            cboLo.RightToLeft = RightToLeft.No;
            cboLo.Size = new Size(41, 22);
            cboLo.TabIndex = 19;
            // 
            // cmdAddLocation
            // 
            _cmdAddLocation.BackColor = SystemColors.Control;
            _cmdAddLocation.Cursor = Cursors.Default;
            _cmdAddLocation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdAddLocation.ForeColor = SystemColors.ControlText;
            _cmdAddLocation.Location = new Point(328, 350);
            _cmdAddLocation.Name = "_cmdAddLocation";
            _cmdAddLocation.RightToLeft = RightToLeft.No;
            _cmdAddLocation.Size = new Size(121, 25);
            _cmdAddLocation.TabIndex = 26;
            _cmdAddLocation.Text = "&Add New Location";
            _cmdAddLocation.UseVisualStyleBackColor = false;
            // 
            // lstFavorites
            // 
            _lstFavorites.BackColor = SystemColors.Window;
            _lstFavorites.Cursor = Cursors.Default;
            _lstFavorites.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lstFavorites.ForeColor = SystemColors.WindowText;
            _lstFavorites.ItemHeight = 14;
            _lstFavorites.Location = new Point(8, 32);
            _lstFavorites.Name = "_lstFavorites";
            _lstFavorites.RightToLeft = RightToLeft.No;
            _lstFavorites.ScrollAlwaysVisible = true;
            _lstFavorites.Size = new Size(761, 102);
            _lstFavorites.Sorted = true;
            _lstFavorites.TabIndex = 0;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Control;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(616, 16);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(55, 17);
            Label3.TabIndex = 41;
            Label3.Text = "Ds dist.";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(576, 16);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(24, 17);
            Label1.TabIndex = 40;
            Label1.Text = "Hor";
            // 
            // lblHorizon
            // 
            lblHorizon.BackColor = SystemColors.Control;
            lblHorizon.Cursor = Cursors.Default;
            lblHorizon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHorizon.ForeColor = SystemColors.ControlText;
            lblHorizon.Location = new Point(160, 296);
            lblHorizon.Name = "lblHorizon";
            lblHorizon.RightToLeft = RightToLeft.No;
            lblHorizon.Size = new Size(49, 17);
            lblHorizon.TabIndex = 36;
            lblHorizon.Text = "Horizon";
            // 
            // lblSelect
            // 
            lblSelect.BackColor = SystemColors.Control;
            lblSelect.Cursor = Cursors.Default;
            lblSelect.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSelect.ForeColor = SystemColors.ControlText;
            lblSelect.Location = new Point(8, 0);
            lblSelect.Name = "lblSelect";
            lblSelect.RightToLeft = RightToLeft.No;
            lblSelect.Size = new Size(81, 17);
            lblSelect.TabIndex = 31;
            lblSelect.Text = "Select location:";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(16, 8);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(105, 1);
            Label2.TabIndex = 30;
            Label2.Text = "Label2";
            // 
            // lblNewLocation
            // 
            lblNewLocation.BackColor = SystemColors.Control;
            lblNewLocation.Cursor = Cursors.Default;
            lblNewLocation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNewLocation.ForeColor = SystemColors.ControlText;
            lblNewLocation.Location = new Point(200, 184);
            lblNewLocation.Name = "lblNewLocation";
            lblNewLocation.RightToLeft = RightToLeft.No;
            lblNewLocation.Size = new Size(80, 17);
            lblNewLocation.TabIndex = 29;
            lblNewLocation.Text = "New Location:";
            // 
            // lblMaxAzdeg
            // 
            lblMaxAzdeg.BackColor = SystemColors.Control;
            lblMaxAzdeg.Cursor = Cursors.Default;
            lblMaxAzdeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMaxAzdeg.ForeColor = SystemColors.ControlText;
            lblMaxAzdeg.Location = new Point(329, 272);
            lblMaxAzdeg.Name = "lblMaxAzdeg";
            lblMaxAzdeg.RightToLeft = RightToLeft.No;
            lblMaxAzdeg.Size = new Size(9, 17);
            lblMaxAzdeg.TabIndex = 25;
            lblMaxAzdeg.Text = "°";
            // 
            // lblMinAzDeg
            // 
            lblMinAzDeg.BackColor = SystemColors.Control;
            lblMinAzDeg.Cursor = Cursors.Default;
            lblMinAzDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMinAzDeg.ForeColor = SystemColors.ControlText;
            lblMinAzDeg.Location = new Point(265, 272);
            lblMinAzDeg.Name = "lblMinAzDeg";
            lblMinAzDeg.RightToLeft = RightToLeft.No;
            lblMinAzDeg.Size = new Size(9, 17);
            lblMinAzDeg.TabIndex = 22;
            lblMinAzDeg.Text = "°";
            // 
            // lblNewMaxAz
            // 
            lblNewMaxAz.BackColor = SystemColors.Control;
            lblNewMaxAz.Cursor = Cursors.Default;
            lblNewMaxAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNewMaxAz.ForeColor = SystemColors.ControlText;
            lblNewMaxAz.Location = new Point(275, 272);
            lblNewMaxAz.Name = "lblNewMaxAz";
            lblNewMaxAz.RightToLeft = RightToLeft.No;
            lblNewMaxAz.Size = new Size(18, 17);
            lblNewMaxAz.TabIndex = 23;
            lblNewMaxAz.Text = "to";
            lblNewMaxAz.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNewMinAz
            // 
            lblNewMinAz.BackColor = SystemColors.Control;
            lblNewMinAz.Cursor = Cursors.Default;
            lblNewMinAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNewMinAz.ForeColor = SystemColors.ControlText;
            lblNewMinAz.Location = new Point(160, 272);
            lblNewMinAz.Name = "lblNewMinAz";
            lblNewMinAz.RightToLeft = RightToLeft.No;
            lblNewMinAz.Size = new Size(68, 17);
            lblNewMinAz.TabIndex = 20;
            lblNewMinAz.Text = "Azimuth from";
            // 
            // lblNewLong
            // 
            lblNewLong.BackColor = SystemColors.Control;
            lblNewLong.Cursor = Cursors.Default;
            lblNewLong.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNewLong.ForeColor = SystemColors.ControlText;
            lblNewLong.Location = new Point(160, 248);
            lblNewLong.Name = "lblNewLong";
            lblNewLong.RightToLeft = RightToLeft.No;
            lblNewLong.Size = new Size(55, 17);
            lblNewLong.TabIndex = 14;
            lblNewLong.Text = "Longitude";
            // 
            // lblNewLat
            // 
            lblNewLat.BackColor = SystemColors.Control;
            lblNewLat.Cursor = Cursors.Default;
            lblNewLat.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNewLat.ForeColor = SystemColors.ControlText;
            lblNewLat.Location = new Point(160, 224);
            lblNewLat.Name = "lblNewLat";
            lblNewLat.RightToLeft = RightToLeft.No;
            lblNewLat.Size = new Size(57, 17);
            lblNewLat.TabIndex = 8;
            lblNewLat.Text = "Latitude";
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Control;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(249, 224);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 10;
            lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Control;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(289, 224);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 12;
            lblLMin.Text = "'";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Control;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(249, 248);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 16;
            lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Control;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(289, 248);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 18;
            lblLoMin.Text = "'";
            // 
            // lblNewName
            // 
            lblNewName.BackColor = SystemColors.Control;
            lblNewName.Cursor = Cursors.Default;
            lblNewName.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNewName.ForeColor = SystemColors.ControlText;
            lblNewName.Location = new Point(160, 200);
            lblNewName.Name = "lblNewName";
            lblNewName.RightToLeft = RightToLeft.No;
            lblNewName.Size = new Size(36, 17);
            lblNewName.TabIndex = 6;
            lblNewName.Text = "Name";
            // 
            // lblMaxAz
            // 
            lblMaxAz.BackColor = SystemColors.Control;
            lblMaxAz.Cursor = Cursors.Default;
            lblMaxAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMaxAz.ForeColor = SystemColors.ControlText;
            lblMaxAz.Location = new Point(520, 16);
            lblMaxAz.Name = "lblMaxAz";
            lblMaxAz.RightToLeft = RightToLeft.No;
            lblMaxAz.Size = new Size(38, 17);
            lblMaxAz.TabIndex = 5;
            lblMaxAz.Text = "To Zn";
            // 
            // lblMinAz
            // 
            lblMinAz.BackColor = SystemColors.Control;
            lblMinAz.Cursor = Cursors.Default;
            lblMinAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMinAz.ForeColor = SystemColors.ControlText;
            lblMinAz.Location = new Point(448, 16);
            lblMinAz.Name = "lblMinAz";
            lblMinAz.RightToLeft = RightToLeft.No;
            lblMinAz.Size = new Size(55, 17);
            lblMinAz.TabIndex = 4;
            lblMinAz.Text = "From Zn";
            // 
            // lblLongitude
            // 
            lblLongitude.BackColor = SystemColors.Control;
            lblLongitude.Cursor = Cursors.Default;
            lblLongitude.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLongitude.ForeColor = SystemColors.ControlText;
            lblLongitude.Location = new Point(360, 16);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.RightToLeft = RightToLeft.No;
            lblLongitude.Size = new Size(55, 17);
            lblLongitude.TabIndex = 3;
            lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            lblLatitude.BackColor = SystemColors.Control;
            lblLatitude.Cursor = Cursors.Default;
            lblLatitude.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLatitude.ForeColor = SystemColors.ControlText;
            lblLatitude.Location = new Point(280, 16);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.RightToLeft = RightToLeft.No;
            lblLatitude.Size = new Size(50, 17);
            lblLatitude.TabIndex = 2;
            lblLatitude.Text = "Latitude";
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.Control;
            lblName.Cursor = Cursors.Default;
            lblName.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblName.ForeColor = SystemColors.ControlText;
            lblName.Location = new Point(16, 16);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.No;
            lblName.Size = new Size(38, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // ExitBtn
            // 
            _ExitBtn.Location = new Point(694, 351);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(75, 23);
            _ExitBtn.TabIndex = 43;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = true;
            // 
            // btnOpenLocList
            // 
            _btnOpenLocList.BackColor = SystemColors.Control;
            _btnOpenLocList.Cursor = Cursors.Default;
            _btnOpenLocList.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnOpenLocList.ForeColor = SystemColors.ControlText;
            _btnOpenLocList.Location = new Point(8, 144);
            _btnOpenLocList.Name = "_btnOpenLocList";
            _btnOpenLocList.RightToLeft = RightToLeft.No;
            _btnOpenLocList.Size = new Size(105, 25);
            _btnOpenLocList.TabIndex = 44;
            _btnOpenLocList.Text = "Open Location List";
            _btnOpenLocList.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Control;
            ClientSize = new Size(776, 382);
            Controls.Add(_btnOpenLocList);
            Controls.Add(_ExitBtn);
            Controls.Add(cboDsUnit);
            Controls.Add(_txtDsDist);
            Controls.Add(_optHorizonNatural);
            Controls.Add(_optHorizonArtificial);
            Controls.Add(_optHorizonDipShort);
            Controls.Add(_cmdUse);
            Controls.Add(_cmdSave);
            Controls.Add(_cmdRemoveLocation);
            Controls.Add(_txtMaxAz);
            Controls.Add(_txtMinAz);
            Controls.Add(_txtLMin);
            Controls.Add(cboL);
            Controls.Add(_txtLoDeg);
            Controls.Add(_txtLoMin);
            Controls.Add(cboLo);
            Controls.Add(_txtLDeg);
            Controls.Add(_txtNewName);
            Controls.Add(_cmdAddLocation);
            Controls.Add(_lstFavorites);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(lblDsDist);
            Controls.Add(lblHorizon);
            Controls.Add(lblSelect);
            Controls.Add(Label2);
            Controls.Add(lblNewLocation);
            Controls.Add(lblMaxAzdeg);
            Controls.Add(lblMinAzDeg);
            Controls.Add(lblNewMaxAz);
            Controls.Add(lblNewMinAz);
            Controls.Add(lblNewLong);
            Controls.Add(lblNewLat);
            Controls.Add(lblLDeg);
            Controls.Add(lblLMin);
            Controls.Add(lblLoDeg);
            Controls.Add(lblLoMin);
            Controls.Add(lblNewName);
            Controls.Add(lblMaxAz);
            Controls.Add(lblMinAz);
            Controls.Add(lblLongitude);
            Controls.Add(lblLatitude);
            Controls.Add(lblName);
            // Me.Controls.Add(Me.ShapeContainer1)
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form7";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favorite Places";
            Load += new EventHandler(Form7_Load);
            FormClosing += new FormClosingEventHandler(Form7_FormClosing);
            FormClosed += new FormClosedEventHandler(Form7_FormClosed);
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

        private Button _btnOpenLocList;

        public Button btnOpenLocList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOpenLocList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOpenLocList != null)
                {
                    _btnOpenLocList.Click -= btnOpenLocList_Click;
                }

                _btnOpenLocList = value;
                if (_btnOpenLocList != null)
                {
                    _btnOpenLocList.Click += btnOpenLocList_Click;
                }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}