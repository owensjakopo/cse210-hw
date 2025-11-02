using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int yourNumber = -1;
        int guessCount = 0;

        while (yourNumber != magicNumber)
        {
            Console.Write("Guess the magic number between 1 and 100: ");
            yourNumber = int.Parse(Console.ReadLine());
            guessCount++;

            if (yourNumber == magicNumber)
            {
                Console.WriteLine($"You guessed it! It took you {guessCount} tries.");
            }
            else if (yourNumber > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Higher!");
            }
        }
    }
}