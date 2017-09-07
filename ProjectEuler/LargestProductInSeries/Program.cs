using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.IO;

namespace LargestProductInSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string bigNumber = File.ReadAllText(@"..\\..\\bigNumber.txt");
                bigNumber = bigNumber.Replace("\n", "");
                bigNumber = bigNumber.Replace("\t", "");
                bigNumber = bigNumber.Replace("\r", "");
        
                BigInteger largest = 0;
                BigInteger product;

                for (int i = 0; i < bigNumber.Length - 12; i++)
                {
                    product = bigNumber[i] - 48;
                    for (int j = i + 1; j < i + 13; j++)
                    {
                        product = product * (bigNumber[j] - 48);
                        if (largest <= product)
                        {
                            largest = product;
                        }
                    }
                }

                Console.WriteLine(largest);
                Console.ReadLine();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File doesn't exist");
                Console.ReadLine();
            }
        }

        private static char[] SplitString(string literal)
        {
            literal = literal.Replace("\n", "");
            literal = literal.Replace("\t", "");
            literal = literal.Replace("\r", "");
            return literal.ToCharArray();
        }
    }
}
