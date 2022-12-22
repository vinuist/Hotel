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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACA-777;Initial Catalog=otel;Integrated Security=True");
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi and Sifre=@Sifresi ";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", TxtKullaniciAdi.Text.Trim()); // trim boş karakter vs önler
                SqlParameter prm2 = new SqlParameter("Sifresi",TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtAd.Text + "',Sifre='" + txtSifre2.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Şifre Güncellendi");
            baglanti.Close();
            
        }


    }
}
