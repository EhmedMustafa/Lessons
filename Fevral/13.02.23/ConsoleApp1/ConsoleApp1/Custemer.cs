using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Custemer
    {
        public String name;
        public String surname;
        public String adress;
        public String dokument;
        //public int age;
        public Custemer(string name,string surname,string adress,string dokument)
        {
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.dokument = dokument;
        }

        internal bool CheckCustomerFromDb()
        {
            string[] custemers = { "Orxan", "Ehmed", "Valeh" };
            return custemers.Contains(name);
        }

        internal bool checkcustemer()
        {
            bool netice = CheckCustomerFromDb();
            return netice;
        }


    }
}
