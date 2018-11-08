namespace tren
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVarisSaati = new System.Windows.Forms.TextBox();
            this.txtKalkisSaati = new System.Windows.Forms.TextBox();
            this.dtVaris = new System.Windows.Forms.DateTimePicker();
            this.dtKalkis = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnMKaydet = new System.Windows.Forms.Button();
            this.listBoxMusteri1 = new System.Windows.Forms.ListBox();
            this.txtVarisYeri = new System.Windows.Forms.TextBox();
            this.txtKalkisYeri = new System.Windows.Forms.TextBox();
            this.btnSKaydet = new System.Windows.Forms.Button();
            this.listBoxMusteri2 = new System.Windows.Forms.ListBox();
            this.listBoxSefer2 = new System.Windows.Forms.ListBox();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnBiletKes = new System.Windows.Forms.Button();
            this.listBoxSefer = new System.Windows.Forms.ListBox();
            this.listBoxBilet = new System.Windows.Forms.ListBox();
            this.listBoxRez2 = new System.Windows.Forms.ListBox();
            this.listBoxRez = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.rbOgrenci = new System.Windows.Forms.RadioButton();
            this.rbTam = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxMusteri1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(829, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişi Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.groupBox1.Controls.Add(this.btnMKaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(302, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tc Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(137, 194);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(148, 84);
            this.txtAdres.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(137, 162);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(148, 22);
            this.txtTel.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 130);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(137, 98);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(148, 22);
            this.txtTcNo.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(137, 66);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(148, 22);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(137, 34);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(148, 22);
            this.txtAd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(829, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sefer Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxSefer);
            this.groupBox2.Controls.Add(this.btnSKaydet);
            this.groupBox2.Controls.Add(this.txtKalkisYeri);
            this.groupBox2.Controls.Add(this.txtUcret);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVarisYeri);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtVarisSaati);
            this.groupBox2.Controls.Add(this.txtKalkisSaati);
            this.groupBox2.Controls.Add(this.dtVaris);
            this.groupBox2.Controls.Add(this.dtKalkis);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(811, 516);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sefer Ekle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Varış";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kalkış";
            // 
            // txtVarisSaati
            // 
            this.txtVarisSaati.Location = new System.Drawing.Point(606, 82);
            this.txtVarisSaati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVarisSaati.Name = "txtVarisSaati";
            this.txtVarisSaati.Size = new System.Drawing.Size(50, 22);
            this.txtVarisSaati.TabIndex = 1;
            this.txtVarisSaati.Text = "12:00";
            // 
            // txtKalkisSaati
            // 
            this.txtKalkisSaati.Location = new System.Drawing.Point(606, 43);
            this.txtKalkisSaati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKalkisSaati.Name = "txtKalkisSaati";
            this.txtKalkisSaati.Size = new System.Drawing.Size(50, 22);
            this.txtKalkisSaati.TabIndex = 1;
            this.txtKalkisSaati.Text = "12:00";
            // 
            // dtVaris
            // 
            this.dtVaris.Location = new System.Drawing.Point(397, 82);
            this.dtVaris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtVaris.Name = "dtVaris";
            this.dtVaris.Size = new System.Drawing.Size(201, 22);
            this.dtVaris.TabIndex = 0;
            // 
            // dtKalkis
            // 
            this.dtKalkis.Location = new System.Drawing.Point(397, 43);
            this.dtKalkis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtKalkis.Name = "dtKalkis";
            this.dtKalkis.Size = new System.Drawing.Size(201, 22);
            this.dtKalkis.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRezervasyon);
            this.tabPage3.Controls.Add(this.listBoxRez);
            this.tabPage3.Controls.Add(this.listBoxSefer2);
            this.tabPage3.Controls.Add(this.listBoxMusteri2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(829, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rezervasyon Yap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rbTam);
            this.tabPage4.Controls.Add(this.rbOgrenci);
            this.tabPage4.Controls.Add(this.listBoxBilet);
            this.tabPage4.Controls.Add(this.listBoxRez2);
            this.tabPage4.Controls.Add(this.btnBiletKes);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(829, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bilet Kes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnMKaydet
            // 
            this.btnMKaydet.Location = new System.Drawing.Point(210, 285);
            this.btnMKaydet.Name = "btnMKaydet";
            this.btnMKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMKaydet.TabIndex = 2;
            this.btnMKaydet.Text = "Kaydet";
            this.btnMKaydet.UseVisualStyleBackColor = true;
            this.btnMKaydet.Click += new System.EventHandler(this.btnMKaydet_Click);
            // 
            // listBoxMusteri1
            // 
            this.listBoxMusteri1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxMusteri1.FormattingEnabled = true;
            this.listBoxMusteri1.ItemHeight = 16;
            this.listBoxMusteri1.Location = new System.Drawing.Point(637, 4);
            this.listBoxMusteri1.Name = "listBoxMusteri1";
            this.listBoxMusteri1.Size = new System.Drawing.Size(188, 525);
            this.listBoxMusteri1.TabIndex = 2;
            // 
            // txtVarisYeri
            // 
            this.txtVarisYeri.Location = new System.Drawing.Point(101, 82);
            this.txtVarisYeri.Name = "txtVarisYeri";
            this.txtVarisYeri.Size = new System.Drawing.Size(238, 22);
            this.txtVarisYeri.TabIndex = 3;
            // 
            // txtKalkisYeri
            // 
            this.txtKalkisYeri.Location = new System.Drawing.Point(101, 43);
            this.txtKalkisYeri.Name = "txtKalkisYeri";
            this.txtKalkisYeri.Size = new System.Drawing.Size(238, 22);
            this.txtKalkisYeri.TabIndex = 3;
            // 
            // btnSKaydet
            // 
            this.btnSKaydet.Location = new System.Drawing.Point(648, 484);
            this.btnSKaydet.Name = "btnSKaydet";
            this.btnSKaydet.Size = new System.Drawing.Size(87, 23);
            this.btnSKaydet.TabIndex = 4;
            this.btnSKaydet.Text = "Kaydet";
            this.btnSKaydet.UseVisualStyleBackColor = true;
            this.btnSKaydet.Click += new System.EventHandler(this.btnSKaydet_Click);
            // 
            // listBoxMusteri2
            // 
            this.listBoxMusteri2.FormattingEnabled = true;
            this.listBoxMusteri2.ItemHeight = 16;
            this.listBoxMusteri2.Location = new System.Drawing.Point(12, 55);
            this.listBoxMusteri2.Name = "listBoxMusteri2";
            this.listBoxMusteri2.Size = new System.Drawing.Size(193, 404);
            this.listBoxMusteri2.TabIndex = 0;
            // 
            // listBoxSefer2
            // 
            this.listBoxSefer2.FormattingEnabled = true;
            this.listBoxSefer2.ItemHeight = 16;
            this.listBoxSefer2.Location = new System.Drawing.Point(225, 55);
            this.listBoxSefer2.Name = "listBoxSefer2";
            this.listBoxSefer2.Size = new System.Drawing.Size(207, 404);
            this.listBoxSefer2.TabIndex = 0;
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Location = new System.Drawing.Point(438, 413);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(125, 46);
            this.btnRezervasyon.TabIndex = 1;
            this.btnRezervasyon.Text = "Rezervasyon yap";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnBiletKes
            // 
            this.btnBiletKes.Location = new System.Drawing.Point(257, 210);
            this.btnBiletKes.Name = "btnBiletKes";
            this.btnBiletKes.Size = new System.Drawing.Size(125, 46);
            this.btnBiletKes.TabIndex = 4;
            this.btnBiletKes.Text = "Bilet Kes";
            this.btnBiletKes.UseVisualStyleBackColor = true;
            this.btnBiletKes.Click += new System.EventHandler(this.btnBiletKes_Click);
            // 
            // listBoxSefer
            // 
            this.listBoxSefer.FormattingEnabled = true;
            this.listBoxSefer.ItemHeight = 16;
            this.listBoxSefer.Location = new System.Drawing.Point(27, 119);
            this.listBoxSefer.Name = "listBoxSefer";
            this.listBoxSefer.Size = new System.Drawing.Size(372, 388);
            this.listBoxSefer.TabIndex = 5;
            // 
            // listBoxBilet
            // 
            this.listBoxBilet.FormattingEnabled = true;
            this.listBoxBilet.ItemHeight = 16;
            this.listBoxBilet.Location = new System.Drawing.Point(405, 36);
            this.listBoxBilet.Name = "listBoxBilet";
            this.listBoxBilet.Size = new System.Drawing.Size(266, 404);
            this.listBoxBilet.TabIndex = 5;
            this.listBoxBilet.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxRez2
            // 
            this.listBoxRez2.FormattingEnabled = true;
            this.listBoxRez2.ItemHeight = 16;
            this.listBoxRez2.Location = new System.Drawing.Point(17, 36);
            this.listBoxRez2.Name = "listBoxRez2";
            this.listBoxRez2.Size = new System.Drawing.Size(207, 404);
            this.listBoxRez2.TabIndex = 6;
            // 
            // listBoxRez
            // 
            this.listBoxRez.FormattingEnabled = true;
            this.listBoxRez.ItemHeight = 16;
            this.listBoxRez.Location = new System.Drawing.Point(569, 55);
            this.listBoxRez.Name = "listBoxRez";
            this.listBoxRez.Size = new System.Drawing.Size(257, 404);
            this.listBoxRez.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ücret";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(497, 129);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(101, 22);
            this.txtUcret.TabIndex = 3;
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Location = new System.Drawing.Point(257, 133);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(79, 21);
            this.rbOgrenci.TabIndex = 7;
            this.rbOgrenci.Text = "Öğrenci";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            // 
            // rbTam
            // 
            this.rbTam.AutoSize = true;
            this.rbTam.Checked = true;
            this.rbTam.Location = new System.Drawing.Point(257, 160);
            this.rbTam.Name = "rbTam";
            this.rbTam.Size = new System.Drawing.Size(57, 21);
            this.rbTam.TabIndex = 7;
            this.rbTam.TabStop = true;
            this.rbTam.Text = "Tam";
            this.rbTam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 593);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tren Otomasyon";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVarisSaati;
        private System.Windows.Forms.TextBox txtKalkisSaati;
        private System.Windows.Forms.DateTimePicker dtVaris;
        private System.Windows.Forms.DateTimePicker dtKalkis;
        private System.Windows.Forms.ListBox listBoxMusteri1;
        private System.Windows.Forms.Button btnMKaydet;
        private System.Windows.Forms.TextBox txtVarisYeri;
        private System.Windows.Forms.TextBox txtKalkisYeri;
        private System.Windows.Forms.Button btnSKaydet;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.ListBox listBoxSefer2;
        private System.Windows.Forms.ListBox listBoxMusteri2;
        private System.Windows.Forms.Button btnBiletKes;
        private System.Windows.Forms.ListBox listBoxSefer;
        private System.Windows.Forms.ListBox listBoxBilet;
        private System.Windows.Forms.ListBox listBoxRez2;
        private System.Windows.Forms.ListBox listBoxRez;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbTam;
        private System.Windows.Forms.RadioButton rbOgrenci;

    }
}

