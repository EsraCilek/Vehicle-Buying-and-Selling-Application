using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VeriTabani
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost; Database =prolab3; uid = root; Password =; ");

        MySqlCommand komut;

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            con.Open();
            if (Sifre.Text == SifreTekrar.Text)
            {
                komut = new MySqlCommand("INSERT INTO `uyeler`(`Kullanici_Adi`, `Sifre`) VALUES ('" + KAdi.Text + "','" + Sifre.Text + "')", con);
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yeni Üye Oluşturuldu");
                Form1 Giris = new Form1();
                this.Hide();
                Giris.Show();
            }

            else
            {
                MessageBox.Show("Şifreler Aynı Değil");
                con.Close();
            }
        }

        private void Kaydol_Load(object sender, EventArgs e)
        {
            Sifre.PasswordChar = '*';
            SifreTekrar.PasswordChar = '*';
        }
    }
}
