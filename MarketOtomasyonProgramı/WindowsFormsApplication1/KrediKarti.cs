using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class KrediKarti:Odeme
    {
       
        public double ttr { get; set; }
        

        public override double OdemeYap(double ttr)
        {
           return ttr += (ttr*10)/100;
           
        }
      
        
       
    }
}
