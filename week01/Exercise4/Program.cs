using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers and type 0 when done: ");
        Console.WriteLine();
        

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();

            number = int.Parse(response);


            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        
        int sum = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();

        Console.WriteLine();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        
       }  
}