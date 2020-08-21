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
using System.Windows.Forms;

namespace NDPODEV1
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Hasta Giriş Butonuna Basınca
        {
            RandevuAl randevu = new RandevuAl();
            randevu.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)//Doktor Giriş Butonuna Basınca
        {
            DoktorGirisi doktor = new DoktorGirisi();
            doktor.Show();
            this.Hide();
        }

        private void AnaGiris_FormClosed(object sender, FormClosedEventArgs e)//Ana Giriş Kapatma Tuşuna Basılınca
        {
            DialogResult dialog = new DialogResult();//dialog adında nesne üretmek
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);//Kullanıcıya bir uyarı mesajı gösterimi
            if (dialog == DialogResult.Yes)//Tercih eğer evet olursa
            {
                Application.Exit();//Uygulamadan Çıkar
                
            }
            else//Hayır ise
            {
                //MessageBox.Show("Çıkış yapılmadı");
                Application.Run();//Uygulama Devam Eder
            }
        }
    }
}
