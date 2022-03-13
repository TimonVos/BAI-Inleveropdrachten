using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI___InleverOpdrachten___1
{
    public static class Opgave3
    {
        /// <summary>
        /// Generates a stack with random unique numbers
        /// </summary>
        /// <param name="lower">The lowest number in the stack</param>
        /// <param name="upper">The highest number in the stack</param>
        /// <param name="count">The amount of numbers in the stack</param>
        /// <returns>The stack with {count} random numbers</returns>
        public static Stack<int> GenerateRandomUniqueNumbers(int lower, int upper, int count)
        {
            if (count < (upper - lower))
            {
                Random rand = new Random();
                Dictionary<int, int> uniqueNumberChecker = new Dictionary<int, int>();
                Stack<int> randomUniqueNumbers = new Stack<int>();
                int generatedNumber;
                for (int i = 0; i < count; i++)
                {
                    generatedNumber = rand.Next(lower, upper);
                    while (uniqueNumberChecker.ContainsKey(generatedNumber))
                    {
                        generatedNumber = rand.Next(lower, upper);
                    }
                    randomUniqueNumbers.Push(generatedNumber);
                    uniqueNumberChecker.Add(generatedNumber, 1);
                }
                return randomUniqueNumbers;
            }
            else
            {
                Console.WriteLine("Count is more than (Upper - Lower), can't generate a Stack");
                return null;
            }
        }
    }
}
