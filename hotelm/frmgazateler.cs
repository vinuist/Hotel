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
    public partial class frmgazateler : Form
    {
        public frmgazateler()
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
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cumhuriyet.com.tr");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
