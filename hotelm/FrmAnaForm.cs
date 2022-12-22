using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelm
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
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
        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris fr = new AdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmYeniMusteri fr = new frmYeniMusteri();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnStok_Click(object sender, EventArgs e)
        {
            FrmStokGider fr = new FrmStokGider();
            fr.Show();
            

        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnToplam_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
            this.Hide();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FrmRadyo fr = new FrmRadyo();
            fr.Show();
        }

        private void BtnGazate_Click(object sender, EventArgs e)
        {
            frmgazateler fr = new frmgazateler();
            fr.Show();
        }

        private void BtnMesaj_Click(object sender, EventArgs e)
        {
            frmMesajlar fr = new frmMesajlar();
            fr.Show();
        }
    }
}
