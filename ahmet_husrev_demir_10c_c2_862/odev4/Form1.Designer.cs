namespace odev4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbox_OgrenciBilgi = new System.Windows.Forms.GroupBox();
            this.btn_ogrenci_kaydet = new System.Windows.Forms.Button();
            this.date_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_ogrenciNo = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tumKayitSil = new System.Windows.Forms.Button();
            this.btn_SeciliSil = new System.Windows.Forms.Button();
            this.btn_OgrenciNoSirala = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox_OgrenciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_OgrenciBilgi
            // 
            this.gbox_OgrenciBilgi.Controls.Add(this.btn_ogrenci_kaydet);
            this.gbox_OgrenciBilgi.Controls.Add(this.date_dogumTarihi);
            this.gbox_OgrenciBilgi.Controls.Add(this.cbox_cinsiyet);
            this.gbox_OgrenciBilgi.Controls.Add(this.txt_ogrenciNo);
            this.gbox_OgrenciBilgi.Controls.Add(this.txt_isim);
            this.gbox_OgrenciBilgi.Controls.Add(this.txt_tcNo);
            this.gbox_OgrenciBilgi.Controls.Add(this.label10);
            this.gbox_OgrenciBilgi.Controls.Add(this.label9);
            this.gbox_OgrenciBilgi.Controls.Add(this.label8);
            this.gbox_OgrenciBilgi.Controls.Add(this.label7);
            this.gbox_OgrenciBilgi.Controls.Add(this.label6);
            this.gbox_OgrenciBilgi.Controls.Add(this.label5);
            this.gbox_OgrenciBilgi.Controls.Add(this.label4);
            this.gbox_OgrenciBilgi.Controls.Add(this.label3);
            this.gbox_OgrenciBilgi.Controls.Add(this.label2);
            this.gbox_OgrenciBilgi.Controls.Add(this.label1);
            this.gbox_OgrenciBilgi.Location = new System.Drawing.Point(18, 16);
            this.gbox_OgrenciBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_OgrenciBilgi.Name = "gbox_OgrenciBilgi";
            this.gbox_OgrenciBilgi.Padding = new System.Windows.Forms.Padding(4);
            this.gbox_OgrenciBilgi.Size = new System.Drawing.Size(399, 255);
            this.gbox_OgrenciBilgi.TabIndex = 0;
            this.gbox_OgrenciBilgi.TabStop = false;
            this.gbox_OgrenciBilgi.Text = "ÖĞRENCİ BİLGİLERİ :";
            // 
            // btn_ogrenci_kaydet
            // 
            this.btn_ogrenci_kaydet.Location = new System.Drawing.Point(69, 207);
            this.btn_ogrenci_kaydet.Name = "btn_ogrenci_kaydet";
            this.btn_ogrenci_kaydet.Size = new System.Drawing.Size(232, 38);
            this.btn_ogrenci_kaydet.TabIndex = 15;
            this.btn_ogrenci_kaydet.Text = "ÖĞRENCİ KAYDET";
            this.btn_ogrenci_kaydet.UseVisualStyleBackColor = true;
            this.btn_ogrenci_kaydet.Click += new System.EventHandler(this.btn_ogrenci_kaydet_Click);
            // 
            // date_dogumTarihi
            // 
            this.date_dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dogumTarihi.Location = new System.Drawing.Point(181, 137);
            this.date_dogumTarihi.Name = "date_dogumTarihi";
            this.date_dogumTarihi.Size = new System.Drawing.Size(205, 23);
            this.date_dogumTarihi.TabIndex = 14;
            this.date_dogumTarihi.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // cbox_cinsiyet
            // 
            this.cbox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_cinsiyet.FormattingEnabled = true;
            this.cbox_cinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cbox_cinsiyet.Location = new System.Drawing.Point(180, 102);
            this.cbox_cinsiyet.Name = "cbox_cinsiyet";
            this.cbox_cinsiyet.Size = new System.Drawing.Size(206, 25);
            this.cbox_cinsiyet.TabIndex = 13;
            // 
            // txt_ogrenciNo
            // 
            this.txt_ogrenciNo.Location = new System.Drawing.Point(180, 174);
            this.txt_ogrenciNo.Name = "txt_ogrenciNo";
            this.txt_ogrenciNo.Size = new System.Drawing.Size(206, 23);
            this.txt_ogrenciNo.TabIndex = 12;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(181, 66);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(205, 23);
            this.txt_isim.TabIndex = 11;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(181, 32);
            this.txt_tcNo.MaxLength = 11;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(205, 23);
            this.txt_tcNo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ÖĞRENCİ NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CİNSİYET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI SOYADI";
            // 
            // liste
            // 
            this.liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.liste.FullRowSelect = true;
            this.liste.GridLines = true;
            this.liste.HideSelection = false;
            this.liste.Location = new System.Drawing.Point(10, 277);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(690, 218);
            this.liste.TabIndex = 1;
            this.liste.UseCompatibleStateImageBehavior = false;
            this.liste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad Soyad";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cinsiyet";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "T.C. No";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 175;
            // 
            // btn_tumKayitSil
            // 
            this.btn_tumKayitSil.Location = new System.Drawing.Point(425, 169);
            this.btn_tumKayitSil.Name = "btn_tumKayitSil";
            this.btn_tumKayitSil.Size = new System.Drawing.Size(269, 48);
            this.btn_tumKayitSil.TabIndex = 2;
            this.btn_tumKayitSil.Text = "TÜM KAYITLARI SİL";
            this.btn_tumKayitSil.UseVisualStyleBackColor = true;
            this.btn_tumKayitSil.Click += new System.EventHandler(this.btn_tumKayitSil_Click);
            // 
            // btn_SeciliSil
            // 
            this.btn_SeciliSil.Location = new System.Drawing.Point(425, 223);
            this.btn_SeciliSil.Name = "btn_SeciliSil";
            this.btn_SeciliSil.Size = new System.Drawing.Size(269, 48);
            this.btn_SeciliSil.TabIndex = 3;
            this.btn_SeciliSil.Text = "SEÇİLİ OLAN KAYDI SİL";
            this.btn_SeciliSil.UseVisualStyleBackColor = true;
            this.btn_SeciliSil.Click += new System.EventHandler(this.btn_SeciliSil_Click);
            // 
            // btn_OgrenciNoSirala
            // 
            this.btn_OgrenciNoSirala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OgrenciNoSirala.Location = new System.Drawing.Point(425, 108);
            this.btn_OgrenciNoSirala.Name = "btn_OgrenciNoSirala";
            this.btn_OgrenciNoSirala.Size = new System.Drawing.Size(269, 53);
            this.btn_OgrenciNoSirala.TabIndex = 4;
            this.btn_OgrenciNoSirala.Text = "Öğrenciyi Numaraya Göre Sırala";
            this.btn_OgrenciNoSirala.UseVisualStyleBackColor = false;
            this.btn_OgrenciNoSirala.Click += new System.EventHandler(this.btn_OgrenciNoSirala_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(684, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_OgrenciNoSirala);
            this.Controls.Add(this.btn_SeciliSil);
            this.Controls.Add(this.btn_tumKayitSil);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.gbox_OgrenciBilgi);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kaydetme";
            this.gbox_OgrenciBilgi.ResumeLayout(false);
            this.gbox_OgrenciBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_OgrenciBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_cinsiyet;
        private System.Windows.Forms.TextBox txt_ogrenciNo;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView liste;
        private System.Windows.Forms.DateTimePicker date_dogumTarihi;
        private System.Windows.Forms.Button btn_tumKayitSil;
        private System.Windows.Forms.Button btn_SeciliSil;
        private System.Windows.Forms.Button btn_ogrenci_kaydet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_OgrenciNoSirala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

