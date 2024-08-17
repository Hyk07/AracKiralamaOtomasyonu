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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adres = "E://MusteriEkle.txt";


                string[] lines = File.ReadAllLines(adres);

                int lastLineNumber = lines.Length;

                string newLine = $"{lastLineNumber + 1}. " + txtID.Text; // Burada txtId, girilen veriyi tutan TextBox kontrolüdür.

                using (StreamWriter sw = File.AppendText(adres))
                {
                    sw.Write(newLine);
                }

                StreamWriter yaz = File.AppendText(adres);

                yaz.Write(txtID.Text + ",");
                yaz.Write(txtTC.Text + ",");
                yaz.Write(txtAdSyd.Text + ",");
                yaz.Write(txtTel.Text + ",");
                yaz.Write(txtMail.Text + ",");
                yaz.WriteLine(txtAdres.Text);
                yaz.Close();
                MessageBox.Show("Müşteri Başarıyla Eklendi");
                foreach (Control nesne in this.Controls)
                {
                    if (nesne is TextBox)
                    {
                        (nesne as TextBox).Clear();
                        txtTel.Text = "";
                    }
                    txtID.Focus();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
