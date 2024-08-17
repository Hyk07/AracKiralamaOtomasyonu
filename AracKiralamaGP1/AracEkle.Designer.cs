namespace AracKiralamaGP1
{
    partial class AracEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtAracID = new TextBox();
            txtPlaka = new TextBox();
            txtYil = new TextBox();
            txtRenk = new TextBox();
            txtKilometre = new TextBox();
            txtKiraUcreti = new TextBox();
            cbxMarka = new ComboBox();
            cbxModel = new ComboBox();
            cbxYakit = new ComboBox();
            cbxDurumu = new ComboBox();
            btnAracKaydet = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "AraçID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "Plaka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "Marka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 0;
            label5.Text = "Yıl:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 182);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 0;
            label6.Text = "Renk:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 214);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 0;
            label7.Text = "Kilometre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 278);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 0;
            label8.Text = "Kira Ücreti:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 246);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 0;
            label9.Text = "Yakıt:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 310);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 0;
            label10.Text = "Durumu:";
            // 
            // txtAracID
            // 
            txtAracID.Enabled = false;
            txtAracID.Location = new Point(155, 19);
            txtAracID.Name = "txtAracID";
            txtAracID.Size = new Size(166, 27);
            txtAracID.TabIndex = 1;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(155, 51);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(166, 27);
            txtPlaka.TabIndex = 2;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(155, 147);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(166, 27);
            txtYil.TabIndex = 3;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(155, 179);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(166, 27);
            txtRenk.TabIndex = 4;
            // 
            // txtKilometre
            // 
            txtKilometre.Location = new Point(155, 211);
            txtKilometre.Name = "txtKilometre";
            txtKilometre.Size = new Size(166, 27);
            txtKilometre.TabIndex = 5;
            // 
            // txtKiraUcreti
            // 
            txtKiraUcreti.Location = new Point(155, 275);
            txtKiraUcreti.Name = "txtKiraUcreti";
            txtKiraUcreti.Size = new Size(166, 27);
            txtKiraUcreti.TabIndex = 6;
            // 
            // cbxMarka
            // 
            cbxMarka.FormattingEnabled = true;
            cbxMarka.Items.AddRange(new object[] { "Mercedes", "BMW", "Audi", "Volvo" });
            cbxMarka.Location = new Point(155, 83);
            cbxMarka.Name = "cbxMarka";
            cbxMarka.Size = new Size(166, 28);
            cbxMarka.TabIndex = 7;
            cbxMarka.SelectedIndexChanged += cbxMarka_SelectedIndexChanged;
            // 
            // cbxModel
            // 
            cbxModel.FormattingEnabled = true;
            cbxModel.Location = new Point(155, 115);
            cbxModel.Name = "cbxModel";
            cbxModel.Size = new Size(166, 28);
            cbxModel.TabIndex = 8;
            // 
            // cbxYakit
            // 
            cbxYakit.FormattingEnabled = true;
            cbxYakit.Items.AddRange(new object[] { "Benzin", "Dizel", "LPG", "Benzin / LPG" });
            cbxYakit.Location = new Point(155, 243);
            cbxYakit.Name = "cbxYakit";
            cbxYakit.Size = new Size(166, 28);
            cbxYakit.TabIndex = 9;
            // 
            // cbxDurumu
            // 
            cbxDurumu.FormattingEnabled = true;
            cbxDurumu.Items.AddRange(new object[] { "Dolu", "Boş" });
            cbxDurumu.Location = new Point(155, 307);
            cbxDurumu.Name = "cbxDurumu";
            cbxDurumu.Size = new Size(166, 28);
            cbxDurumu.TabIndex = 10;
            // 
            // btnAracKaydet
            // 
            btnAracKaydet.Image = Properties.Resources.pngwing_com__22_;
            btnAracKaydet.Location = new Point(261, 350);
            btnAracKaydet.Name = "btnAracKaydet";
            btnAracKaydet.Size = new Size(60, 62);
            btnAracKaydet.TabIndex = 11;
            btnAracKaydet.UseVisualStyleBackColor = true;
            btnAracKaydet.Click += btnAracKaydet_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.pngwing_com__3_;
            button2.Location = new Point(12, 402);
            button2.Name = "button2";
            button2.Size = new Size(65, 40);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AracEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(338, 451);
            Controls.Add(button2);
            Controls.Add(btnAracKaydet);
            Controls.Add(cbxDurumu);
            Controls.Add(cbxYakit);
            Controls.Add(cbxModel);
            Controls.Add(cbxMarka);
            Controls.Add(txtKiraUcreti);
            Controls.Add(txtKilometre);
            Controls.Add(txtRenk);
            Controls.Add(txtYil);
            Controls.Add(txtPlaka);
            Controls.Add(txtAracID);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "AracEkle";
            Text = "AracEkle";
            Load += AracEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtAracID;
        private TextBox txtPlaka;
        private TextBox txtYil;
        private TextBox txtRenk;
        private TextBox txtKilometre;
        private TextBox txtKiraUcreti;
        private ComboBox cbxMarka;
        private ComboBox cbxModel;
        private ComboBox cbxYakit;
        private ComboBox cbxDurumu;
        private Button btnAracKaydet;
        private Button button2;
    }
}