using System;

class Program
{
    static void Main(string[] args)
    {
        Running r = new Running(new DateTime(2025, 6, 1), 30, 5.0);
        Cycling c = new Cycling(new DateTime(2025, 6, 2), 45, 15.0);
        Swimming s = new Swimming(new DateTime(2025, 6, 3), 60, 1000);

        Console.WriteLine(r.GetSummary());
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(s.GetSummary());
    }
}