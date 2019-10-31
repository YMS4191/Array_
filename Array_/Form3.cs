using System;
using System.Windows.Forms;

namespace Array_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] sehirler = { "istanbul", "edirne", "ankara", "eskişehir", "bursa", "konya", "trabzon", "eskişehir", "sivas" };
        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(sehirler, 0, 5);
            // 1. Parametre, İşlem yapılacak olan diziyi ister (veri tipi önemli değildir)
            // 2. Parametre, başlangıç index değeri
            // 3. Parametre, silinecek olan eleman sayısı

            Array.Clear(sehirler, 0, sehirler.Length); // dizinin tüm elemanlarını temizler 
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Array.Copy() => dizi içerisinden belirli bir alanı kopyalayıp almak için kullanılır.,
            string[] kopyaArray = new string[5];

            //Array.Copy(sehirler, kopyaArray, 3); 
            // (0. index değerinden başlayarak kopyalama yapar)

            // 1. Parametre, Verilerin kopyalanacağı kaynak dizi
            // 2. Parametre, Verilerin ekleneceği hedef dizi
            // 3. Parametre, kopyalanacak olan eleman sayısı


            Array.Copy(sehirler, 2, kopyaArray, 2, 3);

            // 1. Parametre, Verilerin kopyalanacağı kaynak dizi
            // 2. Parametre, Kaynak dizinin kaçıncı index değerinden kopyalamaya başlanacağı
            // 3. Parametre, Verilerin ekleneceği hedef dizi
            // 4. Parametre, Hedef dizinin, kaçıncı index değerinden başlanacağı
            // 5. Parametre, Toplamda, kaynak diziden hedef diziye kaç eleman kopyalanacağı
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //Array.IndexOf() => dizi içerisinde aradığınız elemanın index değerini teslim eder. eğer eleman var ise, elemanın index değerini, yok ise -1 değerini teslim eder.
            // NOT : dizi içerisinde aynı eleman var ise, ilk bulduğu elemanın index değerini teslim eder.


            int index = Array.IndexOf(sehirler, txtGelenDeger.Text);
            // 1. Parametre, Kayank dizi
            // 2. Parametre, Kaynak dizinin veri tipine göre aranacak olan eleman



            //MessageBox.Show("Aradığınız index değeri : " + index);
            //MessageBox.Show(string.Format("Aradığınız index değeri : {0}", index));
            //MessageBox.Show($"Aradığınız index değeri : {index}");

            // MessageBox içerisinde eleman var ise,  dizi içerisinde aradığınız eleman bulunmaktadır yok ise aradığınız eleman dizi içerisinde bulunmamamktadır uyarısını verdiriniz.


            //MessageBox.Show(index < 0 ? "Dizi içerisinde eleman bulunmamaktadır" : "Dizi içerisinde eleman bulunmaktadır");
            MessageBox.Show($"Dizi içerisinde eleman bulunma{(index < 0 ? "ma" : "")}ktadır {index}");


            index = Array.IndexOf(sehirler, txtGelenDeger.Text, 2);
            // 1. Parametre, Kayank dizi
            // 2. Parametre, Kaynak dizinin veri tipine göre aranacak olan eleman
            // 3. Parametre, Kaynak dizinin, kaçıncı index değerinden aramaya başlanacak


            index = Array.IndexOf(sehirler, txtGelenDeger.Text, 2, 5);
            // 1. Parametre, Kayank dizi
            // 2. Parametre, Kaynak dizinin veri tipine göre aranacak olan eleman
            // 3. Parametre, Kaynak dizinin, kaçıncı index değerinden aramaya başlanacak
            // 4. Parametre, 3. parametrede verilen index değerinden başlayarak kaç eleman içerisinde arama yapacak.

        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            //Array.LastIndexOf() => dizi içerisinde aradığınız elemanın en son geçtiği yerin index değerini teslim eder. eğer dizi içerisinde birden fazla aynı eleman var ise, en son elemanın index değerini teslim eder. dizi içerisinde aradığınız eleman yok ise -1 değerini teslim eder.

            int index = Array.LastIndexOf(sehirler, txtGelenDeger.Text);
            MessageBox.Show($"Dizi içerisinde eleman bulunma{(index < 0 ? "ma" : "")}ktadır {index}");

        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize<string>(ref sehirler, 90);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Array.Sort() => dizinin içerisinde yer alan elemanları A'dan Z'ye - 0'dan 9'a sıralama işlemi yapar

            Array.Sort(sehirler);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //Array.Reverse() => dizi içerisinde yer alan elemanları, terise çevirir NOT : kesinlikle sıralama yapmaz.
            Array.Reverse(sehirler);
        }
    }
}
