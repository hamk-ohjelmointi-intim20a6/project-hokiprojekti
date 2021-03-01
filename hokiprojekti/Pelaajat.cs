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
            
            
            while (isRunning) //while luuppaa niin kauan kunnes käyttäjä syöttää numeroksi kelpaavan syötteen
            {
                Console.WriteLine("Anna pelaajien määrä lukuna ja paina ENTER");
                bool onkoNumero = int.TryParse(Console.ReadLine(), out int pelaajienLukuMäärä);
                Console.Clear();


                if (onkoNumero) //jos käyttäjän syöte voidaan muuttaa numeroksi kysytään käyttäjältä onko määrä oikein.
                {
                    Console.WriteLine("Annoit pelaajien määräksi " + pelaajienLukuMäärä + ". Onko pelaajien määrä oikein?");
                    Console.WriteLine("k/e");
                    string onkoOk = Console.ReadLine();
                    

                  
                    if (onkoOk == "k" | onkoOk == "K") //jos käyttäjä on tyytyväinen pelaajien määrään palautetaan pelaajien määrä
                    {

                        Console.Clear();
                        return pelaajienLukuMäärä;         
                    }
                    else // jos käyttäjä ei ole tyytyväinen ja painaa muuta kuin k-näppäintä jatketaan kyselyä.
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
            List<string> pelaajienNimet = new List<string>(); //lista pelaajien nimiä varten
            while (isRunning)
            {
                
                for (int i = 0; i < pelaajienLukumäärä; i++) //kysellään nimiä niin monta kertaa kuin pelaajien määrä on määritettyä
                {

                    Console.Write("Anna pelaajan nimi ja paina ENTER: ");

                    pelaajienNimet.Add(Console.ReadLine());
                }

                Console.Clear();

                Console.WriteLine("Pelaajat:"); 

                foreach (var pelaaja in pelaajienNimet) //Tulostetaan syötetyt pelaajat
                {
                    Console.WriteLine(pelaaja);
                }

                Console.WriteLine("Onko pelaajalista oikein?");
                Console.WriteLine("k/e");
                string onkoOk = Console.ReadLine();

                if (onkoOk == "e" | onkoOk == "E") // Mikäli pelaajien nimiin ei olla tyytyväisiä tyhjennetään lista ja kysytään nimet uusiksi.
                {
                    pelaajienNimet.Clear();
                    Console.Clear();
                    isRunning = true;

                }
                else //jos nimiin ollaan tyytyväisiä palautetaan pelaajienNimet lista.
                {
                    Console.Clear();
                    return pelaajienNimet;

                }

                
            }

            return pelaajienNimet;
        }


        
       
    }
}
