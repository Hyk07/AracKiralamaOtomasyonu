using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AracKiralamaGP1
{
    public partial class Sozlesme : Form
    {
        string connectionword = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\AracEkle.txt\\;Extended Properties=\"text;HDR=Yes;FMT=Fixed\";";
        public Sozlesme()
        {
            InitializeComponent();
        }
        string AracAdres = @"E:/AracEkle.txt";
        string MusteriAdres = @"E:/MusteriEkle.txt";
        string SozlesmeAdres = @"E:/Sozlesme.txt";
        string SatisAdres = @"E:/Satis.txt";
        double price;

        public void sozlesmelistele()
        {
            string adres = SozlesmeAdres;
            string oku = File.ReadAllText(adres);
            richTextBox1.Text = oku;
        }

        private void cbxAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Streamreader = new StreamReader(AracAdres);
            string[] lines = File.ReadAllLines(AracAdres);
            string selectedValue = cbxAraclar.SelectedItem.ToString();
            string selectedLine = "";
            cbxAraclar.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (columns[1] == selectedValue)
                {
                    selectedLine = line;
                    break;
                }

            }
            if (!string.IsNullOrEmpty(selectedLine))
            {
                string[] columns = selectedLine.Split(',');
                txtMarka.Text = columns[2];
                txtModel.Text = columns[3];
                txtYil.Text = columns[4];
                txtRenk.Text = columns[5];
                label18.Text = columns[8];
                txtKiraUcreti.Clear();
                txtGun.Clear();
                txtTutar.Clear();
                price = Convert.ToDouble(columns[8]);
            }


        }


        private void Sozlesme_Load(object sender, EventArgs e)
        {
            var Streamreader = new StreamReader(AracAdres);
            string[] lines = File.ReadAllLines(AracAdres);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (columns[9] == " Boş")
                {
                    cbxAraclar.Items.Add(columns[1]);
                }
            }
            sozlesmelistele();
            richTextBox1.ReadOnly = true;
        }

        private void txtTCara_TextChanged(object sender, EventArgs e)
        {

            var Streamreader = new StreamReader(MusteriAdres);
            string[] lines = File.ReadAllLines(MusteriAdres);
            string selectedLine = "";
            string selectedValue = txtTCara.Text;

            // Seçilen öğeye göre ilgili satırı buluyoruz.
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (columns[1] == selectedValue)
                {
                    selectedLine = line;
                    break;
                }


            }
            if (!string.IsNullOrEmpty(selectedLine))
            {
                string[] columns = selectedLine.Split(',');

                txtTC.Text = columns[1];
                txtAdSoyad.Text = columns[2];
                txtTel.Text = columns[3];
            }
            AracInfo.Enabled = true;
        }

        private void btnKiraHesap_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(dtDonus.Text) - DateTime.Parse(dtCikis.Text);
            int gunhesap = gunfarki.Days;
            txtGun.Text = gunhesap.ToString();
            txtTutar.Text = (gunhesap * int.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void cbxKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxKiraSekli.DropDownStyle = ComboBoxStyle.DropDownList;
            var Streamreader = new StreamReader(AracAdres);
            string[] lines = File.ReadAllLines(AracAdres);

            if (cbxKiraSekli.SelectedIndex == 0)
            {
                txtKiraUcreti.Text = (price * 1).ToString();
            }
            if (cbxKiraSekli.SelectedIndex == 1)
            {
                txtKiraUcreti.Text = (price * 0.80).ToString();
            }
            if (cbxKiraSekli.SelectedIndex == 2)
            {
                txtKiraUcreti.Text = (price * 0.50).ToString();
            }

        }

        private void txtTCara_TextChanged_1(object sender, EventArgs e)
        {
            var Streamreader = new StreamReader(MusteriAdres);
            string[] lines = File.ReadAllLines(MusteriAdres);
            string selectedLine = "";
            string selectedValue = txtTCara.Text;

            // Seçilen öğeye göre ilgili satırı buluyoruz.
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (columns[1] == selectedValue)
                {
                    selectedLine = line;
                    break;
                }


            }
            if (!string.IsNullOrEmpty(selectedLine))
            {
                string[] columns = selectedLine.Split(',');
                txtTC.Text = columns[1];
                txtAdSoyad.Text = columns[2];
                txtTel.Text = columns[3];
            }
            AracInfo.Enabled = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            

            string adres = SozlesmeAdres;
            string[] lines = File.ReadAllLines(adres);

            int lastLineNumber = lines.Length;

            string newLine = $"{lastLineNumber + 1}. " + txtID.Text; // Burada textBox1, girilen veriyi tutan TextBox kontrolüdür.

            using (StreamWriter sw = File.AppendText(adres))
            {
                sw.Write(newLine);
            }


            StreamWriter yaz = File.AppendText(adres);
            yaz.Write(txtID.Text + ", ");
            yaz.Write(txtTC.Text + ", ");
            yaz.Write(txtAdSoyad.Text + ", ");
            yaz.Write(txtTel.Text + ", ");
            yaz.Write(txtEhliyet.Text + ", ");
            yaz.Write(txtEhliyetDt.Text + ", ");
            yaz.Write(cbxAraclar.Text + ", ");
            yaz.Write(txtMarka.Text + ", ");
            yaz.Write(txtModel.Text + ", ");
            yaz.Write(txtYil.Text + ", ");
            yaz.Write(txtRenk.Text + ", ");
            yaz.Write(cbxKiraSekli.Text + ", ");
            yaz.Write(txtKiraUcreti.Text + ", ");
            yaz.Write(dtCikis.Text + ", ");
            yaz.Write(dtDonus.Text + ", ");
            yaz.Write(txtGun.Text + ", ");
            yaz.WriteLine(txtTutar.Text + "");
            yaz.Close();
            MessageBox.Show("Müşteri Başarıyla Eklendi");

            sozlesmelistele();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void btnDuzenleme_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adres = SozlesmeAdres;
            StreamWriter yaz = new StreamWriter(adres);
            yaz.Write(richTextBox1.Text);
            yaz.Close();
            MessageBox.Show("Sözleşme Başarıyla Güncellendi");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //string filePath = SozlesmeAdres;
            //string satis = SatisAdres;

            //// kaynak dosyanın yolu
            //string kaynakDosya =filePath;
            //// hedef dosyanın yolu
            //string hedefDosya = satis;
            //// seçilen satırın indeksi
            //int secilenSatir = Convert.ToInt32(textBox1.Text);

            //// geçici bir liste oluştur
            //List<string> geciciListe = new List<string>();

            //// kaynak dosyadan satırları okuyan StreamReader nesnesi
            //using (StreamReader sr = new StreamReader(kaynakDosya))
            //{
            //    // hedef dosyaya satırları yazan StreamWriter nesnesi
            //    using (StreamWriter sw =File.AppendText(hedefDosya))
            //    {
            //        // satırları oku
            //        int satirNo = 0;
            //        string satir;
            //        while ((satir = sr.ReadLine()) != null)
            //        {
            //            satirNo++;
            //            // seçilen satırın indeksine denk gelen satırı seç
            //            if (satirNo == secilenSatir)
            //            {
            //                // seçilen satırı hedef dosyaya yaz
            //                sw.WriteLine(satir);
            //            }
            //            else
            //            {
            //                // seçilen satır dışındaki satırları geçici listeye ekle
            //                geciciListe.Add(satir);
            //            }
            //        }
            //    }
            //}

            //// kaynak dosyaya yeniden yazmak için StreamWriter nesnesi
            //using (StreamWriter eskiDosya = new StreamWriter(kaynakDosya))
            //{
            //    foreach (string satirGeciciListe in geciciListe)
            //    {
            //        eskiDosya.WriteLine(satirGeciciListe);
            //        MessageBox.Show("Araç Teslimi başarılı bir şekilde yapıldı.");
            //    }
            //}

            //// seçilen satırın eski dosyadan silinmesi
            //List<string> dosyaSatirlari = File.ReadAllLines(kaynakDosya).ToList();


            string filePath = SozlesmeAdres;
            string satis = SatisAdres;
            string sss = File.ReadAllText(filePath);
            int secilenSatir = Convert.ToInt32(textBox1.Text);
            string kaynakDosyaAdi = filePath;
            string hedefDosyaAdi = satis;

            string[] satirlar = File.ReadAllLines(kaynakDosyaAdi);

            using (StreamWriter sw = File.AppendText(hedefDosyaAdi))
            {
                foreach (string satir in satirlar)
                {
                    sw.WriteLine(satir);
                }
            }

            string[] lines = File.ReadAllLines(filePath);

            List<string> newLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i != secilenSatir)
                {
                    newLines.Add(lines[i]);
                }
            }
            //// Dosyaya yeni satırları yazın
            File.WriteAllLines(filePath, newLines);
            MessageBox.Show("Teslim Başarılı");
            sozlesmelistele();

        }

            
        }
    }


