// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгортма. 

//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintStringArray(string[] stringArray)
{
    Console.Write("[ ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int SearchStringsWithSizeLessOrEqual3(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
           numberOfStrings++; 
        }
    }
    return numberOfStrings;
}

string[] CreateArrayWithSizeLessOrEqual3(string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
           newStringArray[j] = stringArray[i]; 
           j++;
        }
    }
    return newStringArray;
}

string[] stringArray = { "hello", "word", "2", ":-)"};
PrintStringArray(stringArray);
int sortedNewArray = SearchStringsWithSizeLessOrEqual3(stringArray); 
string[] newStringArray = CreateArrayWithSizeLessOrEqual3(stringArray, sortedNewArray);
Console.Write(" => ");
PrintStringArray(newStringArray);
Console.WriteLine();
