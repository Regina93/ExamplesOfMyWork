using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverse_string
{
    class Program
    {
        //O(n)
        static void reverseString(ref string str)
        {
            StringBuilder copyStr = new StringBuilder(str);

            for (int i = 0; i < copyStr.Length / 2; ++i)
            {
                char buff = copyStr[i];
                copyStr[i] = copyStr[(copyStr.Length - 1) - i];
                copyStr[(copyStr.Length - 1) - i] = buff;
            }

            str = copyStr.ToString();
        }

        static void Main(string[] args)
        {
            string myStr = null;

            Console.WriteLine("Write something...\n");
            myStr = Console.ReadLine();

            reverseString(ref myStr);

            Console.WriteLine("\nReversing string: \"{0}\"\n", myStr);

            Console.ReadLine();
        }
    }
}
