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
    public partial class DoktorGirisi : Form
    {
        public DoktorGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Deniz"&&textBox2.Text=="12345")
            {
                DoktorEkranı doktorPanel = new DoktorEkranı();
                doktorPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı veya şifre hatalı");
            }
            
        }

        
        
        private void DoktorGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaGiris anagiris = new AnaGiris();
            anagiris.Show();
            this.Hide();
        }
    }
}
