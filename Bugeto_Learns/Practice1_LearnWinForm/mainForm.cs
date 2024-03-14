namespace Practice1_LearnWinForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //EditName();
            FullName();
        }

        private void Calculate()
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            int res = num1 + num2;

            lblSum.Text = $"n1: {num1} + n2: {num2} = {res}";
        }

        private void FullName()
        {
            string name = txtName.Text;
            string lblLastName = txtLastName.Text;

            lblFullName.Text = name + " " + lblLastName;
        }

        private void EditName()
        {
            this.Text = "تغییر نام فرم";
            btnOk.Text = "تغییر نام دکمه";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
