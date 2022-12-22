
namespace hotelm
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.btnCikis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnVeriGoster = new System.Windows.Forms.Button();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnOdaSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Maroon;
            this.btnCikis.Location = new System.Drawing.Point(866, 2);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(57, 39);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 70);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(744, 166);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 58;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC ";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 37;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda No";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 66;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giriş Tarihi";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 96;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Çıkış Tarihi";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ücret";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 72;
            // 
            // BtnVeriGoster
            // 
            this.BtnVeriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnVeriGoster.Location = new System.Drawing.Point(673, 270);
            this.BtnVeriGoster.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVeriGoster.Name = "BtnVeriGoster";
            this.BtnVeriGoster.Size = new System.Drawing.Size(122, 28);
            this.BtnVeriGoster.TabIndex = 7;
            this.BtnVeriGoster.Text = "Müşteri Listesi";
            this.BtnVeriGoster.UseVisualStyleBackColor = false;
            this.BtnVeriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Tanımsız"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(115, 333);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(184, 25);
            this.CmbCinsiyet.TabIndex = 29;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.White;
            this.lblCinsiyet.Location = new System.Drawing.Point(45, 336);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(66, 20);
            this.lblCinsiyet.TabIndex = 28;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.SystemColors.Window;
            this.TxtUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(438, 404);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(186, 27);
            this.TxtUcret.TabIndex = 27;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.BackColor = System.Drawing.Color.Transparent;
            this.lblUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.ForeColor = System.Drawing.Color.White;
            this.lblUcret.Location = new System.Drawing.Point(382, 404);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(50, 20);
            this.lblUcret.TabIndex = 26;
            this.lblUcret.Text = "Ücret:";
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(113, 267);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(186, 27);
            this.TxtAdi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adı:";
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.SystemColors.Window;
            this.MskTxtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(115, 366);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(184, 27);
            this.MskTxtTelefon.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyadı:";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(438, 371);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 27);
            this.DtpCikisTarihi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefonu:";
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(436, 336);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 27);
            this.DtpGirisTarihi.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mail:";
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNo.Location = new System.Drawing.Point(436, 303);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(186, 27);
            this.TxtOdaNo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "T.C. Kimlik no:";
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTcNo.Location = new System.Drawing.Point(436, 263);
            this.TxtTcNo.MaxLength = 11;
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(186, 27);
            this.TxtTcNo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(323, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Oda Numarası:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(115, 399);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(186, 27);
            this.TxtMail.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(349, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Location = new System.Drawing.Point(113, 300);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(186, 27);
            this.TxtSoyadi.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(348, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(489, 31);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(160, 25);
            this.TxtAra.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "İsim:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuncelle.Location = new System.Drawing.Point(673, 306);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(122, 28);
            this.BtnGuncelle.TabIndex = 32;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSil.Location = new System.Drawing.Point(673, 341);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(122, 28);
            this.BtnSil.TabIndex = 33;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAra.Location = new System.Drawing.Point(673, 28);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(122, 35);
            this.BtnAra.TabIndex = 34;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnTemizle.Location = new System.Drawing.Point(673, 375);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(122, 28);
            this.BtnTemizle.TabIndex = 35;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnOdaSil
            // 
            this.BtnOdaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnOdaSil.Location = new System.Drawing.Point(673, 409);
            this.BtnOdaSil.Name = "BtnOdaSil";
            this.BtnOdaSil.Size = new System.Drawing.Size(122, 28);
            this.BtnOdaSil.TabIndex = 37;
            this.BtnOdaSil.Text = "Odadan Sil";
            this.BtnOdaSil.UseVisualStyleBackColor = false;
            this.BtnOdaSil.Click += new System.EventHandler(this.BtnOdaSil_Click);
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 502);
            this.Controls.Add(this.BtnOdaSil);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTcNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnVeriGoster);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCikis);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnVeriGoster;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnOdaSil;
    }
}