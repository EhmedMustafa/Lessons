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
            /*
            Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın.Bunlar heç bir zaman dəyişməyəcək şəkildə olsun.Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
             Not: Switch case və döngülərdən istifadə etmək olmaz.*/

            string username = "Ehmed";
            string password = "1987";
            username = Console.ReadLine();
            password = Console.ReadLine();
            if (username=="ehmed"&&password=="1987")
            {
                Console.WriteLine("daxil olduz");
                Console.Read();
            }
            else
            {
                username = Console.ReadLine();
                password = Console.ReadLine();
                if (username == "ehmed" && password == "1987")
                {
                    Console.WriteLine("daxil olduz");
                }
                else
                {
                    username = Console.ReadLine();
                    password = Console.ReadLine();
                    if (username == "ehmed" && password == "1987")
                    {
                        Console.WriteLine("daxil olduz");
                    }
                    else
                    {
                        Console.WriteLine("BLOK");
                    }

                }
                
            }
         

        }


    }
}
