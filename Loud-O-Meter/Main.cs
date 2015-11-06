using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio;
using NAudio.CoreAudioApi;

namespace Loud_O_Meter
{
    public partial class Main : Form
    {
        private int warnVol = Properties.Settings.Default.warnVol;
        private int timerInterval = Properties.Settings.Default.Interval;

        public Main()
        {
            InitializeComponent();
        }

        private void t_volume_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator device = new MMDeviceEnumerator();
            MMDevice mic = device.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
            int vol = (int)(mic.AudioMeterInformation.MasterPeakValue * 100);
            pb_volume.Value = vol;

            l_volume.Text = vol + "%";

            if (vol >= warnVol && warnVol != 0)
            {
                SystemSounds.Beep.Play();
                this.BackColor = Properties.Settings.Default.bgColor;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void nud_timer_ValueChanged(object sender, EventArgs e)
        {
            timerInterval = (int)nud_timer.Value;
            t_volume.Interval = timerInterval;

            Properties.Settings.Default.Interval = t_volume.Interval;
            Properties.Settings.Default.Save();
        }

        private void tb_volume_Scroll(object sender, EventArgs e)
        {
            warnVol = tb_volume.Value;
            nud_volume.Value = warnVol;

            Properties.Settings.Default.warnVol = warnVol;
            Properties.Settings.Default.Save();
        }

        private void nud_volume_ValueChanged(object sender, EventArgs e)
        {
            warnVol = (int)nud_volume.Value;
            tb_volume.Value = warnVol;

            Properties.Settings.Default.warnVol = warnVol;
            Properties.Settings.Default.Save();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            nud_volume.Value = warnVol;
            tb_volume.Value = warnVol;

            nud_timer.Value = timerInterval;
        }
    }
}
