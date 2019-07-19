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
    public partial class VeriGuncelle : Form
    {
        public VeriGuncelle()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost; Database =prolab3; uid = root; Password =; pooling = false; convert zero datetime=True ");
        MySqlCommand komut;

        void Yenile()
        {
         

            //combobox sehir 
            MySqlDataAdapter daSehir = new MySqlDataAdapter("select* from tbl_sehir order by Sehir", con);
            DataTable dtsehir = new DataTable();
            daSehir.Fill(dtsehir);
            Sehir.DataSource = dtsehir;
            Sehir.ValueMember = "SehirID";
            Sehir.DisplayMember = "Sehir";


            MySqlDataAdapter Ilan = new MySqlDataAdapter("Select IlanID, Ilan_Adi, Ilan_Fiyat, Ilan_Km, Ilan_Tarih, Ilan_ArabaID, tbl_sehir.Sehir " +
                "from tbl_ilan join tbl_araba on tbl_ilan.Ilan_ArabaID = tbl_araba.ArabaID join tbl_sehir on tbl_ilan.Ilan_SehirID = tbl_sehir.SehirID order by IlanID desc", con);
            DataTable dtIlan = new DataTable();
            Ilan.Fill(dtIlan);
            IlanG.DataSource = dtIlan;

        }

        private void VeriGuncelle_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void IlanG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IlanID.Text = IlanG.CurrentRow.Cells[0].Value.ToString();
            AD.Text = IlanG.CurrentRow.Cells[1].Value.ToString();
            Fiyat.Text = IlanG.CurrentRow.Cells[2].Value.ToString();
            KM.Text = IlanG.CurrentRow.Cells[3].Value.ToString();
            Sehir.Text = IlanG.CurrentRow.Cells[6].Value.ToString();
        }

        public void OpenCon()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();

            }
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
        }

        public void Sorgum(string sorgu)
        {
            try
            {
                OpenCon();
                komut = new MySqlCommand(sorgu, con);
                if (komut.ExecuteNonQuery() == 1) {
                    MessageBox.Show("Başarılı");

                }
                else
                {
                    MessageBox.Show("Başarısız");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        private void IlanGuncelle_Click(object sender, EventArgs e)
        {
            string Guncelleme = "UPDATE `tbl_ilan` SET `Ilan_Adi`=('" + AD.Text + "' )," +
                "`Ilan_Fiyat`=('" + Fiyat.Text + "' ),`Ilan_Km`=('" + KM.Text + "' )," +
                "`Ilan_SehirID`=('" + Sehir.SelectedValue + "' ) WHERE IlanID = ('" + IlanID.Text + "' )";
            Sorgum(Guncelleme);
            Yenile();
        }

        private void Geri1_Click(object sender, EventArgs e)
        {
            IslemSec form = new IslemSec();
            this.Close();
            form.Show();
        }
    }
}
