using System.Drawing;
using System.Windows.Forms;

namespace NotePadeFarsi
{
    public partial class frmSearch : Form
    {
        MainForm mainForm;
        public frmSearch(MainForm frmMain)
        {
            InitializeComponent();
            this.mainForm = frmMain;
        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            string searchKey = txtBoxSearch.Text;
            int startIndex = 0;

            while (startIndex < mainForm.richText.TextLength)
            {
                // Start Index
                int wordStartIndex = mainForm.richText.Find(searchKey, startIndex, RichTextBoxFinds.None);

                if (wordStartIndex != -1)
                {
                    mainForm.richText.SelectionStart = wordStartIndex;
                    mainForm.richText.SelectionLength = searchKey.Length;
                    mainForm.richText.SelectionBackColor = Color.Yellow;

                    startIndex = wordStartIndex + searchKey.Length;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
