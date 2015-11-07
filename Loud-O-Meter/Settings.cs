using System;
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
            lb_path.Text = Properties.Settings.Default.customTone;
            toolTip.SetToolTip(lb_path, Properties.Settings.Default.customTone);

            if (Properties.Settings.Default.warnTone != 5)
            {
                cb_tone.SelectedIndex = Properties.Settings.Default.warnTone;
                cb_custom.Checked = false;
            }
            else
            {
                cb_custom.Checked = true;

                cb_tone.Enabled = !cb_custom.Checked;
                lb_path.Enabled = cb_custom.Checked;
                bt_path.Enabled = cb_custom.Checked;
            }
        }

        private void cb_tone_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.warnTone = cb_tone.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void bt_path_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();

            dlg.CheckFileExists = true;

            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lb_path.Text = dlg.FileName;
                toolTip.SetToolTip(lb_path, dlg.FileName);
                Properties.Settings.Default.customTone = dlg.FileName;
                Properties.Settings.Default.warnTone = 5;
                Properties.Settings.Default.Save();
            }
        }

        private void cb_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_custom.Checked && lb_path.Text != "-")
            {
                Properties.Settings.Default.warnTone = 5;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.warnTone = cb_tone.SelectedIndex;
                Properties.Settings.Default.Save();
            }

            cb_tone.Enabled = !cb_custom.Checked;
            lb_path.Enabled = cb_custom.Checked;
            bt_path.Enabled = cb_custom.Checked;
        }
    }
}