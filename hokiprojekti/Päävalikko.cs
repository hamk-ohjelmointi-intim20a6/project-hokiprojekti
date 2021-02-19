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
            Console.WriteLine("1 Tee uusi otteluohjelma\n2 Tarkastele vanhoja otteluohjelmia\n0 Sulje konsoli");
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
                else if (komento == "2")
                {
                    VanhojenOhjelmienSelaus();
                }
                else
                {
                    Console.WriteLine("Annoit virheellisen syötteen\n");
                    AlkuValikko();
                }
            }
        }

        public static void JatketaankoVaiLopetetaanko()
        {
            Console.WriteLine("1 Päävalikkoon\n0 Sulje sovellus");
            string komento = Console.ReadLine();

            if (komento == "0")
            {
                Environment.Exit(0);
            }
            else if (komento == "1")
            {
                Console.Clear();
                return;
            }
            else
            {
                Console.WriteLine("Annoit virheellisen syötteen");
                JatketaankoVaiLopetetaanko();
            }
        }
        private static void VanhojenOhjelmienSelaus()
        {
            Console.Clear();
            Tallennus.LueJSON();

            Console.WriteLine("\nPaina jotain nappia jatkaaksesi");
            Console.ReadKey();

            Console.Clear();
            AlkuValikko();
        }
    }
}
