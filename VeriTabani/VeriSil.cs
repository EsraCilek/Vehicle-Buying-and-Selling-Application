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
    public partial class VeriSil : Form
    {
        public VeriSil()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("Server=localhost; Database =prolab3; uid = root; Password =; pooling = false; convert zero datetime=True ");
        MySqlCommand komut1 = new MySqlCommand();
        MySqlCommand komut2 = new MySqlCommand();


        void Yenile()
        {
            MySqlDataAdapter Araba = new MySqlDataAdapter("select ArabaId, Araba_Marka, Araba_Model, Vites, Yakit, Renk " +
                "from tbl_araba join tbl_vites on tbl_araba.Araba_VitesTuruID= tbl_vites.VitesID" +
                " join tbl_yakitturu on tbl_araba.Araba_YakitTuruID = tbl_yakitturu.YakitID join tbl_renk on tbl_araba.Araba_RenkID = tbl_renk.RenkID ", con);
            DataTable dtAraba = new DataTable();
            Araba.Fill(dtAraba);
            ArabaG.DataSource = dtAraba;



            MySqlDataAdapter Ilan = new MySqlDataAdapter("Select IlanID, Ilan_Adi, Ilan_Fiyat, Ilan_Km, Ilan_Tarih, Ilan_ArabaID, tbl_sehir.Sehir " +
                "from tbl_ilan join tbl_araba on tbl_ilan.Ilan_ArabaID = tbl_araba.ArabaID join tbl_sehir on tbl_ilan.Ilan_SehirID = tbl_sehir.SehirID", con);
            DataTable dtIlan = new DataTable();
            Ilan.Fill(dtIlan);
            IlanG.DataSource = dtIlan;

        }

        private void VeriSil_Load(object sender, EventArgs e)
        {
            Yenile();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("Select Ilan_ArabaID From tbl_ilan where Ilan_ArabaID = '" + ArabaID.Text + "' ", con);

            con.Open();
            MySqlDataReader dr;
            dr = komut.ExecuteReader();
           
            if (dr.Read())
            {
                con.Close();
                MessageBox.Show("Önce İlanı Kaldırınız!");
            }
            else
            {
                con.Close();
                con.Open();
                komut1.Connection = con;
                komut1.CommandText = "delete from tbl_araba where ArabaID = '" + ArabaID.Text + "' ";
                komut1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Seçilen Araba Silindi!");
                Yenile();
            }
            

        }

        private void IlanıSil_Click(object sender, EventArgs e)
        {
            komut2.Connection = con;
            komut2.CommandText = "delete from tbl_ilan where IlanID = '" + IlanID.Text + "' ";
            con.Open();
            komut2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Seçilen İlan Kaldırıldı!");
            Yenile();
        }

        private void ArabaG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ArabaID.Text = ArabaG.CurrentRow.Cells[0].Value.ToString();
        }

        private void IlanG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IlanID.Text = IlanG.CurrentRow.Cells[0].Value.ToString();
        }

        private void Geri1_Click(object sender, EventArgs e)
        {
            IslemSec form = new IslemSec();
            this.Close();
            form.Show();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            IslemSec form = new IslemSec();
            this.Close();
            form.Show();
        }
    }
}
