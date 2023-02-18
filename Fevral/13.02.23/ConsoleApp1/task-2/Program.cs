using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mehsul info = new Mehsul("mersedez","S class");
            Mehsul info1 = new Mehsul("mersedez", "S class",2002);
            Mehsul info3 = new Mehsul("mersedez", "S class", 2002,50000);
            Mehsul info4 = new Mehsul("mersedez", "S class", 2002, 50000,"benzin");

           // int var= info4.alis;
            Mehsul melumat = new Mehsul();
           info4.info();
        }
    }
}
