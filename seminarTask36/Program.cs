// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

int length = 4;
int[] array = new int[length];

Random rnd = new Random();

int sum = 0;

for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(1, 99);

    if (array[i] % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine(sum);


