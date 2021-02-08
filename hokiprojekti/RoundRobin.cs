using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class RoundRobin
    {
        public void Robin(List<string> testilista, int rounds)
        {
            int players;
            players = testilista.Count();
            string nimi;
            int n = 0;

            while (n < rounds)
            {
                Console.WriteLine("Kierros {0}", n+1);
                //kierrätä listan elementit listassa yhden kierroksen verran, i = mones listaversio
                for (var i = 1; i < players; i++)
                {
                    nimi = testilista[testilista.Count - 1]; //luo uusi elementti listaan, joka on sama kuin listan viimeinen elementti
                    testilista.Remove(testilista[testilista.Count - 1]); //poista listasta viimeinen elementti
                    testilista.Insert(1, nimi); //lisää uusi elementti (pohja listan viimeinen elementti) listan kohtaan 2 eli indeksi 1

                    ParillinenPariton(testilista, i); //metodi joka päättää koti- ja vieraspelin
                    

                }
                n++;
            }
        }

        //Metodi valitsee listaversion numerosta riippuen koti ja vieraspelin
        public void ParillinenPariton(List<string> testilista, int i)
        {
            var x = i; //x = listaversio
            if (x % 2 == 0) //jos listaversio on kahdella jaollinen, parillisilla listan indekseillä  kotiottelu
            {
                
                ParillinenKoti(testilista, x);
            }

            if (x % 2 == 1) //jos listaversio on kahdella jaollinen, parittomilla listan indekseillä  kotiottelu
            {
                ParitonKoti(testilista, x);
            }

        }

        //Listan parilliset indekseillä on kotiottelu
        public void ParitonKoti(List<string> testilista, int x)
        {
            int ListanPituus; //listan pituudesta saadaan indeksit
            ListanPituus = testilista.Count();
            Console.WriteLine("{0} ottelu", x);
            for (int i = 0; i < ListanPituus; i++)
            {
                if (i % 2 == 0) //jos indeksi parillinen -> kotiottelu, vastustaja on listan seuraava pariton indeksi
                {
                    Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: {1}", testilista[i], testilista[i+1]);
                }

                if (i % 2 == 1) // jos indeksi pariton jatka
                { 
                    continue;
                }

                
            }

            Console.ReadLine();
        }

        //Listan parittomilla indekseillä on kotiottelu
        public void ParillinenKoti(List<string> testilista, int x)
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
        }
    }
}
