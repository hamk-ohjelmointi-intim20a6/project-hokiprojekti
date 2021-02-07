using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Päävalikko
    {
        public void AlkuValikko()
        {
            string komento = PyydäMerkkiä();
            AloitetaankoUusiPeliVaiLopetetaanko(komento);

            if (komento == "1")
            {
                return;
            }
            else
            {
                AlkuValikko();
            }
        }
        public string PyydäMerkkiä()
        {
            Console.WriteLine("Tervetuloa Änäri-äppiin");
            Console.WriteLine("1 Aloita uusi peli\n0 Sulje konsoli");
            Console.WriteLine("Syötä 1/0");
            string komento = Console.ReadLine();
            return komento;
        }
        public void AloitetaankoUusiPeliVaiLopetetaanko(string komento)
        {
            if (komento == "1")
            {
                Console.Clear();
            }
            else if (komento == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Syötit virheellisen merkin, yritä uudestaan.\n");
            }
        }
    }
}
