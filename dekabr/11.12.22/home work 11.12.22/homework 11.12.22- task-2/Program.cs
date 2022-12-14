using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_11._12._22__task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Homework 2:
             Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları toplayacaqsınız. Bu məlumatlar ad, soyad, cins, doğum tarixi,
             yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq. Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.*/

            Console.WriteLine("Adiniz nedir?");
            String name = Console.ReadLine();
            Console.WriteLine("Familiyaniz nedir?");
            string SurName = Console.ReadLine();
            Console.WriteLine("Dogum tarixi?");
            DateTime datebirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Yasagidiniz olke?");
            string country = Console.ReadLine();
            Console.WriteLine("Yasagidiniz seher?");
            string city = Console.ReadLine();
            Console.WriteLine("Bonuyuz necedi?");
            int heith = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cekiniz necedi?");
            Double weith = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nece maat maas alirsiz?");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ad:" + name);
            Console.WriteLine("Familiya:" + SurName);
            Console.WriteLine("Dogum tarixi:" + datebirth);
            Console.WriteLine("Yasadigi olke:" + country);
            Console.WriteLine("Yaşadığı şəhər:" + city);
            Console.WriteLine("Boy:" + heith);
            Console.WriteLine("Çəki:" + weith);
            Console.WriteLine("Maas:" + count);

            Console.Read();











        }
        
    }
}
