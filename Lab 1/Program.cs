// Lab 1 - Counting Characters in an array.

Console.WriteLine("Please Enter a Number:");
// Assume for user errors (in this case users can enter letters instead of numbers)
int n = 0;

while (n <= 0)
{
    // Form Validation
    Console.WriteLine("Please enter integer value greater than zero.");
    n = Int32.Parse(Console.ReadLine());
}

string[] words = new string[n];// get console entered amount

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter word {i + 1}");

    string newWord = Console.ReadLine();
    // Users can input null values (entering with no input)
    if (newWord.Length > 0 && !newWord.Contains(" "))
    {
        words[i] = newWord.ToLower();
    }
    else
    {
        Console.WriteLine("Sorry but you must enter at least one character and have no spaces.");
        i--;
    }
}

char charToCount = ' ';

while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("Please enter a character to count.");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
}

// get a count of how many times this character appears in all of the words

int charCount = 0;
int totalCount = 0;

foreach (string word in words)
{
    // changes the word into an array of characters
    char[] chars = word.ToCharArray();

    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            charCount++;
        }
        totalCount++;
    }
}


if ((charCount * 100) / totalCount > 25)
{
    Console.WriteLine($"The character '{charToCount}' appears {charCount} time(s) in the array of words and is more than 25%");
}
else
{
    Console.WriteLine($"The character '{charToCount}' appears {charCount} time(s) in the array of words.");
}
