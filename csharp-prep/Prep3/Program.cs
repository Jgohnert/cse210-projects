using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 1000);

        int userGuess = 0;

        while (userGuess != number)
        {
            Console.Write("Guess the number: ");
            string chosenNumber = Console.ReadLine();

            int x = int.Parse(chosenNumber);

            if (x > number)
            {
                Console.WriteLine("Guess lower");
            }
            else if (x < number)
            {
                Console.WriteLine("Guess Higher");
            }
            else
            {
                Console.WriteLine($"Correct! The correct number is {number}");
            }
        }

    }
}