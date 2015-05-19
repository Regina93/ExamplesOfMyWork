using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nSum
{
    class Program
    {
        static int sumFormula(int n)
        {
            return n * (n + 1) / 2;
        }

        static int sumRecursive(int n)
        {
            if (n == 1) return 1;
            else return n + sumRecursive(n - 1);
        }

        static void Main(string[] args)
        {
            int n = 10000;

            Console.WriteLine("\nFormula of sum {0} = {1}\n", n, sumFormula(n));
            Console.WriteLine("Recursive sum {0} = {1}", n, sumRecursive(n));
            Console.ReadLine();
        }
    }
}
