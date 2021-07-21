using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KenoGame
{
    public class NumratEQelluar : Lojtari
    {
       public int TeQelluara = 0; //Ruan numrin e te qelluarve
        public int NrQelluara(int[] random, int[] NrLojtarit) //Metoda si parametra ka dy vargje, numrat e gjeneruara random, dhe numrat e shtypura nga lojtari
        {
            int count = 0; //Numron numrin e te qelluarave
   
            for (int i = 0; i < random.Length; i++)
            {
                for (int j = 0; j < NrLojtarit.Length; j++)
                {
                    if (random[i] == NrLojtarit[j]) //Kushti nese numri i shtypur nga lojtari eshte i barabarte me numrin e gjeneruar
                    {
                        count++; // Rritet numruesi per nje
                        break;
                    }
                }
            }                   
 
            return count; // Kthehet numri i te qelluarave
        }

        public bool KontrolloVleratHyrese(int[] numrat) //Funksion qe si parameter pranon vargun e numrave qe shtypen nga shfrytezuesi
        {
            for (int i = 0; i < numrat.Length; i++)
            {
                if (numrat[i] == 0) 
                    break; //Nese plotesohet kushti kalohet ky hap
                for (int j = 0; j < numrat.Length; j++)
                {
                    if (i == j)
                        continue; // Nese plotesohet ky kusht kalojme ne unaze sepse numrat me indeks te njejte nuk krahasohen
                    if (numrat[i] == numrat[j]) //Kontrollohet nese eshte shtypur numri i njejte
                    {
                        return false; // Tregon qe eshte shtypur numri i njejte
                    }
                }
            }
            return true;
        }
        public  void Listimi(NumratEQelluar[] lojtari)//Funksioni  Listimi  si parameter ka klasen e derivuar NumratEQelluar
        {
           
            bool count = false;
            for (int i = 10; i >= 5; i--) //Lojtaret NrQelluara kane 5 ose me shume te qelluara
            {
                for (int j = 0; j < lojtari.Length; j++)
                {
                    if (lojtari[j].TeQelluara == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; //Vendos shkronjat ne ngjyre te gjelbert
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("Emri i lojtarit: {0}", lojtari[j].Emri);
                        Console.Write("Numrat e dhene: ");
                        var sortAscending =
                                from value in lojtari[j].Numrat
                                orderby value
                                select value;
                        foreach (int value in sortAscending)
                        {                                
                            Console.Write("{0},", value);
                        }
                        Console.WriteLine("\nNumri i te qelluarave: {0}", i);
                        Console.Write("Cmimi i fituar eshte: {0}",(lojtari[j].Cmimi +( 0.2* lojtari[j].Cmimi)*i).ToString("0.00"));
                        Console.Write("\n==============================================");
                        Console.ResetColor();
                        count = true; //count behet true per te treguar qe kane qellu 5 ose me shume vlera
                    }
                }

            }

            if (!count) 
                /*Nese count eshte kthy si vlere true ky e shndrron ne false dhe nuk e ekzekuton funskionin brenda kllapave,
                nes eshte kthy vlere false ky e shndrron ne true dhe  e ekzekuton funksionin brenda kllapave*/
            {

                Console.WriteLine("\n==============================================");
                Console.WriteLine("Nuk ka asnje lojtar me 5 ose me shume te qelluara!");
                Console.WriteLine("==============================================");
            }
            return;
            
        }

    }
}














