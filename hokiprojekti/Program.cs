﻿using System;
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
            // Konsolin otsikko
            Console.Title = "Änäri-äppi";

            /* Päävalikko.AlkuValikko();

             int pelaajienMäärä = Pelaajat.pelaajienMäärä();

             List<string> listaPelaajista = Pelaajat.listaPelaajista(pelaajienMäärä);

             Kierrokset kierrokset = new Kierrokset();
             kierrokset.Kierrosluku();

             Turnaustyyppi turnaustyyppi = new Turnaustyyppi();
             turnaustyyppi.Turnausvalinta();

             RoundRobin roundRobin = new RoundRobin();


             int rounds;
             rounds = 4;
             roundRobin.Robin(listaPelaajista, rounds);*/

            var list = new List<string> { "1", "2", "3", "4" };
            Generointi_2v2 generointi = new Generointi_2v2();
            generointi.KopioiLista(list);

            Console.ReadKey();


        }
    }
}
