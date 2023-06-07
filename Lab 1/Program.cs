class Program
{
    static Stack<string> playlist = new Stack<string>();
    static Queue<string> songQueue = new Queue<string>();

    static void Main(string[] args)
    {
        int choice = 0;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a song to your playlist");
            Console.WriteLine("2. Play the next song in your playlist");
            Console.WriteLine("3. Skip the next song");
            Console.WriteLine("4. Rewind one song");
            Console.WriteLine("5. Exit");

            Console.Write("> ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSong();
                    break;
                case 2:
                    PlayNextSong();
                    break;
                case 3:
                    SkipNextSong();
                    break;
                case 4:
                    RewindOneSong();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 5);
    }

    static void AddSong()
    {
        Console.WriteLine("Enter Song Name: ");
        string songName = Console.ReadLine();
        playlist.Push(songName);
        Console.WriteLine($"\"{songName}\" added to your playlist.");
    }

    static void PlayNextSong()
    {
        if (playlist.Count > 0)
        {
            string songName = playlist.Pop();
            Console.WriteLine($"Now playing \"{songName}\"");

            if (playlist.Count > 0)
            {
                string nextSong = playlist.Peek();
                Console.WriteLine($"Next song: \"{nextSong}\"");
            }
            else
            {
                Console.WriteLine("Next song: none queued");
            }
        }
        else
        {
            Console.WriteLine("No songs in the playlist.");
        }
    }

    static void SkipNextSong()
    {
        if (playlist.Count > 1)
        {
            playlist.Pop();
            string nextSong = playlist.Peek();
            Console.WriteLine($"Now playing \"{nextSong}\"");
            Console.WriteLine($"Next song: \"{nextSong}\"");
        }
        else
        {
            Console.WriteLine("No songs to skip or no songs in the playlist.");
        }
    }

    static void RewindOneSong()
    {
        if (playlist.Count > 1)
        {
            string currentSong = playlist.Pop();
            string previousSong = playlist.Peek();
            Console.WriteLine($"Now playing \"{previousSong}\"");
            playlist.Push(currentSong);
            Console.WriteLine($"Next song: \"{currentSong}\"");
        }
        else
        {
            Console.WriteLine("No previous song or no songs in the playlist.");
        }
    }
}
