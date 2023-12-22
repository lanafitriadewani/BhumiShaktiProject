using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BhumiShakti.Bhumi_Post;

namespace BhumiShakti
{
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
            CheckVisitedArticles();
        }

        private void CheckVisitedArticles()
        {
            if (VisitedArticlesManager.IsArticleVisited("Emisi_Karbon"))
            {
                AddNotification("Cool! You have visited the 'Emisi Karbon Capai Rekor Tertinggi pada 2023' article.");
            }
            else if (VisitedArticlesManager.IsArticleVisited("TnT"))
            {
                AddNotification("Cool! You have visited the 'Ekosistem? Tips dan Trik Menjaga Ekosistem' article.");
            }
            else if (VisitedArticlesManager.IsArticleVisited("Funfact"))
            {
                AddNotification("Cool! You have visited the 'Keajaiban Alam: Fakta Menarik Tentang Ekosistem di Bumi' article.");
            }
            else
            {
                AddNotification("There is no Notifications!");
            }
        }

        private void AddNotification(string message)
        {
            Label notificationLabel = new Label();
            notificationLabel.Text = message;
            notificationLabel.AutoSize = true;

            // Add the label to the form
            flowLayoutPanel1.Controls.Add(notificationLabel);

            // Optionally, you can set a timer to remove the notification after a certain time
            /*Timer timer = new Timer();
            timer.Interval = 30000; // 600000 milliseconds (10 minutes)
            timer.Tick += (sender, e) =>
            {
                flowLayoutPanel1.Controls.Remove(notificationLabel);
                timer.Stop();
            };
            timer.Start();*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.SetUserInfo();
            this.Hide();
            profile.Show();
        }
    }
}
