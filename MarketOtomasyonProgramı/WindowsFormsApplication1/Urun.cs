using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Urun : UrunTanimi
    {
        public string urunAdi;
        public int urunMiktari=0;
        

        public Urun(long kod,int urunMiktari,string urunAdi, string tanim, double fiyat)
        {
            this.urunAdi = urunAdi;
            this.tanim = tanim;
            this.fiyat = fiyat;
            this.kdv = fiyat * 0.18;
            this.urunKodu = kod;
            this.urunMiktari = urunMiktari;
        }

       public Urun()
        {
            // TODO: Complete member initialization
        }

        
        
    }
}
