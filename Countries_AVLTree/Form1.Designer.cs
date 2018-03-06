namespace Countries_AVLTree
{
    partial class CountryInfoForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryInformationGroupBox1 = new System.Windows.Forms.GroupBox();
            this.valueCountryName = new System.Windows.Forms.TextBox();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.btnRemoveTradePartner = new System.Windows.Forms.Button();
            this.btnAddTradePartner = new System.Windows.Forms.Button();
            this.labelEditTradePartners = new System.Windows.Forms.Label();
            this.editTradePartnersListView = new System.Windows.Forms.ListView();
            this.tbValueHDIRanking = new System.Windows.Forms.TextBox();
            this.labelHDIRanking = new System.Windows.Forms.Label();
            this.tbValueTradeBalance = new System.Windows.Forms.TextBox();
            this.labelTradeBalance = new System.Windows.Forms.Label();
            this.tbValueInflation = new System.Windows.Forms.TextBox();
            this.labelInflation = new System.Windows.Forms.Label();
            this.tbValueGDPGrowth = new System.Windows.Forms.TextBox();
            this.labelGDPGrowth = new System.Windows.Forms.Label();
            this.lableCountryName = new System.Windows.Forms.Label();
            this.countriesListView = new System.Windows.Forms.ListView();
            this.numberOfCountriesLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthValue = new System.Windows.Forms.Label();
            this.numberOfCountriesValue = new System.Windows.Forms.Label();
            this.countrySearchTB = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.keywordSearchLabel = new System.Windows.Forms.Label();
            this.allCountriesGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.countryInformationGroupBox1.SuspendLayout();
            this.allCountriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // countryInformationGroupBox1
            // 
            this.countryInformationGroupBox1.Controls.Add(this.valueCountryName);
            this.countryInformationGroupBox1.Controls.Add(this.btnSaveEdits);
            this.countryInformationGroupBox1.Controls.Add(this.btnRemoveTradePartner);
            this.countryInformationGroupBox1.Controls.Add(this.btnAddTradePartner);
            this.countryInformationGroupBox1.Controls.Add(this.labelEditTradePartners);
            this.countryInformationGroupBox1.Controls.Add(this.editTradePartnersListView);
            this.countryInformationGroupBox1.Controls.Add(this.tbValueHDIRanking);
            this.countryInformationGroupBox1.Controls.Add(this.labelHDIRanking);
            this.countryInformationGroupBox1.Controls.Add(this.tbValueTradeBalance);
            this.countryInformationGroupBox1.Controls.Add(this.labelTradeBalance);
            this.countryInformationGroupBox1.Controls.Add(this.tbValueInflation);
            this.countryInformationGroupBox1.Controls.Add(this.labelInflation);
            this.countryInformationGroupBox1.Controls.Add(this.tbValueGDPGrowth);
            this.countryInformationGroupBox1.Controls.Add(this.labelGDPGrowth);
            this.countryInformationGroupBox1.Controls.Add(this.lableCountryName);
            this.countryInformationGroupBox1.Location = new System.Drawing.Point(505, 27);
            this.countryInformationGroupBox1.Name = "countryInformationGroupBox1";
            this.countryInformationGroupBox1.Size = new System.Drawing.Size(468, 451);
            this.countryInformationGroupBox1.TabIndex = 1;
            this.countryInformationGroupBox1.TabStop = false;
            this.countryInformationGroupBox1.Text = "Edit Country Information";
            this.countryInformationGroupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // valueCountryName
            // 
            this.valueCountryName.Location = new System.Drawing.Point(102, 25);
            this.valueCountryName.Name = "valueCountryName";
            this.valueCountryName.Size = new System.Drawing.Size(100, 20);
            this.valueCountryName.TabIndex = 18;
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Location = new System.Drawing.Point(172, 420);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(88, 26);
            this.btnSaveEdits.TabIndex = 17;
            this.btnSaveEdits.Text = "Save";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // btnRemoveTradePartner
            // 
            this.btnRemoveTradePartner.Location = new System.Drawing.Point(102, 384);
            this.btnRemoveTradePartner.Name = "btnRemoveTradePartner";
            this.btnRemoveTradePartner.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTradePartner.TabIndex = 16;
            this.btnRemoveTradePartner.Text = "Remove";
            this.btnRemoveTradePartner.UseVisualStyleBackColor = true;
            this.btnRemoveTradePartner.Click += new System.EventHandler(this.btnRemoveTradePartner_Click);
            // 
            // btnAddTradePartner
            // 
            this.btnAddTradePartner.Location = new System.Drawing.Point(6, 384);
            this.btnAddTradePartner.Name = "btnAddTradePartner";
            this.btnAddTradePartner.Size = new System.Drawing.Size(75, 23);
            this.btnAddTradePartner.TabIndex = 15;
            this.btnAddTradePartner.Text = "Add";
            this.btnAddTradePartner.UseVisualStyleBackColor = true;
            this.btnAddTradePartner.Click += new System.EventHandler(this.btnAddTradePartner_Click);
            // 
            // labelEditTradePartners
            // 
            this.labelEditTradePartners.AutoSize = true;
            this.labelEditTradePartners.Location = new System.Drawing.Point(13, 224);
            this.labelEditTradePartners.Name = "labelEditTradePartners";
            this.labelEditTradePartners.Size = new System.Drawing.Size(77, 13);
            this.labelEditTradePartners.TabIndex = 14;
            this.labelEditTradePartners.Text = "Trade Partners";
            // 
            // editTradePartnersListView
            // 
            this.editTradePartnersListView.FullRowSelect = true;
            this.editTradePartnersListView.GridLines = true;
            this.editTradePartnersListView.Location = new System.Drawing.Point(6, 240);
            this.editTradePartnersListView.Name = "editTradePartnersListView";
            this.editTradePartnersListView.Size = new System.Drawing.Size(456, 141);
            this.editTradePartnersListView.TabIndex = 13;
            this.editTradePartnersListView.UseCompatibleStateImageBehavior = false;
            this.editTradePartnersListView.View = System.Windows.Forms.View.Details;
            // 
            // tbValueHDIRanking
            // 
            this.tbValueHDIRanking.Location = new System.Drawing.Point(102, 184);
            this.tbValueHDIRanking.Name = "tbValueHDIRanking";
            this.tbValueHDIRanking.Size = new System.Drawing.Size(100, 20);
            this.tbValueHDIRanking.TabIndex = 9;
            // 
            // labelHDIRanking
            // 
            this.labelHDIRanking.AutoSize = true;
            this.labelHDIRanking.Location = new System.Drawing.Point(16, 187);
            this.labelHDIRanking.Name = "labelHDIRanking";
            this.labelHDIRanking.Size = new System.Drawing.Size(72, 13);
            this.labelHDIRanking.TabIndex = 8;
            this.labelHDIRanking.Text = "HDI Ranking:";
            // 
            // tbValueTradeBalance
            // 
            this.tbValueTradeBalance.Location = new System.Drawing.Point(102, 137);
            this.tbValueTradeBalance.Name = "tbValueTradeBalance";
            this.tbValueTradeBalance.Size = new System.Drawing.Size(100, 20);
            this.tbValueTradeBalance.TabIndex = 7;
            // 
            // labelTradeBalance
            // 
            this.labelTradeBalance.AutoSize = true;
            this.labelTradeBalance.Location = new System.Drawing.Point(16, 140);
            this.labelTradeBalance.Name = "labelTradeBalance";
            this.labelTradeBalance.Size = new System.Drawing.Size(80, 13);
            this.labelTradeBalance.TabIndex = 6;
            this.labelTradeBalance.Text = "Trade Balance:";
            this.labelTradeBalance.UseWaitCursor = true;
            // 
            // tbValueInflation
            // 
            this.tbValueInflation.Location = new System.Drawing.Point(102, 94);
            this.tbValueInflation.Name = "tbValueInflation";
            this.tbValueInflation.Size = new System.Drawing.Size(100, 20);
            this.tbValueInflation.TabIndex = 5;
            // 
            // labelInflation
            // 
            this.labelInflation.AutoSize = true;
            this.labelInflation.Location = new System.Drawing.Point(16, 97);
            this.labelInflation.Name = "labelInflation";
            this.labelInflation.Size = new System.Drawing.Size(47, 13);
            this.labelInflation.TabIndex = 4;
            this.labelInflation.Text = "Inflation:";
            // 
            // tbValueGDPGrowth
            // 
            this.tbValueGDPGrowth.Location = new System.Drawing.Point(102, 58);
            this.tbValueGDPGrowth.Name = "tbValueGDPGrowth";
            this.tbValueGDPGrowth.Size = new System.Drawing.Size(100, 20);
            this.tbValueGDPGrowth.TabIndex = 3;
            // 
            // labelGDPGrowth
            // 
            this.labelGDPGrowth.AutoSize = true;
            this.labelGDPGrowth.Location = new System.Drawing.Point(16, 61);
            this.labelGDPGrowth.Name = "labelGDPGrowth";
            this.labelGDPGrowth.Size = new System.Drawing.Size(70, 13);
            this.labelGDPGrowth.TabIndex = 2;
            this.labelGDPGrowth.Text = "GDP Growth:";
            // 
            // lableCountryName
            // 
            this.lableCountryName.AutoSize = true;
            this.lableCountryName.Location = new System.Drawing.Point(16, 28);
            this.lableCountryName.Name = "lableCountryName";
            this.lableCountryName.Size = new System.Drawing.Size(77, 13);
            this.lableCountryName.TabIndex = 0;
            this.lableCountryName.Text = "Country Name:";
            // 
            // countriesListView
            // 
            this.countriesListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.countriesListView.FullRowSelect = true;
            this.countriesListView.GridLines = true;
            this.countriesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.countriesListView.Location = new System.Drawing.Point(12, 19);
            this.countriesListView.Name = "countriesListView";
            this.countriesListView.Size = new System.Drawing.Size(462, 362);
            this.countriesListView.TabIndex = 2;
            this.countriesListView.UseCompatibleStateImageBehavior = false;
            this.countriesListView.View = System.Windows.Forms.View.Details;
            this.countriesListView.SelectedIndexChanged += new System.EventHandler(this.countriesListView1_SelectedIndexChanged);
            this.countriesListView.Click += new System.EventHandler(this.countriesListView1_Click);
            this.countriesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.countriesListView_MouseDoubleClick);
            // 
            // numberOfCountriesLabel
            // 
            this.numberOfCountriesLabel.AutoSize = true;
            this.numberOfCountriesLabel.Location = new System.Drawing.Point(10, 389);
            this.numberOfCountriesLabel.Name = "numberOfCountriesLabel";
            this.numberOfCountriesLabel.Size = new System.Drawing.Size(111, 13);
            this.numberOfCountriesLabel.TabIndex = 3;
            this.numberOfCountriesLabel.Text = "Number Of Countries: ";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(222, 389);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(78, 13);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = "Depth Of Tree:";
            // 
            // depthValue
            // 
            this.depthValue.AutoSize = true;
            this.depthValue.Location = new System.Drawing.Point(306, 389);
            this.depthValue.Name = "depthValue";
            this.depthValue.Size = new System.Drawing.Size(36, 13);
            this.depthValue.TabIndex = 5;
            this.depthValue.Text = "Depth";
            // 
            // numberOfCountriesValue
            // 
            this.numberOfCountriesValue.AutoSize = true;
            this.numberOfCountriesValue.Location = new System.Drawing.Point(127, 389);
            this.numberOfCountriesValue.Name = "numberOfCountriesValue";
            this.numberOfCountriesValue.Size = new System.Drawing.Size(74, 13);
            this.numberOfCountriesValue.TabIndex = 6;
            this.numberOfCountriesValue.Text = "noOfCountries";
            // 
            // countrySearchTB
            // 
            this.countrySearchTB.Location = new System.Drawing.Point(101, 421);
            this.countrySearchTB.Name = "countrySearchTB";
            this.countrySearchTB.Size = new System.Drawing.Size(100, 20);
            this.countrySearchTB.TabIndex = 7;
            this.countrySearchTB.TextChanged += new System.EventHandler(this.countrySearchTB_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(225, 421);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // keywordSearchLabel
            // 
            this.keywordSearchLabel.AutoSize = true;
            this.keywordSearchLabel.Location = new System.Drawing.Point(10, 424);
            this.keywordSearchLabel.Name = "keywordSearchLabel";
            this.keywordSearchLabel.Size = new System.Drawing.Size(85, 13);
            this.keywordSearchLabel.TabIndex = 10;
            this.keywordSearchLabel.Text = "Keyword Search";
            // 
            // allCountriesGroupBox
            // 
            this.allCountriesGroupBox.Controls.Add(this.countriesListView);
            this.allCountriesGroupBox.Controls.Add(this.keywordSearchLabel);
            this.allCountriesGroupBox.Controls.Add(this.numberOfCountriesLabel);
            this.allCountriesGroupBox.Controls.Add(this.removeButton);
            this.allCountriesGroupBox.Controls.Add(this.depthLabel);
            this.allCountriesGroupBox.Controls.Add(this.countrySearchTB);
            this.allCountriesGroupBox.Controls.Add(this.depthValue);
            this.allCountriesGroupBox.Controls.Add(this.numberOfCountriesValue);
            this.allCountriesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.allCountriesGroupBox.Name = "allCountriesGroupBox";
            this.allCountriesGroupBox.Size = new System.Drawing.Size(487, 453);
            this.allCountriesGroupBox.TabIndex = 12;
            this.allCountriesGroupBox.TabStop = false;
            this.allCountriesGroupBox.Text = "All Countries";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "CSV";
            this.openFileDialog1.FileName = "countries";
            this.openFileDialog1.Title = "Select CSV";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CountryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 490);
            this.Controls.Add(this.allCountriesGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.countryInformationGroupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CountryInfoForm";
            this.Text = "Country Information Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.countryInformationGroupBox1.ResumeLayout(false);
            this.countryInformationGroupBox1.PerformLayout();
            this.allCountriesGroupBox.ResumeLayout(false);
            this.allCountriesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox countryInformationGroupBox1;
        private System.Windows.Forms.ListView countriesListView;
        private System.Windows.Forms.Label numberOfCountriesLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label depthValue;
        private System.Windows.Forms.Label numberOfCountriesValue;
        private System.Windows.Forms.TextBox countrySearchTB;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label keywordSearchLabel;
        private System.Windows.Forms.GroupBox allCountriesGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelEditTradePartners;
        private System.Windows.Forms.ListView editTradePartnersListView;
        private System.Windows.Forms.TextBox tbValueHDIRanking;
        private System.Windows.Forms.Label labelHDIRanking;
        private System.Windows.Forms.TextBox tbValueTradeBalance;
        private System.Windows.Forms.Label labelTradeBalance;
        private System.Windows.Forms.TextBox tbValueInflation;
        private System.Windows.Forms.Label labelInflation;
        private System.Windows.Forms.TextBox tbValueGDPGrowth;
        private System.Windows.Forms.Label labelGDPGrowth;
        private System.Windows.Forms.Label lableCountryName;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Button btnRemoveTradePartner;
        private System.Windows.Forms.Button btnAddTradePartner;
        private System.Windows.Forms.TextBox valueCountryName;
    }
}

