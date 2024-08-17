namespace AracKiralamaGP1
{
    partial class Satislar
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1049, 370);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.pngwing_com__3_;
            button1.Location = new Point(12, 376);
            button1.Name = "button1";
            button1.Size = new Size(74, 38);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Image = Properties.Resources.pngwing_com__25_;
            btnKaydet.Location = new Point(995, 376);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(54, 48);
            btnKaydet.TabIndex = 4;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Satislar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1052, 425);
            Controls.Add(btnKaydet);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Satislar";
            Text = "Satislar";
            Load += Satislar_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button btnKaydet;
    }
}