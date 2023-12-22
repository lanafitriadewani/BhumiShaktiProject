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
    public partial class Scores : Form
    {
        public Scores(int score, int percentage)
        {
            InitializeComponent();

            label1.Text = "Quiz Ended!\nYou have answered " + score + " questions correctly.\nYour total percentage is " + percentage + "%";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
