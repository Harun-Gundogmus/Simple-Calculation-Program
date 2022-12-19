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
    public partial class tekCift : Form
    {
        public tekCift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 % 2 == 0)
                MessageBox.Show("Sayı çift", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Sayı tek", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string ekle = txt_Ekle.Text;
            lbox_Ekle.Items.Add(ekle);
            txt_Ekle.Clear();
        }
         
        private void btn_Kaldir_Click(object sender, EventArgs e)
        {
            lbox_Ekle.Items.RemoveAt(lbox_Ekle.Items.Count - 1);
            lbox_Ekle.Show();
        }

        private void btn_FormDegistir_Click(object sender, EventArgs e)
        {
            OrtveAlanHesaplama ortveAlan = new OrtveAlanHesaplama();
            ortveAlan.Show();
            this.Hide();
        }

        private void tekCift_Load(object sender, EventArgs e)
        {
            
        }
    }
}
