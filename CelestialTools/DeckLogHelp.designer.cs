using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CelestialTools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DeckLogHelp : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckLogHelp));
            _btnInfoExit = new Button();
            _btnInfoExit.Click += new EventHandler(btnInfoExit_Click);
            TabDeckLogInfo = new TabControl();
            GeneralInfo = new TabPage();
            txtGenInfo = new RichTextBox();
            FileActions = new TabPage();
            RichTextBox1 = new RichTextBox();
            LogDataEntry = new TabPage();
            RichTextBox2 = new RichTextBox();
            EntryFields = new TabPage();
            RichTextBox3 = new RichTextBox();
            DataGridActions = new TabPage();
            RichTextBox4 = new RichTextBox();
            TabDeckLogInfo.SuspendLayout();
            GeneralInfo.SuspendLayout();
            FileActions.SuspendLayout();
            LogDataEntry.SuspendLayout();
            EntryFields.SuspendLayout();
            DataGridActions.SuspendLayout();
            SuspendLayout();
            // 
            // btnInfoExit
            // 
            _btnInfoExit.BackColor = Color.Red;
            _btnInfoExit.ForeColor = Color.White;
            _btnInfoExit.Location = new Point(548, 4);
            _btnInfoExit.Name = "_btnInfoExit";
            _btnInfoExit.Size = new Size(118, 23);
            _btnInfoExit.TabIndex = 9;
            _btnInfoExit.Text = "Exit";
            _btnInfoExit.UseVisualStyleBackColor = false;
            // 
            // TabDeckLogInfo
            // 
            TabDeckLogInfo.Controls.Add(GeneralInfo);
            TabDeckLogInfo.Controls.Add(FileActions);
            TabDeckLogInfo.Controls.Add(LogDataEntry);
            TabDeckLogInfo.Controls.Add(EntryFields);
            TabDeckLogInfo.Controls.Add(DataGridActions);
            TabDeckLogInfo.Location = new Point(12, 33);
            TabDeckLogInfo.Name = "TabDeckLogInfo";
            TabDeckLogInfo.SelectedIndex = 0;
            TabDeckLogInfo.Size = new Size(659, 640);
            TabDeckLogInfo.TabIndex = 10;
            // 
            // GeneralInfo
            // 
            GeneralInfo.Controls.Add(txtGenInfo);
            GeneralInfo.Location = new Point(4, 22);
            GeneralInfo.Name = "GeneralInfo";
            GeneralInfo.Padding = new Padding(3);
            GeneralInfo.Size = new Size(651, 614);
            GeneralInfo.TabIndex = 0;
            GeneralInfo.Text = "General Info";
            GeneralInfo.UseVisualStyleBackColor = true;
            // 
            // txtGenInfo
            // 
            txtGenInfo.Location = new Point(7, 4);
            txtGenInfo.Name = "txtGenInfo";
            txtGenInfo.Size = new Size(638, 604);
            txtGenInfo.TabIndex = 0;
            txtGenInfo.Text = resources.GetString("txtGenInfo.Text");
            // 
            // FileActions
            // 
            FileActions.Controls.Add(RichTextBox1);
            FileActions.Location = new Point(4, 22);
            FileActions.Name = "FileActions";
            FileActions.Padding = new Padding(3);
            FileActions.Size = new Size(651, 614);
            FileActions.TabIndex = 1;
            FileActions.Text = "Form and File Buttons";
            FileActions.UseVisualStyleBackColor = true;
            // 
            // RichTextBox1
            // 
            RichTextBox1.Location = new Point(6, 5);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(638, 582);
            RichTextBox1.TabIndex = 1;
            RichTextBox1.Text = resources.GetString("RichTextBox1.Text");
            // 
            // LogDataEntry
            // 
            LogDataEntry.Controls.Add(RichTextBox2);
            LogDataEntry.Location = new Point(4, 22);
            LogDataEntry.Name = "LogDataEntry";
            LogDataEntry.Size = new Size(651, 614);
            LogDataEntry.TabIndex = 2;
            LogDataEntry.Text = "Log Data Entry Buttons";
            LogDataEntry.UseVisualStyleBackColor = true;
            // 
            // RichTextBox2
            // 
            RichTextBox2.Location = new Point(6, 4);
            RichTextBox2.Name = "RichTextBox2";
            RichTextBox2.Size = new Size(638, 607);
            RichTextBox2.TabIndex = 2;
            RichTextBox2.Text = resources.GetString("RichTextBox2.Text");
            // 
            // EntryFields
            // 
            EntryFields.Controls.Add(RichTextBox3);
            EntryFields.Location = new Point(4, 22);
            EntryFields.Name = "EntryFields";
            EntryFields.Size = new Size(651, 614);
            EntryFields.TabIndex = 3;
            EntryFields.Text = "Log Data Entry Fields";
            EntryFields.UseVisualStyleBackColor = true;
            // 
            // RichTextBox3
            // 
            RichTextBox3.Location = new Point(5, 4);
            RichTextBox3.Name = "RichTextBox3";
            RichTextBox3.Size = new Size(638, 607);
            RichTextBox3.TabIndex = 2;
            RichTextBox3.Text = resources.GetString("RichTextBox3.Text");
            // 
            // DataGridActions
            // 
            DataGridActions.Controls.Add(RichTextBox4);
            DataGridActions.Location = new Point(4, 22);
            DataGridActions.Name = "DataGridActions";
            DataGridActions.Size = new Size(651, 614);
            DataGridActions.TabIndex = 4;
            DataGridActions.Text = "Data Grid Actions";
            DataGridActions.UseVisualStyleBackColor = true;
            // 
            // RichTextBox4
            // 
            RichTextBox4.Location = new Point(6, 3);
            RichTextBox4.Name = "RichTextBox4";
            RichTextBox4.Size = new Size(638, 608);
            RichTextBox4.TabIndex = 2;
            RichTextBox4.Text = resources.GetString("RichTextBox4.Text");
            // 
            // DeckLogHelp
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 685);
            Controls.Add(TabDeckLogInfo);
            Controls.Add(_btnInfoExit);
            Name = "DeckLogHelp";
            Text = "Deck Log Info ";
            TabDeckLogInfo.ResumeLayout(false);
            GeneralInfo.ResumeLayout(false);
            FileActions.ResumeLayout(false);
            LogDataEntry.ResumeLayout(false);
            EntryFields.ResumeLayout(false);
            DataGridActions.ResumeLayout(false);
            ResumeLayout(false);
        }

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

        internal TabControl TabDeckLogInfo;
        internal TabPage GeneralInfo;
        internal RichTextBox txtGenInfo;
        internal TabPage FileActions;
        internal TabPage LogDataEntry;
        internal TabPage EntryFields;
        internal TabPage DataGridActions;
        internal RichTextBox RichTextBox1;
        internal RichTextBox RichTextBox2;
        internal RichTextBox RichTextBox3;
        internal RichTextBox RichTextBox4;
    }
}