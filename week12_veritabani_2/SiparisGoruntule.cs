using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace week12_veritabani_2
{
    public partial class SiparisGoruntule : Form
    {
        public SiparisGoruntule()
        {
            InitializeComponent();
        }

        ArrayList musteriIDler = new ArrayList();

        private void SiparisGoruntule_Load(object sender, EventArgs e)
        {
            string baglantiCumlesi= "Data Source=(localdb)\\slymn;Initial Catalog=veritabani_ntp;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            baglanti.Open();
            string sqlCumlesi = "";
            sqlCumlesi += "SELECT [musteriId] " +
                ",[musteriAd] " +
                ",[musteriSoyad] " +
                ",[musteriTelefon] " +
                ",[musteriAdres] " +
                ",[siparisDetay] " +
                ",[siparisTutar] " +
                "FROM [siparisler]";
            SqlCommand komut = new SqlCommand(sqlCumlesi,baglanti);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                listeSiparisler.Items.Add(okuyucu["musteriAd"] + " " + okuyucu["musteriSoyad"]);
                musteriIDler.Add(okuyucu["musteriId"]);
           
            }

            okuyucu.Close();
            baglanti.Close();
        }

        private void listeSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {

            string baglantiCumlesi = "Data Source=(localdb)\\slymn;Initial Catalog=veritabani_ntp;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string sqlCumlem = "SELECT [musteriAd],[musteriSoyad],[musteriTelefon],[musteriAdres]," +
                "[siparisDetay],[siparisTutar] FROM [siparisler] " +
                "WHERE musteriId=" + musteriIDler[listeSiparisler.SelectedIndex].ToString();
            SqlCommand komut1 = new SqlCommand(sqlCumlem, baglanti);
            SqlDataReader reader = komut1.ExecuteReader();
            reader.Read();
            txtSiparisDetay.Text = "";
            txtSiparisDetay.Text += reader["musteriAd"] + " ";
            txtSiparisDetay.Text += reader["musteriSoyad"] + "\r \n";
            txtSiparisDetay.Text += "------------------- \r \n";
            txtSiparisDetay.Text += reader["musteriTelefon"] + "\r \n";
            txtSiparisDetay.Text += reader["musteriAdres"] + "\r \n";
            txtSiparisDetay.Text += "------------------- \r \n";
            txtSiparisDetay.Text += reader["siparisDetay"] + "\r \n";
            txtSiparisDetay.Text += "------------------- \r \n";
            txtSiparisDetay.Text += reader["siparisTutar"] + " TL \r \n";
            txtSiparisDetay.Text += "------------------- \r \n";
            reader.Close();
            baglanti.Close();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap==DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void belge_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtSiparisDetay.Text, txtSiparisDetay.Font, 
                Brushes.Black, new Point(100, 100));

        }
    }
}
