
Console.WriteLine("число");
int i = int.Parse(Console.ReadLine());
int n = 1;
while (n<=i)
{
    int result = n % 2;
    if (result !=1)
    {
        Console.WriteLine("четное + n");
        n++;
    }
    else
    {
        n++;
    }
}
