namespace VeriTabani
{
    partial class IslemSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemSec));
            this.VeriEkle = new System.Windows.Forms.Button();
            this.VeriGuncelle = new System.Windows.Forms.Button();
            this.VeriSil = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VeriEkle
            // 
            this.VeriEkle.Location = new System.Drawing.Point(12, 3);
            this.VeriEkle.Name = "VeriEkle";
            this.VeriEkle.Size = new System.Drawing.Size(219, 53);
            this.VeriEkle.TabIndex = 0;
            this.VeriEkle.Text = "İlan Ekle / Araba Ekle";
            this.VeriEkle.UseVisualStyleBackColor = true;
            this.VeriEkle.Click += new System.EventHandler(this.VeriEkle_Click);
            // 
            // VeriGuncelle
            // 
            this.VeriGuncelle.Location = new System.Drawing.Point(12, 62);
            this.VeriGuncelle.Name = "VeriGuncelle";
            this.VeriGuncelle.Size = new System.Drawing.Size(219, 53);
            this.VeriGuncelle.TabIndex = 1;
            this.VeriGuncelle.Text = "İlan Güncelle";
            this.VeriGuncelle.UseVisualStyleBackColor = true;
            this.VeriGuncelle.Click += new System.EventHandler(this.VeriGuncelle_Click);
            // 
            // VeriSil
            // 
            this.VeriSil.Location = new System.Drawing.Point(12, 186);
            this.VeriSil.Name = "VeriSil";
            this.VeriSil.Size = new System.Drawing.Size(219, 53);
            this.VeriSil.TabIndex = 2;
            this.VeriSil.Text = "İlan Sil / Araba Sil";
            this.VeriSil.UseVisualStyleBackColor = true;
            this.VeriSil.Click += new System.EventHandler(this.VeriSil_Click);
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(12, 121);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(219, 53);
            this.Listele.TabIndex = 3;
            this.Listele.Text = "Ara";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // IslemSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 540);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.VeriSil);
            this.Controls.Add(this.VeriGuncelle);
            this.Controls.Add(this.VeriEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IslemSec";
            this.Text = "İşlem Seç";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VeriEkle;
        private System.Windows.Forms.Button VeriGuncelle;
        private System.Windows.Forms.Button VeriSil;
        private System.Windows.Forms.Button Listele;
    }
}