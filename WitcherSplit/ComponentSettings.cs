using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using LiveSplit.BunnySplit;


namespace WitcherSplit {

namespace LiveSplit.BunnySplit
{
    public class ComponentSettings : UserControl
    {       

        public ComponentSettings()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            this.SplitOnFactsCheckbox = new System.Windows.Forms.CheckBox();
            this.EnableAutoSplitCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnableAutoStartCheckbox = new System.Windows.Forms.CheckBox();
            //this.EnableAutoResetCheckbox = new System.Windows.Forms.CheckBox();
            this.SplitOnFactsList = new EditableListBox();
            this.Facts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOnFactsList)).BeginInit();
            this.SuspendLayout();
            
            // 
            // SplitOnFactsCheckbox
            // 
            this.SplitOnFactsCheckbox.AutoSize = true;
            this.SplitOnFactsCheckbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SplitOnFactsCheckbox.Location = new System.Drawing.Point(6, 50);
            this.SplitOnFactsCheckbox.Name = "SplitOnFactsCheckbox";
            this.SplitOnFactsCheckbox.Size = new System.Drawing.Size(154, 17);
            this.SplitOnFactsCheckbox.TabIndex = 1;
            this.SplitOnFactsCheckbox.Text = "Split on the following Facts:";
            this.SplitOnFactsCheckbox.UseVisualStyleBackColor = true;
           
            // 
            // EnableAutoSplitCheckbox
            // 
            this.EnableAutoSplitCheckbox.AutoSize = true;
            this.EnableAutoSplitCheckbox.Location = new System.Drawing.Point(6, 19);
            this.EnableAutoSplitCheckbox.Name = "EnableAutoSplitCheckbox";
            this.EnableAutoSplitCheckbox.Size = new System.Drawing.Size(104, 17);
            this.EnableAutoSplitCheckbox.TabIndex = 6;
            this.EnableAutoSplitCheckbox.Text = "Enable AutoSplit";
            this.EnableAutoSplitCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SplitOnFactsList);
            this.groupBox1.Controls.Add(this.EnableAutoSplitCheckbox);
            this.groupBox1.Controls.Add(this.SplitOnFactsCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 213);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AutoSplit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 289);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            //this.groupBox2.Controls.Add(this.EnableAutoResetCheckbox);
            this.groupBox2.Controls.Add(this.EnableAutoStartCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(3, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AutoStart";
            // 
            // EnableAutoStartCheckbox
            // 
            this.EnableAutoStartCheckbox.AutoSize = true;
            this.EnableAutoStartCheckbox.Checked = true;
            this.EnableAutoStartCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableAutoStartCheckbox.Location = new System.Drawing.Point(7, 20);
            this.EnableAutoStartCheckbox.Name = "EnableAutoStartCheckbox";
            this.EnableAutoStartCheckbox.Size = new System.Drawing.Size(106, 17);
            this.EnableAutoStartCheckbox.TabIndex = 0;
            this.EnableAutoStartCheckbox.Text = "Enable AutoStart";
            this.EnableAutoStartCheckbox.UseVisualStyleBackColor = true;
            // 
            // EnableAutoResetCheckbox
            // 
           /* this.EnableAutoResetCheckbox.AutoSize = true;
            this.EnableAutoResetCheckbox.Checked = true;
            this.EnableAutoResetCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableAutoResetCheckbox.Location = new System.Drawing.Point(7, 43);
            this.EnableAutoResetCheckbox.Name = "EnableAutoResetCheckbox";
            this.EnableAutoResetCheckbox.Size = new System.Drawing.Size(112, 17);
            this.EnableAutoResetCheckbox.TabIndex = 1;
            this.EnableAutoResetCheckbox.Text = "Enable AutoReset";
            this.EnableAutoResetCheckbox.UseVisualStyleBackColor = true;
            */// 
            // SplitOnFactsList
            // 
            this.SplitOnFactsList.AllowUserToResizeRows = false;
            this.SplitOnFactsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SplitOnFactsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SplitOnFactsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitOnFactsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SplitOnFactsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SplitOnFactsList.ColumnHeadersVisible = false;
            this.SplitOnFactsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Facts});
            this.SplitOnFactsList.Location = new System.Drawing.Point(6, 88);
            this.SplitOnFactsList.Name = "SplitOnFactsList";
            this.SplitOnFactsList.RowHeadersVisible = false;
            this.SplitOnFactsList.RowTemplate.Height = 14;
            this.SplitOnFactsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SplitOnFactsList.Size = new System.Drawing.Size(196, 100);
            this.SplitOnFactsList.TabIndex = 2;
            // 
            // Facts
            // 
            this.Facts.HeaderText = "Facts";
            this.Facts.Name = "Facts";
            
            // 
            // ComponentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComponentSettings";
            this.Size = new System.Drawing.Size(222, 418);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOnFactsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox SplitOnFactsCheckbox;
        public EditableListBox SplitOnFactsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facts;
        public System.Windows.Forms.CheckBox EnableAutoSplitCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox EnableAutoResetCheckbox;
        public System.Windows.Forms.CheckBox EnableAutoStartCheckbox;
    

        private static void AppendElement<T>(XmlDocument document, XmlElement parent, string name, T value)
        {
            XmlElement el = document.CreateElement(name);
            el.InnerText = value.ToString();
            parent.AppendChild(el);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            XmlElement settingsNode = document.CreateElement("Settings");

            AppendElement(document, settingsNode, "Version", Assembly.GetExecutingAssembly().GetName().Version);
            AppendElement(document, settingsNode, "EnableAutoSplit", EnableAutoSplitCheckbox.Checked);
            AppendElement(document, settingsNode, "SplitOnFacts", SplitOnFactsCheckbox.Checked);
            AppendElement(document, settingsNode, "SplitOnFactsList", string.Join("|", SplitOnFactsList.GetValues()));

            //AppendElement(document, settingsNode, "EnableAutoReset", EnableAutoResetCheckbox.Checked);
            AppendElement(document, settingsNode, "EnableAutoStart", EnableAutoStartCheckbox.Checked);

            
            return settingsNode;
        }

        private bool FindSetting(XmlNode node, string name, bool previous)
        {
            var element = node[name];
            if (element == null)
                return previous;

            bool b;
            if (bool.TryParse(element.InnerText, out b))
                return b;

            return previous;
        }

        public void SetSettings(XmlNode settings)
        {

            if (settings == null) {
                return;
            }
            
            var versionElement = settings["Version"];
            if (versionElement == null)
                return;
            
            EnableAutoSplitCheckbox.Checked = FindSetting(settings, "EnableAutoSplit", EnableAutoSplitCheckbox.Checked);


            SplitOnFactsCheckbox.Checked = FindSetting(settings, "SplitOnFacts", SplitOnFactsCheckbox.Checked);
            var e = settings["SplitOnFactsList"];
            if (e != null)
                foreach (var map in e.InnerText.Split('|'))
                    SplitOnFactsList.Rows.Add(map);

            //EnableAutoResetCheckbox.Checked = FindSetting(settings, "EnableAutoReset", EnableAutoResetCheckbox.Checked);
            EnableAutoStartCheckbox.Checked = FindSetting(settings, "EnableAutoStart", EnableAutoStartCheckbox.Checked);

        }
    }
}
}