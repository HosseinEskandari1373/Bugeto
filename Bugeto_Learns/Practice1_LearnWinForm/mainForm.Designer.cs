namespace Practice1_LearnWinForm
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            button1 = new Button();
            lblName = new Label();
            lblLastName = new Label();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblFullName = new Label();
            lblSum = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(37, 161);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "ذخیره";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(27, 93);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(257, 47);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(257, 93);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(270, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "جمع";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(145, 50);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.Yes;
            lblName.Size = new Size(24, 15);
            lblName.TabIndex = 6;
            lblName.Text = "نام:";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(145, 96);
            lblLastName.Name = "lblLastName";
            lblLastName.RightToLeft = RightToLeft.Yes;
            lblLastName.Size = new Size(72, 15);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "نام خانوادگی:";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(375, 50);
            lblNum1.Name = "lblNum1";
            lblNum1.RightToLeft = RightToLeft.Yes;
            lblNum1.Size = new Size(49, 15);
            lblNum1.TabIndex = 8;
            lblNum1.Text = "عدد اول:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(375, 96);
            lblNum2.Name = "lblNum2";
            lblNum2.RightToLeft = RightToLeft.Yes;
            lblNum2.Size = new Size(51, 15);
            lblNum2.TabIndex = 9;
            lblNum2.Text = "عدد دوم:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(61, 133);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(22, 15);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "---";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(294, 133);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(22, 15);
            lblSum.TabIndex = 11;
            lblSum.Text = "---";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 368);
            Controls.Add(lblSum);
            Controls.Add(lblFullName);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(button1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnOk);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نرم افزار من";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button button1;
        private Label lblName;
        private Label lblLastName;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblFullName;
        private Label lblSum;
    }
}
