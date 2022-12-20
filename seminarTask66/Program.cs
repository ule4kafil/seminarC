// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов
// в промежутке от M до N.

Console.WriteLine("Add number m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Add number n:");
int n = int.Parse(Console.ReadLine());

void SumBetween(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Sum between m and n: {sum}");
        return;
    }
    sum = sum + (m++);
    SumBetween(m, n, sum);
}
SumBetween(m, n, 0);