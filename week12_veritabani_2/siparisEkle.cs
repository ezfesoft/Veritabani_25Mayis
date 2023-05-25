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
    public partial class siparisEkle : Form
    {
        public siparisEkle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string musteriAdi;
        string musteriSoyad;
        string musteriCinsiyet;
        string musteriTelefon;
        string musteriAdres;
        string siparisDetay = "";
        string siparisTutar;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 2)
            {
                musteriAdi = txtAd.Text;
                musteriSoyad = txtSoyad.Text;
                if (rbKadin.Checked==true)
                {
                    musteriCinsiyet = "K";
                }
                else
                {
                    musteriCinsiyet = "E";
                }
                musteriTelefon = txtTelefon.Text;
                musteriAdres = txtAdres.Text;

                //------

                siparisDetay += "Çorba:" + numCorba.Value.ToString() +"\r \n"; 
                siparisDetay += "Salata: " + numSalata.Value.ToString() + "\r \n";
                siparisDetay += "Ana Yemek: " + numAnayemek.Value.ToString() + "\r \n";
                siparisDetay += "Tatlı: " + numTatli.Value.ToString();

                decimal tutar = numCorba.Value * 30 + numSalata.Value * 20 + numAnayemek.Value * 80 + numTatli.Value * 30;
                siparisTutar = tutar.ToString();

                //------
                txtDetay.Text = musteriAdi + " " + musteriSoyad + "\r \n" + musteriTelefon+"\r \n"+musteriAdres + "\r \n" +siparisDetay;
                txtTutar.Text = siparisTutar;
            }
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            string baglantiCumlesi = "Data Source=(localdb)\\slymn;Initial Catalog=veritabani_ntp;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            baglanti.Open();
            string sqlCumlesi = "";
            sqlCumlesi += "INSERT INTO siparisler ";
            sqlCumlesi += "(musteriAd, musteriSoyad, musteriCinsiyet, musteriTelefon, musteriAdres, siparisDetay, siparisTutar) ";
            sqlCumlesi += "VALUES";
            sqlCumlesi += "('" + musteriAdi + "','" + musteriSoyad + "','" + musteriCinsiyet;
            sqlCumlesi += "','" + musteriTelefon + "','" + musteriAdres + "','" + siparisDetay + "','" + siparisTutar + "')";

            SqlCommand komut1 = new SqlCommand(sqlCumlesi, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();

            DialogResult cevap = MessageBox.Show("Kayıt Girildi", "Bilgi!", MessageBoxButtons.OK);
            if (cevap==DialogResult.OK)
            {
                this.Close();
            }
               
        }
    }
}
