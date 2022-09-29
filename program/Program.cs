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