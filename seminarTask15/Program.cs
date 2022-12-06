// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Add number");

int day = int.Parse(Console.ReadLine());

if (day > 7)
{
    Console.WriteLine("error");
    return;
}

if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
    Console.WriteLine("weekday");
}
else
{
    Console.WriteLine("weekend");
}


