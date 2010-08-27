namespace LQFBUI
{
    partial class LQFBUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LQFBUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textAPIKEY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAPIURL = new System.Windows.Forms.TextBox();
            this.iniTree = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAreaLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolAreaInterest = new System.Windows.Forms.ToolStripButton();
            this.toolAreaAutoreject = new System.Windows.Forms.ToolStripButton();
            this.toolAreaIgnore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTopicLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolTopicInterest = new System.Windows.Forms.ToolStripButton();
            this.toolTopicAutoreject = new System.Windows.Forms.ToolStripButton();
            this.toolTopicVotelater = new System.Windows.Forms.ToolStripButton();
            this.toolTopicIgnore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolIniLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolIniSupport = new System.Windows.Forms.ToolStripButton();
            this.toolButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolIniPotential = new System.Windows.Forms.ToolStripButton();
            this.toolIniWatchChange = new System.Windows.Forms.ToolStripButton();
            this.toolIniWatchIdea = new System.Windows.Forms.ToolStripButton();
            this.toolIniRead = new System.Windows.Forms.ToolStripButton();
            this.textInitiative = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textAPIKEY);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textAPIURL);
            this.splitContainer1.Panel1.Controls.Add(this.iniTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(799, 396);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(56, 371);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(206, 24);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update from API";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "API Key";
            // 
            // textAPIKEY
            // 
            this.textAPIKEY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textAPIKEY.Location = new System.Drawing.Point(56, 345);
            this.textAPIKEY.Name = "textAPIKEY";
            this.textAPIKEY.Size = new System.Drawing.Size(206, 20);
            this.textAPIKEY.TabIndex = 3;
            this.textAPIKEY.UseSystemPasswordChar = true;
            this.textAPIKEY.Validated += new System.EventHandler(this.textAPIKEY_Validated);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "API URL";
            // 
            // textAPIURL
            // 
            this.textAPIURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textAPIURL.Location = new System.Drawing.Point(56, 319);
            this.textAPIURL.Name = "textAPIURL";
            this.textAPIURL.Size = new System.Drawing.Size(206, 20);
            this.textAPIURL.TabIndex = 1;
            this.textAPIURL.Text = "https://lqfb.piratenpartei.de/pp/api/";
            this.textAPIURL.Validated += new System.EventHandler(this.textAPIURL_Validated);
            // 
            // iniTree
            // 
            this.iniTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.iniTree.LabelEdit = true;
            this.iniTree.Location = new System.Drawing.Point(0, 0);
            this.iniTree.Name = "iniTree";
            this.iniTree.Size = new System.Drawing.Size(262, 313);
            this.iniTree.TabIndex = 0;
            this.iniTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.iniTree_BeforeLabelEdit);
            this.iniTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.iniTree_AfterLabelEdit);
            this.iniTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.iniTree_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.textInitiative);
            this.splitContainer2.Size = new System.Drawing.Size(530, 396);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolAreaLabel,
            this.toolAreaInterest,
            this.toolAreaAutoreject,
            this.toolAreaIgnore,
            this.toolStripSeparator1,
            this.toolTopicLabel,
            this.toolTopicInterest,
            this.toolTopicAutoreject,
            this.toolTopicVotelater,
            this.toolTopicIgnore,
            this.toolStripSeparator2,
            this.toolIniLabel,
            this.toolIniSupport,
            this.toolButtonAbout,
            this.toolStripSeparator3,
            this.toolIniPotential,
            this.toolIniWatchChange,
            this.toolIniWatchIdea,
            this.toolIniRead});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(530, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAreaLabel
            // 
            this.toolAreaLabel.Enabled = false;
            this.toolAreaLabel.Name = "toolAreaLabel";
            this.toolAreaLabel.Size = new System.Drawing.Size(42, 22);
            this.toolAreaLabel.Text = "Bereich";
            // 
            // toolAreaInterest
            // 
            this.toolAreaInterest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAreaInterest.Enabled = false;
            this.toolAreaInterest.Image = ((System.Drawing.Image)(resources.GetObject("toolAreaInterest.Image")));
            this.toolAreaInterest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAreaInterest.Name = "toolAreaInterest";
            this.toolAreaInterest.Size = new System.Drawing.Size(23, 22);
            this.toolAreaInterest.Text = "Mitgliedschaft (Interesse)";
            this.toolAreaInterest.Click += new System.EventHandler(this.toolAreaInterest_Click);
            // 
            // toolAreaAutoreject
            // 
            this.toolAreaAutoreject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAreaAutoreject.Enabled = false;
            this.toolAreaAutoreject.Image = ((System.Drawing.Image)(resources.GetObject("toolAreaAutoreject.Image")));
            this.toolAreaAutoreject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAreaAutoreject.Name = "toolAreaAutoreject";
            this.toolAreaAutoreject.Size = new System.Drawing.Size(23, 22);
            this.toolAreaAutoreject.Text = "Auto-Ablehnen";
            this.toolAreaAutoreject.Click += new System.EventHandler(this.toolAreaAutoreject_Click);
            // 
            // toolAreaIgnore
            // 
            this.toolAreaIgnore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAreaIgnore.Enabled = false;
            this.toolAreaIgnore.Image = ((System.Drawing.Image)(resources.GetObject("toolAreaIgnore.Image")));
            this.toolAreaIgnore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAreaIgnore.Name = "toolAreaIgnore";
            this.toolAreaIgnore.Size = new System.Drawing.Size(23, 22);
            this.toolAreaIgnore.Text = "Bereich ignorieren";
            this.toolAreaIgnore.Click += new System.EventHandler(this.toolAreaIgnore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTopicLabel
            // 
            this.toolTopicLabel.Enabled = false;
            this.toolTopicLabel.Name = "toolTopicLabel";
            this.toolTopicLabel.Size = new System.Drawing.Size(39, 22);
            this.toolTopicLabel.Text = "Thema";
            // 
            // toolTopicInterest
            // 
            this.toolTopicInterest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTopicInterest.Enabled = false;
            this.toolTopicInterest.Image = ((System.Drawing.Image)(resources.GetObject("toolTopicInterest.Image")));
            this.toolTopicInterest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTopicInterest.Name = "toolTopicInterest";
            this.toolTopicInterest.Size = new System.Drawing.Size(23, 22);
            this.toolTopicInterest.Text = "Interesse";
            this.toolTopicInterest.Click += new System.EventHandler(this.toolTopicInterest_Click);
            // 
            // toolTopicAutoreject
            // 
            this.toolTopicAutoreject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTopicAutoreject.Enabled = false;
            this.toolTopicAutoreject.Image = ((System.Drawing.Image)(resources.GetObject("toolTopicAutoreject.Image")));
            this.toolTopicAutoreject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTopicAutoreject.Name = "toolTopicAutoreject";
            this.toolTopicAutoreject.Size = new System.Drawing.Size(23, 22);
            this.toolTopicAutoreject.Text = "Auto-Ablehnen (dagegenstimmen)";
            this.toolTopicAutoreject.Click += new System.EventHandler(this.toolTopicAutoreject_Click);
            // 
            // toolTopicVotelater
            // 
            this.toolTopicVotelater.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTopicVotelater.Enabled = false;
            this.toolTopicVotelater.Image = ((System.Drawing.Image)(resources.GetObject("toolTopicVotelater.Image")));
            this.toolTopicVotelater.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTopicVotelater.Name = "toolTopicVotelater";
            this.toolTopicVotelater.Size = new System.Drawing.Size(23, 22);
            this.toolTopicVotelater.Text = "Für spätere Abstimmung stimmen";
            this.toolTopicVotelater.Click += new System.EventHandler(this.toolTopicVotelater_Click);
            // 
            // toolTopicIgnore
            // 
            this.toolTopicIgnore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTopicIgnore.Enabled = false;
            this.toolTopicIgnore.Image = ((System.Drawing.Image)(resources.GetObject("toolTopicIgnore.Image")));
            this.toolTopicIgnore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTopicIgnore.Name = "toolTopicIgnore";
            this.toolTopicIgnore.Size = new System.Drawing.Size(23, 22);
            this.toolTopicIgnore.Text = "Thema ignorieren";
            this.toolTopicIgnore.Click += new System.EventHandler(this.toolTopicIgnore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolIniLabel
            // 
            this.toolIniLabel.Enabled = false;
            this.toolIniLabel.Name = "toolIniLabel";
            this.toolIniLabel.Size = new System.Drawing.Size(49, 22);
            this.toolIniLabel.Text = "Initiative";
            // 
            // toolIniSupport
            // 
            this.toolIniSupport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolIniSupport.Enabled = false;
            this.toolIniSupport.Image = ((System.Drawing.Image)(resources.GetObject("toolIniSupport.Image")));
            this.toolIniSupport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIniSupport.Name = "toolIniSupport";
            this.toolIniSupport.Size = new System.Drawing.Size(23, 22);
            this.toolIniSupport.Text = "Unterstützen";
            // 
            // toolButtonAbout
            // 
            this.toolButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonAbout.Image")));
            this.toolButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonAbout.Name = "toolButtonAbout";
            this.toolButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolButtonAbout.Text = "Hilfe/About";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolIniPotential
            // 
            this.toolIniPotential.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolIniPotential.Enabled = false;
            this.toolIniPotential.Image = ((System.Drawing.Image)(resources.GetObject("toolIniPotential.Image")));
            this.toolIniPotential.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIniPotential.Name = "toolIniPotential";
            this.toolIniPotential.Size = new System.Drawing.Size(23, 22);
            this.toolIniPotential.Text = "Potentiell unterstützen";
            // 
            // toolIniWatchChange
            // 
            this.toolIniWatchChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolIniWatchChange.Enabled = false;
            this.toolIniWatchChange.Image = ((System.Drawing.Image)(resources.GetObject("toolIniWatchChange.Image")));
            this.toolIniWatchChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIniWatchChange.Name = "toolIniWatchChange";
            this.toolIniWatchChange.Size = new System.Drawing.Size(23, 22);
            this.toolIniWatchChange.Text = "Textänderungen beobachten";
            // 
            // toolIniWatchIdea
            // 
            this.toolIniWatchIdea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolIniWatchIdea.Enabled = false;
            this.toolIniWatchIdea.Image = ((System.Drawing.Image)(resources.GetObject("toolIniWatchIdea.Image")));
            this.toolIniWatchIdea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIniWatchIdea.Name = "toolIniWatchIdea";
            this.toolIniWatchIdea.Size = new System.Drawing.Size(23, 22);
            this.toolIniWatchIdea.Text = "Anregungen beobachten";
            // 
            // toolIniRead
            // 
            this.toolIniRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolIniRead.Enabled = false;
            this.toolIniRead.Image = ((System.Drawing.Image)(resources.GetObject("toolIniRead.Image")));
            this.toolIniRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIniRead.Name = "toolIniRead";
            this.toolIniRead.Size = new System.Drawing.Size(23, 22);
            this.toolIniRead.Text = "Änderungen gesehen";
            // 
            // textInitiative
            // 
            this.textInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textInitiative.Location = new System.Drawing.Point(3, 28);
            this.textInitiative.Multiline = true;
            this.textInitiative.Name = "textInitiative";
            this.textInitiative.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInitiative.Size = new System.Drawing.Size(524, 167);
            this.textInitiative.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(799, 371);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(799, 396);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // LQFBUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(799, 396);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "LQFBUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "LQFB UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.LQFBUI_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView iniTree;
        private System.Windows.Forms.TextBox textInitiative;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAPIKEY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAPIURL;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolAreaLabel;
        private System.Windows.Forms.ToolStripButton toolAreaInterest;
        private System.Windows.Forms.ToolStripButton toolAreaAutoreject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolTopicLabel;
        private System.Windows.Forms.ToolStripButton toolTopicInterest;
        private System.Windows.Forms.ToolStripButton toolTopicAutoreject;
        private System.Windows.Forms.ToolStripButton toolTopicVotelater;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolIniLabel;
        private System.Windows.Forms.ToolStripButton toolIniSupport;
        private System.Windows.Forms.ToolStripButton toolButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolIniPotential;
        private System.Windows.Forms.ToolStripButton toolAreaIgnore;
        private System.Windows.Forms.ToolStripButton toolTopicIgnore;
        private System.Windows.Forms.ToolStripButton toolIniWatchChange;
        private System.Windows.Forms.ToolStripButton toolIniWatchIdea;
        private System.Windows.Forms.ToolStripButton toolIniRead;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

    }
}

