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
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string adress = Console.ReadLine();
            string dokument = Console.ReadLine();
            //string name = Console.ReadLine();



            Custemer info = new Custemer(name,surname,adress,dokument);
            info.name = "Ehmed";
            info.surname = "Mustafa";
            info.adress = "Baku";
            info.dokument = "1223456";
            //info.age = 35;

            Custemer infonew = new Custemer(name, surname, adress, dokument);
            infonew.CheckCustomerFromDb();
        }
    }
}
