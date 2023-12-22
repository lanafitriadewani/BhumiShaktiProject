using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BhumiShakti
{
    public partial class Bhumi_Games : Form
    {
        public Bhumi_Games()
        {
            InitializeComponent();

            label1.Text = "Welcome to the Bhumi Games! Before you begin the game, please take note of the following instructions:\r\n\r\n" +
                "1. Ensure you carefully read each question before selecting an answer.\r\n" +
                "2. Answer questions correctly to achieve the maximum score.\r\n" +
                "3. The questions and answers will be in Bahasa\r\n" +
                "4. After completing the quiz, you will see your final score and can review the correct answers.\r\n" +
                "5. Get ready for the challenge and enjoy the game!\r\n\r\n" +
                "Have fun and good luck! 🌟";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quiz_Started start = new Quiz_Started();
            this.Hide();
            start.Show();
        }
    }
}
