namespace AracKiralamaGP1
{
    partial class MusteriEkle
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
            btnKaydet = new Button();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtTC = new TextBox();
            label3 = new Label();
            txtAdSyd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMail = new TextBox();
            label6 = new Label();
            button2 = new Button();
            txtTel = new MaskedTextBox();
            txtAdres = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Image = Properties.Resources.pngwing_com__22_;
            btnKaydet.Location = new Point(326, 324);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(58, 63);
            btnKaydet.TabIndex = 0;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Müşteri ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(126, 23);
            txtID.Name = "txtID";
            txtID.Size = new Size(157, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik No:";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(126, 56);
            txtTC.MaxLength = 11;
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(157, 27);
            txtTC.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Ad Soyad:";
            // 
            // txtAdSyd
            // 
            txtAdSyd.Location = new Point(126, 89);
            txtAdSyd.Name = "txtAdSyd";
            txtAdSyd.Size = new Size(157, 27);
            txtAdSyd.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 1;
            label4.Text = "Telefon No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 1;
            label5.Text = "E-mail:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(126, 156);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(157, 27);
            txtMail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 192);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 1;
            label6.Text = "Adres:";
            // 
            // button2
            // 
            button2.Image = Properties.Resources.pngwing_com__3_;
            button2.Location = new Point(12, 373);
            button2.Name = "button2";
            button2.Size = new Size(76, 43);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(126, 122);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(157, 27);
            txtTel.TabIndex = 4;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(124, 192);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(260, 126);
            txtAdres.TabIndex = 5;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(398, 428);
            Controls.Add(txtAdres);
            Controls.Add(txtTel);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(txtTC);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtAdSyd);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Name = "MusteriEkle";
            Text = "MusteriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtTC;
        private Label label3;
        private TextBox txtAdSyd;
        private Label label4;
        private Label label5;
        private TextBox txtMail;
        private Label label6;
        private Button button2;
        private MaskedTextBox txtTel;
        private TextBox txtAdres;
    }
}