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

            while (true)
            {
                Päävalikko.AlkuValikko();

                int pelaajienMäärä = Pelaajat.pelaajienMäärä();

                List<string> listaPelaajista = Pelaajat.listaPelaajista(pelaajienMäärä);

                //valitaan haluttu kierrosmäärä peliin
                Kierrokset kierrokset = new Kierrokset();

                //Tämä osio kommentoitu pois sen tarpeetoomuuden takia.
                /*Turnaustyyppi turnaustyyppi = new Turnaustyyppi();
                turnaustyyppi.Turnausvalinta();*/

                RoundRobin roundRobin = new RoundRobin();

                int rounds = kierrokset.Kierrosluku(); ;
                roundRobin.Robin(listaPelaajista, rounds);

                Tallennus.TallennaJSON();
            }
        }
    }
}
