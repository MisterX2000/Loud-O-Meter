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
    public partial class Form1 : Form
    {
        private int warnVol;

        public Form1()
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
            }
        }

        private void nud_timer_ValueChanged(object sender, EventArgs e)
        {
            t_volume.Interval = (int)nud_timer.Value;
        }

        private void tb_volume_Scroll(object sender, EventArgs e)
        {
            warnVol = tb_volume.Value;
            nud_volume.Value = tb_volume.Value;
        }

        private void nud_volume_ValueChanged(object sender, EventArgs e)
        {
            warnVol = (int)nud_volume.Value;
            tb_volume.Value = (int)nud_volume.Value;
        }
    }
}
