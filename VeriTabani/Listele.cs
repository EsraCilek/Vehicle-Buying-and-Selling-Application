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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost; Database =prolab3; uid = root; Password =; pooling = false; convert zero datetime=True ");
        string sqlsorgu = "Select tbl_ilan.IlanID , tbl_ilan.Ilan_Adi, tbl_ilan.Ilan_Fiyat, tbl_ilan.Ilan_Km, tbl_ilan.ilan_Tarih,tbl_araba.Araba_Marka,tbl_araba.Araba_Model,tbl_vites.Vites, tbl_yakitturu.Yakit, tbl_renk.Renk,tbl_sehir.Sehir "
          + "FROM tbl_ilan join tbl_araba on tbl_ilan.ilan_ArabaID = tbl_araba.ArabaID join tbl_renk on tbl_araba.Araba_RenkID= tbl_renk.RenkID join tbl_sehir on tbl_ilan.Ilan_SehirID = tbl_sehir.SehirID join tbl_vites on tbl_araba.Araba_VitesTuruID = tbl_vites.VitesID join tbl_yakıtturu on tbl_araba.Araba_YakitTuruID = tbl_yakitturu.YakitID    ";
        MySqlCommand komut = new MySqlCommand();
        DataTable tablo = new DataTable();
       
        MySqlDataAdapter Sorgu = new MySqlDataAdapter();
        void  Yenile() {

            MySqlDataAdapter Ilan = new MySqlDataAdapter(sqlsorgu,con);
            DataTable dtIlan = new DataTable();
            Ilan.Fill(dtIlan);
            IlanG.DataSource = dtIlan;

      


        }
        
        private void Listele_Load(object sender, EventArgs e)
        {

            Yenile();

        }
        string FinalFilter = "";

        private void button1_Click(object sender, EventArgs e)
        {
            


           int  count = 0;
            //https://www.youtube.com/watch?v=Qj_yGSlxwB0 sitesinden yararlanarak uyarlanmıştırdır.

            string Filter = "";
            

            if (Sehir.Text != "") { Filter = Filter + "Sehir like '%" + Sehir.Text + "%' and ";
               
            }
            if(Renk.Text != "") { Filter = Filter + "Renk like '%" + Renk.Text + "%' and ";
              
            }
            if (Marka.Text != "") { Filter = Filter + "Araba_Marka like '%" + Marka.Text + "%' and ";
                
            }
            if (Model.Text != "") { Filter = Filter + "Araba_Model like '%" + Model.Text + "%' and ";
                
            }
            if (MinFiyat.Text != "" || MaxFiyat.Text!="") {
                if (MaxFiyat.Text == "")
                {
                    Filter = Filter + "tbl_ilan.Ilan_Fiyat>= ('" + MinFiyat.Text + "' ) and ";
                }
                else
                {
                    Filter = Filter + "tbl_ilan.Ilan_Fiyat between ('" + MinFiyat.Text + "' ) and ('" + MaxFiyat.Text + "') and ";
                }
            }
            if (MinKm.Text != "" || MaxKm.Text != "") {

                if (MaxKm.Text == "")
                {
                    Filter = Filter + "tbl_ilan.Ilan_Fiyat>= ('" + MinKm.Text + "' ) and ";
                }
                else
                {
                    Filter = Filter + "tbl_ilan.Ilan_Km between ('" + MinKm.Text + "' ) and ('" + MaxKm.Text + "') and ";
                }
            }
            if (Vites.Text != "") { Filter = Filter + "Vites like '%" + Vites.Text + "%' and ";
                
            }
            if (Yakit.Text != "") { Filter = Filter + "Yakit like '%" + Yakit.Text + "%' and ";
                count++;
            }
            if (IlanAdi.Text != "") { Filter = Filter + "Ilan_Adi like '%" + IlanAdi.Text + "%' and ";
                
            }
            if (Tarih.Text != "") {
                if (Tarih.SelectedIndex == 1)
                {
                    Filter = Filter+ " tbl_ilan.Ilan_Tarih >= (now() - INTERVAL 1 DAY) and ";
                }
                if (Tarih.SelectedIndex == 2)
                {
                    Filter = Filter + " tbl_ilan.Ilan_Tarih >= (now() - INTERVAL 7 DAY) and ";
                }
                if (Tarih.SelectedIndex == 3)
                {
                    Filter = Filter + " tbl_ilan.Ilan_Tarih >= (now() - INTERVAL 30 DAY) and ";
                }
                count++;
            }





            string sorgu = "";
            if (Filter.Length <= 0)
            {
                tablo.Clear();
                if (Sıralamabox.Text == "Sıralama")
                {
                    sorgu = sqlsorgu +  "order by IlanID";
                }
                if (Sıralamabox.SelectedIndex == 0)
                {
                    sorgu = sqlsorgu + " order by Araba_Marka asc  ";
                }
                if (Sıralamabox.SelectedIndex == 1)
                {
                    sorgu = sqlsorgu +  "order by Araba_Marka desc ";

                }
                if (Sıralamabox.SelectedIndex == 2)
                {
                    sorgu = sqlsorgu +  "order by Ilan_Fiyat asc ";

                }
                if (Sıralamabox.SelectedIndex == 3)
                {
                    sorgu = sqlsorgu +  "order by Ilan_Fiyat desc ";
                }

                if (Sıralamabox.SelectedIndex == 4)
                {
                    sorgu = sqlsorgu + "order by Ilan_Km asc ";
                }

                if (Sıralamabox.SelectedIndex == 5)
                {
                    sorgu = sqlsorgu + "order by Ilan_Km desc ";
                }

                con.Open();
                komut.CommandText = sorgu;

                komut.Connection = con;
                Sorgu.SelectCommand = komut;
                
                Sorgu.Fill(tablo);
                con.Close();
                IlanG.DataSource = tablo;
            }

            if (Filter.Length >0 )
            {
                 FinalFilter = Filter.Remove(Filter.Length - 4, 3);
                tablo.Clear();
                if (Sıralamabox.Text=="Sıralama") {
                    sorgu = sqlsorgu + " where " + FinalFilter + "ORDER BY IlanID";
                }
                if (Sıralamabox.SelectedIndex == 0)
                {
                    sorgu = sqlsorgu + " where " + FinalFilter + "order by Araba_Marka asc  ";
                }
                if (Sıralamabox.SelectedIndex == 1)
                {
                    sorgu = sqlsorgu + " where " + FinalFilter + "order by Araba_Marka desc ";
                
                }
                if (Sıralamabox.SelectedIndex == 2)
                {
                    sorgu = sqlsorgu + " where " + FinalFilter + "order by Ilan_Fiyat asc ";

                }
                if (Sıralamabox.SelectedIndex == 3)
                {
                    sorgu = sqlsorgu + " where " + FinalFilter + "order by Ilan_Fiyat desc ";
                }

                if (Sıralamabox.SelectedIndex == 4)
                {
                    sorgu = sqlsorgu + " where " + FinalFilter + "order by Ilan_Km asc ";
                }

                if (Sıralamabox.SelectedIndex == 5)
                {
                    sorgu = sqlsorgu + " where " + FinalFilter + "order by Ilan_Km desc ";
                }

                con.Open();
                komut.CommandText = sorgu;

                komut.Connection = con;
                Sorgu.SelectCommand = komut;
                
                Sorgu.Fill(tablo);
                con.Close();
                IlanG.DataSource = tablo;
            }

           

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            IslemSec islemsec = new IslemSec();
            this.Close();
            islemsec.Show();
        }
    }
}
