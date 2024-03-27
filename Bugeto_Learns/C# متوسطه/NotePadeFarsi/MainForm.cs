using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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

            richText.Font = fontDialog.Font;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void mnuFont_Click(object sender, System.EventArgs e)
        {
            fontDialog.ShowDialog();
            richText.Font = fontDialog.Font;
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            if (manageRichText == true)
            {
                DialogResult dialogRes = MessageBox.Show("سند را هنوز ذخیره نکرده اید. آیا مایل به ذخیره آن هستید؟",
                                                         "ذخیره سند",
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Question,
                                                         MessageBoxDefaultButton.Button1);

                if (dialogRes == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                    {
                        sw.Write(richText.Text);
                    }
                }
            }
        }

        private void mnuStatus_Click(object sender, System.EventArgs e)
        {
            if (statusBar.Visible == true)
            {
                statusBar.Visible = false;
                mnuStatus.Checked = false;
            }
            else
            {
                statusBar.Visible = true;
                mnuStatus.Checked = false;
            }
        }

        private void mnuTools_Click(object sender, System.EventArgs e)
        {
            toolBar.Visible = !toolBar.Visible;
            mnuTools.Checked = !mnuTools.Checked;
        }

        private void mnuCopy_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
            }
            else
            {
                Clipboard.SetText(richText.Text);
            }
        }

        private void mnuPast_Click(object sender, System.EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richText.Text += Clipboard.GetText(TextDataFormat.UnicodeText).ToString();
            }
        }

        private void mnuDelete_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                richText.SelectedText = richText.SelectedText.Replace(richText.SelectedText, "");
            }
            else
            {
                richText.Text = richText.Text.Replace(richText.Text, "");
            }
        }

        private void mnuCut_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
                richText.SelectedText = richText.SelectedText.Replace(richText.SelectedText, "");
            }
            else
            {
                Clipboard.SetText(richText.Text);
                richText.Text = richText.Text.Replace(richText.Text, "");
            }
        }

        private void mnuSelectAll_Click(object sender, System.EventArgs e)
        {
            richText.SelectAll();
        }

        private void mnuInsertDate_Click(object sender, System.EventArgs e)
        {
            richText.Text += $"{DateTime.Now.ToShortDateString()}  {DateTime.Now.ToShortTimeString()}";
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = richText.Text;
            int chars;
            int lines;

            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat strFormat = new StringFormat();
            strFormat.Trimming = StringTrimming.Word;
            RectangleF myRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            SizeF sz = new SizeF(e.MarginBounds.Width, e.MarginBounds.Height - fontDialog.Font.GetHeight(e.Graphics));
            e.Graphics.MeasureString(str, fontDialog.Font, sz, strFormat, out chars, out lines);
            string printStr = str.Substring(0, chars);
            e.Graphics.DrawString(printStr, fontDialog.Font, brush, myRect, strFormat);
            if (str.Length > chars)
            {
                str = str.Substring(chars);
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(this);
            search.ShowDialog();
        }

        private void mnuReplace_Click(object sender, EventArgs e)
        {
            frmReplace replace = new frmReplace(this);
            replace.ShowDialog();
        }
    }
}
