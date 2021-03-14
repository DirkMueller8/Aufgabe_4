using System;
using System.Collections.Generic;

namespace Aufgabe_4
{
    // Author: Dirk Mueller
    // Date: 14.03.2021
    //
    // Algorithm:
    // 1. Convert all characters of the given string to lower case
    // 2. Iterate through the string and check if each character is a vowel
    // 3. If so, increment the counter
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
