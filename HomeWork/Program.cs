string[] GetNewArray(string[] newArray)
{
    int lengthNewArray = 0;

    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3) 
        {
            lengthNewArray++;
        }
    }

    string[] resultArray = new string[lengthNewArray];
    int j = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3) 
        {
            resultArray[j] = newArray[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}

string[] newArray = {"Hello", "2", "World", ":-)"};
string[] resultArray = GetNewArray(newArray);
PrintArray(newArray);
Console.Write(" -> ");
PrintArray(resultArray);
Console.WriteLine();




