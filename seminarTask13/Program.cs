// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет


Console.Write("Введите число: "); 
int i = int.Parse(Console.ReadLine()); 

if (Math.Abs(i) <= 99) 
{ 
    Console.WriteLine("третьей цифры нет: ");
}
else
{
    string s1 = i.ToString(); 
    if (i > 0) 
        Console.WriteLine(s1[2]); 
    else 
        Console.WriteLine(s1[3]);

}
