using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using KenoGame;
using System.Reflection.Emit;

namespace KenoGame
{
    public static class viti
    {
        //Metoda e mbingarkuar
        public static void vitet(int viti, string emri)  //Metoda e pare pranon si parameter vitin(integer)  dhe emrin (string)
        {
            if (viti < 18) //Kushti qe lojtaret pjesemarres te jene te moshes madhore
                Console.Write("Ju Z/Znj.{0} ", emri);

        }
        public static void vitet(int viti) //Metoda e dyte pranon si parameter vitin
        {
            if (viti < 18) //Kushti qe lojtaret pjesemarres te jene te moshes madhore
            {
                Console.Write("nuk mund te luani sepse jeni me i vogel se 18 vjet!");
                throw new System.Exception();
            }
        }
    }
    class Program
    {
        enum Statusi 
        {
            rregullt,
            parregullt

        };
        static void Main(string[] args)
        {
            Console.Title = "Loja e fatit me numra nga 1 deri ne 80"; //Paraqitja e titullit ne konzole

            Informata info = new Informata(); 

            info.Hyrja(); //Thirrja e funksionit permes instances se klases
            SealedClass klasaseald = new SealedClass();
            klasaseald.Funk();

            int[] NumGen = new int[10]; //Deklarimi i nje vargu nga  10 numrave 

            Random RandomGen = new Random(); 

            //List<int> numratRandom = new List<int>();
            NumratEQelluar nr = new NumratEQelluar();

            for (int i = 0; i < NumGen.Length; i++)
            {
                NumGen[i] = RandomGen.Next(1, 81);//Gjenerimi i numrav random nga 1 deri ne 80
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (i != j) // Gjenerimi i numrave random te ndryshem nga duplikimi
                        {
                            if (NumGen[i] == NumGen[j])
                            {
                                i--;
                            }
                        }
                    }
                }
            }
        a: Console.Write("\nTe jepet numri i lojtareve qe do te marrin pjese ne kete xhiro: ");

            int NumLojtar; //Variabla qe ruan numrin e lojetareve

            //Validimi  qe te shkruhen vetem  numra kur kerkohet te jepet numri i lojetareve
            while (!int.TryParse(Console.ReadLine(), out NumLojtar))
            {

                Console.WriteLine("Nuk lejohen shkronja");
                Console.Write("\nTe jepet numri i lojtareve qe do te marrin pjese ne kete xhiro: ");
            }
            if (NumLojtar <= 0)  //Validimi qe te mos shenohen numrat me te vogel se 1
            {
                Console.WriteLine("Per te filluar lojen duhet se paku te marre pjese 1 lojtare! ");
                goto a;
            }

             //Krijimi i nje instance te klases se trasheguar

            NumratEQelluar[] Lojtari = new NumratEQelluar[NumLojtar]; //Krijimi i nje  instance te klases NumratEQelluar qe ruan numrin e lojetareve
            for (int i = 0; i < Lojtari.Length; i++)
            {

            c: Console.WriteLine("\nTe dhenat e lojtarit {0}", i + 1);
                Lojtari[i] = new NumratEQelluar();

                //Leximi i te dhenave te lojetarit

                bool IsFound = false;
                while (IsFound == false)
                {
                    Console.Write("Emri:");
                    Lojtari[i].Emri = Console.ReadLine();
                    try
                    {
                        if (Lojtari[i].Emri.ToUpper() == Lojtari[i].Emri.ToLower())
                        {
                            Console.WriteLine("Ju lutem pranohen vetem shkronja");
                        }
                        else
                        {
                            IsFound = true;
                        }
                    }
                    catch (Exception)
                    {
                        IsFound = false;
                    }
                }


                bool IsFound1 = false;
                while (IsFound1 == false)
                {
                    Console.Write("Mbiemri:");
                   Lojtari[i].Mbiemri = Console.ReadLine();
                    try
                    {
                        if (Lojtari[i].Mbiemri.ToUpper() == Lojtari[i].Mbiemri.ToLower())
                        {
                            Console.WriteLine("Ju lutem pranohen vetem shkronja");
                        }
                        else
                        {
                            IsFound1 = true;
                        }
                    }
                    catch (Exception)
                    {
                        IsFound1 = false;
                    }
                }

               
                Console.Write("Sa vjec jeni:");
                int year = Convert.ToInt32(Console.ReadLine());
                //viti v = new viti();//Krijimi i nje intance te klases viti

                try
                {
                    viti.vitet(year, Lojtari[i].Emri);//Thirrja e funksionit te mbingarkuar  me parametrat e viti dhe emrit te lojtarit
                    viti.vitet(year); //Thirrja e funksioni te mbingarkur me parametrin integer viti
                }
                catch
                {
                    goto c;
                }
                Console.Write("A eshte hera e pare qe jeni duke luajtur 0/Po, 1/Jo: ");
                string pergjigja = Console.ReadLine();
                int num = Convert.ToInt32(pergjigja);
                if ((num == 0) || (num == 1))// Duhet te shtypen numrat 0 ose 1 per te treguuar statusin e lojtarit
                {
                    if (num == 0) // Shtypja e 0 tregon per statusin e rregullt, ndersa 1 per status te parregullt
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Ju jeni lojtar i {0} qe luani lojen Keno", Statusi.parregullt);
                        LojtariParregullt lojtar = new LojtariParregullt();
                        lojtar.Mesazhi();
                    }
                    else
                        Console.WriteLine("Ju jeni lojtar i {0} qe luani lojen Keno", Statusi.rregullt);
                    Console.ResetColor();

                }
                else
                {
                    throw new System.Exception(); //Leshimi i nje Exception
                }

