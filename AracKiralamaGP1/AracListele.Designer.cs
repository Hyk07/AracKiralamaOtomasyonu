namespace AracKiralamaGP1
{
    partial class AracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            richTextBox1 = new RichTextBox();
            btnGuncelle = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            btnRdOnlyAcik = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1200, 385);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = Properties.Resources.pngwing_com__25_;
            btnGuncelle.Location = new Point(1206, 334);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(66, 51);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.pngwing_com__3_;
            button2.Location = new Point(12, 402);
            button2.Name = "button2";
            button2.Size = new Size(73, 37);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1237, 45);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Arama yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1206, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // btnRdOnlyAcik
            // 
            btnRdOnlyAcik.Image = (Image)resources.GetObject("btnRdOnlyAcik.Image");
            btnRdOnlyAcik.Location = new Point(1146, 391);
            btnRdOnlyAcik.Name = "btnRdOnlyAcik";
            btnRdOnlyAcik.Size = new Size(57, 48);
            btnRdOnlyAcik.TabIndex = 23;
            btnRdOnlyAcik.UseVisualStyleBackColor = true;
            btnRdOnlyAcik.Click += button5_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1069, 391);
            button4.Name = "button4";
            button4.Size = new Size(57, 48);
            button4.TabIndex = 22;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AracListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1337, 447);
            Controls.Add(btnRdOnlyAcik);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnGuncelle);
            Controls.Add(richTextBox1);
            Name = "AracListele";
            Text = "AracListele";
            Load += AracListele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnGuncelle;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Button btnRdOnlyAcik;
        private Button button4;
    }
}