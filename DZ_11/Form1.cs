using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DZ_11
{
    public partial class Form1 : Form
    {
        // Список слов для тренировки
        private List<string> words = new List<string> { "яблоко", "стол", "ручка", "небо", "лампа", "окно", "экран", "собака" };
        private Random random = new Random();
        private int correctCount = 0;
        private int wrongCount = 0;

        public Form1()
        {
            InitializeComponent();
            NextWord();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Trim().ToLower() == label3.Text.ToLower())
                {
                    correctCount++;
                }
                else
                {
                    wrongCount++;
                }
                label1.Text = "Правильных слов: " + correctCount;
                label2.Text = "Неправильных слов: " + wrongCount;
                textBox1.Text = "";
                NextWord();
            }
        }

        private void NextWord()
        {
            label3.Text = words[random.Next(words.Count)];
        }
    }
}
