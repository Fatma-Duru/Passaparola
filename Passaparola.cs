using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Passaparola : Form
    {
        public Passaparola()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var answers = new Dictionary<int, string>
        {
            { 1, "Akdeniz" },
            { 2, "Bursa" },
            { 3, "Cuma" },
            { 4, "Niğde" },
            { 5, "Eski" },
            { 6, "Ferman" },
            { 10, "Türkiye" },
            { 11, "Everest" },
            { 12, "Osman Gazi" },
            { 13, "1915" },
            { 14, "Fındık" },
            { 15, "Van Gölü" },
            { 16, "Marmara Denizi" },
            { 17, "1923" },
            { 18, "Ağrı Dağı" },
            { 19, "Sakarya" },
            { 20, "Akdeniz" },
            { 21, "Pasifik" },
            { 22, "Edirne" },
            { 23, "Artvin" },
            { 24, "Antalya" }
        };

                if (answers.ContainsKey(soruno))
                {
                    bool isCorrect = textBox1.Text.Equals(answers[soruno], StringComparison.OrdinalIgnoreCase);
                    Control button = Controls["btn" + soruno]; // butonun adını oluştur
                    button.BackColor = isCorrect ? Color.Green : Color.Red;

                    if (isCorrect)
                    {
                        dogru++;
                        LblDogru.Text = dogru.ToString();
                    }
                    else
                    {
                        yanlis++;
                        LblYanlis.Text = yanlis.ToString();
                    }
                }
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {
            basla.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            string[] sorular = new string[]
            {
        "Ülkemizin güney kısmındaki kıyı bölgesi?",
        "Yeşilliği ile ünlü Marmara ilimiz?",
        "Müslümanların kutsal günü?",
        "Karpuzu ile ünlü olan ilimiz?",
        "Yeni kelimesinin zıttı?",
        "Padişahın emirlerinin yazılı hali?",
        "Ülkemizin güney kısmındaki kıyı bölgesi?",
        "Yeşilliği ile ünlü Marmara ilimiz?",
        "Müslümanların kutsal günü?",
        "Başkenti Ankara olan ülke?",
        "Dünyanın en yüksek dağı?",
        "Osmanlı Devleti'nin kurucusu kimdir?",
        "Çanakkale Savaşı'nın yapıldığı yıl?",
        "Karadeniz Bölgesi'nde en çok yetişen tarım ürünü?",
        "Türkiye'nin en büyük gölü?",
        "İstanbul Boğazı'ndan geçen deniz?",
        "Cumhuriyetin ilan yılı?",
        "Türkiye'nin doğusunda yer alan dağ?",
        "Kurtuluş Savaşı'nın başladığı şehir?",
        "Türkiye'nin komşusu olan deniz?",
        "Dünyanın en büyük okyanusu?",
        "Türkiye'nin en batısında yer alan şehir?",
        "Türkiye'nin en kuzeyindeki il?",
        "Türkiye'nin en güneyindeki şehir?"
            };

            Button[] butonlar = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24 };

            if (soruno > 0 && soruno <= sorular.Length)
            {
                richTextBox1.Text = sorular[soruno - 1];
                butonlar[soruno - 1].BackColor = Color.Yellow;
            }
        }

    }
}
