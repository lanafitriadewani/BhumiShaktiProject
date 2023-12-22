using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BhumiShakti
{
    public partial class TnT : Form
    {
        private List<string> paragraphs;
        private int currentParagraphIndex = 0;
        public TnT()
        {
            InitializeComponent();

            paragraphs = new List<string>
            {
                //Page1 
                "Alam memberikan manusia banyak hal yang indah dan bermanfaat. Dari pemandangan yang indah, makanan dan tempat tinggal, hingga menjaga keseimbangan " +
                "ekosistem serta lingkungan diperlukan untuk menopang kehidupan di planet ini. Manfaat dari menjaga keseimbangan ekosistem dan lingkungan menjadi " +
                "prioritas yang sangat tinggi demi kenyamanan dan terhindar dari berbagai penyakit. Berikut adalah beberapa tips dan trik yang dapat membantu kita " +
                "semua berkontribusi dalam menjaga ekosistem:\n\n1. Pendidikan dan Kesadaran Lingkungan:\nKesadaran adalah kunci utama untuk menjaga ekosistem, dengan " +
                "adanya kesadaran dalam menjaga lingkungan, maka potensi untuk terjadinya kerusakan lingkungan semakin berkurang. Pendidikan tentang lingkungan dan " +
                "keanekaragaman hayati dapat membantu mengubah sikap dan perilaku kita terhadap alam.",

                //Page2
                "2. Pengelolaan Sampah yang Bijak:\nMengelola sampah dengan benar adalah langkah awal dalam menjaga ekosistem. Melakukan daur ulang, mengurangi penggunaan " +
                "plastik, dan memastikan untuk membuang sampah pada tempatnya.\n\n3. Gunakan Produk Ramah Lingkungan:\nSeiring berkembangnya zaman, kesadaran masyarakat " +
                "terhadap penggunaan produk ramah lingkungan semakin meningkat. Penggunaan produk ramah lingkungan ini memberikan dampak yang besar bagi keseimbangan ekosistem " +
                "dan lingkungan.\n\n4. Pemeliharaan Tanaman Asli:\n Tanaman asli mendukung keanekaragaman hayati dan membantu menciptakan lingkungan yang sehat. Pemeliharaan " +
                "tanaman asli dapat memberikan berbagai dampak positif bagi manusia serta lingkungan sekitar.",

                //Page3
                "5. Konservasi Keanekaragaman Hayati:\nKeanekaragaman hayati merujuk pada ragam kehidupan di Bumi, termasuk berbagai spesies tumbuhan, hewan, dan " +
                "mikroorganisme, serta keragaman genetik dan ekosistem di mana mereka hidup. Konservasi keanekaragaman hayati menjadi sangat penting karena keberlanjutan " +
                "ekosistem dan kesejahteraan manusia bergantung pada keanekaragaman ini.\n\n6. Pemeliharaan Sumber Daya Air:\nSumber daya air adalah salah satu aset alam yang paling berharga dan penting untuk kehidupan di Bumi. Air memainkan peran" +
                " krusial dalam menjaga keberlanjutan ekosistem dan memenuhi kebutuhan hidup manusia.\n\n7. Pemeliharaan Hutan:\nHutan adalah ekosistem yang sangat berharga" +
                " bagi keberlanjutan Bumi. Pemeliharaan hutan melibatkan berbagai kegiatan dan kebijakan untuk melindungi, mengelola, dan merestorasi hutan serta keanekaragaman " +
                "hayati yang ada di dalamnya.",

                "8. Penggunaan Energi yang Efisien:\nPenggunaan energi yang efisien adalah konsep yang mencakup berbagai strategi dan teknologi untuk memaksimalkan hasil dari " +
                "setiap unit energi yang digunakan. Praktik ini bertujuan untuk mengurangi konsumsi energi, emisi gas rumah kaca, dan ketergantungan pada sumber daya energi " +
                "non-terbarukan.\n\n9. Partisipasi dalam Komunitas:\nPartisipasi dalam komunitas adalah konsep yang menekankan keterlibatan aktif individu dalam kehidupan masyarakatnya. Ini " +
                "mencakup berbagai tindakan dan kontribusi yang bertujuan untuk membangun kesejahteraan bersama dan meningkatkan kualitas hidup di dalam komunitas. Kolaborasi " +
                "dengan tetangga dan kelompok lokal untuk menjaga dan memulihkan ekosistem di sekitar Anda.",

                "10. Pengembangan Ruang Terbuka Hijau\nPengembangan ruang terbuka hijau melibatkan perencanaan, pembangunan, dan pemeliharaan area terbuka yang ditujukan untuk " +
                "kesejahteraan masyarakat dan kelestarian lingkungan. Ruang terbuka hijau dapat mencakup taman, taman kota, taman nasional, dan area terbuka lainnya yang dirancang " +
                "untuk rekreasi, konservasi alam, dan kesehatan masyarakat.\n\nMenjaga ekosistem adalah tanggung jawab bersama kita. Dengan menerapkan tips dan trik ini dalam kehidupan" +
                " sehari-hari, kita dapat berkontribusi untuk menjaga keberlanjutan alam dan mewariskan planet yang lebih baik kepada generasi mendatang. Setiap tindakan kecil memiliki " +
                "dampak besar dalam menjaga kehidupan di Bumi.",
                // Add more paragraphs as needed
            };

            // Display the first paragraph
            label2.Text = paragraphs[currentParagraphIndex];
        }

        private void TnT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentParagraphIndex = (currentParagraphIndex + 1) % paragraphs.Count;

            label2.Text = paragraphs[currentParagraphIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentParagraphIndex = (currentParagraphIndex - 1 + paragraphs.Count) % paragraphs.Count;

            label2.Text = paragraphs[currentParagraphIndex];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bhumi_Post post = new Bhumi_Post();
            this.Hide();
            post.Show();
        }
    }
}
