using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Generointi_2v2
    {




        public void KopioiLista(List<string> pelaajalista) //Syötetty pelaajalista kopioidaan toiseen listaan. Tämä aloittaa generoinnin.
        {
            List<string> pelaajalista2 = new List<string>();
            pelaajalista2 = pelaajalista.ToList();


            PoistaEkaJaVika(pelaajalista, pelaajalista2);

        }

        public void PoistaEkaJaVika(List<string> pelaajalista, List<string> pelaajalista2) //Tämä poistaa toisesta listasta ensimmäisen itemin ja toisesta viimeisen
        {
            pelaajalista.RemoveAt(0);
            pelaajalista2.RemoveAt(pelaajalista2.Count - 1);

            TulostaParit(pelaajalista, pelaajalista2);

        }
        List<string> pelaajalista3 = new List<string>();
        List<string> pelaajalista4 = new List<string>();
      

    

        int x = 1;
        public void TulostaParit(List<string> pelaajalista, List<string> pelaajalista2) //Tämä tulostaa parit
        {

            x++;    //x muuttuja muuttaa mennäänkö if vai elsen mukaan. Tämä vaihtelee vain kumpi lista tulostuu ensin. Vaikuttaa siihen kumpi parin jäsenistä saa valita joukkueen.
            if (x % 2 == 0)
            {
                for (int i = 0; i < pelaajalista.Count; i++)
                {
                    var yhdistettylista = pelaajalista.Zip(pelaajalista2, (first, second) => first + " ja " + second); //Zip yhdistää listojen ekat ja alla tulostetaan parit
                    foreach (var item in yhdistettylista)
                    {
                        Console.WriteLine(item);
                    }

                    pelaajalista3.AddRange(pelaajalista); //pelaajalistat kopioidaan myöhemmin tarvittaviin listoihin 3 ja 4
                    pelaajalista4.AddRange(pelaajalista2);
                    PoistaEkaJaVika(pelaajalista, pelaajalista2); //poistetaan toisesta listasta ensimmäinen itemi ja toisesta viimeinen ja jatketaan looppia niin kauan kunnes pelaajat loppuvat

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

                    pelaajalista3.AddRange(pelaajalista2);
                    pelaajalista4.AddRange(pelaajalista);
                    PoistaEkaJaVika(pelaajalista, pelaajalista2);

                }

            }
            
            KäyListaLäpi(pelaajalista3, pelaajalista4); //tämä aloittaa otteluparien tulostamisen

        }



        List<string> otteluOhjelma = new List<string>(); //tämä on turha
        int y = 0;

        

        public void KäyListaLäpi(List<string> pelaajalista3, List<string> pelaajalista4)
        {
            int z = 0;


            for (int i = 0; i < pelaajalista3.Count * 2 - 1; i++)
            {
                if (y == pelaajalista3.Count | z == pelaajalista3.Count) //Tämä lopettaa loopin jos parit loppuvat listasta
                {
                    break;
                }
                else if (pelaajalista3[y] != pelaajalista3[z] && pelaajalista3[y] != pelaajalista4[z] && pelaajalista4[y] != pelaajalista3[z] && pelaajalista4[y] != pelaajalista4[z]) //koska kukaan ei voi pelata itseään vastaan, tarkistetaan se tällä ehdolla
                {
                    Console.WriteLine(pelaajalista3[y] + " ja " + pelaajalista4[y] + " vs. " + pelaajalista3[z] + " ja " + pelaajalista4[z]);
                    pelaajalista3.RemoveAt(z); //poistetaan "käytetyt" parit listoista
                    pelaajalista4.RemoveAt(z); //poistetaan "käytetyt" parit listoista
                    pelaajalista3.RemoveAt(y); //poistetaan "käytetyt" parit listoista
                    pelaajalista4.RemoveAt(y); //poistetaan "käytetyt" parit listoista



                    z = -1;
                }
                z++;
            }



        }
    }
}
