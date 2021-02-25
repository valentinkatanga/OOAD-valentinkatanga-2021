using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleKlinker
{
    class Program
    {
        static void Main(string[] args)
        {
            int countklinkers = 0;
            Char[] klinkers = new Char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Geef een tekst: ");
            string antwoord = Console.ReadLine();
            for (int i = 0; i < antwoord.Length; i++)
            {
                if (klinkers.Contains(antwoord[i]))
                {
                    countklinkers++;
                }
            }
            Console.WriteLine($"Deze tekst bevat {countklinkers} klinkers");
            

            Console.ReadLine();



        }
    }
}
