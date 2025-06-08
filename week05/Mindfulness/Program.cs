using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingExercise = new Breathing(
            "Welcome to the Breathing Activity",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            30,
            "Great job! You have completed the Breathing Activity. Remember to take deep breaths throughout your day."
        );


        Reflection reflectionExercise = new Reflection("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30,
            "Great job! You have completed the Reflection Activity. Remember to take time to reflect on your experiences and learn from them.",
            new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult",
                "Think of a time when you helped someone in need",
                "Think of a time when you did something truly selfless."
            },
            new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            }
        );

        Listing listingExercise = new Listing("Welcome to the Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            30,
            "Great job! You have completed the Listing Activity. Remember to take time to appreciate the good things in your life.", new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            }
        );

        bool runProgram = true;

        while (runProgram)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select one of the following activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    breathingExercise.StartBreathingExercise();
                    break;
                case "2":
                    reflectionExercise.StartReflectionExercise();
                    break;
                case "3":
                    listingExercise.ListingExercise();
                    break;
                case "4":
                    runProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}