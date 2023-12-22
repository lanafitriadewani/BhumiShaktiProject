using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BhumiShakti
{
    public partial class Profile : Form
    {
        public static string Email { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static DateTime BirthDate { get; set; }
        public static string Country { get; set; }
        public static string Address { get; set; }

        public Profile()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");

        public void SetUserInfo()
        {
            // Set labels or textboxes with user information
            label2.Text = "Name: " + Profile.FirstName + " " + Profile.LastName;
            label6.Text = "Birth Date: " + Profile.BirthDate.ToShortDateString();
            label7.Text = "Country: " + Profile.Country;
            label8.Text = "Address: " + Profile.Address;
            label9.Text = "Email: " + Profile.Email;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Notifications notif = new Notifications();
            this.Hide();
            notif.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
