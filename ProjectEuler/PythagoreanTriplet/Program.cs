using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int c;
            for (int a = 1; a < 1001; a++)
            {
                for (int b = a; b < a + 1001; b++)
                {
                    if (a + b > 1000)
                        break;

                    c = 1000 - a - b;

                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        Console.WriteLine(string.Format("a: {0}, b: {1}, c: {2}", a, b, c));
                        Console.WriteLine(string.Format("answer: {0}", a * b * c));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
