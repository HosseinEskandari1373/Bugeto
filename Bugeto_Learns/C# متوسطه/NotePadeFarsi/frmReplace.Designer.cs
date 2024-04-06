namespace NotePadeFarsi
{
    partial class frmReplace
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
            this.grpTypeSearch = new System.Windows.Forms.GroupBox();
            this.rdbTypeSearchContains = new System.Windows.Forms.RadioButton();
            this.rdbTypeSearchWord = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearchReplace = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpJahatSearch = new System.Windows.Forms.GroupBox();
            this.rdbJahatSearchDown = new System.Windows.Forms.RadioButton();
            this.rdbJahatSearchTop = new System.Windows.Forms.RadioButton();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.grpTypeSearch.SuspendLayout();
            this.grpJahatSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTypeSearch
            // 
            this.grpTypeSearch.Controls.Add(this.rdbTypeSearchContains);
            this.grpTypeSearch.Controls.Add(this.rdbTypeSearchWord);
            this.grpTypeSearch.Location = new System.Drawing.Point(12, 82);
            this.grpTypeSearch.Name = "grpTypeSearch";
            this.grpTypeSearch.Size = new System.Drawing.Size(200, 100);
            this.grpTypeSearch.TabIndex = 10;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(388, 16);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearchReplace
            // 
            this.txtSearchReplace.Location = new System.Drawing.Point(70, 30);
            this.txtSearchReplace.Name = "txtSearchReplace";
            this.txtSearchReplace.Size = new System.Drawing.Size(312, 20);
            this.txtSearchReplace.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(40, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "جستجو";
            // 
            // grpJahatSearch
            // 
            this.grpJahatSearch.Controls.Add(this.rdbJahatSearchDown);
            this.grpJahatSearch.Controls.Add(this.rdbJahatSearchTop);
            this.grpJahatSearch.Location = new System.Drawing.Point(211, 82);
            this.grpJahatSearch.Name = "grpJahatSearch";
            this.grpJahatSearch.Size = new System.Drawing.Size(170, 100);
            this.grpJahatSearch.TabIndex = 11;
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
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(70, 56);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(312, 20);
            this.txtReplace.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "جایگزینی";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(388, 45);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "جایگزین";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(388, 74);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 15;
            this.btnReplaceAll.Text = "جایگزین همه";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // frmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 191);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTypeSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearchReplace);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpJahatSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReplace";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جایگزینی متن";
            this.Load += new System.EventHandler(this.frmReplace_Load);
            this.grpTypeSearch.ResumeLayout(false);
            this.grpTypeSearch.PerformLayout();
            this.grpJahatSearch.ResumeLayout(false);
            this.grpJahatSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTypeSearch;
        private System.Windows.Forms.RadioButton rdbTypeSearchContains;
        private System.Windows.Forms.RadioButton rdbTypeSearchWord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearchReplace;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpJahatSearch;
        private System.Windows.Forms.RadioButton rdbJahatSearchDown;
        private System.Windows.Forms.RadioButton rdbJahatSearchTop;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}