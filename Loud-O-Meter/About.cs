using System.Diagnostics;
using System.Windows.Forms;

namespace Loud_O_Meter
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ll_homepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(toolTip.GetToolTip(ll_homepage));
            e.Link.Visited = true;
        }

        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(toolTip.GetToolTip(ll_github));
            e.Link.Visited = true;
        }

        private void ll_project_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(toolTip.GetToolTip(ll_project));
            e.Link.Visited = true;
        }
    }
}