using System;

namespace number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            int guesses = 0;

            Console.WriteLine("I picked a number, can you guess what it is? Pick a number from 1-100:");

            var input = Console.ReadLine();
            while (int.Parse(input) != num)
            {
                if (int.Parse(input) > num)
                {
                    Console.WriteLine("Your number was too high, guess again!");
                    guesses++;
                    input = Console.ReadLine();
                }
                else if (int.Parse(input) < num)
                {
                    Console.WriteLine("Your number was too low, guess again!");
                    guesses++;
                    input = Console.ReadLine();
                }

            }
            guesses++;
            Console.WriteLine($"Congrats, you picked the right number! It only took you {guesses} guesses.");
        }
    }
}
