using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaGP1
{
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }
        public void Satislistele()
        {
            string adres = "E://Satis.txt";
            string oku = File.ReadAllText(adres);
            richTextBox1.Text = oku;

        }
        private void Satislar_Load(object sender, EventArgs e)
        {
            Satislistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adres = "E://Satis.txt";
            StreamWriter yaz = new StreamWriter(adres);
            yaz.Write(richTextBox1.Text);
            yaz.Close();
            MessageBox.Show("Müşteri Başarıyla Güncellendi");
        }
    }
}
