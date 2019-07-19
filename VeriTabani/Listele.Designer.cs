namespace VeriTabani
{
    partial class Listele
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
            this.IlanG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckSehir = new System.Windows.Forms.CheckBox();
            this.CheckRenk = new System.Windows.Forms.CheckBox();
            this.CheckMarka = new System.Windows.Forms.CheckBox();
            this.CheckModel = new System.Windows.Forms.CheckBox();
            this.CheckFiyat = new System.Windows.Forms.CheckBox();
            this.MaxFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckKm = new System.Windows.Forms.CheckBox();
            this.MinKm = new System.Windows.Forms.TextBox();
            this.MaxKm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckVites = new System.Windows.Forms.CheckBox();
            this.CheckYakit = new System.Windows.Forms.CheckBox();
            this.CheckTarih = new System.Windows.Forms.CheckBox();
            this.CheckIlanAdı = new System.Windows.Forms.CheckBox();
            this.IlanAdi = new System.Windows.Forms.TextBox();
            this.Sehir = new System.Windows.Forms.TextBox();
            this.Renk = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Vites = new System.Windows.Forms.TextBox();
            this.Yakit = new System.Windows.Forms.TextBox();
            this.Sıralamabox = new System.Windows.Forms.ComboBox();
            this.Tarih = new System.Windows.Forms.ComboBox();
            this.MinFiyat = new System.Windows.Forms.TextBox();
            this.Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).BeginInit();
            this.SuspendLayout();
            // 
            // IlanG
            // 
            this.IlanG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlanG.Location = new System.Drawing.Point(11, 182);
            this.IlanG.Name = "IlanG";
            this.IlanG.RowTemplate.Height = 24;
            this.IlanG.Size = new System.Drawing.Size(1548, 289);
            this.IlanG.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1462, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckSehir
            // 
            this.CheckSehir.AutoSize = true;
            this.CheckSehir.Location = new System.Drawing.Point(11, 0);
            this.CheckSehir.Name = "CheckSehir";
            this.CheckSehir.Size = new System.Drawing.Size(63, 21);
            this.CheckSehir.TabIndex = 7;
            this.CheckSehir.Text = "Şehir";
            this.CheckSehir.UseVisualStyleBackColor = true;
            // 
            // CheckRenk
            // 
            this.CheckRenk.AutoSize = true;
            this.CheckRenk.Location = new System.Drawing.Point(140, 0);
            this.CheckRenk.Name = "CheckRenk";
            this.CheckRenk.Size = new System.Drawing.Size(63, 21);
            this.CheckRenk.TabIndex = 8;
            this.CheckRenk.Text = "Renk";
            this.CheckRenk.UseVisualStyleBackColor = true;
            // 
            // CheckMarka
            // 
            this.CheckMarka.AutoSize = true;
            this.CheckMarka.Location = new System.Drawing.Point(288, 0);
            this.CheckMarka.Name = "CheckMarka";
            this.CheckMarka.Size = new System.Drawing.Size(69, 21);
            this.CheckMarka.TabIndex = 9;
            this.CheckMarka.Text = "Marka";
            this.CheckMarka.UseVisualStyleBackColor = true;
            // 
            // CheckModel
            // 
            this.CheckModel.AutoSize = true;
            this.CheckModel.Location = new System.Drawing.Point(437, 0);
            this.CheckModel.Name = "CheckModel";
            this.CheckModel.Size = new System.Drawing.Size(68, 21);
            this.CheckModel.TabIndex = 15;
            this.CheckModel.Text = "Model";
            this.CheckModel.UseVisualStyleBackColor = true;
            // 
            // CheckFiyat
            // 
            this.CheckFiyat.AutoSize = true;
            this.CheckFiyat.Location = new System.Drawing.Point(644, 0);
            this.CheckFiyat.Name = "CheckFiyat";
            this.CheckFiyat.Size = new System.Drawing.Size(60, 21);
            this.CheckFiyat.TabIndex = 16;
            this.CheckFiyat.Text = "Fiyat";
            this.CheckFiyat.UseVisualStyleBackColor = true;
            // 
            // MaxFiyat
            // 
            this.MaxFiyat.Location = new System.Drawing.Point(677, 27);
            this.MaxFiyat.Name = "MaxFiyat";
            this.MaxFiyat.Size = new System.Drawing.Size(84, 22);
            this.MaxFiyat.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Max";
            // 
            // CheckKm
            // 
            this.CheckKm.AutoSize = true;
            this.CheckKm.Location = new System.Drawing.Point(822, 0);
            this.CheckKm.Name = "CheckKm";
            this.CheckKm.Size = new System.Drawing.Size(89, 21);
            this.CheckKm.TabIndex = 22;
            this.CheckKm.Text = "KiloMetre";
            this.CheckKm.UseVisualStyleBackColor = true;
            // 
            // MinKm
            // 
            this.MinKm.Location = new System.Drawing.Point(782, 27);
            this.MinKm.Name = "MinKm";
            this.MinKm.Size = new System.Drawing.Size(83, 22);
            this.MinKm.TabIndex = 24;
            // 
            // MaxKm
            // 
            this.MaxKm.Location = new System.Drawing.Point(871, 27);
            this.MaxKm.Name = "MaxKm";
            this.MaxKm.Size = new System.Drawing.Size(84, 22);
            this.MaxKm.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(809, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(895, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Max";
            // 
            // CheckVites
            // 
            this.CheckVites.AutoSize = true;
            this.CheckVites.Location = new System.Drawing.Point(977, 0);
            this.CheckVites.Name = "CheckVites";
            this.CheckVites.Size = new System.Drawing.Size(95, 21);
            this.CheckVites.TabIndex = 28;
            this.CheckVites.Text = "Vites Türü";
            this.CheckVites.UseVisualStyleBackColor = true;
            // 
            // CheckYakit
            // 
            this.CheckYakit.AutoSize = true;
            this.CheckYakit.Location = new System.Drawing.Point(1122, 0);
            this.CheckYakit.Name = "CheckYakit";
            this.CheckYakit.Size = new System.Drawing.Size(95, 21);
            this.CheckYakit.TabIndex = 31;
            this.CheckYakit.Text = "Yakıt Türü";
            this.CheckYakit.UseVisualStyleBackColor = true;
            // 
            // CheckTarih
            // 
            this.CheckTarih.AutoSize = true;
            this.CheckTarih.Location = new System.Drawing.Point(1273, 0);
            this.CheckTarih.Name = "CheckTarih";
            this.CheckTarih.Size = new System.Drawing.Size(92, 21);
            this.CheckTarih.TabIndex = 34;
            this.CheckTarih.Text = "İlan Tarihi";
            this.CheckTarih.UseVisualStyleBackColor = true;
            // 
            // CheckIlanAdı
            // 
            this.CheckIlanAdı.AutoSize = true;
            this.CheckIlanAdı.Location = new System.Drawing.Point(1433, 0);
            this.CheckIlanAdı.Name = "CheckIlanAdı";
            this.CheckIlanAdı.Size = new System.Drawing.Size(76, 21);
            this.CheckIlanAdı.TabIndex = 36;
            this.CheckIlanAdı.Text = "İlan Adı";
            this.CheckIlanAdı.UseVisualStyleBackColor = true;
            // 
            // IlanAdi
            // 
            this.IlanAdi.Location = new System.Drawing.Point(1433, 25);
            this.IlanAdi.Name = "IlanAdi";
            this.IlanAdi.Size = new System.Drawing.Size(126, 22);
            this.IlanAdi.TabIndex = 37;
            // 
            // Sehir
            // 
            this.Sehir.Location = new System.Drawing.Point(12, 27);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(108, 22);
            this.Sehir.TabIndex = 38;
            // 
            // Renk
            // 
            this.Renk.Location = new System.Drawing.Point(140, 27);
            this.Renk.Name = "Renk";
            this.Renk.Size = new System.Drawing.Size(126, 22);
            this.Renk.TabIndex = 39;
            // 
            // Marka
            // 
            this.Marka.Location = new System.Drawing.Point(288, 27);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(126, 22);
            this.Marka.TabIndex = 40;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(437, 27);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(126, 22);
            this.Model.TabIndex = 41;
            // 
            // Vites
            // 
            this.Vites.Location = new System.Drawing.Point(977, 27);
            this.Vites.Name = "Vites";
            this.Vites.Size = new System.Drawing.Size(126, 22);
            this.Vites.TabIndex = 42;
            // 
            // Yakit
            // 
            this.Yakit.Location = new System.Drawing.Point(1122, 27);
            this.Yakit.Name = "Yakit";
            this.Yakit.Size = new System.Drawing.Size(126, 22);
            this.Yakit.TabIndex = 43;
            // 
            // Sıralamabox
            // 
            this.Sıralamabox.FormattingEnabled = true;
            this.Sıralamabox.Items.AddRange(new object[] {
            "Markaya Göre a-z",
            "Markaya Göre z-a",
            "Fiyata Göre Artan",
            "Fiyata Göre Azalan",
            "Kilometreye Göre Artan",
            "Kilometreye Göre Azalan"});
            this.Sıralamabox.Location = new System.Drawing.Point(675, 104);
            this.Sıralamabox.Name = "Sıralamabox";
            this.Sıralamabox.Size = new System.Drawing.Size(190, 24);
            this.Sıralamabox.TabIndex = 45;
            this.Sıralamabox.Text = "Sıralama";
            // 
            // Tarih
            // 
            this.Tarih.FormattingEnabled = true;
            this.Tarih.Items.AddRange(new object[] {
            "",
            "Son 24 Saat",
            "Son 1 Hafta",
            "Son 1 Ay"});
            this.Tarih.Location = new System.Drawing.Point(1273, 25);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(126, 24);
            this.Tarih.TabIndex = 46;
            // 
            // MinFiyat
            // 
            this.MinFiyat.Location = new System.Drawing.Point(582, 27);
            this.MinFiyat.Name = "MinFiyat";
            this.MinFiyat.Size = new System.Drawing.Size(89, 22);
            this.MinFiyat.TabIndex = 47;
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(1462, 493);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(75, 23);
            this.Geri.TabIndex = 48;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 519);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.MinFiyat);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Sıralamabox);
            this.Controls.Add(this.Yakit);
            this.Controls.Add(this.Vites);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.Renk);
            this.Controls.Add(this.Sehir);
            this.Controls.Add(this.IlanAdi);
            this.Controls.Add(this.CheckIlanAdı);
            this.Controls.Add(this.CheckTarih);
            this.Controls.Add(this.CheckYakit);
            this.Controls.Add(this.CheckVites);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MaxKm);
            this.Controls.Add(this.MinKm);
            this.Controls.Add(this.CheckKm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaxFiyat);
            this.Controls.Add(this.CheckFiyat);
            this.Controls.Add(this.CheckModel);
            this.Controls.Add(this.CheckMarka);
            this.Controls.Add(this.CheckRenk);
            this.Controls.Add(this.CheckSehir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IlanG);
            this.Name = "Listele";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IlanG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckSehir;
        private System.Windows.Forms.CheckBox CheckRenk;
        private System.Windows.Forms.CheckBox CheckMarka;
        private System.Windows.Forms.CheckBox CheckModel;
        private System.Windows.Forms.CheckBox CheckFiyat;
        private System.Windows.Forms.TextBox MaxFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CheckKm;
        private System.Windows.Forms.TextBox MinKm;
        private System.Windows.Forms.TextBox MaxKm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CheckVites;
        private System.Windows.Forms.CheckBox CheckYakit;
        private System.Windows.Forms.CheckBox CheckTarih;
        private System.Windows.Forms.CheckBox CheckIlanAdı;
        private System.Windows.Forms.TextBox IlanAdi;
        private System.Windows.Forms.TextBox Sehir;
        private System.Windows.Forms.TextBox Renk;
        private System.Windows.Forms.TextBox Marka;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Vites;
        private System.Windows.Forms.TextBox Yakit;
        private System.Windows.Forms.ComboBox Sıralamabox;
        private System.Windows.Forms.ComboBox Tarih;
        private System.Windows.Forms.TextBox MinFiyat;
        private System.Windows.Forms.Button Geri;
    }
}