using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_LearnWinForm
{
    public partial class ComboForm : Form
    {
        public ComboForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            message += name + " " + lastName + Environment.NewLine;

            string bime = chkBime.Checked.ToString();
            message += $":سابقه بیمه {bime}" + Environment.NewLine;

            string city = comboCity.SelectedItem.ToString();
            message += $"شهر: {city}" + Environment.NewLine;

            string madrak = lstMadrak.SelectedItem.ToString();
            message += $"مدرک: {madrak}" + Environment.NewLine;

            DialogResult dialog = MessageBox.Show(message, "اطلاع", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void loadFrm(object sender, EventArgs e)
        {
            comboCity.Items.Add("تبریز");
            comboCity.Items.Add("کیش");
            comboCity.Items.Add("قشم");
            comboCity.Items.Add("بندرعباس");

            lstMadrak.Items.Add("فوق لیسانس");
            lstMadrak.Items.Add("دکترا");
        }
    }
}
