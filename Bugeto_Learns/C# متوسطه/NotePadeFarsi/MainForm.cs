using System.IO;
using System.Windows.Forms;

namespace NotePadeFarsi
{
    public partial class MainForm : Form
    {
        bool manageRichText = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemNewFile_Click(object sender, System.EventArgs e)
        {
            if (manageRichText == false)
            {
                richText.Text = "";
            }
            else if (manageRichText == true)
            {
                DialogResult dialogResult = MessageBox.Show("سند را هنوز ذخیره نکرده اید. آیا مایل به ذخیره آن هستید؟",
                                                        "ذخیره سند",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult saveDialogs = saveDialog.ShowDialog();
                    if (saveDialogs == DialogResult.OK)
                    {
                        StreamWriter swNewFile = new StreamWriter(saveDialog.FileName);
                        swNewFile.Write(richText.Text);
                    }
                    else
                    {
                        richText.Text = "";
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    richText.Text = "";
                }
            }

            manageRichText = false;
        }

        private void TxtChange(object sender, System.EventArgs e)
        {
            manageRichText = true;
        }
    }
}
