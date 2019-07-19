namespace VeriTabani
{
    partial class VeriGuncelle
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
            this.Geri1 = new System.Windows.Forms.Button();
            this.IlanGuncelle = new System.Windows.Forms.Button();
            this.IlanG = new System.Windows.Forms.DataGridView();
            this.Sehir = new System.Windows.Forms.ComboBox();
            this.KM = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.TextBox();
            this.AD = new System.Windows.Forms.TextBox();
            this.IlanID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Ilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ilan);
            this.tabControl1.Location = new System.Drawing.Point(153, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // Ilan
            // 
            this.Ilan.Controls.Add(this.Geri1);
            this.Ilan.Controls.Add(this.IlanGuncelle);
            this.Ilan.Controls.Add(this.IlanG);
            this.Ilan.Controls.Add(this.Sehir);
            this.Ilan.Controls.Add(this.KM);
            this.Ilan.Controls.Add(this.Fiyat);
            this.Ilan.Controls.Add(this.AD);
            this.Ilan.Controls.Add(this.IlanID);
            this.Ilan.Controls.Add(this.label13);
            this.Ilan.Controls.Add(this.label10);
            this.Ilan.Controls.Add(this.label9);
            this.Ilan.Controls.Add(this.label8);
            this.Ilan.Controls.Add(this.label7);
            this.Ilan.Location = new System.Drawing.Point(4, 25);
            this.Ilan.Name = "Ilan";
            this.Ilan.Padding = new System.Windows.Forms.Padding(3);
            this.Ilan.Size = new System.Drawing.Size(1060, 471);
            this.Ilan.TabIndex = 1;
            this.Ilan.Text = "İlan Güncelle";
            this.Ilan.UseVisualStyleBackColor = true;
            // 
            // Geri1
            // 
            this.Geri1.Location = new System.Drawing.Point(950, 427);
            this.Geri1.Name = "Geri1";
            this.Geri1.Size = new System.Drawing.Size(75, 23);
            this.Geri1.TabIndex = 17;
            this.Geri1.Text = "Geri";
            this.Geri1.UseVisualStyleBackColor = true;
            this.Geri1.Click += new System.EventHandler(this.Geri1_Click);
            // 
            // IlanGuncelle
            // 
            this.IlanGuncelle.Location = new System.Drawing.Point(469, 427);
            this.IlanGuncelle.Name = "IlanGuncelle";
            this.IlanGuncelle.Size = new System.Drawing.Size(76, 36);
            this.IlanGuncelle.TabIndex = 16;
            this.IlanGuncelle.Text = "Güncelle";
            this.IlanGuncelle.UseVisualStyleBackColor = true;
            this.IlanGuncelle.Click += new System.EventHandler(this.IlanGuncelle_Click);
            // 
            // IlanG
            // 
            this.IlanG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlanG.Location = new System.Drawing.Point(13, 75);
            this.IlanG.Name = "IlanG";
            this.IlanG.RowTemplate.Height = 24;
            this.IlanG.Size = new System.Drawing.Size(1012, 346);
            this.IlanG.TabIndex = 15;
            this.IlanG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.IlanG_CellMouseClick);
            // 
            // Sehir
            // 
            this.Sehir.FormattingEnabled = true;
            this.Sehir.Location = new System.Drawing.Point(535, 23);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(121, 24);
            this.Sehir.TabIndex = 13;
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
            this.label13.Location = new System.Drawing.Point(579, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Sehir";
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
            // VeriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "VeriGuncelle";
            this.Text = "VeriGuncelle";
            this.Load += new System.EventHandler(this.VeriGuncelle_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ilan.ResumeLayout(false);
            this.Ilan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ilan;
        private System.Windows.Forms.Button Geri1;
        private System.Windows.Forms.Button IlanGuncelle;
        private System.Windows.Forms.DataGridView IlanG;
        private System.Windows.Forms.ComboBox Sehir;
        private System.Windows.Forms.TextBox KM;
        private System.Windows.Forms.TextBox Fiyat;
        private System.Windows.Forms.TextBox AD;
        private System.Windows.Forms.TextBox IlanID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}