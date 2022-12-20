// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

string Numbers(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(Numbers(1, 10));

string Recursion(int a, int b)
{
    if (a <= b) return $"{a} " + Recursion(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(Recursion(ReadInt(), ReadInt()));

int ReadInt()
{
    Console.WriteLine("Add number: ");
    if (int.TryParse(Console.ReadLine(), out int i))
        return i;
    else
    {
        Console.WriteLine("Is not a number: ");
        return -1;
    }

}