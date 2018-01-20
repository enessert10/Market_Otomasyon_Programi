using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 :Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        
        UrunKatalogu ktlg = new UrunKatalogu();
        Müsteri mst = new Müsteri();
        Satis sts = new Satis();
        double ToplamTutar = 0;
        int adet = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Urun u1 = new Urun();
            u1.urunAdi = "kalem";
            u1.fiyat = 5;
            u1.urunKodu = 1;
            u1.urunMiktari = 5;
            u1.tanim = "tükenmez";
            ktlg.urunEkle(u1);

            Urun u2 = new Urun();
            u2.urunAdi = "silgi";
            u2.fiyat = 2;
            u2.urunKodu = 2;
            u2.urunMiktari = 7;
            u2.tanim = "resim ";
            ktlg.urunEkle(u2);

            Urun u3 = new Urun();
            u3.urunAdi = "bilgisayar";
            u3.fiyat = 1500;
            u3.urunKodu = 3;
            u3.urunMiktari = 14;
            u3.tanim = "dizüstü";
            ktlg.urunEkle(u3);

            Urun u4 = new Urun();
            u4.urunAdi = "koltuk";
            u4.fiyat = 150;
            u4.urunKodu = 4;
            u4.urunMiktari = 8;
            u4.tanim = "döner";
            ktlg.urunEkle(u4);


            foreach (Urun u in ktlg.UrünListele())
            {
               listStok.Items.Add( "Urun Kodu:" + u.urunKodu +"\t"+ "  Ürün Miktarı:" + u.urunMiktari + "\t" + "Urun Adı:" + u.urunAdi + "\t" + "Tanım:" + u.tanim + "\t" + "Fiyat:" + u.fiyat+"TL");
            }
            foreach (Urun u in ktlg.UrünListele())
            {
                listKatalog.Items.Add("Urun Adı:" + u.urunAdi + "\t" + "Tanım:" + u.tanim + "\t" + "Fiyat:" + u.fiyat+"TL");
            }
            
            
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (txtUrunKod.Text == "" || txtUrunKod.Text == "0" || txtUrunMiktar.Text == "" || txtUrunMiktar.Text == "0" || txtUrunIsim.Text == "" || txtUrunTanim.Text == "" || txtUrunFiyat.Text == "" || txtUrunFiyat.Text == "0")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
            }
            else
            {

                Urun urun1 = new Urun(Convert.ToInt32(txtUrunKod.Text), Convert.ToInt32(txtUrunMiktar.Text), txtUrunIsim.Text.ToString(), txtUrunTanim.Text.ToString(), Convert.ToDouble(txtUrunFiyat.Text));

                ktlg.urunEkle(urun1);
                listStok.Items.Add(ktlg.UrünListele());
                listKatalog.Items.Add(ktlg.UrünListele2());
                listKatalog.Items.Clear();
                foreach (Urun u in ktlg.UrünListele2())
                {
                    listKatalog.Items.Add("Urun Adı:" + u.urunAdi + "\t" + "Tanım:" + u.tanim + "\t" + "Fiyat:" + u.fiyat+" TL");
                }

                txtUrunKod.Clear();
                txtUrunMiktar.Clear();
                txtUrunIsim.Clear();
                txtUrunTanim.Clear();
                txtUrunFiyat.Clear();
                listStok.Items.Clear();
                foreach (Urun u in ktlg.UrünListele())
                {
                    listStok.Items.Add("Urun Kodu:" + u.urunKodu +"\t"+ "  Ürün Miktarı:" + u.urunMiktari + "\t" + "Urun Adı:" + u.urunAdi + "\t" + "Tanım:" + u.tanim + "\t" + "Fiyat:" + u.fiyat+" TL");
                }
            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            listStok.Items.RemoveAt(listStok.Items.Count - 1);
            listKatalog.Items.RemoveAt(listKatalog.Items.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GirisEkrani grs = new GirisEkrani();
            this.Hide();
            grs.Show();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiyatı.Text = txtUrunFiyat.Text;

        }

       

        private void btnHesapla_Click(object sender, EventArgs e)
        {   
            Urun urun = new Urun();
            urun.urunKodu = Convert.ToInt32(cmbUrunSecimi.Text);
            foreach (var item in ktlg.Urun)
            {
                if (urun.urunKodu == item.urunKodu)
                {
                    urun.fiyat = item.fiyat;
                }
            }
            lblFiyatı.Text = ((float)urun.fiyat * int.Parse(txtAdet.Text)).ToString()+" TL";

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sts.urun.urunKodu = Convert.ToInt32(cmbUrunSecimi.Text);
            foreach (var item in ktlg.Urun)
            {
                if (sts.urun.urunKodu == item.urunKodu)
                {
                    sts.urun.fiyat = item.fiyat;
                    sts.urun.urunAdi = item.urunAdi;
                    sts.urun.tanim = item.tanim;
                    lblUrünIsmi.Text =item.tanim+"  "+ item.urunAdi;

                }
            }
        }

       

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
           cmbUrunSecimi.Items.Clear();
            
            foreach (Urun u in ktlg.UrünListele3())
            {
                cmbUrunSecimi.Items.Add(u.urunKodu);
            }
            
        }

        private void btnUrünEkle_Click(object sender, EventArgs e)
        {

            if (txtAdet.Text == "" || Convert.ToInt32(txtAdet.Text) == 0 || txtMusteriAd.Text == "" || txtMusteriSoyad.Text == "" || txtMusteriTel.Text == "" )
            {
                MessageBox.Show("Lütfen istenilen bilgileri eksiksiz doldurunuz");
            }
            else
            {
                HesapDefteri hsp = new HesapDefteri(cmbUrunSecimi.SelectedItem.ToString(), txtAdet.Text, txtMusteriAd.Text, txtMusteriSoyad.Text, DateTime.Now.ToString());

                sts.urun.urunKodu = Convert.ToInt32(cmbUrunSecimi.Text);
                foreach (var item in ktlg.Urun)
                {
                    if (sts.urun.urunKodu == item.urunKodu)
                    {
                        sts.urun.fiyat = item.fiyat;
                        sts.urun.urunAdi = item.urunAdi;
                        sts.adet = Convert.ToInt32(txtAdet.Text);
                        sts.mst.Isim = txtMusteriAd.Text;
                        sts.mst.Soyisim = txtMusteriSoyad.Text;
                        sts.mst.TelNo = Convert.ToDouble(txtMusteriTel.Text);
                        sts.tarih = System.DateTime.Now;
                
                        if (sts.adet > item.urunMiktari)
                        {
                            MessageBox.Show("Yeterli Miktarda Ürün Bulunmamaktadır!");
                           
                        }
                        else
                        {
                            item.urunMiktari -= sts.adet;
                            listStok.Items.Clear();
                            foreach (Urun u in ktlg.UrünListele())
                            {
                                listStok.Items.Add("Urun Kodu:" + u.urunKodu + "\t" + "  Ürün Miktarı:" + u.urunMiktari + "\t" + "Urun Adı:" + u.urunAdi + "\t" + "Tanım:" + u.tanim + "\t" + "Fiyat:" + u.fiyat + " TL");
                            }
                            lblUrünIsmi.Text = item.tanim + " " + item.urunAdi;
                            KrediKarti kk = new KrediKarti();
                            Nakit n = new Nakit();

                            if (radioKart.Checked == true)
                            {

                                ToplamTutar += kk.OdemeYap(((double)sts.urun.fiyat * Convert.ToDouble(txtAdet.Text)));
                                sts.x = kk.OdemeYap(((double)sts.urun.fiyat * Convert.ToDouble(txtAdet.Text)));

                                hsp.SatisEkle(sts);
                                listHesap.Items.Add(hsp.SatisGoster());


                                listSatis.Items.Add(lblUrünIsmi.Text + "," + sts.x + "  TL");

                                
                                adet += Convert.ToInt32(txtAdet.Text);


                                txtToplam.Text = "Ürün Sayısı :" + adet + " " + " Toplam Tutar: " + ToplamTutar.ToString() + " TL";
                                
                            }
                            else if (radioNakit.Checked == true)
                            {
                                ToplamTutar += n.OdemeYap(((double)sts.urun.fiyat * Convert.ToDouble(txtAdet.Text)));
                                sts.x = n.OdemeYap(((double)sts.urun.fiyat * Convert.ToDouble(txtAdet.Text)));

                                hsp.SatisEkle(sts);
                                listHesap.Items.Add(hsp.SatisGoster());


                                listSatis.Items.Add(lblUrünIsmi.Text + "," + sts.x + "  TL");


                                adet += Convert.ToInt32(txtAdet.Text);


                                txtToplam.Text = "Ürün Sayısı :" + adet + " " + " Toplam Tutar: " + ToplamTutar.ToString() + " TL";
                            }
                            else if (radioNakit.Checked == false && radioKart.Checked == false)
                            {
                                MessageBox.Show("Kredi Kartı ya da Nakit Seçilmelidir!");
                            }


                        }
                            
                        
                    }
                }
                
              

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listSatis.Items.Clear();
            txtToplam.Clear();
            txtAdet.Clear();
            lblFiyatı.Text = "";
            adet = 0;
            ToplamTutar = 0;
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtMusteriTel.Clear();
            radioKart.Checked = false;
            radioNakit.Checked = false;

        }

      
    }
}