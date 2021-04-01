using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Deck
    {
        private static Random rng = new Random();
        public List<Kaart> Kaarten { get; set; }


        public Deck() 
        {
            Kaarten = new List<Kaart>();

            for (int i = 0; i < 52; i++)
            {
                int waarde = rng.Next(13) + 1;
                Kaarten.Add(new Kaart(waarde, "C"));
            }
        }

        public void Schudden()
        {
            Shuffle(Kaarten);
        }

        public Kaart NeemKaart()
        {
            int random_index = rng.Next(Kaarten.Count);
            return Kaarten[random_index];
        }

        private void Shuffle(List<Kaart> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Kaart value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
