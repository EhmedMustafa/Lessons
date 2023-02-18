using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Mehsul
    {
        public string marka;
        public string model;
        public int istehsalil;
        public int km;
        public string yanacaqnovu;
        public double alis;
        public double satis;//1000
        public double maxendirim;//200
        private double qiymet;//800

        public Mehsul()
        {
            
        }
        public Mehsul(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
        }
        public Mehsul(string marka, string model,int istehsalil)
        {
            this.marka = marka;
            this.model = model;
            this.istehsalil = istehsalil;
        }
        public Mehsul(string marka, string model, int istehsalil,int km)
        {
            this.marka = marka;
            this.model = model;
            this.istehsalil = istehsalil;
            this.km = km;
        }
        public Mehsul(string marka, string model, int istehsalil, int km,string yanacaqnovu)
        {
            this.marka = marka;
            this.model = model;
            this.istehsalil = istehsalil;
            this.km = km;
            this.yanacaqnovu = yanacaqnovu;
            
        }

        public void info()
        {
            Console.WriteLine(marka+" "+model+" "+istehsalil+" "+km+" "+yanacaqnovu+" "+alis+" "+satis);
        }
        public void price(double qiymet)
        {
            double   netice = satis - maxendirim;
            if (qiymet<netice)
            {
                Console.WriteLine("");
                
            }
            else
            {
                this.qiymet = qiymet;
                Console.WriteLine("qiymet uygundu");
            }


        }
    }
}
