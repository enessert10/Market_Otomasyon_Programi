using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Odeme
    {
        public int Bakiye = 2000;
        protected int Tutar { get; set; }
        public abstract double OdemeYap(double ttr);


        public Odeme()
        {
            // TODO: Complete member initialization
        }

        
    }
}
