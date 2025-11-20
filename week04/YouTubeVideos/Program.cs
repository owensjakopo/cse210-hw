using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();

        List<string> randomTitles = new List<string>()
        {
            "Let's Talk C#",
            "Understanding Abstraction",
            "Understanding Encapsulation",
            "Consructors in C#",
            "Instance vs Static Methods"
        };

        List<string> randomNames = new List<string>()
        {
            "OJ", "XTzv", "CodeKing", "Nerd10", "Ajax",
            "BenzoBeats", "Code Morgan", "BigMinds", "LeviTech", "SyntaxOJ"
        };

        List<string> randomComments = new List<string>()
        {
            "Great explanation on C#! Very helpful.",
            "This video clarified a lot of my doubts about this.",
            "This is so much clearer now, thanks!",
            "I love the examples used in these videos.",
            "Can you make a video on design patterns next?",
            "Found a typo at 3:45, but overall great content!",
            "Subscribed! Looking forward to more videos like this.",
            "The pacing of the video was perfect for learning.",
            "Can you provide more resources in the description?",
            "This channel is my go-to for C# tutorials."
        };

        Comment GenerateRandomComment()
        {
            string name = randomNames[random.Next(randomNames.Count)];
            string text = randomComments[random.Next(randomComments.Count)];

            return new Comment(name, text);
        }

        Video GenerateRandomVideo()
        {
            string title = randomTitles[random.Next(randomTitles.Count)];
            string author = randomNames[random.Next(randomNames.Count)];
            int length = random.Next(300, 1201);

            return new Video(title, author, length);
        }



        Video video1 = GenerateRandomVideo();
        Video video2 = GenerateRandomVideo();
        Video video3 = GenerateRandomVideo();

        int video1Comments = random.Next(2, 4);
        int video2Comments = random.Next(1, 3);
        int video3Comments = random.Next(2, 5);

        Video[] videos = { video1, video2, video3};
        int[] commentsCount = { video1Comments, video2Comments, video3Comments};

        for (int i = 0; i < videos.Length; i++)
        {
            for (int j = 0; j < commentsCount[i]; j++)
            {
                videos[i].AddComment(GenerateRandomComment());
            }
        }
        
        video1.Display();
        Console.WriteLine();
        video2.Display();
        Console.WriteLine();
        video3.Display();
    }
}