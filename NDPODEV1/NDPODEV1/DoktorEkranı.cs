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
    public partial class DoktorEkranı : Form
    {
        public DoktorEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuAl randevu = new RandevuAl();
            string dosyaYolu = @"C:\kayitlar.txt";
            StreamReader sw = new StreamReader(dosyaYolu);
            string yazi = sw.ReadToEnd();

            string[] satirlar = yazi.Split('\n');
            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] sutunlar = satirlar[i].Split('/');
                var satir = new ListViewItem(sutunlar);
                listView1.Items.Add(satir);

            }
        }
    }
}
