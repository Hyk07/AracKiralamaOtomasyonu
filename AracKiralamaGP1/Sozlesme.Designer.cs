namespace AracKiralamaGP1
{
    partial class Sozlesme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sozlesme));
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            label19 = new Label();
            txtTCara = new MaskedTextBox();
            txtEhliyetDt = new TextBox();
            txtEhliyet = new TextBox();
            txtTel = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            AracInfo = new GroupBox();
            label18 = new Label();
            btnKiraHesap = new Button();
            dtDonus = new DateTimePicker();
            dtCikis = new DateTimePicker();
            cbxKiraSekli = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtTutar = new TextBox();
            txtKiraUcreti = new TextBox();
            label13 = new Label();
            txtGun = new TextBox();
            label12 = new Label();
            btnEkle = new Button();
            txtRenk = new TextBox();
            txtModel = new TextBox();
            cbxAraclar = new ComboBox();
            txtYil = new TextBox();
            txtMarka = new TextBox();
            label7 = new Label();
            label11 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            btnDuzenle = new Button();
            btnDuzenleme = new Button();
            btnGuncelle = new Button();
            btnCikis = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label20 = new Label();
            groupBox1.SuspendLayout();
            AracInfo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(txtTCara);
            groupBox1.Controls.Add(txtEhliyetDt);
            groupBox1.Controls.Add(txtEhliyet);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTC);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(136, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(143, 27);
            txtID.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(16, 62);
            label19.Name = "label19";
            label19.Size = new Size(80, 20);
            label19.TabIndex = 3;
            label19.Text = "Musteri ID:";
            // 
            // txtTCara
            // 
            txtTCara.Location = new Point(136, 20);
            txtTCara.Mask = "00000000000";
            txtTCara.Name = "txtTCara";
            txtTCara.Size = new Size(143, 27);
            txtTCara.TabIndex = 2;
            txtTCara.ValidatingType = typeof(int);
            txtTCara.TextChanged += txtTCara_TextChanged_1;
            // 
            // txtEhliyetDt
            // 
            txtEhliyetDt.Location = new Point(136, 207);
            txtEhliyetDt.Name = "txtEhliyetDt";
            txtEhliyetDt.Size = new Size(143, 27);
            txtEhliyetDt.TabIndex = 2;
            // 
            // txtEhliyet
            // 
            txtEhliyet.Location = new Point(136, 177);
            txtEhliyet.Name = "txtEhliyet";
            txtEhliyet.Size = new Size(143, 27);
            txtEhliyet.TabIndex = 2;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(136, 147);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(143, 27);
            txtTel.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(136, 117);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(143, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(136, 87);
            txtTC.Name = "txtTC";
            txtTC.ReadOnly = true;
            txtTC.Size = new Size(143, 27);
            txtTC.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 210);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 0;
            label6.Text = "Ehliyet Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 180);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 0;
            label5.Text = "Ehliyet No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 120);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 150);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefon No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "TC No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "TC No ile ara:";
            // 
            // AracInfo
            // 
            AracInfo.Controls.Add(label18);
            AracInfo.Controls.Add(btnKiraHesap);
            AracInfo.Controls.Add(dtDonus);
            AracInfo.Controls.Add(dtCikis);
            AracInfo.Controls.Add(cbxKiraSekli);
            AracInfo.Controls.Add(label16);
            AracInfo.Controls.Add(label17);
            AracInfo.Controls.Add(label15);
            AracInfo.Controls.Add(label14);
            AracInfo.Controls.Add(txtTutar);
            AracInfo.Controls.Add(txtKiraUcreti);
            AracInfo.Controls.Add(label13);
            AracInfo.Controls.Add(txtGun);
            AracInfo.Controls.Add(label12);
            AracInfo.Controls.Add(btnEkle);
            AracInfo.Controls.Add(txtRenk);
            AracInfo.Controls.Add(txtModel);
            AracInfo.Controls.Add(cbxAraclar);
            AracInfo.Controls.Add(txtYil);
            AracInfo.Controls.Add(txtMarka);
            AracInfo.Controls.Add(label7);
            AracInfo.Controls.Add(label11);
            AracInfo.Controls.Add(label8);
            AracInfo.Controls.Add(label10);
            AracInfo.Controls.Add(label9);
            AracInfo.Enabled = false;
            AracInfo.Location = new Point(361, 12);
            AracInfo.Name = "AracInfo";
            AracInfo.Size = new Size(867, 254);
            AracInfo.TabIndex = 1;
            AracInfo.TabStop = false;
            AracInfo.Text = "Araç Bilgileri";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(288, 23);
            label18.Name = "label18";
            label18.Size = new Size(44, 20);
            label18.TabIndex = 27;
            label18.Text = "Ücret";
            // 
            // btnKiraHesap
            // 
            btnKiraHesap.Location = new Point(592, 212);
            btnKiraHesap.Name = "btnKiraHesap";
            btnKiraHesap.Size = new Size(94, 29);
            btnKiraHesap.TabIndex = 26;
            btnKiraHesap.Text = "Hesapla";
            btnKiraHesap.UseVisualStyleBackColor = true;
            btnKiraHesap.Click += btnKiraHesap_Click;
            // 
            // dtDonus
            // 
            dtDonus.Format = DateTimePickerFormat.Short;
            dtDonus.Location = new Point(565, 179);
            dtDonus.Name = "dtDonus";
            dtDonus.Size = new Size(151, 27);
            dtDonus.TabIndex = 24;
            // 
            // dtCikis
            // 
            dtCikis.Format = DateTimePickerFormat.Short;
            dtCikis.Location = new Point(565, 146);
            dtCikis.Name = "dtCikis";
            dtCikis.Size = new Size(151, 27);
            dtCikis.TabIndex = 25;
            // 
            // cbxKiraSekli
            // 
            cbxKiraSekli.FormattingEnabled = true;
            cbxKiraSekli.Items.AddRange(new object[] { "Günlük", "Haftalık", "Aylık" });
            cbxKiraSekli.Location = new Point(565, 15);
            cbxKiraSekli.Name = "cbxKiraSekli";
            cbxKiraSekli.Size = new Size(151, 28);
            cbxKiraSekli.TabIndex = 23;
            cbxKiraSekli.SelectedIndexChanged += cbxKiraSekli_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(474, 18);
            label16.Name = "label16";
            label16.Size = new Size(73, 20);
            label16.TabIndex = 14;
            label16.Text = "Kira Şekli:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(469, 184);
            label17.Name = "label17";
            label17.Size = new Size(93, 20);
            label17.TabIndex = 15;
            label17.Text = "Dönüş Tarihi:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(469, 151);
            label15.Name = "label15";
            label15.Size = new Size(81, 20);
            label15.TabIndex = 16;
            label15.Text = "Çıkış Tarihi:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(474, 81);
            label14.Name = "label14";
            label14.Size = new Size(38, 20);
            label14.TabIndex = 17;
            label14.Text = "Gün:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(565, 113);
            txtTutar.Name = "txtTutar";
            txtTutar.ReadOnly = true;
            txtTutar.Size = new Size(151, 27);
            txtTutar.TabIndex = 20;
            // 
            // txtKiraUcreti
            // 
            txtKiraUcreti.Location = new Point(565, 49);
            txtKiraUcreti.Name = "txtKiraUcreti";
            txtKiraUcreti.ReadOnly = true;
            txtKiraUcreti.Size = new Size(151, 27);
            txtKiraUcreti.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(474, 113);
            label13.Name = "label13";
            label13.Size = new Size(46, 20);
            label13.TabIndex = 18;
            label13.Text = "Tutar:";
            // 
            // txtGun
            // 
            txtGun.Location = new Point(565, 81);
            txtGun.Name = "txtGun";
            txtGun.ReadOnly = true;
            txtGun.Size = new Size(151, 27);
            txtGun.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(474, 49);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 19;
            label12.Text = "Kira Ücreti:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(148, 186);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 35);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(113, 150);
            txtRenk.Name = "txtRenk";
            txtRenk.ReadOnly = true;
            txtRenk.Size = new Size(151, 27);
            txtRenk.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(113, 87);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(151, 27);
            txtModel.TabIndex = 9;
            // 
            // cbxAraclar
            // 
            cbxAraclar.FormattingEnabled = true;
            cbxAraclar.Location = new Point(113, 20);
            cbxAraclar.Name = "cbxAraclar";
            cbxAraclar.Size = new Size(151, 28);
            cbxAraclar.TabIndex = 12;
            cbxAraclar.SelectedIndexChanged += cbxAraclar_SelectedIndexChanged;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(113, 119);
            txtYil.Name = "txtYil";
            txtYil.ReadOnly = true;
            txtYil.Size = new Size(151, 27);
            txtYil.TabIndex = 10;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(113, 55);
            txtMarka.Name = "txtMarka";
            txtMarka.ReadOnly = true;
            txtMarka.Size = new Size(151, 27);
            txtMarka.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 27);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 3;
            label7.Text = "Araçlar:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 154);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 4;
            label11.Text = "Renk:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 123);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 5;
            label8.Text = "Seri Yılı:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 91);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 6;
            label10.Text = "Model:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 58);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 7;
            label9.Text = "Marka";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 272);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1216, 286);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnDuzenle
            // 
            btnDuzenle.Image = (Image)resources.GetObject("btnDuzenle.Image");
            btnDuzenle.Location = new Point(1108, 566);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(57, 48);
            btnDuzenle.TabIndex = 25;
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnDuzenleme
            // 
            btnDuzenleme.Image = (Image)resources.GetObject("btnDuzenleme.Image");
            btnDuzenleme.Location = new Point(1045, 566);
            btnDuzenleme.Name = "btnDuzenleme";
            btnDuzenleme.Size = new Size(57, 47);
            btnDuzenleme.TabIndex = 24;
            btnDuzenleme.UseVisualStyleBackColor = true;
            btnDuzenleme.Click += btnDuzenleme_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = Properties.Resources.pngwing_com__25_;
            btnGuncelle.Location = new Point(1171, 566);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(57, 47);
            btnGuncelle.TabIndex = 26;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnCikis
            // 
            btnCikis.Image = Properties.Resources.pngwing_com__3_;
            btnCikis.Location = new Point(12, 577);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(58, 36);
            btnCikis.TabIndex = 27;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // button1
            // 
            button1.Location = new Point(899, 572);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 28;
            button1.Text = "Araç Teslim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(756, 577);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 29;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(683, 580);
            label20.Name = "label20";
            label20.Size = new Size(67, 20);
            label20.TabIndex = 30;
            label20.Text = "Satış No:";
            // 
            // Sozlesme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1240, 623);
            Controls.Add(label20);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnCikis);
            Controls.Add(btnGuncelle);
            Controls.Add(btnDuzenle);
            Controls.Add(btnDuzenleme);
            Controls.Add(richTextBox1);
            Controls.Add(AracInfo);
            Controls.Add(groupBox1);
            Name = "Sozlesme";
            Text = "Sozlesme";
            Load += Sozlesme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            AracInfo.ResumeLayout(false);
            AracInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox AracInfo;
        private TextBox txtEhliyetDt;
        private TextBox txtEhliyet;
        private TextBox txtTel;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Button btnKiraHesap;
        private DateTimePicker dtDonus;
        private DateTimePicker dtCikis;
        private ComboBox cbxKiraSekli;
        private Label label16;
        private Label label17;
        private Label label15;
        private Label label14;
        private TextBox txtTutar;
        private TextBox txtKiraUcreti;
        private Label label13;
        private TextBox txtGun;
        private Label label12;
        private Button btnEkle;
        private TextBox txtRenk;
        private TextBox txtModel;
        private ComboBox cbxAraclar;
        private TextBox txtYil;
        private TextBox txtMarka;
        private Label label7;
        private Label label11;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label18;
        private MaskedTextBox txtTCara;
        private RichTextBox richTextBox1;
        private Button btnDuzenle;
        private Button btnDuzenleme;
        private Button btnGuncelle;
        private Button btnCikis;
        private Button button1;
        private TextBox txtID;
        private Label label19;
        private TextBox textBox1;
        private Label label20;
    }
}