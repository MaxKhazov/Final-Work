

Console.WriteLine("Введите любые символы, чтобы заполнить массив.");
Console.WriteLine("Элемент массива 1/4:");
string? Element1 = Console.ReadLine();
Console.WriteLine("Элемент массива 2/4:");
string? Element2 = Console.ReadLine();
Console.WriteLine("Элемент массива 3/4:");
string? Element3 = Console.ReadLine();
Console.WriteLine("Элемент массива 4/4:");
string? Element4 = Console.ReadLine();

string?[] StringArray = new string?[] { Element1, Element2, Element3, Element4 };
Console.Write("Новый массив из строк, в которых 3, либо меньше символов: ");
CreateNewArray(StringArray);


void CreateNewArray(string?[] arr)
{
    string?[] NewArray = new string?[4];
    for (int i = 0; i < arr.Length; i++)
    {
        int Length = arr[i].Length;
        if (Length <= 3)
        {
            NewArray[i] = arr[i];
        }
        Console.Write($"({NewArray[i]}) ");
    }

}