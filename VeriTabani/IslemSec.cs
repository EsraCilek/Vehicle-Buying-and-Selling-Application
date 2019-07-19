using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabani
{
    public partial class IslemSec : Form
    {
        public IslemSec()
        {
            InitializeComponent();
        }

        private void VeriEkle_Click(object sender, EventArgs e)
        {
            VeriEkle veriekleme = new VeriEkle();
            this.Close();
            veriekleme.Show();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            Listele listeleme = new Listele();
            this.Close();
            listeleme.Show();
        }

        private void VeriGuncelle_Click(object sender, EventArgs e)
        {
            VeriGuncelle veriguncelle = new VeriGuncelle();
            this.Close();
            veriguncelle.Show();
        }

        private void VeriSil_Click(object sender, EventArgs e)
        {
            VeriSil verisil = new VeriSil();
            this.Close();
            verisil.Show();
        }
    }
}
