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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        void veri_personel()
        {


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutd = new SqlCommand("Select idd, personel_adid, personel_soyadid, ünvanid, cinsiyetid, departmanid, aktif_pasifd, katd, odad, dahilid from Tbl_personeld", baglanti);

            SqlDataAdapter dad = new SqlDataAdapter(komutd);

            DataTable dtd = new DataTable();

            dad.Fill(dtd);

            data_personelgirisd.DataSource = dtd;

            baglanti.Close();


            data_personelgirisd.Columns["idd"].HeaderText = "IDD";
            data_personelgirisd.Columns["idd"].Width = 50;

            data_personelgirisd.Columns["personel_adid"].HeaderText = "ADID";
            data_personelgirisd.Columns["personel_adid"].Width = 50;

            data_personelgirisd.Columns["personel_soyadid"].HeaderText = "SOYADID";
            data_personelgirisd.Columns["personel_soyadid"].Width = 50;

            data_personelgirisd.Columns["ünvanid"].HeaderText = "ÜNVANID";
            data_personelgirisd.Columns["ünvanid"].Width = 50;

            data_personelgirisd.Columns["cinsiyetid"].HeaderText = "CİNSİYETİD";
            data_personelgirisd.Columns["cinsiyetid"].Width = 50;

            data_personelgirisd.Columns["departmanid"].HeaderText = "DEPARTMANID";
            data_personelgirisd.Columns["departmanid"].Width = 50;

            data_personelgirisd.Columns["aktif_pasifd"].HeaderText = "AKTİF PASİFD";
            data_personelgirisd.Columns["aktif_pasifd"].Width = 50;

            data_personelgirisd.Columns["katd"].HeaderText = "KATID";
            data_personelgirisd.Columns["katd"].Width = 50;

            data_personelgirisd.Columns["odad"].HeaderText = "ODAD";
            data_personelgirisd.Columns["odad"].Width = 50;

            data_personelgirisd.Columns["dahilid"].HeaderText = "DAHILIID";
            data_personelgirisd.Columns["dahilid"].Width = 50;


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            veri_personel();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_pkapatd_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void btn_pekled_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutd = new SqlCommand("insert into Tbl_personeld (personel_adid, personel_soyadid, ünvanid, cinsiyetid, departmanid, aktif_pasifd, katd, odad, dahilid) values (@padid, @psoyadid, @punvanid, @pcinsiyetid, @pdepartmanid, @paktifpasifd, @pkatid, @podanumarasid, @pdahilid)", baglanti);

            komutd.Parameters.AddWithValue("@padid", txt_padid.Text);
            komutd.Parameters.AddWithValue("@psoyadid", txt_psoyadid.Text);
            komutd.Parameters.AddWithValue("@punvanid", txt_punvanid.Text);
            komutd.Parameters.AddWithValue("@pcinsiyetid", txt_pcinsiyetid.Text);
            komutd.Parameters.AddWithValue("@pdepartmanid", txt_pdepartmanid.Text);
            komutd.Parameters.AddWithValue("@paktifpasifd", txt_paktifpasifd.Text);
            komutd.Parameters.AddWithValue("@pkatid", txt_pkatid.Text);
            komutd.Parameters.AddWithValue("@podanumarasid", txt_podanumarasid.Text);
            komutd.Parameters.AddWithValue("@pdahilid", txt_pdahilid.Text);


            komutd.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_personel();
        }


        private void btn_pduzenled_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komutd = new SqlCommand("Update Tbl_personeld set personel_adid=@padid, personel_soyadid=@psoyadid,ünvanid=@punvanid, cinsiyetid=@pcinsiyetid, departmanid= @pdepartmanid, aktif_pasifd=@paktifpasifd, katd=@pkatid, odad=@podanumarasid, dahilid=@pdahilid  where idd=14", baglanti);
            

            komutd.Parameters.AddWithValue("@padid", txt_padid.Text);
            komutd.Parameters.AddWithValue("@psoyadid", txt_psoyadid.Text);
            komutd.Parameters.AddWithValue("@punvanid", txt_punvanid.Text);
            komutd.Parameters.AddWithValue("@pcinsiyetid", txt_pcinsiyetid.Text);
            komutd.Parameters.AddWithValue("@pdepartmanid", txt_pdepartmanid.Text);
            komutd.Parameters.AddWithValue("@paktifpasifd", txt_paktifpasifd.Text);
            komutd.Parameters.AddWithValue("@pkatid", txt_pkatid.Text);
            komutd.Parameters.AddWithValue("@podanumarasid", txt_podanumarasid.Text);
            komutd.Parameters.AddWithValue("@pdahilid", txt_pdahilid.Text);



            komutd.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Düzenleme İşlemi Gerçekleşti.");
            
            veri_personel();
        }

        private void btn_psild_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komutd = new SqlCommand("Delete from  Tbl_personeld where personel_adid=@padid", baglanti);

                komutd.Parameters.AddWithValue("@padid", txt_padid.Text);

                komutd.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Silme İşlemi Tamamlanmıştır.");

                veri_personel();

            }
        }
    }
}
