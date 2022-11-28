string[] array = { "Happy", "new", "year", "and", "merry", "christmas." };

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"[{array[i]}] ");
    Console.WriteLine();
}

ShowArray(array);

string[] CutStringArray(string[] array)
{
    int length = 0;
    string[] cutArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        length = new Random().Next(0, 4);
        while (array[i].Length > length)
            array[i] = array[i].Remove(0, 1);
        cutArray[i] = array[i];
    }
    return cutArray;
}

Console.WriteLine();
string[] cutArray = CutStringArray(array);
ShowArray(cutArray);
