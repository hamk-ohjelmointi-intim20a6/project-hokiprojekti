using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class RoundRobin
    {
        

        //Lisää parittomaan määrään pelaajia yksi varjopelaaja
        public List<string> LisaaPelaaja (List<string> testilista)
        {
            string nimi;
            nimi = "0";
            testilista.Insert(0, nimi);
            return testilista;
        }

        //kierrätä listan elementit listassa yhden kierroksen verran
        public UusiLista LuoRobin(List<string> testilista, int i)
        {
            //int players;
            //players = testilista.Count();

            //// i = mones listaversio
            //for (var i = 1; i < players; i++)
            //{
                if (i % 2 == 0)
                {
                    UusiLista haeLista = new UusiLista(); 
                    haeLista.Lista = ParillinenVersio(testilista), 
                    haeLista.ListaVersio = i
                    ;
                    
                }

                //jos listaversio ei ole kahdella jaollinen, listan indeksi[0] on toisena
                if (i % 2 == 1)
                {
                UusiLista haeLista = new UusiLista();
                
                
                   haeLista.Lista = ParitonVersio(testilista),
                   haeLista.ListaVersio = i
                ;
            }
                

            //}
            

        }

        //Metodi, joka päättää listan muutokset, jotka vaikuttaa koti/vieraspeleihin 
        //public List<string> ParillinenPariton(List<string> testilista, int i)
        //{
        //    var x = i; //x = listaversio

        //    //jos listaversio on kahdella jaollinen, listan indeksi[0] on ensimmäisenä
            

        //}

        public List<string> ParitonVersio (List<string> testilista)
        {
            string nimi;

            //luo uusi elementti listaan, joka on sama kuin listan viimeinen elementti
            nimi = testilista[testilista.Count - 1]; 
            testilista.Remove(testilista[testilista.Count - 1]); //poista listasta viimeinen elementti
            testilista.Insert(0, nimi); //lisää uusi elementti (pohja listan viimeinen elementti) listan kohtaan 1 eli indeksi 0 */
            return testilista;
            ////tulosta
            //Generointi_1v1 otteluohjelma1v1 = new Generointi_1v1();
            //otteluohjelma1v1.ParillinenKoti(testilista, x);
             
        }

        public List<string> ParillinenVersio(List<string> testilista)
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

            return testilista;

            ////tulosta
            //Generointi_1v1 otteluohjelma1v1 = new Generointi_1v1();
            //otteluohjelma1v1.ParillinenKoti(testilista, x);
        }

    }
}
