using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.Projekt_Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Gib deine erste Zahl ein: ");
            string zahl1 = Console.ReadLine();
            double zahlA = Convert.ToDouble(zahl1);


            Console.Write("Gib einen Operator ein: + - * /: ");
            string Operator = Console.ReadLine();



            Console.Write("Gib deine zweite Zahl ein: ");
            string zahl2 = Console.ReadLine();
            double zahlB = Convert.ToDouble(zahl2);


            if (Operator == "+")
            {
                Console.WriteLine();
                Console.WriteLine("Dein Ergebnis ist: " + zahlA + zahlB);
            }
            else if (Operator == "-")
            {
                Console.WriteLine();
                Console.WriteLine("Dein Ergebnis ist: " + (zahlA - zahlB));
            }
            else if (Operator == "*")
            {
                Console.WriteLine();
                Console.WriteLine("Dein Ergebnis ist: " + zahlA * zahlB);
            }
            else if (Operator == "/")
            {
                if (zahlB == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Durch Null teilen ist nicht möglich");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Dein Ergebnis ist: " + zahlA / zahlB);
                }



            }
        }
    }
}
