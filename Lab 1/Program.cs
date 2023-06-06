// Lab 4

// 1. 

int[] nums = new int[3];

int[][] myList = new int[][] 
{            
    new int[] { 1, 5, 3 },
    new int[] { 9, 7, 3, -2 },           
    new int[] { 2, 1, 2 }
};

int[] largestIntegers = myList.Select(sublist => sublist.Max()).ToArray(); // Found on Stack

Console.WriteLine(string.Join(", ", largestIntegers)); Console.WriteLine();

// 1. Bubble

/*

int[][] myList = new int[][] 
{            
    new int[] { 1, 5, 3 },
    new int[] { 9, 7, 3, -2 },           
    new int[] { 2, 1, 2 }
};

int[] highestValues = new int[myList[0].Length];

for (int i = 0; i < myList.Length; i++)
{
    for (int j = 0; j < myList[i].Length; j++)    
    {
        if (myList[i][j] > highestValues[j])        
        {
            highestValues[j] = myList[i][j];       
        }
    }
}

Console.Write("Highest Values: ");

foreach (int num in highestValues)
{
    Console.Write(num + " ");
}

*/

// 2. 

int[][] myGrades = new int[][] 
{            
    new int[] { 85, 92, 67, 94, 94 },
    new int[] { 50, 60, 57, 95 },            
    new int[] { 95 }
};

int highestValue = Int32.MinValue; 
int highestIndex = -1;

for (int i = 0; i < myGrades.Length; i++)
{
    for (int j = 0; j < myGrades[i].Length; j++)
    {
        if (myGrades[i][j] > highestValue)
        {
            highestValue = myGrades[i][j];
            highestIndex = i;
        }
    }
}

Console.WriteLine($"The highest grade is {highestValue} which is found in the class(es) {highestIndex}");
Console.WriteLine();

// 2. Bubble

/*

int[][] myGrades = new int[][] 
{            
    new int[] { 85, 92, 67, 94, 94 },
    new int[] { 50, 60, 57, 95 },            
    new int[] { 95 }
};

int highestValue = Int32.MinValue;
int highestIndex = -1;

for (int i = 0; i < myList.Length; i++)
{
    for (int j = 0; j < myList[i].Length; j++)
    {
        if (myList[i][j] > highestValue)
        {
            highestValue = myList[i][j]; highestIndex = i;
        }
    }
}

Console.WriteLine($"The highest grade is {highestValue} which is found in the class(es) {highestIndex}"); 

*/

// 3. 

int[] mySort = new int[] { 6, -2, 5, 3 };

if (mySort[0] > mySort[1])
{
    int temp = mySort[0];
    mySort[0] = mySort[1]; 
    mySort[1] = temp;
}
if (mySort[1] > mySort[2])
{
    int temp = mySort[1]; 
    mySort[1] = mySort[2];
    mySort[2] = temp;

    if (mySort[0] > mySort[1])
    {
        temp = mySort[0]; 
        mySort[0] = mySort[1];
        mySort[1] = temp;
    }
}

if (mySort[2] > mySort[3])
{
    int temp = mySort[2]; 
    mySort[2] = mySort[3];
    mySort[3] = temp;

    if (mySort[1] > mySort[2])
    {
        temp = mySort[1]; 
        mySort[1] = mySort[2];
        mySort[2] = temp;

        if (mySort[0] > mySort[1])
        {
            temp = mySort[0]; 
            mySort[0] = mySort[1];
            mySort[1] = temp;
        }
    }
}

Console.Write("Sorted List: ");

foreach (int num in mySort)
{
    Console.Write(num + " ");
}

// 3. Bubble

/*

int[] mySort = new int[] { 6, -2, 5, 3 };

for (int i = 0; i < mySort.Length - 1; i++)
{    
    for (int j = 0; j < mySort.Length - 1 - i; j++)
    {
        if (mySort[j] > mySort[j + 1])        
        {
            int temp = mySort[j];            
            mySort[j] = mySort[j + 1];
            mySort[j + 1] = temp;        
        }
    }
}

Console.Write("Sorted List: ");

foreach (int num in mySort)
{
    Console.Write(num + " ");
}

*/