using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary;

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat t1; // deklaracja zmiennej typu Trojkat
            t1 = new Trojkat();

            Console.WriteLine(t1);
            Console.WriteLine(t1.GetObwod());
            Console.WriteLine(t1.Obwod);
            Console.WriteLine($"pole = {t1.GetPole()}");
            Console.WriteLine($"pole = {t1.Pole}");
            try
            {
                t1.A = -1;
                t1.B = -2;
                t1.C = -3;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Nie wolno bokom przypisywać wartości ujemnych");
            }
            Console.WriteLine(t1);
            Console.WriteLine(t1.Pole);

            Console.WriteLine("==========================");
            var t2 = new Trojkat(3, 4, 5);
            Console.WriteLine(t2);
            Console.WriteLine(t2.A);
            t2.B = 100;
            Console.WriteLine(t2);
        }                    
    }
}
