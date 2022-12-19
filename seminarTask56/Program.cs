// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

int[,] massive = new int[4, 4];
FillArrayRandom(massive);
PrintArray(massive);
Console.WriteLine();
MinSumNumbers(massive);

void MinSumNumbers(int[,] array)
{
    int minString = 0;
    int sumString = 0;
    int minSumString = 0;
    
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        minString += massive[0, i];
    }
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++) sumString += massive[i, j];
        if (sumString < minString)
        {
            minString = sumString;
            minSumString = i;
        }
        sumString = 0;
    }
    Console.Write($"{minSumString + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
