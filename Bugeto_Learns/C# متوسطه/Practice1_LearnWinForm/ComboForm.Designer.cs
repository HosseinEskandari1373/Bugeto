namespace Practice1_LearnWinForm
{
    partial class ComboForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboForm));
            btnSave = new Button();
            txtName = new TextBox();
            txtLastName = new TextBox();
            chkBime = new CheckBox();
            comboCity = new ComboBox();
            lstMadrak = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            rdbGender = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            rdbMeliat = new GroupBox();
            rdbKharegi = new RadioButton();
            rdbIrani = new RadioButton();
            picBox = new PictureBox();
            btnSelectPic = new Button();
            btnSavePic = new Button();
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            rdbGender.SuspendLayout();
            rdbMeliat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 443);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(283, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(43, 12);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 2;
            // 
            // chkBime
            // 
            chkBime.AutoSize = true;
            chkBime.Location = new Point(387, 60);
            chkBime.Name = "chkBime";
            chkBime.Size = new Size(79, 19);
            chkBime.TabIndex = 3;
            chkBime.Text = "سابقه بیمه";
            chkBime.UseVisualStyleBackColor = true;
            // 
            // comboCity
            // 
            comboCity.FormattingEnabled = true;
            comboCity.Items.AddRange(new object[] { "اصفهان", "تهران", "همدان", "یزد", "شیراز", "کرج", "فارس", "سیستان" });
            comboCity.Location = new Point(283, 105);
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(121, 23);
            comboCity.TabIndex = 4;
            // 
            // lstMadrak
            // 
            lstMadrak.FormattingEnabled = true;
            lstMadrak.ItemHeight = 15;
            lstMadrak.Items.AddRange(new object[] { "سیکل", "دیپلم", "فوق دیپلم", "لیسانس" });
            lstMadrak.Location = new Point(43, 73);
            lstMadrak.Name = "lstMadrak";
            lstMadrak.Size = new Size(121, 94);
            lstMadrak.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(445, 15);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 6;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 15);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 108);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "شهر";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 108);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "مدرک";
            // 
            // rdbGender
            // 
            rdbGender.Controls.Add(rdbFemale);
            rdbGender.Controls.Add(rdbMale);
            rdbGender.Location = new Point(283, 181);
            rdbGender.Name = "rdbGender";
            rdbGender.Size = new Size(182, 73);
            rdbGender.TabIndex = 11;
            rdbGender.TabStop = false;
            rdbGender.Text = "جنسیت";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(6, 47);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(38, 19);
            rdbFemale.TabIndex = 1;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "زن";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(6, 22);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(42, 19);
            rdbMale.TabIndex = 0;
            rdbMale.TabStop = true;
            rdbMale.Text = "مرد";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbMeliat
            // 
            rdbMeliat.Controls.Add(rdbKharegi);
            rdbMeliat.Controls.Add(rdbIrani);
            rdbMeliat.Location = new Point(43, 181);
            rdbMeliat.Name = "rdbMeliat";
            rdbMeliat.Size = new Size(182, 73);
            rdbMeliat.TabIndex = 12;
            rdbMeliat.TabStop = false;
            rdbMeliat.Text = "ملیت";
            // 
            // rdbKharegi
            // 
            rdbKharegi.AutoSize = true;
            rdbKharegi.Location = new Point(6, 47);
            rdbKharegi.Name = "rdbKharegi";
            rdbKharegi.Size = new Size(57, 19);
            rdbKharegi.TabIndex = 2;
            rdbKharegi.TabStop = true;
            rdbKharegi.Text = "خارجی";
            rdbKharegi.UseVisualStyleBackColor = true;
            // 
            // rdbIrani
            // 
            rdbIrani.AutoSize = true;
            rdbIrani.Location = new Point(6, 22);
            rdbIrani.Name = "rdbIrani";
            rdbIrani.Size = new Size(53, 19);
            rdbIrani.TabIndex = 1;
            rdbIrani.TabStop = true;
            rdbIrani.Text = "ایرانی";
            rdbIrani.UseVisualStyleBackColor = true;
            // 
            // picBox
            // 
            picBox.ErrorImage = (Image)resources.GetObject("picBox.ErrorImage");
            picBox.Image = Properties.Resources._3135715;
            picBox.InitialImage = Properties.Resources._3135715;
            picBox.Location = new Point(49, 286);
            picBox.Name = "picBox";
            picBox.Size = new Size(130, 116);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 13;
            picBox.TabStop = false;
            // 
            // btnSelectPic
            // 
            btnSelectPic.Location = new Point(206, 309);
            btnSelectPic.Name = "btnSelectPic";
            btnSelectPic.Size = new Size(101, 23);
            btnSelectPic.TabIndex = 14;
            btnSelectPic.Text = "انتخاب تصویر";
            btnSelectPic.UseVisualStyleBackColor = true;
            btnSelectPic.Click += btnSelectPic_Click;
            // 
            // btnSavePic
            // 
            btnSavePic.Location = new Point(206, 363);
            btnSavePic.Name = "btnSavePic";
            btnSavePic.Size = new Size(101, 23);
            btnSavePic.TabIndex = 15;
            btnSavePic.Text = "ذخیره تصویر";
            btnSavePic.UseVisualStyleBackColor = true;
            btnSavePic.Click += btnSavePic_Click;
            // 
            // openFile
            // 
            openFile.FileName = "openFile";
            // 
            // saveFile
            // 
            saveFile.FileName = "saveFile";
            // 
            // ComboForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 478);
            Controls.Add(btnSavePic);
            Controls.Add(btnSelectPic);
            Controls.Add(picBox);
            Controls.Add(rdbMeliat);
            Controls.Add(rdbGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstMadrak);
            Controls.Add(comboCity);
            Controls.Add(chkBime);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Name = "ComboForm";
            Text = "ComboForm";
            Load += loadFrm;
            rdbGender.ResumeLayout(false);
            rdbGender.PerformLayout();
            rdbMeliat.ResumeLayout(false);
            rdbMeliat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private TextBox txtLastName;
        private CheckBox chkBime;
        private ComboBox comboCity;
        private ListBox lstMadrak;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private GroupBox rdbGender;
        private GroupBox rdbMeliat;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private RadioButton rdbKharegi;
        private RadioButton rdbIrani;
        private PictureBox picBox;
        private Button btnSelectPic;
        private Button btnSavePic;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
    }
}