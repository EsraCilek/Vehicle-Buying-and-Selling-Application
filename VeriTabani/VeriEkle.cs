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
    public partial class VeriEkle : Form
    {
        public VeriEkle()
        {
            InitializeComponent();
        }
        MySqlConnection con ;
        
        void Yenile() {
            MySqlDataAdapter Araba = new MySqlDataAdapter("select ArabaId, Araba_Marka, Araba_Model, Vites, Yakit, Renk " +
                "from tbl_araba join tbl_vites on tbl_araba.Araba_VitesTuruID= tbl_vites.VitesID" +
                " join tbl_yakitturu on tbl_araba.Araba_YakitTuruID = tbl_yakitturu.YakitID join tbl_renk on tbl_araba.Araba_RenkID = tbl_renk.RenkID order by ArabaID desc", con);
           DataTable  dtAraba = new DataTable();
            Araba.Fill(dtAraba);
            ArabaG.DataSource = dtAraba;

            //combobox vites
            MySqlDataAdapter daVites = new MySqlDataAdapter("select* from tbl_vites order by Vites",con);
            DataTable dtvites = new DataTable();
            daVites.Fill(dtvites);
            Vites.DataSource = dtvites;
            Vites.ValueMember = "VitesID";
            Vites.DisplayMember = "Vites";

            //combobox yakıt
            MySqlDataAdapter daYakitTuru = new MySqlDataAdapter("select* from tbl_yakitturu order by Yakit", con);
            DataTable dtYakitTuru = new DataTable();
            daYakitTuru.Fill(dtYakitTuru);
            Yakit.DataSource = dtYakitTuru;
            Yakit.ValueMember = "YakitID";
            Yakit.DisplayMember = "Yakit";

            //combobox renk
            MySqlDataAdapter daRenk = new MySqlDataAdapter("select* from tbl_renk order by Renk", con);
            DataTable dtrenk = new DataTable();
            daRenk.Fill(dtrenk);
            Renk.DataSource = dtrenk;
            Renk.ValueMember = "RenkID";
            Renk.DisplayMember = "Renk";

            //combobox sehir 
            MySqlDataAdapter daSehir = new MySqlDataAdapter("select* from tbl_sehir order by Sehir", con);
            DataTable dtsehir = new DataTable();
            daSehir.Fill(dtsehir);
            Sehir.DataSource = dtsehir;
            Sehir.ValueMember = "SehirID";
            Sehir.DisplayMember = "Sehir";

            //combobox arabaıd
            MySqlDataAdapter daIlanAID = new MySqlDataAdapter("select tbl_araba.ArabaID from tbl_araba Order By ArabaID", con);
            DataTable dtilanaid = new DataTable();
            daIlanAID.Fill(dtilanaid);
            IlanArabaID.DataSource = dtilanaid;
            IlanArabaID.ValueMember = "ArabaID";
            IlanArabaID.DisplayMember = "ArabaID";


            MySqlDataAdapter Ilan = new MySqlDataAdapter("Select IlanID, Ilan_Adi, Ilan_Fiyat, Ilan_Km, Ilan_Tarih, Ilan_ArabaID, tbl_sehir.Sehir " +
                "from tbl_ilan join tbl_araba on tbl_ilan.Ilan_ArabaID = tbl_araba.ArabaID join tbl_sehir on tbl_ilan.Ilan_SehirID = tbl_sehir.SehirID order by IlanID desc", con);
            DataTable dtIlan = new DataTable();
            Ilan.Fill(dtIlan);
            IlanG.DataSource = dtIlan;

        }

        private void VeriEkle_Load(object sender, EventArgs e)
        {

            con = new MySqlConnection("Server=localhost; Database =prolab3; uid = root; Password =; pooling = false; convert zero datetime=True ");
            Yenile();
        }

        private void ArabaEkle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into tbl_araba values(@ArabaID, @Araba_Marka, @Araba_Model, @Araba_VitesTuruID,@Araba_YakitTuruID,@Araba_RenkID )", con);
            komut.Parameters.AddWithValue("@ArabaID", ArabaID.Text);
            komut.Parameters.AddWithValue("@Araba_Marka", Marka.Text);
            komut.Parameters.AddWithValue("@Araba_Model", Model.Text);
            komut.Parameters.AddWithValue("@Araba_VitesTuruID", Vites.SelectedValue);
            komut.Parameters.AddWithValue("@Araba_YakitTuruID", Yakit.SelectedValue);
            komut.Parameters.AddWithValue("@Araba_RenkID", Renk.SelectedValue);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yeni Araba Eklendi");
            Yenile();
        }

        private void İlanEkle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into tbl_ilan values(@IlanID, @Ilan_Adi, @Ilan_Fiyat, @Ilan_Km,@Ilan_Tarih,@Ilan_ArabaID,@Ilan_SehirID )", con);
            komut.Parameters.AddWithValue("@IlanID", IlanID.Text);
            komut.Parameters.AddWithValue("@Ilan_Adi", AD.Text);
            komut.Parameters.AddWithValue("@Ilan_Fiyat", Fiyat.Text);
            komut.Parameters.AddWithValue("@Ilan_Km", KM.Text);
            komut.Parameters.AddWithValue("@Ilan_Tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Ilan_ArabaID", IlanArabaID.SelectedValue);
            komut.Parameters.AddWithValue("@Ilan_SehirID", Sehir.SelectedValue);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yeni İlan Eklendi");
            Yenile();
        }

        private void Geri1_Click(object sender, EventArgs e)
        {
            IslemSec form3 = new IslemSec();
            this.Close();
            form3.Show();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            IslemSec form3 = new IslemSec();
            this.Close();
            form3.Show();
        }
    }
}
