using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Enter the last number: ");
            int userValue = int.Parse(Console.ReadLine());

            string guess;

            int value = random.Next(0,userValue);

            Console.WriteLine("Try to guess a number: ");
            Console.WriteLine("Enter your value or push F to exit...");
            while (true)
            {
 
                guess = Console.ReadLine();

                if(guess == "f")
                {
                    Console.WriteLine($"The number was: {value} , better luck next time!");
                    break;
                }

                int num = int.Parse(guess);

                if(num < value)
                {
                    Console.WriteLine("Entered number is less!");
                }

                else
                {
                    if(num > value)
                    {
                        Console.WriteLine("Entered number is more!");
                    }

                    else
                    {
                        Console.WriteLine("You guessed!");
                        break;
                    }
                }
            }
        }
    }
}
