//Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же
//указание, что такого элемента нет.
//Например, задан массив:

int[,] inputTwoDimensionArray(int length, int secondLength)
{
    int[,] mass = new int[length, secondLength];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        FillDimention(i, mass);
    }
    return mass;
}

int ReadInt()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}

void FillDimention(int index, int[,] massive)
{
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        massive[index, i] = new Random().Next(1, 10);
    }
}

void GetArrayAsString(int[,] massive)     
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] massive = inputTwoDimensionArray(5, 5);

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
if (m < massive.GetLength(0) && n < massive.GetLength(1))
{
    Console.WriteLine(massive[m, n]);
}
else
{
    Console.WriteLine("not exist");
}


Console.WriteLine(massive[m, n]);


Task();

void Task()
{
    int[,] array = inputTwoDimensionArray(ReadInt(), ReadInt());
    GetArrayAsString(array);
}


