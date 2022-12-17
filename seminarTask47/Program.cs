//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.


double[,] TwoDementionArray(int length, int secondlength)
{
    Random random = new Random();
    double[,] array = new double[length, secondlength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextSingle() * 100 * RandomSymbol();
        }
    }
    return array;
}

int ReadInt()
{
    Console.WriteLine("input number: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int RandomSymbol()
{
    Random random = new Random();
    if (random.Next(10) > 5) return 1;
    return -1;
}

void GetArrayAsString(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:0.##} ", massive[i,j]));
        }
        Console.WriteLine();
    }
}
double[,] massiv = TwoDementionArray(ReadInt(), ReadInt());
Console.WriteLine();
GetArrayAsString(massiv);



