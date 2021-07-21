using System;
using System.Collections.Generic;
using System.Text;
using KenoGame;
namespace KenoGame
{
    public class PerfundimiLojes:Perfundimi
    {
        void Perfundimi.Fundi() //
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n==========Faleminderit per pjesemarrjen tuaj. Ju mirepresim perseri!==========");
            Console.ResetColor();
        }
    }
}
