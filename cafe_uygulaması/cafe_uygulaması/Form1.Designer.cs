namespace cafe_uygulaması
{
    partial class DEMIR_CAFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEMIR_CAFE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1000para = new System.Windows.Forms.Button();
            this.btn500para = new System.Windows.Forms.Button();
            this.btn200para = new System.Windows.Forms.Button();
            this.lblmoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sepetlistbox = new System.Windows.Forms.ListBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pboxpizza = new System.Windows.Forms.PictureBox();
            this.pboxhamburger = new System.Windows.Forms.PictureBox();
            this.pboxpancake = new System.Windows.Forms.PictureBox();
            this.pboxhotdog = new System.Windows.Forms.PictureBox();
            this.pboxcupcake = new System.Windows.Forms.PictureBox();
            this.pboxcheese = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxhamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxpancake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxhotdog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxcupcake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxcheese)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn1000para);
            this.panel1.Controls.Add(this.btn500para);
            this.panel1.Controls.Add(this.btn200para);
            this.panel1.Controls.Add(this.lblmoney);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 342);
            this.panel1.TabIndex = 0;
            // 
            // btn1000para
            // 
            this.btn1000para.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000para.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.btn1000para.Location = new System.Drawing.Point(3, 185);
            this.btn1000para.Name = "btn1000para";
            this.btn1000para.Size = new System.Drawing.Size(164, 37);
            this.btn1000para.TabIndex = 3;
            this.btn1000para.Text = "1000₺ YATIR";
            this.btn1000para.UseVisualStyleBackColor = true;
            this.btn1000para.Click += new System.EventHandler(this.btn1000para_Click);
            // 
            // btn500para
            // 
            this.btn500para.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500para.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.btn500para.Location = new System.Drawing.Point(4, 142);
            this.btn500para.Name = "btn500para";
            this.btn500para.Size = new System.Drawing.Size(164, 37);
            this.btn500para.TabIndex = 3;
            this.btn500para.Text = "500₺ YATIR";
            this.btn500para.UseVisualStyleBackColor = true;
            this.btn500para.Click += new System.EventHandler(this.btn500para_Click);
            // 
            // btn200para
            // 
            this.btn200para.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200para.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.btn200para.Location = new System.Drawing.Point(3, 99);
            this.btn200para.Name = "btn200para";
            this.btn200para.Size = new System.Drawing.Size(164, 37);
            this.btn200para.TabIndex = 3;
            this.btn200para.Text = "200₺ YATIR";
            this.btn200para.UseVisualStyleBackColor = true;
            this.btn200para.Click += new System.EventHandler(this.btn200para_Click);
            // 
            // lblmoney
            // 
            this.lblmoney.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblmoney.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.lblmoney.Location = new System.Drawing.Point(0, 302);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(170, 40);
            this.lblmoney.TabIndex = 2;
            this.lblmoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(0, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEMİR CAFE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.sepetlistbox);
            this.panel2.Controls.Add(this.btnpay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(630, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 342);
            this.panel2.TabIndex = 1;
            // 
            // sepetlistbox
            // 
            this.sepetlistbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sepetlistbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.sepetlistbox.FormattingEnabled = true;
            this.sepetlistbox.ItemHeight = 25;
            this.sepetlistbox.Location = new System.Drawing.Point(0, 88);
            this.sepetlistbox.Name = "sepetlistbox";
            this.sepetlistbox.Size = new System.Drawing.Size(170, 204);
            this.sepetlistbox.TabIndex = 2;
            // 
            // btnpay
            // 
            this.btnpay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.btnpay.Location = new System.Drawing.Point(0, 289);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(170, 53);
            this.btnpay.TabIndex = 1;
            this.btnpay.Text = "PAY";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEPET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pboxpizza);
            this.panel3.Controls.Add(this.pboxhamburger);
            this.panel3.Controls.Add(this.pboxpancake);
            this.panel3.Controls.Add(this.pboxhotdog);
            this.panel3.Controls.Add(this.pboxcupcake);
            this.panel3.Controls.Add(this.pboxcheese);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(170, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 342);
            this.panel3.TabIndex = 2;
            // 
            // pboxpizza
            // 
            this.pboxpizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxpizza.Image = ((System.Drawing.Image)(resources.GetObject("pboxpizza.Image")));
            this.pboxpizza.Location = new System.Drawing.Point(313, 175);
            this.pboxpizza.Name = "pboxpizza";
            this.pboxpizza.Size = new System.Drawing.Size(144, 124);
            this.pboxpizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxpizza.TabIndex = 0;
            this.pboxpizza.TabStop = false;
            this.pboxpizza.Click += new System.EventHandler(this.pboxpizza_Click);
            // 
            // pboxhamburger
            // 
            this.pboxhamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxhamburger.Image = ((System.Drawing.Image)(resources.GetObject("pboxhamburger.Image")));
            this.pboxhamburger.Location = new System.Drawing.Point(313, 12);
            this.pboxhamburger.Name = "pboxhamburger";
            this.pboxhamburger.Size = new System.Drawing.Size(147, 124);
            this.pboxhamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxhamburger.TabIndex = 0;
            this.pboxhamburger.TabStop = false;
            this.pboxhamburger.Click += new System.EventHandler(this.pboxhamburger_Click);
            // 
            // pboxpancake
            // 
            this.pboxpancake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxpancake.Image = ((System.Drawing.Image)(resources.GetObject("pboxpancake.Image")));
            this.pboxpancake.Location = new System.Drawing.Point(156, 175);
            this.pboxpancake.Name = "pboxpancake";
            this.pboxpancake.Size = new System.Drawing.Size(151, 124);
            this.pboxpancake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxpancake.TabIndex = 0;
            this.pboxpancake.TabStop = false;
            this.pboxpancake.Click += new System.EventHandler(this.pboxpancake_Click);
            // 
            // pboxhotdog
            // 
            this.pboxhotdog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxhotdog.Image = ((System.Drawing.Image)(resources.GetObject("pboxhotdog.Image")));
            this.pboxhotdog.Location = new System.Drawing.Point(0, 175);
            this.pboxhotdog.Name = "pboxhotdog";
            this.pboxhotdog.Size = new System.Drawing.Size(147, 124);
            this.pboxhotdog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxhotdog.TabIndex = 0;
            this.pboxhotdog.TabStop = false;
            this.pboxhotdog.Click += new System.EventHandler(this.pboxhotdog_Click);
            // 
            // pboxcupcake
            // 
            this.pboxcupcake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxcupcake.Image = ((System.Drawing.Image)(resources.GetObject("pboxcupcake.Image")));
            this.pboxcupcake.Location = new System.Drawing.Point(156, 12);
            this.pboxcupcake.Name = "pboxcupcake";
            this.pboxcupcake.Size = new System.Drawing.Size(151, 124);
            this.pboxcupcake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxcupcake.TabIndex = 0;
            this.pboxcupcake.TabStop = false;
            this.pboxcupcake.Click += new System.EventHandler(this.pboxcupcake_Click);
            // 
            // pboxcheese
            // 
            this.pboxcheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxcheese.Image = ((System.Drawing.Image)(resources.GetObject("pboxcheese.Image")));
            this.pboxcheese.Location = new System.Drawing.Point(0, 12);
            this.pboxcheese.Name = "pboxcheese";
            this.pboxcheese.Size = new System.Drawing.Size(147, 124);
            this.pboxcheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxcheese.TabIndex = 0;
            this.pboxcheese.TabStop = false;
            this.pboxcheese.Click += new System.EventHandler(this.pboxcheese_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "120₺";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(160, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "50₺";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(310, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "100₺";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "80₺";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(156, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "50₺";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(315, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "100₺";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.button1.Location = new System.Drawing.Point(3, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "2000₺ YATIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.button2.Location = new System.Drawing.Point(7, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "SEPETİ TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DEMIR_CAFE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DEMIR_CAFE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMİR CAFE";
            this.Load += new System.EventHandler(this.DEMIR_CAFE_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxhamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxpancake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxhotdog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxcupcake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxcheese)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pboxcheese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxpizza;
        private System.Windows.Forms.PictureBox pboxhamburger;
        private System.Windows.Forms.PictureBox pboxpancake;
        private System.Windows.Forms.PictureBox pboxhotdog;
        private System.Windows.Forms.PictureBox pboxcupcake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.ListBox sepetlistbox;
        private System.Windows.Forms.Button btn1000para;
        private System.Windows.Forms.Button btn500para;
        private System.Windows.Forms.Button btn200para;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

