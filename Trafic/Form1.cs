using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafic
{
    public partial class Form1 : Form
    {
        private enum LightState { Red, Yellow, Green }
        private LightState currentState = LightState.Green;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SwitchToNextState();
            ShowLight();
        }

        private void ShowLight()
        {
            panelRED.BackColor = Color.Gray;
            panelYELLOW.BackColor = Color.Gray;
            panelGREEN.BackColor = Color.Gray;

            switch (currentState)
            {
                case LightState.Red:
                    panelRED.BackColor = Color.Red;
                    break;
                case LightState.Yellow:
                    panelYELLOW.BackColor = Color.Yellow;
                    break;
                case LightState.Green:
                    panelGREEN.BackColor = Color.Green;
                    break;
            }

        }

        private void SwitchToNextState()
        {
            switch (currentState)
            {
                case LightState.Red:
                    currentState = LightState.Yellow;
                    break;
                case LightState.Yellow:
                    currentState = LightState.Green;
                    break;
                case LightState.Green:
                    currentState = LightState.Red;
                    break;

            }
        }
    }
}
