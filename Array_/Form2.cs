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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] arabalar = { "Mercedes", "Ford", "Ferrari", "Bugatti", "Lamborghini", "Audi", "Seat", "Honda", "Alfa Romeo" };

        private void btnSonElemaniGoster_Click(object sender, EventArgs e)
        {
            //Dizinin eleman sayısını bilmiyoruz, ancak bizden istenen son elemanı kullaniciya gostermek...
            //arabalar.Length => ilgili dizinin uzunlugunu alabilirsiniz..

            MessageBox.Show("Dizi içerisinde yer alan toplam araba sayısı : " + arabalar.Length);
            MessageBox.Show(arabalar[arabalar.Length - 1]);
        }


        Random rnd = new Random();
        private void btnRastgeleEleman_Click(object sender, EventArgs e)
        {
            //Rastgele olarak dizinin bir elemani, formun tepesine yazdırılsın... 
            this.Text = arabalar[rnd.Next(0, arabalar.Length)];
        }


        int[] sayilar = { 10, 20, 30, 40, 50 };
        int index = 0;
        int toplam = 0;
        private void btnElemanlariListboxaEkle_Click(object sender, EventArgs e)
        {

            //listBox1.Items.Add("");

            //Butona her bastigimda, ilk elemandan baslayarak sirasi ile dizinin tum elemanlarini listbox'a ekleyiniz.
            //ancak, eklediginiz her elemani da bir havuzda toplayarak anlik olarak elemanlarin toplamini tepeye yazdiriniz..

            if (index < sayilar.Length)
            {
                listBox1.Items.Add(sayilar[index]);
               
                toplam += sayilar[index];
                this.Text = toplam.ToString();
                index++;
            }
            else
            {
                MessageBox.Show("Dizinin son elemanını ekledin");
            }
        }
    }
}
