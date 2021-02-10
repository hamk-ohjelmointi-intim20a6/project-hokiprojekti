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
            bool isRunning = true;

            while (isRunning)
            {

                Console.WriteLine("Valitse pelattavien kierrosten määrä ja paina ENTER: ");
                bool tarkistaLuku = int.TryParse(Console.ReadLine(), out int kierrosmäärä);
                Console.Clear();


                if (tarkistaLuku)
                {
                    Console.WriteLine("Valitsit " + kierrosmäärä + " kierrosta. Onko haluttu kierrosmäärä oikein?");
                    Console.WriteLine("k/e");
                    string onkoOK = Console.ReadLine();


                    if (onkoOK == "k" | onkoOK == "K")
                    {
                        Console.Clear();
                        return kierrosmäärä;
                    }
                    else
                    {
                        Console.Clear();
                        isRunning = true;
                    }

                }

                

            }
            return 0;
        }

       
        
    }
}
