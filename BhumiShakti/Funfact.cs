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
    public partial class Funfact : Form
    {
        private List<string> paragraphs;
        private int currentParagraphIndex = 0;
        public Funfact()
        {
            InitializeComponent();

            paragraphs = new List<string>
            {
                //Page1 
                "Bumi kita adalah rumah bagi berbagai macam ekosistem yang menakjubkan, mulai dari hutan hujan yang lebat hingga gurun pasir yang panas. " +
                "Setiap ekosistem memiliki karakteristik uniknya dan berperan penting dalam menjaga keseimbangan lingkungan. Mari kita eksplorasi beberapa fakta " +
                "menarik yang membuat keberagaman ekosistem di Bumi begitu memukau.\r\n\n1. Hutan Hujan Amazon: Paru-paru Dunia\r\n" +
                "Hutan hujan Amazon di Amerika Selatan tidak hanya menjadi rumah bagi sekitar 390 miliar pohon, tetapi juga menghasilkan sekitar 20% oksigen di " +
                "atmosfer Bumi, menjadikannya 'paru-paru dunia.' \r\n\n2. Ekosistem Terumbu Karang: Keanekaragaman Bawah Laut\r\n" +
                "Meskipun hanya menempati kurang dari 0,1% permukaan lautan, terumbu karang menyediakan rumah bagi sekitar 25% spesies laut. Ini adalah " +
                "ekosistem yang sangat produktif dan beragam.\r\n",

                //Page2
                "3. Gurun Atacama: Kehidupan dalam Kekeringan\r\nGurun Atacama di Chili dianggap sebagai salah satu gurun terkering di dunia, tetapi ekosistemnya " +
                "menunjukkan kehidupan yang luar biasa. Bakteri yang dapat bertahan dalam kondisi kekeringan ekstrem dapat ditemukan di sana." +
                "\r\n\n4. Ekosistem Hutan Kelp: Hutan Bawah Laut\r\nHutan kelp di pantai California adalah ekosistem laut yang unik. Alga kelp menciptakan hutan bawah air " +
                "yang berfungsi sebagai tempat perlindungan dan makanan bagi banyak spesies laut.\r\n\n5. Savanna Afrika: Rumah bagi Raksasa-Raksasa Laut\r\n" +
                "Savana di Afrika adalah rumah bagi beberapa dan jerapah. Ini adalah contoh ekosistem daratan yang menampilkan keanekaragaman hayati yang luar biasa.",

                //Page3
                "6. Hutan Boreal: Menyimpan Karbon dan Habitat Unik\r\nHutan boreal di wilayah kutub utara adalah penyerap karbon besar dan menyediakan habitat " +
                "untuk berbagai spesies, termasuk beruang kutub dan rusa kutub.\r\n\n7. Ekosistem Sungai Amazon: Jalan Air Besar\r\nSungai Amazon membentuk ekosistem " +
                "air tawar terbesar di dunia. Ini menyediakan habitat untuk sejumlah besar spesies ikan dan memainkan peran penting dalam sistem hidrologis global." +
                "\r\n\n8. Ekosistem Gua: Kehidupan di Dalam Kegelapan\r\nEkosistem gua menampilkan kehidupan yang unik, termasuk kelelawar, serangga khusus," +
                " dan bahkan ikan yang telah beradaptasi untuk hidup di dalam gua yang gelap.\r\n\n9. Hutan Mangrove: Perlindungan Pantai dan Keanekaragaman\r\nHutan " +
                "mangrove di garis pantai menyediakan perlindungan dari badai dan gelombang tinggi. Mereka juga menjadi rumah bagi banyak spesies laut yang penting.\r\n",

                "10. Padang Rumput Amerika Serikat: Habitat Bison dan Pronghorn\r\nPadang rumput di Amerika Serikat, seperti Great Plains, adalah rumah bagi sejumlah " +
                "besar bison dan pronghorn. Ini adalah contoh ekosistem daratan yang luas dan unik.\r\n\nMelalui keberagaman ekosistem ini, Bumi menunjukkan keajaiban " +
                "alam yang tak terhitung jumlahnya. Memahami, menjaga, dan melestarikan keberagaman ini penting untuk masa depan planet kita dan kelangsungan hidup " +
                "generasi mendatang. Mari kita bersama-sama menjadi pelindung alam ini dan terus merayakan keindahan ekosistem yang memukau ini.\r\n ",
                // Add more paragraphs as needed
            };

            // Display the first paragraph
            label2.Text = paragraphs[currentParagraphIndex];

        }

        private void Funfact_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bhumi_Post post = new Bhumi_Post();
            this.Hide();
            post.Show();
        }
    }
}
