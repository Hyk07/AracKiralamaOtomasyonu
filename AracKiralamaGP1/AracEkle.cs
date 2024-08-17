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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0)
            {
                cbxModel.Items.Clear();
                cbxModel.Text = "";
                cbxModel.Items.Add("300SL");
                cbxModel.Items.Add("300D");
                cbxModel.Items.Add("SLR Mclaren");
                cbxModel.Items.Add("190SL");
                cbxModel.Items.Add("540K");
            }
            else if (cbxMarka.SelectedIndex == 1)
            {
                cbxModel.Items.Clear();
                cbxModel.Text = "";
                cbxModel.Items.Add("507");
                cbxModel.Items.Add("M1");
                cbxModel.Items.Add("320D");
                cbxModel.Items.Add("M4");
                cbxModel.Items.Add("M5");
            }
            else if (cbxMarka.SelectedIndex == 2)
            {
                cbxModel.Items.Clear();
                cbxModel.Text = "";
                cbxModel.Items.Add("RS5");
                cbxModel.Items.Add("RS7");
                cbxModel.Items.Add("A4");
                cbxModel.Items.Add("A6");
                cbxModel.Items.Add("A8");
            }
            else if (cbxMarka.SelectedIndex == 3)
            {
                cbxModel.Items.Clear();
                cbxModel.Text = "";
                cbxModel.Items.Add("XC40");
                cbxModel.Items.Add("XC70");
                cbxModel.Items.Add("S60");
                cbxModel.Items.Add("S80");
                cbxModel.Items.Add("V90");
            }
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            string adres = "E://AracEkle.txt";

            string[] lines = File.ReadAllLines(adres);

            int lastLineNumber = lines.Length;

            string newLine = $"{lastLineNumber + 1}. " + txtAracID.Text; // Burada textBox1, girilen veriyi tutan TextBox kontrolüdür.

            using (StreamWriter sw = File.AppendText(adres))
            {
                sw.Write(newLine);
            }


            StreamWriter yaz = File.AppendText(adres);
            yaz.Write(txtAracID.Text + ", ");
            yaz.Write(txtPlaka.Text + ", ");
            yaz.Write(cbxMarka.Text + ", ");
            yaz.Write(cbxModel.Text + ", ");
            yaz.Write(txtYil.Text + ", ");
            yaz.Write(txtRenk.Text + ", ");
            yaz.Write(txtKilometre.Text + ", ");
            yaz.Write(cbxYakit.Text + ", ");
            yaz.Write(txtKiraUcreti.Text + ", ");
            yaz.WriteLine(cbxDurumu.Text);
            yaz.Close();
            MessageBox.Show("Araç Başarıyla Eklendi");

            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                {
                    (nesne as TextBox).Clear();
                    cbxDurumu.Text = "";
                    cbxMarka.Text = "";
                    cbxModel.Text = "";
                    cbxYakit.Text = "";
                }
                txtAracID.Focus();
            }
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
