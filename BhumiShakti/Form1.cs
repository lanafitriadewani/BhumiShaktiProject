using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BhumiShakti
{
    public partial class Form1 : Form
    {
        //private Timer timer1;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();

            timer1.Interval = 100; // 1000 milliseconds = 1 second

            // Attach the event handler for the Tick event
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            /*
            int progressValue = 0;
            while (progressValue <= 100)
            {
                progressBar1.Value = progressValue;
                
                Task.Delay(1000).Wait();
                progressValue += 10;
            }

            this.Hide();
            Login login = new Login();
            login.Show(); 
            */

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int progressValue = 0;
            /*if (progressBar1.Value <= 100)
            {
                progressBar1.Value += 1;
                //progressBar1.Value = progressValue;

                //Task.Delay(1000).Wait();
                //progressValue += 10;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }*/
            panel1.Width += 3;

            if(panel1.Width >= 463)
            {
                timer1.Stop();

                this.Hide();
                Login login = new Login();
                login.Show();
            }              
            
        } 
    }
}
