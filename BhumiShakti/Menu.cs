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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Notifications notif = new Notifications();
            this.Hide();
            notif.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bhumi_Post post = new Bhumi_Post();
            this.Hide();
            post.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bhumi_Games games = new Bhumi_Games();
            this.Hide();
            games.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.SetUserInfo();
            this.Hide();
            profile.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
