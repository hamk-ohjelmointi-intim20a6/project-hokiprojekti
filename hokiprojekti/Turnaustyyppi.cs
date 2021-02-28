using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    //Turnaustyypin valinta tällä hetkellä ohjelmassa tarpeeton.
    //Päädyimme tekemään vain 1 vs 1 otteluohjelman, mutta tämä on valmiina, jos sitä joskus tarvitsee.
    public class Turnaustyyppi
    {

        public int Turnausvalinta()
        {

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Valitse turnaustyyppi numerolla:");
                Console.WriteLine("1.\t 1 vs 1 -turnaus");
                Console.WriteLine("2.\t 2 vs 2 -turnaus");
                bool tarkistaLuku = int.TryParse(Console.ReadLine(), out int valinta);
                Console.Clear();


                if (tarkistaLuku)
                {
                    if (valinta == 1)
                    {
                        Console.WriteLine("Valitsit turnaustyypiksi 1 vs 1 -turnauksen. Onko valinta ok?");
                        Console.WriteLine("k/e");
                        string onkoOk = Console.ReadLine();


                        if (onkoOk == "k" | onkoOk == "K")
                        {
                            Console.Clear();
                            return valinta;
                        }
                        else
                        {
                            Console.Clear();
                            isRunning = true;
                        }
                    }
                    else if (valinta == 2)
                    {
                        Console.WriteLine("Valitsit turnaustyypiksi 2 vs 2 -turnauksen. Onko valinta ok?");
                        Console.WriteLine("k/e");
                        string onkoOk = Console.ReadLine();


                        if (onkoOk == "k" | onkoOk == "K")
                        {
                            Console.Clear();
                            return valinta;
                        }
                        else
                        {
                            Console.Clear();
                            isRunning = true;
                        }
                    }

                }

                else
                {
                    Console.Clear();
                    isRunning = true;
                }

            }
            return 0;
        }

    }
}
