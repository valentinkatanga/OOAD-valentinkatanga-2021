using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Kaart
    {
       

        private int nummer ;
        private string kleur;

        public string Kleur {
            get {

                return kleur;
            } 
            set {
               if (value == "C" || value == "S" || value == "H" || value == "D")
                {
                    kleur = value;
                }               
            
             } }

        public int Nummer
        {
            get { return nummer; }
            set { 

               if (value >= 1 && value <= 13)
                {
                    nummer = value;
                }
            }
        }

        public Kaart(int nummer, string kleur)
        {
            Nummer = nummer;
            Kleur = kleur;
        }
    }
}
