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
    public partial class Bhumi_Post : Form
    {
        public Bhumi_Post()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Funfact ff = new Funfact();
            this.Hide();
            ff.Show();

            VisitedArticlesManager.MarkArticleAsVisited("Funfact");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emisi_Karbon emisi = new Emisi_Karbon();
            this.Hide();
            emisi.Show();

            VisitedArticlesManager.MarkArticleAsVisited("Emisi_Karbon");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TnT tnt = new TnT();
            this.Hide();
            tnt.Show();

            VisitedArticlesManager.MarkArticleAsVisited("TnT");
        }
        public static class VisitedArticlesManager
        {
            private static List<string> visitedArticles = new List<string>();

            public static bool IsArticleVisited(string articleName)
            {
                return visitedArticles.Contains(articleName);
            }

            public static void MarkArticleAsVisited(string articleName)
            {
                if (!visitedArticles.Contains(articleName))
                {
                    visitedArticles.Add(articleName);
                }
            }
        }

        private void Bhumi_Post_Load(object sender, EventArgs e)
        {

        }
    }
}
