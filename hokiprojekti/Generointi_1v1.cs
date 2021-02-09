using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Generointi_1v1
    {
        //Listan parilliset indekseillä on kotiottelu
        public void ParillinenKoti(List<string> testilista, int x)
        {
            //listan pituudesta saadaan indeksit
            int ListanPituus;
            ListanPituus = testilista.Count();

            //ottelujen määrä / kierros = pelaajien määrä - 1
            Console.WriteLine("{0} ottelu", x);

            //käy listan indeksit läpi
            for (int i = 0; i < ListanPituus; i++)
            {
                //jos indeksi parillinen -> kotiottelu, vastustaja on listan seuraava pariton indeksi
                if (i % 2 == 0)
                {
                    if (testilista[i] == "0" || testilista[i + 1] == "0")
                    {
                        LuovutettuPeli(testilista, i);
                    }

                    else
                    Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: {1}", testilista[i], testilista[i + 1]);
                }

                if (i % 2 == 1) // jos indeksi pariton jatka
                {
                    continue;
                }
            }

            Console.ReadLine();
        }

        public void LuovutettuPeli (List<string> testilista, int i)
        {
            if (testilista[i] == "0") 
            {
                Console.WriteLine("Kotiottelu: none" + " " + "Vieras: {0}", testilista[i + 1]);
            }

            else if (testilista[i +1] == "0")
            {
                Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: none", testilista[i]);
            }
        }

        //EI TARVITA
        //Listan parittomilla indekseillä on kotiottelu
        /*public void ParitonKoti(List<string> testilista, int x)
        {
            int ListanPituus;
            ListanPituus = testilista.Count();
            Console.WriteLine("{0} ottelu", x);
            for (int i = 0; i < ListanPituus; i++)
            {
                if (i % 2 == 0) //jos indeksi parillinen -> parillinen indeksi vieraspeli, vastustaja on listan seuraava pariton indeksi
                {
                    Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: {1}", testilista[i +1], testilista[i]);
                }

                if (i % 2 == 1)
                {
                    continue;
                }

            }

            Console.ReadLine();
        }*/
    }
}
