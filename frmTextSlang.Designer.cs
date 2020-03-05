namespace TextSlangSearch
{
    partial class frmTextSlang
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
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlShowInformation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAbbreviation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.radAbbreviation = new System.Windows.Forms.RadioButton();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            this.radMeaning = new System.Windows.Forms.RadioButton();
            this.tsmPhraseList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlShowInformation.SuspendLayout();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.aboutToolStripMenuItem,
            this.tsmPhraseList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "File";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(180, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlShowInformation
            // 
            this.pnlShowInformation.Controls.Add(this.lblMeaning);
            this.pnlShowInformation.Controls.Add(this.lblAbbreviation);
            this.pnlShowInformation.Controls.Add(this.label3);
            this.pnlShowInformation.Controls.Add(this.label2);
            this.pnlShowInformation.Location = new System.Drawing.Point(12, 121);
            this.pnlShowInformation.Name = "pnlShowInformation";
            this.pnlShowInformation.Size = new System.Drawing.Size(437, 101);
            this.pnlShowInformation.TabIndex = 4;
            this.pnlShowInformation.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abbreviation:";
            // 
            // lblAbbreviation
            // 
            this.lblAbbreviation.AutoSize = true;
            this.lblAbbreviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbbreviation.Location = new System.Drawing.Point(111, 16);
            this.lblAbbreviation.Name = "lblAbbreviation";
            this.lblAbbreviation.Size = new System.Drawing.Size(176, 17);
            this.lblAbbreviation.TabIndex = 1;
            this.lblAbbreviation.Text = "Abbreviation appears here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meaning:";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(111, 62);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(151, 17);
            this.lblMeaning.TabIndex = 1;
            this.lblMeaning.Text = "Meaning appears here";
            // 
            // radAbbreviation
            // 
            this.radAbbreviation.AutoSize = true;
            this.radAbbreviation.Checked = true;
            this.radAbbreviation.Location = new System.Drawing.Point(58, 19);
            this.radAbbreviation.Name = "radAbbreviation";
            this.radAbbreviation.Size = new System.Drawing.Size(84, 17);
            this.radAbbreviation.TabIndex = 6;
            this.radAbbreviation.TabStop = true;
            this.radAbbreviation.Text = "Abbreviation";
            this.radAbbreviation.UseVisualStyleBackColor = true;
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.radMeaning);
            this.grpSearchBy.Controls.Add(this.radAbbreviation);
            this.grpSearchBy.Location = new System.Drawing.Point(78, 61);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Size = new System.Drawing.Size(305, 54);
            this.grpSearchBy.TabIndex = 7;
            this.grpSearchBy.TabStop = false;
            this.grpSearchBy.Text = "Search By:";
            // 
            // radMeaning
            // 
            this.radMeaning.AutoSize = true;
            this.radMeaning.Location = new System.Drawing.Point(180, 19);
            this.radMeaning.Name = "radMeaning";
            this.radMeaning.Size = new System.Drawing.Size(66, 17);
            this.radMeaning.TabIndex = 7;
            this.radMeaning.Text = "Meaning";
            this.radMeaning.UseVisualStyleBackColor = true;
            // 
            // tsmPhraseList
            // 
            this.tsmPhraseList.Name = "tsmPhraseList";
            this.tsmPhraseList.Size = new System.Drawing.Size(75, 20);
            this.tsmPhraseList.Text = "Phrase List";
            this.tsmPhraseList.Click += new System.EventHandler(this.tsmPhraseList_Click);
            // 
            // frmTextSlang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 234);
            this.Controls.Add(this.grpSearchBy);
            this.Controls.Add(this.pnlShowInformation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTextSlang";
            this.Text = "Text Slang Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlShowInformation.ResumeLayout(false);
            this.pnlShowInformation.PerformLayout();
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlShowInformation;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblAbbreviation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radAbbreviation;
        private System.Windows.Forms.GroupBox grpSearchBy;
        private System.Windows.Forms.RadioButton radMeaning;
        private System.Windows.Forms.ToolStripMenuItem tsmPhraseList;
    }
}

