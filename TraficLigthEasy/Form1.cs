using System;
using System.Drawing;
using System.Windows.Forms;

namespace TraficLigthEasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetLight(Color color, string message)
        {
            panel1.BackColor = color;
            label1.Text = message;
        }


        private void buttonRED_Click(object sender, EventArgs e)
        {
            SetLight(Color.Red, "СТОП");
            panel1.BackColor = Color.Red;
        }

        private void buttonYELLOW_Click(object sender, EventArgs e)
        {
            SetLight(Color.Yellow, "ПОДОЖДАТЬ");
            panel1.BackColor = Color.Yellow;
        }

        private void buttonGREEN_Click(object sender, EventArgs e)
        {
            SetLight(Color.Green, "МОЖНО");
            panel1.BackColor = Color.Green;
        }
    }
}
