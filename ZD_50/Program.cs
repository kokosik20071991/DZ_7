Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Нет такого элемента");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно: {numbers[n - 1, m - 1]}");
    Console.WriteLine();
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}