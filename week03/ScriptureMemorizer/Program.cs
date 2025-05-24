using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference reference2 = new Reference("2 Nephi ", 2, 25);
        Scripture scripture2 = new Scripture(reference2, "Adam fell that men might be; and men are, that they might have joy.");
        Reference reference3 = new Reference("Alma", 32, 21);
        Scripture scripture3 = new Scripture(reference3, "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");

        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(scripture);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);

        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count);
        Scripture scripturechosen = scriptures[randomIndex];

        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine(scripturechosen.GetDisplayText());
            Console.WriteLine("\nPress enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || scripturechosen.IsCompletelyHidden())
            {
                isRunning = false;
            }
            else
            {
                scripturechosen.HideRandomWords(1);
            }

        }
    }
}