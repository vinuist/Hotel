
namespace hotelm
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnToplam = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.BtnMesaj = new System.Windows.Forms.Button();
            this.BtnRadyo = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnGazate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(133, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(272, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "Yeni Müşteri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.BackColor = System.Drawing.Color.Khaki;
            this.BtnOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOdalar.Location = new System.Drawing.Point(410, 119);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(107, 54);
            this.BtnOdalar.TabIndex = 0;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = false;
            this.BtnOdalar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Maroon;
            this.btnCikis.Location = new System.Drawing.Point(751, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(43, 30);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnToplam
            // 
            this.BtnToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnToplam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnToplam.Location = new System.Drawing.Point(133, 218);
            this.BtnToplam.Name = "BtnToplam";
            this.BtnToplam.Size = new System.Drawing.Size(107, 54);
            this.BtnToplam.TabIndex = 6;
            this.BtnToplam.Text = "Gelir Gider Formu";
            this.BtnToplam.UseVisualStyleBackColor = false;
            this.BtnToplam.Click += new System.EventHandler(this.BtnToplam_Click);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStok.Location = new System.Drawing.Point(273, 218);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(107, 54);
            this.btnStok.TabIndex = 7;
            this.btnStok.Text = "Stok ve Giderler";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // BtnMesaj
            // 
            this.BtnMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMesaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMesaj.Location = new System.Drawing.Point(410, 218);
            this.BtnMesaj.Name = "BtnMesaj";
            this.BtnMesaj.Size = new System.Drawing.Size(107, 54);
            this.BtnMesaj.TabIndex = 8;
            this.BtnMesaj.Text = "Müşteri Mesajları";
            this.BtnMesaj.UseVisualStyleBackColor = false;
            this.BtnMesaj.Click += new System.EventHandler(this.BtnMesaj_Click);
            // 
            // BtnRadyo
            // 
            this.BtnRadyo.BackColor = System.Drawing.Color.Yellow;
            this.BtnRadyo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRadyo.Location = new System.Drawing.Point(547, 218);
            this.BtnRadyo.Name = "BtnRadyo";
            this.BtnRadyo.Size = new System.Drawing.Size(107, 54);
            this.BtnRadyo.TabIndex = 9;
            this.BtnRadyo.Text = "Radyo Dinle";
            this.BtnRadyo.UseVisualStyleBackColor = false;
            this.BtnRadyo.Click += new System.EventHandler(this.BtnRadyo_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusteriler.Location = new System.Drawing.Point(547, 119);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(107, 54);
            this.BtnMusteriler.TabIndex = 10;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = false;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnGazate
            // 
            this.BtnGazate.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnGazate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGazate.Location = new System.Drawing.Point(133, 307);
            this.BtnGazate.Name = "BtnGazate";
            this.BtnGazate.Size = new System.Drawing.Size(107, 54);
            this.BtnGazate.TabIndex = 13;
            this.BtnGazate.Text = "Gazeteler";
            this.BtnGazate.UseVisualStyleBackColor = false;
            this.BtnGazate.Click += new System.EventHandler(this.BtnGazate_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 424);
            this.Controls.Add(this.BtnGazate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnRadyo);
            this.Controls.Add(this.BtnMesaj);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.BtnToplam);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnOdalar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button BtnToplam;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button BtnMesaj;
        private System.Windows.Forms.Button BtnRadyo;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnGazate;
    }
}