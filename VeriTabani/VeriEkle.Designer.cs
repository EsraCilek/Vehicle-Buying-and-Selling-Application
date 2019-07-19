namespace VeriTabani
{
    partial class VeriEkle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ilan = new System.Windows.Forms.TabPage();
            this.Geri = new System.Windows.Forms.Button();
            this.İlanEkle = new System.Windows.Forms.Button();
            this.IlanG = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Sehir = new System.Windows.Forms.ComboBox();
            this.IlanArabaID = new System.Windows.Forms.ComboBox();
            this.KM = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.TextBox();
            this.AD = new System.Windows.Forms.TextBox();
            this.IlanID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Araba = new System.Windows.Forms.TabPage();
            this.Geri1 = new System.Windows.Forms.Button();
            this.ArabaEkle = new System.Windows.Forms.Button();
            this.Renk = new System.Windows.Forms.ComboBox();
            this.Yakit = new System.Windows.Forms.ComboBox();
            this.Vites = new System.Windows.Forms.ComboBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.TextBox();
            this.ArabaID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArabaG = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Ilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).BeginInit();
            this.Araba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArabaG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ilan);
            this.tabControl1.Controls.Add(this.Araba);
            this.tabControl1.Location = new System.Drawing.Point(67, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // Ilan
            // 
            this.Ilan.Controls.Add(this.Geri);
            this.Ilan.Controls.Add(this.İlanEkle);
            this.Ilan.Controls.Add(this.IlanG);
            this.Ilan.Controls.Add(this.dateTimePicker1);
            this.Ilan.Controls.Add(this.Sehir);
            this.Ilan.Controls.Add(this.IlanArabaID);
            this.Ilan.Controls.Add(this.KM);
            this.Ilan.Controls.Add(this.Fiyat);
            this.Ilan.Controls.Add(this.AD);
            this.Ilan.Controls.Add(this.IlanID);
            this.Ilan.Controls.Add(this.label13);
            this.Ilan.Controls.Add(this.label12);
            this.Ilan.Controls.Add(this.label11);
            this.Ilan.Controls.Add(this.label10);
            this.Ilan.Controls.Add(this.label9);
            this.Ilan.Controls.Add(this.label8);
            this.Ilan.Controls.Add(this.label7);
            this.Ilan.Location = new System.Drawing.Point(4, 25);
            this.Ilan.Name = "Ilan";
            this.Ilan.Padding = new System.Windows.Forms.Padding(3);
            this.Ilan.Size = new System.Drawing.Size(1113, 471);
            this.Ilan.TabIndex = 1;
            this.Ilan.Text = "İlan Ekle";
            this.Ilan.UseVisualStyleBackColor = true;
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(951, 442);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(75, 23);
            this.Geri.TabIndex = 17;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // İlanEkle
            // 
            this.İlanEkle.Location = new System.Drawing.Point(443, 442);
            this.İlanEkle.Name = "İlanEkle";
            this.İlanEkle.Size = new System.Drawing.Size(75, 23);
            this.İlanEkle.TabIndex = 16;
            this.İlanEkle.Text = "İlan Ekle";
            this.İlanEkle.UseVisualStyleBackColor = true;
            this.İlanEkle.Click += new System.EventHandler(this.İlanEkle_Click);
            // 
            // IlanG
            // 
            this.IlanG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IlanG.BackgroundColor = System.Drawing.Color.White;
            this.IlanG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlanG.Location = new System.Drawing.Point(13, 75);
            this.IlanG.Name = "IlanG";
            this.IlanG.RowTemplate.Height = 24;
            this.IlanG.Size = new System.Drawing.Size(1013, 361);
            this.IlanG.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Sehir
            // 
            this.Sehir.FormattingEnabled = true;
            this.Sehir.Location = new System.Drawing.Point(857, 21);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(121, 24);
            this.Sehir.TabIndex = 13;
            // 
            // IlanArabaID
            // 
            this.IlanArabaID.FormattingEnabled = true;
            this.IlanArabaID.Location = new System.Drawing.Point(715, 23);
            this.IlanArabaID.Name = "IlanArabaID";
            this.IlanArabaID.Size = new System.Drawing.Size(121, 24);
            this.IlanArabaID.TabIndex = 12;
            // 
            // KM
            // 
            this.KM.Location = new System.Drawing.Point(378, 23);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(100, 22);
            this.KM.TabIndex = 10;
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(256, 23);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(100, 22);
            this.Fiyat.TabIndex = 9;
            // 
            // AD
            // 
            this.AD.Location = new System.Drawing.Point(133, 23);
            this.AD.Multiline = true;
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(100, 22);
            this.AD.TabIndex = 8;
            // 
            // IlanID
            // 
            this.IlanID.Location = new System.Drawing.Point(13, 23);
            this.IlanID.Name = "IlanID";
            this.IlanID.Size = new System.Drawing.Size(100, 22);
            this.IlanID.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(897, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Sehir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(744, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "ArabaID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tarih";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "KiloMetre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "İlan Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "IlanID";
            // 
            // Araba
            // 
            this.Araba.Controls.Add(this.Geri1);
            this.Araba.Controls.Add(this.ArabaEkle);
            this.Araba.Controls.Add(this.Renk);
            this.Araba.Controls.Add(this.Yakit);
            this.Araba.Controls.Add(this.Vites);
            this.Araba.Controls.Add(this.Model);
            this.Araba.Controls.Add(this.Marka);
            this.Araba.Controls.Add(this.ArabaID);
            this.Araba.Controls.Add(this.label6);
            this.Araba.Controls.Add(this.label5);
            this.Araba.Controls.Add(this.label4);
            this.Araba.Controls.Add(this.label3);
            this.Araba.Controls.Add(this.label2);
            this.Araba.Controls.Add(this.label1);
            this.Araba.Controls.Add(this.ArabaG);
            this.Araba.Location = new System.Drawing.Point(4, 25);
            this.Araba.Name = "Araba";
            this.Araba.Padding = new System.Windows.Forms.Padding(3);
            this.Araba.Size = new System.Drawing.Size(1113, 471);
            this.Araba.TabIndex = 0;
            this.Araba.Text = "Araba Ekle";
            this.Araba.UseVisualStyleBackColor = true;
            // 
            // Geri1
            // 
            this.Geri1.Location = new System.Drawing.Point(795, 416);
            this.Geri1.Name = "Geri1";
            this.Geri1.Size = new System.Drawing.Size(75, 23);
            this.Geri1.TabIndex = 14;
            this.Geri1.Text = "Geri";
            this.Geri1.UseVisualStyleBackColor = true;
            this.Geri1.Click += new System.EventHandler(this.Geri_Click);
            // 
            // ArabaEkle
            // 
            this.ArabaEkle.Location = new System.Drawing.Point(451, 416);
            this.ArabaEkle.Name = "ArabaEkle";
            this.ArabaEkle.Size = new System.Drawing.Size(99, 23);
            this.ArabaEkle.TabIndex = 13;
            this.ArabaEkle.Text = "Araba Ekle";
            this.ArabaEkle.UseVisualStyleBackColor = true;
            this.ArabaEkle.Click += new System.EventHandler(this.ArabaEkle_Click);
            // 
            // Renk
            // 
            this.Renk.FormattingEnabled = true;
            this.Renk.Location = new System.Drawing.Point(776, 23);
            this.Renk.Name = "Renk";
            this.Renk.Size = new System.Drawing.Size(121, 24);
            this.Renk.TabIndex = 12;
            // 
            // Yakit
            // 
            this.Yakit.FormattingEnabled = true;
            this.Yakit.Location = new System.Drawing.Point(625, 21);
            this.Yakit.Name = "Yakit";
            this.Yakit.Size = new System.Drawing.Size(121, 24);
            this.Yakit.TabIndex = 11;
            // 
            // Vites
            // 
            this.Vites.FormattingEnabled = true;
            this.Vites.Location = new System.Drawing.Point(467, 21);
            this.Vites.Name = "Vites";
            this.Vites.Size = new System.Drawing.Size(121, 24);
            this.Vites.TabIndex = 10;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(313, 23);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(121, 22);
            this.Model.TabIndex = 9;
            // 
            // Marka
            // 
            this.Marka.Location = new System.Drawing.Point(170, 25);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(121, 22);
            this.Marka.TabIndex = 8;
            // 
            // ArabaID
            // 
            this.ArabaID.Location = new System.Drawing.Point(23, 25);
            this.ArabaID.Name = "ArabaID";
            this.ArabaID.Size = new System.Drawing.Size(121, 22);
            this.ArabaID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(818, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yakıt Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vites Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ArabaID";
            // 
            // ArabaG
            // 
            this.ArabaG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArabaG.Location = new System.Drawing.Point(23, 92);
            this.ArabaG.Name = "ArabaG";
            this.ArabaG.RowTemplate.Height = 24;
            this.ArabaG.Size = new System.Drawing.Size(874, 274);
            this.ArabaG.TabIndex = 0;
            // 
            // VeriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "VeriEkle";
            this.Text = "İlan Ekle / Araba Ekle";
            this.Load += new System.EventHandler(this.VeriEkle_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ilan.ResumeLayout(false);
            this.Ilan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).EndInit();
            this.Araba.ResumeLayout(false);
            this.Araba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArabaG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Araba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ArabaG;
        private System.Windows.Forms.TabPage Ilan;
        private System.Windows.Forms.TextBox ArabaID;
        private System.Windows.Forms.Button ArabaEkle;
        private System.Windows.Forms.ComboBox Renk;
        private System.Windows.Forms.ComboBox Yakit;
        private System.Windows.Forms.ComboBox Vites;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Marka;
        private System.Windows.Forms.ComboBox Sehir;
        private System.Windows.Forms.ComboBox IlanArabaID;
        private System.Windows.Forms.TextBox KM;
        private System.Windows.Forms.TextBox Fiyat;
        private System.Windows.Forms.TextBox AD;
        private System.Windows.Forms.TextBox IlanID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button İlanEkle;
        private System.Windows.Forms.DataGridView IlanG;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Geri1;
        private System.Windows.Forms.Button Geri;
    }
}