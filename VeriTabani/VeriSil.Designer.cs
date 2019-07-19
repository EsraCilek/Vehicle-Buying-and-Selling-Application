namespace VeriTabani
{
    partial class VeriSil
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
            this.ArabaSil = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ArabaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArabaG = new System.Windows.Forms.DataGridView();
            this.IlanSil = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.IlanID = new System.Windows.Forms.TextBox();
            this.IlanıSil = new System.Windows.Forms.Button();
            this.IlanG = new System.Windows.Forms.DataGridView();
            this.Geri = new System.Windows.Forms.Button();
            this.Geri1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ArabaSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArabaG)).BeginInit();
            this.IlanSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IlanSil);
            this.tabControl1.Controls.Add(this.ArabaSil);
            this.tabControl1.Location = new System.Drawing.Point(21, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // ArabaSil
            // 
            this.ArabaSil.Controls.Add(this.Geri);
            this.ArabaSil.Controls.Add(this.button1);
            this.ArabaSil.Controls.Add(this.ArabaID);
            this.ArabaSil.Controls.Add(this.label1);
            this.ArabaSil.Controls.Add(this.ArabaG);
            this.ArabaSil.Location = new System.Drawing.Point(4, 25);
            this.ArabaSil.Name = "ArabaSil";
            this.ArabaSil.Padding = new System.Windows.Forms.Padding(3);
            this.ArabaSil.Size = new System.Drawing.Size(1176, 440);
            this.ArabaSil.TabIndex = 0;
            this.ArabaSil.Text = "Araba Sil";
            this.ArabaSil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Arabayı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArabaID
            // 
            this.ArabaID.Location = new System.Drawing.Point(396, 53);
            this.ArabaID.Name = "ArabaID";
            this.ArabaID.Size = new System.Drawing.Size(170, 22);
            this.ArabaID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ArabaID";
            // 
            // ArabaG
            // 
            this.ArabaG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArabaG.Location = new System.Drawing.Point(152, 120);
            this.ArabaG.Name = "ArabaG";
            this.ArabaG.RowTemplate.Height = 24;
            this.ArabaG.Size = new System.Drawing.Size(852, 289);
            this.ArabaG.TabIndex = 0;
            this.ArabaG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ArabaG_CellMouseClick);
            // 
            // IlanSil
            // 
            this.IlanSil.Controls.Add(this.label2);
            this.IlanSil.Controls.Add(this.IlanID);
            this.IlanSil.Controls.Add(this.IlanıSil);
            this.IlanSil.Controls.Add(this.IlanG);
            this.IlanSil.Location = new System.Drawing.Point(4, 25);
            this.IlanSil.Name = "IlanSil";
            this.IlanSil.Padding = new System.Windows.Forms.Padding(3);
            this.IlanSil.Size = new System.Drawing.Size(1176, 440);
            this.IlanSil.TabIndex = 1;
            this.IlanSil.Text = "İlan Sil";
            this.IlanSil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "IlanID";
            // 
            // IlanID
            // 
            this.IlanID.Location = new System.Drawing.Point(439, 29);
            this.IlanID.Name = "IlanID";
            this.IlanID.Size = new System.Drawing.Size(148, 22);
            this.IlanID.TabIndex = 2;
            // 
            // IlanıSil
            // 
            this.IlanıSil.Location = new System.Drawing.Point(644, 18);
            this.IlanıSil.Name = "IlanıSil";
            this.IlanıSil.Size = new System.Drawing.Size(94, 45);
            this.IlanıSil.TabIndex = 1;
            this.IlanıSil.Text = "İlanı Sil";
            this.IlanıSil.UseVisualStyleBackColor = true;
            this.IlanıSil.Click += new System.EventHandler(this.IlanıSil_Click);
            // 
            // IlanG
            // 
            this.IlanG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlanG.Location = new System.Drawing.Point(42, 80);
            this.IlanG.Name = "IlanG";
            this.IlanG.RowTemplate.Height = 24;
            this.IlanG.Size = new System.Drawing.Size(1120, 333);
            this.IlanG.TabIndex = 0;
            this.IlanG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.IlanG_CellMouseClick);
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(1062, 357);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(75, 23);
            this.Geri.TabIndex = 7;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // Geri1
            // 
            this.Geri1.Location = new System.Drawing.Point(1243, 463);
            this.Geri1.Name = "Geri1";
            this.Geri1.Size = new System.Drawing.Size(75, 23);
            this.Geri1.TabIndex = 8;
            this.Geri1.Text = "Geri";
            this.Geri1.UseVisualStyleBackColor = true;
            this.Geri1.Click += new System.EventHandler(this.Geri1_Click);
            // 
            // VeriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 502);
            this.Controls.Add(this.Geri1);
            this.Controls.Add(this.tabControl1);
            this.Name = "VeriSil";
            this.Text = "VeriSil";
            this.Load += new System.EventHandler(this.VeriSil_Load);
            this.tabControl1.ResumeLayout(false);
            this.ArabaSil.ResumeLayout(false);
            this.ArabaSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArabaG)).EndInit();
            this.IlanSil.ResumeLayout(false);
            this.IlanSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlanG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ArabaSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ArabaG;
        private System.Windows.Forms.TabPage IlanSil;
        private System.Windows.Forms.DataGridView IlanG;
        private System.Windows.Forms.TextBox ArabaID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IlanID;
        private System.Windows.Forms.Button IlanıSil;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button Geri1;
    }
}