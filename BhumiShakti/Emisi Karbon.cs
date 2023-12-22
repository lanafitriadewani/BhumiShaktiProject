using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BhumiShakti
{
    public partial class Emisi_Karbon : Form
    {
        private List<string> paragraphs;
        private int currentParagraphIndex = 0;
        public Emisi_Karbon()
        {
            InitializeComponent();

            paragraphs = new List<string>
            {
                //Page1 
                "Emisi karbon menjadi isu global karena dianggap menjadi penyebab percepatan pemanasan global. Terlebih, pada 2023, emisi karbon dari bahan bakar " +
                "fosil telah meningkat ke rekor tertinggi.\nMenurut Laporan Iklim Internasional, diketahui umat manusia melepaskan setidaknya 40,6 miliar ton karbon " +
                "dioksida ke atmosfer pada 2023. Jumlah tersebut meningkat 1,1 persen dari tahun 2022. Jika ditambah dengan emisi yang dihasilkan oleh perubahan " +
                "penggunaan lahan, termasuk penggundulan hutan, maka total karbon dioksida yang dilepaskan mencapai 45,1 miliar ton pada 2023.\nMelansir dari BBC, Minggu " +
                "(10/12/2023), setelah mengalami tahun dengan suhu sangat tinggi yang belum pernah terjadi sebelumnya, termasuk bulan Juli yang tercatat sebagai bulan " +
                "terpanas di dunia, suhu secara keseluruhan pada tahun 2023 diperkirakan akan mendekati 1,5 derajat Celsius di atas tingkat pra-industri sebelum penggunaan " +
                "batu bara, minyak, dan gas secara luas dimulai pada tahun 1850.",

                //Page2
                "Meskipun situasi tersebut mungkin merupakan kejadian langka, para ilmuwan mengkhawatirkan bahwa dunia mungkin akan mempertahankan kadar gas rumah kaca " +
                "yang cukup tinggi untuk mempertahankan suhu pada tingkat ini dalam jangka waktu yang lebih lama. Para ilmuwan menjelaskan bahwa peningkatan karbon dioksida " +
                "dan gas lain di atmosfer menyebabkan peningkatan suhu karena menangkap radiasi dari Bumi, menciptakan apa yang disebut sebagai efek rumah kaca.\nAngka 1,5 " +
                "derajat Celsius merupakan elemen kunci dari komitmen yang diambil oleh pemimpin politik saat mereka menandatangani Perjanjian Iklim Paris pada tahun 2015. " +
                "Mereka berupaya untuk membatasi kenaikan suhu global jauh di bawah 2 derajat Celsius dan melakukan upaya terbaik untuk mempertahankan kenaikan suhu di bawah" +
                " 1,5 derajat Celsius selama abad ini.\nAngka 1,5 derajat Celsius memiliki arti besar bagi negara-negara berkembang dan kepulauan kecil yang khawatir jika " +
                "kenaikan suhu melewati batas ini. Hal tersebut adanya potensi yang menyebabkan naiknya permukaan laut dan mengancam tempat tinggal mereka.",

                //Page3
                "Para ilmuwan telah melakukan perhitungan untuk menentukan berapa lama dunia dapat mempertahankan angka ini, dengan menghitung anggaran sisa karbon yang dapat " +
                "dilepaskan sebelum melewati batas krusial tersebut.\nAwal tahun ini, Intergovernmental Panel on Climate Change (IPCC), badan penasihat utama PBB, memperkirakan " +
                "bahwa sisa karbon yang dapat dilepaskan ke atmosfer hanya sekitar 500 miliar ton. Dengan batasan tersebut, peluang untuk mempertahankan pemanasan di bawah 1,5 " +
                "derajat Celsius adalah 50 persen.\nDikarenakan tingkat emisi tahunan saat ini mencapai sekitar 40 miliar ton, IPCC memprediksi bahwa ambang batas tersebut akan " +
                "terlampaui secara permanen sekitar pertengahan dekade berikutnya. Namun, analisis terbaru menunjukkan bahwa ini akan terjadi lebih cepat dari yang diperkirakan. " +
                "\nPara peneliti mempertimbangkan fakta bahwa IPCC hanya memasukkan data hingga tahun 2020, sehingga mereka melakukan penyesuaian pada estimasi anggaran untuk " +
                "memperhitungkan karbon yang telah terlepas selama tiga tahun terakhir.",

                //Page4
                "Mereka juga melakukan evaluasi ulang terhadap faktor-faktor non-karbon lainnya yang turut berkontribusi pada pemanasan. Salah satu hal yang sangat penting adalah " +
                "partikel kecil berupa jelaga yang disebut aerosol, yang sebagian besar berasal dari pembakaran bahan bakar fosil.\nMeskipun bahan-bahan tersebut menyebabkan polusi " +
                "udara yang signifikan, mereka memiliki efek tak terduga pada iklim karena membantu mendinginkan atmosfer dengan memantulkan sinar matahari kembali ke luar angkasa.\n" +
                "Studi terbaru menunjukkan bahwa aerosol sebenarnya memiliki efek pendinginan yang lebih besar dari yang sebelumnya diperkirakan.\nNamun, dengan upaya global untuk " +
                "membersihkan udara di kota-kota besar dan mengurangi penggunaan bahan bakar fosil yang banyak mencemari, konsentrasi aerosol di atmosfer turun, yang berarti suhu " +
                "meningkat lebih cepat daripada yang diprediksi sebelumnya.",

                //Page5
                "Para peneliti menyatakan bahwa pemahaman baru tentang peran aerosol mengakibatkan pengurangan sekitar 100 miliar ton dari sisa anggaran 1,5 derajat Celsius. Ketika " +
                "ini digabungkan dengan tambahan emisi karbon dan beberapa penyesuaian kecil lainnya, total sisa anggaran ini turun menjadi 250 miliar ton.\nPemimpin penelitian, Dr. " +
                "Robin Lamboll dari Imperial College London menyatakan,'Peluang untuk menghindari kenaikan suhu 1,5 derajat Celsius semakin sempit seiring terusnya emisi dan pemahaman " +
                "kita tentang fisika atmosfer semakin meningkat.'\n'Kami kini memprediksi bahwa kita hanya dapat mempertahankan tingkat emisi saat ini selama sekitar enam tahun sebelum " +
                "kemungkinan besar kita akan melampaui titik penting dalam Perjanjian Paris,' tambah Dr. Robin Lamboll.",
                // Add more paragraphs as needed
            };

            // Display the first paragraph
            label2.Text = paragraphs[currentParagraphIndex];
        }

        private void Emisi_Karbon_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
