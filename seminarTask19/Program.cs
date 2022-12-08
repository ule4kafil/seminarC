// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.



Console.WriteLine("Add number: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Palindrome");
    }
    else
    {
        Console.WriteLine($"{number} - Not Palindrome");
    }
}
else
{
    Console.WriteLine($"Error: {number} - not five signs");
}






