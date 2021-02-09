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
            int n = 0;

            while (n < rounds)
            {
                Console.WriteLine("Kierros {0}", n+1);
                //kierrätä listan elementit listassa yhden kierroksen verran, i = mones listaversio
                for (var i = 1; i < players; i++)
                {
                    
                    ParillinenPariton(testilista, i); 
                    
                }
                n++;
            }
        }

        //Metodi, joka päättää listan muutokset, jotka vaikuttaa koti/vieraspeleihin 
        public void ParillinenPariton(List<string> testilista, int i)
        {
            var x = i; //x = listaversio

            //jos listaversio on kahdella jaollinen, listan indeksi[0] on ensimmäisenä
            if (x % 2 == 0) 
            {

                ParillinenVersio(testilista, x);
            }

            //jos listaversio ei ole kahdella jaollinen, listan indeksi[0] on toisena
            if (x % 2 == 1) 
            {
                ParitonVersio(testilista, x);
            }

        }

        public void ParitonVersio (List<string> testilista, int x)
        {
            string nimi;

            //luo uusi elementti listaan, joka on sama kuin listan viimeinen elementti
            nimi = testilista[testilista.Count - 1]; 
            testilista.Remove(testilista[testilista.Count - 1]); //poista listasta viimeinen elementti
            testilista.Insert(0, nimi); //lisää uusi elementti (pohja listan viimeinen elementti) listan kohtaan 1 eli indeksi 0 */

            //tulosta
            Generointi_1v1 otteluohjelma1v1 = new Generointi_1v1();
            otteluohjelma1v1.ParillinenKoti(testilista, x);
        }

        public void ParillinenVersio(List<string> testilista, int x)
        {
            string nimi;

            //luo uusi elementti listaan, joka on sama kuin listan viimeinen elementti
            nimi = testilista[testilista.Count - 1];
            testilista.Remove(testilista[testilista.Count - 1]);
            testilista.Insert(0, nimi);

            //listan ensimmäinen arvo (parittomilla kierroksilla 1 ja parillisilla 2), vaihtaa paikkoja indeksien 0 ja 1 välillä
            nimi = testilista[2]; 
            testilista.Remove(testilista[2]);
            testilista.Insert(0, nimi);

            //tulosta
            Generointi_1v1 otteluohjelma1v1 = new Generointi_1v1();
            otteluohjelma1v1.ParillinenKoti(testilista, x);
        }

    }
}
