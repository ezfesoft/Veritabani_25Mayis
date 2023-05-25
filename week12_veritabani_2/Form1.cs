using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace week12_veritabani_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string baglantiCumlesi= "Data Source=(localdb)\\slymn;Initial Catalog=veritabani_ntp;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            string komut1_sql = "SELECT COUNT(musteriID) AS [Total] FROM [siparisler]";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand(komut1_sql,baglanti);
            SqlDataReader okuyucu = komut1.ExecuteReader();
            okuyucu.Read();
            labelSiparisTotal.Text = okuyucu["Total"].ToString();
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            siparisEkle formEkle = new siparisEkle();
            formEkle.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            string baglantiCumlesi = "Data Source=(localdb)\\slymn;Initial Catalog=veritabani_ntp;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            string komut1_sql = "SELECT COUNT(musteriID) AS [Total] FROM [siparisler]";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand(komut1_sql, baglanti);
            SqlDataReader okuyucu = komut1.ExecuteReader();
            okuyucu.Read();
            labelSiparisTotal.Text = okuyucu["Total"].ToString();
            baglanti.Close();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            SiparisGoruntule form_siparis_goruntule = new SiparisGoruntule();
            form_siparis_goruntule.ShowDialog();
        }
    }
}
