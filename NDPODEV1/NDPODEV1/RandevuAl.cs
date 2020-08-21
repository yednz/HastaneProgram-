/****************************************************************************
**                  SAKARYA ÜNİVERSİTESİ
**           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**             BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**              NESNEYE DAYALI PROGRAMLAMA DERSİ
**                 2019-2020 YAZ DÖNEMİ
**
**             PROJE NUMARASI.........: 01
**             ÖĞRENCİ ADI............:Yunus Emre Deniz
**             ÖĞRENCİ NUMARASI.......:B171200012
**             DERSİN ALINDIĞI GRUP...: A
****************************************************************************/



using System;
using System.IO;
using System.Windows.Forms;

namespace NDPODEV1
{
    public partial class RandevuAl : Form
    {
        string isim, soyisim, tckimlik, cinsiyet, dogumTarih, randevuTarih, randevuSaati, veri = "";


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isim = textBox1.Text;
                soyisim = textBox2.Text;
                tckimlik = textBox3.Text;
                dogumTarih = dateTimePicker1.Value.Date.ToString();
                randevuTarih = dateTimePicker2.Value.Date.ToString();

                //randevuSaati = (randevuSaati==null) ? null : comboBox1.SelectedItem.ToString();
                randevuSaati = comboBox1.SelectedItem.ToString();
                bool tc = true;

                string dosyaYolu = @"C:\kayitlar.txt";

                StreamReader sw = new StreamReader(dosyaYolu);
                string yazi = sw.ReadToEnd();


                string[] satirlar = yazi.Split('\n');
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string[] sutunlar = satirlar[i].Split('/');
                    if (sutunlar[2] == tckimlik)//tc sütünlarını yazılan tc no ile karşılaştırır
                    {
                        MessageBox.Show("Bu TC Kimlik No ile randevu alınmış");
                        sw.Close();
                        tc = false;
                    }
                    else if (sutunlar[5] == randevuTarih && sutunlar[6] == randevuSaati)//randevu saati ve tarihini karşılaştırır.
                    {
                        MessageBox.Show("Bu randevu dolu.Saati veya tarihi değiştirin");
                        sw.Close();
                        tc = false;
                    }
                }

                sw.Close();


                if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(tckimlik) || string.IsNullOrEmpty(randevuSaati))
                {//randevu alırken boş kalan bi yer varmı diye bakar
                    MessageBox.Show("Hatalı veya Eksik giriş yaptınız1");
                }
                else
                {
                    veri = isim + "/" + soyisim + "/" + tckimlik + "/" + cinsiyet + "/" + dogumTarih + "/" + randevuTarih + "/" + randevuSaati;
                    if (tc)
                    {
                        File.AppendAllText(dosyaYolu, Environment.NewLine + veri);//veriyi txt dosyasına kaydeder
                        MessageBox.Show("Randevu" + randevuTarih + "tarihe" + randevuSaati + "saate alındı");
                    }
                }



            }
            catch//program çalışırken hata olursa 
            {
                MessageBox.Show("Hatalı veya eksik giriş yaptınız2");
            }

        }

        public RandevuAl()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

    }
}