                f: Console.Write("Jepni cmimin: ");

                int CmimiEuro; //Variabla qe ruan numrin e lojetareve


                while (!int.TryParse(Console.ReadLine(), out CmimiEuro))
                {

                    Console.WriteLine("Nuk lejohen shkronja/ numra decimal");
                    Console.Write("Jepni cmimin: ");
                }
                if (CmimiEuro <= 0)  //Validimi qe te mos shenohen numrat me te vogel se 1
                {
                    Console.WriteLine("Per te filluar lojen duhet te jepni vlere pozitive! ");
                    goto f;
                }
                else
                {
                    Lojtari[i].Cmimi = CmimiEuro;
                }

                for (int j = 0; j < Lojtari[i].Numrat.Length; j++)
                {

                    try
                    {
                        Console.Write("Shtyp numrin e {0}: ", j + 1);
                        Lojtari[i].Numrat[j] = Convert.ToInt32(Console.ReadLine());//Leximi i numrave qe shtypen nga lojtari
                    }
                    catch
                    {
                        Console.WriteLine("Ju lutem jepni numra");
                    }
                    if (Lojtari[i].Numrat[j] < 1 || Lojtari[i].Numrat[j] > 81) //kushti nese  numri qe shtypet esht jasht rangut 1 dhe 80
                    {
                        j--;//Mundeson qe te shtypet numri i cili kerkohet p.sh numrin e tret e shtypim 81 ,prap me kerku nr e tret
                        Console.WriteLine("Shtyp numrat vetem nga 1 deri 80 !\n");
                        continue;
                    }
                    if (!nr.KontrolloVleratHyrese(Lojtari[i].Numrat)) //Kontrollon se a eshte shtyp numri i njejt apo jo
                    {
                        j--;
                        Console.WriteLine("Nuk mund te shtypet numri i njejt 2 here!\n");
                    }
                }

                Lojtari[i].TeQelluara = nr.NrQelluara(NumGen, Lojtari[i].Numrat);//Mbushja e numrave te qelluar nga lojtari
                Console.WriteLine();
            }

            /*  Shtypja  e numrave te gjeneruar nga sistemi*/
            Console.Write("Numrat e gjeneruar nga softueri jane: ");
            for (int i = 0; i < NumGen.Length; i++)
            {
                //Te numri i fundit mos me vendos presje por me dal kryerresht
                if (i != NumGen.Length - 1)
                {
                    Console.Write("{0},", NumGen[i]);
                }
                else
                {
                    Console.Write("{0}\n", NumGen[i]);
                }
                Thread.Sleep(1000);
            }
            nr.Listimi(Lojtari);//Listimi i lojtareve ne baze te numrave te qelluar
            Perfundimi obj = new PerfundimiLojes(); //Krijimi i nje instance te interface
            obj.Fundi();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}