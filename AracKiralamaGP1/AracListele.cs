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
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        public void araclistele()
        {
            string adres = "E://AracEkle.txt";
            string oku = File.ReadAllText(adres);
            richTextBox1.Text = oku;

        }
        public void boya(string kelime, Color renk, Boolean tamam)
        {
            int textEnd = richTextBox1.TextLength;
            int index = 0;
            int lastIndex = richTextBox1.Text.LastIndexOf(kelime);

            while (index < lastIndex)
            {
                if (tamam)
                {
                    richTextBox1.Find(kelime, index, textEnd, RichTextBoxFinds.WholeWord);
                }
                else
                {
                    richTextBox1.Find(kelime, index, textEnd, RichTextBoxFinds.None);
                }

                richTextBox1.SelectionBackColor = renk;
                index = richTextBox1.Text.IndexOf(kelime, index) + 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            araclistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adres = "E://AracEkle.txt";
            StreamWriter yaz = new StreamWriter(adres);
            yaz.Write(richTextBox1.Text);
            yaz.Close();
            MessageBox.Show("Araç Başarıyla Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boya(textBox1.Text, Color.Green, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }


    }
}
