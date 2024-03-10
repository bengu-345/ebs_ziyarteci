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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);



        void veri_pt()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutf = new SqlCommand("Select idf, sicil_nof, personel_adif, personel_unvanif from Tbl_personeltakipf", baglanti);

            SqlDataAdapter daf = new SqlDataAdapter(komutf);

            DataTable dtf = new DataTable();

            daf.Fill(dtf);

            pt_veri.DataSource = dtf;

            baglanti.Close();


            pt_veri.Columns["idf"].HeaderText = "IDF";
            pt_veri.Columns["idf"].Width = 100;

            pt_veri.Columns["sicil_nof"].HeaderText = "SİCİL NOF";
            pt_veri.Columns["sicil_nof"].Width = 200;

            pt_veri.Columns["personel_adif"].HeaderText = "ADIF";
            pt_veri.Columns["personel_adif"].Width = 200;

            pt_veri.Columns["personel_unvanif"].HeaderText = "UNVANIF";
            pt_veri.Columns["personel_unvanif"].Width = 200;

        }
        private void btn_ptekle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutff= new SqlCommand("insert into Tbl_personeltakipf (sicil_nof, personel_adif, personel_unvanif) values (@sicil_nof, @personel_adif, @personel_unvanif)", baglanti);

            komutff.Parameters.AddWithValue("@sicil_nof", txt_ptsicil.Text);
            komutff.Parameters.AddWithValue("@personel_adif", txt_ptadif.Text);
            komutff.Parameters.AddWithValue("@personel_unvanif", txt_ptunvanif.Text);
        
            komutff.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_pt();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            veri_pt();
        }

        private void btn_ptsil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komutfff = new SqlCommand("Delete from  Tbl_personeltakipf  where personel_adif=@personel_adif", baglanti);

                komutfff.Parameters.AddWithValue("@personel_adif", txt_ptadif.Text);

                komutfff.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Silme İşlemi Tamamlanmıştır.");

                veri_pt();
            }
        }

        private void btn_ptkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ptduzenle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komutfr = new SqlCommand("Update Tbl_personeltakipf set sicil_nof=@sicil_nof, personel_adif=@personel_adif, personel_unvanif=@personel_unvanif where idf=11", baglanti);


            komutfr.Parameters.AddWithValue("@sicil_nof", txt_ptsicil.Text);
            komutfr.Parameters.AddWithValue("@personel_adif", txt_ptadif.Text);
            komutfr.Parameters.AddWithValue("@personel_unvanif", txt_ptunvanif.Text);


            komutfr.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Düzenleme İşlemi Gerçekleşti.");

            veri_pt();
        }
    }
}
