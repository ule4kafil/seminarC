// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A(3, 6, 8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53


Console.WriteLine("Введите посследовательность координат: ");

double ax = double.Parse(Console.ReadLine()!);
double ay = double.Parse(Console.ReadLine()!);
double az = double.Parse(Console.ReadLine()!);
double bx = double.Parse(Console.ReadLine()!);
double by = double.Parse(Console.ReadLine()!);
double bz = double.Parse(Console.ReadLine()!);


double ab = Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2);

ab = Math.Sqrt (ab);

System.Console.WriteLine(ab);



