using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hotelm
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACA-777;Initial Catalog=otel;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());             
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }

                    return;
            }
            base.WndProc(ref m);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbCinsiyet.Text= listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcNo.Text= listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text= listView1.SelectedItems[0].SubItems[7].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[10].Text;
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbCinsiyet.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtTcNo.Clear();
            TxtOdaNo.Clear(); //odayı boşaltmasın!!!
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            TxtUcret.Clear();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+"',Cinsiyet='"+CmbCinsiyet.Text+"',Telefon='"+MskTxtTelefon.Text+"',Mail='"+TxtMail.Text+"',TC='"+TxtTcNo.Text+"',OdaNo='"+TxtOdaNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"' where Musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+TxtAra.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnOdaSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda101", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }

            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda102", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda103", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda104", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda105", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda106", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda107", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda108", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda109", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }
    }
}
