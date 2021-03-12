using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter;

            Console.WriteLine("Geef een kleine letter: ");

            letter = Console.ReadLine();
            string hoofdletter = Convert.ToString(Convert.ToChar(Convert.ToByte(Convert.ToChar(letter)) - 32));
            string vrgletter = Convert.ToString(Convert.ToChar(Convert.ToByte(Convert.ToChar(letter)) - 1));
            string vlgletter = Convert.ToString(Convert.ToChar(Convert.ToByte(Convert.ToChar(letter)) + 1));
            Console.WriteLine($"Deze letter staat op plaats: {Convert.ToByte(Convert.ToChar(letter))}");
            Console.WriteLine($"De hoofdletter:{hoofdletter}");
            Console.WriteLine($"De vorige letter: {vrgletter}");
            Console.WriteLine($"De volgende letter: {vlgletter}");

            Console.ReadLine();
        }
    }
}
