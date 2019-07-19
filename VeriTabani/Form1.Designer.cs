namespace VeriTabani
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.GirisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Kaydol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // KAdi
            // 
            this.KAdi.Location = new System.Drawing.Point(246, 66);
            this.KAdi.Name = "KAdi";
            this.KAdi.Size = new System.Drawing.Size(149, 22);
            this.KAdi.TabIndex = 2;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(246, 145);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(149, 22);
            this.Sifre.TabIndex = 3;
            // 
            // GirisYap
            // 
            this.GirisYap.Location = new System.Drawing.Point(269, 223);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(97, 41);
            this.GirisYap.TabIndex = 4;
            this.GirisYap.Text = "GirisYap";
            this.GirisYap.UseVisualStyleBackColor = true;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Kaydol
            // 
            this.Kaydol.Location = new System.Drawing.Point(269, 297);
            this.Kaydol.Name = "Kaydol";
            this.Kaydol.Size = new System.Drawing.Size(97, 41);
            this.Kaydol.TabIndex = 6;
            this.Kaydol.Text = "Kaydol";
            this.Kaydol.UseVisualStyleBackColor = true;
            this.Kaydol.Click += new System.EventHandler(this.Kaydol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 511);
            this.Controls.Add(this.Kaydol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisYap);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Button GirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Kaydol;
    }
}

