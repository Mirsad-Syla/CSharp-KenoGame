using System;
using System.Collections.Generic;
using System.Text;

namespace KenoGame
{
    class Informata : KlasaAbstrakte
    {
        public override void Hyrja() //Metoda virtuale qe trashegohet nga klasa baze, perdoret per paraqitjen e informatave  hyrese ne konzole
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("              =========================================           ");
            Console.WriteLine("               LOJA E FATIT ME NUMRA NGA 1 NE 80                  ");
            Console.WriteLine("              =========================================           \n");
            Console.ResetColor(); 
            Console.ForegroundColor = ConsoleColor.Red;//Vendos ngjyren e shkronjave ne te kuqe
            Console.WriteLine("                            KUJDES!                     ");

            Console.WriteLine("             =========================================        ");

            Console.WriteLine("             Duhet te shkruani infomata te verteta ne  \n             te kunderten edhe nese fitoni nuk do te \n             mund te merrni shperblimin!");
            Console.WriteLine("             =========================================\n");
            Console.ResetColor();
        }
    }
}
