using System;
using System.Windows.Forms;

namespace Imagy_gallery
{
    public partial class Form1 : Form
    {
        int currentIndex = 1;
        private readonly object[] images =
        {
            Properties.Resources._2851548463,
            Properties.Resources._5400259267312870115,
            Properties.Resources.ce743c65_bec5_4564_bd5f_9fe8e8b5dbfc,
            Properties.Resources.efb550175087029c763091e169676fe0

        };
        private void ShowImage()
        {
            pictureBox1.Image = (System.Drawing.Image)images[currentIndex];
        }
        //private void changeImage(int number)
        //{
        //    switch (number)
        //    {
        //        case 1: pictureBox1.Image = Properties.Resources._2851548463; 
        //            break;
        //        case 2: pictureBox1.Image = Properties.Resources._5400259267312870115; 
        //            break;
        //        case 3: pictureBox1.Image = Properties.Resources.ce743c65_bec5_4564_bd5f_9fe8e8b5dbfc; 
        //            break;
        //        case 4: pictureBox1.Image = Properties.Resources.efb550175087029c763091e169676fe0; 
        //            break;

        //    }
        //}
        public Form1()
        {
            InitializeComponent();
            ShowImage();
        }

        private void buttonNext(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Length)
                currentIndex = 0;
            ShowImage();
        }

        private void buttonBack(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = images.Length - 1;
            ShowImage();
        }
    }
}
