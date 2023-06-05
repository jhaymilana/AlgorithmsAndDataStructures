// Lab 3

// 1. 
List<int> intArr = new List<int> { 1, 2, 3, 4, 7, 9, 2, 4 };
HashSet<int> uniqueVal = new HashSet<int>();
Dictionary<int, int> multiples = new Dictionary<int, int>();

foreach(int interger  in intArr)
{
    uniqueVal.Add(interger);
}

foreach(int interger in uniqueVal)
{
    multiples.Add(interger, 0);
}

foreach (int interger in intArr)
{
    if (multiples.ContainsKey(interger))
    {
        multiples[interger]++;
    }
}

foreach (KeyValuePair<int, int> keyValuePair in multiples)
{
    if (keyValuePair.Value > 1)
    {
        Console.WriteLine($"{keyValuePair.Key}");
    }
}

Console.WriteLine();

// 2.

int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 2, 5, 7, 9, 13 };

int[] arr3 = new int[arr1.Length + arr2.Length];
int i = 0, j = 0, k = 0;

while (i < arr1.Length && j < arr2.Length)
{
    if (arr1[i] < arr2[j])
    {
        arr3[k] = arr1[i];
        i++;
    }
    else
    {
        arr3[k] = arr2[j];
        j++;
    }
    k++;
}

while (i < arr1.Length)
{
    arr3[k] = arr1[i];
    i++;
    k++;
}

while (j < arr2.Length)
{
    arr3[k] = arr2[j];
    j++;
    k++;
}

foreach (int num in arr3)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine();

// 3. 

int orgInt = 3415;
int reversedInt = 0;

for (int num = orgInt; num != 0; num /= 10)
{
    int digit = num % 10;
    reversedInt = (reversedInt * 10) + digit;
}

Console.WriteLine(reversedInt);
