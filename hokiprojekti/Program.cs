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

            // Kysytään käyttäjältä aloitetaanko peli vai suljetaanko konsoli. 
            // Antamalla "1" ohjelma jatkuu, mikä tahansa muu merkki sulkee konsolin.
            Console.WriteLine("Tervetuloa Änäri-äppiin");
            Console.WriteLine("1 Aloita uusi peli\n0 Sulje konsoli");
            Console.WriteLine("Syötä 1/0");
            string komento = Console.ReadLine();
            if (komento.StartsWith("1"))
            {
                Console.Clear();
                // tänne tulis sitten ohjelman jatkohommat
                Console.WriteLine("Jee aloitetaan uusi peli!");
                Console.WriteLine("Ohjelma sulkeutuu kun painat jotain nappia..");
                Console.ReadKey();
            }
        }
    }
}
