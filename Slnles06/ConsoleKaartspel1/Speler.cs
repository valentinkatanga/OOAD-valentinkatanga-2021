using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Speler
    {

        private int teller;
        public string Naam { get; set; }
        public List<Kaart> Kaarten { get; set; }
        public bool HeeftNogKaarten { 
            get {
                return teller < Kaarten.Count;
            }
        }


        private static Random rng = new Random();

        public Speler(string naam)
        {
            Naam = naam;
            Kaarten = new List<Kaart>();
        }

        public Speler(string naam, List<Kaart> kaarten)
        {
            Naam = naam;
            Kaarten = kaarten;
        }

        public Kaart LegKaart()
        {
            teller += 1;
            int random_index = rng.Next(Kaarten.Count);
            return Kaarten[random_index];
        }
    }
}
