using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BhumiShakti
{
    public partial class Login : Form
    {
        /*public Login()
        {
            InitializeComponent();
        }*/
        
        SqlConnection connection;

        public Login()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            try
            {
                // Get the folder where the executable is located
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the relative path to the database file
                string dbFilePath = "LoginDb.mdf";

                // Combine the base directory with the database file path
                string fullDbPath = System.IO.Path.Combine(baseDirectory, dbFilePath);

                // Use the combined path in the connection string
                connection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={fullDbPath};Integrated Security=True;Connect Timeout=30");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the connection: {ex.Message}");
            }
        }
        //SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text != "" && password.Text != "")
            {
                string query = "SELECT COUNT(*) FROM RegistrationTbl WHERE email = '" + email.Text + "' AND password = '" + password.Text + "'";
                //connection.Open();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or password", "Error!");
                }
                else
                {
                    /*MessageBox.Show("Welcome to your profile!");
                    email.Text = "";
                    password.Text = "";*/
                    connection.Close();
                    Profile.Email = email.Text;
                    FetchUserInfoFromDatabase();

                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks");
            }
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void FetchUserInfoFromDatabase()
        {
            try
            {
                string query = "SELECT * FROM RegistrationTbl WHERE email = @Email";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", Profile.Email);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Profile.FirstName = reader["f_name"].ToString();
                    Profile.LastName = reader["l_name"].ToString();
                    Profile.BirthDate = Convert.ToDateTime(reader["b_date"]);
                    Profile.Country = reader["country"].ToString();
                    Profile.Address = reader["address"].ToString();
                    // Set other properties as needed
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
