using System;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private readonly StopWatchModule stopWatch;

        public Form1()
        {
            InitializeComponent();
            stopWatch = new StopWatchModule(15);
            timer1.Interval = 10;
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopWatch.Reset();
            UpdateLabel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopWatch.Tick();
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            label1.Text = stopWatch.GetFormattedTime();
        }
    }
}
