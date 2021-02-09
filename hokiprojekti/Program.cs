using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Program
    {
        static void Main(string[] args)
        {

            // Konsolin otsikko
            Console.Title = "Änäri-äppi";

            Päävalikko.AlkuValikko();
            AloitaUusiPeli();

        }

        public static void AloitaUusiPeli()
        {
            Console.WriteLine("Aloitetaan uusi peli!");
            Console.WriteLine("Paina mitä vaan nappia sulkeaksesi konsolin");
            Console.ReadKey();

            int pelaajienMäärä = Pelaajat.pelaajienMäärä();
           
            List<string> listaPelaajista = Pelaajat.listaPelaajista(pelaajienMäärä);
            
        }
    }
}
