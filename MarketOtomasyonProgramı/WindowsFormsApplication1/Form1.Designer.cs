namespace WindowsFormsApplication1
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
            this.tabSatis = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listKatalog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listStok = new System.Windows.Forms.ListBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTanim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunTanim = new System.Windows.Forms.TextBox();
            this.txtUrunIsim = new System.Windows.Forms.TextBox();
            this.txtUrunMiktar = new System.Windows.Forms.TextBox();
            this.txtUrunKod = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAciklma = new System.Windows.Forms.Label();
            this.radioNakit = new System.Windows.Forms.RadioButton();
            this.radioKart = new System.Windows.Forms.RadioButton();
            this.lblUrünIsmi = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblMusteriTel = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.btnUrünEkle = new System.Windows.Forms.Button();
            this.listSatis = new System.Windows.Forms.ListBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblFiyatı = new System.Windows.Forms.Label();
            this.lblUrünFiyati = new System.Windows.Forms.Label();
            this.lblUrünSec = new System.Windows.Forms.Label();
            this.cmbUrunSecimi = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listHesap = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabSatis.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSatis
            // 
            this.tabSatis.Controls.Add(this.tabPage1);
            this.tabSatis.Controls.Add(this.tabPage2);
            this.tabSatis.Controls.Add(this.tabPage3);
            this.tabSatis.Controls.Add(this.tabPage4);
            this.tabSatis.Location = new System.Drawing.Point(3, 3);
            this.tabSatis.Name = "tabSatis";
            this.tabSatis.SelectedIndex = 0;
            this.tabSatis.Size = new System.Drawing.Size(538, 314);
            this.tabSatis.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listKatalog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Katalog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listKatalog
            // 
            this.listKatalog.FormattingEnabled = true;
            this.listKatalog.Location = new System.Drawing.Point(5, 6);
            this.listKatalog.Name = "listKatalog";
            this.listKatalog.Size = new System.Drawing.Size(501, 277);
            this.listKatalog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listStok);
            this.tabPage2.Controls.Add(this.lblFiyat);
            this.tabPage2.Controls.Add(this.lblTanim);
            this.tabPage2.Controls.Add(this.lblIsim);
            this.tabPage2.Controls.Add(this.lblMiktar);
            this.tabPage2.Controls.Add(this.lblKod);
            this.tabPage2.Controls.Add(this.txtUrunFiyat);
            this.tabPage2.Controls.Add(this.btnTemizle);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtUrunTanim);
            this.tabPage2.Controls.Add(this.txtUrunIsim);
            this.tabPage2.Controls.Add(this.txtUrunMiktar);
            this.tabPage2.Controls.Add(this.txtUrunKod);
            this.tabPage2.Controls.Add(this.btnEkle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listStok
            // 
            this.listStok.FormattingEnabled = true;
            this.listStok.Location = new System.Drawing.Point(3, 178);
            this.listStok.Name = "listStok";
            this.listStok.Size = new System.Drawing.Size(500, 108);
            this.listStok.TabIndex = 29;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(54, 125);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(32, 13);
            this.lblFiyat.TabIndex = 28;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblTanim
            // 
            this.lblTanim.AutoSize = true;
            this.lblTanim.Location = new System.Drawing.Point(22, 98);
            this.lblTanim.Name = "lblTanim";
            this.lblTanim.Size = new System.Drawing.Size(67, 13);
            this.lblTanim.TabIndex = 27;
            this.lblTanim.Text = "Ürün Tanımı:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(32, 72);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(54, 13);
            this.lblIsim.TabIndex = 26;
            this.lblIsim.Text = "Ürün İsmi:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(22, 46);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(67, 13);
            this.lblMiktar.TabIndex = 25;
            this.lblMiktar.Text = "Ürün Miktarı:";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(28, 22);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(61, 13);
            this.lblKod.TabIndex = 24;
            this.lblKod.Text = "Ürün Kodu:";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(92, 122);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyat.TabIndex = 23;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(219, 46);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // txtUrunTanim
            // 
            this.txtUrunTanim.Location = new System.Drawing.Point(92, 95);
            this.txtUrunTanim.Name = "txtUrunTanim";
            this.txtUrunTanim.Size = new System.Drawing.Size(100, 20);
            this.txtUrunTanim.TabIndex = 20;
            // 
            // txtUrunIsim
            // 
            this.txtUrunIsim.Location = new System.Drawing.Point(92, 69);
            this.txtUrunIsim.Name = "txtUrunIsim";
            this.txtUrunIsim.Size = new System.Drawing.Size(100, 20);
            this.txtUrunIsim.TabIndex = 19;
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.Location = new System.Drawing.Point(92, 43);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtUrunMiktar.TabIndex = 18;
            // 
            // txtUrunKod
            // 
            this.txtUrunKod.Location = new System.Drawing.Point(92, 17);
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.Size = new System.Drawing.Size(100, 20);
            this.txtUrunKod.TabIndex = 17;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(219, 17);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.lblAciklma);
            this.tabPage3.Controls.Add(this.radioNakit);
            this.tabPage3.Controls.Add(this.radioKart);
            this.tabPage3.Controls.Add(this.lblUrünIsmi);
            this.tabPage3.Controls.Add(this.lblUrun);
            this.tabPage3.Controls.Add(this.lblMusteriTel);
            this.tabPage3.Controls.Add(this.lblMusteriSoyad);
            this.tabPage3.Controls.Add(this.lblMusteriAd);
            this.tabPage3.Controls.Add(this.txtMusteriTel);
            this.tabPage3.Controls.Add(this.txtMusteriSoyad);
            this.tabPage3.Controls.Add(this.txtMusteriAd);
            this.tabPage3.Controls.Add(this.btnUrünEkle);
            this.tabPage3.Controls.Add(this.listSatis);
            this.tabPage3.Controls.Add(this.txtToplam);
            this.tabPage3.Controls.Add(this.lblToplam);
            this.tabPage3.Controls.Add(this.btnHesapla);
            this.tabPage3.Controls.Add(this.lblAdet);
            this.tabPage3.Controls.Add(this.txtAdet);
            this.tabPage3.Controls.Add(this.lblFiyatı);
            this.tabPage3.Controls.Add(this.lblUrünFiyati);
            this.tabPage3.Controls.Add(this.lblUrünSec);
            this.tabPage3.Controls.Add(this.cmbUrunSecimi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(530, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Satış";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblAciklma
            // 
            this.lblAciklma.AutoSize = true;
            this.lblAciklma.Location = new System.Drawing.Point(313, 148);
            this.lblAciklma.Name = "lblAciklma";
            this.lblAciklma.Size = new System.Drawing.Size(182, 26);
            this.lblAciklma.TabIndex = 22;
            this.lblAciklma.Text = "Nakit alış-verişlerde %10 indirim\r\nKredi Kartı ile alış-verişlerde %10 fazla\r\n";
            // 
            // radioNakit
            // 
            this.radioNakit.AutoSize = true;
            this.radioNakit.Location = new System.Drawing.Point(417, 109);
            this.radioNakit.Name = "radioNakit";
            this.radioNakit.Size = new System.Drawing.Size(50, 17);
            this.radioNakit.TabIndex = 21;
            this.radioNakit.TabStop = true;
            this.radioNakit.Text = "Nakit";
            this.radioNakit.UseVisualStyleBackColor = true;
            // 
            // radioKart
            // 
            this.radioKart.AutoSize = true;
            this.radioKart.Location = new System.Drawing.Point(325, 109);
            this.radioKart.Name = "radioKart";
            this.radioKart.Size = new System.Drawing.Size(73, 17);
            this.radioKart.TabIndex = 20;
            this.radioKart.TabStop = true;
            this.radioKart.Text = "Kredi Kartı";
            this.radioKart.UseVisualStyleBackColor = true;
            // 
            // lblUrünIsmi
            // 
            this.lblUrünIsmi.AutoSize = true;
            this.lblUrünIsmi.Location = new System.Drawing.Point(88, 50);
            this.lblUrünIsmi.Name = "lblUrünIsmi";
            this.lblUrünIsmi.Size = new System.Drawing.Size(0, 13);
            this.lblUrünIsmi.TabIndex = 19;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(21, 50);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(54, 13);
            this.lblUrun.TabIndex = 18;
            this.lblUrun.Text = "Ürün İsmi:";
            // 
            // lblMusteriTel
            // 
            this.lblMusteriTel.AutoSize = true;
            this.lblMusteriTel.Location = new System.Drawing.Point(290, 77);
            this.lblMusteriTel.Name = "lblMusteriTel";
            this.lblMusteriTel.Size = new System.Drawing.Size(80, 13);
            this.lblMusteriTel.TabIndex = 16;
            this.lblMusteriTel.Text = "Müşteri Telefon";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(290, 50);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(82, 13);
            this.lblMusteriSoyad.TabIndex = 15;
            this.lblMusteriSoyad.Text = "Müşteri Soyisim:";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(290, 24);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(65, 13);
            this.lblMusteriAd.TabIndex = 14;
            this.lblMusteriAd.Text = "Müşteri İsim:";
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Location = new System.Drawing.Point(385, 70);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriTel.TabIndex = 13;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(385, 43);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriSoyad.TabIndex = 12;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(385, 17);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriAd.TabIndex = 11;
            // 
            // btnUrünEkle
            // 
            this.btnUrünEkle.Location = new System.Drawing.Point(24, 120);
            this.btnUrünEkle.Name = "btnUrünEkle";
            this.btnUrünEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrünEkle.TabIndex = 10;
            this.btnUrünEkle.Text = "Ekle";
            this.btnUrünEkle.UseVisualStyleBackColor = true;
            this.btnUrünEkle.Click += new System.EventHandler(this.btnUrünEkle_Click);
            // 
            // listSatis
            // 
            this.listSatis.FormattingEnabled = true;
            this.listSatis.Location = new System.Drawing.Point(24, 148);
            this.listSatis.Name = "listSatis";
            this.listSatis.Size = new System.Drawing.Size(249, 95);
            this.listSatis.TabIndex = 9;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(67, 261);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(206, 20);
            this.txtToplam.TabIndex = 8;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(19, 264);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(42, 13);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "Toplam";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(105, 120);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(81, 23);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(21, 73);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(32, 13);
            this.lblAdet.TabIndex = 5;
            this.lblAdet.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(91, 70);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(179, 20);
            this.txtAdet.TabIndex = 4;
            // 
            // lblFiyatı
            // 
            this.lblFiyatı.AutoSize = true;
            this.lblFiyatı.Location = new System.Drawing.Point(88, 100);
            this.lblFiyatı.Name = "lblFiyatı";
            this.lblFiyatı.Size = new System.Drawing.Size(29, 13);
            this.lblFiyatı.TabIndex = 3;
            this.lblFiyatı.Text = "0 TL";
            // 
            // lblUrünFiyati
            // 
            this.lblUrünFiyati.AutoSize = true;
            this.lblUrünFiyati.Location = new System.Drawing.Point(21, 100);
            this.lblUrünFiyati.Name = "lblUrünFiyati";
            this.lblUrünFiyati.Size = new System.Drawing.Size(35, 13);
            this.lblUrünFiyati.TabIndex = 2;
            this.lblUrünFiyati.Text = "Tutar:";
            // 
            // lblUrünSec
            // 
            this.lblUrünSec.AutoSize = true;
            this.lblUrünSec.Location = new System.Drawing.Point(21, 24);
            this.lblUrünSec.Name = "lblUrünSec";
            this.lblUrünSec.Size = new System.Drawing.Size(67, 13);
            this.lblUrünSec.TabIndex = 1;
            this.lblUrünSec.Text = "Ürün Seçimi:";
            // 
            // cmbUrunSecimi
            // 
            this.cmbUrunSecimi.FormattingEnabled = true;
            this.cmbUrunSecimi.Location = new System.Drawing.Point(91, 21);
            this.cmbUrunSecimi.Name = "cmbUrunSecimi";
            this.cmbUrunSecimi.Size = new System.Drawing.Size(179, 21);
            this.cmbUrunSecimi.TabIndex = 0;
            this.cmbUrunSecimi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbUrunSecimi.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listHesap);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(509, 288);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hesap Defteri";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listHesap
            // 
            this.listHesap.FormattingEnabled = true;
            this.listHesap.Location = new System.Drawing.Point(7, 7);
            this.listHesap.Name = "listHesap";
            this.listHesap.Size = new System.Drawing.Size(496, 277);
            this.listHesap.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Tümünü Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabSatis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabSatis.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.TabControl tabSatis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTanim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunTanim;
        private System.Windows.Forms.TextBox txtUrunIsim;
        private System.Windows.Forms.TextBox txtUrunMiktar;
        private System.Windows.Forms.TextBox txtUrunKod;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listKatalog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblUrünSec;
        private System.Windows.Forms.Label lblFiyatı;
        private System.Windows.Forms.Label lblUrünFiyati;
        public System.Windows.Forms.TextBox txtUrunFiyat;
        public System.Windows.Forms.ComboBox cmbUrunSecimi;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox listSatis;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnUrünEkle;
        private System.Windows.Forms.Label lblMusteriTel;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listHesap;
        public System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblUrünIsmi;
        private System.Windows.Forms.RadioButton radioKart;
        private System.Windows.Forms.RadioButton radioNakit;
        private System.Windows.Forms.Label lblAciklma;
        private System.Windows.Forms.Button button1;

    }
}

