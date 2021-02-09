using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Päävalikko
    {
        public static void AlkuValikko()
        {
            string komento = PyydäMerkkiä();
            AloitetaankoUusiTurnausVaiLopetetaanko(komento);
        }
        private static string PyydäMerkkiä()
        {
            Console.WriteLine("Tervetuloa Änäri-äppiin");
            Console.WriteLine("1 Aloita uusi turnaus\n0 Sulje konsoli");
            string komento = Console.ReadLine();
            return komento;
        }
        private static void AloitetaankoUusiTurnausVaiLopetetaanko(string komento)
        {
            if (komento == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                if (komento == "1")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Annoit virheellisen syötteen\n");
                    AlkuValikko();
                }

            }
        }
    }
}
