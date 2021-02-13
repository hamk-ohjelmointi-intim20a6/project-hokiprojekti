using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Tallennus
    {
        // Luodaan lista, joka sisältää Otteluita (Ottelu sisältää ottelunumeron=OtteluNro, kotijoukkueen nimen = Koti ja vierasjoukkueen = Vieras)
        public static List<Ottelu> ottelut = new List<Ottelu>();

        // Tätä metodia käytetään Generointi_1v1-luokassa
        public static void LisääListalle(string koti, string vieras)
        {
            // Luodaan uusi Ottellu
            Ottelu ottelu = new Ottelu();

            // Ottelu haluaa ottelunumeron, kotijoukkueen ja vierasjoukkueen nimet. 
            // Jälkimmäiset saadaan Generointi_1v1-luokasta ja ottelunumero määritellään sen mukaan, 
            // montako Ottelua tällä ylläluodulla listalla jo on. Aluksi siellä on 0, 
            // joten lukuun täytyy lisätä 1
            ottelu.OtteluNro = ottelut.Count + 1;
            ottelu.Koti = koti;
            ottelu.Vieras = vieras;

            // Muodostetaan ylläannetuista tiedoista Ottelu ja lisätään se tuolle Otteluita keräävälle listalle
            ottelut.Add(ottelu);
        }

        // Tätä metodia käytetään pääohjelmassa
        public static void TallennaJSON()
        {
            // Luosaan string tolla hienolla conventterilla jonka toimintaa en tarkemmin tunne.
            // Eli käytetään sitä otteluista tehtyä listaa ja muutetaan se JSON-muotoiseksi string-pötköksi,
            // jonka nimi nyt on JSONmerkkijono
            string JSONmerkkijono = JsonConvert.SerializeObject(ottelut);

            // Tässä käytetään taas jotain hienoa valmista kaavaa millä tää tehdään.
            // Määritellään vaan tiedoston polku ja nimi tonne perään. Me ei nyt laitetaq polkua,
            // eli se tallentuu vaan kunkin omalle koneelle kansioon hokiprojekti > hokiprojekti > bin > Debug
            // Ja siis GIT ei seuraa tota kansioo, eli noi tiedostot ei tallennu gittiin.
            using (StreamWriter tiedosto = new StreamWriter("ottelut.json", false)) // false = päällekirjoittaa tiedoston
            {
                // Tässä kerrotaan mitä siihen tiedostoon halutaan kirjoittaa,
                // ja sehän on se yllämääritelty JSONmerkkijono
                tiedosto.WriteLine(JSONmerkkijono);
            }
        }

        // Tätä metodia käytetään pääohjelmassa
        public static void TallennaTXT()
        {




            // Tässä päätetään mihin kirjoitetaan
            using (StreamWriter writetext = new StreamWriter("ottelut.txt"))
            {
                // Tässä päätetään mitä kirjoitetaan
                foreach (Ottelu ottelu in ottelut)
                {
                    writetext.WriteLine(ottelu);
                }
            }


        }

        // Tässä koodi JSONin lukemiseen.

        //private static List<Ottelu> LueJSON()
        //{
        //    string pelitLuettuTiedostosta = File.ReadAllText("ottelut.json");

        //    List<Ottelu> peliParit = JsonConvert.DeserializeObject<List<Ottelu>>(pelitLuettuTiedostosta);

        //    Console.WriteLine("Luetaan JSON-tiedostosta");

        //    foreach (Ottelu ottelu in peliParit)
        //    {
        //        Console.WriteLine("*************************");
        //        Console.Write($"Peli nro. {ottelu.OtteluNro} ");
        //        Console.WriteLine($"{ottelu.Koti} vs {ottelu.Vieras}");
        //    }

        //    return peliParit;
        //}
    }
}
