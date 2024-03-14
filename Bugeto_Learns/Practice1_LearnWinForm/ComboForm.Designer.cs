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
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(196, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(171, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 2;
            // 
            // chkBime
            // 
            chkBime.AutoSize = true;
            chkBime.Location = new Point(171, 117);
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
            comboCity.Location = new Point(171, 159);
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(121, 23);
            comboCity.TabIndex = 4;
            // 
            // lstMadrak
            // 
            lstMadrak.FormattingEnabled = true;
            lstMadrak.ItemHeight = 15;
            lstMadrak.Items.AddRange(new object[] { "سیکل", "دیپلم", "فوق دیپلم", "لیسانس" });
            lstMadrak.Location = new Point(171, 199);
            lstMadrak.Name = "lstMadrak";
            lstMadrak.Size = new Size(120, 94);
            lstMadrak.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 15);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 6;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 58);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 161);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "شهر";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 234);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "مدرک";
            // 
            // ComboForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 345);
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
    }
}