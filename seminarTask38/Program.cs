//Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[,] a = new int[1, 5];

Random random = new Random();

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,3}", a[i, j]);
    }
    Console.WriteLine();
}

for (int i = 0; i < a.GetLength(0); i++)
{
    int min = a[i, 0];
    int max = a[i, 0];
    for (int j = 1; j < a.GetLength(1); j++)
    {
        if (a[i, j] < min)
            min = a[i, j];
        if (a[i, j] > max)
            max = a[i, j];
    }
    Console.WriteLine(max - min);
}




