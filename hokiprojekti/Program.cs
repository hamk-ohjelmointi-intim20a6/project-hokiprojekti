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
            int pelaajienMäärä = Pelaajat.pelaajienMäärä();
           
            List<string> listaPelaajista = Pelaajat.listaPelaajista(pelaajienMäärä);
            
            Console.ReadKey();
            
        }
    }
}
