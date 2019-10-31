using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Array - Dizi
        // Birden fazla aynı tipdeki değerleri bir arada tutma

        private void btnDizi_Click(object sender, EventArgs e)
        {
            // 1 Tanımlama yöntemi
            // veriTipi[] diziAdi = new veriTipi[Eleman sayısı(dizi kaç elemanlı bir dizi olacak)];

            int[] sayilar = new int[5];
            sayilar[4] = 10;
            sayilar[1] = 20;
            sayilar[0] = 30;
            sayilar[2] = 40;
            sayilar[3] = 50;

            // 'Index was outside the bounds of the array.' dizinin alabileceğinden fazla eleman ekleme durumu
            //sayilar[5] = 60;
            //  0 = 30
            //  1 = 20
            //  2 = 40
            //  3 = 50
            //  4 = 10


            // 2. Tanımlama yöntemi 
            // veriTipi[] diziAdi = new veriTipi[eleman sayısı]{dizinin elemanları (,)}
            string[] sehirler = new string[5] {
                "ankara",  // 0 
                "edirne",  // 1
                "istanbul",// 2
                "bursa",   // 3
                "tekirdağ" // 4 (dizinin en son elemanı, dizinin eleman sayısı - 1'dir
            };

            string sehir = sehirler[4];


            // 3. Tanımlama yöntemi
            // veriTipi[] diziAdi =  {dizinin elemanları(,)}
            char[] karakterler = { 'a', 'A', 'b', 'B' };
            karakterler[0] = 'c';
            karakterler[1] = 'C';

            char gelen_karakter = karakterler[0];
        }
    }
}
