using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class RoundRobin
    {
        public void Robin(List<string> testilista, int rounds)
        {
            int players;
            players = testilista.Count();
            string nimi;
            int n = 0;

            while (n < rounds)
            {


                for (var i = 1; i < players; i++)
                {
                    nimi = testilista[testilista.Count - 1];
                    testilista.Remove(testilista[testilista.Count - 1]);
                    testilista.Insert(1, nimi);

                    foreach (string pelaaja in testilista)
                    {

                        Console.WriteLine(pelaaja);
                    }



                    Console.ReadLine();
                }
                n++;
            }
        }
    }
}
