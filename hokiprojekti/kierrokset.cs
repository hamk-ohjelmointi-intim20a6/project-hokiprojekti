using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    public class Kierrokset
    {

        public int Kierrosluku()
        {
            Console.WriteLine("valitse pelattavien kierrosten määrä: ");
            int syöte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valitsit " + syöte + " kierrosta");

            return syöte;

            //jos syöte on jotain muuta kuin numeroita, ohjelma kaatuu

            
            

        }

       
        
    }
}
