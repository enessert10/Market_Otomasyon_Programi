using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class HesapDefteri:Müsteri
    {
        //satılan ürülerin kaydı tutulacak
        public Urun urun=new Urun();
        public Satis sts = new Satis();
        public List<Dukkan> Hesap = new List<Dukkan>();
        public List<Satis> satis = new List<Satis>();
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        
        public void SatisEkle(Satis s)
        {
            satis.Add(s);
        }

        public string SatisGoster()
        {
            string str = "";
            foreach (var item in satis)
            {
                str += item.x.ToString() + " TL\t" + item.adet + " Adet\t" + item.urun.urunAdi + "\t"
                    + item.mst.Isim + "\t" + item.mst.Soyisim + "\t" + item.tarih.ToString() + Environment.NewLine;
            }
            return str;
        }

        public void hesapEkle(Dukkan hesap)
        {
            Hesap.Add(hesap);
        }
        public List<Dukkan> HesapListele()
        {
            return Hesap;
        }
        
         
        public HesapDefteri (string urun, int adet, string MustesriIsim, string MusteriSoyisim,DateTime tarih)
	    {
            this.urun.urunAdi=urun;
            this.Isim=MustesriIsim;
            this.Soyisim=MusteriSoyisim;
            this.sts.adet = adet;
            this.sts.tarih = tarih;
            
	    }
        public HesapDefteri()
        {

        }

        public HesapDefteri(string p1, string p2, string p3, string p4, string p5)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
        }

        
    }
}
