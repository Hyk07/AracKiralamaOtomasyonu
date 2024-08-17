namespace AracKiralamaGP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMuseteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm = new MusteriEkle();
            musterieklefrm.ShowDialog();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele musterilistelefrm = new MusteriListele();
            musterilistelefrm.ShowDialog();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm = new AracEkle();
            araceklefrm.ShowDialog();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele();
            araclistelefrm.ShowDialog();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            Sozlesme sozlesmefrm = new Sozlesme();
            sozlesmefrm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            Satislar satislarfrm = new Satislar();
            satislarfrm.ShowDialog();
        }
    }
}