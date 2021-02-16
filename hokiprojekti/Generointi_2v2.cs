using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Generointi_2v2
    {
        

        /*public void OtaLista(List<string> pelaajalista) //Jos pelaajien määrä on pariton, lisätään perään 
        {
            if (pelaajalista.Count % 2 == 0)
            {
                
                KopioiLista(pelaajalista);

            }
            else
            {
                pelaajalista.Add("Tyhjä");
                KopioiLista(pelaajalista);
            }
        }*/

        public void KopioiLista(List<string> pelaajalista)
        {
            List<string> pelaajalista2 = new List<string>();
            pelaajalista2 = pelaajalista.ToList();
            

            PoistaEkaJaVika(pelaajalista, pelaajalista2);

        }

        public void PoistaEkaJaVika(List<string> pelaajalista, List<string> pelaajalista2)
        {
            pelaajalista.RemoveAt(0);
            pelaajalista2.RemoveAt(pelaajalista2.Count - 1);
           
            TulostaParit(pelaajalista, pelaajalista2);
          
        }
        List<string> pelaajalista3 = new List<string>();
        List<string> pelaajalista4 = new List<string>();
        List<string> pelaajalista5 = new List<string>();
        List<string> pelaajalista6 = new List<string>();

        public void TeeNeljäListaa(List<string> pelaajalista, List<string> pelaajalista2)
        {


            pelaajalista3.AddRange(pelaajalista);
            pelaajalista4.AddRange(pelaajalista2);

            pelaajalista5.AddRange(pelaajalista);
            pelaajalista6.AddRange(pelaajalista2);


        }

        int x = 1;
        public void TulostaParit(List<string> pelaajalista, List<string> pelaajalista2)
        {
            
            x++;
            if (x % 2 == 0)
            {
                for (int i = 0; i < pelaajalista.Count; i++)
                {
                    var yhdistettylista = pelaajalista.Zip(pelaajalista2, (first, second) => first + " ja " + second);
                    foreach (var item in yhdistettylista)
                    {
                        Console.WriteLine(item);
                    }

                    TeeNeljäListaa(pelaajalista, pelaajalista2);
                    PoistaEkaJaVika(pelaajalista, pelaajalista2);

                }
                
            }
            else
            {
                for (int i = 0; i < pelaajalista.Count; i++)
                {
                    var yhdistettylista2 = pelaajalista2.Zip(pelaajalista, (first, second) => first + " ja " + second);
                    foreach (var item in yhdistettylista2)
                    {
                        Console.WriteLine(item);
                    }

                    TeeNeljäListaa(pelaajalista, pelaajalista2);
                    PoistaEkaJaVika(pelaajalista, pelaajalista2);

                }
                
            }

            PoistaPuolet(pelaajalista3, pelaajalista4, pelaajalista5, pelaajalista6);
          
        }

        public void PoistaPuolet(List<string> pelaajalista3, List<string> pelaajalista4, List<string> pelaajalista5, List<string> pelaajalista6)
        {
            
            pelaajalista3.RemoveRange(pelaajalista3.Count / 2 - 1, pelaajalista3.Count / 2);
            pelaajalista4.RemoveRange(pelaajalista4.Count / 2 - 1, pelaajalista4.Count / 2);
            pelaajalista5.RemoveRange(pelaajalista5.Count / 2 - 1, pelaajalista5.Count / 2);
            pelaajalista6.RemoveRange(pelaajalista6.Count / 2 - 1, pelaajalista6.Count / 2);
            TulostaOtteluohjelma(pelaajalista3, pelaajalista4, pelaajalista5, pelaajalista6);
        }

        public void TulostaOtteluohjelma(List<string> pelaajalista3, List<string> pelaajalista4, List<string> pelaajalista5, List<string> pelaajalista6)
        {
            foreach (var item in pelaajalista3)
            {
                Console.WriteLine(item);
            }

            foreach (var item in pelaajalista4)
            {
                Console.WriteLine(item);
            }
            foreach (var item in pelaajalista5)
            {
                Console.WriteLine(item);
            }

            foreach (var item in pelaajalista6)
            {
                Console.WriteLine(item);
            }


            for (int i = 0; i < pelaajalista3.Count; i++)
            {
                if (pelaajalista3[i] != pelaajalista5[i] && pelaajalista3[i] != pelaajalista6[i])
                {
                    Console.WriteLine(pelaajalista3[i] + " ja " + pelaajalista4[i] + " vs. " + pelaajalista5[i] + " ja " + pelaajalista6[i]);
                }
            }

        }
    }
}
