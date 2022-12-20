// Напишите программу вычисления функции Аккермана с
// помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadInt()
{
    Console.WriteLine("Add number: ");
    string s = Console.ReadLine();
    if (int.TryParse(s, out int i))
        return i;
    return -1;
}
{
    int AckermannFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
        if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return AckermannFunction(m, n);
    }
    Console.WriteLine("Add numbers for Ackermann Function");
    Console.WriteLine($"A(m,n) = {AckermannFunction(ReadInt(), ReadInt())}");
}