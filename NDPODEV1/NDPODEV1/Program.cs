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
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaGiris());
        }
    }
}
