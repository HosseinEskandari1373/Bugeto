using System.Windows.Forms;

namespace NotePadeFarsi
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void LinkAbout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://bugeto.net/");
        }
    }
}
