using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DortIslem
{
    public partial class oyun : Form
    {
        public oyun()
        {
            InitializeComponent();
        }

        int zaman = 100;
        bool JOKER = false;
        int skor = 0;
        int soruno = 0;
        int[] cevaplar = new int[4];
        int sayi1, sayi2;
        int islemsonucu;
        string isaret;
        int islem;
        Random rastgele = new Random();

        public bool OyunSonuMu()
        {
            if (soruno >= 10)
            {
                Program.isim = Interaction.InputBox("Lütfen isminizi giriniz", "Bilgi Girişi", "", (Screen.PrimaryScreen.WorkingArea.Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2));
                Program.skor = skor;
                sonEkran x = new sonEkran();
                x.Show();
                this.Close();
                return true;
            }
            else return false;
        }

        public void yeniSoru()
        {
            soruno++;
            soruSayisiLbl.Text = soruno.ToString() + " -)";
            islem = rastgele.Next(0, 4);

            if (islem == 0) toplamaCagir();
            if (islem == 1) cikarmaCagir();
            if (islem == 2) carpmaCagir();
            if (islem == 3) bolmeCagir();

            pA.BackgroundImage = Properties.Resources.gribas;
            pB.BackgroundImage = Properties.Resources.gribas;
            pC.BackgroundImage = Properties.Resources.gribas;
            pD.BackgroundImage = Properties.Resources.gribas;

        }

        public void toplamaCagir()
        {

            sayi1 = rastgele.Next(1, 50);
            sayi2 = rastgele.Next(1, 50);

            islemsonucu = sayi1 + sayi2;
            isaret = " + ";

            int rnd1 = rastgele.Next(1, 100);
            int rnd2 = rastgele.Next(1, 150);
            int rnd3 = rastgele.Next(1, 200);

            cevaplar[0] = islemsonucu;
            if (!Array.Exists(cevaplar, element => element == rnd1)) cevaplar[1] = rnd1;
            if (!Array.Exists(cevaplar, element => element == rnd2)) cevaplar[2] = rnd2;
            if (!Array.Exists(cevaplar, element => element == rnd3)) cevaplar[3] = rnd3;

            cevaplar.ToList().Sort();

            for (int t = 0; t < cevaplar.Length; t++)
            {

                int tmp = cevaplar[t];
                int r = rastgele.Next(t, cevaplar.Length);
                cevaplar[t] = cevaplar[r];
                cevaplar[r] = tmp;
            }

            islemLbl.Text = sayi1.ToString() + isaret + sayi2.ToString();

            cevapALbl.Text = cevaplar[0].ToString();
            cevapCLbl.Text = cevaplar[1].ToString();
            cevapBLbl.Text = cevaplar[2].ToString();
            cevapDLbl.Text = cevaplar[3].ToString();

        }


        public void cikarmaCagir()
        {
            int s1 = rastgele.Next(1, 50);
            int s2 = rastgele.Next(1, 50);

            isaret = " - ";

            if (s1 > s2)
            {
                sayi1 = s1;
                sayi2 = s2;
            }
            else
            {
                sayi1 = s2;
                sayi2 = s1;
            }

            islemsonucu = sayi1 - sayi2;

            int rnd1 = rastgele.Next(1, 100);
            int rnd2 = rastgele.Next(1, 150);
            int rnd3 = rastgele.Next(1, 200);

            cevaplar[0] = islemsonucu;
            if (!Array.Exists(cevaplar, element => element == rnd1)) cevaplar[1] = rnd1;
            if (!Array.Exists(cevaplar, element => element == rnd2)) cevaplar[2] = rnd2;
            if (!Array.Exists(cevaplar, element => element == rnd3)) cevaplar[3] = rnd3;

            cevaplar.ToList().Sort();

            for (int t = 0; t < cevaplar.Length; t++)
            {

                int tmp = cevaplar[t];
                int r = rastgele.Next(t, cevaplar.Length);
                cevaplar[t] = cevaplar[r];
                cevaplar[r] = tmp;
            }

            islemLbl.Text = sayi1.ToString() + isaret + sayi2.ToString();

            cevapALbl.Text = cevaplar[0].ToString();
            cevapCLbl.Text = cevaplar[1].ToString();
            cevapBLbl.Text = cevaplar[2].ToString();
            cevapDLbl.Text = cevaplar[3].ToString();
        }

        public void carpmaCagir()
        {

            sayi1 = rastgele.Next(1, 25);
            sayi2 = rastgele.Next(1, 10);

            isaret = " x ";

            islemsonucu = sayi1 * sayi2;


            int rnd1 = rastgele.Next(1, 100);
            int rnd2 = rastgele.Next(1, 150);
            int rnd3 = rastgele.Next(1, 200);

            cevaplar[0] = islemsonucu;
            if (!Array.Exists(cevaplar, element => element == rnd1)) cevaplar[1] = rnd1;
            if (!Array.Exists(cevaplar, element => element == rnd2)) cevaplar[2] = rnd2;
            if (!Array.Exists(cevaplar, element => element == rnd3)) cevaplar[3] = rnd3;


            cevaplar.ToList().Sort();

            for (int t = 0; t < cevaplar.Length; t++)
            {

                int tmp = cevaplar[t];
                int r = rastgele.Next(t, cevaplar.Length);
                cevaplar[t] = cevaplar[r];
                cevaplar[r] = tmp;
            }

            islemLbl.Text = sayi1.ToString() + isaret + sayi2.ToString();

            cevapALbl.Text = cevaplar[0].ToString();
            cevapCLbl.Text = cevaplar[1].ToString();
            cevapBLbl.Text = cevaplar[2].ToString();
            cevapDLbl.Text = cevaplar[3].ToString();
        }

        public void bolmeCagir()
        {
            int s1 = rastgele.Next(1, 100);
            int s2 = rastgele.Next(1, 10);

            isaret = " / ";

            if (s1 > s2)
            {
                sayi1 = s1;
                sayi2 = s2;
            }
            else
            {
                sayi1 = s2;
                sayi2 = s1;
            }

            int carpim = sayi1 * sayi2;
            islemsonucu = carpim / sayi2;

            int rnd1 = rastgele.Next(1, 100);
            int rnd2 = rastgele.Next(1, 50);
            int rnd3 = rastgele.Next(1, 25);

            cevaplar[0] = islemsonucu;
            if (!Array.Exists(cevaplar, element => element == rnd1)) cevaplar[1] = rnd1;
            if (!Array.Exists(cevaplar, element => element == rnd2)) cevaplar[2] = rnd2;
            if (!Array.Exists(cevaplar, element => element == rnd3)) cevaplar[3] = rnd3;

            cevaplar.ToList().Sort();

            for (int t = 0; t < cevaplar.Length; t++)
            {

                int tmp = cevaplar[t];
                int r = rastgele.Next(t, cevaplar.Length);
                cevaplar[t] = cevaplar[r];
                cevaplar[r] = tmp;
            }

            islemLbl.Text = carpim.ToString() + isaret + sayi2.ToString();

            cevapALbl.Text = cevaplar[0].ToString();
            cevapCLbl.Text = cevaplar[1].ToString();
            cevapBLbl.Text = cevaplar[2].ToString();
            cevapDLbl.Text = cevaplar[3].ToString();
        }



        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyun_Load(object sender, EventArgs e)
        {
            timer1.Start();
            yeniSoru();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            soruno--;
            yeniSoru x = new yeniSoru();
            x.ShowDialog();
            yeniSoru();
            pictureBox1.Visible = false;
        }

        private void pA_Click(object sender, EventArgs e)
        {
            if (cevapALbl.Text == islemsonucu.ToString())
            {
                pA.BackgroundImage = Properties.Resources.yesilbas;
                skor += 10;
                skorLbl.Text = skor.ToString();
                JOKER = false;
                Program.sescal("correct.wav");
            }
            else
            {

                pA.BackgroundImage = Properties.Resources.kirmizibas;
                if (JOKER == false)
                {
                    Program.sescal("fail.wav");
                    if (cevapCLbl.Text == islemsonucu.ToString()) pC.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapBLbl.Text == islemsonucu.ToString()) pB.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapDLbl.Text == islemsonucu.ToString()) pD.BackgroundImage = Properties.Resources.yesilbas;
                }

            }

            if (OyunSonuMu() == false)
            {
                if (JOKER == false)
                {
                    yeniSoru x = new yeniSoru();
                    x.ShowDialog();
                    yeniSoru();
                }
                else JOKER = false;
            }
        }

        private void pB_Click(object sender, EventArgs e)
        {
            if (cevapBLbl.Text == islemsonucu.ToString())
            {
                pB.BackgroundImage = Properties.Resources.yesilbas;
                skor += 10;
                skorLbl.Text = skor.ToString();
                JOKER = false;
                Program.sescal("correct.wav");
            }
            else
            {

                pB.BackgroundImage = Properties.Resources.kirmizibas;
                if (JOKER == false)
                {
                    Program.sescal("fail.wav");
                    if (cevapCLbl.Text == islemsonucu.ToString()) pC.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapALbl.Text == islemsonucu.ToString()) pA.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapDLbl.Text == islemsonucu.ToString()) pD.BackgroundImage = Properties.Resources.yesilbas;
                }

            }

            if (OyunSonuMu() == false)
            {
                if (JOKER == false)
                {
                    yeniSoru x = new yeniSoru();
                    x.ShowDialog();
                    yeniSoru();
                }
                else JOKER = false;
            }
        }

        private void pC_Click(object sender, EventArgs e)
        {
            if (cevapCLbl.Text == islemsonucu.ToString())
            {
                pC.BackgroundImage = Properties.Resources.yesilbas;
                skor += 10;
                skorLbl.Text = skor.ToString();
                JOKER = false;
                Program.sescal("correct.wav");
            }
            else
            {

                pC.BackgroundImage = Properties.Resources.kirmizibas;
                if (JOKER == false)
                {
                    Program.sescal("fail.wav");
                    if (cevapBLbl.Text == islemsonucu.ToString()) pB.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapALbl.Text == islemsonucu.ToString()) pA.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapDLbl.Text == islemsonucu.ToString()) pD.BackgroundImage = Properties.Resources.yesilbas;
                }

            }

            if (OyunSonuMu() == false)
            {
                if (JOKER == false)
                {
                    yeniSoru x = new yeniSoru();
                    x.ShowDialog();
                    yeniSoru();
                }
                else JOKER = false;
            }
        }

        private void pD_Click(object sender, EventArgs e)
        {
            if (cevapDLbl.Text == islemsonucu.ToString())
            {
                pD.BackgroundImage = Properties.Resources.yesilbas;
                skor += 10;
                skorLbl.Text = skor.ToString();
                JOKER = false;
                Program.sescal("correct.wav");
            }
            else
            {

                pD.BackgroundImage = Properties.Resources.kirmizibas;
                if (JOKER == false)
                {
                    Program.sescal("fail.wav");
                    if (cevapBLbl.Text == islemsonucu.ToString()) pB.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapALbl.Text == islemsonucu.ToString()) pA.BackgroundImage = Properties.Resources.yesilbas;
                    if (cevapCLbl.Text == islemsonucu.ToString()) pC.BackgroundImage = Properties.Resources.yesilbas;
                }

            }

            if (OyunSonuMu() == false)
            {
                if (JOKER == false)
                {
                    yeniSoru x = new yeniSoru();
                    x.ShowDialog();
                    yeniSoru();
                }
                else JOKER = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (islemsonucu.ToString() == cevapALbl.Text)
            {
                cevapBLbl.Text = "";
                cevapDLbl.Text = "";
            }
            else if (islemsonucu.ToString() == cevapBLbl.Text)
            {
                cevapALbl.Text = "";
                cevapCLbl.Text = "";
            }
            else if (islemsonucu.ToString() == cevapCLbl.Text)
            {
                cevapBLbl.Text = "";
                cevapDLbl.Text = "";
            }
            else if (islemsonucu.ToString() == cevapDLbl.Text)
            {
                cevapALbl.Text = "";
                cevapCLbl.Text = "";
            }
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            JOKER = true;
            MessageBox.Show("Şimdi 2 kez cevap verebilirsiniz..");
            pictureBox3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zaman <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti!");
            }
            else
            {
                zaman--;
                zamanLbl.Text = zaman.ToString();
                Program.sure++;
            }
        }





    }
}

