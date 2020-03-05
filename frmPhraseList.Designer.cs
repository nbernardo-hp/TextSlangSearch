namespace TextSlangSearch
{
    partial class frmPhraseList
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
            this.dgvPhraseList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhraseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhraseList
            // 
            this.dgvPhraseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhraseList.Location = new System.Drawing.Point(13, 13);
            this.dgvPhraseList.Name = "dgvPhraseList";
            this.dgvPhraseList.Size = new System.Drawing.Size(344, 425);
            this.dgvPhraseList.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(147, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPhraseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPhraseList);
            this.Name = "frmPhraseList";
            this.Text = "Phrase List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhraseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhraseList;
        private System.Windows.Forms.Button btnClose;
    }
}