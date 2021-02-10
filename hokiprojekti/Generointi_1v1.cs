using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Generointi_1v1
    {
        public void Robin(List<string> testilista, int rounds)
        {
            int n = 0;
            RoundRobin testi = new RoundRobin();
            while (n < rounds)
            {
                
                if (testilista.Count % 2 == 1)
                {
                     
                    testi.LisaaPelaaja(testilista);
                    n--;
                }

                else if (testilista.Count % 2 == 0)
                {
                    
                    Console.WriteLine("Kierros {0}", n + 1);
                    int players;
                    players = testilista.Count();

                    // i = mones listaversio
                    for (var i = 1; i < players; i++)
                    {
                        RoundRobin luoRobin = new RoundRobin();
                        var Testi = luoRobin.LuoRobin(testilista, i);
                        List<string> UusiLista = Testi.Lista;
                        int ListaVersio = Testi.ListaVersio;
                    }
                        
                    
                }

                n++;
            }
        }

        
        //Listan parilliset indekseillä on kotiottelu
        public void ParillinenKoti(List<string> testilista)
        {
            //listan pituudesta saadaan indeksit
            int ListanPituus;
            ListanPituus = testilista.Count();

            //ottelujen määrä / kierros = pelaajien määrä - 1
            Console.WriteLine("{0} ottelu", ListanPituus);

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

    }
}
