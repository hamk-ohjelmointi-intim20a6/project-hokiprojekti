using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    class Pelaajat
    {
       
       
        public static int pelaajienMäärä() //Kysytään käyttäjältä pelaajien määrä
        {
            bool isRunning = true;
            
            
            while (isRunning)
            {
                Console.WriteLine("Anna pelaajien määrä lukuna ja paina ENTER");
                bool onkoNumero = int.TryParse(Console.ReadLine(), out int pelaajienLukuMäärä);
                Console.Clear();


                if (onkoNumero)
                {
                    Console.WriteLine("Annoit pelaajien määräksi " + pelaajienLukuMäärä + ". Onko pelaajien määrä oikein?");
                    Console.WriteLine("k/e");
                    string onkoOk = Console.ReadLine();
                    

                  
                    if (onkoOk == "k" | onkoOk == "K")
                    {

                        Console.Clear();
                        return pelaajienLukuMäärä;         
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
        public static List<string> listaPelaajista(int pelaajienLukumäärä) //Kysytään pelaajien nimet
        {
            bool isRunning = true;
            List<string> pelaajienNimet = new List<string>();
            while (isRunning)
            {
                
                for (int i = 0; i < pelaajienLukumäärä; i++)
                {

                    Console.Write("Anna pelaajan nimi ja paina ENTER: ");

                    pelaajienNimet.Add(Console.ReadLine());
                }

                Console.Clear();

                Console.WriteLine("Pelaajat:");

                foreach (var pelaaja in pelaajienNimet)
                {
                    Console.WriteLine(pelaaja);
                }

                Console.WriteLine("Onko pelaajalista oikein?");
                Console.WriteLine("k/e");
                string onkoOk = Console.ReadLine();

                if (onkoOk == "e" | onkoOk == "E")
                {
                    pelaajienNimet.Clear();
                    Console.Clear();
                    isRunning = true;

                }
                else
                {
                    Console.Clear();
                    return pelaajienNimet;

                }

                
            }

            return pelaajienNimet;
        }


        
       
    }
}
