using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace BhumiShakti
{
    public partial class Register : Form
    {
        SqlConnection connection;

        public Register()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && last_name.Text != "" && birth_date.Text != "" && country.Text != "" && email.Text != "" && address.Text != "" && password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();

                            SqlCommand getMaxIdCommand = new SqlCommand("SELECT MAX(Id) FROM RegistrationTbl", connection);
                            object result = getMaxIdCommand.ExecuteScalar();
                            int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                            //int maxId = (int)(getMaxIdCommand.ExecuteScalar() ?? 0);
                            int newId = maxId + 1;

                            SqlCommand command = new SqlCommand("INSERT INTO RegistrationTbl (Id, f_name, l_name, b_date, country, address, email, password) VALUES (@Id, @f_name, @l_name, @b_date, @country, @address, @email, @password)", connection);

                            command.Parameters.AddWithValue("@Id", newId);
                            command.Parameters.AddWithValue("@f_name", first_name.Text);
                            command.Parameters.AddWithValue("@l_name", last_name.Text);
                            command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(birth_date.Text));
                            command.Parameters.AddWithValue("@country", country.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();

                            Login login = new Login();
                            this.Hide();
                            login.Show();

                            /*MessageBox.Show("Register Succesfully!");
                            first_name.Text = "";
                            last_name.Text = "";
                            country.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";*/
                        }
                        else
                        {
                            MessageBox.Show("You are already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from RegistrationTbl where email='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
                con_password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_password.UseSystemPasswordChar = true;
            }
        }

        private void check_pass_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
