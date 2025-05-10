using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? ");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);
        bool isGuessed = false;
        do {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);  

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed the magic number!");
                isGuessed = true;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else
            {
                Console.WriteLine("Your guess is too high.");
            }
        } while (!isGuessed);


    }
}