using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to the Memorizer App!");

        Scripture startVerse = new Scripture("Moroni 10:4", "And when ye shall receive these things, I would\n exhort you that ye would ask God, the Eternal Father,\n in the name of Christ, if these things are \nnot true; and if ye shall ask with a \nsincere heart, with real intent, having faith in Christ, \nhe will manifest the truth of it unto you, by \nthe power of the Holy Ghost\n");


        Scripture endVerse = new Scripture("Moroni 10:5", "And by the power of the Holy Ghost ye\n may know the truth of all things.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(startVerse.GetDisplayText());
            Console.WriteLine(endVerse.GetDisplayText());

            if (startVerse.IsCompletelyHidden() && endVerse.IsCompletelyHidden())
            {
                Console.WriteLine("\nYou have completely memorized both verses!");
                Console.WriteLine("Thank you for using our Memorizer App!");
                
                break;
            }
                
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            startVerse.HideRandomWords(3);
            endVerse.HideRandomWords(2);
        }
    }
}