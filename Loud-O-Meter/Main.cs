using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace Loud_O_Meter
{
    public partial class Main : Form
    {
        private bool isActiv;
        private int timerInterval = Properties.Settings.Default.Interval;
        private int warnVol = Properties.Settings.Default.warnVol;

        public Main()
        {
            InitializeComponent();
        }

        private void t_volume_Tick(object sender, EventArgs e)
        {
            var device = new MMDeviceEnumerator();
            var mic = device.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);
            var vol = (int) (mic.AudioMeterInformation.MasterPeakValue*100);

            pb_volume.Value = vol;
            l_volume.Text = vol + "%";

            if (vol >= warnVol && warnVol != 0 && !isActiv)
            {
                switch (Properties.Settings.Default.warnTone)
                {
                    case 0:
                        SystemSounds.Asterisk.Play();
                        break;
                    case 1:
                        SystemSounds.Beep.Play();
                        break;
                    case 2:
                        SystemSounds.Exclamation.Play();
                        break;
                    case 3:
                        SystemSounds.Hand.Play();
                        break;
                    case 4:
                        SystemSounds.Question.Play();
                        break;
                    case 5:
                        var player = new SoundPlayer(Properties.Settings.Default.customTone);
                        player.Play();
                        break;
                }

                BackColor = Properties.Settings.Default.bgColor;
                isActiv = true;
            }
            else if (vol < warnVol)
            {
                BackColor = SystemColors.Control;
                isActiv = false;
            }
        }

        private void nud_timer_ValueChanged(object sender, EventArgs e)
        {
            timerInterval = (int) nud_timer.Value;
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
            warnVol = (int) nud_volume.Value;
            tb_volume.Value = warnVol;

            Properties.Settings.Default.warnVol = warnVol;
            Properties.Settings.Default.Save();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            nud_volume.Value = warnVol;
            tb_volume.Value = warnVol;

            nud_timer.Value = timerInterval;
        }
    }
}