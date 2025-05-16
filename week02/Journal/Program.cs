using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        prompt._prompts.Add("What was the best part of your day?:");
        prompt._prompts.Add("What was something funny that happened today?:");
        prompt._prompts.Add("What is a thing that you want to remember about today?:");
        prompt._prompts.Add("What is something that you learned today?:");
        prompt._prompts.Add("What is something that you are grateful for today?:");

        Journal journal = new Journal();

        bool runProgram = true;
        
        Console.WriteLine("Welcome to the amazing Journal Program!");
        while (runProgram)
        {

            Console.WriteLine("Please select one of the following options (1-5):");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Quit");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string promptText = prompt.GetRandomPrompt();
                Console.WriteLine(promptText);
                string entryText = Console.ReadLine();
                EntryText newEntry = new EntryText();
                newEntry._date = dateText;
                newEntry._promptText = promptText;
                newEntry._entryText = entryText;
                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added! Do you wanna save it to file? (y/n): ");
                string saveInput = Console.ReadLine();
                if (saveInput == "y")
                {
                    Console.WriteLine("Please enter the file name to save to:");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    Console.WriteLine($"Entries saved to {fileName}");
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Displaying all entries:");
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Please enter the file name to save to:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine($"Entries saved to {fileName}");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Please enter the file name to load from:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine($"Entries loaded from {fileName}");
            }
            else if (userInput == "5")
            {
                runProgram = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }
}