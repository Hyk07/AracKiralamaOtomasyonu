namespace AracKiralamaGP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnMuseteriEkle = new Button();
            btnMusteriListele = new Button();
            btnAracEkle = new Button();
            btnAracListele = new Button();
            btnSozlesme = new Button();
            btnSatislar = new Button();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 575);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnMuseteriEkle
            // 
            btnMuseteriEkle.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMuseteriEkle.Image = Properties.Resources.pngwing_com__2_;
            btnMuseteriEkle.ImageAlign = ContentAlignment.TopCenter;
            btnMuseteriEkle.Location = new Point(7, 12);
            btnMuseteriEkle.Name = "btnMuseteriEkle";
            btnMuseteriEkle.Size = new Size(94, 64);
            btnMuseteriEkle.TabIndex = 1;
            btnMuseteriEkle.Text = "Müşteri Ekle";
            btnMuseteriEkle.TextAlign = ContentAlignment.BottomCenter;
            btnMuseteriEkle.UseVisualStyleBackColor = true;
            btnMuseteriEkle.Click += btnMuseteriEkle_Click;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriListele.Image = Properties.Resources.pngwing_com__8_;
            btnMusteriListele.ImageAlign = ContentAlignment.TopCenter;
            btnMusteriListele.Location = new Point(7, 82);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(94, 64);
            btnMusteriListele.TabIndex = 1;
            btnMusteriListele.Text = "Müşteri liste";
            btnMusteriListele.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriListele.UseVisualStyleBackColor = true;
            btnMusteriListele.Click += btnMusteriListele_Click;
            // 
            // btnAracEkle
            // 
            btnAracEkle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAracEkle.Image = Properties.Resources.pngwing_com__12_;
            btnAracEkle.ImageAlign = ContentAlignment.TopCenter;
            btnAracEkle.Location = new Point(7, 152);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(94, 64);
            btnAracEkle.TabIndex = 1;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.TextAlign = ContentAlignment.BottomCenter;
            btnAracEkle.UseVisualStyleBackColor = true;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // btnAracListele
            // 
            btnAracListele.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAracListele.Image = Properties.Resources.pngwing_com__8_;
            btnAracListele.ImageAlign = ContentAlignment.TopCenter;
            btnAracListele.Location = new Point(7, 222);
            btnAracListele.Name = "btnAracListele";
            btnAracListele.Size = new Size(94, 67);
            btnAracListele.TabIndex = 1;
            btnAracListele.Text = "Araç Listele";
            btnAracListele.TextAlign = ContentAlignment.BottomCenter;
            btnAracListele.UseVisualStyleBackColor = true;
            btnAracListele.Click += btnAracListele_Click;
            // 
            // btnSozlesme
            // 
            btnSozlesme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSozlesme.Image = Properties.Resources.pngwing_com__4_;
            btnSozlesme.ImageAlign = ContentAlignment.TopCenter;
            btnSozlesme.Location = new Point(7, 295);
            btnSozlesme.Name = "btnSozlesme";
            btnSozlesme.Size = new Size(94, 67);
            btnSozlesme.TabIndex = 1;
            btnSozlesme.Text = "Sözleşme";
            btnSozlesme.TextAlign = ContentAlignment.BottomCenter;
            btnSozlesme.UseVisualStyleBackColor = true;
            btnSozlesme.Click += btnSozlesme_Click;
            // 
            // btnSatislar
            // 
            btnSatislar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSatislar.Image = (Image)resources.GetObject("btnSatislar.Image");
            btnSatislar.ImageAlign = ContentAlignment.TopCenter;
            btnSatislar.Location = new Point(7, 368);
            btnSatislar.Name = "btnSatislar";
            btnSatislar.Size = new Size(94, 67);
            btnSatislar.TabIndex = 1;
            btnSatislar.Text = "Satışlar";
            btnSatislar.TextAlign = ContentAlignment.BottomCenter;
            btnSatislar.UseVisualStyleBackColor = true;
            btnSatislar.Click += btnSatislar_Click;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.Image = Properties.Resources.pngwing_com__3_;
            btnCikis.Location = new Point(7, 517);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(72, 45);
            btnCikis.TabIndex = 1;
            btnCikis.TextAlign = ContentAlignment.BottomCenter;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(889, 574);
            Controls.Add(btnCikis);
            Controls.Add(btnSatislar);
            Controls.Add(btnSozlesme);
            Controls.Add(btnAracListele);
            Controls.Add(btnAracEkle);
            Controls.Add(btnMusteriListele);
            Controls.Add(btnMuseteriEkle);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Ana sayfa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMuseteriEkle;
        private Button btnMusteriListele;
        private Button btnAracEkle;
        private Button btnAracListele;
        private Button btnSozlesme;
        private Button btnSatislar;
        private Button btnCikis;
    }
}