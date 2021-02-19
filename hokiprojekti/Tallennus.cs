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

            // Ottelu haluaa kierrosnumeron, ottelunumeron, kotijoukkueen ja vierasjoukkueen nimet. 
            // Jälkimmäiset saadaan Generointi_1v1-luokasta ja ottelunumero määritellään sen mukaan, 
            // montako Ottelua tällä ylläluodulla listalla jo on. Aluksi siellä on 0, 
            // joten lukuun täytyy lisätä 1
            ottelu.OtteluNro = ottelut.Count + 1;
            ottelu.KierrosNro = kierros;
            ottelu.Koti = koti;
            ottelu.Vieras = vieras;

            // Muodostetaan ylläannetuista tiedoista Ottelu ja lisätään se tuolle Otteluita keräävälle listalle
            ottelut.Add(ottelu);
        }

        // Tätä metodia käytetään pääohjelmassa
        public static void TallennaJSON()
        {
            try
            {
                Console.WriteLine("Anna luotavan tai muokattavan tiedoston nimi (ilman tiedostopäätettä)");
                Console.WriteLine("Huomaathan, että mikäli annetun niminen tiedosto löytyy jo, ylikirjoittaa ohjelma sen päälle.");
                string tiedostonNimi = Console.ReadLine();

                Console.WriteLine($"Annoit nimeksi {tiedostonNimi}.json, ok? (k/e)");
                string onkoOk = Console.ReadLine();

                // jos nimi ei ole K tai k palataan alkuun
                if (!(onkoOk == "k" || onkoOk == "K"))
                {
                    TallennaJSON();
                }

                // Tiedoston nimi voi periaatteessa olla tyhjä tai sisältää välilyöntejä, mutta ei hyväksytä sitä silti
                if (string.IsNullOrEmpty(tiedostonNimi) || tiedostonNimi.Contains(" "))
                {
                    throw new Exception();
                }

                // Luodaan merkkijono tuolla hienolla convertterilla,
                // eli käytetään sitä ylempänä otteluista tehtyä listaa ja muutetaan se JSON-muotoiseksi merkkijonopötköksi,
                // jonka nimi nyt on JSONmerkkijono
                string JSONmerkkijono = JsonConvert.SerializeObject(ottelut);

                // Tässä käytetään taas jotain hienoa valmista kaavaa millä tää tehdään.
                // Määritellään vaan tiedoston polku ja nimi tonne perään. Me ei nyt laiteta polkua,
                // eli se tallentuu vaan kunkin omalle koneelle kansioon hokiprojekti > hokiprojekti > bin > Debug
                // Ja siis GIT ei seuraa tota kansioo, eli noi tiedostot ei tallennu gittiin.
                using (StreamWriter tiedosto = new StreamWriter($"{tiedostonNimi}.json", false)) // false = päällekirjoittaa tiedoston
                {
                    // Tässä kerrotaan mitä siihen tiedostoon halutaan kirjoittaa,
                    // ja sehän on se yllämääritelty JSONmerkkijono
                    tiedosto.WriteLine(JSONmerkkijono);
                }
                // Tallennetaan ainakin toistaiseksi tiedosto myös tekstimuodossa selvyyden vuoksi
                TallennaTXT(tiedostonNimi);
                Console.Clear();
                Console.WriteLine($"Tallennettu tiedostot {tiedostonNimi}.json ja {tiedostonNimi}.txt.");
                Päävalikko.JatketaankoVaiLopetetaanko();
            }
            // Jos tallennus ei onnistunut
            catch
            {
                Console.WriteLine("Tiedoston tallentaminen ei onnistunut, yritä uudestaan");
                TallennaJSON();
            }
        }

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
                // Yritetään lukea annetun nimistä tiedostoa
                string pelitLuettuTiedostosta = File.ReadAllText($"{tiedostonNimi}.json");

                // Tehdään peliParit niminen lista käyttämällä tätä hienoa JSON-tiedoston lukemiseen tarkoitettua koodia
                List<Ottelu> peliParit = JsonConvert.DeserializeObject<List<Ottelu>>(pelitLuettuTiedostosta);

                Console.WriteLine($"Luetaan {tiedostonNimi}.json");

                // Käydään äsken luotu peliParit niminen lista läpi ja 
                // tulostetaan listan jokaisen jäsenen kohdalla Ottelu-luokan ToString-metodin mukainen rivi
                // eli $"Kierros nro. {KierrosNro}, peli nro. {OtteluNro}: {Koti} vs {Vieras}"
                foreach (Ottelu ottelu in peliParit)
                {
                    Console.WriteLine(ottelu);
                }
            }
            catch
            {
                // Jos annetun nimistä tiedostoa ei löydy tulostuu tämä
                Console.WriteLine($"Ei löytynyt tiedostoa nimeltä {tiedostonNimi}");
            }
        }
    }
}
