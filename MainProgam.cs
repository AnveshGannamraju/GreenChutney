using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            #region IMessageFIFOQueue

            /*IMessageFIFOQueue messQueue = new MessageFIFOQueue();
            int TotalMessagesInQueue = messQueue._countMessagesInQueue(string.Empty);
            for (int i = 1; i <= 10; i++)
            {
                FIFOMessage message = new FIFOMessage()
                {
                    messageBody = "hello I am message  " + i.ToString()
                };
                messQueue.WriteMessage(message);
            }
            TotalMessagesInQueue = messQueue._countMessagesInQueue(string.Empty);
            FIFOMessage messageResponse = messQueue.ReadMessage(string.Empty);*/
            #endregion
            //Console.WriteLine("Hello World!");
            #region missNumFindArray
            MissNumFindArray missNumFindArray = new MissNumFindArray();
            int[] numFind = new int[]{
1,2,3,4,5,6,7,8,10,11
            };
            int missingNumber = missNumFindArray.FindMissingNumber(numFind, 1, 11);
            #endregion
            int[] arrNumbers = GetNumbersfromConsole();
            BasicSort _bsSort = new BasicSort();
            int[] result = _bsSort.Sort(arrNumbers);
            Console.WriteLine("------------------");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i].ToString() + " ");
            }
            Console.Read();
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
            Console.WriteLine("Enter {0} numbers", sizeOfArray);
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
