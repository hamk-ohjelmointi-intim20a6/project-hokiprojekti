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
        public static void LisääListalle(int kierros, string koti, string vieras)
        {
            // Luodaan uusi Ottellu
            Ottelu ottelu = new Ottelu();

            // Ottelu haluaa ottelunumeron, kotijoukkueen ja vierasjoukkueen nimet. 
            // Jälkimmäiset saadaan Generointi_1v1-luokasta ja ottelunumero määritellään sen mukaan, 
            // montako Ottelua tällä ylläluodulla listalla jo on. Aluksi siellä on 0, 
            // joten lukuun täytyy lisätä 1
            ottelu.KierrosNro = kierros;
            ottelu.OtteluNro = ottelut.Count + 1;
            ottelu.Koti = koti;
            ottelu.Vieras = vieras;

            // Muodostetaan ylläannetuista tiedoista Ottelu ja lisätään se tuolle Otteluita keräävälle listalle
            ottelut.Add(ottelu);
        }

        // Tätä metodia käytetään pääohjelmassa
        public static void TallennaJSON()
        {
            Console.WriteLine("Anna luotavan tiedoston nimi (ilman tiedostopäätettä)");
            string tiedostonNimi = Console.ReadLine();

            // Luosaan string tolla hienolla conventterilla jonka toimintaa en tarkemmin tunne.
            // Eli käytetään sitä otteluista tehtyä listaa ja muutetaan se JSON-muotoiseksi string-pötköksi,
            // jonka nimi nyt on JSONmerkkijono
            string JSONmerkkijono = JsonConvert.SerializeObject(ottelut);

            // Tässä käytetään taas jotain hienoa valmista kaavaa millä tää tehdään.
            // Määritellään vaan tiedoston polku ja nimi tonne perään. Me ei nyt laitetaq polkua,
            // eli se tallentuu vaan kunkin omalle koneelle kansioon hokiprojekti > hokiprojekti > bin > Debug
            // Ja siis GIT ei seuraa tota kansioo, eli noi tiedostot ei tallennu gittiin.
            using (StreamWriter tiedosto = new StreamWriter($"{tiedostonNimi}.json", false)) // false = päällekirjoittaa tiedoston
            {
                // Tässä kerrotaan mitä siihen tiedostoon halutaan kirjoittaa,
                // ja sehän on se yllämääritelty JSONmerkkijono
                tiedosto.WriteLine(JSONmerkkijono);
            }
            TallennaTXT(tiedostonNimi);
        }

        // Tätä metodia käytetään pääohjelmassa
        public static void TallennaTXT(string tiedostonNimi)
        {
            // Tässä päätetään mihin kirjoitetaan
            using (StreamWriter writetext = new StreamWriter($"{tiedostonNimi}.txt"))
            {
                // Tässä päätetään mitä kirjoitetaan
                foreach (Ottelu ottelu in ottelut)
                {
                    writetext.WriteLine(ottelu);
                }
            }

        }

        // Tässä koodi JSONin lukemiseen.
        public static void LueJSON()
        {
            Console.WriteLine("Anna vanhan otteluohjelman nimi (ilman tiedostopäätettä)");
            string tiedostonNimi = Console.ReadLine();

            try
            {
                string pelitLuettuTiedostosta = File.ReadAllText($"{tiedostonNimi}.json");

                List<Ottelu> peliParit = JsonConvert.DeserializeObject<List<Ottelu>>(pelitLuettuTiedostosta);

                Console.WriteLine($"Luetaan {tiedostonNimi}.json");

                foreach (Ottelu ottelu in peliParit)
                {
                    Console.WriteLine(ottelu);
                }
            }
            catch
            {
                Console.WriteLine($"Ei löytynyt tiedostoa nimeltä {tiedostonNimi}");
            }
        }
    }
}
