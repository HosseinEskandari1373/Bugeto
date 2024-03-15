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
        Image file;
        public ComboForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Combo();

            RadioGender();
            RadioMeliat();
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

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            SelectPic();
        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            SavePic();
        }

        /*متدها*/
        private void RadioMeliat()
        {
            if (rdbIrani.Checked == true)
            {
                MessageBox.Show("ملیت ایرانی", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbKharegi.Checked)
            {
                MessageBox.Show("ملیت خارجی", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RadioGender()
        {
            if (rdbMale.Checked == true)
            {
                MessageBox.Show("جنسیت مرد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbFemale.Checked)
            {
                MessageBox.Show("جنسیت زن", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Combo()
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

            //if (dialog == DialogResult.Yes)
            //{
            //    Close();
            //}
        }
        private void SelectPic()
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(openFile.FileName);
            }

            picBox.Image = file;
        }
        private void SavePic()
        {
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            { 
                file.Save(saveFile.FileName);
            }
        }
    }
}
