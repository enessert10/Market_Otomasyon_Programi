using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UrunKatalogu
    {
       public List<Urun> Urun = new List<Urun>();
        
        
        public void urunEkle(Urun urun)
        {
            Urun.Add(urun);
        }
        public void urunCikar(Urun urun)
        {  
            
           Urun.Remove(urun);
        }
        public List<Urun> UrünListele()
        {
            return Urun;
        }
        public List<Urun> UrünListele2()
        {            
            return Urun;
        }
        public List<Urun> UrünListele3()
        {
            return Urun;
        }
        public List<Urun> UrünListele4()
        {
            return Urun;
        }
    }
}
