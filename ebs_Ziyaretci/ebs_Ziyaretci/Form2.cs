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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



    
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            veri_cekziyaretciler();
            veri_cekaractakip();
            veri_ziyaretcibilgiler();
            veri_sofortakip();
            veri_personel();
            veri_cekaractakip_personel();
            veri_pt();
                   }

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

            data_ptveri.DataSource = dtf;

            baglanti.Close();


            data_ptveri.Columns["idf"].HeaderText = "IDF";
            data_ptveri.Columns["idf"].Width = 50;

            data_ptveri.Columns["sicil_nof"].HeaderText = "SİCİL NOF";
            data_ptveri.Columns["sicil_nof"].Width = 150;

            data_ptveri.Columns["personel_adif"].HeaderText = "ADIF";
            data_ptveri.Columns["personel_adif"].Width = 150;

            data_ptveri.Columns["personel_unvanif"].HeaderText = "UNVANIF";
            data_ptveri.Columns["personel_unvanif"].Width = 150;

        }

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

            data_pverid.DataSource = dtd;

            baglanti.Close();


            data_pverid.Columns["idd"].HeaderText = "IDD";
            data_pverid.Columns["idd"].Width = 50;

            data_pverid.Columns["personel_adid"].HeaderText = "ADID";
            data_pverid.Columns["personel_adid"].Width = 150;

            data_pverid.Columns["personel_soyadid"].HeaderText = "SOYADID";
            data_pverid.Columns["personel_soyadid"].Width = 150;

            data_pverid.Columns["ünvanid"].HeaderText = "ÜNVANID";
            data_pverid.Columns["ünvanid"].Width = 150;

            data_pverid.Columns["cinsiyetid"].HeaderText = "CİNSİYETİD";
            data_pverid.Columns["cinsiyetid"].Width = 150;

            data_pverid.Columns["departmanid"].HeaderText = "DEPARTMANID";
            data_pverid.Columns["departmanid"].Width = 150;

            data_pverid.Columns["aktif_pasifd"].HeaderText = "AKTİF PASİFD";
            data_pverid.Columns["aktif_pasifd"].Width = 150;

            data_pverid.Columns["katd"].HeaderText = "KATID";
            data_pverid.Columns["katd"].Width = 150;

            data_pverid.Columns["odad"].HeaderText = "ODAD";
            data_pverid.Columns["odad"].Width = 150;

            data_pverid.Columns["dahilid"].HeaderText = "DAHILIID";
            data_pverid.Columns["dahilid"].Width = 150;

            
        }



        void veri_cekziyaretciler()
        {

            //TBL ZİYARETCİLER İCİN VOİD VERİCEK

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut = new SqlCommand("Select id, Adi, Soyadi, Telefonu, adresi, Firma_Adi, Kimlik_No, Departman, Ziyaret_edilecek_personel, Ziyaret_sebebi, Arac_markasi, arac_plakasi, aciklama from Tbl_ziyaretciler", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            grid_ziyaretcigirisveri.DataSource = dt;

            baglanti.Close();


            grid_ziyaretcigirisveri.Columns["id"].HeaderText = "ID";
            grid_ziyaretcigirisveri.Columns["id"].Width = 50;

            grid_ziyaretcigirisveri.Columns["Adi"].HeaderText = "ADI";
            grid_ziyaretcigirisveri.Columns["Adi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Soyadi"].HeaderText = "SOYADI";
            grid_ziyaretcigirisveri.Columns["Soyadi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Telefonu"].HeaderText = "TELEFONU";
            grid_ziyaretcigirisveri.Columns["Telefonu"].Width = 150;

            grid_ziyaretcigirisveri.Columns["adresi"].HeaderText = "ADRESİ";
            grid_ziyaretcigirisveri.Columns["adresi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Firma_Adi"].HeaderText = "FİRMA ADI";
            grid_ziyaretcigirisveri.Columns["Firma_Adi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Kimlik_No"].HeaderText = "KİMLİK NO";
            grid_ziyaretcigirisveri.Columns["Kimlik_No"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Departman"].HeaderText = "DEPARTMAN";
            grid_ziyaretcigirisveri.Columns["Departman"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Ziyaret_edilecek_personel"].HeaderText = "ZİYARET EDİLECEK PERSONEL";
            grid_ziyaretcigirisveri.Columns["Ziyaret_edilecek_personel"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Ziyaret_sebebi"].HeaderText = "ZİYARET SEBEBİ";
            grid_ziyaretcigirisveri.Columns["Ziyaret_sebebi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Arac_markasi"].HeaderText = "ARAÇ MARKASI";
            grid_ziyaretcigirisveri.Columns["Arac_markasi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["arac_plakasi"].HeaderText = "ARAÇ PLAKASI";
            grid_ziyaretcigirisveri.Columns["arac_plakasi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["aciklama"].HeaderText = "AÇIKLAMA";
            grid_ziyaretcigirisveri.Columns["aciklama"].Width = 150;



        }

        //TBL ARAC TAKIP AMA PERSONEL ICIN OLANAI

        void veri_cekaractakip_personel()
        {


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komute = new SqlCommand("Select idc, ziyaretci_durumuc, ziyaretci_kartnoc, arac_plakac, ziyaret_tarihic, cikis_tarihic, ziyaret_suresic, sofor_adisoyadic, tasima_sirketic, arac_markasic, evrak_noc, yuk_turuc from Tbl_aractakipc", baglanti);

            SqlDataAdapter dae = new SqlDataAdapter(komute);

            DataTable dte = new DataTable();

            dae.Fill(dte);

            data_zverid.DataSource = dte;

            baglanti.Close();


            data_zverid.Columns["idc"].HeaderText = "ID8";
            data_sofordurum.Columns["idc"].Width = 50;

            data_zverid.Columns["Ziyaretci_durumuc"].HeaderText = "ZİYARETÇİ DURUMU8";
            data_zverid.Columns["Ziyaretci_durumuc"].Width = 150;

            data_zverid.Columns["Ziyaretci_kartnoc"].HeaderText = "KART NO8";
            data_zverid.Columns["Ziyaretci_kartnoc"].Width = 150;

            data_zverid.Columns["arac_plakac"].HeaderText = "ARAÇ PLAKASI8";
            data_zverid.Columns["arac_plakac"].Width = 150;

            data_zverid.Columns["ziyaret_tarihic"].HeaderText = "ZİYARET TARİHİ8";
            data_zverid.Columns["ziyaret_tarihic"].Width = 150;

            data_zverid.Columns["cikis_tarihic"].HeaderText = "ÇIKIŞ TARİHİ8";
            data_zverid.Columns["cikis_tarihic"].Width = 150;

            data_zverid.Columns["ziyaret_suresic"].HeaderText = "ZİYARET SÜRESİ8";
            data_zverid.Columns["ziyaret_suresic"].Width = 150;

            data_zverid.Columns["sofor_adisoyadic"].HeaderText = "ŞOFÖR AD SOYAD8";
            data_zverid.Columns["sofor_adisoyadic"].Width = 150;

            data_zverid.Columns["tasima_sirketic"].HeaderText = "TAŞIMA ŞİRKETİ8";
            data_zverid.Columns["tasima_sirketic"].Width = 150;

            data_zverid.Columns["arac_markasic"].HeaderText = "ARAÇ MARKASI8";
            data_zverid.Columns["arac_markasic"].Width = 150;

            data_zverid.Columns["evrak_noc"].HeaderText = "EVRAK NUMARASI8";
            data_zverid.Columns["evrak_noc"].Width = 150;

            data_zverid.Columns["yuk_turuc"].HeaderText = "YÜK TÜRÜ8";
            data_zverid.Columns["yuk_turuc"].Width = 150;


        }

        //TBL ARAC TAKİP İCİN VOİD VERİCEK

        void veri_cekaractakip()
         {


                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }


                SqlCommand komut3 = new SqlCommand("Select idc, ziyaretci_durumuc, ziyaretci_kartnoc, arac_plakac, ziyaret_tarihic, cikis_tarihic, ziyaret_suresic, sofor_adisoyadic, tasima_sirketic, arac_markasic, evrak_noc, yuk_turuc from Tbl_aractakipc", baglanti);

                SqlDataAdapter da3 = new SqlDataAdapter(komut3);

                DataTable dt3 = new DataTable();

                da3.Fill(dt3);

                data_sofordurum.DataSource = dt3;

                baglanti.Close();


                data_sofordurum.Columns["idc"].HeaderText = "ID81";
                data_sofordurum.Columns["idc"].Width = 50;

                data_sofordurum.Columns["Ziyaretci_durumuc"].HeaderText = "ZİYARETÇİ DURUMU81";
                data_sofordurum.Columns["Ziyaretci_durumuc"].Width = 150;

                data_sofordurum.Columns["Ziyaretci_kartnoc"].HeaderText = "KART NO81";
                data_sofordurum.Columns["Ziyaretci_kartnoc"].Width = 150;

                data_sofordurum.Columns["arac_plakac"].HeaderText = "ARAÇ PLAKASI81";
                data_sofordurum.Columns["arac_plakac"].Width = 150;

                data_sofordurum.Columns["ziyaret_tarihic"].HeaderText = "ZİYARET TARİHİ81";
                data_sofordurum.Columns["ziyaret_tarihic"].Width = 150;

                data_sofordurum.Columns["cikis_tarihic"].HeaderText = "ÇIKIŞ TARİHİ81";
                data_sofordurum.Columns["cikis_tarihic"].Width = 150;

                data_sofordurum.Columns["ziyaret_suresic"].HeaderText = "ZİYARET SÜRESİ81";
                data_sofordurum.Columns["ziyaret_suresic"].Width = 150;

                data_sofordurum.Columns["sofor_adisoyadic"].HeaderText = "ŞOFÖR AD SOYAD81";
                data_sofordurum.Columns["sofor_adisoyadic"].Width = 150;

                data_sofordurum.Columns["tasima_sirketic"].HeaderText = "TAŞIMA ŞİRKETİ81";
                data_sofordurum.Columns["tasima_sirketic"].Width = 150;

                data_sofordurum.Columns["arac_markasic"].HeaderText = "ARAÇ MARKASI81";
                data_sofordurum.Columns["arac_markasic"].Width = 150;

                data_sofordurum.Columns["evrak_noc"].HeaderText = "EVRAK NUMARASI81";
                data_sofordurum.Columns["evrak_noc"].Width = 150;

                data_sofordurum.Columns["yuk_turuc"].HeaderText = "YÜK TÜRÜ81";
                data_sofordurum.Columns["yuk_turuc"].Width = 150;


            }

        //ZİYARETCİ BİLGİLERİ İÇİN VOİDVERİCEK


        void veri_ziyaretcibilgiler()
        {


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut1 = new SqlCommand("Select id, Ziyaretci_durumu, kart_no, ziyaret_tarihi, ziyaret_suresi, ad_soyad, kimlik_no, firma, departman, personel, ziyaret_sebeb from Tbl_ziyaretci_bilgileri ", baglanti);

            SqlDataAdapter da1 = new SqlDataAdapter(komut1);

            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            grid_ziyaretcibilgisveri.DataSource = dt1;

            baglanti.Close();


            grid_ziyaretcibilgisveri.Columns["id"].HeaderText = "ID2";
            grid_ziyaretcibilgisveri.Columns["id"].Width = 50;

            grid_ziyaretcibilgisveri.Columns["Ziyaretci_durumu"].HeaderText = "Z.DURUMU";
            grid_ziyaretcibilgisveri.Columns["Ziyaretci_durumu"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["kart_no"].HeaderText = "KART NUMARASI";
            grid_ziyaretcibilgisveri.Columns["kart_no"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ziyaret_tarihi"].HeaderText = "ZİYARET TARİHİ";
            grid_ziyaretcibilgisveri.Columns["ziyaret_tarihi"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ziyaret_suresi"].HeaderText = "ZİYARET SÜRESİ";
            grid_ziyaretcibilgisveri.Columns["ziyaret_suresi"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ad_soyad"].HeaderText = "ADI SOYADI";
            grid_ziyaretcibilgisveri.Columns["ad_soyad"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["kimlik_No"].HeaderText = "KİMLİK NO2";
            grid_ziyaretcibilgisveri.Columns["kimlik_No"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["departman"].HeaderText = "DEPARTMAN2";
            grid_ziyaretcibilgisveri.Columns["departman"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["personel"].HeaderText = "PERSONEL";
            grid_ziyaretcibilgisveri.Columns["personel"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ziyaret_sebeb"].HeaderText = "ZİYARET SEBEBİ2";
            grid_ziyaretcibilgisveri.Columns["ziyaret_sebeb"].Width = 150;
            
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

            data_soforveri.DataSource = dt7;

            baglanti.Close();


            data_soforveri.Columns["idb"].HeaderText = "IDb";
            data_soforveri.Columns["idb"].Width = 50;

            data_soforveri.Columns["sofor_adib"].HeaderText = "ŞOFÖR ADIB";
            data_soforveri.Columns["sofor_adib"].Width = 150;

            data_soforveri.Columns["sofor_soyadib"].HeaderText = "ŞOFÖR SOYADİb";
            data_soforveri.Columns["sofor_soyadib"].Width = 150;

            data_soforveri.Columns["sofor_numarasib"].HeaderText = "ŞOFÖR NUMARASIB";
            data_soforveri.Columns["sofor_numarasib"].Width = 150;

            data_soforveri.Columns["sofor_ehliyetib"].HeaderText = "ŞOFÖR EHLİYETİB";
            data_soforveri.Columns["sofor_ehliyetib"].Width = 150;

            data_soforveri.Columns["sofor_calistigisirketib"].HeaderText = "ÇALIŞTIĞI ŞİRKETB";
            data_soforveri.Columns["sofor_calistigisirketib"].Width = 150;

            data_soforveri.Columns["sofor_adresib"].HeaderText = "ADRESİB";
            data_soforveri.Columns["sofor_adresib"].Width = 150;
        }






        private void txt_arama1_TextChanged(object sender, EventArgs e)
        {


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut = new SqlCommand("Select id, Adi, Soyadi, Telefonu, adresi, Firma_Adi, Kimlik_No, Departman, Ziyaret_edilecek_personel, Ziyaret_sebebi, Arac_markasi, arac_plakasi, aciklama from Tbl_ziyaretciler where  Adi  like '" + txt_arama1.Text + "%'", baglanti);


            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            grid_ziyaretcigirisveri.DataSource = dt;

            baglanti.Close();


            grid_ziyaretcigirisveri.Columns["id"].HeaderText = "ID";
            grid_ziyaretcigirisveri.Columns["id"].Width = 50;

            grid_ziyaretcigirisveri.Columns["Adi"].HeaderText = "ADI";
            grid_ziyaretcigirisveri.Columns["Adi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Soyadi"].HeaderText = "SOYADI";
            grid_ziyaretcigirisveri.Columns["Soyadi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Telefonu"].HeaderText = "TELEFONU";
            grid_ziyaretcigirisveri.Columns["Telefonu"].Width = 150;

            grid_ziyaretcigirisveri.Columns["adresi"].HeaderText = "ADRESİ";
            grid_ziyaretcigirisveri.Columns["adresi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Firma_Adi"].HeaderText = "FİRMA ADI";
            grid_ziyaretcigirisveri.Columns["Firma_Adi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Kimlik_No"].HeaderText = "KİMLİK NO";
            grid_ziyaretcigirisveri.Columns["Kimlik_No"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Departman"].HeaderText = "DEPARTMAN";
            grid_ziyaretcigirisveri.Columns["Departman"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Ziyaret_edilecek_personel"].HeaderText = "ZİYARET EDİLECEK PERSONEL";
            grid_ziyaretcigirisveri.Columns["Ziyaret_edilecek_personel"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Ziyaret_sebebi"].HeaderText = "ZİYARET SEBEBİ";
            grid_ziyaretcigirisveri.Columns["Ziyaret_sebebi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["Arac_markasi"].HeaderText = "ARAÇ MARKASI";
            grid_ziyaretcigirisveri.Columns["Arac_markasi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["arac_plakasi"].HeaderText = "ARAÇ PLAKASI";
            grid_ziyaretcigirisveri.Columns["arac_plakasi"].Width = 150;

            grid_ziyaretcigirisveri.Columns["aciklama"].HeaderText = "AÇIKLAMA";
            grid_ziyaretcigirisveri.Columns["aciklama"].Width = 150;


        }

        private void btn_kayitara1_Click(object sender, EventArgs e)
        {
            txt_arama1.Text = "";
        }

        private void txt_arama2_TextChanged(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut1 = new SqlCommand("Select id, Ziyaretci_durumu, kart_no, ziyaret_tarihi, ziyaret_suresi, ad_soyad, kimlik_no, firma, departman, personel, ziyaret_sebeb from Tbl_ziyaretci_bilgileri where  Ziyaretci_durumu like '" + txt_arama2.Text + "%'", baglanti);

            SqlDataAdapter da1 = new SqlDataAdapter(komut1);

            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            grid_ziyaretcibilgisveri.DataSource = dt1;

            baglanti.Close();


            grid_ziyaretcibilgisveri.Columns["id"].HeaderText = "ID2";
            grid_ziyaretcibilgisveri.Columns["id"].Width = 50;

            grid_ziyaretcibilgisveri.Columns["Ziyaretci_durumu"].HeaderText = "Z.DURUMU";
            grid_ziyaretcibilgisveri.Columns["Ziyaretci_durumu"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["kart_no"].HeaderText = "KART NUMARASI";
            grid_ziyaretcibilgisveri.Columns["kart_no"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ziyaret_tarihi"].HeaderText = "ZİYARET TARİHİ";
            grid_ziyaretcibilgisveri.Columns["ziyaret_tarihi"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ziyaret_suresi"].HeaderText = "ZİYARET SÜRESİ";
            grid_ziyaretcibilgisveri.Columns["ziyaret_suresi"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ad_soyad"].HeaderText = "ADI SOYADI";
            grid_ziyaretcibilgisveri.Columns["ad_soyad"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["kimlik_No"].HeaderText = "KİMLİK NO2";
            grid_ziyaretcibilgisveri.Columns["kimlik_No"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["firma"].HeaderText = "FİRMA2";
            grid_ziyaretcibilgisveri.Columns["firma"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["departman"].HeaderText = "DEPARTMAN2";
            grid_ziyaretcibilgisveri.Columns["departman"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["personel"].HeaderText = "PERSONEL";
            grid_ziyaretcibilgisveri.Columns["personel"].Width = 150;

            grid_ziyaretcibilgisveri.Columns["ziyaret_sebeb"].HeaderText = "ZİYARET SEBEBİ2";
            grid_ziyaretcibilgisveri.Columns["ziyaret_sebeb"].Width = 150;


        }

        private void btn_kayitara2_Click(object sender, EventArgs e)
        {
            txt_arama2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_girisekle_Click(object sender, EventArgs e)
        {
            Form3 sayfa = new Form3();

            sayfa.ShowDialog();
        }

        private void btn_girisduzenle_Click(object sender, EventArgs e)
        {
            Form3 sayfa = new Form3();

            sayfa.ShowDialog();
        }

        private void btn_girissil_Click(object sender, EventArgs e)
        {
            Form3 sayfa = new Form3();

            sayfa.ShowDialog();
        }

        private void grid_ziyaretcigirisveri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_ziyaretcibilgisveri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_zekle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut0 = new SqlCommand("insert into Tbl_ziyaretci_bilgileri (Ziyaretci_durumu, kart_no, ziyaret_tarihi, ziyaret_suresi, ad_soyad, kimlik_no, firma, departman, personel, ziyaret_sebeb) values(@durumu, @kartno, @ziyarettarihi,@ziyaretsuresi,@adsoyad,@kimlikno,@firma,@departman,@personel,@ziyaretsebebi)", baglanti);



            komut0.Parameters.AddWithValue("@durumu", txt_durumu.Text);
            komut0.Parameters.AddWithValue("@kartno", txt_kartno.Text);
            komut0.Parameters.AddWithValue("@ziyarettarihi", txt_ziyarettarihi.Text);
            komut0.Parameters.AddWithValue("@ziyaretsuresi", txt_ziyaretsuresi.Text);
            komut0.Parameters.AddWithValue("@adsoyad", txt_adsoyad.Text);
            komut0.Parameters.AddWithValue("@kimlikno", txt_kimlikno.Text);
            komut0.Parameters.AddWithValue("@firma", txt_firma.Text);
            komut0.Parameters.AddWithValue("@departman", txt_departman.Text);
            komut0.Parameters.AddWithValue("@personel", txt_personel.Text);
            komut0.Parameters.AddWithValue("@ziyaretsebebi", txt_ziyaretsebebi.Text);

            komut0.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_ziyaretcibilgiler();
        }

        private void btn_aracekle_Click(object sender, EventArgs e)
        {
            Form4 sayfa = new Form4();

            sayfa.ShowDialog();
        }

        private void btn_aracduzenle_Click(object sender, EventArgs e)
        {
            Form4 sayfa = new Form4();

            sayfa.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form4 sayfa = new Form4();

            sayfa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)

                baglanti.Open();

            SqlCommand komut3 = new SqlCommand("insert into Tbl_aractakipc ( Ziyaretci_durumuc, Ziyaretci_kartnoc, arac_plakac, ziyaret_tarihic, cikis_tarihic, ziyaret_suresic, sofor_adisoyadic, tasima_sirketic, arac_markasic, evrak_noc, yuk_turuc)  Values (@Ziyaretci_durumuc, @Ziyaretci_kartnoc, @arac_plakac, @ziyaret_tarihic, @cikis_tarihic, @ziyaret_suresic, @sofor_adisoyadic, @tasima_sirketic, @arac_markasic, @evrak_noc, @yuk_turuc)", baglanti);
                                                    

            komut3.Parameters.AddWithValue("@Ziyaretci_durumuc", txt_zdurumuc.Text);
            komut3.Parameters.AddWithValue("@Ziyaretci_kartnoc", txt_zkartnoc.Text);
            komut3.Parameters.AddWithValue("@arac_plakac", txt_aracplakasic.Text);
            komut3.Parameters.AddWithValue("@ziyaret_tarihic", txt_ztarihic.Text);
            komut3.Parameters.AddWithValue("@cikis_tarihic", txt_cikistarihic.Text);
            komut3.Parameters.AddWithValue("@ziyaret_suresic", txt_zsuresic.Text);
            komut3.Parameters.AddWithValue("@sofor_adisoyadic", txt_soforadisoyadic.Text);
            komut3.Parameters.AddWithValue("@tasima_sirketic", txt_tasimasirketic.Text);
            komut3.Parameters.AddWithValue("@arac_markasic", txt_aracmarkasic.Text);
            komut3.Parameters.AddWithValue("@evrak_noc", txt_evraknoc.Text);
            komut3.Parameters.AddWithValue("@yuk_turuc", txt_yukturuc.Text);


            komut3.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_cekaractakip();
        }


        

        private void txt_aramaarac_TextChanged(object sender, EventArgs e)
        {
          
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
                                                                      
            SqlCommand komut7 = new SqlCommand("Select idb, sofor_adib, sofor_soyadib, sofor_numarasib, sofor_ehliyetib, sofor_calistigisirketib, sofor_adresib from Tbl_sofortakipb where  sofor_adib  like '" + txt_aramaarac.Text + "%'", baglanti);

            SqlDataAdapter da7 = new SqlDataAdapter(komut7);

            DataTable dt7 = new DataTable();

            da7.Fill(dt7);

            data_soforveri.DataSource = dt7;

            baglanti.Close();


            data_soforveri.Columns["idb"].HeaderText = "IDb";
            data_soforveri.Columns["idb"].Width = 50;

            data_soforveri.Columns["sofor_adib"].HeaderText = "ŞOFÖR ADIB";
            data_soforveri.Columns["sofor_adib"].Width = 150;

            data_soforveri.Columns["sofor_soyadib"].HeaderText = "ŞOFÖR SOYADİb";
            data_soforveri.Columns["sofor_soyadib"].Width = 150;

            data_soforveri.Columns["sofor_numarasib"].HeaderText = "ŞOFÖR NUMARASIB";
            data_soforveri.Columns["sofor_numarasib"].Width = 150;

            data_soforveri.Columns["sofor_ehliyetib"].HeaderText = "ŞOFÖR EHLİYETİB";
            data_soforveri.Columns["sofor_ehliyetib"].Width = 150;

            data_soforveri.Columns["sofor_calistigisirketib"].HeaderText = "ÇALIŞTIĞI ŞİRKETB";
            data_soforveri.Columns["sofor_calistigisirketib"].Width = 150;

            data_soforveri.Columns["sofor_adresib"].HeaderText = "ADRESİB";
            data_soforveri.Columns["sofor_adresib"].Width = 150;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_pekled_Click(object sender, EventArgs e)
        {
            Form5 sayfa = new Form5();

            sayfa.ShowDialog();
        }

        private void btn_pduzenled_Click(object sender, EventArgs e)
        {
            Form5 sayfa = new Form5();

            sayfa.ShowDialog();
        }

        private void btn_psild_Click(object sender, EventArgs e)
        {
            Form5 sayfa = new Form5();

            sayfa.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_ekled_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)

                baglanti.Open();

            SqlCommand komute = new SqlCommand("insert into Tbl_aractakipc (Ziyaretci_durumuc, Ziyaretci_kartnoc, arac_plakac, ziyaret_tarihic, cikis_tarihic, ziyaret_suresic, sofor_adisoyadic, tasima_sirketic, arac_markasic, evrak_noc, yuk_turuc)  Values (@Ziyaretci_durumud, @Ziyaretci_kartnod, @arac_plakad, @ziyaret_tarihid, @cikis_tarihid, @ziyaret_suresid, @sofor_adisoyadid, @tasima_sirketid, @arac_markasid, @evrak_nod, @yuk_turud)", baglanti);


            komute.Parameters.AddWithValue("@Ziyaretci_durumud", txt_zdurumud.Text);
            komute.Parameters.AddWithValue("@Ziyaretci_kartnod", txt_kartnod.Text);
            komute.Parameters.AddWithValue("@arac_plakad", txt_aracplakasid.Text);
            komute.Parameters.AddWithValue("@ziyaret_tarihid", txt_ztarihid.Text);
            komute.Parameters.AddWithValue("@cikis_tarihid", txt_cikistarihid.Text);
            komute.Parameters.AddWithValue("@ziyaret_suresid", txt_zsuresid.Text);
            komute.Parameters.AddWithValue("@sofor_adisoyadid", txt_soforadisoyadid.Text);
            komute.Parameters.AddWithValue("@tasima_sirketid", txt_tasimasirektid.Text);
            komute.Parameters.AddWithValue("@arac_markasid", txt_aracmarkasid.Text);
            komute.Parameters.AddWithValue("@evrak_nod", txt_evraknod.Text);
            komute.Parameters.AddWithValue("@yuk_turud", txt_yukturud.Text);


            komute.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

            veri_cekaractakip_personel();
        }

        private void btn_kapatd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_zkayitaramad_Click(object sender, EventArgs e)
        {
            txt_zaramad.Text = "";
        }

        private void btn_kayıtaraarac2_Click(object sender, EventArgs e)
        {
            txt_aramaarac2.Text = "";
        }

        private void btn_kayıtaraarac_Click(object sender, EventArgs e)
        {
            txt_aramaarac.Text = "";
        }

        private void txt_aramaarac2_TextChanged(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komut3 = new SqlCommand("Select idc, ziyaretci_durumuc, ziyaretci_kartnoc, arac_plakac, ziyaret_tarihic, cikis_tarihic, ziyaret_suresic, sofor_adisoyadic, tasima_sirketic, arac_markasic, evrak_noc, yuk_turuc from Tbl_aractakipc where ziyaretci_durumuc  like '" +  txt_aramaarac2.Text + "%'", baglanti);

            SqlDataAdapter da3 = new SqlDataAdapter(komut3);

            DataTable dt3 = new DataTable();

            da3.Fill(dt3);

            data_sofordurum.DataSource = dt3;

            baglanti.Close();


            data_sofordurum.Columns["idc"].HeaderText = "ID8";
            data_sofordurum.Columns["idc"].Width = 50;

            data_sofordurum.Columns["Ziyaretci_durumuc"].HeaderText = "ZİYARETÇİ DURUMU8";
            data_sofordurum.Columns["Ziyaretci_durumuc"].Width = 150;

            data_sofordurum.Columns["Ziyaretci_kartnoc"].HeaderText = "KART NO8";
            data_sofordurum.Columns["Ziyaretci_kartnoc"].Width = 150;

            data_sofordurum.Columns["arac_plakac"].HeaderText = "ARAÇ PLAKASI8";
            data_sofordurum.Columns["arac_plakac"].Width = 150;

            data_sofordurum.Columns["ziyaret_tarihic"].HeaderText = "ZİYARET TARİHİ8";
            data_sofordurum.Columns["ziyaret_tarihic"].Width = 150;

            data_sofordurum.Columns["cikis_tarihic"].HeaderText = "ÇIKIŞ TARİHİ8";
            data_sofordurum.Columns["cikis_tarihic"].Width = 150;

            data_sofordurum.Columns["ziyaret_suresic"].HeaderText = "ZİYARET SÜRESİ8";
            data_sofordurum.Columns["ziyaret_suresic"].Width = 150;

            data_sofordurum.Columns["sofor_adisoyadic"].HeaderText = "ŞOFÖR AD SOYAD8";
            data_sofordurum.Columns["sofor_adisoyadic"].Width = 150;

            data_sofordurum.Columns["tasima_sirketic"].HeaderText = "TAŞIMA ŞİRKETİ8";
            data_sofordurum.Columns["tasima_sirketic"].Width = 1150;

            data_sofordurum.Columns["arac_markasic"].HeaderText = "ARAÇ MARKASI8";
            data_sofordurum.Columns["arac_markasic"].Width = 150;

            data_sofordurum.Columns["evrak_noc"].HeaderText = "EVRAK NUMARASI8";
            data_sofordurum.Columns["evrak_noc"].Width = 150;

            data_sofordurum.Columns["yuk_turuc"].HeaderText = "YÜK TÜRÜ8";
            data_sofordurum.Columns["yuk_turuc"].Width = 150;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_pkayiyarad_Click(object sender, EventArgs e)
        {
            txt_paramad.Text = "";
        }

        private void txt_zaramad_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komute = new SqlCommand("Select idc, ziyaretci_durumuc, ziyaretci_kartnoc, arac_plakac, ziyaret_tarihic, cikis_tarihic, ziyaret_suresic, sofor_adisoyadic, tasima_sirketic, arac_markasic, evrak_noc, yuk_turuc from Tbl_aractakipc where ziyaretci_durumuc  like '" + txt_zaramad.Text + "%'", baglanti);

            SqlDataAdapter dae = new SqlDataAdapter(komute);

            DataTable dte = new DataTable();

            dae.Fill(dte);

            data_zverid.DataSource = dte;

            baglanti.Close();


            data_zverid.Columns["idc"].HeaderText = "ID8";
            data_zverid.Columns["idc"].Width = 50;

            data_zverid.Columns["Ziyaretci_durumuc"].HeaderText = "ZİYARETÇİ DURUMU8";
            data_zverid.Columns["Ziyaretci_durumuc"].Width = 150;

            data_zverid.Columns["Ziyaretci_kartnoc"].HeaderText = "KART NO8";
            data_zverid.Columns["Ziyaretci_kartnoc"].Width = 150;

            data_zverid.Columns["arac_plakac"].HeaderText = "ARAÇ PLAKASI8";
            data_zverid.Columns["arac_plakac"].Width = 150;

            data_zverid.Columns["ziyaret_tarihic"].HeaderText = "ZİYARET TARİHİ8";
            data_zverid.Columns["ziyaret_tarihic"].Width = 150;

            data_zverid.Columns["cikis_tarihic"].HeaderText = "ÇIKIŞ TARİHİ8";
            data_zverid.Columns["cikis_tarihic"].Width = 150;

            data_zverid.Columns["ziyaret_suresic"].HeaderText = "ZİYARET SÜRESİ8";
            data_zverid.Columns["ziyaret_suresic"].Width = 150;

            data_zverid.Columns["sofor_adisoyadic"].HeaderText = "ŞOFÖR AD SOYAD8";
            data_zverid.Columns["sofor_adisoyadic"].Width = 150;

            data_zverid.Columns["tasima_sirketic"].HeaderText = "TAŞIMA ŞİRKETİ8";
            data_zverid.Columns["tasima_sirketic"].Width = 150;

            data_zverid.Columns["arac_markasic"].HeaderText = "ARAÇ MARKASI8";
            data_zverid.Columns["arac_markasic"].Width = 150;

            data_zverid.Columns["evrak_noc"].HeaderText = "EVRAK NUMARASI8";
            data_zverid.Columns["evrak_noc"].Width = 150;

            data_zverid.Columns["yuk_turuc"].HeaderText = "YÜK TÜRÜ8";
            data_zverid.Columns["yuk_turuc"].Width = 150;

        }

        private void txt_paramad_TextChanged(object sender, EventArgs e)
        {
            
          
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutd = new SqlCommand("Select idd, personel_adid, personel_soyadid, ünvanid, cinsiyetid, departmanid, aktif_pasifd, katd, odad, dahilid from Tbl_personeld where  personel_adid  like '" + txt_paramad.Text + "%'", baglanti);

            SqlDataAdapter dad = new SqlDataAdapter(komutd);

            DataTable dtd = new DataTable();

            dad.Fill(dtd);

            data_pverid.DataSource = dtd;

            baglanti.Close();


            data_pverid.Columns["idd"].HeaderText = "IDD";
            data_pverid.Columns["idd"].Width = 50;

            data_pverid.Columns["personel_adid"].HeaderText = "ADID";
            data_pverid.Columns["personel_adid"].Width = 150;

            data_pverid.Columns["personel_soyadid"].HeaderText = "SOYADID";
            data_pverid.Columns["personel_soyadid"].Width = 150;

            data_pverid.Columns["ünvanid"].HeaderText = "ÜNVANID";
            data_pverid.Columns["ünvanid"].Width = 150;

            data_pverid.Columns["cinsiyetid"].HeaderText = "CİNSİYETİD";
            data_pverid.Columns["cinsiyetid"].Width = 150;

            data_pverid.Columns["departmanid"].HeaderText = "DEPARTMANID";
            data_pverid.Columns["departmanid"].Width = 150;

            data_pverid.Columns["aktif_pasifd"].HeaderText = "AKTİF PASİFD";
            data_pverid.Columns["aktif_pasifd"].Width = 150;

            data_pverid.Columns["katd"].HeaderText = "KATID";
            data_pverid.Columns["katd"].Width = 150;

            data_pverid.Columns["odad"].HeaderText = "ODAD";
            data_pverid.Columns["odad"].Width = 150;

            data_pverid.Columns["dahilid"].HeaderText = "DAHILIID";
            data_pverid.Columns["dahilid"].Width = 150;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 sayfa = new Form6();

            sayfa.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 sayfa = new Form6();

            sayfa.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form6 sayfa = new Form6();

            sayfa.ShowDialog();
        }

        private void btn_ptkayitara_Click(object sender, EventArgs e)
        {
            txt_ptarama.Text = "";
        }

        private void txt_ptarama_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutf = new SqlCommand("Select idf, sicil_nof, personel_adif, personel_unvanif from Tbl_personeltakipf where personel_adif like '" + txt_ptarama.Text + "%'", baglanti);

            SqlDataAdapter daf = new SqlDataAdapter(komutf);

            DataTable dtf = new DataTable();

            daf.Fill(dtf);

            data_ptveri.DataSource = dtf;

            baglanti.Close();


            data_ptveri.Columns["idf"].HeaderText = "IDF";
            data_ptveri.Columns["idf"].Width = 50;

            data_ptveri.Columns["sicil_nof"].HeaderText = "SİCİL NOF";
            data_ptveri.Columns["sicil_nof"].Width = 150;

            data_ptveri.Columns["personel_adif"].HeaderText = "ADIF";
            data_ptveri.Columns["personel_adif"].Width = 150;

            data_ptveri.Columns["personel_unvanif"].HeaderText = "UNVANIF";
            data_ptveri.Columns["personel_unvanif"].Width = 150;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pexceld_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < data_pverid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = data_pverid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data_pverid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < data_pverid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = data_pverid.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void btn_yazdir1_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_yazdir2_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_yazdırarac_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_yazdırarac2_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_zyazdırd_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_ptyazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();

            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < grid_ziyaretcigirisveri.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grid_ziyaretcigirisveri.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < grid_ziyaretcigirisveri.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grid_ziyaretcigirisveri.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grid_ziyaretcigirisveri.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < grid_ziyaretcibilgisveri.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grid_ziyaretcibilgisveri.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < grid_ziyaretcibilgisveri.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < grid_ziyaretcibilgisveri.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grid_ziyaretcibilgisveri.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void btn_excelearac_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < data_soforveri.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = data_soforveri.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data_soforveri.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < data_soforveri.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = data_soforveri.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void btn_excelarac2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < data_sofordurum.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = data_sofordurum.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data_sofordurum.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < data_sofordurum.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = data_sofordurum.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void btn_zexceld_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < data_zverid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = data_zverid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data_zverid.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < data_zverid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = data_zverid.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void btn_ptexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";


                for (int i = 1; i < data_ptveri.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = data_ptveri.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data_ptveri.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < data_ptveri.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = data_ptveri.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }
        }

        private void data_sofordurum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


