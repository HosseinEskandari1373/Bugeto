using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NotePadeFarsi
{
    public partial class MainForm : Form
    {
        bool manageRichText = false;
        string pathSave = "";
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
                        using (StreamWriter swNewFile = new StreamWriter(saveDialog.FileName))
                        {
                            swNewFile.Write(richText.Text);
                        }
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

        private void mnuOpenFile_Click(object sender, System.EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string text = "";
                using (StreamReader srOpenFile = new StreamReader(openDialog.FileName))
                {
                    text = srOpenFile.ReadToEnd();
                }

                richText.Text = text;
            }
        }

        private void mnuOpenNewProject_Click(object sender, System.EventArgs e)
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            Process.Start(processName);
        }

        private void mnuSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(pathSave))
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                    {
                        sw.Write(richText.Text);
                        pathSave = saveDialog.FileName;
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(pathSave))
                {
                    sw.Write(richText.Text);
                }
            }
        }

        private void mnuSaveAs_Click(object sender, System.EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                {
                    sw.Write(richText.Text);
                    pathSave = saveDialog.FileName;
                }
            }
        }
    }
}
