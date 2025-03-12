using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Super Lotto 6/49!");
            int[] arrayInput = new int[6];
            int[] lottoNums = new int[6];
            int genNum;
            int matchCounter = 0;
            string message = "";
            bool matchNum;
            bool valueChecking;
            Random random = new Random();

            for (int counter = 0; counter < arrayInput.Length; counter++) 
            {
                Console.Write($"Quick pick #{counter + 1}: ");
                int.TryParse(Console.ReadLine(), out arrayInput[counter]);
                message = "";

                if (arrayInput[counter] == 0) 
                {
                    counter--;
                    message = "Invalid input.";
                }

                Console.WriteLine(message);
            }

            for (int counter = 0; counter < lottoNums.Length; counter++)
            {
                valueChecking = false;
                while (valueChecking == false)
                {
                    genNum = random.Next(1, 50);
                    matchNum = false;

                    for (int counter2 = 0; counter2 < lottoNums.Length; counter2++)
                    {
                        if (genNum == lottoNums[counter2])
                        {
                            matchNum = true;
                        }
                    }

                    if (matchNum == false)
                    {
                        lottoNums[counter] = genNum;
                        valueChecking = true;
                    }
                }
            }

            Console.WriteLine($"LOTTO WINNING NUMBERS");
            for (int counter = 0; counter < lottoNums.Length; ++counter)
            { 
                Console.Write($"{lottoNums[counter]} \t");
            }

            for (int counter = 0; counter < lottoNums.Length; ++counter) 
            { 
                for (int inputCounter = 0; inputCounter < arrayInput.Length;)
                {
                    if (arrayInput[counter] == lottoNums[counter])
                    {
                        Console.WriteLine($"{arrayInput[counter]} matches with {lottoNums[counter]}");
                        matchCounter++;
                    }
                }
            }

            if (matchCounter == 6)
            {
                Console.WriteLine($"CONGRATULATIONS, you won Php 50, 413, 109.80");
            }

            else if (matchCounter == 5)
            {
                Console.WriteLine($"CONGRATULATIONS, you won Php 50, 000");
            }

            else if (matchCounter == 4)
            {
                Console.WriteLine($"CONGRATULATIONS, you won Php 1, 200");
            }

            else if (matchCounter == 3)
            {
                Console.WriteLine($"CONGRATULATIONS, you won Php 50");
            }

            else
            {
                Console.WriteLine("Better luck next time.");
            }
            
        }
    }
}
