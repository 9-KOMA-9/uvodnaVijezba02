using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaViježba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, d;
            a = 10;
            b = 7;
            c = 12.5;
            d = 16.7;
            Console.WriteLine(" srednja vrijednost ovih brojeva je " + (a + b + c + d) / 4);
            Console.ReadKey();
        }
    }
}
