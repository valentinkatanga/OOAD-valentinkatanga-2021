using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankautomaat");
            Console.WriteLine("============");
            int bedrag;
            int beginsaldo = 500;
            string answer;
            do
            {
                Console.WriteLine("wat wil je doen? a. afhalen? b. storting c. stoppen");
                answer = Console.ReadLine();

                if (answer == "a")
                {
                    Console.WriteLine("Welk bedrag wilt u afhalen?");
                    bedrag = Convert.ToInt32(Console.ReadLine());
                    beginsaldo -= bedrag;
                    Console.WriteLine($"uw nieuw saldo is gelijk aan: {Convert.ToString(beginsaldo)}");
                    

                }
                else
                if (answer == "b")
                {
                    Console.WriteLine("Welk bedrag wilt u storten?");
                    bedrag = Convert.ToInt32(Console.ReadLine());
                    beginsaldo += bedrag;
                    Console.WriteLine($"uw nieuw saldo is gelijk aan: {Convert.ToString(beginsaldo)}");
                    
                }
                else
                if (answer == "c")
                {
                    Console.WriteLine("Bedankt en tot ziens");
                }
                else
                {
                    Console.WriteLine("Uw keuze is niet correct");
                }

            } while (beginsaldo != 0);


        }
    }
}
