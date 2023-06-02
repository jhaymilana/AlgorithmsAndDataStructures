// Lab 2

using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

// Check a sentence for repeated characters
Console.WriteLine("Enter a sentence to check for repeated letters:");
string inputA = Console.ReadLine();
string lowerInputA = inputA.ToLower();

StringBuilder repeatedCharacters = new StringBuilder();

foreach(char c in lowerInputA)
{
    int count = 0;
    for (int i = 0; i < lowerInputA.Length; i++)
    {
        if ( c == lowerInputA[i])
        {
            count++;
        }
        // Checks for repeated character and if it is already appended to the StringBuilder
        if ( count > 1 && repeatedCharacters.ToString().IndexOf(c) == -1 )  
        {
            repeatedCharacters.Append(c);
        }
    }
}

Console.WriteLine(repeatedCharacters);
Console.WriteLine();

// Check a sentence for unique words
Console.WriteLine("Enter a sentence to check for unique words:");
string inputB = Console.ReadLine();
string[] words = inputB.Split(' ');

StringBuilder uniqueWords = new StringBuilder();

for (int i = 0; i < words.Length; i++)
{
    if (!uniqueWords.ToString().Contains(words[i].ToLower()))
    {
        uniqueWords.Append(words[i].ToLower()).Append(" ");
    }
}

Console.WriteLine(uniqueWords);
Console.WriteLine();

// Reverse a String
Console.WriteLine("Write a sentance to reverse.");
string inputReverse = Console.ReadLine();
StringBuilder reversedStr = new StringBuilder();

for (int i = inputReverse.Length - 1; i >= 0; i--)
{
    reversedStr.Append(inputReverse[i]);
}

Console.WriteLine(reversedStr);
Console.WriteLine();

// Find the largest word in a string and print it

Console.WriteLine("Please enter a sentence to find the longest word:");
string inputC  = Console.ReadLine();
string lowerInputC = inputC.ToLower();
string[] wordsArray = lowerInputC.Split();

StringBuilder longestWords = new StringBuilder();

for (int i = 0; i < wordsArray.Length - 1; i++)
{
    if ( wordsArray[i].Length  > wordsArray[i + 1].Length)
    {
        string longestWord = wordsArray[i];
        longestWords.Append(wordsArray[i]);
    }
}

Console.WriteLine(longestWords);

/*
String Builder vs Strings

Strings in C# is immutable. Thus StringBuilder lets us do much more with strings that wouldn't be possible with just a string.
String builder makes working with strings much easier. There are many methods that can be paired with using StringBuilder for
more simpler and efficient code. 

*/
