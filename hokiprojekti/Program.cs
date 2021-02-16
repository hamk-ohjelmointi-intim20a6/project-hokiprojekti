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

            int pelaajienMäärä = Pelaajat.pelaajienMäärä();

            List<string> listaPelaajista = Pelaajat.listaPelaajista(pelaajienMäärä);

            //valitaan haluttu kierrosmäärä peliin
            Kierrokset kierrokset = new Kierrokset();
            kierrokset.Kierrosluku();

            //valitaan turnaustyyppi: 1vs1 tai 2vs2
            Turnaustyyppi turnaustyyppi = new Turnaustyyppi();
            turnaustyyppi.Turnausvalinta();


            RoundRobin roundRobin = new RoundRobin();
            
         
            int rounds;
            rounds = 2;
            roundRobin.Robin(listaPelaajista, rounds);

            Tallennus.TallennaJSON();
            Tallennus.TallennaTXT();
        }
    }
}
