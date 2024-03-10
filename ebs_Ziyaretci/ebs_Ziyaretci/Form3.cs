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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        private void Form3_Load(object sender, EventArgs e)
        {
         
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut5 = new SqlCommand("insert into Tbl_ziyaretciler ( Adi, Soyadi, Telefonu, adresi, Firma_Adi, Kimlik_No, Departman, Ziyaret_edilecek_personel, Ziyaret_sebebi, Arac_markasi, arac_plakasi, aciklama) values(@adi, @soyadi, @telefonu, @adresi, @firma_adi, @kimlik_no, @departman, @ziyaret_personel, @ziyaret_sebeb, @arac_markasi, @arac_plakasi, @aciklama )", baglanti);



            komut5.Parameters.AddWithValue("@adi", txt_ad.Text);
            komut5.Parameters.AddWithValue("@soyadi", txt_soyad.Text);
            komut5.Parameters.AddWithValue("@telefonu", txt_tel.Text);
            komut5.Parameters.AddWithValue("@adresi", txt_adres.Text);
            komut5.Parameters.AddWithValue("@firma_adi", txt_firmad.Text);
            komut5.Parameters.AddWithValue("@kimlik_no", txt_kimlik.Text);
            komut5.Parameters.AddWithValue("@departman", txt_departmani.Text);
            komut5.Parameters.AddWithValue("@ziyaret_personel", txt_zpersonel.Text);
            komut5.Parameters.AddWithValue("@ziyaret_sebeb", txt_ziyaretsebep.Text);
            komut5.Parameters.AddWithValue("@arac_markasi", txt_aracmarka.Text);
            komut5.Parameters.AddWithValue("@arac_plakasi", txt_aracplakasi.Text);
            komut5.Parameters.AddWithValue("@aciklama", txt_aciklamasi.Text);

            komut5.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_cek();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("Delete from  Tbl_ziyaretciler where Adi=@adi", baglanti);

                komut.Parameters.AddWithValue("@adi", txt_ad.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Silme İşlemi Tamamlanmıştır.");

                veri_cek();
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


           
            SqlCommand komut3 = new SqlCommand("Update Tbl_ziyaretciler set Adi=@adi, Soyadi=@soyadi, Telefonu=@telefonu, adresi= @adresi, Firma_Adi= @firma_adi, Departman=@departman,Ziyaret_edilecek_personel=@ziyaret_personel, Ziyaret_sebebi=@ziyaret_sebeb, Arac_markasi=@arac_markasi, arac_plakasi=@arac_plakasi, aciklama=@aciklama where id=19", baglanti);


            komut3.Parameters.AddWithValue("@adi", txt_ad.Text);
            komut3.Parameters.AddWithValue("@soyadi", txt_soyad.Text);
            komut3.Parameters.AddWithValue("@telefonu", txt_tel.Text);
            komut3.Parameters.AddWithValue("@adresi", txt_adres.Text);
            komut3.Parameters.AddWithValue("@firma_adi", txt_firmad.Text);
            komut3.Parameters.AddWithValue("@kimlik_no", txt_kimlik.Text);
            komut3.Parameters.AddWithValue("@departman", txt_departmani.Text);
            komut3.Parameters.AddWithValue("@ziyaret_personel", txt_zpersonel.Text);
            komut3.Parameters.AddWithValue("@ziyaret_sebeb", txt_ziyaretsebep.Text);
            komut3.Parameters.AddWithValue("@arac_markasi", txt_aracmarka.Text);
            komut3.Parameters.AddWithValue("@arac_plakasi", txt_aracplakasi.Text);
            komut3.Parameters.AddWithValue("@aciklama", txt_aciklamasi.Text);


            komut3.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Düzenleme İşlemi Gerçekleşti.");

            veri_cek();

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            veri_cek();
        }


        void veri_cek()
        {


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut = new SqlCommand("Select id, Adi, Soyadi, Telefonu, adresi, Firma_Adi, Kimlik_No, Departman, Ziyaret_edilecek_personel, Ziyaret_sebebi, Arac_markasi, arac_plakasi, aciklama from Tbl_ziyaretciler", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            grid_ziyaretcigirisveri2.DataSource = dt;

            baglanti.Close();


            grid_ziyaretcigirisveri2.Columns["id"].HeaderText = "ID";
            grid_ziyaretcigirisveri2.Columns["id"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["Adi"].HeaderText = "ADI";
            grid_ziyaretcigirisveri2.Columns["Adi"].Width = 120;

            grid_ziyaretcigirisveri2.Columns["Soyadi"].HeaderText = "SOYADI";
            grid_ziyaretcigirisveri2.Columns["Soyadi"].Width = 120;

            grid_ziyaretcigirisveri2.Columns["Telefonu"].HeaderText = "TELEFONU";
            grid_ziyaretcigirisveri2.Columns["Telefonu"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["adresi"].HeaderText = "ADRESİ";
            grid_ziyaretcigirisveri2.Columns["adresi"].Width = 200;

            grid_ziyaretcigirisveri2.Columns["Firma_Adi"].HeaderText = "FİRMA ADI";
            grid_ziyaretcigirisveri2.Columns["Firma_Adi"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["Kimlik_No"].HeaderText = "KİMLİK NO";
            grid_ziyaretcigirisveri2.Columns["Kimlik_No"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["Departman"].HeaderText = "DEPARTMAN";
            grid_ziyaretcigirisveri2.Columns["Departman"].Width = 120;

            grid_ziyaretcigirisveri2.Columns["Ziyaret_edilecek_personel"].HeaderText = "ZİYARET EDİLECEK PERSONEL";
            grid_ziyaretcigirisveri2.Columns["Ziyaret_edilecek_personel"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["Ziyaret_sebebi"].HeaderText = "ZİYARET SEBEBİ";
            grid_ziyaretcigirisveri2.Columns["Ziyaret_sebebi"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["Arac_markasi"].HeaderText = "ARAÇ MARKASI";
            grid_ziyaretcigirisveri2.Columns["Arac_markasi"].Width = 120;

            grid_ziyaretcigirisveri2.Columns["arac_plakasi"].HeaderText = "ARAÇ PLAKASI";
            grid_ziyaretcigirisveri2.Columns["arac_plakasi"].Width = 50;

            grid_ziyaretcigirisveri2.Columns["aciklama"].HeaderText = "AÇIKLAMA";
            grid_ziyaretcigirisveri2.Columns["aciklama"].Width = 200;

        }



    }


}
