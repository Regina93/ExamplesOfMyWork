using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_problem_of_open_lockers
{
    class Program
    {
        static int multiplicity(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
                if (num % i == 0)
                    count++;

            return count;
        }

        static int countingOfOpenLockers(int countOfLockers)
        {
            int countOfOpenLockers = 0;

            for (int i = 1; i <= countOfLockers; i++)
            {
                int countOfMult = multiplicity(i);

                if(countOfMult % 2 != 0)
                {
                    countOfOpenLockers++;
                    Console.WriteLine("Num of open locker {0}", i);
                }
            }

            return countOfOpenLockers;
        }


        static void Main()
        {
            Console.WriteLine("Please, enter the count of lockers:");
            int countOfLockers;

            try
            {
                countOfLockers = int.Parse(Console.ReadLine());
                Console.WriteLine("\nTotal count of lockers: {0}\n", countOfLockers);
                Console.WriteLine("\nCount of open lockers: {0}", countingOfOpenLockers(countOfLockers));
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n" + e.Message);
                Console.WriteLine("\nERROR: invalid type. Required integer number.\n");
            }

            Console.ReadLine();
        }
    }
}
