﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokiprojekti
{
    public class Turnaustyyppi
    {

        public int Turnausvalinta()
        {
            Console.WriteLine("valitse turnaustyyppi:");
            Console.WriteLine("1. 1 vs 1 -turnaus");
            Console.WriteLine("2. 2 vs 2 -turnaus");

            int syöte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valitsit turnaustyypiksi " + syöte);

            if (syöte == 1)
            {
                Console.WriteLine("tästä alkaa 1 vs 1 turnaustyypin koodi");
                return 1;
            }

            else if (syöte == 2)
            {
                Console.WriteLine("tästä alkaa 2 vs 2 turnaustyypin koodi");
                return 2;
            }

            else
            {
                Console.WriteLine("huppis, ei muuta vaihtoehtoa!");
                return 0;
                // aloita luuppi alusta
            }

            //jos syöte on jotain muuta kuin numeroita, ohjelma kaatuu

            
        }

    }
}