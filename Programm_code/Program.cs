Console.Clear();

string[] array1 = new string[9] { "one", "2", "three", "the", "world", "is", "yours", "!", ":))" };
Console.WriteLine("First Array:");
Console.WriteLine();
for (int i = 0; i < 9; i++)
{
    {
        Console.Write("{0}, ", array1[i]);
    }
}
Console.WriteLine();

string[] array2 = new string[array1.Length];
Console.WriteLine("\nSecond Array with string's length <=3 characters:\n");
FillSecondArray(array1, array2);
PrintArray(array2);

void FillSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.WriteLine();