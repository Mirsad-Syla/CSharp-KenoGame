using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace KenoGame
{
    public class Lojtari
    {
        private string emri; 
        public string Mbiemri;
        public double Cmimi;
        public int[] Numrat = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //Vargu qe ruan numrat e shtypur nga lojtari
        public string Emri
        {
            get
            {
                return emri;  //Merr vleren e emrit
            }
            set
            {
                emri = value;// vendos vleren e dhene nga shfrytezuesi
            }
        }
    }
}
