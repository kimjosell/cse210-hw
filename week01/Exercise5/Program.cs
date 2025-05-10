using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();

    int squareNumber = SquareNumber(number);
    DisplayResult(name, squareNumber);

    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number){
        return number * number;
    }

    static void DisplayResult(string name, int squareNumber){
        Console.WriteLine($"Hello {name}, the square of your number is: {squareNumber}");
    }

}