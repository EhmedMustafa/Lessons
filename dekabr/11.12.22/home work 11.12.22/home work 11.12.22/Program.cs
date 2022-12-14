using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_11._12._22
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
            Homework 1:
             5 dənə dəyişəni Implicit Conversion*/
            short warlong = short.MinValue;
            int warint= int.MinValue;
            int a = warlong;

            long d = warint;
            Double v = warint;
            float b = warint;


            Byte s= 100;
            int s1 = s;

            short a1 = 10000;
            int a2 = a1;

            int b1 = 100000;
            float b2 = b1;

            long c = 1500000;
            Double c1 = c;
            #endregion

            #region 2
            /* 5 dənə dəyişəni Explicit Conversion  */

            int q = 10000;
            short d2 =(short)q;

            short g = 10030;
            byte n = (byte)g;

            int b3 = 20000;
            byte n2 = (byte)b3;

            long j = 10000000;
            int h1 = (int)j;

            float b4 = 5000000;
            long y = (long)b4;
            #endregion

            #region 3
            /* 5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.*/
            string varst = "100";
            int varint;
            long varlong;
            short varshort;


            //varint = varst;

            //varint = (int)varst;

            varint = Convert.ToInt32(varst);
            varlong = Convert.ToInt64(varst);
            varshort = Convert.ToInt16(varst);

            int plus;
            plus = Convert.ToInt32("5");
            plus = Convert.ToInt32(1);
            plus = Convert.ToInt32(0);


            bool varbool;
            varbool = Convert.ToBoolean(1);
            varbool = Convert.ToBoolean(true);
            varbool = Convert.ToBoolean(false);

            #endregion
        }
    }
}
