using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma2
{
    public partial class OrtveAlanHesaplama : Form
    {
        public OrtveAlanHesaplama()
        {
            InitializeComponent();
        }

        private void lbl_Sayiİki_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(tbt_SayiBir.Text);
            int sayi2 = Convert.ToInt32(tbt_SayiIki.Text);
            int ort = (sayi1 + sayi2)/2;
            label2.Text = ort.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            double cembersonuc = 0;
            int kenaruzunluk = Convert.ToInt32(textBox1.Text);
            int kenaruzunluk2 = Convert.ToInt32(textBox2.Text);
            if(checkBox1.Checked && radioButton1.Checked)
            {
                sonuc = kenaruzunluk * kenaruzunluk;
                label3.Text = sonuc.ToString();
            }
            else if (checkBox1.Checked && radioButton2.Checked)
            {
                sonuc = 4 * kenaruzunluk;
                label3.Text = sonuc.ToString();
            }
            else if (checkBox2.Checked && radioButton1.Checked)
            {
                sonuc = kenaruzunluk * kenaruzunluk2;
                label3.Text = sonuc.ToString();
            }
            else if (checkBox2.Checked && radioButton2.Checked)
            {
                sonuc = 2 * (kenaruzunluk + kenaruzunluk2);
                label3.Text = sonuc.ToString();
            }
            else if (checkBox3.Checked && radioButton1.Checked)
            {
                cembersonuc = 3.14 * (kenaruzunluk * kenaruzunluk);
                label3.Text = sonuc.ToString();
            }
            else if (checkBox3.Checked && radioButton2.Checked)
            {
                cembersonuc = 2 * 3.14 * kenaruzunluk;
                label3.Text = sonuc.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_FormDegistir_Click(object sender, EventArgs e)
        {
            tekCift tekCift = new tekCift();
            tekCift.Show();
            this.Hide();
        }
    }
}
