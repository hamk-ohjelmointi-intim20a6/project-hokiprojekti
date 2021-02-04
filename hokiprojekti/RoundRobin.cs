using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class RoundRobin
    {
        public void Lista()
        {
            List<string> testiLista = new List<string>();
            testiLista.Add("Pekka");
            testiLista.Add("Liisa");
            testiLista.Add("Martti");
            testiLista.Add("Maija");
            return;
        }

        public void Robin()
        {
            for (var i = 0; i < 8; i++)
            {
                Console.WriteLine($"{testiLista.Next()},");
            }
        }

    }
}
