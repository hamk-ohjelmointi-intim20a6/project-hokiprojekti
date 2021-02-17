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
        public void ParillinenKoti(List<string> testilista, int x, int KierrosNro)
        {
            //listan pituudesta saadaan indeksit
            int ListanPituus;
            ListanPituus = testilista.Count() - 1;
            
            //kuinka monta kertaa tulostusloopi tehdään = pelaajien määrä jaettuna 2
            int otteluParit = testilista.Count() / 2;

            //ottelujen määrä / kierros = pelaajien määrä - 1
            Console.WriteLine("{0} ottelu", x);

            //käy yhden kierroksen otteluparit läpi
            for (int i = 0; i < otteluParit; i++)
            {
                //jos ensimmäinen pari ja varjopelaaja ensimmäinen tai toinen
                if (i == 0 && testilista[i] == "0" || testilista[i + 1] == "0")
                {
                    LuovutettuPeli(testilista, i);
                }
                //jos listan ensimmäinen pari
                else if (i == 0 && testilista[i] != "0" && testilista[i + 1] != "0")
                {
                    Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: {1}", testilista[i], testilista[i + 1]);
                    Tallennus.LisääListalle(KierrosNro, testilista[i], testilista[i + 1]);
                }
                //jos muu kuin listan ensimmäinen
                else
                {
                    int vieras = i + 1;
                    Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: {1}",
                    testilista[ListanPituus],
                    testilista[vieras]);
                    Tallennus.LisääListalle(KierrosNro, testilista[ListanPituus], testilista[vieras]);
                    ListanPituus -= 1;
                }
                  
            }
        }

        public void LuovutettuPeli(List<string> testilista, int i)
        {
            if (testilista[i] == "0")
            {
                Console.WriteLine("Kotiottelu: none" + " " + "Vieras: {0}", testilista[i + 1]); ;                        
            }

            else if (testilista[i + 1] == "0")
            {
                Console.WriteLine("Kotiottelu: {0}" + " " + "Vieras: none", testilista[i]);
            }
        }

    }
}