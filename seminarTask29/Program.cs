// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

int[] array = new int[8];
Random myRandom = new Random();

Console.WriteLine("Profit");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 99);
    Console.Write("{0} ", array[i]);
}
Console.ReadKey();