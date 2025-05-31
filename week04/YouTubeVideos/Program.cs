using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Programming Tutorial", "John Doe", 300, new List<Comment>
        {
            new Comment("Alice", "Great video!"),
            new Comment("Bob", "Very informative."),
            new Comment("Charlie", "Thanks for sharing!")
        });
        Video video2 = new Video("Rick Roled", "Rick Astley", 200, new List<Comment>
        {
            new Comment("Alice", "Never gonna give you up!"),
            new Comment("Bob", "Never gonna let you down!"),
            new Comment("Charlie", "Never gonna run around and desert you!")
        });
        Video video3 = new Video("All Too Well Taylor's Version (10 Minute Version) From The Vault", "Taylor Swift", 600, new List<Comment>
        {
            new Comment("Alice", "This song is a masterpiece!"),
            new Comment("Bob", "Taylor Swift never disappoints."),
            new Comment("Charlie", "The lyrics are so emotional.")
        });
        Video video4 = new Video("Baby One More Time", "Britney Spears", 240, new List<Comment>
        {
            new Comment("Alice", "A classic hit!"),
            new Comment("Bob", "Britney is the queen of pop."),
            new Comment("Charlie", "This song brings back so many memories.")
        });

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine();
        }
    }
}