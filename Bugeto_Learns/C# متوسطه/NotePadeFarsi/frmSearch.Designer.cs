namespace NotePadeFarsi
{
    partial class frmSearch
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTypeSearch = new System.Windows.Forms.GroupBox();
            this.rdbTypeSearchContains = new System.Windows.Forms.RadioButton();
            this.rdbTypeSearchWord = new System.Windows.Forms.RadioButton();
            this.grpJahatSearch = new System.Windows.Forms.GroupBox();
            this.rdbJahatSearchDown = new System.Windows.Forms.RadioButton();
            this.rdbJahatSearchTop = new System.Windows.Forms.RadioButton();
            this.grpTypeSearch.SuspendLayout();
            this.grpJahatSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(40, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "جستجو";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(53, 26);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(329, 20);
            this.txtBoxSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(388, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpTypeSearch
            // 
            this.grpTypeSearch.Controls.Add(this.rdbTypeSearchContains);
            this.grpTypeSearch.Controls.Add(this.rdbTypeSearchWord);
            this.grpTypeSearch.Location = new System.Drawing.Point(12, 59);
            this.grpTypeSearch.Name = "grpTypeSearch";
            this.grpTypeSearch.Size = new System.Drawing.Size(200, 100);
            this.grpTypeSearch.TabIndex = 4;
            this.grpTypeSearch.TabStop = false;
            this.grpTypeSearch.Text = "نحوه جستجو";
            // 
            // rdbTypeSearchContains
            // 
            this.rdbTypeSearchContains.AutoSize = true;
            this.rdbTypeSearchContains.Checked = true;
            this.rdbTypeSearchContains.Location = new System.Drawing.Point(79, 60);
            this.rdbTypeSearchContains.Name = "rdbTypeSearchContains";
            this.rdbTypeSearchContains.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbTypeSearchContains.Size = new System.Drawing.Size(115, 17);
            this.rdbTypeSearchContains.TabIndex = 1;
            this.rdbTypeSearchContains.TabStop = true;
            this.rdbTypeSearchContains.Text = "شامل این کلمه باشد";
            this.rdbTypeSearchContains.UseVisualStyleBackColor = true;
            // 
            // rdbTypeSearchWord
            // 
            this.rdbTypeSearchWord.AutoSize = true;
            this.rdbTypeSearchWord.Location = new System.Drawing.Point(96, 37);
            this.rdbTypeSearchWord.Name = "rdbTypeSearchWord";
            this.rdbTypeSearchWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbTypeSearchWord.Size = new System.Drawing.Size(98, 17);
            this.rdbTypeSearchWord.TabIndex = 0;
            this.rdbTypeSearchWord.Text = "دقیقا همین کلمه";
            this.rdbTypeSearchWord.UseVisualStyleBackColor = true;
            // 
            // grpJahatSearch
            // 
            this.grpJahatSearch.Controls.Add(this.rdbJahatSearchDown);
            this.grpJahatSearch.Controls.Add(this.rdbJahatSearchTop);
            this.grpJahatSearch.Location = new System.Drawing.Point(212, 59);
            this.grpJahatSearch.Name = "grpJahatSearch";
            this.grpJahatSearch.Size = new System.Drawing.Size(170, 100);
            this.grpJahatSearch.TabIndex = 5;
            this.grpJahatSearch.TabStop = false;
            this.grpJahatSearch.Text = "جهت جستجو";
            // 
            // rdbJahatSearchDown
            // 
            this.rdbJahatSearchDown.AutoSize = true;
            this.rdbJahatSearchDown.Checked = true;
            this.rdbJahatSearchDown.Location = new System.Drawing.Point(23, 47);
            this.rdbJahatSearchDown.Name = "rdbJahatSearchDown";
            this.rdbJahatSearchDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbJahatSearchDown.Size = new System.Drawing.Size(60, 17);
            this.rdbJahatSearchDown.TabIndex = 1;
            this.rdbJahatSearchDown.TabStop = true;
            this.rdbJahatSearchDown.Text = "به پایین";
            this.rdbJahatSearchDown.UseVisualStyleBackColor = true;
            // 
            // rdbJahatSearchTop
            // 
            this.rdbJahatSearchTop.AutoSize = true;
            this.rdbJahatSearchTop.Location = new System.Drawing.Point(104, 47);
            this.rdbJahatSearchTop.Name = "rdbJahatSearchTop";
            this.rdbJahatSearchTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbJahatSearchTop.Size = new System.Drawing.Size(51, 17);
            this.rdbJahatSearchTop.TabIndex = 0;
            this.rdbJahatSearchTop.Text = "به بالا";
            this.rdbJahatSearchTop.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 171);
            this.Controls.Add(this.grpJahatSearch);
            this.Controls.Add(this.grpTypeSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.grpTypeSearch.ResumeLayout(false);
            this.grpTypeSearch.PerformLayout();
            this.grpJahatSearch.ResumeLayout(false);
            this.grpJahatSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpTypeSearch;
        private System.Windows.Forms.GroupBox grpJahatSearch;
        private System.Windows.Forms.RadioButton rdbTypeSearchContains;
        private System.Windows.Forms.RadioButton rdbTypeSearchWord;
        private System.Windows.Forms.RadioButton rdbJahatSearchDown;
        private System.Windows.Forms.RadioButton rdbJahatSearchTop;
    }
}