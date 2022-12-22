
namespace hotelm
{
    partial class FrmStokGider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokGider));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGida = new System.Windows.Forms.TextBox();
            this.Txticecek = new System.Windows.Forms.TextBox();
            this.TxtCerezler = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.Txtinternet = new System.Windows.Forms.TextBox();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblelektrik = new System.Windows.Forms.Label();
            this.BtnKaydet2 = new System.Windows.Forms.Button();
            this.grbM = new System.Windows.Forms.GroupBox();
            this.grbF = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbM.SuspendLayout();
            this.grbF.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atıştırmalıklar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "İçecek Tutarı:";
            // 
            // TxtGida
            // 
            this.TxtGida.Location = new System.Drawing.Point(117, 30);
            this.TxtGida.Name = "TxtGida";
            this.TxtGida.Size = new System.Drawing.Size(100, 25);
            this.TxtGida.TabIndex = 3;
            // 
            // Txticecek
            // 
            this.Txticecek.Location = new System.Drawing.Point(117, 65);
            this.Txticecek.Name = "Txticecek";
            this.Txticecek.Size = new System.Drawing.Size(100, 25);
            this.Txticecek.TabIndex = 4;
            // 
            // TxtCerezler
            // 
            this.TxtCerezler.Location = new System.Drawing.Point(117, 100);
            this.TxtCerezler.Name = "TxtCerezler";
            this.TxtCerezler.Size = new System.Drawing.Size(100, 25);
            this.TxtCerezler.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(250, 47);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 43);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Maroon;
            this.btnCikis.Location = new System.Drawing.Point(696, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(43, 30);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 156);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 163);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 99;
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(99, 108);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(100, 25);
            this.TxtSu.TabIndex = 14;
            // 
            // Txtinternet
            // 
            this.Txtinternet.Location = new System.Drawing.Point(99, 73);
            this.Txtinternet.Name = "Txtinternet";
            this.Txtinternet.Size = new System.Drawing.Size(100, 25);
            this.Txtinternet.TabIndex = 13;
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(99, 38);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(100, 25);
            this.TxtE.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Su:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "İnternet:";
            // 
            // lblelektrik
            // 
            this.lblelektrik.AutoSize = true;
            this.lblelektrik.Location = new System.Drawing.Point(23, 41);
            this.lblelektrik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblelektrik.Name = "lblelektrik";
            this.lblelektrik.Size = new System.Drawing.Size(56, 17);
            this.lblelektrik.TabIndex = 9;
            this.lblelektrik.Text = "Elektrik:";
            // 
            // BtnKaydet2
            // 
            this.BtnKaydet2.Location = new System.Drawing.Point(99, 139);
            this.BtnKaydet2.Name = "BtnKaydet2";
            this.BtnKaydet2.Size = new System.Drawing.Size(89, 29);
            this.BtnKaydet2.TabIndex = 15;
            this.BtnKaydet2.Text = "Kaydet";
            this.BtnKaydet2.UseVisualStyleBackColor = true;
            this.BtnKaydet2.Click += new System.EventHandler(this.BtnKaydet2_Click);
            // 
            // grbM
            // 
            this.grbM.BackColor = System.Drawing.Color.Transparent;
            this.grbM.Controls.Add(this.Txticecek);
            this.grbM.Controls.Add(this.label1);
            this.grbM.Controls.Add(this.label2);
            this.grbM.Controls.Add(this.label3);
            this.grbM.Controls.Add(this.TxtGida);
            this.grbM.Controls.Add(this.TxtCerezler);
            this.grbM.Controls.Add(this.BtnKaydet);
            this.grbM.Controls.Add(this.listView1);
            this.grbM.Location = new System.Drawing.Point(12, 12);
            this.grbM.Name = "grbM";
            this.grbM.Size = new System.Drawing.Size(352, 342);
            this.grbM.TabIndex = 16;
            this.grbM.TabStop = false;
            this.grbM.Text = "Mutfak";
            // 
            // grbF
            // 
            this.grbF.BackColor = System.Drawing.Color.Transparent;
            this.grbF.Controls.Add(this.listView2);
            this.grbF.Controls.Add(this.Txtinternet);
            this.grbF.Controls.Add(this.lblelektrik);
            this.grbF.Controls.Add(this.BtnKaydet2);
            this.grbF.Controls.Add(this.label5);
            this.grbF.Controls.Add(this.TxtSu);
            this.grbF.Controls.Add(this.label4);
            this.grbF.Controls.Add(this.TxtE);
            this.grbF.Location = new System.Drawing.Point(389, 12);
            this.grbF.Name = "grbF";
            this.grbF.Size = new System.Drawing.Size(287, 342);
            this.grbF.TabIndex = 17;
            this.grbF.TabStop = false;
            this.grbF.Text = "Faturalar";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(56, 174);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(191, 145);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 43;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 78;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 434);
            this.Controls.Add(this.grbF);
            this.Controls.Add(this.grbM);
            this.Controls.Add(this.btnCikis);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar ";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.grbM.ResumeLayout(false);
            this.grbM.PerformLayout();
            this.grbF.ResumeLayout(false);
            this.grbF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGida;
        private System.Windows.Forms.TextBox Txticecek;
        private System.Windows.Forms.TextBox TxtCerezler;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox Txtinternet;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblelektrik;
        private System.Windows.Forms.Button BtnKaydet2;
        private System.Windows.Forms.GroupBox grbM;
        private System.Windows.Forms.GroupBox grbF;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}