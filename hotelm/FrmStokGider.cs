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
    public partial class FrmStokGider : Form
    {
        public FrmStokGider()
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
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
                
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();            
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["internet"].ToString());

                listView2.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
                                          
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,icecek,Cerezler) values('" + TxtGida.Text + "','" + Txticecek.Text + "','" + TxtCerezler.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Faturalar (Elektrik,Su,internet) values('" + TxtE.Text + "','" + TxtSu.Text + "','" + Txtinternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
