using System;
using System.Collections.Generic;

namespace Aufgabe_4
{
    // Author: Dirk Mueller
    // Date: 15.03.2021
    //
    // Algorithm:
    // 1. Reserve a list with 6 integer members
    // 2. Create a random number that is larger or equal than 1 and smaller or equal than 49
    // 3. If it does not exist yet in the list, add that number to it
    //
    class DrawNumbers
    {
        int candidateNr;

        // Create a list with a capacity of 6 for the numbers to be drawn:
        List<int> lotteryNumbers = new List<int>(6);
        Random random = new Random();

        public void MakeNumbers()
        {
            // Repeat the following block until 6 numbers were added to the list:
            while (lotteryNumbers.Count < 6)
            {
                // Draw number n with the condition: 1 <= n <= 49:
                // minValue: inclusive lower boundary
                // maxValue: exclusive upper boundary
                candidateNr = random.Next(1, 50);

                // Add random number only if it was not drawn before:
                if (!lotteryNumbers.Contains(candidateNr))
                {
                    lotteryNumbers.Add(candidateNr);
                }
            }
            // Sort the draw:
            lotteryNumbers.Sort();
        }
        public List<int> GetLottoryNumbers()
        {
            return lotteryNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* This program performs a drawing of the lottery 6 out of 49                   *");
            Console.WriteLine("********************************************************************************");

            // Instantiate a new instance of lottery class:
            DrawNumbers draw = new DrawNumbers();
            // Do the draw:
            draw.MakeNumbers();

            foreach (int item in draw.GetLottoryNumbers())
            {
                Console.Write(item + " | ");
            }
            Console.ReadKey();
        }
    }
}
