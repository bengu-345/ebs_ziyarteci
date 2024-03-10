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
    public partial class Ziyaretci_giris : Form

    {
        public Ziyaretci_giris()
        {
            InitializeComponent();
        }

        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ziyaretci_giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_ziyaretci_giris where Kullanici_Adi=@kullanici_adi AND Parola=@parola", baglanti);


            komut.Parameters.AddWithValue("@kullanici_adi", txt_kullaniciadi.Text);
            komut.Parameters.AddWithValue("@parola", txt_parola.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                Form2 sayfa = new Form2();

                sayfa.ShowDialog();


            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();



        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
