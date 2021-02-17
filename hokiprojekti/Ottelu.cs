using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Ottelu
    {
        public int KierrosNro { get; set; }
        public int OtteluNro { get; set; }

        public string Koti { get; set; }

        public string Vieras { get; set; }

        public override string ToString()
        {
            return $"Kierros nro. {KierrosNro}, peli nro. {OtteluNro}: {Koti} vs {Vieras}";
        }
    }
}
