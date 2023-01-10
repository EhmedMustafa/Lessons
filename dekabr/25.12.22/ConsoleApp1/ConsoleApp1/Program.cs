using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task-1
            //Homework 1: İstifadəçi mənfi dəyər daxil edənə qədər, daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın.
            int reqem;
            int a = 0;
            Console.WriteLine("Zehmet olmasa reqem daxil edin:");
            while (true)
            {
                reqem = int.Parse(Console.ReadLine());
                a += reqem; ;
                if (reqem < 0)
                {
                    Console.WriteLine(a); break;
                }
            }
            #endregion

            #region task-4
            //Homework 4: İstifadəçidən bir rəqəm alın. While döngüsüylə istifadəçinin daxil etdiyi rəqəmdən 0-a doğru geriyə sayın.
            int reqem1;
            reqem1= Convert.ToInt32(Console.ReadLine());
            while (reqem1>= 0)
            {
                Console.WriteLine(reqem1);
                reqem--;
            }
            #endregion

            #region task-3
            /*omework 3: App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
              alınmalıdır.Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və istifadəçidən generate olunan rəqəmi
                           tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
                           Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir.Sadəcə 2. 3. 4.deyə artır cəhd sayı.İstifadəçi düzgün rəqəmi
                        tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.*/

            Console.WriteLine("Texmin oyunu ucun en yuksek deyeri daxil edin: ");
            int say = Convert.ToInt32(Console.ReadLine());
            while (true)
            {


                Console.WriteLine("Cehdiniz! Zehmet olmasa reqemi texmin edin: ");
                int j = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                int b = rand.Next(1, say);
                Console.WriteLine(b);

                if (j == b)
                {
                    Console.WriteLine("Cehdinizde düzgün reqemi tapdınız!"); break;
                }
                #endregion
            }

        }
    }
}
