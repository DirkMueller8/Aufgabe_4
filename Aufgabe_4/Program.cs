using System;
using System.Collections.Generic;

namespace Aufgabe_4
{
    // Author: Dirk Mueller
    // Date: 15.03.2021
    //
    // Algorithm:
    // 1. Reserve a list with 6 integer members
    // 2. Create a random number that is larger or equal than 1 and smaller of equal than 49
    // 3. If it does not exist yet in the list, add that number to it
    // 4. 
    class DrawNumbers
    {
        int candidateNr;

        List<int> lottoZahlen = new List<int>(6);
        Random random = new Random();

        public void MakeNumbers()
        {
            while (lottoZahlen.Count < 6)
            {
                candidateNr = random.Next(1, 50);
                if (!lottoZahlen.Contains(candidateNr))
                {
                    lottoZahlen.Add(candidateNr);
                }
            }
            foreach (var item in lottoZahlen)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* This program performs a drawing of the lottery 6 out of 49                   *");
            Console.WriteLine("********************************************************************************");

            DrawNumbers draw = new DrawNumbers();
            draw.MakeNumbers();
        }
    }
}
