using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Type_conversion
{
    class Program
    {
        static int convertStringToInt(string str)
        {
            int num = 0;
            int coeff = 1;

            for (int i = str.Length - 1; i != 0; --i, coeff *= 10)
                num += (str[i] - '0') * coeff;

            if (str[0] != '-')
                return (num += (str[0] - '0') * coeff);

            return (-num);
        }

        static void Main()
        {
            Console.WriteLine("Write any number:\n");
            string myStr = Console.ReadLine();

            Console.WriteLine("\nConvertion string to integer number: {0}", convertStringToInt(myStr));

            Console.ReadLine();
        }
    }
}
