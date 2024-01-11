using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int number = -1;
        int sum = 0;

        while (number != 0)
        {
            Console.WriteLine("Enter a number for your number list.");
            Console.Write("To stop, enter 0: ");

            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum of the numbers in the list is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average number is {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The biggest number is {max}");
    }
}