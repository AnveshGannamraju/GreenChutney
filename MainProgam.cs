using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arrNumbers = GetNumbersfromConsole();
            BasicSort _bsSort = new BasicSort();
            int[] result = _bsSort.Sort(arrNumbers);
            Console.WriteLine("------------------");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i].ToString() + " ");
            }
        }
        private static int[] GetNumbersfromConsole()
        {
            Console.WriteLine("Total number to sort");
            string readConsole = Console.ReadLine();
            Console.WriteLine("------------------");
            int sizeOfArray = 0;
            if (!int.TryParse(readConsole, out sizeOfArray))
            {
                Console.WriteLine("Invalid number provided");
            }
            int[] arrNumbers = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                int _number = 0;
                string readConsole1 = Console.ReadLine();
                if (!int.TryParse(readConsole1, out _number))
                {
                    Console.WriteLine("Invalid number provided");
                }
                arrNumbers[i] = _number;
            }
            return arrNumbers;
        }
    }
}
