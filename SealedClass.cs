using System;
using System.Collections.Generic;
using System.Text;

namespace KenoGame
{
    public sealed class  SealedClass
    {
        public void Funk()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("              =========================================           ");
            Console.WriteLine("                   Ju urojme fat ne lojen Keno.                  ");
            Console.WriteLine("              =========================================           \n");
            Console.ResetColor(); //Kthen ngjyren e nenkuptuar te shkronjave
        }
    }
}
