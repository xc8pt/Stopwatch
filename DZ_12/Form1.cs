using System;
using System.Windows.Forms;

namespace DZ_12
{
    public partial class Form1 : Form
    {
        private int timeLeft = 10;
        private int clickCount = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeClicker();
        }

        private void InitializeClicker()
        {
            label1.Text = "Время: " + timeLeft;
            label2.Text = "Нажатий: " + clickCount;
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                if (!timer.Enabled)
                    timer.Start();
                ++clickCount;
                label2.Text = "Нажатий: " + clickCount;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            --timeLeft;
            label1.Text = "Время: " + timeLeft;
            if (timeLeft == 0)
                timer.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeLeft = 10;
            clickCount = 0;
            label1.Text = "Время: " + timeLeft;
            label2.Text = "Нажатий: " + clickCount;
        }
    }
}

