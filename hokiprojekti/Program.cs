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
            Päävalikko päävalikko = new Päävalikko();

            // Konsolin otsikko
            Console.Title = "Änäri-äppi";

            päävalikko.AlkuValikko();
            AloitaUusiPeli();
        }

        public static void AloitaUusiPeli()
        {
            Console.WriteLine("Aloitetaan uusi peli!");
            Console.WriteLine("Paina mitä vaan nappia sulkeaksesi konsolin");
            Console.ReadKey();
        }
    }
}
