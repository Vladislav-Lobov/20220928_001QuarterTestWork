string[] FillArray(int size)
{
    string input = string.Empty;
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива с индексом {i}");
        do
        {
            input = Console.ReadLine();
        } while (isNotCorrect(input));

        array[i] = input;
    }
    return array;
}

bool isNotCorrect(string symbol)
{
    if (symbol == string.Empty)
    {
        Console.WriteLine("Некорректный ввод, повторите:");
        return true;
    }
    return false;
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

int LengthCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GetNewArray(int size, string[] inputArray)
{
    string[] outputArray = new string[size];
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    return outputArray;
}

Console.WriteLine("Введите размер массива");
bool isNumberSize = int.TryParse(Console.ReadLine(), out int size);

if (isNumberSize == false || size < 1)
{
    Console.WriteLine("Некорректный ввод размера массива");
    return;
}

string[] firstArray = new string[size];
firstArray = FillArray(size);
string[] secondArray = new string[LengthCount(firstArray)];
secondArray = GetNewArray(LengthCount(firstArray), firstArray);
Console.WriteLine("Массив на входе:");
PrintArray(firstArray);
Console.WriteLine("\nМассив на выходе:");
PrintArray(secondArray);

