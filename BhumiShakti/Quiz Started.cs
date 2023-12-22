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
    public partial class Quiz_Started : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Quiz_Started()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber < totalQuestions)
            {
                questionNumber++;
                askQuestion(questionNumber);
            }
            else
            {
                // Work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                Scores scores = new Scores(score, percentage);
                this.Hide();
                scores.Show();

                score = 0;
                questionNumber = 1; // Reset question number to 1 for next round
            }

            //questionNumber++;
            //askQuestion(questionNumber);


        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    label1.Text = "Bagaimana cara mengurangi emisi karbon pribadi?";

                    button1.Text = "Menggunakan transportasi umum atau bersepeda";
                    button2.Text = "Menyalakan lampu dan peralatan elektronik sepanjang waktu";
                    button3.Text = "Meningkatkan penggunaan kendaraan bermotor pribadi";
                    button4.Text = "Menggunakan kemasan sekali pakai";

                    correctAnswer = 1;

                    break;

                case 2:

                    label1.Text = "Apa yang dapat dilakukan untuk mendukung daur ulang?";

                    button1.Text = "Membuang sampah ke sungai";
                    button2.Text = "Memilah sampah organik dan non-organik";
                    button3.Text = "Membakar sampah di halaman belakang";
                    button4.Text = "Membuang sampah sembarangan di jalanan";

                    correctAnswer = 2;

                    break;

                case 3:

                    label1.Text = "Apa dampak dari peningkatan emisi karbon terhadap iklim global?";

                    button1.Text = "Penurunan suhu global";
                    button2.Text = "Peningkatan tingkat lautan";
                    button3.Text = "Penurunan tingkat hujan";
                    button4.Text = "Pencairan es di kutub";

                    correctAnswer = 4;

                    break;

                case 4:

                    label1.Text = "Gurun Atacama di Chili dianggap sebagai salah satu gurun terkering di dunia. Namun, apa yang membuatnya unik dalam hal kehidupan?";

                    button1.Text = "Keanekaragaman spesies tumbuhan";
                    button2.Text = "Keberadaan oasis alami";
                    button3.Text = "Adaptasi bakteri terhadap kekeringan";
                    button4.Text = "Tingginya curah hujan sporadis";

                    correctAnswer = 3;

                    break;

                case 5:

                    label1.Text = "Bagaimana individu dapat membantu mengurangi emisi karbon mereka?";

                    button1.Text = "Meningkatkan penggunaan kendaraan pribadi";
                    button2.Text = "Menggunakan listrik dari pembangkit listrik batu bara";
                    button3.Text = "Mendukung proyek deforestasi";
                    button4.Text = "Mengurangi penggunaan energi dan menggunakan transportasi berkelanjutan";

                    correctAnswer = 4;

                    break;

            }
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
    }
}
