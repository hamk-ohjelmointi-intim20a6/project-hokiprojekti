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
            //Testi commit
            RoundRobin roundRobin = new RoundRobin();
            List<string> testilista = new List<string>();
            testilista.Add("1");
            testilista.Add("2");
            testilista.Add("3");
            testilista.Add("4");
            testilista.Add("5");
            int rounds;
            rounds = 4;
            roundRobin.Robin(testilista, rounds);
            /*List<Pelaaja> listapelaajista = otteluOhjelma1v1.Lista();
            otteluOhjelma1v1.Printti(listapelaajista);*/


            Console.ReadLine();
        }
    }
}
