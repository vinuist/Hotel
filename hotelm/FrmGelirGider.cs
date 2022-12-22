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
    public partial class FrmGelirGider : Form
    {
      
        public FrmGelirGider()
        {
            InitializeComponent();
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
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACA-777;Initial Catalog=otel;Integrated Security=True");
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(TxtPer.Text);
            lblMaas.Text = (personel * 4200).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasa.Text) - (Convert.ToInt32(lblMaas.Text) + Convert.ToInt32(lblelektrik.Text) + Convert.ToInt32(lblinternet.Text) + Convert.ToInt32(lblsu.Text) + Convert.ToInt32(lblUrun.Text) + Convert.ToInt32(lblUrun2.Text) + Convert.ToInt32(lblUrun3.Text));
            lblSonuc.Text = sonuc.ToString();

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
  
            //kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasa.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            //stokların giderleri

            baglanti.Open();
            SqlCommand komuts = new SqlCommand(" Select sum(Gida) as top1, sum(icecek) as top2 ,sum(Cerezler) as top3 from Stoklar", baglanti);
            SqlDataReader okus = komuts.ExecuteReader();
            while (okus.Read())
            {
                lblUrun.Text = okus["top1"].ToString();
                lblUrun2.Text = okus["top2"].ToString();
                lblUrun3.Text = okus["top3"].ToString();
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komutf = new SqlCommand(" Select sum(Elektrik) as tope, sum(Su) as tops ,sum(internet) as topi from Faturalar", baglanti);
            SqlDataReader okuf = komutf.ExecuteReader();
            while (okuf.Read())
            {
                lblelektrik.Text = okuf["tope"].ToString();
                lblsu.Text = okuf["tops"].ToString();
                lblinternet.Text = okuf["topi"].ToString();
            }
            baglanti.Close();


        }
    }
}
