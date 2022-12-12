using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3__04._12._22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 3:
             Eyni qaydada istifadəçidən 10 ədəd şəhər adı soruşun. 
                10 - cu şəhərin adını daxil edəndən sonra bu dəfə alt-alta yox vergüllə ayırıb yazın.*/

            Console.WriteLine("Please write ten cites:");
            string city, city1, city2, city3, city4, city5;
            city = Console.ReadLine();
            city1 = Console.ReadLine();
            city2 = Console.ReadLine();
            city3 = Console.ReadLine();
            city4 = Console.ReadLine();
            city5 = Console.ReadLine();
            Console.Read();
            Console.WriteLine(city + "," + city1 + "," + city2 + "," + city3 + "," + city4 + "," + city5);
            Console.Read();


        }
    }
}
