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

            bool isRunning = true;

            while (isRunning)
            {
                string komento = PyydäMerkkiä();

                isRunning = AloitetaankoUusiPeliVaiLopetetaanko(komento);

                if (komento != "1")
                {
                    continue;
                }

                AloitaUusiPeli();

                Console.WriteLine("Paina mitä vaan nappia sulkeaksesi konsolin");
                Console.ReadKey();
                isRunning = false;
            }
        }
        public static string PyydäMerkkiä()
        {
            Console.WriteLine("Tervetuloa Änäri-äppiin");
            Console.WriteLine("1 Aloita uusi peli\n0 Sulje konsoli");
            Console.WriteLine("Syötä 1/0");
            string komento = Console.ReadLine();
            return komento;
        }
        public static bool AloitetaankoUusiPeliVaiLopetetaanko(string komento)
        {
            if (komento == "1")
            {
                Console.Clear();
                return true;
            }
            else if (komento == "0")
            {
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Syötit virheellisen merkin, yritä uudestaan.");
                return true;
            }
        }
        public static void AloitaUusiPeli()
        {
            Console.WriteLine("Aloitetaan uusi peli!");
        }
    }
}
