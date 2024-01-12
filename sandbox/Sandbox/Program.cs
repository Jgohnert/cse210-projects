using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        string value = Console.ReadLine();

        int x = int.Parse(value);
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}