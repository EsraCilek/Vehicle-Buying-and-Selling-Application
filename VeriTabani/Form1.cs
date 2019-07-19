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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost; Database =prolab3; uid = root; Password =; ");

        MySqlCommand komut;







        private void GirisYap_Click(object sender, EventArgs e)
        {

            komut = new MySqlCommand("Select* From uyeler where Kullanici_Adi = ('"+KAdi.Text+"' ) and Sifre = ('"+Sifre.Text+"')", con);
       
            con.Open();
            MySqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                IslemSec Form = new IslemSec();
                this.Hide();
                Form.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış!");
                con.Close();
            }
        }

        private void Kaydol_Click(object sender, EventArgs e)
        {
            Kaydol kayıt = new Kaydol();
            this.Hide();
            kayıt.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sifre.PasswordChar = '*';
        }
    }
}
