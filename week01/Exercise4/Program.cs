using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        string input;
        int number = 1;
        while (number != 0){
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if(number == 0){
                break;
            }
            numbers.Add(number);
        };

        int sum = 0;
        int larNumber = numbers[0];
        foreach(int num in numbers){
            sum += num;
            if(num > larNumber){
                larNumber = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / (numbers.Count);

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The minimum number is: {larNumber}");


    }
}