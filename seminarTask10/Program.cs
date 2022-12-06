// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("ввод трехзначного числа: ");
int number = int.Parse(Console.ReadLine());

int result = number % 100 / 10;
Console.Write($"вторая цифра в числе: {result}");
