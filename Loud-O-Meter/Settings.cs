using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loud_O_Meter
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Restart();
        }

        private void bt_color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.bgColor = colorDialog.Color;
                Properties.Settings.Default.Save();

                pb_color.BackColor = Properties.Settings.Default.bgColor;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            pb_color.BackColor = Properties.Settings.Default.bgColor;
        }
    }
}
