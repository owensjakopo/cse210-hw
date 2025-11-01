using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score (0-100): ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        if (score < 0 || score > 100)
        {
            Console.WriteLine("Error: Score must be between 0 and 100.");
            return;
        }

        string letter = "";
        string symbol = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";

        }
        else if (score >= 70)
        {
            letter = "C";

        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //the + or minus symbol.
        if (letter != "F")
        {
            int lastDigit = score % 10;
            if (lastDigit >= 7 && letter != "A")
            {
                symbol = "+";
            }
            else if (lastDigit <= 3)
            {
                symbol = "-";
            }
        }


        Console.WriteLine($"Your letter grade is: {letter}{symbol}");
        if (score >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Try again next time!");
        }
    }
}