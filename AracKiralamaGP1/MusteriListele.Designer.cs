namespace AracKiralamaGP1
{
    partial class MusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListele));
            richTextBox1 = new RichTextBox();
            btnKaydet = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, -2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1200, 384);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnKaydet
            // 
            btnKaydet.Image = Properties.Resources.pngwing_com__25_;
            btnKaydet.Location = new Point(1207, 329);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(58, 53);
            btnKaydet.TabIndex = 3;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.pngwing_com__3_;
            button2.Location = new Point(12, 396);
            button2.Name = "button2";
            button2.Size = new Size(74, 39);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1238, 45);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Arama yap";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1207, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 19;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1067, 388);
            button4.Name = "button4";
            button4.Size = new Size(57, 48);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(1144, 388);
            button5.Name = "button5";
            button5.Size = new Size(57, 48);
            button5.TabIndex = 21;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MusteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1340, 447);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnKaydet);
            Controls.Add(richTextBox1);
            Name = "MusteriListele";
            Text = "MusteriListele";
            Load += MusteriListele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label6;
        private TextBox txtTC;
        private Label label4;
        private TextBox txtMail;
        private Label label2;
        private Label label5;
        private TextBox txtAdSyd;
        private Label label3;
        private TextBox txtID;
        private Label label1;
        private Button btnKaydet;
        private Button button1;
        private Button button2;
        private MaskedTextBox txtTel;
        private TextBox txtAdres;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
    }
}