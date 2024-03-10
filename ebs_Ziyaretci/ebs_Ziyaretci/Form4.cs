using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ebs_Ziyaretci
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        private void Form4_Load(object sender, EventArgs e)
        {
            veri_sofortakip();
        }

        void veri_sofortakip()
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut7 = new SqlCommand("Select idb, sofor_adib, sofor_soyadib, sofor_numarasib, sofor_ehliyetib, sofor_calistigisirketib, sofor_adresib from Tbl_sofortakipb ", baglanti);

            SqlDataAdapter da7 = new SqlDataAdapter(komut7);

            DataTable dt7 = new DataTable();

            da7.Fill(dt7);

            data_soforverib.DataSource = dt7;

            baglanti.Close();


            data_soforverib.Columns["idb"].HeaderText = "IDb";
            data_soforverib.Columns["idb"].Width = 120;

            data_soforverib.Columns["sofor_adib"].HeaderText = "ŞOFÖR ADIB";
            data_soforverib.Columns["sofor_adib"].Width = 100;

            data_soforverib.Columns["sofor_soyadib"].HeaderText = "ŞOFÖR SOYADİb";
            data_soforverib.Columns["sofor_soyadib"].Width = 100;

            data_soforverib.Columns["sofor_numarasib"].HeaderText = "ŞOFÖR NUMARASIB";
            data_soforverib.Columns["sofor_numarasib"].Width = 100;

            data_soforverib.Columns["sofor_ehliyetib"].HeaderText = "ŞOFÖR EHLİYETİB";
            data_soforverib.Columns["sofor_ehliyetib"].Width = 100;

            data_soforverib.Columns["sofor_calistigisirketib"].HeaderText = "ÇALIŞTIĞI ŞİRKETB";
            data_soforverib.Columns["sofor_calistigisirketib"].Width = 100;

            data_soforverib.Columns["sofor_adresib"].HeaderText = "ADRESİB";
            data_soforverib.Columns["sofor_adresib"].Width = 100;
        }


        private void btn_aekle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut7 = new SqlCommand("insert into Tbl_sofortakipb (sofor_adib, sofor_soyadib, sofor_numarasib, sofor_ehliyetib, sofor_calistigisirketib, sofor_adresib ) values(@sadib, @soyadib, @snumarasib, @sehliyetib, @scalistigib, @sadresib)", baglanti);
            
            komut7.Parameters.AddWithValue("@sadib", txt_sadib.Text);
            komut7.Parameters.AddWithValue("@soyadib", txt_soyadib.Text);
            komut7.Parameters.AddWithValue("@snumarasib", txt_numarasib.Text);
            komut7.Parameters.AddWithValue("@sehliyetib", txt_ehliyetib.Text);
            komut7.Parameters.AddWithValue("@scalistigib", txt_calistigib.Text);
            komut7.Parameters.AddWithValue("@sadresib", txt_adresib.Text);
            

            komut7.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_sofortakip();
        }

        private void btn_akapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_asil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut7 = new SqlCommand("Delete from  Tbl_sofortakipb where sofor_adib=@sadib", baglanti);

                komut7.Parameters.AddWithValue("@sadib", txt_sadib.Text);

                komut7.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Silme İşlemi Tamamlanmıştır.");

                veri_sofortakip();

            }
        }



        private void btn_aduzenle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            
            SqlCommand komut5 = new SqlCommand("Update Tbl_sofortakipb set sofor_adib=@sadib, sofor_soyadib=@soyadib, sofor_numarasib=@snumarasib, sofor_ehliyetib=@sehliyetib, sofor_calistigisirketib= @scalistigib, sofor_adresib=@sadresib  where idb=2", baglanti);
           


            komut5.Parameters.AddWithValue("@sadib", txt_sadib.Text);
            komut5.Parameters.AddWithValue("@soyadib", txt_soyadib.Text);
            komut5.Parameters.AddWithValue("@snumarasib", txt_numarasib.Text);
            komut5.Parameters.AddWithValue("@sehliyetib", txt_ehliyetib.Text);
            komut5.Parameters.AddWithValue("@scalistigib", txt_calistigib.Text);
            komut5.Parameters.AddWithValue("@sadresib", txt_adresib.Text);


            komut5.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Düzenleme İşlemi Gerçekleşti.");

            veri_sofortakip();
            

    }





    }
}
