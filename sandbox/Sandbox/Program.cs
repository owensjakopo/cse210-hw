using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Student student = new Student("Owen", "1994");
        string name = student.GetName();
        string number = student.GetNumber();

        Console.WriteLine($"{name}\n{number}");
    }
}