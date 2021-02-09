using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    public class Kierrokset
    {

        public void Kierrosluku()
        {
            Console.WriteLine("valitse pelattavien kierrosten määrä: ");
            int syöte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valitsit " + syöte + " kierrosta");

            if (syöte == 1)
            {
                Console.WriteLine("tästä alkaa yhden kierroksen koodi");
            }

            else
            {
                Console.WriteLine("valittu kierrosluku oli jotain muuta kuin 1");
            }

            //jos syöte on jotain muuta kuin numeroita, ohjelma kaatuu

           Console.ReadLine();
            

        }

       
        
    }
}
